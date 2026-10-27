using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D2B RID: 23851
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleWeeklyRogueButton : FormationExtraButton
	{
		// Token: 0x0603C7BA RID: 247738 RVA: 0x00E823A4 File Offset: 0x00E805A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(8, typeof(UUIItem)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUIItem)));
			}
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603C7BB RID: 247739 RVA: 0x00E82554 File Offset: 0x00E80754
		protected override UniTask OnBeforeStartAsync()
		{
			BattleWeeklyRogueButton.<OnBeforeStartAsync>d__27 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleWeeklyRogueButton.<OnBeforeStartAsync>d__27>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C7BC RID: 247740 RVA: 0x00E82598 File Offset: 0x00E80798
		protected override void OnStart()
		{
			base.OnStart();
			if (!Info.Instance.IsInTouch())
			{
				CombineKeyItem keyItemPc = this.KeyItemPc;
				if (keyItemPc != null)
				{
					keyItemPc.RefreshAction("Link大招");
				}
				CombineKeyItem keyItemGp = this.KeyItemGp;
				if (keyItemGp != null)
				{
					keyItemGp.RefreshAction("Link大招");
				}
				this.RefreshKeyItemVisible();
			}
			this.BarTex = base.GetTexture(1);
			this.PointItem = base.GetItem(5);
			if (WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
			{
				bool flag = WeeklyRogueModel.Instance.CurrentActivityId != 0;
				this.IsScoreEnable = flag;
				if (!flag)
				{
					EventSystem.Instance.Add(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
					this.SetVisible(false);
				}
				else
				{
					this.InitScoreWhenEnable();
				}
			}
			this.UpdateEnableClickState();
			this.RefreshNodeVisibleByState();
			EventSystem.Instance.Add<int, int>(EEventName.BattleScoreChanged, new Action<int, int>(this.BattleScoreChanged));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add<ENewLinkStatus>(EEventName.OnNewLinkStatusChanged, new Action<ENewLinkStatus>(this.OnWeeklyRogueLinkStageChange));
			InputDistributeController.Instance.BindAction("Link大招", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603C7BD RID: 247741 RVA: 0x00E826D0 File Offset: 0x00E808D0
		protected override void OnBeforeDestroy()
		{
			if (EventSystem.Instance.Has(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh)))
			{
				EventSystem.Instance.Remove(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
			}
			EventSystem.Instance.Remove(EEventName.BattleScoreChanged, new Action<int, int>(this.BattleScoreChanged));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove(EEventName.OnNewLinkStatusChanged, new Action<ENewLinkStatus>(this.OnWeeklyRogueLinkStageChange));
			InputDistributeController.Instance.UnBindAction("Link大招", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			if (this.LoadIconId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadIconId);
				this.LoadIconId = -1;
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0603C7BE RID: 247742 RVA: 0x00E827AB File Offset: 0x00E809AB
		private void OnCycleRefresh()
		{
			EventSystem.Instance.Remove(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
			this.InitScoreWhenEnable();
			this.SetVisible(true);
		}

		// Token: 0x0603C7BF RID: 247743 RVA: 0x00E827D8 File Offset: 0x00E809D8
		private unsafe void InitScoreWhenEnable()
		{
			this.IsScoreEnable = true;
			this.ArtifactId = WeeklyRogueModel.Instance.GetArtifactBuffId();
			if (this.ArtifactId != 0)
			{
				this.ArtifactConfig = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(this.ArtifactId);
			}
			int cycleId = WeeklyRogueModel.Instance.ActivityData.CycleId;
			RogueWeeklyCycle? cycleConfig = WeeklyRogueModel.Instance.ActivityData.GetCycleConfig();
			int? num = (cycleConfig != null) ? new int?(cycleConfig.GetValueOrDefault().LinkId) : null;
			if (num == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.WeeklyRogue;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "周常肉鸽获取不到link配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cycleId", cycleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LinkData? linkDataConfig = BattleLinkConfig.Instance.GetLinkDataConfig(num.Value);
			int? num2 = (linkDataConfig != null) ? new int?(linkDataConfig.GetValueOrDefault().BattleScoreId) : null;
			if (num2 == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.WeeklyRogue;
				ELogAuthor author2 = ELogAuthor.CFT;
				string message2 = "周常肉鸽获取不到战斗评分配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cycleId", cycleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("linkId", num);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.ScoreId = num2.Value;
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(num2.Value, true);
			int? num3 = (scoreConfig != null) ? new int?(scoreConfig.GetValueOrDefault().LevelGroupId) : null;
			if (num3 == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.WeeklyRogue;
				ELogAuthor author3 = ELogAuthor.CFT;
				string message3 = "周常肉鸽获取不到战斗评分等级配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("cycleId", cycleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("linkId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("scoreId", num2);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			this.CurScoreLevelConfigList = BattleScoreConfig.Instance.GetBattleScoreActionConfigByGroupId(num3.Value);
			if (this.CurScoreLevelConfigList != null && this.CurScoreLevelConfigList.Count > 0)
			{
				this.UpdateMaxAndMinScore();
			}
			else
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.WeeklyRogue;
				ELogAuthor author4 = ELogAuthor.CFT;
				string message4 = "周常肉鸽获取不到战斗评分等级配置";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("groupId", num3);
				instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			this.SetCurScore(0f);
			this.RefreshIcon();
		}

		// Token: 0x0603C7C0 RID: 247744 RVA: 0x00E82A94 File Offset: 0x00E80C94
		private void RefreshIcon()
		{
			UUITexture iconTexture = base.GetTexture(6);
			iconTexture.SetUIActive(false);
			string text = (this.ArtifactConfig != null) ? this.ArtifactConfig.GetValueOrDefault().ButtonIcon : null;
			if (!string.IsNullOrEmpty(text))
			{
				this.LoadIconId = ResourceSystem.Instance.LoadAsync<UTexture2D>(text, delegate([Nullable(2)] UTexture2D iconTextureData, string _)
				{
					this.LoadIconId = -1;
					if (iconTextureData == null)
					{
						return;
					}
					iconTexture.SetUIActive(true);
					iconTexture.SetTexture(iconTextureData);
				}, 103, "js_undefined");
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WeeklyRogue;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "[WeeklyRogue]神器图标路径为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("神器Id", this.ArtifactId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603C7C1 RID: 247745 RVA: 0x00E82B48 File Offset: 0x00E80D48
		private void UpdateMaxAndMinScore()
		{
			this.MinScoreLevelConfig = null;
			this.MaxScoreLevelConfig = null;
			int num = int.MaxValue;
			int num2 = 0;
			foreach (BattleScoreLevelConf value in this.CurScoreLevelConfigList)
			{
				int level = value.Level;
				if (num > level)
				{
					num = level;
					this.MinScoreLevelConfig = new BattleScoreLevelConf?(value);
				}
				if (num2 < level)
				{
					num2 = level;
					this.MaxScoreLevelConfig = new BattleScoreLevelConf?(value);
				}
			}
			this.MaxScore = (float)((this.MaxScoreLevelConfig != null) ? this.MaxScoreLevelConfig.GetValueOrDefault().LowerUpperLimits(0) : 0);
			float maxScore = this.MaxScore;
		}

		// Token: 0x0603C7C2 RID: 247746 RVA: 0x00E82C14 File Offset: 0x00E80E14
		private void BattleScoreChanged(int scoreId, int score)
		{
			if (!this.IsScoreEnable || this.MinScoreLevelConfig == null || !this.IsValidScore(scoreId))
			{
				return;
			}
			this.OnBattleScoreChanged((float)score);
		}

		// Token: 0x0603C7C3 RID: 247747 RVA: 0x00E82C40 File Offset: 0x00E80E40
		private bool IsValidScore(int scoreId)
		{
			if (this.ScoreId == scoreId)
			{
				return true;
			}
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, true);
			return scoreConfig != null && scoreConfig.Value.Type == 7;
		}

		// Token: 0x0603C7C4 RID: 247748 RVA: 0x00E82C84 File Offset: 0x00E80E84
		private void OnBattleScoreChanged(float score)
		{
			if (score < (float)this.MinScoreLevelConfig.Value.LowerUpperLimits(0))
			{
				this.CurScoreLevelConfig = null;
			}
			else if (score >= (float)this.MaxScoreLevelConfig.Value.LowerUpperLimits(1))
			{
				this.CurScoreLevelConfig = this.MaxScoreLevelConfig;
			}
			else
			{
				this.CurScoreLevelConfig = this.MinScoreLevelConfig;
			}
			this.HasValidConfig = (this.CurScoreLevelConfig != null);
			this.SetTickEndScore(score);
		}

		// Token: 0x0603C7C5 RID: 247749 RVA: 0x00E82D04 File Offset: 0x00E80F04
		public override void Tick(float delta)
		{
			if (this.HasValidConfig && this.TickScore != this.TickEndScore && base.GetActive())
			{
				this.SmoothTime = Math.Min(200f, this.SmoothTime + delta);
				float num = this.SmoothTime / 200f;
				this.SetCurScore(this.TickStartScore * (1f - num) + this.TickEndScore * num);
			}
		}

		// Token: 0x0603C7C6 RID: 247750 RVA: 0x00E82D74 File Offset: 0x00E80F74
		private void SetCurScore(float score)
		{
			this.TickScore = score;
			if (this.MaxScore > 0f)
			{
				float num = this.TickScore / this.MaxScore;
				UUIItem pointItem = this.PointItem;
				if (pointItem != null)
				{
					FRotator frotator = new FRotator();
					frotator.Yaw = num * -360f;
					pointItem.SetUIRelativeRotation(frotator);
				}
				UUITexture barTex = this.BarTex;
				if (barTex != null)
				{
					barTex.SetFillAmount(num);
				}
			}
			this.SetIsFull(this.TickScore >= this.MaxScore);
		}

		// Token: 0x0603C7C7 RID: 247751 RVA: 0x00E82DF4 File Offset: 0x00E80FF4
		private void SetTickEndScore(float score)
		{
			if (score > 0f)
			{
				this.TickStartScore = this.TickScore;
				this.TickEndScore = score;
				this.SmoothTime = 0f;
				return;
			}
			this.TickStartScore = this.TickScore;
			this.TickEndScore = 0f;
			this.SmoothTime = 200f;
		}

		// Token: 0x0603C7C8 RID: 247752 RVA: 0x00E82E4A File Offset: 0x00E8104A
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshKeyItemVisible();
		}

		// Token: 0x0603C7C9 RID: 247753 RVA: 0x00E82E52 File Offset: 0x00E81052
		private void OnWeeklyRogueLinkStageChange(ENewLinkStatus stage)
		{
			this.SetIsBursting(stage == ENewLinkStatus.Burst);
		}

		// Token: 0x0603C7CA RID: 247754 RVA: 0x00E82E5E File Offset: 0x00E8105E
		private void RefreshKeyItemVisible()
		{
			CombineKeyItem keyItemPc = this.KeyItemPc;
			if (keyItemPc != null)
			{
				keyItemPc.SetUiActive(Info.Instance.IsInKeyBoard());
			}
			CombineKeyItem keyItemGp = this.KeyItemGp;
			if (keyItemGp == null)
			{
				return;
			}
			keyItemGp.SetUiActive(Info.Instance.IsInGamepad());
		}

		// Token: 0x0603C7CB RID: 247755 RVA: 0x00E82E95 File Offset: 0x00E81095
		[NullableContext(1)]
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (!base.GetActive())
			{
				return;
			}
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				this.LinkAction();
			}
		}

		// Token: 0x0603C7CC RID: 247756 RVA: 0x00E82EA9 File Offset: 0x00E810A9
		private void OnClicked()
		{
			this.LinkAction();
		}

		// Token: 0x0603C7CD RID: 247757 RVA: 0x00E82EB4 File Offset: 0x00E810B4
		private void LinkAction()
		{
			if (!this.IsFull || this.IsBursting)
			{
				return;
			}
			if (Time.Instance.Now < this.NextClickTime)
			{
				return;
			}
			if (WeeklyRogueController.Instance.RequestNewLinkBurst())
			{
				this.NextClickTime = Time.Instance.Now + 500.0;
			}
		}

		// Token: 0x0603C7CE RID: 247758 RVA: 0x00E82F0B File Offset: 0x00E8110B
		private void SetIsFull(bool value)
		{
			if (this.IsFull == value)
			{
				return;
			}
			this.IsFull = value;
			this.UpdateEnableClickState();
			this.RefreshNodeVisibleByState();
		}

		// Token: 0x0603C7CF RID: 247759 RVA: 0x00E82F2C File Offset: 0x00E8112C
		private void SetIsBursting(bool value)
		{
			if (this.IsBursting == value)
			{
				return;
			}
			this.IsBursting = value;
			this.UpdateEnableClickState();
			this.RefreshNodeVisibleByState();
			if (value)
			{
				HudUnitController.Instance.TryCreateHud(EHudUnitType.WeeklyRogue);
			}
			EventSystem.Instance.Emit<bool>(EEventName.WeeklyRogueBurstEnableChange, this.IsBursting);
		}

		// Token: 0x0603C7D0 RID: 247760 RVA: 0x00E82F7C File Offset: 0x00E8117C
		private void UpdateEnableClickState()
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			bool flag = this.IsFull && !this.IsBursting;
			this.KeyItemPc.SetGray(!flag);
			this.KeyItemGp.SetGray(!flag);
		}

		// Token: 0x0603C7D1 RID: 247761 RVA: 0x00E82FCC File Offset: 0x00E811CC
		private void RefreshNodeVisibleByState()
		{
			if (this.IsBursting)
			{
				UUITexture texture = base.GetTexture(2);
				if (texture != null)
				{
					texture.SetUIActive(true);
				}
				UUITexture texture2 = base.GetTexture(3);
				if (texture2 != null)
				{
					texture2.SetUIActive(false);
				}
				UUIItem item = base.GetItem(4);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUINiagara uiNiagara = base.GetUiNiagara(7);
				if (uiNiagara != null)
				{
					uiNiagara.SetUIActive(false);
				}
				UUITexture texture3 = base.GetTexture(1);
				if (texture3 != null)
				{
					texture3.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(5);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
			else if (this.IsFull)
			{
				UUITexture texture4 = base.GetTexture(2);
				if (texture4 != null)
				{
					texture4.SetUIActive(false);
				}
				UUITexture texture5 = base.GetTexture(3);
				if (texture5 != null)
				{
					texture5.SetUIActive(true);
				}
				UUIItem item3 = base.GetItem(4);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
				UUINiagara uiNiagara2 = base.GetUiNiagara(7);
				if (uiNiagara2 != null)
				{
					uiNiagara2.SetUIActive(true);
				}
				UUITexture texture6 = base.GetTexture(1);
				if (texture6 != null)
				{
					texture6.SetUIActive(true);
				}
				UUIItem item4 = base.GetItem(5);
				if (item4 == null)
				{
					return;
				}
				item4.SetUIActive(false);
				return;
			}
			else
			{
				UUITexture texture7 = base.GetTexture(2);
				if (texture7 != null)
				{
					texture7.SetUIActive(true);
				}
				UUITexture texture8 = base.GetTexture(3);
				if (texture8 != null)
				{
					texture8.SetUIActive(false);
				}
				UUIItem item5 = base.GetItem(4);
				if (item5 != null)
				{
					item5.SetUIActive(false);
				}
				UUINiagara uiNiagara3 = base.GetUiNiagara(7);
				if (uiNiagara3 != null)
				{
					uiNiagara3.SetUIActive(false);
				}
				UUITexture texture9 = base.GetTexture(1);
				if (texture9 != null)
				{
					texture9.SetUIActive(true);
				}
				UUIItem item6 = base.GetItem(5);
				if (item6 == null)
				{
					return;
				}
				item6.SetUIActive(true);
				return;
			}
		}

		// Token: 0x0603C7D2 RID: 247762 RVA: 0x00E83140 File Offset: 0x00E81340
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			UUIButtonComponent button = base.GetButton(0);
			UUIItem uuiitem = (button != null) ? button.GetRootComponent() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401F83C RID: 129084
		private const float MAX_SMOOTH_TIME = 200f;

		// Token: 0x0401F83D RID: 129085
		private const float CLICK_CD = 500f;

		// Token: 0x0401F83E RID: 129086
		private CombineKeyItem KeyItemPc;

		// Token: 0x0401F83F RID: 129087
		private CombineKeyItem KeyItemGp;

		// Token: 0x0401F840 RID: 129088
		public bool IsScoreEnable;

		// Token: 0x0401F841 RID: 129089
		private int ScoreId;

		// Token: 0x0401F842 RID: 129090
		private UUITexture BarTex;

		// Token: 0x0401F843 RID: 129091
		private UUIItem PointItem;

		// Token: 0x0401F844 RID: 129092
		private bool HasValidConfig;

		// Token: 0x0401F845 RID: 129093
		private float TickStartScore;

		// Token: 0x0401F846 RID: 129094
		private float TickEndScore;

		// Token: 0x0401F847 RID: 129095
		private float TickScore;

		// Token: 0x0401F848 RID: 129096
		private float MaxScore;

		// Token: 0x0401F849 RID: 129097
		private float SmoothTime;

		// Token: 0x0401F84A RID: 129098
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401F84B RID: 129099
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401F84C RID: 129100
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401F84D RID: 129101
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401F84E RID: 129102
		private bool IsBursting;

		// Token: 0x0401F84F RID: 129103
		private bool IsFull;

		// Token: 0x0401F850 RID: 129104
		private int ArtifactId;

		// Token: 0x0401F851 RID: 129105
		private RogueWeeklyBuffPool? ArtifactConfig;

		// Token: 0x0401F852 RID: 129106
		private int LoadIconId = -1;

		// Token: 0x0401F853 RID: 129107
		private double NextClickTime;

		// Token: 0x0200BFBA RID: 49082
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x04039D7B RID: 236923
			KeyItemPc = 8,
			// Token: 0x04039D7C RID: 236924
			KeyItemGp
		}

		// Token: 0x0200BFBB RID: 49083
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039D7E RID: 236926
			BtnClick,
			// Token: 0x04039D7F RID: 236927
			BarTex,
			// Token: 0x04039D80 RID: 236928
			EmptyBgTex,
			// Token: 0x04039D81 RID: 236929
			FullBgTex,
			// Token: 0x04039D82 RID: 236930
			FullItem,
			// Token: 0x04039D83 RID: 236931
			PointItem,
			// Token: 0x04039D84 RID: 236932
			IconTex,
			// Token: 0x04039D85 RID: 236933
			GlowEffect
		}
	}
}
