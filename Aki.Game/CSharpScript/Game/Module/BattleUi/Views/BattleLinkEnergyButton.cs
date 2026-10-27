using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CD7 RID: 23767
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleLinkEnergyButton : FormationExtraButton
	{
		// Token: 0x0603C231 RID: 246321 RVA: 0x00E64D14 File Offset: 0x00E62F14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
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
		}

		// Token: 0x0603C232 RID: 246322 RVA: 0x00E64E88 File Offset: 0x00E63088
		protected override UniTask OnCreateAsync()
		{
			BattleLinkEnergyButton.<OnCreateAsync>d__37 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<BattleLinkEnergyButton.<OnCreateAsync>d__37>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C233 RID: 246323 RVA: 0x00E64ECC File Offset: 0x00E630CC
		protected override UniTask OnBeforeStartAsync()
		{
			BattleLinkEnergyButton.<OnBeforeStartAsync>d__38 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleLinkEnergyButton.<OnBeforeStartAsync>d__38>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C234 RID: 246324 RVA: 0x00E64F10 File Offset: 0x00E63110
		protected override void OnStart()
		{
			base.OnStart();
			this.LinkButton = base.GetButton(0);
			this.PointItem = base.GetItem(2);
			this.ScoreUiNiagara = base.GetUiNiagara(1);
			if (this.ScoreNiagara != null)
			{
				UUINiagara scoreUiNiagara = this.ScoreUiNiagara;
				if (scoreUiNiagara != null)
				{
					scoreUiNiagara.SetUIActive(false);
				}
				UUINiagara scoreUiNiagara2 = this.ScoreUiNiagara;
				if (scoreUiNiagara2 != null)
				{
					scoreUiNiagara2.SetNiagaraSystem(this.ScoreNiagara);
				}
			}
			this.ForbidItem = base.GetItem(3);
			this.LockItem = base.GetItem(4);
			this.Icon = base.GetTexture(5);
			this.IconBg = base.GetTexture(6);
			this.ReadyUiNiagara = base.GetUiNiagara(7);
			if (this.ReadyNiagara != null)
			{
				UUINiagara readyUiNiagara = this.ReadyUiNiagara;
				if (readyUiNiagara != null)
				{
					readyUiNiagara.SetUIActive(false);
				}
				UUINiagara readyUiNiagara2 = this.ReadyUiNiagara;
				if (readyUiNiagara2 != null)
				{
					readyUiNiagara2.SetNiagaraSystem(this.ReadyNiagara);
				}
			}
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
				if (Info.Instance.IsInKeyBoard())
				{
					CombineKeyItem keyItemPc2 = this.KeyItemPc;
					if (keyItemPc2 != null)
					{
						keyItemPc2.SetUiActive(true);
					}
				}
				else if (Info.Instance.IsInGamepad())
				{
					CombineKeyItem keyItemGp2 = this.KeyItemGp;
					if (keyItemGp2 != null)
					{
						keyItemGp2.SetUiActive(true);
					}
				}
			}
			UUIButtonComponent linkButton = this.LinkButton;
			if (linkButton != null)
			{
				linkButton.SetActive(true, false);
			}
			UUIButtonComponent linkButton2 = this.LinkButton;
			if (linkButton2 != null)
			{
				linkButton2.OnPointDownCallBack.Bind(new Action(this.OnPressLinkButton));
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.UpdateLinkConfig();
			this.RefreshLinkButton(BattleLinkModel.Instance.GetNewLinkStatus());
			EventSystem.Instance.Add<int, int>(EEventName.BattleScoreChanged, new Action<int, int>(this.OnBattleScoreChanged));
			EventSystem.Instance.Add<ENewLinkStatus>(EEventName.OnNewLinkStatusChanged, new Action<ENewLinkStatus>(this.OnNewLinkStatusChanged));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			InputDistributeController.Instance.BindAction("Link大招", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputLinkAction));
		}

		// Token: 0x0603C235 RID: 246325 RVA: 0x00E65130 File Offset: 0x00E63330
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			EventSystem.Instance.Remove(EEventName.BattleScoreChanged, new Action<int, int>(this.OnBattleScoreChanged));
			EventSystem.Instance.Remove(EEventName.OnNewLinkStatusChanged, new Action<ENewLinkStatus>(this.OnNewLinkStatusChanged));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			InputDistributeController.Instance.UnBindAction("Link大招", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputLinkAction));
			if (Info.Instance.IsInTouch())
			{
				UUIButtonComponent linkButton = this.LinkButton;
				if (linkButton != null)
				{
					linkButton.OnPointDownCallBack.Unbind();
				}
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0603C236 RID: 246326 RVA: 0x00E651EC File Offset: 0x00E633EC
		[NullableContext(1)]
		private UniTask LoadNiagara(string path)
		{
			BattleLinkEnergyButton.<LoadNiagara>d__41 <LoadNiagara>d__;
			<LoadNiagara>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadNiagara>d__.<>4__this = this;
			<LoadNiagara>d__.path = path;
			<LoadNiagara>d__.<>1__state = -1;
			<LoadNiagara>d__.<>t__builder.Start<BattleLinkEnergyButton.<LoadNiagara>d__41>(ref <LoadNiagara>d__);
			return <LoadNiagara>d__.<>t__builder.Task;
		}

		// Token: 0x0603C237 RID: 246327 RVA: 0x00E65237 File Offset: 0x00E63437
		[NullableContext(1)]
		private void OnInputLinkAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (!base.IsUiActiveInHierarchy())
			{
				return;
			}
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				this.LinkAction();
			}
		}

		// Token: 0x0603C238 RID: 246328 RVA: 0x00E6524B File Offset: 0x00E6344B
		private void OnPressLinkButton()
		{
			this.LinkAction();
		}

		// Token: 0x0603C239 RID: 246329 RVA: 0x00E65254 File Offset: 0x00E63454
		private void LinkAction()
		{
			if (CameraController.Instance.IsSequenceCameraInCinematic("MainCamera"))
			{
				return;
			}
			if (!Info.Instance.IsBuildShipping && BattleLinkModel.Instance.IsNewLinkGmTest())
			{
				BattleLinkController.Instance.NewLinkBurstTest().Forget();
				return;
			}
			if (!this.CheckAliveRoles())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Link_CannotCast_Tips", Array.Empty<object>());
				return;
			}
			if (BattleLinkModel.Instance.GetNewLinkStatus() == ENewLinkStatus.Ready)
			{
				if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - this.BurstTriggerCd < 1000L)
				{
					return;
				}
				this.BurstTriggerCd = DateTimeOffset.Now.ToUnixTimeMilliseconds();
				BattleLinkController.Instance.RequestNewLinkBurst();
			}
		}

		// Token: 0x0603C23A RID: 246330 RVA: 0x00E65300 File Offset: 0x00E63500
		private void OnBattleScoreChanged(int scoreId, int score)
		{
			if (!this.IsValidScore(scoreId))
			{
				return;
			}
			if (score < this.MinScoreLevelConfig.Value.LowerUpperLimits(0))
			{
				this.CurScoreLevelConfig = null;
			}
			else if (score >= this.MaxScoreLevelConfig.Value.LowerUpperLimits(1))
			{
				this.CurScoreLevelConfig = this.MaxScoreLevelConfig;
			}
			else
			{
				this.CurScoreLevelConfig = this.MinScoreLevelConfig;
			}
			this.UpdateScore(score, this.CurScoreLevelConfig);
		}

		// Token: 0x0603C23B RID: 246331 RVA: 0x00E6537A File Offset: 0x00E6357A
		private void OnNewLinkStatusChanged(ENewLinkStatus state)
		{
			this.UpdateLinkConfig();
			this.RefreshLinkButton(state);
			if (BattleLinkModel.Instance.IsNewLinkGmTest())
			{
				this.SetVisible(true);
			}
		}

		// Token: 0x0603C23C RID: 246332 RVA: 0x00E6539C File Offset: 0x00E6359C
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (Info.Instance.IsInKeyBoard())
			{
				CombineKeyItem keyItemPc = this.KeyItemPc;
				if (keyItemPc != null)
				{
					keyItemPc.SetUiActive(true);
				}
				CombineKeyItem keyItemGp = this.KeyItemGp;
				if (keyItemGp == null)
				{
					return;
				}
				keyItemGp.SetUiActive(false);
				return;
			}
			else if (Info.Instance.IsInGamepad())
			{
				CombineKeyItem keyItemPc2 = this.KeyItemPc;
				if (keyItemPc2 != null)
				{
					keyItemPc2.SetUiActive(false);
				}
				CombineKeyItem keyItemGp2 = this.KeyItemGp;
				if (keyItemGp2 == null)
				{
					return;
				}
				keyItemGp2.SetUiActive(true);
				return;
			}
			else
			{
				CombineKeyItem keyItemPc3 = this.KeyItemPc;
				if (keyItemPc3 != null)
				{
					keyItemPc3.SetUiActive(false);
				}
				CombineKeyItem keyItemGp3 = this.KeyItemGp;
				if (keyItemGp3 == null)
				{
					return;
				}
				keyItemGp3.SetUiActive(false);
				return;
			}
		}

		// Token: 0x0603C23D RID: 246333 RVA: 0x00E6542C File Offset: 0x00E6362C
		private void UpdateLinkConfig()
		{
			LinkData? linkConfig = BattleLinkModel.Instance.GetLinkConfig();
			if (linkConfig == null)
			{
				this.NewLinkId = 0;
				this.ScoreId = 0;
				return;
			}
			LinkData valueOrDefault = linkConfig.GetValueOrDefault();
			if (valueOrDefault.Id == this.NewLinkId)
			{
				return;
			}
			this.NewLinkId = valueOrDefault.Id;
			this.ScoreId = valueOrDefault.BattleScoreId;
			BattleScoreConf? battleScoreConfig = BattleScoreConfig.Instance.GetBattleScoreConfig(valueOrDefault.BattleScoreId);
			if (battleScoreConfig != null)
			{
				BattleScoreConf valueOrDefault2 = battleScoreConfig.GetValueOrDefault();
				this.CurScoreLevelConfigList = BattleScoreConfig.Instance.GetBattleScoreActionConfigByGroupId(valueOrDefault2.LevelGroupId);
				this.UpdateMaxAndMinScore();
				foreach (KeyValuePair<int, int> keyValuePair in BattleScoreModel.Instance.GetScoreMap())
				{
					int num;
					int num2;
					keyValuePair.Deconstruct(out num, out num2);
					int num3 = num;
					int score = num2;
					if (num3 == valueOrDefault.BattleScoreId)
					{
						this.OnBattleScoreChanged(num3, score);
						break;
					}
				}
			}
		}

		// Token: 0x0603C23E RID: 246334 RVA: 0x00E65540 File Offset: 0x00E63740
		private void UpdateScore(int score, BattleScoreLevelConf? scoreLevelConfig)
		{
			this.Score = score;
			this.HasValidConfig = (scoreLevelConfig != null);
			this.SetTickEndScore(score);
			if ((float)score >= this.MaxScore && !this.IsShowFull)
			{
				this.IsShowFull = true;
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.StopSequenceByKey("Restart", false, false);
				}
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.PlaySequencePurely("Full", false, false, null, null, false);
				}
				this.SetLinkButtonState(BattleLinkEnergyButton.ELinkButtonState.Full);
				return;
			}
			if ((float)score != this.MaxScore && this.IsShowFull)
			{
				this.IsShowFull = false;
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 != null)
				{
					levelSequencePlayer3.StopSequenceByKey("Full", false, false);
				}
				LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
				if (levelSequencePlayer4 != null)
				{
					levelSequencePlayer4.PlaySequencePurely("Restart", false, false, null, null, false);
				}
				this.SetLinkButtonState(BattleLinkEnergyButton.ELinkButtonState.Normal);
			}
		}

		// Token: 0x0603C23F RID: 246335 RVA: 0x00E65620 File Offset: 0x00E63820
		public override void Tick(float delta)
		{
			if (this.HasValidConfig && this.TickScore != this.TickEndScore && base.GetActive())
			{
				this.SmoothTime = Math.Min(200f, this.SmoothTime + delta * 1000f);
				float num = this.SmoothTime / 200f;
				this.TickScore = this.TickStartScore * (1f - num) + this.TickEndScore * num;
				if (this.MaxScore > 0f)
				{
					float num2 = this.TickScore / this.MaxScore;
					UUINiagara scoreUiNiagara = this.ScoreUiNiagara;
					if (scoreUiNiagara != null)
					{
						scoreUiNiagara.SetNiagaraVarFloat("Dissolve", num2);
					}
					UUIItem pointItem = this.PointItem;
					if (pointItem != null)
					{
						FRotator frotator = new FRotator();
						frotator.Yaw = num2 * -360f;
						pointItem.SetUIRelativeRotation(frotator);
					}
					UUIItem pointItem2 = this.PointItem;
					if (pointItem2 == null)
					{
						return;
					}
					pointItem2.SetUIActive(num2 > 0f && num2 < 1f);
				}
			}
		}

		// Token: 0x0603C240 RID: 246336 RVA: 0x00E6571C File Offset: 0x00E6391C
		private void SetTickEndScore(int score)
		{
			if (score > 0)
			{
				this.TickStartScore = this.TickScore;
				this.TickEndScore = (float)score;
				this.SmoothTime = 0f;
				return;
			}
			this.TickStartScore = this.TickScore;
			this.TickEndScore = 0f;
			this.SmoothTime = 200f;
		}

		// Token: 0x0603C241 RID: 246337 RVA: 0x00E65770 File Offset: 0x00E63970
		private void UpdateMaxAndMinScore()
		{
			this.MinScoreLevelConfig = null;
			this.MaxScoreLevelConfig = null;
			if (this.CurScoreLevelConfigList == null)
			{
				return;
			}
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
			this.MaxScore = (float)this.MaxScoreLevelConfig.Value.LowerUpperLimits(0);
			float maxScore = this.MaxScore;
		}

		// Token: 0x0603C242 RID: 246338 RVA: 0x00E6583C File Offset: 0x00E63A3C
		public bool IsValidScore(int scoreId)
		{
			return scoreId == this.ScoreId && BattleScoreModel.Instance.GetScoreConfig(scoreId, true) != null;
		}

		// Token: 0x0603C243 RID: 246339 RVA: 0x00E65870 File Offset: 0x00E63A70
		public bool CheckAliveRoles()
		{
			LinkData? linkConfig = BattleLinkModel.Instance.GetLinkConfig();
			if (linkConfig != null && linkConfig.Value.IsEnableOneRoleBurst != 0)
			{
				return true;
			}
			int num = 0;
			using (List<SceneTeamItem>.Enumerator enumerator = SceneTeamModel.Instance.GetTeamItems(false).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsDead())
					{
						num++;
					}
				}
			}
			return num > 1;
		}

		// Token: 0x0603C244 RID: 246340 RVA: 0x00E658F8 File Offset: 0x00E63AF8
		public void RefreshLinkButton(ENewLinkStatus state)
		{
			if (state == ENewLinkStatus.None)
			{
				this.SetVisible(false);
				return;
			}
			this.SetVisible(true);
			if (!this.CheckAliveRoles())
			{
				this.SetLinkButtonState(BattleLinkEnergyButton.ELinkButtonState.Forbid);
				return;
			}
			switch (state)
			{
			case ENewLinkStatus.Lock:
				this.SetLinkButtonState(BattleLinkEnergyButton.ELinkButtonState.Lock);
				return;
			case ENewLinkStatus.Active:
				if ((float)this.Score != this.MaxScore)
				{
					this.SetLinkButtonState(BattleLinkEnergyButton.ELinkButtonState.Normal);
					return;
				}
				this.SetLinkButtonState(BattleLinkEnergyButton.ELinkButtonState.Full);
				return;
			case ENewLinkStatus.Ready:
				this.SetLinkButtonState(BattleLinkEnergyButton.ELinkButtonState.Full);
				return;
			case ENewLinkStatus.Burst:
				this.SetLinkButtonState(BattleLinkEnergyButton.ELinkButtonState.Burst);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603C245 RID: 246341 RVA: 0x00E65978 File Offset: 0x00E63B78
		public void SetLinkButtonState(BattleLinkEnergyButton.ELinkButtonState state)
		{
			switch (state)
			{
			case BattleLinkEnergyButton.ELinkButtonState.Normal:
			{
				UUIItem pointItem = this.PointItem;
				if (pointItem != null)
				{
					pointItem.SetUIActive(true);
				}
				UUINiagara scoreUiNiagara = this.ScoreUiNiagara;
				if (scoreUiNiagara != null)
				{
					scoreUiNiagara.SetUIActive(true);
				}
				UUINiagara readyUiNiagara = this.ReadyUiNiagara;
				if (readyUiNiagara != null)
				{
					readyUiNiagara.SetUIActive(false);
				}
				UUIItem forbidItem = this.ForbidItem;
				if (forbidItem != null)
				{
					forbidItem.SetUIActive(false);
				}
				UUIItem lockItem = this.LockItem;
				if (lockItem != null)
				{
					lockItem.SetUIActive(false);
				}
				UUINiagara scoreUiNiagara2 = this.ScoreUiNiagara;
				if (scoreUiNiagara2 != null)
				{
					scoreUiNiagara2.SetAlpha(1f);
				}
				UUIItem pointItem2 = this.PointItem;
				if (pointItem2 != null)
				{
					pointItem2.SetAlpha(1f);
				}
				UUITexture icon = this.Icon;
				if (icon != null)
				{
					icon.SetAlpha(1f);
				}
				UUITexture iconBg = this.IconBg;
				if (iconBg == null)
				{
					return;
				}
				iconBg.SetColor(FColor.White);
				return;
			}
			case BattleLinkEnergyButton.ELinkButtonState.Full:
			{
				UUIItem pointItem3 = this.PointItem;
				if (pointItem3 != null)
				{
					pointItem3.SetUIActive(true);
				}
				UUINiagara scoreUiNiagara3 = this.ScoreUiNiagara;
				if (scoreUiNiagara3 != null)
				{
					scoreUiNiagara3.SetUIActive(true);
				}
				UUINiagara readyUiNiagara2 = this.ReadyUiNiagara;
				if (readyUiNiagara2 != null)
				{
					readyUiNiagara2.SetUIActive(true);
				}
				UUIItem forbidItem2 = this.ForbidItem;
				if (forbidItem2 != null)
				{
					forbidItem2.SetUIActive(false);
				}
				UUIItem lockItem2 = this.LockItem;
				if (lockItem2 != null)
				{
					lockItem2.SetUIActive(false);
				}
				UUINiagara scoreUiNiagara4 = this.ScoreUiNiagara;
				if (scoreUiNiagara4 != null)
				{
					scoreUiNiagara4.SetAlpha(1f);
				}
				UUITexture icon2 = this.Icon;
				if (icon2 != null)
				{
					icon2.SetAlpha(1f);
				}
				UUITexture iconBg2 = this.IconBg;
				if (iconBg2 == null)
				{
					return;
				}
				iconBg2.SetColor(FColor.White);
				return;
			}
			case BattleLinkEnergyButton.ELinkButtonState.Burst:
			{
				UUIItem pointItem4 = this.PointItem;
				if (pointItem4 != null)
				{
					pointItem4.SetUIActive(true);
				}
				UUINiagara scoreUiNiagara5 = this.ScoreUiNiagara;
				if (scoreUiNiagara5 != null)
				{
					scoreUiNiagara5.SetUIActive(true);
				}
				UUINiagara readyUiNiagara3 = this.ReadyUiNiagara;
				if (readyUiNiagara3 != null)
				{
					readyUiNiagara3.SetUIActive(false);
				}
				UUIItem forbidItem3 = this.ForbidItem;
				if (forbidItem3 != null)
				{
					forbidItem3.SetUIActive(false);
				}
				UUIItem lockItem3 = this.LockItem;
				if (lockItem3 != null)
				{
					lockItem3.SetUIActive(false);
				}
				UUINiagara scoreUiNiagara6 = this.ScoreUiNiagara;
				if (scoreUiNiagara6 != null)
				{
					scoreUiNiagara6.SetAlpha(1f);
				}
				UUITexture icon3 = this.Icon;
				if (icon3 != null)
				{
					icon3.SetAlpha(1f);
				}
				UUITexture iconBg3 = this.IconBg;
				if (iconBg3 == null)
				{
					return;
				}
				iconBg3.SetColor(FColor.White);
				return;
			}
			case BattleLinkEnergyButton.ELinkButtonState.Forbid:
			{
				UUIItem pointItem5 = this.PointItem;
				if (pointItem5 != null)
				{
					pointItem5.SetUIActive(true);
				}
				UUINiagara scoreUiNiagara7 = this.ScoreUiNiagara;
				if (scoreUiNiagara7 != null)
				{
					scoreUiNiagara7.SetUIActive(true);
				}
				UUINiagara readyUiNiagara4 = this.ReadyUiNiagara;
				if (readyUiNiagara4 != null)
				{
					readyUiNiagara4.SetUIActive(false);
				}
				UUIItem forbidItem4 = this.ForbidItem;
				if (forbidItem4 != null)
				{
					forbidItem4.SetUIActive(true);
				}
				UUIItem lockItem4 = this.LockItem;
				if (lockItem4 != null)
				{
					lockItem4.SetUIActive(false);
				}
				UUINiagara scoreUiNiagara8 = this.ScoreUiNiagara;
				if (scoreUiNiagara8 != null)
				{
					scoreUiNiagara8.SetAlpha(0.5f);
				}
				UUIItem pointItem6 = this.PointItem;
				if (pointItem6 != null)
				{
					pointItem6.SetAlpha(0.5f);
				}
				UUITexture icon4 = this.Icon;
				if (icon4 != null)
				{
					icon4.SetAlpha(0.3f);
				}
				UUITexture iconBg4 = this.IconBg;
				if (iconBg4 == null)
				{
					return;
				}
				iconBg4.SetColor(FColor.Transparent);
				return;
			}
			case BattleLinkEnergyButton.ELinkButtonState.Lock:
			{
				UUIItem pointItem7 = this.PointItem;
				if (pointItem7 != null)
				{
					pointItem7.SetUIActive(false);
				}
				UUINiagara scoreUiNiagara9 = this.ScoreUiNiagara;
				if (scoreUiNiagara9 != null)
				{
					scoreUiNiagara9.SetUIActive(false);
				}
				UUINiagara readyUiNiagara5 = this.ReadyUiNiagara;
				if (readyUiNiagara5 != null)
				{
					readyUiNiagara5.SetUIActive(false);
				}
				UUIItem forbidItem5 = this.ForbidItem;
				if (forbidItem5 != null)
				{
					forbidItem5.SetUIActive(false);
				}
				UUIItem lockItem5 = this.LockItem;
				if (lockItem5 != null)
				{
					lockItem5.SetUIActive(true);
				}
				UUITexture icon5 = this.Icon;
				if (icon5 != null)
				{
					icon5.SetAlpha(0.3f);
				}
				UUITexture iconBg5 = this.IconBg;
				if (iconBg5 == null)
				{
					return;
				}
				iconBg5.SetColor(FColor.Transparent);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0603C246 RID: 246342 RVA: 0x00E65CC1 File Offset: 0x00E63EC1
		protected override void OnShowBattleChildView()
		{
		}

		// Token: 0x0603C247 RID: 246343 RVA: 0x00E65CC4 File Offset: 0x00E63EC4
		public string GetResourceId()
		{
			BattleLinkModel instance = BattleLinkModel.Instance;
			if (instance.CheckInNewBattleLink())
			{
				return "UiItem_RogueScoreE";
			}
			if (!instance.CheckInSpecialBattleLink())
			{
				return null;
			}
			string specialLinkEnergyButton = instance.GetSpecialLinkEnergyButton();
			if (!string.IsNullOrEmpty(specialLinkEnergyButton))
			{
				return specialLinkEnergyButton;
			}
			return "UiItem_FightLinkBurst";
		}

		// Token: 0x0401F597 RID: 128407
		[Nullable(1)]
		private const string SCORE_NIAGARA_PATH = "/Game/Aki/Effect/UI/Niagaras/RouGe/NS_Fx_LGUI_WhiteCat_Button_Panner.NS_Fx_LGUI_WhiteCat_Button_Panner";

		// Token: 0x0401F598 RID: 128408
		[Nullable(1)]
		private const string READY_NIAGARA_PATH = "/Game/Aki/Effect/UI/Niagaras/Common/NS_Fx_LGUI_Fight_Link.NS_Fx_LGUI_Fight_Link";

		// Token: 0x0401F599 RID: 128409
		private const int MAX_SMOOTH_TIME = 200;

		// Token: 0x0401F59A RID: 128410
		private const int LINK_BURST_TRIGGER_INTERVAL = 1000;

		// Token: 0x0401F59B RID: 128411
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]BattleLinkEnergyButtonTick", "", "");

		// Token: 0x0401F59C RID: 128412
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F59D RID: 128413
		private UUIButtonComponent LinkButton;

		// Token: 0x0401F59E RID: 128414
		private UNiagaraSystem ScoreNiagara;

		// Token: 0x0401F59F RID: 128415
		private UUINiagara ScoreUiNiagara;

		// Token: 0x0401F5A0 RID: 128416
		private UNiagaraSystem ReadyNiagara;

		// Token: 0x0401F5A1 RID: 128417
		private UUINiagara ReadyUiNiagara;

		// Token: 0x0401F5A2 RID: 128418
		private UUIItem PointItem;

		// Token: 0x0401F5A3 RID: 128419
		private UUIItem ForbidItem;

		// Token: 0x0401F5A4 RID: 128420
		private UUIItem LockItem;

		// Token: 0x0401F5A5 RID: 128421
		private UUITexture Icon;

		// Token: 0x0401F5A6 RID: 128422
		private UUITexture IconBg;

		// Token: 0x0401F5A7 RID: 128423
		private CombineKeyItem KeyItemPc;

		// Token: 0x0401F5A8 RID: 128424
		private CombineKeyItem KeyItemGp;

		// Token: 0x0401F5A9 RID: 128425
		private bool HasValidConfig;

		// Token: 0x0401F5AA RID: 128426
		private bool IsShowFull;

		// Token: 0x0401F5AB RID: 128427
		private float TickStartScore;

		// Token: 0x0401F5AC RID: 128428
		private float TickEndScore;

		// Token: 0x0401F5AD RID: 128429
		private float TickScore;

		// Token: 0x0401F5AE RID: 128430
		private float MaxScore;

		// Token: 0x0401F5AF RID: 128431
		private float SmoothTime;

		// Token: 0x0401F5B0 RID: 128432
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401F5B1 RID: 128433
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401F5B2 RID: 128434
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401F5B3 RID: 128435
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401F5B4 RID: 128436
		private int NewLinkId;

		// Token: 0x0401F5B5 RID: 128437
		private int ScoreId;

		// Token: 0x0401F5B6 RID: 128438
		private int Score;

		// Token: 0x0401F5B7 RID: 128439
		private long BurstTriggerCd;

		// Token: 0x0200BF29 RID: 48937
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039A92 RID: 236178
			LinkButton,
			// Token: 0x04039A93 RID: 236179
			ScoreNiagara,
			// Token: 0x04039A94 RID: 236180
			PointItem,
			// Token: 0x04039A95 RID: 236181
			ForbidItem,
			// Token: 0x04039A96 RID: 236182
			LockItem,
			// Token: 0x04039A97 RID: 236183
			Icon,
			// Token: 0x04039A98 RID: 236184
			IconBg,
			// Token: 0x04039A99 RID: 236185
			ReadyNiagara
		}

		// Token: 0x0200BF2A RID: 48938
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x04039A9B RID: 236187
			KeyItemPc = 8,
			// Token: 0x04039A9C RID: 236188
			KeyItemGp
		}

		// Token: 0x0200BF2B RID: 48939
		[NullableContext(0)]
		public enum ELinkButtonState
		{
			// Token: 0x04039A9E RID: 236190
			Normal,
			// Token: 0x04039A9F RID: 236191
			Full,
			// Token: 0x04039AA0 RID: 236192
			Burst,
			// Token: 0x04039AA1 RID: 236193
			Forbid,
			// Token: 0x04039AA2 RID: 236194
			Lock
		}
	}
}
