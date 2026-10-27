using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065CD RID: 26061
	public class FishingLevelUpView : UiViewBase
	{
		// Token: 0x060415DA RID: 267738 RVA: 0x00FD72CB File Offset: 0x00FD54CB
		[NullableContext(1)]
		public FishingLevelUpView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060415DB RID: 267739 RVA: 0x00FD72D4 File Offset: 0x00FD54D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060415DC RID: 267740 RVA: 0x00FD73BC File Offset: 0x00FD55BC
		protected override void OnStart()
		{
			FishingLevelUpData fishingLevelUpData = this.OpenParam as FishingLevelUpData;
			bool isMax = fishingLevelUpData.IsCurrentLevelMax();
			this.RefreshView(fishingLevelUpData.LastLevel, fishingLevelUpData.CurrentLevel, isMax);
		}

		// Token: 0x060415DD RID: 267741 RVA: 0x00FD73F0 File Offset: 0x00FD55F0
		private void RefreshView(int lastLevel, int currentLevel, bool isMax)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Fishing_LevelUpTip", new <>z__ReadOnlySingleElementList<object>(lastLevel));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Fishing_LevelUpTip", new <>z__ReadOnlySingleElementList<object>(currentLevel));
			base.GetItem(3).SetUIActive(isMax);
		}

		// Token: 0x060415DE RID: 267742 RVA: 0x00FD744C File Offset: 0x00FD564C
		private void OnClickButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200C7F5 RID: 51189
		private class EComponents
		{
			// Token: 0x0403C63F RID: 247359
			public const int Button = 0;

			// Token: 0x0403C640 RID: 247360
			public const int TxtLast = 1;

			// Token: 0x0403C641 RID: 247361
			public const int TxtCurrent = 2;

			// Token: 0x0403C642 RID: 247362
			public const int MaxItem = 3;
		}
	}
}
