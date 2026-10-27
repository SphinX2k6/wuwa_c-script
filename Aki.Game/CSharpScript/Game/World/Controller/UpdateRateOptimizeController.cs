using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02004540 RID: 17728
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class UpdateRateOptimizeController : ControllerBase
	{
		// Token: 0x1700754B RID: 30027
		// (get) Token: 0x0602DD2C RID: 187692 RVA: 0x00A882FE File Offset: 0x00A864FE
		protected HashSet<EntityHandle> CurFrameValidEntityHandles
		{
			get
			{
				return this.EntityHandlesCache[this.CurIndex];
			}
		}

		// Token: 0x1700754C RID: 30028
		// (get) Token: 0x0602DD2D RID: 187693 RVA: 0x00A88311 File Offset: 0x00A86511
		protected HashSet<EntityHandle> LastFrameValidEntityHandles
		{
			get
			{
				return this.EntityHandlesCache[1 - this.CurIndex];
			}
		}

		// Token: 0x0602DD2E RID: 187694 RVA: 0x00A88328 File Offset: 0x00A86528
		protected override bool OnInit()
		{
			this.IsEnableRayTraceReflection = (GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracedReflection, 0, true) != 0);
			EventSystem.Instance.Add<bool>(EEventName.UpdateRayTraceReflection, new Action<bool>(this.UpdateRayTraceReflection));
			return base.OnInit();
		}

		// Token: 0x0602DD2F RID: 187695 RVA: 0x00A88374 File Offset: 0x00A86574
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

		// Token: 0x0602DD30 RID: 187696 RVA: 0x00A88504 File Offset: 0x00A86704
		protected override bool OnClear()
		{
			this.ResetState();
			EventSystem.Instance.Remove<bool>(EEventName.UpdateRayTraceReflection, new Action<bool>(this.UpdateRayTraceReflection));
			return true;
		}

		// Token: 0x0602DD31 RID: 187697 RVA: 0x00A88529 File Offset: 0x00A86729
		protected override bool OnLeaveLevel()
		{
			this.ResetState();
			return true;
		}

		// Token: 0x0602DD32 RID: 187698 RVA: 0x00A88532 File Offset: 0x00A86732
		protected void ResetState()
		{
			this.TempEntities.Clear();
			this.CurFrameValidEntityHandles.Clear();
			this.LastFrameValidEntityHandles.Clear();
			this.PendingEnableEntityHandles.Clear();
		}

		// Token: 0x0602DD33 RID: 187699 RVA: 0x00A88560 File Offset: 0x00A86760
		protected void UpdateRayTraceReflection(bool enable)
		{
			if (this.IsEnableRayTraceReflection == enable)
			{
				return;
			}
			this.IsEnableRayTraceReflection = enable;
		}

		// Token: 0x0602DD34 RID: 187700 RVA: 0x00A88574 File Offset: 0x00A86774
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

		// Token: 0x0602DD35 RID: 187701 RVA: 0x00A885CC File Offset: 0x00A867CC
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

		// Token: 0x0602DD36 RID: 187702 RVA: 0x00A88624 File Offset: 0x00A86824
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

		// Token: 0x0602DD37 RID: 187703 RVA: 0x00A88684 File Offset: 0x00A86884
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

		// Token: 0x1700754D RID: 30029
		// (get) Token: 0x0602DD38 RID: 187704 RVA: 0x00A886FD File Offset: 0x00A868FD
		public static UpdateRateOptimizeController Instance
		{
			get
			{
				return UpdateRateOptimizeController._Instance;
			}
		}

		// Token: 0x0602DD39 RID: 187705 RVA: 0x00A88704 File Offset: 0x00A86904
		public static UpdateRateOptimizeController GetOrCreateInstance()
		{
			if (UpdateRateOptimizeController._Instance == null)
			{
				UpdateRateOptimizeController.CreateInstance();
			}
			return UpdateRateOptimizeController._Instance;
		}

		// Token: 0x0602DD3A RID: 187706 RVA: 0x00A88718 File Offset: 0x00A86918
		public static bool CreateInstance()
		{
			if (UpdateRateOptimizeController._Instance != null)
			{
				return true;
			}
			UpdateRateOptimizeController._Instance = new UpdateRateOptimizeController();
			return true;
		}

		// Token: 0x0602DD3B RID: 187707 RVA: 0x00A8872E File Offset: 0x00A8692E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DD3C RID: 187708 RVA: 0x00A88730 File Offset: 0x00A86930
		public static void ResetStaticDefaultValue()
		{
			UpdateRateOptimizeController._Instance = null;
		}

		// Token: 0x0602DD3D RID: 187709 RVA: 0x00A88738 File Offset: 0x00A86938
		static UpdateRateOptimizeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UpdateRateOptimizeController.CreateStaticDefaultValue), new Action(UpdateRateOptimizeController.ResetStaticDefaultValue));
		}

		// Token: 0x0602DD3E RID: 187710 RVA: 0x00A88758 File Offset: 0x00A86958
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

		// Token: 0x0401876D RID: 100205
		private const int RAYTRACING_URO_CHECK_DISTANCE = 120000;

		// Token: 0x0401876E RID: 100206
		private const int DELAY_ENABLE_URO_TIME = 3000;

		// Token: 0x0401876F RID: 100207
		protected bool IsEnableRayTraceReflection;

		// Token: 0x04018770 RID: 100208
		protected int CurIndex;

		// Token: 0x04018771 RID: 100209
		protected List<HashSet<EntityHandle>> EntityHandlesCache;

		// Token: 0x04018772 RID: 100210
		protected Dictionary<EntityHandle, float> PendingEnableEntityHandles;

		// Token: 0x04018773 RID: 100211
		protected List<EntityHandle> TempEntities;

		// Token: 0x04018774 RID: 100212
		[Nullable(2)]
		private static UpdateRateOptimizeController _Instance;
	}
}
