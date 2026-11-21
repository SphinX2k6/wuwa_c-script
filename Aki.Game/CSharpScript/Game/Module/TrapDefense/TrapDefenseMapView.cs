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
	// Token: 0x02003A91 RID: 14993
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMapView : UiViewBase
	{
		// Token: 0x06026867 RID: 157799 RVA: 0x00ACC369 File Offset: 0x00ACA569
		public TrapDefenseMapView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06026868 RID: 157800 RVA: 0x00ACC388 File Offset: 0x00ACA588
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

		// Token: 0x06026869 RID: 157801 RVA: 0x00ACC470 File Offset: 0x00ACA670
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMapView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMapView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602686A RID: 157802 RVA: 0x00ACC4B3 File Offset: 0x00ACA6B3
		protected override void OnStart()
		{
			this.RefreshWaveTips();
			this.RefreshHpPanel();
		}

		// Token: 0x0602686B RID: 157803 RVA: 0x00ACC4C1 File Offset: 0x00ACA6C1
		protected override void OnBeforeShow()
		{
			this.CampsiteHpPanel.ShowBattleChildViewPanel();
		}

		// Token: 0x0602686C RID: 157804 RVA: 0x00ACC4CE File Offset: 0x00ACA6CE
		protected override void OnAfterHide()
		{
			this.CampsiteHpPanel.HideBattleChildViewPanel();
		}

		// Token: 0x0602686D RID: 157805 RVA: 0x00ACC4DB File Offset: 0x00ACA6DB
		protected override void OnBeforeDestroy()
		{
			this.MiniMap.Reset();
			this.CampsiteHpPanel.Reset();
		}

		// Token: 0x0602686E RID: 157806 RVA: 0x00ACC4F4 File Offset: 0x00ACA6F4
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

		// Token: 0x0602686F RID: 157807 RVA: 0x00ACC564 File Offset: 0x00ACA764
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

		// Token: 0x06026870 RID: 157808 RVA: 0x00ACC5CD File Offset: 0x00ACA7CD
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x040151C9 RID: 86473
		public TrapDefenseMiniMapPanel MiniMap = new TrapDefenseMiniMapPanel();

		// Token: 0x040151CA RID: 86474
		public TrapDefenseCampsiteHpPanel CampsiteHpPanel = new TrapDefenseCampsiteHpPanel();
	}
}
