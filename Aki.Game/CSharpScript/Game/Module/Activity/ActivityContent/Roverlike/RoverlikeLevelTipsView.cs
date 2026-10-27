using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006149 RID: 24905
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLevelTipsView : UiViewBase
	{
		// Token: 0x0603EF4C RID: 257868 RVA: 0x00F3543F File Offset: 0x00F3363F
		public RoverlikeLevelTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603EF4D RID: 257869 RVA: 0x00F35448 File Offset: 0x00F33648
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EF4E RID: 257870 RVA: 0x00F35490 File Offset: 0x00F33690
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeLevelTipsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeLevelTipsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EF4F RID: 257871 RVA: 0x00F354D4 File Offset: 0x00F336D4
		protected override void OnBeforeShow()
		{
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			if (instanceData == null)
			{
				return;
			}
			this.RefreshLevelTips(instanceData);
		}

		// Token: 0x0603EF50 RID: 257872 RVA: 0x00F354F7 File Offset: 0x00F336F7
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603EF51 RID: 257873 RVA: 0x00F35500 File Offset: 0x00F33700
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			RoverlikeLevelTipsItem levelTips = this.LevelTips;
			if (levelTips == null)
			{
				return;
			}
			levelTips.PlayCurrentLevelSequence("Get");
		}

		// Token: 0x0603EF52 RID: 257874 RVA: 0x00F35518 File Offset: 0x00F33718
		private void RefreshLevelTips(RoverlikeInstanceData instanceData)
		{
			RoverlikeLevelTipsItem levelTips = this.LevelTips;
			if (levelTips != null)
			{
				levelTips.Refresh(instanceData, false, null);
			}
			IReadOnlyList<RoverRogueRoad> roadByRoadType = RoverlikeConfig.Instance.GetRoadByRoadType(instanceData.RoadTypeId);
			int num = instanceData.CurLayer - 1;
			int? num2 = (num >= 0 && num < roadByRoadType.Count) ? new int?(roadByRoadType[num].LayerType) : null;
			bool effectPanelVisible = num2.GetValueOrDefault() == 2 || num2.GetValueOrDefault() == 3;
			RoverlikeLevelTipsItem levelTips2 = this.LevelTips;
			if (levelTips2 == null)
			{
				return;
			}
			levelTips2.SetEffectPanelVisible(effectPanelVisible);
		}

		// Token: 0x04020DB8 RID: 134584
		[Nullable(2)]
		private RoverlikeLevelTipsItem LevelTips;

		// Token: 0x0200C3A7 RID: 50087
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B09D RID: 241821
			public const int ItemLevelTips = 0;
		}
	}
}
