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
	// Token: 0x020053A3 RID: 21411
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaSumView : UiTickViewBase
	{
		// Token: 0x06036B4A RID: 224074 RVA: 0x00CF27EF File Offset: 0x00CF09EF
		public MoraleAreaSumView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036B4B RID: 224075 RVA: 0x00CF2804 File Offset: 0x00CF0A04
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

		// Token: 0x06036B4C RID: 224076 RVA: 0x00CF2927 File Offset: 0x00CF0B27
		protected override void OnBeforeCreate()
		{
			this.Model = MoraleModel.Instance;
		}

		// Token: 0x06036B4D RID: 224077 RVA: 0x00CF2934 File Offset: 0x00CF0B34
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaSumView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaSumView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036B4E RID: 224078 RVA: 0x00CF2977 File Offset: 0x00CF0B77
		protected override void OnStart()
		{
			this.InitAreaSumMapData();
		}

		// Token: 0x06036B4F RID: 224079 RVA: 0x00CF2980 File Offset: 0x00CF0B80
		public UniTask InitAreaSumMap()
		{
			MoraleAreaSumView.<InitAreaSumMap>d__17 <InitAreaSumMap>d__;
			<InitAreaSumMap>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAreaSumMap>d__.<>4__this = this;
			<InitAreaSumMap>d__.<>1__state = -1;
			<InitAreaSumMap>d__.<>t__builder.Start<MoraleAreaSumView.<InitAreaSumMap>d__17>(ref <InitAreaSumMap>d__);
			return <InitAreaSumMap>d__.<>t__builder.Task;
		}

		// Token: 0x06036B50 RID: 224080 RVA: 0x00CF29C4 File Offset: 0x00CF0BC4
		public UniTask InitEnterConfig()
		{
			MoraleAreaSumView.<InitEnterConfig>d__18 <InitEnterConfig>d__;
			<InitEnterConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEnterConfig>d__.<>4__this = this;
			<InitEnterConfig>d__.<>1__state = -1;
			<InitEnterConfig>d__.<>t__builder.Start<MoraleAreaSumView.<InitEnterConfig>d__18>(ref <InitEnterConfig>d__);
			return <InitEnterConfig>d__.<>t__builder.Task;
		}

		// Token: 0x06036B51 RID: 224081 RVA: 0x00CF2A08 File Offset: 0x00CF0C08
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

		// Token: 0x06036B52 RID: 224082 RVA: 0x00CF2A4B File Offset: 0x00CF0C4B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MoraleProgressRewardUpdate, new Action(this.EventMoraleProgressRewardUpdate));
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.EventOnActivitySequenceEmitEvent));
		}

		// Token: 0x06036B53 RID: 224083 RVA: 0x00CF2A85 File Offset: 0x00CF0C85
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MoraleProgressRewardUpdate, new Action(this.EventMoraleProgressRewardUpdate));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.EventOnActivitySequenceEmitEvent));
		}

		// Token: 0x06036B54 RID: 224084 RVA: 0x00CF2ABF File Offset: 0x00CF0CBF
		protected override void OnBeforeShow()
		{
			this.ResetLoopEffect();
			this.UpdateData();
		}

		// Token: 0x06036B55 RID: 224085 RVA: 0x00CF2AD0 File Offset: 0x00CF0CD0
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

		// Token: 0x06036B56 RID: 224086 RVA: 0x00CF2B3C File Offset: 0x00CF0D3C
		protected override void OnAfterShow()
		{
			this.CheckPlayEnterEffect().Forget();
		}

		// Token: 0x06036B57 RID: 224087 RVA: 0x00CF2B49 File Offset: 0x00CF0D49
		protected override void OnAfterHide()
		{
			this.Model.ClearAllFlagNewUnlockState();
			this.Model.SaveLocalData();
		}

		// Token: 0x06036B58 RID: 224088 RVA: 0x00CF2B61 File Offset: 0x00CF0D61
		public void UpdateData()
		{
			this.SumLvInfoPanel.UpdateData();
			this.ScoreProgressPanel.UpdateData();
		}

		// Token: 0x06036B59 RID: 224089 RVA: 0x00CF2B79 File Offset: 0x00CF0D79
		public bool IsMoraleGameOver(bool? active = null)
		{
			if (active.GetValueOrDefault())
			{
				return true;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			return ((uiViewSequence != null) ? uiViewSequence.StartSequenceName : null) == "Occupy" || this.Model.IsMoraleGameOver();
		}

		// Token: 0x06036B5A RID: 224090 RVA: 0x00CF2BB4 File Offset: 0x00CF0DB4
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

		// Token: 0x06036B5B RID: 224091 RVA: 0x00CF2C00 File Offset: 0x00CF0E00
		public void InitAreaSumMapData()
		{
			for (int i = 0; i < this.AreaMapPanelList.Count; i++)
			{
				this.AreaMapPanelList[i].InitData();
			}
		}

		// Token: 0x06036B5C RID: 224092 RVA: 0x00CF2C34 File Offset: 0x00CF0E34
		private void EventMoraleProgressRewardUpdate()
		{
			this.ScoreProgressPanel.UpdateData();
		}

		// Token: 0x06036B5D RID: 224093 RVA: 0x00CF2C41 File Offset: 0x00CF0E41
		private void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036B5E RID: 224094 RVA: 0x00CF2C4A File Offset: 0x00CF0E4A
		private void EventOnActivitySequenceEmitEvent(string name)
		{
			if (name == "Enter")
			{
				this.CheckPlayEnterEffect().Forget();
			}
		}

		// Token: 0x06036B5F RID: 224095 RVA: 0x00CF2C64 File Offset: 0x00CF0E64
		private void OnBtnHelp()
		{
			HelpController.Instance.OpenHelpById(315);
		}

		// Token: 0x06036B60 RID: 224096 RVA: 0x00CF2C78 File Offset: 0x00CF0E78
		public UniTask CheckPlayEnterEffect()
		{
			MoraleAreaSumView.<CheckPlayEnterEffect>d__34 <CheckPlayEnterEffect>d__;
			<CheckPlayEnterEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckPlayEnterEffect>d__.<>4__this = this;
			<CheckPlayEnterEffect>d__.<>1__state = -1;
			<CheckPlayEnterEffect>d__.<>t__builder.Start<MoraleAreaSumView.<CheckPlayEnterEffect>d__34>(ref <CheckPlayEnterEffect>d__);
			return <CheckPlayEnterEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06036B61 RID: 224097 RVA: 0x00CF2CBC File Offset: 0x00CF0EBC
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

		// Token: 0x06036B62 RID: 224098 RVA: 0x00CF2D0F File Offset: 0x00CF0F0F
		private static List<MoraleAreaPlotData> CombineLists(IReadOnlyList<MoraleAreaPlotData> a, IReadOnlyList<MoraleAreaPlotData> b)
		{
			List<MoraleAreaPlotData> list = new List<MoraleAreaPlotData>(a.Count + b.Count);
			list.AddRange(a);
			list.AddRange(b);
			return list;
		}

		// Token: 0x06036B63 RID: 224099 RVA: 0x00CF2D34 File Offset: 0x00CF0F34
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

		// Token: 0x06036B64 RID: 224100 RVA: 0x00CF2D70 File Offset: 0x00CF0F70
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

		// Token: 0x06036B65 RID: 224101 RVA: 0x00CF2E44 File Offset: 0x00CF1044
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

		// Token: 0x06036B66 RID: 224102 RVA: 0x00CF2E98 File Offset: 0x00CF1098
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

		// Token: 0x06036B67 RID: 224103 RVA: 0x00CF2EEC File Offset: 0x00CF10EC
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

		// Token: 0x06036B68 RID: 224104 RVA: 0x00CF2F40 File Offset: 0x00CF1140
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

		// Token: 0x06036B69 RID: 224105 RVA: 0x00CF2F8C File Offset: 0x00CF118C
		public UniTask PlayHighMonsterKillEffect()
		{
			MoraleAreaSumView.<PlayHighMonsterKillEffect>d__43 <PlayHighMonsterKillEffect>d__;
			<PlayHighMonsterKillEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayHighMonsterKillEffect>d__.<>4__this = this;
			<PlayHighMonsterKillEffect>d__.<>1__state = -1;
			<PlayHighMonsterKillEffect>d__.<>t__builder.Start<MoraleAreaSumView.<PlayHighMonsterKillEffect>d__43>(ref <PlayHighMonsterKillEffect>d__);
			return <PlayHighMonsterKillEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06036B6A RID: 224106 RVA: 0x00CF2FD0 File Offset: 0x00CF11D0
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

		// Token: 0x06036B6B RID: 224107 RVA: 0x00CF301B File Offset: 0x00CF121B
		protected override void OnTick(float delta)
		{
			this.TickAreaMapPanel(delta);
		}

		// Token: 0x06036B6C RID: 224108 RVA: 0x00CF3024 File Offset: 0x00CF1224
		public void TickAreaMapPanel(float delta)
		{
			for (int i = 0; i < this.AreaMapPanelList.Count; i++)
			{
				this.AreaMapPanelList[i].OnTick(delta);
			}
		}

		// Token: 0x06036B6D RID: 224109 RVA: 0x00CF305C File Offset: 0x00CF125C
		public UniTask CheckExistAreaActiveLight()
		{
			MoraleAreaSumView.<CheckExistAreaActiveLight>d__47 <CheckExistAreaActiveLight>d__;
			<CheckExistAreaActiveLight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckExistAreaActiveLight>d__.<>4__this = this;
			<CheckExistAreaActiveLight>d__.<>1__state = -1;
			<CheckExistAreaActiveLight>d__.<>t__builder.Start<MoraleAreaSumView.<CheckExistAreaActiveLight>d__47>(ref <CheckExistAreaActiveLight>d__);
			return <CheckExistAreaActiveLight>d__.<>t__builder.Task;
		}

		// Token: 0x06036B6E RID: 224110 RVA: 0x00CF30A0 File Offset: 0x00CF12A0
		public UniTask CheckNextHighMonsterArea()
		{
			MoraleAreaSumView.<CheckNextHighMonsterArea>d__48 <CheckNextHighMonsterArea>d__;
			<CheckNextHighMonsterArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckNextHighMonsterArea>d__.<>4__this = this;
			<CheckNextHighMonsterArea>d__.<>1__state = -1;
			<CheckNextHighMonsterArea>d__.<>t__builder.Start<MoraleAreaSumView.<CheckNextHighMonsterArea>d__48>(ref <CheckNextHighMonsterArea>d__);
			return <CheckNextHighMonsterArea>d__.<>t__builder.Task;
		}

		// Token: 0x06036B6F RID: 224111 RVA: 0x00CF30E4 File Offset: 0x00CF12E4
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

		// Token: 0x06036B70 RID: 224112 RVA: 0x00CF3150 File Offset: 0x00CF1350
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

		// Token: 0x06036B71 RID: 224113 RVA: 0x00CF31A8 File Offset: 0x00CF13A8
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

		// Token: 0x06036B72 RID: 224114 RVA: 0x00CF3203 File Offset: 0x00CF1403
		protected override void OnAfterDestroy()
		{
			this.Model.UiEnterConfig = null;
			this.Model.UiLoopConfig = null;
		}

		// Token: 0x06036B73 RID: 224115 RVA: 0x00CF3220 File Offset: 0x00CF1420
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

		// Token: 0x0401CE44 RID: 118340
		public PopupCaptionItem PopupCaption;

		// Token: 0x0401CE45 RID: 118341
		public MoraleSumLvInfoPanel SumLvInfoPanel;

		// Token: 0x0401CE46 RID: 118342
		public MoraleScoreProgressPanel ScoreProgressPanel;

		// Token: 0x0401CE47 RID: 118343
		public MoraleModel Model;

		// Token: 0x0401CE48 RID: 118344
		public readonly List<MoraleSumAreaMapPanel> AreaMapPanelList = new List<MoraleSumAreaMapPanel>();

		// Token: 0x0401CE49 RID: 118345
		public BP_MoraleEffectConfig_C EnterConfig;

		// Token: 0x0401CE4A RID: 118346
		public BP_MoraleEffectConfig_C LoopConfig;

		// Token: 0x0401CE4B RID: 118347
		public bool IsPlayingEnterEffect;

		// Token: 0x0401CE4C RID: 118348
		public bool IsPlayedEnterEffect;

		// Token: 0x0401CE4D RID: 118349
		public int LoopFlagNum;

		// Token: 0x0401CE4E RID: 118350
		public MoraleHighMonsterProgressPanel HighMonsterProgressPanel;

		// Token: 0x0200B623 RID: 46627
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040372BC RID: 225980
			public const int ItemCaption = 0;

			// Token: 0x040372BD RID: 225981
			public const int ItemArea1Panel = 1;

			// Token: 0x040372BE RID: 225982
			public const int ItemArea2Panel = 2;

			// Token: 0x040372BF RID: 225983
			public const int ItemArea3Panel = 3;

			// Token: 0x040372C0 RID: 225984
			public const int ItemArea4Panel = 4;

			// Token: 0x040372C1 RID: 225985
			public const int ItemArea5Panel = 5;

			// Token: 0x040372C2 RID: 225986
			public const int ItemLevelInfoPanel = 6;

			// Token: 0x040372C3 RID: 225987
			public const int ItemScoreProgressPanel = 7;

			// Token: 0x040372C4 RID: 225988
			public const int ItemOccupyComplete = 8;

			// Token: 0x040372C5 RID: 225989
			public const int TextureMapBg = 9;

			// Token: 0x040372C6 RID: 225990
			public const int TextureMapLightBg = 10;

			// Token: 0x040372C7 RID: 225991
			public const int ItemHighMonsterProgress = 11;
		}
	}
}
