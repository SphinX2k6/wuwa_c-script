using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AE9 RID: 19177
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMapView : UiViewBase
	{
		// Token: 0x06031AD7 RID: 203479 RVA: 0x00B883B5 File Offset: 0x00B865B5
		public TrapDefenseMapView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031AD8 RID: 203480 RVA: 0x00B883D4 File Offset: 0x00B865D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031AD9 RID: 203481 RVA: 0x00B884BC File Offset: 0x00B866BC
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMapView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMapView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031ADA RID: 203482 RVA: 0x00B884FF File Offset: 0x00B866FF
		protected override void OnStart()
		{
			this.RefreshWaveTips();
			this.RefreshHpPanel();
		}

		// Token: 0x06031ADB RID: 203483 RVA: 0x00B8850D File Offset: 0x00B8670D
		protected override void OnBeforeShow()
		{
			this.CampsiteHpPanel.ShowBattleChildViewPanel();
		}

		// Token: 0x06031ADC RID: 203484 RVA: 0x00B8851A File Offset: 0x00B8671A
		protected override void OnAfterHide()
		{
			this.CampsiteHpPanel.HideBattleChildViewPanel();
		}

		// Token: 0x06031ADD RID: 203485 RVA: 0x00B88527 File Offset: 0x00B86727
		protected override void OnBeforeDestroy()
		{
			this.MiniMap.Reset();
			this.CampsiteHpPanel.Reset();
		}

		// Token: 0x06031ADE RID: 203486 RVA: 0x00B88540 File Offset: 0x00B86740
		private void RefreshWaveTips()
		{
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			TrapDefenseLevelData curInstToLevelData = instance.GetCurInstToLevelData();
			IReadOnlyList<TrapDefenseWave> trapDefenseWavesByLevelId = TrapDefenseConfig.Instance.GetTrapDefenseWavesByLevelId(curInstToLevelData.Id);
			long behaviorTreeVarToNumber = instance.BattleData.GetBehaviorTreeVarToNumber(ETrapDefenseSystemVarType.Batch);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "TowerDefense_Map_Progress_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				behaviorTreeVarToNumber,
				trapDefenseWavesByLevelId.Count
			}));
		}

		// Token: 0x06031ADF RID: 203487 RVA: 0x00B885B0 File Offset: 0x00B867B0
		private void RefreshHpPanel()
		{
			FKSC_MiniMapContext[] entityPositions = KuroSimpleCombatController.Instance.GetEntityPositions();
			int trapDefenseWarningDistance = TrapDefenseConfig.Instance.GetTrapDefenseWarningDistance();
			bool warningItemActive = false;
			if (entityPositions != null && entityPositions.Length != 0)
			{
				FKSC_MiniMapContext[] array = entityPositions;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Distance <= (float)trapDefenseWarningDistance)
					{
						warningItemActive = true;
						break;
					}
				}
			}
			this.CampsiteHpPanel.SetWarningItemActive(warningItemActive);
			this.CampsiteHpPanel.SetLightItemActive(false);
		}

		// Token: 0x06031AE0 RID: 203488 RVA: 0x00B88619 File Offset: 0x00B86819
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401A877 RID: 108663
		public TrapDefenseMiniMapPanel MiniMap = new TrapDefenseMiniMapPanel();

		// Token: 0x0401A878 RID: 108664
		public TrapDefenseCampsiteHpPanel CampsiteHpPanel = new TrapDefenseCampsiteHpPanel();
	}
}
