using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200636B RID: 25451
	[NullableContext(1)]
	public interface IPlayerFollowerChairHandler : IPlayerFollowerHandler
	{
		// Token: 0x0603DAB3 RID: 252595
		void SummonChair();

		// Token: 0x0603DAB4 RID: 252596
		long GetChairCreatureDataId();

		// Token: 0x0603DAB5 RID: 252597
		bool IsSummonedChairSitDownNotSettled(Entity chairEntity);

		// Token: 0x0603DAB6 RID: 252598
		bool IsSummonedChairManualSitBlocked(Entity chairEntity);

		// Token: 0x0603DAB7 RID: 252599
		bool IsChairSpaceOccupied(Entity chairEntity);

		// Token: 0x0603DAB8 RID: 252600
		[NullableContext(2)]
		void SetChairSpaceOccupied([Nullable(1)] Entity chairEntity, bool occupied, AActor triggerActor = null, AActor currentOccupantActor = null);

		// Token: 0x0603DAB9 RID: 252601
		void ExitSitDownDueToOverlap();

		// Token: 0x0603DABA RID: 252602
		void ExitSitDownDueToPlayerMove();

		// Token: 0x0603DABB RID: 252603
		void RecallChairDueToTickGroundCheck();

		// Token: 0x0603DABC RID: 252604
		void HideChairDueToLeaveRange(Entity chairEntity, int transactionVersion);

		// Token: 0x0603DABD RID: 252605
		void TryStartRemoteVisibilityByChairEntity(Entity chairEntity);

		// Token: 0x0603DABE RID: 252606
		void TryRebindLocalChairEntity(Entity chairEntity);

		// Token: 0x0603DABF RID: 252607
		[NullableContext(2)]
		void OnRemoteChairPresentationNotify(long chairCreatureDataId, bool isShow, Aki.Protocol.Vector location, Aki.Protocol.Rotator rotation);
	}
}
