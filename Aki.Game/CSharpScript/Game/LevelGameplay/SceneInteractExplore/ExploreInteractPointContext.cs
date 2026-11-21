using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplore
{
	// Token: 0x02005BEF RID: 23535
	[NullableContext(2)]
	[Nullable(0)]
	public class ExploreInteractPointContext : ExploreSkillInteractPointContextBase
	{
		// Token: 0x06039CE5 RID: 236773 RVA: 0x0103C258 File Offset: 0x0103A458
		[NullableContext(1)]
		public ExploreInteractPointContext(IExploreSkillInteract config, EntityHandle entityHandle) : base(config, entityHandle)
		{
			IExploreSkillInteractType option = config.Option;
			if (option.Type == EExploreSkillInteractType.FoxJumpInteractPoint && (option as IFoxJumpInteractPoint).PositionConfig.Type == EFoxJumpInteractPointRelationType.ThisEntity && ((option as IFoxJumpInteractPoint).PositionConfig as IFoxJumpPositionOnThisEntity).SplineEntityId != null)
			{
				int? splineEntityId = ((option as IFoxJumpInteractPoint).PositionConfig as IFoxJumpPositionOnThisEntity).SplineEntityId;
				int num = 0;
				if (!(splineEntityId.GetValueOrDefault() == num & splineEntityId != null))
				{
					this.SplineLandingBindingSlot = new SplineLandingBinding(((option as IFoxJumpInteractPoint).PositionConfig as IFoxJumpPositionOnThisEntity).SplineEntityId.Value, entityHandle.PbDataId);
				}
			}
		}

		// Token: 0x06039CE6 RID: 236774 RVA: 0x0103C30C File Offset: 0x0103A50C
		public override ESceneInteractPointType GetInteractPointType()
		{
			return ESceneInteractPointType.ExploreInteractPoint;
		}

		// Token: 0x06039CE7 RID: 236775 RVA: 0x0103C30F File Offset: 0x0103A50F
		public IIgnoresCollisionCfg GetIgnoresCollisionCfg()
		{
			return this.Config.IgnoresCollisionCfg;
		}

		// Token: 0x06039CE8 RID: 236776 RVA: 0x0103C31C File Offset: 0x0103A51C
		public Vector GetRaycastDestOffset()
		{
			IExploreSkillInteractType option = this.Config.Option;
			if (option.Type != EExploreSkillInteractType.FoxJumpInteractPoint)
			{
				return null;
			}
			if ((option as IFoxJumpInteractPoint).PositionConfig.RaycastDestOffset == null)
			{
				return null;
			}
			if (this.TempRaycastOffset == null)
			{
				this.TempRaycastOffset = Vector.Create();
			}
			this.TempRaycastOffset.FromConfigVector((option as IFoxJumpInteractPoint).PositionConfig.RaycastDestOffset);
			return this.TempRaycastOffset;
		}

		// Token: 0x0401E8A3 RID: 125091
		private Vector TempRaycastOffset;
	}
}
