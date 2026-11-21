using System;

namespace Aki.Protocol
{
	// Token: 0x020015AD RID: 5549
	public enum ECombatRequestDataMessage
	{
		// Token: 0x0400A888 RID: 43144
		CreateBulletRequest = 18246,
		// Token: 0x0400A889 RID: 43145
		DestroyBulletRequest = 27103,
		// Token: 0x0400A88A RID: 43146
		DamageExecuteRequest = 18654,
		// Token: 0x0400A88B RID: 43147
		ApplyGameplayEffectRequest = 26992,
		// Token: 0x0400A88C RID: 43148
		RemoveGameplayEffectRequest = 15998,
		// Token: 0x0400A88D RID: 43149
		HitRequest = 17489,
		// Token: 0x0400A88E RID: 43150
		HitEndRequest = 19130,
		// Token: 0x0400A88F RID: 43151
		SkillRequest = 28732,
		// Token: 0x0400A890 RID: 43152
		UseSkillRequest = 15873,
		// Token: 0x0400A891 RID: 43153
		EndSkillRequest = 26657,
		// Token: 0x0400A892 RID: 43154
		PartUpdateRequest = 22158,
		// Token: 0x0400A893 RID: 43155
		MaterialRequest = 17530,
		// Token: 0x0400A894 RID: 43156
		GameplayCueRequest = 20852,
		// Token: 0x0400A895 RID: 43157
		EntityIsVisibleRequest = 26500,
		// Token: 0x0400A896 RID: 43158
		SwitchCharacterStateRequest = 26359,
		// Token: 0x0400A897 RID: 43159
		LogicStateInitRequest = 18260,
		// Token: 0x0400A898 RID: 43160
		SwitchLogicStateRequest = 17062,
		// Token: 0x0400A899 RID: 43161
		AnimationStateChangedRequest = 17015,
		// Token: 0x0400A89A RID: 43162
		AnimationStateInitRequest = 29999,
		// Token: 0x0400A89B RID: 43163
		ModifyBulletParamsRequest = 29414,
		// Token: 0x0400A89C RID: 43164
		DrownRequest = 25778,
		// Token: 0x0400A89D RID: 43165
		OrderApplyBuffRequest = 21297,
		// Token: 0x0400A89E RID: 43166
		OrderRemoveBuffRequest = 26903,
		// Token: 0x0400A89F RID: 43167
		ActivateBuffRequest = 27416,
		// Token: 0x0400A8A0 RID: 43168
		OrderRemoveBuffByTagsRequest = 20210,
		// Token: 0x0400A8A1 RID: 43169
		AiInformationRequest = 18681,
		// Token: 0x0400A8A2 RID: 43170
		ToughCalcExtraRatioChangeRequest = 25451,
		// Token: 0x0400A8A3 RID: 43171
		BattleStateChangeRequest = 19982,
		// Token: 0x0400A8A4 RID: 43172
		AnimationGameplayTagRequest = 20782,
		// Token: 0x0400A8A5 RID: 43173
		BoneVisibleChangeRequest = 18467,
		// Token: 0x0400A8A6 RID: 43174
		AiBlackboardsRequest = 22558,
		// Token: 0x0400A8A7 RID: 43175
		AiBlackboardCdRequest = 15625,
		// Token: 0x0400A8A8 RID: 43176
		AiHateRequest = 27610,
		// Token: 0x0400A8A9 RID: 43177
		MonsterBoomRequest = 17163,
		// Token: 0x0400A8AA RID: 43178
		CaughtRequest = 17706,
		// Token: 0x0400A8AB RID: 43179
		EntityStaticHookMoveRequest = 23825,
		// Token: 0x0400A8AC RID: 43180
		ChangeStateRequest = 20524,
		// Token: 0x0400A8AD RID: 43181
		ChangeStateConfirmRequest = 17371,
		// Token: 0x0400A8AE RID: 43182
		FsmConditionPassRequest = 21831,
		// Token: 0x0400A8AF RID: 43183
		BuffStackCountRequest = 24150,
		// Token: 0x0400A8B0 RID: 43184
		ANStartRequest = 25509,
		// Token: 0x0400A8B1 RID: 43185
		UseSkillFailRequest = 15861,
		// Token: 0x0400A8B2 RID: 43186
		EnterViewDirectionRequest = 25151,
		// Token: 0x0400A8B3 RID: 43187
		ExitViewDirectionRequest = 16245,
		// Token: 0x0400A8B4 RID: 43188
		PassiveSkillAddRequest = 17475,
		// Token: 0x0400A8B5 RID: 43189
		InterruptSkillInDelayRequest = 24013,
		// Token: 0x0400A8B6 RID: 43190
		TriggerExitSkillRequest = 23172,
		// Token: 0x0400A8B7 RID: 43191
		ActorVisibleRequest = 17594,
		// Token: 0x0400A8B8 RID: 43192
		BuffEffectRequest = 22402,
		// Token: 0x0400A8B9 RID: 43193
		FragileChangeRequest = 22818,
		// Token: 0x0400A8BA RID: 43194
		RTimeStopRequest = 16580,
		// Token: 0x0400A8BB RID: 43195
		DrownEndTeleportRequest = 21245,
		// Token: 0x0400A8BC RID: 43196
		MonsterDrownRequest = 20753,
		// Token: 0x0400A8BD RID: 43197
		PassiveSkillRemoveRequest = 20977,
		// Token: 0x0400A8BE RID: 43198
		RTimeStopInstRequest = 18157,
		// Token: 0x0400A8BF RID: 43199
		FsmStateBehaviorRequest = 23005,
		// Token: 0x0400A8C0 RID: 43200
		FsmPlayMontageRequest = 25815,
		// Token: 0x0400A8C1 RID: 43201
		RTimeStopAnimRequest = 28674,
		// Token: 0x0400A8C2 RID: 43202
		SwitchRoleRequest = 27457,
		// Token: 0x0400A8C3 RID: 43203
		GameplayTagRequest = 17502,
		// Token: 0x0400A8C4 RID: 43204
		ExecuteQteRequest = 25206,
		// Token: 0x0400A8C5 RID: 43205
		CombineEntitiesRequest = 28910,
		// Token: 0x0400A8C6 RID: 43206
		DissolveCombineRelationRequest = 20585,
		// Token: 0x0400A8C7 RID: 43207
		ClientCurrentRoleReportRequest = 19037,
		// Token: 0x0400A8C8 RID: 43208
		GaSwitchCommonEnemyProCampRequest = 18387,
		// Token: 0x0400A8C9 RID: 43209
		ChangeSummonEntityStateRequest = 23569,
		// Token: 0x0400A8CA RID: 43210
		CombatMaxCaseMessageRequest = 28528
	}
}
