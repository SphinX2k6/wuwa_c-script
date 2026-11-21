using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059C6 RID: 22982
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolUnlockConditionItem : GridProxyAbstract<IActivityConditionData>
	{
		// Token: 0x06038A4C RID: 232012 RVA: 0x00FD9B70 File Offset: 0x00FD7D70
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnAccessClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnAccessClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038A4D RID: 232013 RVA: 0x00FD9D68 File Offset: 0x00FD7F68
		[NullableContext(1)]
		public override void Refresh(IActivityConditionData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			bool isFinished = data.IsFinished;
			bool flag = data.AccessType == 7;
			bool flag2 = data.AccessType == 16;
			bool flag3 = data.AccessId == 0;
			base.GetItem(0).SetUIActive(isFinished);
			base.GetItem(1).SetUIActive(!isFinished && flag);
			base.GetItem(2).SetUIActive(!isFinished && !flag);
			UUIText text = base.GetText(6);
			if (!StringUtils.IsEmpty(data.ConditionTextId))
			{
				text.ShowTextNew(data.ConditionTextId);
			}
			else
			{
				text.SetText(string.Empty, true);
			}
			UUIItem uuiitem = text;
			bool bUseChangeColor = isFinished;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.GetItem(8).SetUIActive(isFinished);
			base.GetItem(9).SetUIActive(!isFinished && flag3);
			base.GetButton(7).RootUIComp.Get().SetUIActive(!isFinished && !flag3 && !flag2);
			base.GetButton(10).RootUIComp.Get().SetUIActive(!isFinished && !flag3 && flag2);
			this.RefreshExtra(data as SolarSchoolUnlockConditionData);
		}

		// Token: 0x06038A4E RID: 232014 RVA: 0x00FD9E9C File Offset: 0x00FD809C
		private void RefreshExtra(SolarSchoolUnlockConditionData data)
		{
			if (data == null)
			{
				return;
			}
			UUIText text = base.GetText(5);
			if (!StringUtils.IsEmpty(data.TitleId))
			{
				text.ShowTextNew(data.TitleId);
			}
			bool flag = !StringUtils.IsEmpty(data.IconPath);
			base.GetItem(4).SetUIActive(flag);
			if (flag)
			{
				base.SetTextureByPath(data.IconPath, base.GetTexture(4), null, null);
			}
		}

		// Token: 0x06038A4F RID: 232015 RVA: 0x00FD9F0A File Offset: 0x00FD810A
		private void OnAccessClick()
		{
			if (this.Data == null || this.Data.AccessId == 0)
			{
				return;
			}
			SkipTaskManager.RunByConfigId(this.Data.AccessId, null);
		}

		// Token: 0x0401DD3A RID: 122170
		private IActivityConditionData Data;

		// Token: 0x0200B577 RID: 46455
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040381CC RID: 229836
			public const int PnlDone = 0;

			// Token: 0x040381CD RID: 229837
			public const int PnlPreQuest = 1;

			// Token: 0x040381CE RID: 229838
			public const int PnlOther = 2;

			// Token: 0x040381CF RID: 229839
			public const int SprFrame = 3;

			// Token: 0x040381D0 RID: 229840
			public const int TexIcon = 4;

			// Token: 0x040381D1 RID: 229841
			public const int TxtTitle = 5;

			// Token: 0x040381D2 RID: 229842
			public const int TxtContent = 6;

			// Token: 0x040381D3 RID: 229843
			public const int BtnGoto = 7;

			// Token: 0x040381D4 RID: 229844
			public const int SprDone = 8;

			// Token: 0x040381D5 RID: 229845
			public const int TxtUnDone = 9;

			// Token: 0x040381D6 RID: 229846
			public const int BtnHelp = 10;
		}
	}
}
