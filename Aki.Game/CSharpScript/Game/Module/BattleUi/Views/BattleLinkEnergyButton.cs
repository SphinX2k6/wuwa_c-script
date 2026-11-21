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
	// Token: 0x02004CB9 RID: 19641
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleLinkEnergyButton : FormationExtraButton
	{
		// Token: 0x06031187 RID: 201095 RVA: 0x00DB52F0 File Offset: 0x00DB34F0
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

		// Token: 0x06031188 RID: 201096 RVA: 0x00DB5464 File Offset: 0x00DB3664
		protected override UniTask OnCreateAsync()
		{
			BattleLinkEnergyButton.<OnCreateAsync>d__37 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<BattleLinkEnergyButton.<OnCreateAsync>d__37>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031189 RID: 201097 RVA: 0x00DB54A8 File Offset: 0x00DB36A8
		protected override UniTask OnBeforeStartAsync()
		{
			BattleLinkEnergyButton.<OnBeforeStartAsync>d__38 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleLinkEnergyButton.<OnBeforeStartAsync>d__38>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603118A RID: 201098 RVA: 0x00DB54EC File Offset: 0x00DB36EC
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

		// Token: 0x0603118B RID: 201099 RVA: 0x00DB570C File Offset: 0x00DB390C
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

		// Token: 0x0603118C RID: 201100 RVA: 0x00DB57C8 File Offset: 0x00DB39C8
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

		// Token: 0x0603118D RID: 201101 RVA: 0x00DB5813 File Offset: 0x00DB3A13
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

		// Token: 0x0603118E RID: 201102 RVA: 0x00DB5827 File Offset: 0x00DB3A27
		private void OnPressLinkButton()
		{
			this.LinkAction();
		}

		// Token: 0x0603118F RID: 201103 RVA: 0x00DB5830 File Offset: 0x00DB3A30
		private void LinkAction()
		{
			if (CameraController.Instance.IsSequenceCameraInCinematic("MainCamera"))
			{
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

		// Token: 0x06031190 RID: 201104 RVA: 0x00DB58B4 File Offset: 0x00DB3AB4
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

		// Token: 0x06031191 RID: 201105 RVA: 0x00DB592E File Offset: 0x00DB3B2E
		private void OnNewLinkStatusChanged(ENewLinkStatus state)
		{
			this.UpdateLinkConfig();
			this.RefreshLinkButton(state);
			if (BattleLinkModel.Instance.IsNewLinkGmTest())
			{
				this.SetVisible(true);
			}
		}

		// Token: 0x06031192 RID: 201106 RVA: 0x00DB5950 File Offset: 0x00DB3B50
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

		// Token: 0x06031193 RID: 201107 RVA: 0x00DB59E0 File Offset: 0x00DB3BE0
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

		// Token: 0x06031194 RID: 201108 RVA: 0x00DB5AF4 File Offset: 0x00DB3CF4
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

		// Token: 0x06031195 RID: 201109 RVA: 0x00DB5BD4 File Offset: 0x00DB3DD4
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

		// Token: 0x06031196 RID: 201110 RVA: 0x00DB5CD0 File Offset: 0x00DB3ED0
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

		// Token: 0x06031197 RID: 201111 RVA: 0x00DB5D24 File Offset: 0x00DB3F24
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

		// Token: 0x06031198 RID: 201112 RVA: 0x00DB5DF0 File Offset: 0x00DB3FF0
		public bool IsValidScore(int scoreId)
		{
			return scoreId == this.ScoreId && BattleScoreModel.Instance.GetScoreConfig(scoreId, true) != null;
		}

		// Token: 0x06031199 RID: 201113 RVA: 0x00DB5E24 File Offset: 0x00DB4024
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

		// Token: 0x0603119A RID: 201114 RVA: 0x00DB5EAC File Offset: 0x00DB40AC
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

		// Token: 0x0603119B RID: 201115 RVA: 0x00DB5F2C File Offset: 0x00DB412C
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

		// Token: 0x0603119C RID: 201116 RVA: 0x00DB6275 File Offset: 0x00DB4475
		protected override void OnShowBattleChildView()
		{
		}

		// Token: 0x0603119D RID: 201117 RVA: 0x00DB6278 File Offset: 0x00DB4478
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

		// Token: 0x0401A050 RID: 106576
		[Nullable(1)]
		private const string SCORE_NIAGARA_PATH = "/Game/Aki/Effect/UI/Niagaras/RouGe/NS_Fx_LGUI_WhiteCat_Button_Panner.NS_Fx_LGUI_WhiteCat_Button_Panner";

		// Token: 0x0401A051 RID: 106577
		[Nullable(1)]
		private const string READY_NIAGARA_PATH = "/Game/Aki/Effect/UI/Niagaras/Common/NS_Fx_LGUI_Fight_Link.NS_Fx_LGUI_Fight_Link";

		// Token: 0x0401A052 RID: 106578
		private const int MAX_SMOOTH_TIME = 200;

		// Token: 0x0401A053 RID: 106579
		private const int LINK_BURST_TRIGGER_INTERVAL = 1000;

		// Token: 0x0401A054 RID: 106580
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]BattleLinkEnergyButtonTick", "", "");

		// Token: 0x0401A055 RID: 106581
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A056 RID: 106582
		private UUIButtonComponent LinkButton;

		// Token: 0x0401A057 RID: 106583
		private UNiagaraSystem ScoreNiagara;

		// Token: 0x0401A058 RID: 106584
		private UUINiagara ScoreUiNiagara;

		// Token: 0x0401A059 RID: 106585
		private UNiagaraSystem ReadyNiagara;

		// Token: 0x0401A05A RID: 106586
		private UUINiagara ReadyUiNiagara;

		// Token: 0x0401A05B RID: 106587
		private UUIItem PointItem;

		// Token: 0x0401A05C RID: 106588
		private UUIItem ForbidItem;

		// Token: 0x0401A05D RID: 106589
		private UUIItem LockItem;

		// Token: 0x0401A05E RID: 106590
		private UUITexture Icon;

		// Token: 0x0401A05F RID: 106591
		private UUITexture IconBg;

		// Token: 0x0401A060 RID: 106592
		private CombineKeyItem KeyItemPc;

		// Token: 0x0401A061 RID: 106593
		private CombineKeyItem KeyItemGp;

		// Token: 0x0401A062 RID: 106594
		private bool HasValidConfig;

		// Token: 0x0401A063 RID: 106595
		private bool IsShowFull;

		// Token: 0x0401A064 RID: 106596
		private float TickStartScore;

		// Token: 0x0401A065 RID: 106597
		private float TickEndScore;

		// Token: 0x0401A066 RID: 106598
		private float TickScore;

		// Token: 0x0401A067 RID: 106599
		private float MaxScore;

		// Token: 0x0401A068 RID: 106600
		private float SmoothTime;

		// Token: 0x0401A069 RID: 106601
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401A06A RID: 106602
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401A06B RID: 106603
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401A06C RID: 106604
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401A06D RID: 106605
		private int NewLinkId;

		// Token: 0x0401A06E RID: 106606
		private int ScoreId;

		// Token: 0x0401A06F RID: 106607
		private int Score;

		// Token: 0x0401A070 RID: 106608
		private long BurstTriggerCd;

		// Token: 0x0200A92F RID: 43311
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034454 RID: 214100
			LinkButton,
			// Token: 0x04034455 RID: 214101
			ScoreNiagara,
			// Token: 0x04034456 RID: 214102
			PointItem,
			// Token: 0x04034457 RID: 214103
			ForbidItem,
			// Token: 0x04034458 RID: 214104
			LockItem,
			// Token: 0x04034459 RID: 214105
			Icon,
			// Token: 0x0403445A RID: 214106
			IconBg,
			// Token: 0x0403445B RID: 214107
			ReadyNiagara
		}

		// Token: 0x0200A930 RID: 43312
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x0403445D RID: 214109
			KeyItemPc = 8,
			// Token: 0x0403445E RID: 214110
			KeyItemGp
		}

		// Token: 0x0200A931 RID: 43313
		[NullableContext(0)]
		public enum ELinkButtonState
		{
			// Token: 0x04034460 RID: 214112
			Normal,
			// Token: 0x04034461 RID: 214113
			Full,
			// Token: 0x04034462 RID: 214114
			Burst,
			// Token: 0x04034463 RID: 214115
			Forbid,
			// Token: 0x04034464 RID: 214116
			Lock
		}
	}
}
