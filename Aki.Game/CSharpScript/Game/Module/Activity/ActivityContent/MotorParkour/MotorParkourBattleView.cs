using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063F9 RID: 25593
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourBattleView : UiTickViewBase
	{
		// Token: 0x060405D8 RID: 263640 RVA: 0x00F91ABF File Offset: 0x00F8FCBF
		public MotorParkourBattleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060405D9 RID: 263641 RVA: 0x00F91AC8 File Offset: 0x00F8FCC8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060405DA RID: 263642 RVA: 0x00F91B52 File Offset: 0x00F8FD52
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, float>(EEventName.MotorParkourFinishLap, new Action<int, float>(this.OnMotorParkourFinishLap));
		}

		// Token: 0x060405DB RID: 263643 RVA: 0x00F91B70 File Offset: 0x00F8FD70
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, float>(EEventName.MotorParkourFinishLap, new Action<int, float>(this.OnMotorParkourFinishLap));
		}

		// Token: 0x060405DC RID: 263644 RVA: 0x00F91B90 File Offset: 0x00F8FD90
		protected override UniTask OnBeforeStartAsync()
		{
			MotorParkourBattleView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorParkourBattleView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060405DD RID: 263645 RVA: 0x00F91BD3 File Offset: 0x00F8FDD3
		protected override void OnTick(float delta)
		{
			this.MissionPanel.OnTickBattleChildViewPanel(delta);
			this.MapItem.UpdatePlayerPosition();
		}

		// Token: 0x060405DE RID: 263646 RVA: 0x00F91BEC File Offset: 0x00F8FDEC
		protected override void OnBeforeDestroy()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.DriveMotorcycle, new List<EBattleUiChild>
			{
				EBattleUiChild.Mission
			}, true, true, 0);
			this.MissionPanel.Reset();
		}

		// Token: 0x060405DF RID: 263647 RVA: 0x00F91C1C File Offset: 0x00F8FE1C
		private void OnMotorParkourFinishLap(int lap, float time)
		{
			List<MotorParkourRankData> lapRankList = this.LevelData.GetLapRankList(lap, time);
			this.RankPanel.RefreshRankList(lapRankList);
		}

		// Token: 0x040217A6 RID: 137126
		private MotorParkourLevelData LevelData;

		// Token: 0x040217A7 RID: 137127
		private MotorParkourMapItem MapItem;

		// Token: 0x040217A8 RID: 137128
		private MissionPanel MissionPanel;

		// Token: 0x040217A9 RID: 137129
		private MotorParkourRankPanel RankPanel;

		// Token: 0x0200C617 RID: 50711
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BCDD RID: 244957
			public const int ItemMap = 0;

			// Token: 0x0403BCDE RID: 244958
			public const int ItemMissionPanel = 1;

			// Token: 0x0403BCDF RID: 244959
			public const int ItemRankPanel = 2;
		}
	}
}
