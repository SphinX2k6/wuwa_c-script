using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F52 RID: 28498
	[NullableContext(1)]
	[Nullable(0)]
	public class BigStuffedDollView : UiTickViewBase
	{
		// Token: 0x0604553A RID: 283962 RVA: 0x01126CC8 File Offset: 0x01124EC8
		public BigStuffedDollView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0604553B RID: 283963 RVA: 0x01126D30 File Offset: 0x01124F30
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBack));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickLeftBonusQte));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickRightBonusQte));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickCommonQte));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604553C RID: 283964 RVA: 0x01126F28 File Offset: 0x01125128
		protected override UniTask OnBeforeStartAsync()
		{
			BigStuffedDollView.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BigStuffedDollView.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604553D RID: 283965 RVA: 0x01126F6B File Offset: 0x0112516B
		protected override void OnStart()
		{
			base.OnStart();
		}

		// Token: 0x0604553E RID: 283966 RVA: 0x01126F73 File Offset: 0x01125173
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			BigStuffedDollModel.Instance.EnterNextGameStage();
		}

		// Token: 0x0604553F RID: 283967 RVA: 0x01126F88 File Offset: 0x01125188
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer qteLeftBtnLevelSequence = this.QteLeftBtnLevelSequence;
			if (qteLeftBtnLevelSequence != null)
			{
				qteLeftBtnLevelSequence.Clear();
			}
			this.QteLeftBtnLevelSequence = null;
			LevelSequencePlayer qteRightBtnLevelSequence = this.QteRightBtnLevelSequence;
			if (qteRightBtnLevelSequence != null)
			{
				qteRightBtnLevelSequence.Clear();
			}
			this.QteRightBtnLevelSequence = null;
			this.QteLeftBtn = null;
			this.QteRightBtn = null;
			BlackboardController.Instance.RemoveValueByEntity(this.EntityId, "CountDownStart");
			BlackboardController.Instance.RemoveValueByEntity(this.EntityId, "CountDownOver");
			BlackboardController.Instance.RemoveValueByEntity(this.EntityId, "GameOver");
			BlackboardController.Instance.RemoveValueByEntity(this.EntityId, "PressFailCount");
			BlackboardController.Instance.RemoveValueByEntity(this.EntityId, "PressCommonAreaSuccessCount");
			BlackboardController.Instance.RemoveValueByEntity(this.EntityId, "PressPerfectAreaSuccessCount");
			BlackboardController.Instance.RemoveValueByEntity(this.EntityId, "PressBonusAreaSuccessCount");
			BlackboardController.Instance.RemoveValueByEntity(this.EntityId, "FinishSkillOver");
			Entity entity = EntitySystem.Instance.Get(this.EntityId);
			CharacterSkillComponent characterSkillComponent = (entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null;
			if (characterSkillComponent != null)
			{
				int skillId = 0;
				OneOf<BrokenRockConfig, BrokenRockConfig> config = BigStuffedDollModel.Instance.Config;
				if (config.HasValue)
				{
					if (config.IsT1)
					{
						skillId = config.AsT1.NormalSkill;
					}
					else if (config.IsT2)
					{
						skillId = config.AsT2.NormalSkill;
					}
				}
				characterSkillComponent.EndSkill(skillId, "BigStuffedDollView.OnBeforeDestroy");
			}
		}

		// Token: 0x06045540 RID: 283968 RVA: 0x011270EE File Offset: 0x011252EE
		protected override void OnAfterDestroy()
		{
			if (this.FinishCallback != null)
			{
				this.FinishCallback();
			}
		}

		// Token: 0x06045541 RID: 283969 RVA: 0x01127104 File Offset: 0x01125304
		protected override void OnTick(float delta)
		{
			this.ProgressItem.OnTick(delta);
			this.GameCountDownItem.OnTick(delta);
			foreach (KeyValuePair<int, BigStuffedRingItem> keyValuePair in this.RingItems)
			{
				BigStuffedRingItem value = keyValuePair.Value;
				value.OnTick(delta);
				int currentArrowStayCellIndex = value.GetCurrentArrowStayCellIndex();
				if (currentArrowStayCellIndex != 0)
				{
					BigStuffedDollModel.Instance.GameInfo.CurrentArrowStayCellIndex = currentArrowStayCellIndex;
				}
			}
			bool? booleanValueByEntity = BlackboardModel.Instance.GetBooleanValueByEntity(this.EntityId, "FinishSkillOver");
			EGameStage gameStage = BigStuffedDollModel.Instance.GetGameStage();
			if (booleanValueByEntity != null && booleanValueByEntity.Value && gameStage == EGameStage.GameEndAnim && !this.IsExecutedFinish)
			{
				LevelGeneralCommons.PrechangeStateTag(BigStuffedDollModel.Instance.BrokenRockEntityPbDataId, GameplayTagDefine.EGameplayTagId["关卡.打击机关.状态6"], "大个布偶坚固岩石玩法：终结一拳播放完毕");
				LevelGeneralNetworks.RequestEntitySendEvent(BigStuffedDollModel.Instance.BrokenRockEntityCreatureDataId, "BrokenRockEventKey6");
				float valueOrDefault = BlackboardModel.Instance.GetFloatValueByEntity(this.EntityId, "DelayFinishTime").GetValueOrDefault(0.02f);
				TimerSystem.Instance.Delay(delegate(float _)
				{
					this.GameSuccessItem.ShowTip();
				}, valueOrDefault * 1000f, null, null, true, 1f);
				this.IsExecutedFinish = true;
			}
		}

		// Token: 0x06045542 RID: 283970 RVA: 0x01127268 File Offset: 0x01125468
		private UniTask InitRings([Nullable(new byte[]
		{
			0,
			1
		})] OneOf<BrokenRockConfig, BrokenRockConfig>? config)
		{
			BigStuffedDollView.<InitRings>d__40 <InitRings>d__;
			<InitRings>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRings>d__.<>4__this = this;
			<InitRings>d__.config = config;
			<InitRings>d__.<>1__state = -1;
			<InitRings>d__.<>t__builder.Start<BigStuffedDollView.<InitRings>d__40>(ref <InitRings>d__);
			return <InitRings>d__.<>t__builder.Task;
		}

		// Token: 0x06045543 RID: 283971 RVA: 0x011272B4 File Offset: 0x011254B4
		private UniTask InitProgressItem([Nullable(new byte[]
		{
			0,
			1
		})] OneOf<BrokenRockConfig, BrokenRockConfig>? config)
		{
			BigStuffedDollView.<InitProgressItem>d__41 <InitProgressItem>d__;
			<InitProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitProgressItem>d__.<>4__this = this;
			<InitProgressItem>d__.config = config;
			<InitProgressItem>d__.<>1__state = -1;
			<InitProgressItem>d__.<>t__builder.Start<BigStuffedDollView.<InitProgressItem>d__41>(ref <InitProgressItem>d__);
			return <InitProgressItem>d__.<>t__builder.Task;
		}

		// Token: 0x06045544 RID: 283972 RVA: 0x01127300 File Offset: 0x01125500
		private UniTask InitPrepareCountDownItem()
		{
			BigStuffedDollView.<InitPrepareCountDownItem>d__42 <InitPrepareCountDownItem>d__;
			<InitPrepareCountDownItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPrepareCountDownItem>d__.<>4__this = this;
			<InitPrepareCountDownItem>d__.<>1__state = -1;
			<InitPrepareCountDownItem>d__.<>t__builder.Start<BigStuffedDollView.<InitPrepareCountDownItem>d__42>(ref <InitPrepareCountDownItem>d__);
			return <InitPrepareCountDownItem>d__.<>t__builder.Task;
		}

		// Token: 0x06045545 RID: 283973 RVA: 0x01127344 File Offset: 0x01125544
		private UniTask InitGameCountDownItem()
		{
			BigStuffedDollView.<InitGameCountDownItem>d__43 <InitGameCountDownItem>d__;
			<InitGameCountDownItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitGameCountDownItem>d__.<>4__this = this;
			<InitGameCountDownItem>d__.<>1__state = -1;
			<InitGameCountDownItem>d__.<>t__builder.Start<BigStuffedDollView.<InitGameCountDownItem>d__43>(ref <InitGameCountDownItem>d__);
			return <InitGameCountDownItem>d__.<>t__builder.Task;
		}

		// Token: 0x06045546 RID: 283974 RVA: 0x01127388 File Offset: 0x01125588
		private UniTask InitSuccessItem()
		{
			BigStuffedDollView.<InitSuccessItem>d__44 <InitSuccessItem>d__;
			<InitSuccessItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSuccessItem>d__.<>4__this = this;
			<InitSuccessItem>d__.<>1__state = -1;
			<InitSuccessItem>d__.<>t__builder.Start<BigStuffedDollView.<InitSuccessItem>d__44>(ref <InitSuccessItem>d__);
			return <InitSuccessItem>d__.<>t__builder.Task;
		}

		// Token: 0x06045547 RID: 283975 RVA: 0x011273CC File Offset: 0x011255CC
		private UniTask InitFailItem()
		{
			BigStuffedDollView.<InitFailItem>d__45 <InitFailItem>d__;
			<InitFailItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFailItem>d__.<>4__this = this;
			<InitFailItem>d__.<>1__state = -1;
			<InitFailItem>d__.<>t__builder.Start<BigStuffedDollView.<InitFailItem>d__45>(ref <InitFailItem>d__);
			return <InitFailItem>d__.<>t__builder.Task;
		}

		// Token: 0x06045548 RID: 283976 RVA: 0x01127410 File Offset: 0x01125610
		private UniTask InitTipItem()
		{
			BigStuffedDollView.<InitTipItem>d__46 <InitTipItem>d__;
			<InitTipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipItem>d__.<>4__this = this;
			<InitTipItem>d__.<>1__state = -1;
			<InitTipItem>d__.<>t__builder.Start<BigStuffedDollView.<InitTipItem>d__46>(ref <InitTipItem>d__);
			return <InitTipItem>d__.<>t__builder.Task;
		}

		// Token: 0x06045549 RID: 283977 RVA: 0x01127454 File Offset: 0x01125654
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnBigStuffedDollGameStageUpdate, new Action<EGameStage>(this.OnGameStageUpdate));
			EventSystem.Instance.Add(EEventName.OnBigStuffedDollArrowStayAreaUpdate, new Action<int, int, int>(this.OnArrowStayAreaUpdate));
			EventSystem.Instance.Add(EEventName.OnBigStuffedDollRingItemSequencePlayStart, new Action<int, EAreaType, int>(this.RingItemSequenceStart));
		}

		// Token: 0x0604554A RID: 283978 RVA: 0x011274B8 File Offset: 0x011256B8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnBigStuffedDollGameStageUpdate, new Action<EGameStage>(this.OnGameStageUpdate));
			EventSystem.Instance.Remove(EEventName.OnBigStuffedDollArrowStayAreaUpdate, new Action<int, int, int>(this.OnArrowStayAreaUpdate));
			EventSystem.Instance.Remove(EEventName.OnBigStuffedDollRingItemSequencePlayStart, new Action<int, EAreaType, int>(this.RingItemSequenceStart));
			EventSystem.Instance.Remove(EEventName.GeneralLogicTreePrepareRollbackFinish, new Action<int>(this.OnRollbackFinish));
		}

		// Token: 0x0604554B RID: 283979 RVA: 0x01127538 File Offset: 0x01125738
		private void OnGameStageUpdate(EGameStage currentGameStage)
		{
			BigStuffedDollModel instance = BigStuffedDollModel.Instance;
			SceneTeamModel instance2 = SceneTeamModel.Instance;
			EntityHandle getCurrentEntity = instance2.GetCurrentEntity;
			if (instance2.IsPhantomTeam && instance2.IsTeamReady && getCurrentEntity != null && getCurrentEntity.Entity != null)
			{
				this.EntityId = getCurrentEntity.Entity.Id;
			}
			switch (currentGameStage)
			{
			case EGameStage.GameReady:
			{
				UUIButtonComponent button = base.GetButton(1);
				if (button != null)
				{
					button.SetSelfInteractive(false);
				}
				UUIButtonComponent button2 = base.GetButton(8);
				if (button2 != null)
				{
					button2.SetSelfInteractive(false);
				}
				BigStuffedDollController.Instance.SetBooleanValueThenSendEvent(this.EntityId, "CountDownStart", true);
				this.PrepareCountDownItem.StartCountDown();
				this.TipItem.ShowTips("TeddyBear_Intro", 3000);
				foreach (KeyValuePair<int, BigStuffedRingItem> keyValuePair in this.RingItems)
				{
					keyValuePair.Value.OnArrowExit();
				}
				instance.ArrowEnterNextValidArea();
				return;
			}
			case EGameStage.GamePlaying:
				if (instance.LastGameStage != EGameStage.GamePause)
				{
					this.PrepareCountDownItem.Hide(null);
					int globalTime = instance.GetGlobalTime();
					this.GameCountDownItem.StartCountDown((float)globalTime);
					UUIButtonComponent button3 = base.GetButton(8);
					if (button3 != null)
					{
						button3.SetSelfInteractive(true);
					}
					UUIButtonComponent button4 = base.GetButton(1);
					if (button4 != null)
					{
						button4.SetSelfInteractive(true);
					}
					if (this.EntityId != -1)
					{
						BigStuffedDollController.Instance.SetBooleanValueThenSendEvent(this.EntityId, "CountDownOver", true);
						CharacterSkillComponent component = getCurrentEntity.Entity.GetComponent<CharacterSkillComponent>();
						if (component != null)
						{
							OneOf<BrokenRockConfig, BrokenRockConfig> config = instance.Config;
							if (config.HasValue)
							{
								if (config.IsT1)
								{
									component.BeginSkill(config.AsT1.NormalSkill, null);
									return;
								}
								if (config.IsT2)
								{
									component.BeginSkill(config.AsT2.NormalSkill, null);
									return;
								}
							}
						}
					}
				}
				break;
			case EGameStage.GameEnd:
			{
				UUIButtonComponent button5 = base.GetButton(1);
				if (button5 != null)
				{
					button5.SetSelfInteractive(false);
				}
				this.OnGameEnd(instance.GameResult);
				return;
			}
			case EGameStage.GameEndAnim:
				break;
			case EGameStage.Destroy:
				base.CloseMe(null);
				break;
			default:
				return;
			}
		}

		// Token: 0x0604554C RID: 283980 RVA: 0x01127758 File Offset: 0x01125958
		private UniTask OnGameEnd(bool success)
		{
			BigStuffedDollView.<OnGameEnd>d__50 <OnGameEnd>d__;
			<OnGameEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnGameEnd>d__.<>4__this = this;
			<OnGameEnd>d__.success = success;
			<OnGameEnd>d__.<>1__state = -1;
			<OnGameEnd>d__.<>t__builder.Start<BigStuffedDollView.<OnGameEnd>d__50>(ref <OnGameEnd>d__);
			return <OnGameEnd>d__.<>t__builder.Task;
		}

		// Token: 0x0604554D RID: 283981 RVA: 0x011277A3 File Offset: 0x011259A3
		private void OnRollbackFinish(int treeConfigId)
		{
			if (treeConfigId != BigStuffedDollModel.Instance.BehaviorTreeConfigId)
			{
				return;
			}
			this.GameFailed();
		}

		// Token: 0x0604554E RID: 283982 RVA: 0x011277BC File Offset: 0x011259BC
		private UniTask GameFailed()
		{
			BigStuffedDollView.<GameFailed>d__52 <GameFailed>d__;
			<GameFailed>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GameFailed>d__.<>4__this = this;
			<GameFailed>d__.<>1__state = -1;
			<GameFailed>d__.<>t__builder.Start<BigStuffedDollView.<GameFailed>d__52>(ref <GameFailed>d__);
			return <GameFailed>d__.<>t__builder.Task;
		}

		// Token: 0x0604554F RID: 283983 RVA: 0x01127800 File Offset: 0x01125A00
		private void OnArrowStayAreaUpdate(int lastRingId, int ringId, int relativeValidAreaIndex)
		{
			foreach (KeyValuePair<int, BigStuffedRingItem> keyValuePair in this.RingItems)
			{
				BigStuffedRingItem value = keyValuePair.Value;
				if (lastRingId != ringId)
				{
					if (value.Id == lastRingId)
					{
						value.OnArrowExit();
					}
					if (value.Id == ringId)
					{
						value.OnArrowEnter();
					}
				}
				value.OnArrowStayAreaUpdate(relativeValidAreaIndex);
			}
		}

		// Token: 0x06045550 RID: 283984 RVA: 0x01127880 File Offset: 0x01125A80
		private void RingItemSequenceStart(int ringId, EAreaType areaType, int continuousIndex)
		{
			BigStuffedRingItem bigStuffedRingItem;
			if (!this.RingItems.TryGetValue(ringId, out bigStuffedRingItem))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[BigStuffedDoll]RingItemAreaClick:找不到当前的RingItem";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ringId", ringId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			OneOf<BrokenRockRing, BrokenRockRingConfig> config = bigStuffedRingItem.Config;
			if (config == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneGameplay;
				ELogAuthor author2 = ELogAuthor.YSQ;
				string message2 = "[BigStuffedDoll]RingItemAreaClick:找不到当前的RingConfig";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ringId", ringId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			BigStuffedDollModel instance3 = BigStuffedDollModel.Instance;
			switch (areaType)
			{
			case EAreaType.BlankArea:
				this.ProgressItem.AddScore((float)(-(float)instance3.GetScoreDown()), true);
				this.PressFailCount++;
				BigStuffedDollController.Instance.SetIntValueThenSendEvent(this.EntityId, "PressFailCount", this.PressFailCount);
				return;
			case EAreaType.GoodArea:
			{
				int num = 0;
				if (config.HasValue)
				{
					if (config.IsT1)
					{
						num = config.AsT1.GoodScore;
					}
					else if (config.IsT2)
					{
						num = config.AsT2.GoodScore;
					}
				}
				this.ProgressItem.AddScore((float)num, true);
				instance3.ArrowEnterNextValidArea();
				bigStuffedRingItem.SpawnContinuousArea(continuousIndex);
				this.PressCommonSuccessCount++;
				BigStuffedDollController.Instance.SetIntValueThenSendEvent(this.EntityId, "PressCommonAreaSuccessCount", this.PressCommonSuccessCount);
				return;
			}
			case EAreaType.PerfectArea:
			{
				int num2 = 0;
				if (config.HasValue)
				{
					if (config.IsT1)
					{
						num2 = config.AsT1.PerfectScore;
					}
					else if (config.IsT2)
					{
						num2 = config.AsT2.PerfectScore;
					}
				}
				this.ProgressItem.AddScore((float)num2, true);
				instance3.ArrowEnterNextValidArea();
				bigStuffedRingItem.SpawnContinuousArea(continuousIndex);
				this.PressCommonSuccessCount++;
				BigStuffedDollController.Instance.SetIntValueThenSendEvent(this.EntityId, "PressPerfectAreaSuccessCount", this.PressCommonSuccessCount);
				return;
			}
			case EAreaType.BonusArea:
			{
				int num3 = 0;
				if (config.HasValue)
				{
					if (config.IsT1)
					{
						num3 = config.AsT1.BonusScore;
					}
					else if (config.IsT2)
					{
						num3 = config.AsT2.BonusScore;
					}
				}
				this.ProgressItem.AddScore((float)num3, true);
				this.PressBonusSuccessCount++;
				BigStuffedDollController.Instance.SetIntValueThenSendEvent(this.EntityId, "PressBonusAreaSuccessCount", this.PressBonusSuccessCount);
				this.EnterBonusState();
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06045551 RID: 283985 RVA: 0x01127AF4 File Offset: 0x01125CF4
		private void EnterBonusState()
		{
			this.IsInBonusTime = true;
			this.TipItem.ShowTips("TeddyBear_Bonus", 3000);
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIButtonComponent button = base.GetButton(8);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			UUIButtonComponent qteLeftBtn = this.QteLeftBtn;
			if (qteLeftBtn != null)
			{
				qteLeftBtn.RootUIComp.Get().SetUIActive(true);
			}
			LevelSequencePlayer qteLeftBtnLevelSequence = this.QteLeftBtnLevelSequence;
			if (qteLeftBtnLevelSequence != null)
			{
				qteLeftBtnLevelSequence.PlayLevelSequenceByName("Start", false, null, false);
			}
			UUIButtonComponent qteRightBtn = this.QteRightBtn;
			if (qteRightBtn != null)
			{
				qteRightBtn.RootUIComp.Get().SetUIActive(true);
			}
			LevelSequencePlayer qteRightBtnLevelSequence = this.QteRightBtnLevelSequence;
			if (qteRightBtnLevelSequence == null)
			{
				return;
			}
			qteRightBtnLevelSequence.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06045552 RID: 283986 RVA: 0x01127BD0 File Offset: 0x01125DD0
		private void OnClickBack()
		{
			BigStuffedDollModel model = BigStuffedDollModel.Instance;
			model.SetGameStage(EGameStage.GamePause);
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BigStuffedBrokenRock);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.OnConfirmExit);
			confirmBoxDataNew.SetCloseFunction(delegate
			{
				model.SetGameStage(model.LastGameStage);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06045553 RID: 283987 RVA: 0x01127C3C File Offset: 0x01125E3C
		private void OnConfirmExit()
		{
			BigStuffedDollModel.Instance.GameResult = false;
			BigStuffedDollModel.Instance.SetGameStage(EGameStage.GameEnd);
		}

		// Token: 0x06045554 RID: 283988 RVA: 0x01127C54 File Offset: 0x01125E54
		private void OnClickCommonQte()
		{
			Log.Instance.Info(ELogModule.SceneGameplay, ELogAuthor.YSQ, "[BigStuffedDoll]QteButton Click", default(ReadOnlySpan<ValueTuple<string, object>>));
			BigStuffedGameInfo gameInfo = BigStuffedDollModel.Instance.GameInfo;
			int currentArrowStayRingId = gameInfo.CurrentArrowStayRingId;
			BigStuffedRingInfo ringInfo = gameInfo.GetRingInfo(currentArrowStayRingId);
			if (ringInfo == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[BigStuffedDoll]QteButtonClick:找不到当前所在的圆环";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ringId", gameInfo.CurrentArrowStayRingId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int currentArrowStayCellIndex = gameInfo.CurrentArrowStayCellIndex;
			ContinuousArea continuousArea = this.CheckInArea(ringInfo.GetBonusAreas(), currentArrowStayCellIndex);
			if (continuousArea != null)
			{
				this.OnAreaClick(EAreaType.BonusArea, continuousArea);
				return;
			}
			ContinuousArea continuousArea2 = this.CheckInArea(ringInfo.GetPerfectAreas(), currentArrowStayCellIndex);
			if (continuousArea2 != null)
			{
				this.OnAreaClick(EAreaType.PerfectArea, continuousArea2);
				return;
			}
			ContinuousArea continuousArea3 = this.CheckInArea(ringInfo.GetGoodAreas(), currentArrowStayCellIndex);
			if (continuousArea3 != null)
			{
				this.OnAreaClick(EAreaType.GoodArea, continuousArea3);
				return;
			}
			this.OnAreaClick(EAreaType.BlankArea, null);
		}

		// Token: 0x06045555 RID: 283989 RVA: 0x01127D33 File Offset: 0x01125F33
		private void OnClickLeftBonusQte()
		{
			this.OnClickBonusBtn(BigStuffedDollView.EBonusBtnType.Left);
		}

		// Token: 0x06045556 RID: 283990 RVA: 0x01127D3C File Offset: 0x01125F3C
		private void OnClickRightBonusQte()
		{
			this.OnClickBonusBtn(BigStuffedDollView.EBonusBtnType.Right);
		}

		// Token: 0x06045557 RID: 283991 RVA: 0x01127D48 File Offset: 0x01125F48
		private void OnClickBonusBtn(BigStuffedDollView.EBonusBtnType buttonType)
		{
			if (!this.IsInBonusTime)
			{
				return;
			}
			int currentArrowStayRingId = BigStuffedDollModel.Instance.GameInfo.CurrentArrowStayRingId;
			BigStuffedRingItem bigStuffedRingItem;
			this.RingItems.TryGetValue(currentArrowStayRingId, out bigStuffedRingItem);
			OneOf<BrokenRockRing, BrokenRockRingConfig>? oneOf = (bigStuffedRingItem != null) ? new OneOf<BrokenRockRing, BrokenRockRingConfig>?(bigStuffedRingItem.Config) : null;
			if (oneOf != null)
			{
				int num = 0;
				if (oneOf != null)
				{
					if (oneOf.Value.IsT1)
					{
						num = oneOf.Value.AsT1.BonusScore;
					}
					else if (oneOf.Value.IsT2)
					{
						num = oneOf.Value.AsT2.BonusScore;
					}
				}
				this.ProgressItem.AddScore((float)num, true);
			}
			if (buttonType != BigStuffedDollView.EBonusBtnType.Left)
			{
				if (buttonType != BigStuffedDollView.EBonusBtnType.Right)
				{
					return;
				}
				LevelSequencePlayer qteRightBtnLevelSequence = this.QteRightBtnLevelSequence;
				if (qteRightBtnLevelSequence != null)
				{
					qteRightBtnLevelSequence.StopCurrentSequence(false, true);
				}
				LevelSequencePlayer qteRightBtnLevelSequence2 = this.QteRightBtnLevelSequence;
				if (qteRightBtnLevelSequence2 == null)
				{
					return;
				}
				qteRightBtnLevelSequence2.PlayLevelSequenceByName("Press", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer qteLeftBtnLevelSequence = this.QteLeftBtnLevelSequence;
				if (qteLeftBtnLevelSequence != null)
				{
					qteLeftBtnLevelSequence.StopCurrentSequence(false, true);
				}
				LevelSequencePlayer qteLeftBtnLevelSequence2 = this.QteLeftBtnLevelSequence;
				if (qteLeftBtnLevelSequence2 == null)
				{
					return;
				}
				qteLeftBtnLevelSequence2.PlayLevelSequenceByName("Press", false, null, false);
				return;
			}
		}

		// Token: 0x06045558 RID: 283992 RVA: 0x01127E84 File Offset: 0x01126084
		[return: Nullable(2)]
		private ContinuousArea CheckInArea(Dictionary<int, ContinuousArea> areas, int currentArrowStayCellIndex)
		{
			foreach (KeyValuePair<int, ContinuousArea> keyValuePair in areas)
			{
				ContinuousArea value = keyValuePair.Value;
				int startCellIndex = value.StartCellIndex;
				int endCellIndex = value.EndCellIndex;
				if (endCellIndex >= startCellIndex)
				{
					if (currentArrowStayCellIndex >= startCellIndex && currentArrowStayCellIndex <= endCellIndex)
					{
						return value;
					}
				}
				else
				{
					bool flag = currentArrowStayCellIndex >= startCellIndex && currentArrowStayCellIndex <= 36;
					bool flag2 = currentArrowStayCellIndex >= 1 && currentArrowStayCellIndex <= endCellIndex;
					if (flag || flag2)
					{
						return value;
					}
				}
			}
			return null;
		}

		// Token: 0x06045559 RID: 283993 RVA: 0x01127F2C File Offset: 0x0112612C
		[NullableContext(2)]
		private void OnAreaClick(EAreaType areaType, ContinuousArea area)
		{
			BigStuffedGameInfo gameInfo = BigStuffedDollModel.Instance.GameInfo;
			int currentArrowStayRingId = gameInfo.CurrentArrowStayRingId;
			BigStuffedRingItem bigStuffedRingItem;
			if (!this.RingItems.TryGetValue(currentArrowStayRingId, out bigStuffedRingItem))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[BigStuffedDoll]OnAreaClick:找不到当前的RingItem";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ringId", gameInfo.CurrentArrowStayRingId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			OneOf<BrokenRockRing, BrokenRockRingConfig> config = bigStuffedRingItem.Config;
			if (config == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneGameplay;
				ELogAuthor author2 = ELogAuthor.YSQ;
				string message2 = "[BigStuffedDoll]OnAreaClick:找不到当前的RingConfig";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ringId", gameInfo.CurrentArrowStayRingId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			int num = 0;
			if (config.HasValue)
			{
				if (config.IsT1)
				{
					num = config.AsT1.ColdTime;
				}
				else if (config.IsT2)
				{
					num = config.AsT2.ColdTime;
				}
			}
			if (TimeUtil.Instance.GetServerStopTimeStamp() - this.LastClickAreaTime <= (double)num)
			{
				return;
			}
			this.LastClickAreaTime = TimeUtil.Instance.GetServerStopTimeStamp();
			UUIButtonComponent button = base.GetButton(8);
			UUIButtonComponent button3 = button;
			if (button3 != null)
			{
				button3.SetSelfInteractive(false);
			}
			TimerSystem.Instance.Delay(delegate(float _)
			{
				UUIButtonComponent button2 = button;
				if (button2 == null)
				{
					return;
				}
				button2.SetSelfInteractive(true);
			}, (float)num, null, null, true, 1f);
			bigStuffedRingItem.OnAreaClick(areaType, area);
		}

		// Token: 0x0604555A RID: 283994 RVA: 0x0112808C File Offset: 0x0112628C
		private void OnQteLeftBtnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start" || sequenceName == "Press")
			{
				this.QteLeftBtnLevelSequence.PlayLevelSequenceByName("Loop", false, null, false);
			}
		}

		// Token: 0x0604555B RID: 283995 RVA: 0x011280D0 File Offset: 0x011262D0
		private void OnQteRightBtnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start" || sequenceName == "Press")
			{
				this.QteRightBtnLevelSequence.PlayLevelSequenceByName("Loop", false, null, false);
			}
		}

		// Token: 0x0402427F RID: 148095
		private const int BONUS_TIME_TIPSTAYTIME = 3000;

		// Token: 0x04024280 RID: 148096
		private const string COUNTDOWNSTART = "CountDownStart";

		// Token: 0x04024281 RID: 148097
		private const string COUNTDOWNOVER = "CountDownOver";

		// Token: 0x04024282 RID: 148098
		private const string GAMEOVER = "GameOver";

		// Token: 0x04024283 RID: 148099
		private const string PRESS_FAIL_COUNT = "PressFailCount";

		// Token: 0x04024284 RID: 148100
		private const string PRESS_COMMONAREA_SUCCESS_COUNT = "PressCommonAreaSuccessCount";

		// Token: 0x04024285 RID: 148101
		private const string PRESS_PERFECTAREA_SUCCESS_COUNT = "PressPerfectAreaSuccessCount";

		// Token: 0x04024286 RID: 148102
		private const string PRESS_BONUSAREA_SUCCESS_COUNT = "PressBonusAreaSuccessCount";

		// Token: 0x04024287 RID: 148103
		private const string FINISH_SKILL_OVER = "FinishSkillOver";

		// Token: 0x04024288 RID: 148104
		private const string DELAY_FINISH_TIME = "DelayFinishTime";

		// Token: 0x04024289 RID: 148105
		private const string QTE_ROCK_DESTORY_EVENT = "BrokenRockEventKey6";

		// Token: 0x0402428A RID: 148106
		private readonly Dictionary<int, BigStuffedRingItem> RingItems = new Dictionary<int, BigStuffedRingItem>();

		// Token: 0x0402428B RID: 148107
		private readonly BigStuffedDollProgressItem ProgressItem = new BigStuffedDollProgressItem();

		// Token: 0x0402428C RID: 148108
		private readonly PrepareCountDownItem PrepareCountDownItem = new PrepareCountDownItem();

		// Token: 0x0402428D RID: 148109
		private readonly GameCountDownItem GameCountDownItem = new GameCountDownItem();

		// Token: 0x0402428E RID: 148110
		private readonly BigStuffedDollTipItem TipItem = new BigStuffedDollTipItem();

		// Token: 0x0402428F RID: 148111
		private readonly BigStuffedDollChallengeSuccessItem GameSuccessItem = new BigStuffedDollChallengeSuccessItem();

		// Token: 0x04024290 RID: 148112
		private readonly BigStuffedDollChallengeFailItem GameFailItem = new BigStuffedDollChallengeFailItem();

		// Token: 0x04024291 RID: 148113
		private double LastClickAreaTime;

		// Token: 0x04024292 RID: 148114
		private bool IsInBonusTime;

		// Token: 0x04024293 RID: 148115
		[Nullable(2)]
		private UUIButtonComponent QteLeftBtn;

		// Token: 0x04024294 RID: 148116
		[Nullable(2)]
		private UUIButtonComponent QteRightBtn;

		// Token: 0x04024295 RID: 148117
		[Nullable(2)]
		private LevelSequencePlayer QteLeftBtnLevelSequence;

		// Token: 0x04024296 RID: 148118
		[Nullable(2)]
		private LevelSequencePlayer QteRightBtnLevelSequence;

		// Token: 0x04024297 RID: 148119
		private int EntityId = -1;

		// Token: 0x04024298 RID: 148120
		private int PressCommonSuccessCount;

		// Token: 0x04024299 RID: 148121
		private int PressBonusSuccessCount;

		// Token: 0x0402429A RID: 148122
		private int PressFailCount;

		// Token: 0x0402429B RID: 148123
		[Nullable(2)]
		private Action FinishCallback;

		// Token: 0x0402429C RID: 148124
		private bool IsExecutedFinish;

		// Token: 0x0200CD7C RID: 52604
		[NullableContext(0)]
		private class EViewComponent
		{
			// Token: 0x0403DEB7 RID: 253623
			public const int GameUiRoot = 0;

			// Token: 0x0403DEB8 RID: 253624
			public const int BackBtn = 1;

			// Token: 0x0403DEB9 RID: 253625
			public const int ProgressItem = 2;

			// Token: 0x0403DEBA RID: 253626
			public const int QteLeftBtn = 3;

			// Token: 0x0403DEBB RID: 253627
			public const int QteRightBtn = 4;

			// Token: 0x0403DEBC RID: 253628
			public const int RingItemRoot = 5;

			// Token: 0x0403DEBD RID: 253629
			public const int RingItem = 6;

			// Token: 0x0403DEBE RID: 253630
			public const int QteTipItem = 7;

			// Token: 0x0403DEBF RID: 253631
			public const int BtnSingleQte = 8;
		}

		// Token: 0x0200CD7D RID: 52605
		[NullableContext(0)]
		private enum EBonusBtnType
		{
			// Token: 0x0403DEC1 RID: 253633
			Left,
			// Token: 0x0403DEC2 RID: 253634
			Right
		}
	}
}
