using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200465D RID: 18013
	public enum IGmCommand_Union : byte
	{
		// Token: 0x0400C7D9 RID: 51161
		NONE,
		// Token: 0x0400C7DA RID: 51162
		IGmCommand,
		// Token: 0x0400C7DB RID: 51163
		ISkipToLevelPlayNode,
		// Token: 0x0400C7DC RID: 51164
		IFinishCurrentLevelPlayNode,
		// Token: 0x0400C7DD RID: 51165
		ITeleportToCurLevelPlayTrackPosition,
		// Token: 0x0400C7DE RID: 51166
		IGmSetLevelPlaySwitchForce,
		// Token: 0x0400C7DF RID: 51167
		IGmSetLevelPlayUpdateForce,
		// Token: 0x0400C7E0 RID: 51168
		ITeleportToLevelPlayCenter,
		// Token: 0x0400C7E1 RID: 51169
		ISkipToQuestNode,
		// Token: 0x0400C7E2 RID: 51170
		IFinishCurrentTrackQuestNode,
		// Token: 0x0400C7E3 RID: 51171
		ITeleportToCurQuestTrackPosition,
		// Token: 0x0400C7E4 RID: 51172
		IAcceptQuest,
		// Token: 0x0400C7E5 RID: 51173
		IUnlockQuest,
		// Token: 0x0400C7E6 RID: 51174
		IPlayFlowForGm,
		// Token: 0x0400C7E7 RID: 51175
		ISkipToInstanceDungeonNode,
		// Token: 0x0400C7E8 RID: 51176
		IFinishCurTrackDungeonNode,
		// Token: 0x0400C7E9 RID: 51177
		ITeleportToCurDungeonTrackPosition,
		// Token: 0x0400C7EA RID: 51178
		IResetCurrentDungeon,
		// Token: 0x0400C7EB RID: 51179
		IExitDungeonInGm,
		// Token: 0x0400C7EC RID: 51180
		IGmRoguelikeStartInGm,
		// Token: 0x0400C7ED RID: 51181
		IGmGotoRogueRoomInGm,
		// Token: 0x0400C7EE RID: 51182
		IUnlockEntityForGm,
		// Token: 0x0400C7EF RID: 51183
		ITeleportToEntity,
		// Token: 0x0400C7F0 RID: 51184
		IGmTeleportToEntity,
		// Token: 0x0400C7F1 RID: 51185
		IOpenDungeonEntrance,
		// Token: 0x0400C7F2 RID: 51186
		IShowTipsView,
		// Token: 0x0400C7F3 RID: 51187
		IShieldGuide,
		// Token: 0x0400C7F4 RID: 51188
		IOpenFunc,
		// Token: 0x0400C7F5 RID: 51189
		ISetTime,
		// Token: 0x0400C7F6 RID: 51190
		IUnlockAllExploreSkill,
		// Token: 0x0400C7F7 RID: 51191
		IActivateTeleport,
		// Token: 0x0400C7F8 RID: 51192
		ISetUnopenedAreaPullback,
		// Token: 0x0400C7F9 RID: 51193
		ITeleportToPos,
		// Token: 0x0400C7FA RID: 51194
		ITeleportToPosInWorld,
		// Token: 0x0400C7FB RID: 51195
		IUnfreezeInstanceLimit,
		// Token: 0x0400C7FC RID: 51196
		IUpdateSceneRoles,
		// Token: 0x0400C7FD RID: 51197
		IAddAllRole,
		// Token: 0x0400C7FE RID: 51198
		IAddNewRole,
		// Token: 0x0400C7FF RID: 51199
		ISetAllRoleToGraduate,
		// Token: 0x0400C800 RID: 51200
		IAddAllItem,
		// Token: 0x0400C801 RID: 51201
		IAddItem,
		// Token: 0x0400C802 RID: 51202
		IAddAllPhantom,
		// Token: 0x0400C803 RID: 51203
		IGetAllGraduatedPhantom,
		// Token: 0x0400C804 RID: 51204
		IGetAllGraduatedWeapon,
		// Token: 0x0400C805 RID: 51205
		ISetEquippedWeaponToGraduate,
		// Token: 0x0400C806 RID: 51206
		IEquipGraduatedWeaponToTeam,
		// Token: 0x0400C807 RID: 51207
		IExecuteActionList,
		// Token: 0x0400C808 RID: 51208
		IOpenBackLoginView,
		// Token: 0x0400C809 RID: 51209
		ISavePlayerData,
		// Token: 0x0400C80A RID: 51210
		IBrokenRockHotFix,
		// Token: 0x0400C80B RID: 51211
		ISetVar,
		// Token: 0x0400C80C RID: 51212
		IGoToNode,
		// Token: 0x0400C80D RID: 51213
		ICustomTextGm,
		// Token: 0x0400C80E RID: 51214
		IStartCombatOperationCapture,
		// Token: 0x0400C80F RID: 51215
		IStopCombatOperationCapture,
		// Token: 0x0400C810 RID: 51216
		IRecordCombatOperationCaptureCheckpoint,
		// Token: 0x0400C811 RID: 51217
		IStartCombatOperationReplay,
		// Token: 0x0400C812 RID: 51218
		IStopCombatOperationReplay
	}
}
