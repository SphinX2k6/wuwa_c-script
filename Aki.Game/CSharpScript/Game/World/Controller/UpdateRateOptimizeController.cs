using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02003468 RID: 13416
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class UpdateRateOptimizeController : ControllerBase
	{
		// Token: 0x17004802 RID: 18434
		// (get) Token: 0x0602240E RID: 140302 RVA: 0x009B3A32 File Offset: 0x009B1C32
		protected HashSet<EntityHandle> CurFrameValidEntityHandles
		{
			get
			{
				return this.EntityHandlesCache[this.CurIndex];
			}
		}

		// Token: 0x17004803 RID: 18435
		// (get) Token: 0x0602240F RID: 140303 RVA: 0x009B3A45 File Offset: 0x009B1C45
		protected HashSet<EntityHandle> LastFrameValidEntityHandles
		{
			get
			{
				return this.EntityHandlesCache[1 - this.CurIndex];
			}
		}

		// Token: 0x06022410 RID: 140304 RVA: 0x009B3A5C File Offset: 0x009B1C5C
		protected override bool OnInit()
		{
			this.IsEnableRayTraceReflection = (GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracedReflection, 0, true) != 0);
			EventSystem.Instance.Add<bool>(EEventName.UpdateRayTraceReflection, new Action<bool>(this.UpdateRayTraceReflection));
			return base.OnInit();
		}

		// Token: 0x06022411 RID: 140305 RVA: 0x009B3AA8 File Offset: 0x009B1CA8
		protected override void OnTick(float delta)
		{
			if (!this.IsEnableRayTraceReflection)
			{
				this.EnableUpdateRateOptimizationForSet(true, this.LastFrameValidEntityHandles, null);
				this.EnableUpdateRateOptimizationForMap(true, this.PendingEnableEntityHandles, null);
				this.ResetState();
				return;
			}
			this.TempEntities.Clear();
			if (UKuroRenderingRuntimeBPPluginBPLibrary.GetDisableNPCOptAsRayTracing(GlobalData.World))
			{
				CreatureModel.Instance.GetEntitiesInRange(120000f, EEntityTypeQuery.Character, this.TempEntities, true, false);
			}
			this.EnableUpdateRateOptimizationForArray(false, this.TempEntities, delegate(EntityHandle handle)
			{
				this.CurFrameValidEntityHandles.Add(handle);
				this.LastFrameValidEntityHandles.Remove(handle);
				this.PendingEnableEntityHandles.Remove(handle);
			});
			foreach (EntityHandle key in this.LastFrameValidEntityHandles)
			{
				this.PendingEnableEntityHandles[key] = 0f;
			}
			this.LastFrameValidEntityHandles.Clear();
			this.TempEntities.Clear();
			foreach (KeyValuePair<EntityHandle, float> keyValuePair in this.PendingEnableEntityHandles)
			{
				EntityHandle entityHandle;
				float num;
				keyValuePair.Deconstruct(out entityHandle, out num);
				EntityHandle entityHandle2 = entityHandle;
				float num2 = num;
				if (entityHandle2.Valid && num2 < 3000f)
				{
					this.PendingEnableEntityHandles[entityHandle2] = num2 + delta;
				}
				else
				{
					this.TempEntities.Add(entityHandle2);
					this.PendingEnableEntityHandles.Remove(entityHandle2);
				}
			}
			this.EnableUpdateRateOptimizationForArray(true, this.TempEntities, null);
			this.CurIndex = 1 - this.CurIndex;
		}

		// Token: 0x06022412 RID: 140306 RVA: 0x009B3C38 File Offset: 0x009B1E38
		protected override bool OnClear()
		{
			this.ResetState();
			EventSystem.Instance.Remove<bool>(EEventName.UpdateRayTraceReflection, new Action<bool>(this.UpdateRayTraceReflection));
			return true;
		}

		// Token: 0x06022413 RID: 140307 RVA: 0x009B3C5D File Offset: 0x009B1E5D
		protected override bool OnLeaveLevel()
		{
			this.ResetState();
			return true;
		}

		// Token: 0x06022414 RID: 140308 RVA: 0x009B3C66 File Offset: 0x009B1E66
		protected void ResetState()
		{
			this.TempEntities.Clear();
			this.CurFrameValidEntityHandles.Clear();
			this.LastFrameValidEntityHandles.Clear();
			this.PendingEnableEntityHandles.Clear();
		}

		// Token: 0x06022415 RID: 140309 RVA: 0x009B3C94 File Offset: 0x009B1E94
		protected void UpdateRayTraceReflection(bool enable)
		{
			if (this.IsEnableRayTraceReflection == enable)
			{
				return;
			}
			this.IsEnableRayTraceReflection = enable;
		}

		// Token: 0x06022416 RID: 140310 RVA: 0x009B3CA8 File Offset: 0x009B1EA8
		protected void EnableUpdateRateOptimizationForArray(bool enable, List<EntityHandle> entityHandles, [Nullable(new byte[]
		{
			2,
			1
		})] Action<EntityHandle> action = null)
		{
			if (entityHandles.Count == 0)
			{
				return;
			}
			foreach (EntityHandle eHandle in entityHandles)
			{
				UpdateRateOptimizeController.ApplyOptimizationToEntity(enable, eHandle, action);
			}
		}

		// Token: 0x06022417 RID: 140311 RVA: 0x009B3D00 File Offset: 0x009B1F00
		protected void EnableUpdateRateOptimizationForSet(bool enable, HashSet<EntityHandle> entityHandles, [Nullable(new byte[]
		{
			2,
			1
		})] Action<EntityHandle> action = null)
		{
			if (entityHandles.Count == 0)
			{
				return;
			}
			foreach (EntityHandle eHandle in entityHandles)
			{
				UpdateRateOptimizeController.ApplyOptimizationToEntity(enable, eHandle, action);
			}
		}

		// Token: 0x06022418 RID: 140312 RVA: 0x009B3D58 File Offset: 0x009B1F58
		protected void EnableUpdateRateOptimizationForMap(bool enable, Dictionary<EntityHandle, float> entityHandlesMap, [Nullable(new byte[]
		{
			2,
			1
		})] Action<EntityHandle> action = null)
		{
			if (entityHandlesMap.Count == 0)
			{
				return;
			}
			foreach (EntityHandle eHandle in entityHandlesMap.Keys)
			{
				UpdateRateOptimizeController.ApplyOptimizationToEntity(enable, eHandle, action);
			}
		}

		// Token: 0x06022419 RID: 140313 RVA: 0x009B3DB8 File Offset: 0x009B1FB8
		private static void ApplyOptimizationToEntity(bool enable, EntityHandle eHandle, [Nullable(new byte[]
		{
			2,
			1
		})] Action<EntityHandle> action = null)
		{
			if (eHandle.EntityType != 10)
			{
				WorldEntity entity = eHandle.Entity;
				BaseAnimationComponent baseAnimationComponent = (entity != null) ? entity.GetComponent<BaseAnimationComponent>() : null;
				if (baseAnimationComponent == null)
				{
					return;
				}
				if (enable)
				{
					baseAnimationComponent.CancelForceDisableAnimOptimization(EForceDisableAnimOptimization.RayTrace);
				}
				else
				{
					baseAnimationComponent.StartForceDisableAnimOptimization2(EForceDisableAnimOptimization.RayTrace);
				}
			}
			else
			{
				WorldEntity entity2 = eHandle.Entity;
				VehicleAnimationComponent vehicleAnimationComponent = (entity2 != null) ? entity2.GetComponent<VehicleAnimationComponent>() : null;
				if (vehicleAnimationComponent == null)
				{
					return;
				}
				if (enable)
				{
					vehicleAnimationComponent.CancelForceDisableAnimOptimization(EForceDisableAnimOptimization.RayTrace);
				}
				else
				{
					vehicleAnimationComponent.StartForceDisableAnimOptimization2(EForceDisableAnimOptimization.RayTrace);
				}
			}
			if (action != null)
			{
				action(eHandle);
			}
		}

		// Token: 0x17004804 RID: 18436
		// (get) Token: 0x0602241A RID: 140314 RVA: 0x009B3E31 File Offset: 0x009B2031
		public static UpdateRateOptimizeController Instance
		{
			get
			{
				return UpdateRateOptimizeController._Instance;
			}
		}

		// Token: 0x0602241B RID: 140315 RVA: 0x009B3E38 File Offset: 0x009B2038
		public static UpdateRateOptimizeController GetOrCreateInstance()
		{
			if (UpdateRateOptimizeController._Instance == null)
			{
				UpdateRateOptimizeController.CreateInstance();
			}
			return UpdateRateOptimizeController._Instance;
		}

		// Token: 0x0602241C RID: 140316 RVA: 0x009B3E4C File Offset: 0x009B204C
		public static bool CreateInstance()
		{
			if (UpdateRateOptimizeController._Instance != null)
			{
				return true;
			}
			UpdateRateOptimizeController._Instance = new UpdateRateOptimizeController();
			return true;
		}

		// Token: 0x0602241D RID: 140317 RVA: 0x009B3E62 File Offset: 0x009B2062
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602241E RID: 140318 RVA: 0x009B3E64 File Offset: 0x009B2064
		public static void ResetStaticDefaultValue()
		{
			UpdateRateOptimizeController._Instance = null;
		}

		// Token: 0x0602241F RID: 140319 RVA: 0x009B3E6C File Offset: 0x009B206C
		static UpdateRateOptimizeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UpdateRateOptimizeController.CreateStaticDefaultValue), new Action(UpdateRateOptimizeController.ResetStaticDefaultValue));
		}

		// Token: 0x06022420 RID: 140320 RVA: 0x009B3E8C File Offset: 0x009B208C
		public unsafe UpdateRateOptimizeController()
		{
			int num = 2;
			List<HashSet<EntityHandle>> list = new List<HashSet<EntityHandle>>(num);
			CollectionsMarshal.SetCount<HashSet<EntityHandle>>(list, num);
			Span<HashSet<EntityHandle>> span = CollectionsMarshal.AsSpan<HashSet<EntityHandle>>(list);
			int num2 = 0;
			*span[num2] = new HashSet<EntityHandle>();
			num2++;
			*span[num2] = new HashSet<EntityHandle>();
			this.EntityHandlesCache = list;
			this.PendingEnableEntityHandles = new Dictionary<EntityHandle, float>();
			this.TempEntities = new List<EntityHandle>();
			base..ctor();
		}

		// Token: 0x04012DA7 RID: 77223
		private const int RAYTRACING_URO_CHECK_DISTANCE = 120000;

		// Token: 0x04012DA8 RID: 77224
		private const int DELAY_ENABLE_URO_TIME = 3000;

		// Token: 0x04012DA9 RID: 77225
		protected bool IsEnableRayTraceReflection;

		// Token: 0x04012DAA RID: 77226
		protected int CurIndex;

		// Token: 0x04012DAB RID: 77227
		protected List<HashSet<EntityHandle>> EntityHandlesCache;

		// Token: 0x04012DAC RID: 77228
		protected Dictionary<EntityHandle, float> PendingEnableEntityHandles;

		// Token: 0x04012DAD RID: 77229
		protected List<EntityHandle> TempEntities;

		// Token: 0x04012DAE RID: 77230
		[Nullable(2)]
		private static UpdateRateOptimizeController _Instance;
	}
}
