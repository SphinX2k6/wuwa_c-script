using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002780 RID: 10112
	[NullableContext(2)]
	[Nullable(0)]
	public class IActorInitialState
	{
		// Token: 0x0600E11E RID: 57630 RVA: 0x002143AD File Offset: 0x002125AD
		[NullableContext(1)]
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

		// Token: 0x170043E0 RID: 17376
		// (get) Token: 0x0600E11F RID: 57631 RVA: 0x002143CC File Offset: 0x002125CC
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

		// Token: 0x170043E1 RID: 17377
		// (get) Token: 0x0600E120 RID: 57632 RVA: 0x00214400 File Offset: 0x00212600
		[Nullable(1)]
		public virtual IActorLookAtData InitialLookAt
		{
			[NullableContext(1)]
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

		// Token: 0x170043E2 RID: 17378
		// (get) Token: 0x0600E121 RID: 57633 RVA: 0x0021442F File Offset: 0x0021262F
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

		// Token: 0x170043E3 RID: 17379
		// (get) Token: 0x0600E122 RID: 57634 RVA: 0x00214464 File Offset: 0x00212664
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

		// Token: 0x04007CB8 RID: 31928
		private IActorInitialState Instance;

		// Token: 0x04007CB9 RID: 31929
		private IActorInitialMontage _InitialMontageCache;

		// Token: 0x04007CBA RID: 31930
		private bool _InitialMontageInited;

		// Token: 0x04007CBB RID: 31931
		[Nullable(1)]
		private IActorLookAtData _InitialLookAtCache;

		// Token: 0x04007CBC RID: 31932
		private bool _InitialLookAtInited;

		// Token: 0x04007CBD RID: 31933
		private IActorInitialEffect _InitialEffectsCache;

		// Token: 0x04007CBE RID: 31934
		private bool _InitialEffectsInited;
	}
}
