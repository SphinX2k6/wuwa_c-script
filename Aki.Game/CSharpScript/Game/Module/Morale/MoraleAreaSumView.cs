using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UI.View.Morale;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Morale.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004386 RID: 17286
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaSumView : UiTickViewBase
	{
		// Token: 0x0602BA90 RID: 178832 RVA: 0x00C41897 File Offset: 0x00C3FA97
		public MoraleAreaSumView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BA91 RID: 178833 RVA: 0x00C418AC File Offset: 0x00C3FAAC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUITexture)),
				new ValueTuple<int, Type>(11, typeof(UUIItem))
			};
		}

		// Token: 0x0602BA92 RID: 178834 RVA: 0x00C419CF File Offset: 0x00C3FBCF
		protected override void OnBeforeCreate()
		{
			this.Model = MoraleModel.Instance;
		}

		// Token: 0x0602BA93 RID: 178835 RVA: 0x00C419DC File Offset: 0x00C3FBDC
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaSumView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaSumView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA94 RID: 178836 RVA: 0x00C41A1F File Offset: 0x00C3FC1F
		protected override void OnStart()
		{
			this.InitAreaSumMapData();
		}

		// Token: 0x0602BA95 RID: 178837 RVA: 0x00C41A28 File Offset: 0x00C3FC28
		public UniTask InitAreaSumMap()
		{
			MoraleAreaSumView.<InitAreaSumMap>d__17 <InitAreaSumMap>d__;
			<InitAreaSumMap>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAreaSumMap>d__.<>4__this = this;
			<InitAreaSumMap>d__.<>1__state = -1;
			<InitAreaSumMap>d__.<>t__builder.Start<MoraleAreaSumView.<InitAreaSumMap>d__17>(ref <InitAreaSumMap>d__);
			return <InitAreaSumMap>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA96 RID: 178838 RVA: 0x00C41A6C File Offset: 0x00C3FC6C
		public UniTask InitEnterConfig()
		{
			MoraleAreaSumView.<InitEnterConfig>d__18 <InitEnterConfig>d__;
			<InitEnterConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEnterConfig>d__.<>4__this = this;
			<InitEnterConfig>d__.<>1__state = -1;
			<InitEnterConfig>d__.<>t__builder.Start<MoraleAreaSumView.<InitEnterConfig>d__18>(ref <InitEnterConfig>d__);
			return <InitEnterConfig>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA97 RID: 178839 RVA: 0x00C41AB0 File Offset: 0x00C3FCB0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BP_MoraleEffectConfig_C> CreateEffectConfig(string resId)
		{
			MoraleAreaSumView.<CreateEffectConfig>d__19 <CreateEffectConfig>d__;
			<CreateEffectConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<BP_MoraleEffectConfig_C>.Create();
			<CreateEffectConfig>d__.resId = resId;
			<CreateEffectConfig>d__.<>1__state = -1;
			<CreateEffectConfig>d__.<>t__builder.Start<MoraleAreaSumView.<CreateEffectConfig>d__19>(ref <CreateEffectConfig>d__);
			return <CreateEffectConfig>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA98 RID: 178840 RVA: 0x00C41AF3 File Offset: 0x00C3FCF3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MoraleProgressRewardUpdate, new Action(this.EventMoraleProgressRewardUpdate));
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.EventOnActivitySequenceEmitEvent));
		}

		// Token: 0x0602BA99 RID: 178841 RVA: 0x00C41B2D File Offset: 0x00C3FD2D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MoraleProgressRewardUpdate, new Action(this.EventMoraleProgressRewardUpdate));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.EventOnActivitySequenceEmitEvent));
		}

		// Token: 0x0602BA9A RID: 178842 RVA: 0x00C41B67 File Offset: 0x00C3FD67
		protected override void OnBeforeShow()
		{
			this.ResetLoopEffect();
			this.UpdateData();
		}

		// Token: 0x0602BA9B RID: 178843 RVA: 0x00C41B78 File Offset: 0x00C3FD78
		private void ResetLoopEffect()
		{
			for (int i = 0; i < this.AreaMapPanelList.Count; i++)
			{
				MoraleSumAreaMapPanel moraleSumAreaMapPanel = this.AreaMapPanelList[i];
				for (int j = 0; j < moraleSumAreaMapPanel.AreaPlotPanel.PlotList.Count; j++)
				{
					MoraleTickPromise loopTickPromise = moraleSumAreaMapPanel.AreaPlotPanel.PlotList[j].LoopTickPromise;
					if (loopTickPromise != null)
					{
						loopTickPromise.Stop();
					}
				}
			}
		}

		// Token: 0x0602BA9C RID: 178844 RVA: 0x00C41BE4 File Offset: 0x00C3FDE4
		protected override void OnAfterShow()
		{
			this.CheckPlayEnterEffect().Forget();
		}

		// Token: 0x0602BA9D RID: 178845 RVA: 0x00C41BF1 File Offset: 0x00C3FDF1
		protected override void OnAfterHide()
		{
			this.Model.ClearAllFlagNewUnlockState();
			this.Model.SaveLocalData();
		}

		// Token: 0x0602BA9E RID: 178846 RVA: 0x00C41C09 File Offset: 0x00C3FE09
		public void UpdateData()
		{
			this.SumLvInfoPanel.UpdateData();
			this.ScoreProgressPanel.UpdateData();
		}

		// Token: 0x0602BA9F RID: 178847 RVA: 0x00C41C21 File Offset: 0x00C3FE21
		public bool IsMoraleGameOver(bool? active = null)
		{
			if (active.GetValueOrDefault())
			{
				return true;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			return ((uiViewSequence != null) ? uiViewSequence.StartSequenceName : null) == "Occupy" || this.Model.IsMoraleGameOver();
		}

		// Token: 0x0602BAA0 RID: 178848 RVA: 0x00C41C5C File Offset: 0x00C3FE5C
		public UniTask CheckOccupyAllAreaState(bool? active = null)
		{
			MoraleAreaSumView.<CheckOccupyAllAreaState>d__28 <CheckOccupyAllAreaState>d__;
			<CheckOccupyAllAreaState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckOccupyAllAreaState>d__.<>4__this = this;
			<CheckOccupyAllAreaState>d__.active = active;
			<CheckOccupyAllAreaState>d__.<>1__state = -1;
			<CheckOccupyAllAreaState>d__.<>t__builder.Start<MoraleAreaSumView.<CheckOccupyAllAreaState>d__28>(ref <CheckOccupyAllAreaState>d__);
			return <CheckOccupyAllAreaState>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAA1 RID: 178849 RVA: 0x00C41CA8 File Offset: 0x00C3FEA8
		public void InitAreaSumMapData()
		{
			for (int i = 0; i < this.AreaMapPanelList.Count; i++)
			{
				this.AreaMapPanelList[i].InitData();
			}
		}

		// Token: 0x0602BAA2 RID: 178850 RVA: 0x00C41CDC File Offset: 0x00C3FEDC
		private void EventMoraleProgressRewardUpdate()
		{
			this.ScoreProgressPanel.UpdateData();
		}

		// Token: 0x0602BAA3 RID: 178851 RVA: 0x00C41CE9 File Offset: 0x00C3FEE9
		private void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602BAA4 RID: 178852 RVA: 0x00C41CF2 File Offset: 0x00C3FEF2
		private void EventOnActivitySequenceEmitEvent(string name)
		{
			if (name == "Enter")
			{
				this.CheckPlayEnterEffect().Forget();
			}
		}

		// Token: 0x0602BAA5 RID: 178853 RVA: 0x00C41D0C File Offset: 0x00C3FF0C
		private void OnBtnHelp()
		{
			HelpController.Instance.OpenHelpById(315);
		}

		// Token: 0x0602BAA6 RID: 178854 RVA: 0x00C41D20 File Offset: 0x00C3FF20
		public UniTask CheckPlayEnterEffect()
		{
			MoraleAreaSumView.<CheckPlayEnterEffect>d__34 <CheckPlayEnterEffect>d__;
			<CheckPlayEnterEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckPlayEnterEffect>d__.<>4__this = this;
			<CheckPlayEnterEffect>d__.<>1__state = -1;
			<CheckPlayEnterEffect>d__.<>t__builder.Start<MoraleAreaSumView.<CheckPlayEnterEffect>d__34>(ref <CheckPlayEnterEffect>d__);
			return <CheckPlayEnterEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAA7 RID: 178855 RVA: 0x00C41D64 File Offset: 0x00C3FF64
		public UniTask PlayEnterEffect([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<MoraleAreaPlotData> setEnterList = null, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<MoraleAreaPlotData> setNewUnlockList = null)
		{
			MoraleAreaSumView.<PlayEnterEffect>d__35 <PlayEnterEffect>d__;
			<PlayEnterEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEnterEffect>d__.<>4__this = this;
			<PlayEnterEffect>d__.setEnterList = setEnterList;
			<PlayEnterEffect>d__.setNewUnlockList = setNewUnlockList;
			<PlayEnterEffect>d__.<>1__state = -1;
			<PlayEnterEffect>d__.<>t__builder.Start<MoraleAreaSumView.<PlayEnterEffect>d__35>(ref <PlayEnterEffect>d__);
			return <PlayEnterEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAA8 RID: 178856 RVA: 0x00C41DB7 File Offset: 0x00C3FFB7
		private static List<MoraleAreaPlotData> CombineLists(IReadOnlyList<MoraleAreaPlotData> a, IReadOnlyList<MoraleAreaPlotData> b)
		{
			List<MoraleAreaPlotData> list = new List<MoraleAreaPlotData>(a.Count + b.Count);
			list.AddRange(a);
			list.AddRange(b);
			return list;
		}

		// Token: 0x0602BAA9 RID: 178857 RVA: 0x00C41DDC File Offset: 0x00C3FFDC
		[NullableContext(2)]
		public void TestPlayEnterEffectByFlag(int[] flagEnterList = null, int[] flagNewUnlockList = null)
		{
			if (this.IsPlayingEnterEffect)
			{
				return;
			}
			IReadOnlyList<MoraleAreaPlotData> idList = this.GetIdList(flagEnterList);
			IReadOnlyList<MoraleAreaPlotData> idList2 = this.GetIdList(flagNewUnlockList);
			this.InitAreaSumMapData();
			this.PlayEnterEffect(idList, idList2).Forget();
		}

		// Token: 0x0602BAAA RID: 178858 RVA: 0x00C41E18 File Offset: 0x00C40018
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private IReadOnlyList<MoraleAreaPlotData> GetIdList(int[] flagList)
		{
			if (flagList == null)
			{
				return null;
			}
			List<MoraleAreaPlotData> list = new List<MoraleAreaPlotData>();
			foreach (int key in flagList)
			{
				MoraleAreaFlagData moraleAreaFlagData;
				if (this.Model.FlagMap.TryGetValue(key, out moraleAreaFlagData))
				{
					List<MoraleAreaPlotData> areaPlotDataList = moraleAreaFlagData.AreaPlotDataList;
					for (int j = 0; j < areaPlotDataList.Count; j++)
					{
						list.Add(areaPlotDataList[j]);
					}
				}
			}
			if (list.Count > 0)
			{
				MoraleAreaPlotData[] array = new MoraleAreaPlotData[list.Count];
				for (int k = 0; k < list.Count; k++)
				{
					array[k] = list[k];
				}
				MoraleAreaPlotData[] array2 = MathUtils.Instance.Shuffle<MoraleAreaPlotData>(array);
				for (int l = 0; l < array2.Length; l++)
				{
					list[l] = array2[l];
				}
			}
			return list;
		}

		// Token: 0x0602BAAB RID: 178859 RVA: 0x00C41EEC File Offset: 0x00C400EC
		public UniTask PlayAreaPanelEnterEffectTimes(int sumTimes, IReadOnlyList<MoraleAreaPlotData> plotList)
		{
			MoraleAreaSumView.<PlayAreaPanelEnterEffectTimes>d__39 <PlayAreaPanelEnterEffectTimes>d__;
			<PlayAreaPanelEnterEffectTimes>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAreaPanelEnterEffectTimes>d__.<>4__this = this;
			<PlayAreaPanelEnterEffectTimes>d__.sumTimes = sumTimes;
			<PlayAreaPanelEnterEffectTimes>d__.plotList = plotList;
			<PlayAreaPanelEnterEffectTimes>d__.<>1__state = -1;
			<PlayAreaPanelEnterEffectTimes>d__.<>t__builder.Start<MoraleAreaSumView.<PlayAreaPanelEnterEffectTimes>d__39>(ref <PlayAreaPanelEnterEffectTimes>d__);
			return <PlayAreaPanelEnterEffectTimes>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAAC RID: 178860 RVA: 0x00C41F40 File Offset: 0x00C40140
		public UniTask PlayAreaPanelEnterEffect(IReadOnlyList<MoraleAreaPlotData> plotList, int? dealTime = null)
		{
			MoraleAreaSumView.<PlayAreaPanelEnterEffect>d__40 <PlayAreaPanelEnterEffect>d__;
			<PlayAreaPanelEnterEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAreaPanelEnterEffect>d__.<>4__this = this;
			<PlayAreaPanelEnterEffect>d__.plotList = plotList;
			<PlayAreaPanelEnterEffect>d__.dealTime = dealTime;
			<PlayAreaPanelEnterEffect>d__.<>1__state = -1;
			<PlayAreaPanelEnterEffect>d__.<>t__builder.Start<MoraleAreaSumView.<PlayAreaPanelEnterEffect>d__40>(ref <PlayAreaPanelEnterEffect>d__);
			return <PlayAreaPanelEnterEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAAD RID: 178861 RVA: 0x00C41F94 File Offset: 0x00C40194
		public UniTask PlayAreaPanelLoopEffect(IReadOnlyList<MoraleAreaPlotData> plotList, int? dealTime = null)
		{
			MoraleAreaSumView.<PlayAreaPanelLoopEffect>d__41 <PlayAreaPanelLoopEffect>d__;
			<PlayAreaPanelLoopEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAreaPanelLoopEffect>d__.<>4__this = this;
			<PlayAreaPanelLoopEffect>d__.plotList = plotList;
			<PlayAreaPanelLoopEffect>d__.dealTime = dealTime;
			<PlayAreaPanelLoopEffect>d__.<>1__state = -1;
			<PlayAreaPanelLoopEffect>d__.<>t__builder.Start<MoraleAreaSumView.<PlayAreaPanelLoopEffect>d__41>(ref <PlayAreaPanelLoopEffect>d__);
			return <PlayAreaPanelLoopEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAAE RID: 178862 RVA: 0x00C41FE8 File Offset: 0x00C401E8
		public UniTask PlayAreaPanelNewUnlockEffect(IReadOnlyList<MoraleAreaPlotData> plotList)
		{
			MoraleAreaSumView.<PlayAreaPanelNewUnlockEffect>d__42 <PlayAreaPanelNewUnlockEffect>d__;
			<PlayAreaPanelNewUnlockEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAreaPanelNewUnlockEffect>d__.<>4__this = this;
			<PlayAreaPanelNewUnlockEffect>d__.plotList = plotList;
			<PlayAreaPanelNewUnlockEffect>d__.<>1__state = -1;
			<PlayAreaPanelNewUnlockEffect>d__.<>t__builder.Start<MoraleAreaSumView.<PlayAreaPanelNewUnlockEffect>d__42>(ref <PlayAreaPanelNewUnlockEffect>d__);
			return <PlayAreaPanelNewUnlockEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAAF RID: 178863 RVA: 0x00C42034 File Offset: 0x00C40234
		public UniTask PlayHighMonsterKillEffect()
		{
			MoraleAreaSumView.<PlayHighMonsterKillEffect>d__43 <PlayHighMonsterKillEffect>d__;
			<PlayHighMonsterKillEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayHighMonsterKillEffect>d__.<>4__this = this;
			<PlayHighMonsterKillEffect>d__.<>1__state = -1;
			<PlayHighMonsterKillEffect>d__.<>t__builder.Start<MoraleAreaSumView.<PlayHighMonsterKillEffect>d__43>(ref <PlayHighMonsterKillEffect>d__);
			return <PlayHighMonsterKillEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAB0 RID: 178864 RVA: 0x00C42078 File Offset: 0x00C40278
		private UniTask AwaitTime(float waitTime)
		{
			MoraleAreaSumView.<AwaitTime>d__44 <AwaitTime>d__;
			<AwaitTime>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AwaitTime>d__.<>4__this = this;
			<AwaitTime>d__.waitTime = waitTime;
			<AwaitTime>d__.<>1__state = -1;
			<AwaitTime>d__.<>t__builder.Start<MoraleAreaSumView.<AwaitTime>d__44>(ref <AwaitTime>d__);
			return <AwaitTime>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAB1 RID: 178865 RVA: 0x00C420C3 File Offset: 0x00C402C3
		protected override void OnTick(float delta)
		{
			this.TickAreaMapPanel(delta);
		}

		// Token: 0x0602BAB2 RID: 178866 RVA: 0x00C420CC File Offset: 0x00C402CC
		public void TickAreaMapPanel(float delta)
		{
			for (int i = 0; i < this.AreaMapPanelList.Count; i++)
			{
				this.AreaMapPanelList[i].OnTick(delta);
			}
		}

		// Token: 0x0602BAB3 RID: 178867 RVA: 0x00C42104 File Offset: 0x00C40304
		public UniTask CheckExistAreaActiveLight()
		{
			MoraleAreaSumView.<CheckExistAreaActiveLight>d__47 <CheckExistAreaActiveLight>d__;
			<CheckExistAreaActiveLight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckExistAreaActiveLight>d__.<>4__this = this;
			<CheckExistAreaActiveLight>d__.<>1__state = -1;
			<CheckExistAreaActiveLight>d__.<>t__builder.Start<MoraleAreaSumView.<CheckExistAreaActiveLight>d__47>(ref <CheckExistAreaActiveLight>d__);
			return <CheckExistAreaActiveLight>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAB4 RID: 178868 RVA: 0x00C42148 File Offset: 0x00C40348
		public UniTask CheckNextHighMonsterArea()
		{
			MoraleAreaSumView.<CheckNextHighMonsterArea>d__48 <CheckNextHighMonsterArea>d__;
			<CheckNextHighMonsterArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckNextHighMonsterArea>d__.<>4__this = this;
			<CheckNextHighMonsterArea>d__.<>1__state = -1;
			<CheckNextHighMonsterArea>d__.<>t__builder.Start<MoraleAreaSumView.<CheckNextHighMonsterArea>d__48>(ref <CheckNextHighMonsterArea>d__);
			return <CheckNextHighMonsterArea>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAB5 RID: 178869 RVA: 0x00C4218C File Offset: 0x00C4038C
		public void StopLoopEffect()
		{
			for (int i = 0; i < this.AreaMapPanelList.Count; i++)
			{
				MoraleSumAreaMapPanel moraleSumAreaMapPanel = this.AreaMapPanelList[i];
				for (int j = 0; j < moraleSumAreaMapPanel.AreaPlotPanel.PlotList.Count; j++)
				{
					MoraleTickPromise loopTickPromise = moraleSumAreaMapPanel.AreaPlotPanel.PlotList[j].LoopTickPromise;
					if (loopTickPromise != null)
					{
						loopTickPromise.Stop();
					}
				}
			}
		}

		// Token: 0x0602BAB6 RID: 178870 RVA: 0x00C421F8 File Offset: 0x00C403F8
		private void PlayLoopEffect(IReadOnlyList<MoraleAreaPlotData> setLoopList)
		{
			if (setLoopList.Count <= 0)
			{
				return;
			}
			this.StopLoopEffect();
			int sumTimes = Math.Min(setLoopList.Count, this.LoopConfig.格子入场批次);
			this.LoopFlagNum++;
			this.PlayAreaPanelLoopEffectTimes(sumTimes, setLoopList, this.LoopFlagNum).Forget();
		}

		// Token: 0x0602BAB7 RID: 178871 RVA: 0x00C42250 File Offset: 0x00C40450
		private UniTask PlayAreaPanelLoopEffectTimes(int sumTimes, IReadOnlyList<MoraleAreaPlotData> plotList, int flagNum)
		{
			MoraleAreaSumView.<PlayAreaPanelLoopEffectTimes>d__51 <PlayAreaPanelLoopEffectTimes>d__;
			<PlayAreaPanelLoopEffectTimes>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAreaPanelLoopEffectTimes>d__.<>4__this = this;
			<PlayAreaPanelLoopEffectTimes>d__.sumTimes = sumTimes;
			<PlayAreaPanelLoopEffectTimes>d__.plotList = plotList;
			<PlayAreaPanelLoopEffectTimes>d__.flagNum = flagNum;
			<PlayAreaPanelLoopEffectTimes>d__.<>1__state = -1;
			<PlayAreaPanelLoopEffectTimes>d__.<>t__builder.Start<MoraleAreaSumView.<PlayAreaPanelLoopEffectTimes>d__51>(ref <PlayAreaPanelLoopEffectTimes>d__);
			return <PlayAreaPanelLoopEffectTimes>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAB8 RID: 178872 RVA: 0x00C422AB File Offset: 0x00C404AB
		protected override void OnAfterDestroy()
		{
			this.Model.UiEnterConfig = null;
			this.Model.UiLoopConfig = null;
		}

		// Token: 0x0602BAB9 RID: 178873 RVA: 0x00C422C8 File Offset: 0x00C404C8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx([Nullable(new byte[]
		{
			2,
			1
		})] string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "FirstFinishedArea")
			{
				for (int i = 0; i < this.AreaMapPanelList.Count; i++)
				{
					MoraleSumAreaMapPanel moraleSumAreaMapPanel = this.AreaMapPanelList[i];
					if (moraleSumAreaMapPanel.AreaTitle.IsShowBoxProgress())
					{
						UUIItem guideUiItem = moraleSumAreaMapPanel.AreaTitle.GetGuideUiItem("0");
						if (guideUiItem != null)
						{
							return new UUIItem[]
							{
								guideUiItem,
								guideUiItem
							};
						}
					}
				}
			}
			if (a == "FirstFinishedAreaBox")
			{
				int j = 0;
				while (j < this.AreaMapPanelList.Count)
				{
					MoraleSumAreaMapPanel moraleSumAreaMapPanel2 = this.AreaMapPanelList[j];
					MoraleSumAreaTitleItem areaTitle = moraleSumAreaMapPanel2.AreaTitle;
					if (areaTitle != null && areaTitle.IsShowBoxProgress())
					{
						MoraleSumAreaTitleItem areaTitle2 = moraleSumAreaMapPanel2.AreaTitle;
						if (areaTitle2 == null)
						{
							return null;
						}
						return areaTitle2.GetGuideUiItemAndUiItemForShowEx(configParams);
					}
					else
					{
						j++;
					}
				}
			}
			if (a == "FirstMoraleArea")
			{
				UUIItem guideUiItem2 = base.GetGuideUiItem("1");
				UUIItem rootItem = this.AreaMapPanelList[0].GetRootItem();
				if (guideUiItem2 != null && rootItem != null)
				{
					return new UUIItem[]
					{
						rootItem,
						guideUiItem2
					};
				}
			}
			return null;
		}

		// Token: 0x040178DC RID: 96476
		public PopupCaptionItem PopupCaption;

		// Token: 0x040178DD RID: 96477
		public MoraleSumLvInfoPanel SumLvInfoPanel;

		// Token: 0x040178DE RID: 96478
		public MoraleScoreProgressPanel ScoreProgressPanel;

		// Token: 0x040178DF RID: 96479
		public MoraleModel Model;

		// Token: 0x040178E0 RID: 96480
		public readonly List<MoraleSumAreaMapPanel> AreaMapPanelList = new List<MoraleSumAreaMapPanel>();

		// Token: 0x040178E1 RID: 96481
		public BP_MoraleEffectConfig_C EnterConfig;

		// Token: 0x040178E2 RID: 96482
		public BP_MoraleEffectConfig_C LoopConfig;

		// Token: 0x040178E3 RID: 96483
		public bool IsPlayingEnterEffect;

		// Token: 0x040178E4 RID: 96484
		public bool IsPlayedEnterEffect;

		// Token: 0x040178E5 RID: 96485
		public int LoopFlagNum;

		// Token: 0x040178E6 RID: 96486
		public MoraleHighMonsterProgressPanel HighMonsterProgressPanel;

		// Token: 0x0200A05B RID: 41051
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031D11 RID: 204049
			public const int ItemCaption = 0;

			// Token: 0x04031D12 RID: 204050
			public const int ItemArea1Panel = 1;

			// Token: 0x04031D13 RID: 204051
			public const int ItemArea2Panel = 2;

			// Token: 0x04031D14 RID: 204052
			public const int ItemArea3Panel = 3;

			// Token: 0x04031D15 RID: 204053
			public const int ItemArea4Panel = 4;

			// Token: 0x04031D16 RID: 204054
			public const int ItemArea5Panel = 5;

			// Token: 0x04031D17 RID: 204055
			public const int ItemLevelInfoPanel = 6;

			// Token: 0x04031D18 RID: 204056
			public const int ItemScoreProgressPanel = 7;

			// Token: 0x04031D19 RID: 204057
			public const int ItemOccupyComplete = 8;

			// Token: 0x04031D1A RID: 204058
			public const int TextureMapBg = 9;

			// Token: 0x04031D1B RID: 204059
			public const int TextureMapLightBg = 10;

			// Token: 0x04031D1C RID: 204060
			public const int ItemHighMonsterProgress = 11;
		}
	}
}
