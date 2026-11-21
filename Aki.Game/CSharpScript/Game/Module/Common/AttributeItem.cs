using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02004B20 RID: 19232
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AttributeItem : GridProxyAbstract<AttributeData>
	{
		// Token: 0x060301B5 RID: 197045 RVA: 0x00D6B05C File Offset: 0x00D6925C
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

		// Token: 0x060301B6 RID: 197046 RVA: 0x00D6B149 File Offset: 0x00D69349
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

		// Token: 0x060301B7 RID: 197047 RVA: 0x00D6B16C File Offset: 0x00D6936C
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

		// Token: 0x060301B8 RID: 197048 RVA: 0x00D6B1D6 File Offset: 0x00D693D6
		public void UpdateParam(int id, bool isRatio)
		{
			this.Id = id;
			this.IsRatio = isRatio;
			this.InitCommon();
		}

		// Token: 0x060301B9 RID: 197049 RVA: 0x00D6B1EC File Offset: 0x00D693EC
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

		// Token: 0x060301BA RID: 197050 RVA: 0x00D6B234 File Offset: 0x00D69434
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

		// Token: 0x060301BB RID: 197051 RVA: 0x00D6B290 File Offset: 0x00D69490
		public void SetNextItemActive(bool bActive)
		{
			UUIItem nextItem = this.NextItem;
			if (nextItem != null)
			{
				nextItem.SetUIActive(bActive);
			}
			base.GetText(3).SetUIActive(bActive);
		}

		// Token: 0x060301BC RID: 197052 RVA: 0x00D6B2B1 File Offset: 0x00D694B1
		public int GetAttributeId()
		{
			return this.Id;
		}

		// Token: 0x060301BD RID: 197053 RVA: 0x00D6B2BC File Offset: 0x00D694BC
		public virtual void SetBgActive(bool bActive)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(bActive);
			}
		}

		// Token: 0x060301BE RID: 197054 RVA: 0x00D6B2DC File Offset: 0x00D694DC
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

		// Token: 0x060301BF RID: 197055 RVA: 0x00D6B31C File Offset: 0x00D6951C
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

		// Token: 0x040197FB RID: 104443
		[Nullable(2)]
		protected UUIItem NextItem;

		// Token: 0x040197FC RID: 104444
		private string CurrentValue = "";

		// Token: 0x040197FD RID: 104445
		private int Id;

		// Token: 0x040197FE RID: 104446
		private bool IsRatio;

		// Token: 0x0200A77B RID: 42875
		[NullableContext(0)]
		private class EAttributeItemDefine
		{
			// Token: 0x04033C19 RID: 211993
			public const int Name = 0;

			// Token: 0x04033C1A RID: 211994
			public const int CurrentValue = 1;

			// Token: 0x04033C1B RID: 211995
			public const int NextItem = 2;

			// Token: 0x04033C1C RID: 211996
			public const int NextValue = 3;

			// Token: 0x04033C1D RID: 211997
			public const int Icon = 4;

			// Token: 0x04033C1E RID: 211998
			public const int Bg = 5;
		}
	}
}
