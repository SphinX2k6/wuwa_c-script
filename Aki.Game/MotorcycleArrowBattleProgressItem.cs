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

// Token: 0x02001CC4 RID: 7364
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleArrowBattleProgressItem : UiPanelBase
{
	// Token: 0x0600DEF0 RID: 57072 RVA: 0x00342F94 File Offset: 0x00341194
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

	// Token: 0x0600DEF1 RID: 57073 RVA: 0x0034301C File Offset: 0x0034121C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowBattleProgressItem.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowBattleProgressItem.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DEF2 RID: 57074 RVA: 0x0034305F File Offset: 0x0034125F
	protected override void OnBeforeDestroy()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600DEF3 RID: 57075 RVA: 0x00343068 File Offset: 0x00341268
	protected override void OnBeforeShow()
	{
		this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		this.RefreshBossIcon();
		this.StartShowHeadItem();
	}

	// Token: 0x0600DEF4 RID: 57076 RVA: 0x0034309E File Offset: 0x0034129E
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorArrowSubLevelNotify, new Action<int, bool>(this.Refresh));
		EventSystem.Instance.Add(EEventName.MotorArrowBossStateChange, new Action<int, EBossState>(this.RefreshBattleState));
	}

	// Token: 0x0600DEF5 RID: 57077 RVA: 0x003430D8 File Offset: 0x003412D8
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorArrowSubLevelNotify, new Action<int, bool>(this.Refresh));
		EventSystem.Instance.Remove(EEventName.MotorArrowBossStateChange, new Action<int, EBossState>(this.RefreshBattleState));
	}

	// Token: 0x0600DEF6 RID: 57078 RVA: 0x00343114 File Offset: 0x00341314
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

	// Token: 0x0600DEF7 RID: 57079 RVA: 0x00343208 File Offset: 0x00341408
	public UniTask InitBossHeadItem()
	{
		MotorcycleArrowBattleProgressItem.<InitBossHeadItem>d__26 <InitBossHeadItem>d__;
		<InitBossHeadItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBossHeadItem>d__.<>1__state = -1;
		<InitBossHeadItem>d__.<>t__builder.Start<MotorcycleArrowBattleProgressItem.<InitBossHeadItem>d__26>(ref <InitBossHeadItem>d__);
		return <InitBossHeadItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600DEF8 RID: 57080 RVA: 0x00343244 File Offset: 0x00341444
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

	// Token: 0x0600DEF9 RID: 57081 RVA: 0x00343290 File Offset: 0x00341490
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

	// Token: 0x0600DEFA RID: 57082 RVA: 0x00343338 File Offset: 0x00341538
	public void RefreshBattleState(int subLevelIndex, EBossState bossState)
	{
		MotorcycleBossHeadItem motorcycleBossHeadItem = this.HeadItemList[subLevelIndex];
		if (motorcycleBossHeadItem == null)
		{
			return;
		}
		motorcycleBossHeadItem.SetBossState(bossState, false);
	}

	// Token: 0x0600DEFB RID: 57083 RVA: 0x00343352 File Offset: 0x00341552
	public void OnTick(float delta)
	{
		this.UpdatePlayerHeadPos();
		if (this.NextShowHeadTime > 0f && this.NextShowHeadTime <= (float)Time.Instance.Now)
		{
			this.ShowNextHeadItem();
		}
	}

	// Token: 0x0600DEFC RID: 57084 RVA: 0x00343380 File Offset: 0x00341580
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

	// Token: 0x0600DEFD RID: 57085 RVA: 0x00343480 File Offset: 0x00341680
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

	// Token: 0x0600DEFE RID: 57086 RVA: 0x003434FC File Offset: 0x003416FC
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

	// Token: 0x0600DEFF RID: 57087 RVA: 0x00343574 File Offset: 0x00341774
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

	// Token: 0x0400666B RID: 26219
	private const int PROGRESS_DURATION = 500;

	// Token: 0x0400666C RID: 26220
	private const int FOREVER_LEVEL_PERCOUNT = 5;

	// Token: 0x0400666D RID: 26221
	protected UUISprite DistancePressBar;

	// Token: 0x0400666E RID: 26222
	protected UUIItem HeadList;

	// Token: 0x0400666F RID: 26223
	protected UUIItem HeadItem;

	// Token: 0x04006670 RID: 26224
	protected UUIItem PlayerHead;

	// Token: 0x04006671 RID: 26225
	protected UUITexture PlayerTextureHead;

	// Token: 0x04006672 RID: 26226
	protected int BarLength;

	// Token: 0x04006673 RID: 26227
	protected int SubBarLength;

	// Token: 0x04006674 RID: 26228
	[Nullable(1)]
	protected List<MotorcycleBossHeadItem> HeadItemList = new List<MotorcycleBossHeadItem>();

	// Token: 0x04006675 RID: 26229
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006676 RID: 26230
	private int ShowHeadItemIndex = -1;

	// Token: 0x04006677 RID: 26231
	private float NextShowHeadTime;

	// Token: 0x04006678 RID: 26232
	private float ShowHeadItemInterval;

	// Token: 0x04006679 RID: 26233
	private bool IsForeverLevel;

	// Token: 0x0400667A RID: 26234
	private int CurStartSubLevelIndex;

	// Token: 0x0400667B RID: 26235
	private int SubBarCount;

	// Token: 0x0400667C RID: 26236
	private float PlayerHeadPosOffset;

	// Token: 0x020082BF RID: 33471
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AA71 RID: 174705
		public const int DistancePressBar = 0;

		// Token: 0x0402AA72 RID: 174706
		public const int HeadList = 1;

		// Token: 0x0402AA73 RID: 174707
		public const int HeadItem = 2;

		// Token: 0x0402AA74 RID: 174708
		public const int PlayerHead = 3;

		// Token: 0x0402AA75 RID: 174709
		public const int PlayerTextureHead = 4;
	}
}
