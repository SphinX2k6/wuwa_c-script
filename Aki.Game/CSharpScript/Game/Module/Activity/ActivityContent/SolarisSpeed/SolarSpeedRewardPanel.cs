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
	// Token: 0x0200504C RID: 20556
	[NullableContext(1)]
	[Nullable(0)]
	internal class SolarSpeedRewardPanel : UiPanelBase
	{
		// Token: 0x06033740 RID: 210752 RVA: 0x00E68B60 File Offset: 0x00E66D60
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

		// Token: 0x06033741 RID: 210753 RVA: 0x00E68C0C File Offset: 0x00E66E0C
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedRewardPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedRewardPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033742 RID: 210754 RVA: 0x00E68C4F File Offset: 0x00E66E4F
		protected override void OnStart()
		{
			this.RefreshByOpenParam();
		}

		// Token: 0x06033743 RID: 210755 RVA: 0x00E68C58 File Offset: 0x00E66E58
		public void RefreshByOpenParam()
		{
			ISolarSpeedRewardPanelData solarSpeedRewardPanelData = this.OpenParam as ISolarSpeedRewardPanelData;
			this.TabLayout.RefreshByData(solarSpeedRewardPanelData.TabDataList, null, false);
			this.RewardLayout.RefreshByData(solarSpeedRewardPanelData.RewardDataList, null, false);
		}

		// Token: 0x06033744 RID: 210756 RVA: 0x00E68C97 File Offset: 0x00E66E97
		public void PlayStart(string animName)
		{
			(base.GetVerticalLayout(2).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController).Play(animName, -1, false);
		}

		// Token: 0x06033745 RID: 210757 RVA: 0x00E68CC1 File Offset: 0x00E66EC1
		private SolarSpeedTabCellPanel BuildSolarSpeedTabCellPanel()
		{
			return new SolarSpeedTabCellPanel();
		}

		// Token: 0x06033746 RID: 210758 RVA: 0x00E68CC8 File Offset: 0x00E66EC8
		private SolarSpeedRewardCellPanel BuildSolarSpeedRewardCellPanel()
		{
			return new SolarSpeedRewardCellPanel();
		}

		// Token: 0x0401B543 RID: 111939
		private GenericLayout<SolarSpeedTabCellPanel, ISolarSpeedTabCellPanelData> TabLayout;

		// Token: 0x0401B544 RID: 111940
		private GenericLayout<SolarSpeedRewardCellPanel, ISolarSpeedRewardCellPanelData> RewardLayout;

		// Token: 0x0200AD0B RID: 44299
		[NullableContext(0)]
		private class ERewardComponent
		{
			// Token: 0x04035817 RID: 219159
			public const int TabContentLayout = 0;

			// Token: 0x04035818 RID: 219160
			public const int TabCellItem = 1;

			// Token: 0x04035819 RID: 219161
			public const int RewardContentLayout = 2;

			// Token: 0x0403581A RID: 219162
			public const int RewardCellItem = 3;
		}
	}
}
