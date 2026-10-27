using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

// Token: 0x02003195 RID: 12693
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillLinnai : SpecialSkillBase
{
	// Token: 0x0601B550 RID: 111952 RVA: 0x00776BD6 File Offset: 0x00774DD6
	[NullableContext(1)]
	public SpecialSkillLinnai(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B551 RID: 111953 RVA: 0x00776BE0 File Offset: 0x00774DE0
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

	// Token: 0x0601B552 RID: 111954 RVA: 0x00776C98 File Offset: 0x00774E98
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

	// Token: 0x0601B553 RID: 111955 RVA: 0x00776D00 File Offset: 0x00774F00
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

	// Token: 0x0601B554 RID: 111956 RVA: 0x00776EA4 File Offset: 0x007750A4
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

	// Token: 0x0400D5BD RID: 54717
	private const int JUMP_DELAY_TIME = 500;

	// Token: 0x0400D5BE RID: 54718
	private const int JUMP_EXIT_CLIMB_DELAY_TIME = 800;

	// Token: 0x0400D5BF RID: 54719
	[Nullable(1)]
	private const string SPECIAL_TAG_LISTENER_DA = "/Game/Aki/Character/Role/FemaleM/LinNai/Data/DA_SpecialTagConfig.DA_SpecialTagConfig";

	// Token: 0x0400D5C0 RID: 54720
	private int SpecialTagListenerHandle;

	// Token: 0x0400D5C1 RID: 54721
	private CharacterClimbComponent ClimbComp;

	// Token: 0x0400D5C2 RID: 54722
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D5C3 RID: 54723
	private BaseTagComponent TagComp;

	// Token: 0x0400D5C4 RID: 54724
	private BaseUnifiedStateComponent UnifiedComp;

	// Token: 0x0400D5C5 RID: 54725
	private CharacterSpecialTagComponent SpecialTagComp;

	// Token: 0x0400D5C6 RID: 54726
	private ITagTask SpecialTagListener;
}
