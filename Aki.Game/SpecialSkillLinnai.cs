using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

// Token: 0x02002703 RID: 9987
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillLinnai : SpecialSkillBase
{
	// Token: 0x06019070 RID: 102512 RVA: 0x0079EE63 File Offset: 0x0079D063
	[NullableContext(1)]
	public SpecialSkillLinnai(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x06019071 RID: 102513 RVA: 0x0079EE6C File Offset: 0x0079D06C
	public override void OnStart()
	{
		Entity entity = this.SpecialSkillComponent.Entity;
		this.MoveComp = entity.GetComponent<CharacterMoveComponent>();
		this.SpecialTagComp = entity.GetComponent<CharacterSpecialTagComponent>();
		this.ClimbComp = entity.GetComponent<CharacterClimbComponent>();
		this.TagComp = entity.GetComponent<BaseTagComponent>();
		this.UnifiedComp = entity.GetComponent<BaseUnifiedStateComponent>();
		CharacterSpecialTagComponent specialTagComp = this.SpecialTagComp;
		this.SpecialTagListenerHandle = ((specialTagComp != null) ? specialTagComp.InitTagListenerConfig("/Game/Aki/Character/Role/FemaleM/LinNai/Data/DA_SpecialTagConfig.DA_SpecialTagConfig", new Func<double, bool>(this.CheckLinnaiSpecialState)) : 0);
		BaseTagComponent tagComp = this.TagComp;
		this.SpecialTagListener = ((tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.轮滑状态"]), new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialTagChanged), null) : null);
	}

	// Token: 0x06019072 RID: 102514 RVA: 0x0079EF24 File Offset: 0x0079D124
	public override void OnEnd()
	{
		CharacterSpecialTagComponent specialTagComp = this.SpecialTagComp;
		if (specialTagComp != null)
		{
			specialTagComp.RemoveTagListenerConfig(this.SpecialTagListenerHandle);
		}
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null)
		{
			tagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.LinnaiMd10011.轮滑状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialTagChanged));
		}
		ITagTask specialTagListener = this.SpecialTagListener;
		if (specialTagListener != null)
		{
			specialTagListener.EndTask();
		}
		this.SpecialTagListener = null;
	}

	// Token: 0x06019073 RID: 102515 RVA: 0x0079EF8C File Offset: 0x0079D18C
	private bool CheckLinnaiSpecialState(double delta)
	{
		BaseUnifiedStateComponent unifiedComp = this.UnifiedComp;
		bool flag = unifiedComp != null && unifiedComp.PositionState == ECharPositionState.Ground;
		BaseUnifiedStateComponent unifiedComp2 = this.UnifiedComp;
		object obj = unifiedComp2 != null && unifiedComp2.PositionState == ECharPositionState.Air;
		CharacterMoveComponent moveComp = this.MoveComp;
		double num = (moveComp != null) ? moveComp.LastJumpTime : 0.0;
		CharacterMoveComponent moveComp2 = this.MoveComp;
		bool flag2 = (moveComp2 != null && moveComp2.IsJump) || Time.Instance.PlayerWorldTime - num < 500.0;
		object obj2 = obj;
		bool flag3 = ((obj2 | flag) & flag2) != null;
		CharacterClimbComponent climbComp = this.ClimbComp;
		bool flag4;
		if (climbComp != null && climbComp.LastExitClimbType == EExitClimb.蹬墙退出)
		{
			double playerWorldTime = Time.Instance.PlayerWorldTime;
			CharacterClimbComponent climbComp2 = this.ClimbComp;
			flag4 = (playerWorldTime - (double)((climbComp2 != null) ? climbComp2.LastExitClimbTime : 0f) < 800.0);
		}
		else
		{
			flag4 = false;
		}
		bool flag5 = flag4;
		bool flag6 = (obj2 & flag5) != null;
		CharacterClimbComponent climbComp3 = this.ClimbComp;
		AkiClient.Game.Aki.Character.BaseCharacter.SClimbState? sclimbState = (climbComp3 != null) ? new AkiClient.Game.Aki.Character.BaseCharacter.SClimbState?(climbComp3.GetClimbState()) : null;
		bool flag7 = ((sclimbState != null) ? new TEnumAsByte<EClimbState>?(sclimbState.GetValueOrDefault().攀爬状态) : null) != EClimbState.退出攀爬 || ((sclimbState != null) ? new TEnumAsByte<EExitClimb>?(sclimbState.GetValueOrDefault().退出攀爬类型) : null) == EExitClimb.反斜登顶;
		return !flag3 && flag7 && !flag6;
	}

	// Token: 0x06019074 RID: 102516 RVA: 0x0079F130 File Offset: 0x0079D330
	private void OnSpecialTagChanged(int tagId, bool tagExists)
	{
		if (tagExists)
		{
			CharacterClimbComponent climbComp = this.ClimbComp;
			if (climbComp == null)
			{
				return;
			}
			climbComp.ResetClimbObjectConfig("FemaleLinnaiSpecial");
			return;
		}
		else
		{
			CharacterClimbComponent climbComp2 = this.ClimbComp;
			if (climbComp2 == null)
			{
				return;
			}
			climbComp2.ResetClimbObjectConfig("FemaleM");
			return;
		}
	}

	// Token: 0x0400DA40 RID: 55872
	private const int JUMP_DELAY_TIME = 500;

	// Token: 0x0400DA41 RID: 55873
	private const int JUMP_EXIT_CLIMB_DELAY_TIME = 800;

	// Token: 0x0400DA42 RID: 55874
	[Nullable(1)]
	private const string SPECIAL_TAG_LISTENER_DA = "/Game/Aki/Character/Role/FemaleM/LinNai/Data/DA_SpecialTagConfig.DA_SpecialTagConfig";

	// Token: 0x0400DA43 RID: 55875
	private int SpecialTagListenerHandle;

	// Token: 0x0400DA44 RID: 55876
	private CharacterClimbComponent ClimbComp;

	// Token: 0x0400DA45 RID: 55877
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400DA46 RID: 55878
	private BaseTagComponent TagComp;

	// Token: 0x0400DA47 RID: 55879
	private BaseUnifiedStateComponent UnifiedComp;

	// Token: 0x0400DA48 RID: 55880
	private CharacterSpecialTagComponent SpecialTagComp;

	// Token: 0x0400DA49 RID: 55881
	private ITagTask SpecialTagListener;
}
