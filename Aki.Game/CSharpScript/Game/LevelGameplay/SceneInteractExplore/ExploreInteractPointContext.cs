using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplore
{
	// Token: 0x02006A92 RID: 27282
	[NullableContext(2)]
	[Nullable(0)]
	public class ExploreInteractPointContext : ExploreSkillInteractPointContextBase
	{
		// Token: 0x06043C97 RID: 277655 RVA: 0x01097A04 File Offset: 0x01095C04
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

		// Token: 0x06043C98 RID: 277656 RVA: 0x01097AB8 File Offset: 0x01095CB8
		public override ESceneInteractPointType GetInteractPointType()
		{
			return ESceneInteractPointType.ExploreInteractPoint;
		}

		// Token: 0x06043C99 RID: 277657 RVA: 0x01097ABB File Offset: 0x01095CBB
		public IIgnoresCollisionCfg GetIgnoresCollisionCfg()
		{
			return this.Config.IgnoresCollisionCfg;
		}

		// Token: 0x06043C9A RID: 277658 RVA: 0x01097AC8 File Offset: 0x01095CC8
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

		// Token: 0x040236B1 RID: 145073
		private Vector TempRaycastOffset;
	}
}
