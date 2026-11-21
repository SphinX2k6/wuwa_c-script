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
	// Token: 0x02005377 RID: 21367
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourBattleView : UiTickViewBase
	{
		// Token: 0x06035299 RID: 217753 RVA: 0x00ED8A9F File Offset: 0x00ED6C9F
		public MotorParkourBattleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603529A RID: 217754 RVA: 0x00ED8AA8 File Offset: 0x00ED6CA8
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

		// Token: 0x0603529B RID: 217755 RVA: 0x00ED8B32 File Offset: 0x00ED6D32
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, float>(EEventName.MotorParkourFinishLap, new Action<int, float>(this.OnMotorParkourFinishLap));
		}

		// Token: 0x0603529C RID: 217756 RVA: 0x00ED8B50 File Offset: 0x00ED6D50
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, float>(EEventName.MotorParkourFinishLap, new Action<int, float>(this.OnMotorParkourFinishLap));
		}

		// Token: 0x0603529D RID: 217757 RVA: 0x00ED8B70 File Offset: 0x00ED6D70
		protected override UniTask OnBeforeStartAsync()
		{
			MotorParkourBattleView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorParkourBattleView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603529E RID: 217758 RVA: 0x00ED8BB3 File Offset: 0x00ED6DB3
		protected override void OnTick(float delta)
		{
			this.MissionPanel.OnTickBattleChildViewPanel(delta);
			this.MapItem.UpdatePlayerPosition();
		}

		// Token: 0x0603529F RID: 217759 RVA: 0x00ED8BCC File Offset: 0x00ED6DCC
		protected override void OnBeforeDestroy()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.DriveMotorcycle, new List<EBattleUiChild>
			{
				EBattleUiChild.Mission
			}, true, true, 0);
			this.MissionPanel.Reset();
		}

		// Token: 0x060352A0 RID: 217760 RVA: 0x00ED8BFC File Offset: 0x00ED6DFC
		private void OnMotorParkourFinishLap(int lap, float time)
		{
			List<MotorParkourRankData> lapRankList = this.LevelData.GetLapRankList(lap, time);
			this.RankPanel.RefreshRankList(lapRankList);
		}

		// Token: 0x0401C0D5 RID: 114901
		private MotorParkourLevelData LevelData;

		// Token: 0x0401C0D6 RID: 114902
		private MotorParkourMapItem MapItem;

		// Token: 0x0401C0D7 RID: 114903
		private MissionPanel MissionPanel;

		// Token: 0x0401C0D8 RID: 114904
		private MotorParkourRankPanel RankPanel;

		// Token: 0x0200AFFE RID: 45054
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403663C RID: 222780
			public const int ItemMap = 0;

			// Token: 0x0403663D RID: 222781
			public const int ItemMissionPanel = 1;

			// Token: 0x0403663E RID: 222782
			public const int ItemRankPanel = 2;
		}
	}
}
