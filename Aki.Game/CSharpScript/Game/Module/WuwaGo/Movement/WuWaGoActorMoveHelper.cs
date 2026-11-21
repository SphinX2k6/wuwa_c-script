using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Movement
{
	// Token: 0x0200365C RID: 13916
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoActorMoveHelper
	{
		// Token: 0x06024191 RID: 147857 RVA: 0x00A3747C File Offset: 0x00A3567C
		public static void SnapMoveTargetsByGridCoordinateDelta(Transform originTransform, Vector fromCoordinate, Vector toCoordinate, IReadOnlyList<IWuWaGoWorldMoveTarget> moveTargets)
		{
			if (moveTargets.Count == 0)
			{
				return;
			}
			WuWaGoUtil.GetWorldPositionByCoordinate(originTransform, fromCoordinate, WuWaGoActorMoveHelper.FromWorldPosition);
			WuWaGoUtil.GetWorldPositionByCoordinate(originTransform, toCoordinate, WuWaGoActorMoveHelper.ToWorldPosition);
			WuWaGoActorMoveHelper.WorldDelta.Set(WuWaGoActorMoveHelper.ToWorldPosition.X - WuWaGoActorMoveHelper.FromWorldPosition.X, WuWaGoActorMoveHelper.ToWorldPosition.Y - WuWaGoActorMoveHelper.FromWorldPosition.Y, WuWaGoActorMoveHelper.ToWorldPosition.Z - WuWaGoActorMoveHelper.FromWorldPosition.Z);
			if (WuWaGoActorMoveHelper.WorldDelta.IsNearlyZero(9.999999747378752E-05))
			{
				return;
			}
			foreach (IWuWaGoWorldMoveTarget wuWaGoWorldMoveTarget in moveTargets)
			{
				if (wuWaGoWorldMoveTarget.Unit != null)
				{
					if (wuWaGoWorldMoveTarget.Unit.IsActorValid())
					{
						FVectorDouble? worldLocation = wuWaGoWorldMoveTarget.Unit.GetWorldLocation();
						if (worldLocation != null)
						{
							WuWaGoActorMoveHelper.InterpLocation.Set(worldLocation.Value.X, worldLocation.Value.Y, worldLocation.Value.Z);
							WuWaGoActorMoveHelper.InterpLocation.AdditionEqual(WuWaGoActorMoveHelper.WorldDelta);
							wuWaGoWorldMoveTarget.Unit.SetActorWorldLocation(WuWaGoActorMoveHelper.InterpLocation, false);
						}
					}
				}
				else
				{
					AActor actor = wuWaGoWorldMoveTarget.Actor;
					if (actor != null && actor.IsValid())
					{
						Vector interpLocation = WuWaGoActorMoveHelper.InterpLocation;
						FVectorDouble fvectorDouble = actor.D_K2_GetActorLocation();
						interpLocation.DeepCopy(fvectorDouble);
						WuWaGoActorMoveHelper.InterpLocation.AdditionEqual(WuWaGoActorMoveHelper.WorldDelta);
						actor.D_K2_SetActorLocation(WuWaGoActorMoveHelper.InterpLocation.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, false);
					}
				}
			}
		}

		// Token: 0x06024192 RID: 147858 RVA: 0x00A3761C File Offset: 0x00A3581C
		public static List<IWuWaGoWorldMoveTarget> BuildGridMoveTargets(WuWaGoGrid grid, [Nullable(2)] WuWaGoGameplayEntityBase gameplayEntity = null, [Nullable(2)] WuWaGoRole role = null, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<IWuWaGoWorldMoveTarget> extraTargets = null)
		{
			List<IWuWaGoWorldMoveTarget> list = new List<IWuWaGoWorldMoveTarget>();
			HashSet<WuWaGoBaseUnit> seenUnits = new HashSet<WuWaGoBaseUnit>();
			HashSet<AActor> seenActors = new HashSet<AActor>();
			WuWaGoActorMoveHelper.AppendUnitMoveTarget(list, seenUnits, grid);
			WuWaGoActorMoveHelper.AppendActorMoveTarget(list, seenActors, grid.Applique);
			WuWaGoActorMoveHelper.AppendUnitMoveTarget(list, seenUnits, gameplayEntity);
			WuWaGoActorMoveHelper.AppendUnitMoveTarget(list, seenUnits, role);
			if (extraTargets != null)
			{
				foreach (IWuWaGoWorldMoveTarget target in extraTargets)
				{
					WuWaGoActorMoveHelper.AppendMoveTarget(list, seenUnits, seenActors, target);
				}
			}
			return list;
		}

		// Token: 0x06024193 RID: 147859 RVA: 0x00A376A4 File Offset: 0x00A358A4
		public static List<IWuWaGoWorldMoveTarget> BuildEntityMoveTargets([Nullable(2)] WuWaGoGameplayEntityBase gameplayEntity = null)
		{
			List<IWuWaGoWorldMoveTarget> list = new List<IWuWaGoWorldMoveTarget>();
			WuWaGoActorMoveHelper.AppendUnitMoveTarget(list, new HashSet<WuWaGoBaseUnit>(), gameplayEntity);
			return list;
		}

		// Token: 0x06024194 RID: 147860 RVA: 0x00A376B7 File Offset: 0x00A358B7
		public static List<IWuWaGoWorldMoveTarget> BuildRoleMoveTargets([Nullable(2)] WuWaGoRole role = null)
		{
			List<IWuWaGoWorldMoveTarget> list = new List<IWuWaGoWorldMoveTarget>();
			WuWaGoActorMoveHelper.AppendUnitMoveTarget(list, new HashSet<WuWaGoBaseUnit>(), role);
			return list;
		}

		// Token: 0x06024195 RID: 147861 RVA: 0x00A376CA File Offset: 0x00A358CA
		private static void AppendUnitMoveTarget(List<IWuWaGoWorldMoveTarget> targets, HashSet<WuWaGoBaseUnit> seenUnits, [Nullable(2)] WuWaGoBaseUnit unit = null)
		{
			if (unit == null || !unit.IsActorValid() || !seenUnits.Add(unit))
			{
				return;
			}
			targets.Add(new WuWaGoWorldMoveTarget
			{
				Unit = unit
			});
		}

		// Token: 0x06024196 RID: 147862 RVA: 0x00A376F3 File Offset: 0x00A358F3
		private static void AppendActorMoveTarget(List<IWuWaGoWorldMoveTarget> targets, HashSet<AActor> seenActors, [Nullable(2)] AActor actor = null)
		{
			if (actor == null || !actor.IsValid() || !seenActors.Add(actor))
			{
				return;
			}
			targets.Add(new WuWaGoWorldMoveTarget
			{
				Actor = actor
			});
		}

		// Token: 0x06024197 RID: 147863 RVA: 0x00A37724 File Offset: 0x00A35924
		private static void AppendMoveTarget(List<IWuWaGoWorldMoveTarget> targets, HashSet<WuWaGoBaseUnit> seenUnits, HashSet<AActor> seenActors, IWuWaGoWorldMoveTarget target)
		{
			if (target.Unit != null)
			{
				if (!target.Unit.IsActorValid() || !seenUnits.Add(target.Unit))
				{
					return;
				}
				targets.Add(target);
				return;
			}
			else
			{
				AActor actor = target.Actor;
				if (actor == null || !actor.IsValid() || !seenActors.Add(target.Actor))
				{
					return;
				}
				targets.Add(target);
				return;
			}
		}

		// Token: 0x04014207 RID: 82439
		[StaticVariableRuleIgnore]
		private static readonly Vector InterpLocation = Vector.Create();

		// Token: 0x04014208 RID: 82440
		[StaticVariableRuleIgnore]
		private static readonly Vector FromWorldPosition = Vector.Create();

		// Token: 0x04014209 RID: 82441
		[StaticVariableRuleIgnore]
		private static readonly Vector ToWorldPosition = Vector.Create();

		// Token: 0x0401420A RID: 82442
		[StaticVariableRuleIgnore]
		private static readonly Vector WorldDelta = Vector.Create();
	}
}
