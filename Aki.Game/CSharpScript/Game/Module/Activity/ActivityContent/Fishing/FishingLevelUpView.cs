using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200554B RID: 21835
	public class FishingLevelUpView : UiViewBase
	{
		// Token: 0x0603629F RID: 221855 RVA: 0x00F1E30B File Offset: 0x00F1C50B
		[NullableContext(1)]
		public FishingLevelUpView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060362A0 RID: 221856 RVA: 0x00F1E314 File Offset: 0x00F1C514
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

		// Token: 0x060362A1 RID: 221857 RVA: 0x00F1E3FC File Offset: 0x00F1C5FC
		protected override void OnStart()
		{
			FishingLevelUpData fishingLevelUpData = this.OpenParam as FishingLevelUpData;
			bool isMax = fishingLevelUpData.IsCurrentLevelMax();
			this.RefreshView(fishingLevelUpData.LastLevel, fishingLevelUpData.CurrentLevel, isMax);
		}

		// Token: 0x060362A2 RID: 221858 RVA: 0x00F1E430 File Offset: 0x00F1C630
		private void RefreshView(int lastLevel, int currentLevel, bool isMax)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Fishing_LevelUpTip", new <>z__ReadOnlySingleElementList<object>(lastLevel));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Fishing_LevelUpTip", new <>z__ReadOnlySingleElementList<object>(currentLevel));
			base.GetItem(3).SetUIActive(isMax);
		}

		// Token: 0x060362A3 RID: 221859 RVA: 0x00F1E48C File Offset: 0x00F1C68C
		private void OnClickButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200B1D8 RID: 45528
		private class EComponents
		{
			// Token: 0x04036F8D RID: 225165
			public const int Button = 0;

			// Token: 0x04036F8E RID: 225166
			public const int TxtLast = 1;

			// Token: 0x04036F8F RID: 225167
			public const int TxtCurrent = 2;

			// Token: 0x04036F90 RID: 225168
			public const int MaxItem = 3;
		}
	}
}
