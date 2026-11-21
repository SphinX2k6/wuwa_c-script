using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A52 RID: 10834
	[NullableContext(2)]
	[Nullable(0)]
	public class IActorInitialState
	{
		// Token: 0x0600EF3C RID: 61244 RVA: 0x00231141 File Offset: 0x0022F341
		[NullableContext(0)]
		public static IActorInitialState Create(IActorInitialState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorInitialState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004746 RID: 18246
		// (get) Token: 0x0600EF3D RID: 61245 RVA: 0x00231160 File Offset: 0x0022F360
		public virtual IActorInitialMontage InitialMontage
		{
			get
			{
				if (this._InitialMontageInited)
				{
					return this._InitialMontageCache;
				}
				this._InitialMontageInited = true;
				this._InitialMontageCache = IActorInitialMontage.Create(this.Instance.InitialMontage);
				return this._InitialMontageCache;
			}
		}

		// Token: 0x17004747 RID: 18247
		// (get) Token: 0x0600EF3E RID: 61246 RVA: 0x00231194 File Offset: 0x0022F394
		[Nullable(0)]
		public virtual IActorLookAtData InitialLookAt
		{
			[NullableContext(0)]
			get
			{
				if (this._InitialLookAtInited)
				{
					return this._InitialLookAtCache;
				}
				this._InitialLookAtInited = true;
				this._InitialLookAtCache = ActionReadHelper.ReadIActorInitialState_InitialLookAt(this.Instance);
				return this._InitialLookAtCache;
			}
		}

		// Token: 0x17004748 RID: 18248
		// (get) Token: 0x0600EF3F RID: 61247 RVA: 0x002311C3 File Offset: 0x0022F3C3
		public virtual IActorInitialEffect InitialEffects
		{
			get
			{
				if (this._InitialEffectsInited)
				{
					return this._InitialEffectsCache;
				}
				this._InitialEffectsInited = true;
				this._InitialEffectsCache = IActorInitialEffect.Create(this.Instance.InitialEffects);
				return this._InitialEffectsCache;
			}
		}

		// Token: 0x17004749 RID: 18249
		// (get) Token: 0x0600EF40 RID: 61248 RVA: 0x002311F8 File Offset: 0x0022F3F8
		public virtual int? InitialFaceExpressionId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.InitialFaceExpressionId);
			}
		}

		// Token: 0x0400836E RID: 33646
		private IActorInitialState Instance;

		// Token: 0x0400836F RID: 33647
		private IActorInitialMontage _InitialMontageCache;

		// Token: 0x04008370 RID: 33648
		private bool _InitialMontageInited;

		// Token: 0x04008371 RID: 33649
		[Nullable(0)]
		private IActorLookAtData _InitialLookAtCache;

		// Token: 0x04008372 RID: 33650
		private bool _InitialLookAtInited;

		// Token: 0x04008373 RID: 33651
		private IActorInitialEffect _InitialEffectsCache;

		// Token: 0x04008374 RID: 33652
		private bool _InitialEffectsInited;
	}
}
