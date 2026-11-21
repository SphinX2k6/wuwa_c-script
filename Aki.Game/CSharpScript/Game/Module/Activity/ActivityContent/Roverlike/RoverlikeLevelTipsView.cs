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
	// Token: 0x020050C7 RID: 20679
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLevelTipsView : UiViewBase
	{
		// Token: 0x06033C0C RID: 211980 RVA: 0x00E7C31F File Offset: 0x00E7A51F
		public RoverlikeLevelTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033C0D RID: 211981 RVA: 0x00E7C328 File Offset: 0x00E7A528
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

		// Token: 0x06033C0E RID: 211982 RVA: 0x00E7C370 File Offset: 0x00E7A570
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeLevelTipsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeLevelTipsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033C0F RID: 211983 RVA: 0x00E7C3B4 File Offset: 0x00E7A5B4
		protected override void OnBeforeShow()
		{
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			if (instanceData == null)
			{
				return;
			}
			this.RefreshLevelTips(instanceData);
		}

		// Token: 0x06033C10 RID: 211984 RVA: 0x00E7C3D7 File Offset: 0x00E7A5D7
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033C11 RID: 211985 RVA: 0x00E7C3E0 File Offset: 0x00E7A5E0
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			RoverlikeLevelTipsItem levelTips = this.LevelTips;
			if (levelTips == null)
			{
				return;
			}
			levelTips.PlayCurrentLevelSequence("Get");
		}

		// Token: 0x06033C12 RID: 211986 RVA: 0x00E7C3F8 File Offset: 0x00E7A5F8
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

		// Token: 0x0401B6E5 RID: 112357
		[Nullable(2)]
		private RoverlikeLevelTipsItem LevelTips;

		// Token: 0x0200AD8E RID: 44430
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040359FE RID: 219646
			public const int ItemLevelTips = 0;
		}
	}
}
