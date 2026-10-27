using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02005B3F RID: 23359
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AttributeItem : GridProxyAbstract<AttributeData>
	{
		// Token: 0x0603B243 RID: 242243 RVA: 0x00E1A344 File Offset: 0x00E18544
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B244 RID: 242244 RVA: 0x00E1A431 File Offset: 0x00E18631
		protected override void OnStart()
		{
			this.NextItem = base.GetItem(2);
			UUIItem nextItem = this.NextItem;
			if (nextItem == null)
			{
				return;
			}
			nextItem.SetUIActive(false);
		}

		// Token: 0x0603B245 RID: 242245 RVA: 0x00E1A454 File Offset: 0x00E18654
		private void InitCommon()
		{
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(this.Id);
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew(propertyIndexInfo.Value.Name);
			}
			UUITexture texture = base.GetTexture(4);
			if (texture != null)
			{
				base.SetTextureByPath(propertyIndexInfo.Value.Icon, texture, null, null);
			}
		}

		// Token: 0x0603B246 RID: 242246 RVA: 0x00E1A4BE File Offset: 0x00E186BE
		public void UpdateParam(int id, bool isRatio)
		{
			this.Id = id;
			this.IsRatio = isRatio;
			this.InitCommon();
		}

		// Token: 0x0603B247 RID: 242247 RVA: 0x00E1A4D4 File Offset: 0x00E186D4
		public void SetCurrentValue(float currentValue)
		{
			string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(this.Id, (double)currentValue, this.IsRatio);
			this.CurrentValue = formatAttributeValueString;
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(this.CurrentValue, true);
		}

		// Token: 0x0603B248 RID: 242248 RVA: 0x00E1A51C File Offset: 0x00E1871C
		public void SetNextValue(float nextValue)
		{
			string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(this.Id, (double)nextValue, this.IsRatio);
			if (!string.IsNullOrEmpty(this.CurrentValue) && this.CurrentValue == formatAttributeValueString)
			{
				this.SetNextItemActive(false);
				return;
			}
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText(formatAttributeValueString, true);
		}

		// Token: 0x0603B249 RID: 242249 RVA: 0x00E1A578 File Offset: 0x00E18778
		public void SetNextItemActive(bool bActive)
		{
			UUIItem nextItem = this.NextItem;
			if (nextItem != null)
			{
				nextItem.SetUIActive(bActive);
			}
			base.GetText(3).SetUIActive(bActive);
		}

		// Token: 0x0603B24A RID: 242250 RVA: 0x00E1A599 File Offset: 0x00E18799
		public int GetAttributeId()
		{
			return this.Id;
		}

		// Token: 0x0603B24B RID: 242251 RVA: 0x00E1A5A4 File Offset: 0x00E187A4
		public virtual void SetBgActive(bool bActive)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(bActive);
			}
		}

		// Token: 0x0603B24C RID: 242252 RVA: 0x00E1A5C4 File Offset: 0x00E187C4
		public void RefreshNameByAnotherName()
		{
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(this.Id);
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(propertyIndexInfo.Value.AnotherName);
		}

		// Token: 0x0603B24D RID: 242253 RVA: 0x00E1A604 File Offset: 0x00E18804
		public override void Refresh(AttributeData data, bool isSelected, int gridIndex)
		{
			this.UpdateParam(data.Id, data.IsRatio);
			this.SetCurrentValue(data.CurValue);
			this.SetNextItemActive(data.ShowNext.GetValueOrDefault());
			if (data.NextValue != null)
			{
				this.SetNextValue(data.NextValue.Value);
			}
			if (data.UseAnotherName != null && data.UseAnotherName.Value)
			{
				this.RefreshNameByAnotherName();
			}
			this.SetBgActive(data.BgActive.GetValueOrDefault());
		}

		// Token: 0x0401ED3F RID: 126271
		[Nullable(2)]
		protected UUIItem NextItem;

		// Token: 0x0401ED40 RID: 126272
		private string CurrentValue = "";

		// Token: 0x0401ED41 RID: 126273
		private int Id;

		// Token: 0x0401ED42 RID: 126274
		private bool IsRatio;

		// Token: 0x0200BD72 RID: 48498
		[NullableContext(0)]
		private class EAttributeItemDefine
		{
			// Token: 0x0403924D RID: 234061
			public const int Name = 0;

			// Token: 0x0403924E RID: 234062
			public const int CurrentValue = 1;

			// Token: 0x0403924F RID: 234063
			public const int NextItem = 2;

			// Token: 0x04039250 RID: 234064
			public const int NextValue = 3;

			// Token: 0x04039251 RID: 234065
			public const int Icon = 4;

			// Token: 0x04039252 RID: 234066
			public const int Bg = 5;
		}
	}
}
