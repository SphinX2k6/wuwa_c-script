using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200713D RID: 28989
	[NullableContext(1)]
	public interface IPlayerFollowerChairHandler : IPlayerFollowerHandler
	{
		// Token: 0x06046C62 RID: 289890
		void SummonChair();

		// Token: 0x06046C63 RID: 289891
		long GetChairCreatureDataId();

		// Token: 0x06046C64 RID: 289892
		bool IsSummonedChairSitDownNotSettled(Entity chairEntity);

		// Token: 0x06046C65 RID: 289893
		bool IsSummonedChairManualSitBlocked(Entity chairEntity);

		// Token: 0x06046C66 RID: 289894
		bool IsChairSpaceOccupied(Entity chairEntity);

		// Token: 0x06046C67 RID: 289895
		[NullableContext(2)]
		void SetChairSpaceOccupied([Nullable(1)] Entity chairEntity, bool occupied, AActor triggerActor = null, AActor currentOccupantActor = null);

		// Token: 0x06046C68 RID: 289896
		void ExitSitDownDueToOverlap();

		// Token: 0x06046C69 RID: 289897
		void ExitSitDownDueToPlayerMove();

		// Token: 0x06046C6A RID: 289898
		void RecallChairDueToTickGroundCheck();

		// Token: 0x06046C6B RID: 289899
		void HideChairDueToLeaveRange(Entity chairEntity, int transactionVersion);

		// Token: 0x06046C6C RID: 289900
		void TryStartRemoteVisibilityByChairEntity(Entity chairEntity);

		// Token: 0x06046C6D RID: 289901
		void TryRebindLocalChairEntity(Entity chairEntity);

		// Token: 0x06046C6E RID: 289902
		[NullableContext(2)]
		void OnRemoteChairPresentationNotify(long chairCreatureDataId, bool isShow, Aki.Protocol.Vector location, Aki.Protocol.Rotator rotation);
	}
}
