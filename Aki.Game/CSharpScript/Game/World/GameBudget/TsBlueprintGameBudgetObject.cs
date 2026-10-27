using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.World.GameBudget
{
	// Token: 0x0200452D RID: 17709
	[NullableContext(1)]
	[Nullable(0)]
	public class TsBlueprintGameBudgetObject : IGameBudgetManagedObject
	{
		// Token: 0x0602DBED RID: 187373 RVA: 0x00A82CB4 File Offset: 0x00A80EB4
		public TsBlueprintGameBudgetObject(AActor actor)
		{
			this.Actor = actor;
			this.ScheduledTickMethod = actor.GetType().GetMethod("ScheduledTick", new Type[]
			{
				typeof(float)
			});
		}

		// Token: 0x0602DBEE RID: 187374 RVA: 0x00A82CEC File Offset: 0x00A80EEC
		public bool HasScheduledTickMethod()
		{
			return this.ScheduledTickMethod != null;
		}

		// Token: 0x0602DBEF RID: 187375 RVA: 0x00A82CFC File Offset: 0x00A80EFC
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

		// Token: 0x0602DBF0 RID: 187376 RVA: 0x00A82D55 File Offset: 0x00A80F55
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

		// Token: 0x0602DBF1 RID: 187377 RVA: 0x00A82D8C File Offset: 0x00A80F8C
		public void ScheduledTick(float deltaSeconds, int deltaFrames, float distance)
		{
			AActor actor = this.Actor;
			if (actor == null || !actor.IsValid())
			{
				Log.Instance.Error(ELogModule.Game, ELogAuthor.WLJ, "TsBlueprintGameBudgetObject Tick Invalid Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.UnregisterTick();
				return;
			}
			if (this.ScheduledTickMethod != null)
			{
				this.ScheduledTickMethod.Invoke(this.Actor, new object[]
				{
					deltaSeconds
				});
			}
		}

		// Token: 0x17007516 RID: 29974
		// (get) Token: 0x0602DBF2 RID: 187378 RVA: 0x00A82E02 File Offset: 0x00A81002
		public bool HasScheduledAfterTick
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602DBF3 RID: 187379 RVA: 0x00A82E05 File Offset: 0x00A81005
		void IGameBudgetManagedObject.ScheduledAfterTick(float deltaSeconds, int deltaFrames, float distance)
		{
		}

		// Token: 0x17007517 RID: 29975
		// (get) Token: 0x0602DBF4 RID: 187380 RVA: 0x00A82E07 File Offset: 0x00A81007
		public bool HasOnEnabledChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602DBF5 RID: 187381 RVA: 0x00A82E0A File Offset: 0x00A8100A
		void IGameBudgetManagedObject.OnEnabledChange(bool enable, float distance)
		{
		}

		// Token: 0x17007518 RID: 29976
		// (get) Token: 0x0602DBF6 RID: 187382 RVA: 0x00A82E0C File Offset: 0x00A8100C
		public bool HasOnWasRecentlyRenderedOnScreenChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602DBF7 RID: 187383 RVA: 0x00A82E0F File Offset: 0x00A8100F
		void IGameBudgetManagedObject.OnWasRecentlyRenderedOnScreenChange(bool wasRecentlyRenderedOnScreen)
		{
		}

		// Token: 0x17007519 RID: 29977
		// (get) Token: 0x0602DBF8 RID: 187384 RVA: 0x00A82E11 File Offset: 0x00A81011
		public bool HasLocationProxyFunction
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602DBF9 RID: 187385 RVA: 0x00A82E14 File Offset: 0x00A81014
		FVectorDouble? IGameBudgetManagedObject.LocationProxyFunction()
		{
			return null;
		}

		// Token: 0x0602DBFA RID: 187386 RVA: 0x00A82E2A File Offset: 0x00A8102A
		public GCHandle GetGCHandle()
		{
			return this.GameBudgetGCHandle;
		}

		// Token: 0x040186C6 RID: 100038
		public AActor Actor;

		// Token: 0x040186C7 RID: 100039
		[Nullable(2)]
		private readonly MethodInfo ScheduledTickMethod;

		// Token: 0x040186C8 RID: 100040
		private bool HasRegister;

		// Token: 0x040186C9 RID: 100041
		private GCHandle GameBudgetGCHandle;
	}
}
