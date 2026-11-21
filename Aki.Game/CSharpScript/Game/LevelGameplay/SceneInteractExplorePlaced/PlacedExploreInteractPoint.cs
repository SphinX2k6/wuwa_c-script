using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced
{
	// Token: 0x02005BF6 RID: 23542
	[NullableContext(1)]
	[Nullable(0)]
	public class PlacedExploreInteractPoint : EntitySceneInteractPointBase, ISceneInteractTag, ISceneInteractDebugPoint
	{
		// Token: 0x06039D1B RID: 236827 RVA: 0x0103CED4 File Offset: 0x0103B0D4
		public PlacedExploreInteractPoint(PlacedExploreInteractSkillPointContext Context)
		{
			this.Context = Context;
			this.InteractTagId = Context.GetInteractTagId().GetValueOrDefault();
		}

		// Token: 0x06039D1C RID: 236828 RVA: 0x0103CF0D File Offset: 0x0103B10D
		public override ESceneInteractSearchStrategyType? GetPointStrategyType()
		{
			return new ESceneInteractSearchStrategyType?(ESceneInteractSearchStrategyType.PlacedExploreInteractPoint);
		}

		// Token: 0x06039D1D RID: 236829 RVA: 0x0103CF15 File Offset: 0x0103B115
		public override ESceneInteractType GetInteractType()
		{
			return this.Context.GetInteractType();
		}

		// Token: 0x06039D1E RID: 236830 RVA: 0x0103CF22 File Offset: 0x0103B122
		public override void Clear()
		{
			this.Context.Dispose();
			base.Clear();
		}

		// Token: 0x06039D1F RID: 236831 RVA: 0x0103CF35 File Offset: 0x0103B135
		public override EntityHandle GetEntityHandle()
		{
			return this.Context.GetEntityHandle();
		}

		// Token: 0x06039D20 RID: 236832 RVA: 0x0103CF42 File Offset: 0x0103B142
		[NullableContext(2)]
		public override AActor GetOwnerActor()
		{
			return this.Context.GetOwnerActor();
		}

		// Token: 0x06039D21 RID: 236833 RVA: 0x0103CF4F File Offset: 0x0103B14F
		[NullableContext(2)]
		public override Vector GetLocation()
		{
			return this.LandingResolver.GetResolvedLocation() ?? this.Context.GetLocation();
		}

		// Token: 0x06039D22 RID: 236834 RVA: 0x0103CF6B File Offset: 0x0103B16B
		public string BuildLockWeightDebugText(Vector charLoc)
		{
			return this.Context.BuildLockWeightDebugText(this.GetLocation(), charLoc);
		}

		// Token: 0x06039D23 RID: 236835 RVA: 0x0103CF7F File Offset: 0x0103B17F
		public bool CheckEntityCondition()
		{
			return this.Context.CheckEntityCondition(this.GetOwnerActor());
		}

		// Token: 0x06039D24 RID: 236836 RVA: 0x0103CF92 File Offset: 0x0103B192
		public double GetLockWeight(Vector charLoc)
		{
			return this.Context.GetLockWeight(this.GetLocation(), charLoc);
		}

		// Token: 0x06039D25 RID: 236837 RVA: 0x0103CFA6 File Offset: 0x0103B1A6
		public bool UseTwoPhaseBlockCheck()
		{
			return this.Context.UseTwoPhaseBlockCheck();
		}

		// Token: 0x06039D26 RID: 236838 RVA: 0x0103CFB3 File Offset: 0x0103B1B3
		public int GetInteractTagId()
		{
			return this.InteractTagId;
		}

		// Token: 0x06039D27 RID: 236839 RVA: 0x0103CFBB File Offset: 0x0103B1BB
		public int GetEnableRangeId()
		{
			return this.Context.GetEnableRangeId();
		}

		// Token: 0x06039D28 RID: 236840 RVA: 0x0103CFC8 File Offset: 0x0103B1C8
		public int GetDisableRangeId()
		{
			return this.Context.GetDisableRangeId();
		}

		// Token: 0x06039D29 RID: 236841 RVA: 0x0103CFD5 File Offset: 0x0103B1D5
		public bool CheckPointCondition()
		{
			AActor ownerActor = this.GetOwnerActor();
			return ownerActor != null && ownerActor.IsValid();
		}

		// Token: 0x06039D2A RID: 236842 RVA: 0x0103CFF1 File Offset: 0x0103B1F1
		[NullableContext(2)]
		public Vector GetRaycastDestLocation()
		{
			return this.Context.GetRaycastDestLocation() ?? this.GetLocation();
		}

		// Token: 0x06039D2B RID: 236843 RVA: 0x0103D008 File Offset: 0x0103B208
		public void ClearResolvedSplineLanding()
		{
			this.LandingResolver.Clear();
		}

		// Token: 0x06039D2C RID: 236844 RVA: 0x0103D015 File Offset: 0x0103B215
		public void TryResolveSplineLanding(ISceneInteractSearchParams @params)
		{
			this.LandingResolver.TryResolve(this.Context.TryGetLandingSpline(), this.Context.GetLocation(), @params, this.Context.GetOwnerActor());
		}

		// Token: 0x0401E8B4 RID: 125108
		private readonly PlacedExploreInteractSkillPointContext Context;

		// Token: 0x0401E8B5 RID: 125109
		private readonly int InteractTagId;

		// Token: 0x0401E8B6 RID: 125110
		private readonly SplineLandingResolver LandingResolver = new SplineLandingResolver();
	}
}
