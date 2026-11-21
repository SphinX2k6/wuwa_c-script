using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Utils;

namespace CSharpScript.Game.World.GameBudget
{
	// Token: 0x02003452 RID: 13394
	[NullableContext(1)]
	[Nullable(0)]
	public class TsBlueprintGameBudgetObject : IGameBudgetManagedObject
	{
		// Token: 0x060222B4 RID: 139956 RVA: 0x009ADECC File Offset: 0x009AC0CC
		public TsBlueprintGameBudgetObject(AActor actor)
		{
			this.Actor = actor;
			int num;
			IntPtr ufunctionPtrAndSize = UnrealReflectionUtils.GetUFunctionPtrAndSize(actor.NativePtr, TsBlueprintGameBudgetObject.ScheduledTickName, out num);
			this.ScheduledTickMethod = (ufunctionPtrAndSize != 0 && num >= 4);
		}

		// Token: 0x060222B5 RID: 139957 RVA: 0x009ADF0C File Offset: 0x009AC10C
		public bool HasScheduledTickMethod()
		{
			return this.ScheduledTickMethod;
		}

		// Token: 0x060222B6 RID: 139958 RVA: 0x009ADF14 File Offset: 0x009AC114
		public uint RegisterTick(TsGameBudgetGroupConfigCache groupConfig)
		{
			if (this.HasRegister)
			{
				return 0U;
			}
			this.HasRegister = true;
			if (!this.GameBudgetGCHandle.IsAllocated)
			{
				this.GameBudgetGCHandle = GCHandle.Alloc(this, GCHandleType.Normal);
			}
			return GameBudgetInterfaceController.Instance.RegisterTick(groupConfig.GroupName, groupConfig.SignificanceGroup, this, this.Actor, true, true, true, true);
		}

		// Token: 0x060222B7 RID: 139959 RVA: 0x009ADF6D File Offset: 0x009AC16D
		public void UnregisterTick()
		{
			if (!this.HasRegister)
			{
				return;
			}
			this.HasRegister = false;
			GameBudgetInterfaceController.Instance.UnregisterTick(this);
			if (this.GameBudgetGCHandle.IsAllocated)
			{
				this.GameBudgetGCHandle.Free();
			}
		}

		// Token: 0x060222B8 RID: 139960 RVA: 0x009ADFA4 File Offset: 0x009AC1A4
		public unsafe void ScheduledTick(float deltaSeconds, int deltaFrames, float distance)
		{
			AActor actor = this.Actor;
			if (actor == null || !actor.IsValid())
			{
				Log.Instance.Error(ELogModule.Game, ELogAuthor.WLJ, "TsBlueprintGameBudgetObject Tick Invalid Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.UnregisterTick();
				return;
			}
			if (this.ScheduledTickMethod)
			{
				int num;
				IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(this.Actor.NativePtr, TsBlueprintGameBudgetObject.ScheduledTickName, out num);
				byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)] + 15L & -16L;
				UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr, 1);
				*(float*)ptr = deltaSeconds;
				UnrealReflectionUtils.CallUFunction(this.Actor.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr);
				UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr, 1);
			}
		}

		// Token: 0x170047C9 RID: 18377
		// (get) Token: 0x060222B9 RID: 139961 RVA: 0x009AE054 File Offset: 0x009AC254
		public bool HasScheduledAfterTick
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060222BA RID: 139962 RVA: 0x009AE057 File Offset: 0x009AC257
		void IGameBudgetManagedObject.ScheduledAfterTick(float deltaSeconds, int deltaFrames, float distance)
		{
		}

		// Token: 0x170047CA RID: 18378
		// (get) Token: 0x060222BB RID: 139963 RVA: 0x009AE059 File Offset: 0x009AC259
		public bool HasOnEnabledChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060222BC RID: 139964 RVA: 0x009AE05C File Offset: 0x009AC25C
		void IGameBudgetManagedObject.OnEnabledChange(bool enable, float distance)
		{
		}

		// Token: 0x170047CB RID: 18379
		// (get) Token: 0x060222BD RID: 139965 RVA: 0x009AE05E File Offset: 0x009AC25E
		public bool HasOnWasRecentlyRenderedOnScreenChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060222BE RID: 139966 RVA: 0x009AE061 File Offset: 0x009AC261
		void IGameBudgetManagedObject.OnWasRecentlyRenderedOnScreenChange(bool wasRecentlyRenderedOnScreen)
		{
		}

		// Token: 0x170047CC RID: 18380
		// (get) Token: 0x060222BF RID: 139967 RVA: 0x009AE063 File Offset: 0x009AC263
		public bool HasLocationProxyFunction
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060222C0 RID: 139968 RVA: 0x009AE068 File Offset: 0x009AC268
		FVectorDouble? IGameBudgetManagedObject.LocationProxyFunction()
		{
			return null;
		}

		// Token: 0x060222C1 RID: 139969 RVA: 0x009AE07E File Offset: 0x009AC27E
		public GCHandle GetGCHandle()
		{
			return this.GameBudgetGCHandle;
		}

		// Token: 0x04012CEA RID: 77034
		public AActor Actor;

		// Token: 0x04012CEB RID: 77035
		private readonly bool ScheduledTickMethod;

		// Token: 0x04012CEC RID: 77036
		private bool HasRegister;

		// Token: 0x04012CED RID: 77037
		private GCHandle GameBudgetGCHandle;

		// Token: 0x04012CEE RID: 77038
		private static readonly FName ScheduledTickName = new FName("ScheduledTick");
	}
}
