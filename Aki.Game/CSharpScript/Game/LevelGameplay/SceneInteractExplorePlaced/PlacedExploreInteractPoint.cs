using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced
{
	// Token: 0x02006A99 RID: 27289
	[NullableContext(1)]
	[Nullable(0)]
	public class PlacedExploreInteractPoint : EntitySceneInteractPointBase, ISceneInteractTag, ISceneInteractDebugPoint
	{
		// Token: 0x06043CCD RID: 277709 RVA: 0x0109868C File Offset: 0x0109688C
		public PlacedExploreInteractPoint(PlacedExploreInteractSkillPointContext Context)
		{
			this.Context = Context;
			this.InteractTagId = Context.GetInteractTagId().GetValueOrDefault();
		}

		// Token: 0x06043CCE RID: 277710 RVA: 0x010986C5 File Offset: 0x010968C5
		public override ESceneInteractSearchStrategyType? GetPointStrategyType()
		{
			return new ESceneInteractSearchStrategyType?(ESceneInteractSearchStrategyType.PlacedExploreInteractPoint);
		}

		// Token: 0x06043CCF RID: 277711 RVA: 0x010986CD File Offset: 0x010968CD
		public override ESceneInteractType GetInteractType()
		{
			return this.Context.GetInteractType();
		}

		// Token: 0x06043CD0 RID: 277712 RVA: 0x010986DA File Offset: 0x010968DA
		public override void Clear()
		{
			this.Context.Dispose();
			base.Clear();
		}

		// Token: 0x06043CD1 RID: 277713 RVA: 0x010986ED File Offset: 0x010968ED
		public override EntityHandle GetEntityHandle()
		{
			return this.Context.GetEntityHandle();
		}

		// Token: 0x06043CD2 RID: 277714 RVA: 0x010986FA File Offset: 0x010968FA
		[NullableContext(2)]
		public override AActor GetOwnerActor()
		{
			return this.Context.GetOwnerActor();
		}

		// Token: 0x06043CD3 RID: 277715 RVA: 0x01098707 File Offset: 0x01096907
		[NullableContext(2)]
		public override Vector GetLocation()
		{
			return this.LandingResolver.GetResolvedLocation() ?? this.Context.GetLocation();
		}

		// Token: 0x06043CD4 RID: 277716 RVA: 0x01098723 File Offset: 0x01096923
		public string BuildLockWeightDebugText(Vector charLoc)
		{
			return this.Context.BuildLockWeightDebugText(this.GetLocation(), charLoc);
		}

		// Token: 0x06043CD5 RID: 277717 RVA: 0x01098737 File Offset: 0x01096937
		public bool CheckEntityCondition()
		{
			return this.Context.CheckEntityCondition(this.GetOwnerActor());
		}

		// Token: 0x06043CD6 RID: 277718 RVA: 0x0109874A File Offset: 0x0109694A
		public double GetLockWeight(Vector charLoc)
		{
			return this.Context.GetLockWeight(this.GetLocation(), charLoc);
		}

		// Token: 0x06043CD7 RID: 277719 RVA: 0x0109875E File Offset: 0x0109695E
		public bool UseTwoPhaseBlockCheck()
		{
			return this.Context.UseTwoPhaseBlockCheck();
		}

		// Token: 0x06043CD8 RID: 277720 RVA: 0x0109876B File Offset: 0x0109696B
		public int GetInteractTagId()
		{
			return this.InteractTagId;
		}

		// Token: 0x06043CD9 RID: 277721 RVA: 0x01098773 File Offset: 0x01096973
		public int GetEnableRangeId()
		{
			return this.Context.GetEnableRangeId();
		}

		// Token: 0x06043CDA RID: 277722 RVA: 0x01098780 File Offset: 0x01096980
		public int GetDisableRangeId()
		{
			return this.Context.GetDisableRangeId();
		}

		// Token: 0x06043CDB RID: 277723 RVA: 0x0109878D File Offset: 0x0109698D
		public bool CheckPointCondition()
		{
			AActor ownerActor = this.GetOwnerActor();
			return ownerActor != null && ownerActor.IsValid();
		}

		// Token: 0x06043CDC RID: 277724 RVA: 0x010987A9 File Offset: 0x010969A9
		[NullableContext(2)]
		public Vector GetRaycastDestLocation()
		{
			return this.Context.GetRaycastDestLocation() ?? this.GetLocation();
		}

		// Token: 0x06043CDD RID: 277725 RVA: 0x010987C0 File Offset: 0x010969C0
		public void ClearResolvedSplineLanding()
		{
			this.LandingResolver.Clear();
		}

		// Token: 0x06043CDE RID: 277726 RVA: 0x010987CD File Offset: 0x010969CD
		public void TryResolveSplineLanding(ISceneInteractSearchParams @params)
		{
			this.LandingResolver.TryResolve(this.Context.TryGetLandingSpline(), this.Context.GetLocation(), @params, this.Context.GetOwnerActor());
		}

		// Token: 0x040236C2 RID: 145090
		private readonly PlacedExploreInteractSkillPointContext Context;

		// Token: 0x040236C3 RID: 145091
		private readonly int InteractTagId;

		// Token: 0x040236C4 RID: 145092
		private readonly SplineLandingResolver LandingResolver = new SplineLandingResolver();
	}
}
