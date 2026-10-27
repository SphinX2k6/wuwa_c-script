using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060CE RID: 24782
	[NullableContext(1)]
	[Nullable(0)]
	internal class SolarSpeedRewardPanel : UiPanelBase
	{
		// Token: 0x0603EA7C RID: 256636 RVA: 0x00F21D90 File Offset: 0x00F1FF90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EA7D RID: 256637 RVA: 0x00F21E3C File Offset: 0x00F2003C
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedRewardPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedRewardPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA7E RID: 256638 RVA: 0x00F21E7F File Offset: 0x00F2007F
		protected override void OnStart()
		{
			this.RefreshByOpenParam();
		}

		// Token: 0x0603EA7F RID: 256639 RVA: 0x00F21E88 File Offset: 0x00F20088
		public void RefreshByOpenParam()
		{
			ISolarSpeedRewardPanelData solarSpeedRewardPanelData = this.OpenParam as ISolarSpeedRewardPanelData;
			this.TabLayout.RefreshByData(solarSpeedRewardPanelData.TabDataList, null, false);
			this.RewardLayout.RefreshByData(solarSpeedRewardPanelData.RewardDataList, null, false);
		}

		// Token: 0x0603EA80 RID: 256640 RVA: 0x00F21EC7 File Offset: 0x00F200C7
		public void PlayStart(string animName)
		{
			(base.GetVerticalLayout(2).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController).Play(animName, -1, false);
		}

		// Token: 0x0603EA81 RID: 256641 RVA: 0x00F21EF1 File Offset: 0x00F200F1
		private SolarSpeedTabCellPanel BuildSolarSpeedTabCellPanel()
		{
			return new SolarSpeedTabCellPanel();
		}

		// Token: 0x0603EA82 RID: 256642 RVA: 0x00F21EF8 File Offset: 0x00F200F8
		private SolarSpeedRewardCellPanel BuildSolarSpeedRewardCellPanel()
		{
			return new SolarSpeedRewardCellPanel();
		}

		// Token: 0x04020C16 RID: 134166
		private GenericLayout<SolarSpeedTabCellPanel, ISolarSpeedTabCellPanelData> TabLayout;

		// Token: 0x04020C17 RID: 134167
		private GenericLayout<SolarSpeedRewardCellPanel, ISolarSpeedRewardCellPanelData> RewardLayout;

		// Token: 0x0200C320 RID: 49952
		[NullableContext(0)]
		private class ERewardComponent
		{
			// Token: 0x0403AEAF RID: 241327
			public const int TabContentLayout = 0;

			// Token: 0x0403AEB0 RID: 241328
			public const int TabCellItem = 1;

			// Token: 0x0403AEB1 RID: 241329
			public const int RewardContentLayout = 2;

			// Token: 0x0403AEB2 RID: 241330
			public const int RewardCellItem = 3;
		}
	}
}
