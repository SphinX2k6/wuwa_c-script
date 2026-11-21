using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001186 RID: 4486
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleArrowBattleProgressItem : UiPanelBase
{
	// Token: 0x0600B30D RID: 45837 RVA: 0x0034E9BC File Offset: 0x0034CBBC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUITexture))
		};
	}

	// Token: 0x0600B30E RID: 45838 RVA: 0x0034EA44 File Offset: 0x0034CC44
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowBattleProgressItem.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowBattleProgressItem.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B30F RID: 45839 RVA: 0x0034EA87 File Offset: 0x0034CC87
	protected override void OnBeforeDestroy()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600B310 RID: 45840 RVA: 0x0034EA90 File Offset: 0x0034CC90
	protected override void OnBeforeShow()
	{
		this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		this.RefreshBossIcon();
		this.StartShowHeadItem();
	}

	// Token: 0x0600B311 RID: 45841 RVA: 0x0034EAC6 File Offset: 0x0034CCC6
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorArrowSubLevelNotify, new Action<int, bool>(this.Refresh));
		EventSystem.Instance.Add(EEventName.MotorArrowBossStateChange, new Action<int, EBossState>(this.RefreshBattleState));
	}

	// Token: 0x0600B312 RID: 45842 RVA: 0x0034EB00 File Offset: 0x0034CD00
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorArrowSubLevelNotify, new Action<int, bool>(this.Refresh));
		EventSystem.Instance.Remove(EEventName.MotorArrowBossStateChange, new Action<int, EBossState>(this.RefreshBattleState));
	}

	// Token: 0x0600B313 RID: 45843 RVA: 0x0034EB3C File Offset: 0x0034CD3C
	public void InitPlayerHead()
	{
		int playerId = CreatureModel.Instance.GetPlayerId();
		SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(playerId);
		int? num;
		if (teamPlayerData == null)
		{
			num = null;
		}
		else
		{
			SceneTeamGroup currentGroup = teamPlayerData.GetCurrentGroup();
			if (currentGroup == null)
			{
				num = null;
			}
			else
			{
				SceneTeamRole currentRole = currentGroup.GetCurrentRole();
				num = ((currentRole != null) ? new int?(currentRole.RoleId) : null);
			}
		}
		int? num2 = num;
		if (num2 == null)
		{
			Log.Instance.Error(ELogModule.CommonGameMainView, ELogAuthor.TZQ, "[摩托战斗]获取不到当前角色id", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(num2.Value);
		if (roleConfig == null)
		{
			return;
		}
		string roleHeadIconCircle = roleConfig.Value.RoleHeadIconCircle;
		base.SetTextureShowUntilLoaded(roleHeadIconCircle, base.GetTexture(4), null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), roleConfig.Value.Name, Array.Empty<object>());
	}

	// Token: 0x0600B314 RID: 45844 RVA: 0x0034EC30 File Offset: 0x0034CE30
	public UniTask InitBossHeadItem()
	{
		MotorcycleArrowBattleProgressItem.<InitBossHeadItem>d__26 <InitBossHeadItem>d__;
		<InitBossHeadItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBossHeadItem>d__.<>1__state = -1;
		<InitBossHeadItem>d__.<>t__builder.Start<MotorcycleArrowBattleProgressItem.<InitBossHeadItem>d__26>(ref <InitBossHeadItem>d__);
		return <InitBossHeadItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600B315 RID: 45845 RVA: 0x0034EC6C File Offset: 0x0034CE6C
	private UniTask CreateBossItem(float curOffsetY)
	{
		MotorcycleArrowBattleProgressItem.<CreateBossItem>d__27 <CreateBossItem>d__;
		<CreateBossItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateBossItem>d__.<>4__this = this;
		<CreateBossItem>d__.curOffsetY = curOffsetY;
		<CreateBossItem>d__.<>1__state = -1;
		<CreateBossItem>d__.<>t__builder.Start<MotorcycleArrowBattleProgressItem.<CreateBossItem>d__27>(ref <CreateBossItem>d__);
		return <CreateBossItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600B316 RID: 45846 RVA: 0x0034ECB8 File Offset: 0x0034CEB8
	public void Refresh(int subLevelIndex, bool isInBossBattle)
	{
		int num = subLevelIndex / 5 * 5;
		if (this.IsForeverLevel && this.CurStartSubLevelIndex != num)
		{
			this.CurStartSubLevelIndex = num;
			this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
			this.RefreshBossIcon();
		}
		int num2 = subLevelIndex - this.CurStartSubLevelIndex;
		for (int i = 0; i < this.HeadItemList.Count; i++)
		{
			MotorcycleBossHeadItem motorcycleBossHeadItem = this.HeadItemList[i];
			if (i < num2)
			{
				motorcycleBossHeadItem.SetBossState(EBossState.Finish, false);
			}
			else if (i == num2)
			{
				motorcycleBossHeadItem.SetBossState(isInBossBattle ? EBossState.Battle : EBossState.WaitStart, false);
			}
			else
			{
				motorcycleBossHeadItem.SetBossState(EBossState.WaitStart, false);
			}
		}
	}

	// Token: 0x0600B317 RID: 45847 RVA: 0x0034ED60 File Offset: 0x0034CF60
	public void RefreshBattleState(int subLevelIndex, EBossState bossState)
	{
		MotorcycleBossHeadItem motorcycleBossHeadItem = this.HeadItemList[subLevelIndex];
		if (motorcycleBossHeadItem == null)
		{
			return;
		}
		motorcycleBossHeadItem.SetBossState(bossState, false);
	}

	// Token: 0x0600B318 RID: 45848 RVA: 0x0034ED7A File Offset: 0x0034CF7A
	public void OnTick(float delta)
	{
		this.UpdatePlayerHeadPos();
		if (this.NextShowHeadTime > 0f && this.NextShowHeadTime <= (float)Time.Instance.Now)
		{
			this.ShowNextHeadItem();
		}
	}

	// Token: 0x0600B319 RID: 45849 RVA: 0x0034EDA8 File Offset: 0x0034CFA8
	public void UpdatePlayerHeadPos()
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		if (motorcycleArrowSubModel == null)
		{
			return;
		}
		int num = motorcycleArrowSubModel.SubLevelIndex - this.CurStartSubLevelIndex;
		float num2 = 0f;
		if (motorcycleArrowSubModel.EndDistance > 0)
		{
			UKSC_World kscWorld = KscEnv.Instance.KscWorld;
			float? num3;
			if (kscWorld == null)
			{
				num3 = null;
			}
			else
			{
				UKSC_SceneMovement sceneMovement = kscWorld.SceneMovement;
				num3 = ((sceneMovement != null) ? new float?(sceneMovement.MoveDistance) : null);
			}
			float? num4 = num3;
			float valueOrDefault = num4.GetValueOrDefault();
			num2 = MathUtils.Instance.Clamp(valueOrDefault / (float)motorcycleArrowSubModel.EndDistance, 0f, 1f);
		}
		float anchorOffsetY = (float)(-(float)this.BarLength) / 2f + ((float)num + num2) * (float)this.SubBarLength + this.PlayerHeadPosOffset;
		UUIItem playerHead = this.PlayerHead;
		if (playerHead != null)
		{
			playerHead.SetAnchorOffsetY(anchorOffsetY);
		}
		if (this.SubBarCount > 0)
		{
			float fillAmount = ((float)num + num2) / (float)this.SubBarCount;
			UUISprite distancePressBar = this.DistancePressBar;
			if (distancePressBar == null)
			{
				return;
			}
			distancePressBar.SetFillAmount(fillAmount);
		}
	}

	// Token: 0x0600B31A RID: 45850 RVA: 0x0034EEA8 File Offset: 0x0034D0A8
	private void StartShowHeadItem()
	{
		if (this.HeadItemList.Count > 1)
		{
			this.ShowHeadItemInterval = 500f / (float)(this.HeadItemList.Count - 1);
			this.NextShowHeadTime = (float)Time.Instance.Now + this.ShowHeadItemInterval;
		}
		else
		{
			this.ShowHeadItemInterval = 0f;
			this.NextShowHeadTime = 0f;
		}
		this.ShowHeadItemIndex = this.HeadItemList.Count;
		this.ShowNextHeadItem();
	}

	// Token: 0x0600B31B RID: 45851 RVA: 0x0034EF24 File Offset: 0x0034D124
	private void ShowNextHeadItem()
	{
		this.ShowHeadItemIndex--;
		if (this.ShowHeadItemIndex >= this.HeadItemList.Count || this.ShowHeadItemIndex < 0)
		{
			this.NextShowHeadTime = -1f;
			return;
		}
		this.NextShowHeadTime = (float)Time.Instance.Now + this.ShowHeadItemInterval;
		this.HeadItemList[this.ShowHeadItemIndex].ShowAsync().Forget<bool>();
	}

	// Token: 0x0600B31C RID: 45852 RVA: 0x0034EF9C File Offset: 0x0034D19C
	private void RefreshBossIcon()
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		if (motorcycleArrowSubModel == null)
		{
			return;
		}
		List<string> bossIconPathList = motorcycleArrowSubModel.BossIconPathList;
		for (int i = 0; i < this.HeadItemList.Count; i++)
		{
			MotorcycleBossHeadItem motorcycleBossHeadItem = this.HeadItemList[i];
			int index = i + this.CurStartSubLevelIndex;
			motorcycleBossHeadItem.SetBossIconPath(bossIconPathList[index]);
		}
	}

	// Token: 0x0400674A RID: 26442
	private const int PROGRESS_DURATION = 500;

	// Token: 0x0400674B RID: 26443
	private const int FOREVER_LEVEL_PERCOUNT = 5;

	// Token: 0x0400674C RID: 26444
	protected UUISprite DistancePressBar;

	// Token: 0x0400674D RID: 26445
	protected UUIItem HeadList;

	// Token: 0x0400674E RID: 26446
	protected UUIItem HeadItem;

	// Token: 0x0400674F RID: 26447
	protected UUIItem PlayerHead;

	// Token: 0x04006750 RID: 26448
	protected UUITexture PlayerTextureHead;

	// Token: 0x04006751 RID: 26449
	protected int BarLength;

	// Token: 0x04006752 RID: 26450
	protected int SubBarLength;

	// Token: 0x04006753 RID: 26451
	[Nullable(1)]
	protected List<MotorcycleBossHeadItem> HeadItemList = new List<MotorcycleBossHeadItem>();

	// Token: 0x04006754 RID: 26452
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006755 RID: 26453
	private int ShowHeadItemIndex = -1;

	// Token: 0x04006756 RID: 26454
	private float NextShowHeadTime;

	// Token: 0x04006757 RID: 26455
	private float ShowHeadItemInterval;

	// Token: 0x04006758 RID: 26456
	private bool IsForeverLevel;

	// Token: 0x04006759 RID: 26457
	private int CurStartSubLevelIndex;

	// Token: 0x0400675A RID: 26458
	private int SubBarCount;

	// Token: 0x0400675B RID: 26459
	private float PlayerHeadPosOffset;

	// Token: 0x02007448 RID: 29768
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025D99 RID: 155033
		public const int DistancePressBar = 0;

		// Token: 0x04025D9A RID: 155034
		public const int HeadList = 1;

		// Token: 0x04025D9B RID: 155035
		public const int HeadItem = 2;

		// Token: 0x04025D9C RID: 155036
		public const int PlayerHead = 3;

		// Token: 0x04025D9D RID: 155037
		public const int PlayerTextureHead = 4;
	}
}
