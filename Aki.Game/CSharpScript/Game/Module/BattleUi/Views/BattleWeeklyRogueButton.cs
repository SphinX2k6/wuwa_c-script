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
	// Token: 0x02004D0D RID: 19725
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleWeeklyRogueButton : FormationExtraButton
	{
		// Token: 0x06031713 RID: 202515 RVA: 0x00DD2B44 File Offset: 0x00DD0D44
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

		// Token: 0x06031714 RID: 202516 RVA: 0x00DD2CF4 File Offset: 0x00DD0EF4
		protected override UniTask OnBeforeStartAsync()
		{
			BattleWeeklyRogueButton.<OnBeforeStartAsync>d__27 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleWeeklyRogueButton.<OnBeforeStartAsync>d__27>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031715 RID: 202517 RVA: 0x00DD2D38 File Offset: 0x00DD0F38
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

		// Token: 0x06031716 RID: 202518 RVA: 0x00DD2E70 File Offset: 0x00DD1070
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

		// Token: 0x06031717 RID: 202519 RVA: 0x00DD2F4B File Offset: 0x00DD114B
		private void OnCycleRefresh()
		{
			EventSystem.Instance.Remove(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
			this.InitScoreWhenEnable();
			this.SetVisible(true);
		}

		// Token: 0x06031718 RID: 202520 RVA: 0x00DD2F78 File Offset: 0x00DD1178
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

		// Token: 0x06031719 RID: 202521 RVA: 0x00DD3234 File Offset: 0x00DD1434
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

		// Token: 0x0603171A RID: 202522 RVA: 0x00DD32E8 File Offset: 0x00DD14E8
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

		// Token: 0x0603171B RID: 202523 RVA: 0x00DD33B4 File Offset: 0x00DD15B4
		private void BattleScoreChanged(int scoreId, int score)
		{
			if (!this.IsScoreEnable || this.MinScoreLevelConfig == null || !this.IsValidScore(scoreId))
			{
				return;
			}
			this.OnBattleScoreChanged((float)score);
		}

		// Token: 0x0603171C RID: 202524 RVA: 0x00DD33E0 File Offset: 0x00DD15E0
		private bool IsValidScore(int scoreId)
		{
			if (this.ScoreId == scoreId)
			{
				return true;
			}
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, true);
			return scoreConfig != null && scoreConfig.Value.Type == 7;
		}

		// Token: 0x0603171D RID: 202525 RVA: 0x00DD3424 File Offset: 0x00DD1624
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

		// Token: 0x0603171E RID: 202526 RVA: 0x00DD34A4 File Offset: 0x00DD16A4
		public override void Tick(float delta)
		{
			if (this.HasValidConfig && this.TickScore != this.TickEndScore && base.GetActive())
			{
				this.SmoothTime = Math.Min(200f, this.SmoothTime + delta);
				float num = this.SmoothTime / 200f;
				this.SetCurScore(this.TickStartScore * (1f - num) + this.TickEndScore * num);
			}
		}

		// Token: 0x0603171F RID: 202527 RVA: 0x00DD3514 File Offset: 0x00DD1714
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

		// Token: 0x06031720 RID: 202528 RVA: 0x00DD3594 File Offset: 0x00DD1794
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

		// Token: 0x06031721 RID: 202529 RVA: 0x00DD35EA File Offset: 0x00DD17EA
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshKeyItemVisible();
		}

		// Token: 0x06031722 RID: 202530 RVA: 0x00DD35F2 File Offset: 0x00DD17F2
		private void OnWeeklyRogueLinkStageChange(ENewLinkStatus stage)
		{
			this.SetIsBursting(stage == ENewLinkStatus.Burst);
		}

		// Token: 0x06031723 RID: 202531 RVA: 0x00DD35FE File Offset: 0x00DD17FE
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

		// Token: 0x06031724 RID: 202532 RVA: 0x00DD3635 File Offset: 0x00DD1835
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

		// Token: 0x06031725 RID: 202533 RVA: 0x00DD3649 File Offset: 0x00DD1849
		private void OnClicked()
		{
			this.LinkAction();
		}

		// Token: 0x06031726 RID: 202534 RVA: 0x00DD3654 File Offset: 0x00DD1854
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

		// Token: 0x06031727 RID: 202535 RVA: 0x00DD36AB File Offset: 0x00DD18AB
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

		// Token: 0x06031728 RID: 202536 RVA: 0x00DD36CC File Offset: 0x00DD18CC
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

		// Token: 0x06031729 RID: 202537 RVA: 0x00DD371C File Offset: 0x00DD191C
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

		// Token: 0x0603172A RID: 202538 RVA: 0x00DD376C File Offset: 0x00DD196C
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

		// Token: 0x0603172B RID: 202539 RVA: 0x00DD38E0 File Offset: 0x00DD1AE0
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

		// Token: 0x0401A2F5 RID: 107253
		private const float MAX_SMOOTH_TIME = 200f;

		// Token: 0x0401A2F6 RID: 107254
		private const float CLICK_CD = 500f;

		// Token: 0x0401A2F7 RID: 107255
		private CombineKeyItem KeyItemPc;

		// Token: 0x0401A2F8 RID: 107256
		private CombineKeyItem KeyItemGp;

		// Token: 0x0401A2F9 RID: 107257
		public bool IsScoreEnable;

		// Token: 0x0401A2FA RID: 107258
		private int ScoreId;

		// Token: 0x0401A2FB RID: 107259
		private UUITexture BarTex;

		// Token: 0x0401A2FC RID: 107260
		private UUIItem PointItem;

		// Token: 0x0401A2FD RID: 107261
		private bool HasValidConfig;

		// Token: 0x0401A2FE RID: 107262
		private float TickStartScore;

		// Token: 0x0401A2FF RID: 107263
		private float TickEndScore;

		// Token: 0x0401A300 RID: 107264
		private float TickScore;

		// Token: 0x0401A301 RID: 107265
		private float MaxScore;

		// Token: 0x0401A302 RID: 107266
		private float SmoothTime;

		// Token: 0x0401A303 RID: 107267
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401A304 RID: 107268
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401A305 RID: 107269
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401A306 RID: 107270
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401A307 RID: 107271
		private bool IsBursting;

		// Token: 0x0401A308 RID: 107272
		private bool IsFull;

		// Token: 0x0401A309 RID: 107273
		private int ArtifactId;

		// Token: 0x0401A30A RID: 107274
		private RogueWeeklyBuffPool? ArtifactConfig;

		// Token: 0x0401A30B RID: 107275
		private int LoadIconId = -1;

		// Token: 0x0401A30C RID: 107276
		private double NextClickTime;

		// Token: 0x0200A9C0 RID: 43456
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x0403473D RID: 214845
			KeyItemPc = 8,
			// Token: 0x0403473E RID: 214846
			KeyItemGp
		}

		// Token: 0x0200A9C1 RID: 43457
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034740 RID: 214848
			BtnClick,
			// Token: 0x04034741 RID: 214849
			BarTex,
			// Token: 0x04034742 RID: 214850
			EmptyBgTex,
			// Token: 0x04034743 RID: 214851
			FullBgTex,
			// Token: 0x04034744 RID: 214852
			FullItem,
			// Token: 0x04034745 RID: 214853
			PointItem,
			// Token: 0x04034746 RID: 214854
			IconTex,
			// Token: 0x04034747 RID: 214855
			GlowEffect
		}
	}
}
