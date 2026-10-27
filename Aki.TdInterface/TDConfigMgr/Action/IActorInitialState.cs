using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200177A RID: 6010
	[NullableContext(2)]
	[Nullable(0)]
	public class IActorInitialState
	{
		// Token: 0x06007F39 RID: 32569 RVA: 0x001303B8 File Offset: 0x0012E5B8
		[NullableContext(1)]
		private IActorInitialState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorInitialState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorInitialState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorInitialState_SetValue());
			}
			return result;
		}

		// Token: 0x06007F3A RID: 32570 RVA: 0x001303F0 File Offset: 0x0012E5F0
		[NullableContext(1)]
		public static IActorInitialState Create([Nullable(2)] IActorInitialState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorInitialState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F3B RID: 32571 RVA: 0x00130403 File Offset: 0x0012E603
		[NullableContext(1)]
		public static IActorInitialState CreateFromSetValue([Nullable(2)] IActorInitialState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorInitialState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F3C RID: 32572 RVA: 0x00130416 File Offset: 0x0012E616
		[NullableContext(1)]
		public IActorInitialState_SetValue ToSetValue()
		{
			return new IActorInitialState_SetValue
			{
				InitialMontage = this.InitialMontage,
				InitialLookAt = this.InitialLookAt,
				InitialEffects = this.InitialEffects,
				InitialFaceExpressionId = this.InitialFaceExpressionId
			};
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x06007F3D RID: 32573 RVA: 0x00130450 File Offset: 0x0012E650
		// (set) Token: 0x06007F3E RID: 32574 RVA: 0x001304B1 File Offset: 0x0012E6B1
		public virtual IActorInitialMontage InitialMontage
		{
			get
			{
				if (this._InitialMontageInited)
				{
					return this._InitialMontageCache;
				}
				this._InitialMontageInited = true;
				if (this.FbInstance != null)
				{
					this._InitialMontageCache = IActorInitialMontage.Create(this.FbInstance.InitialMontage);
				}
				else
				{
					IActorInitialState_SetValue pocoInterface = this.PocoInterface;
					this._InitialMontageCache = ((pocoInterface != null) ? pocoInterface.InitialMontage : null);
				}
				return this._InitialMontageCache;
			}
			set
			{
				this.GetOrCreatePoco().InitialMontage = value;
				this._InitialMontageInited = false;
			}
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x06007F3F RID: 32575 RVA: 0x001304C6 File Offset: 0x0012E6C6
		// (set) Token: 0x06007F40 RID: 32576 RVA: 0x001304ED File Offset: 0x0012E6ED
		public virtual IActorLookAtData InitialLookAt
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitialLookAt;
				}
				IActorInitialState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitialLookAt;
			}
			set
			{
				this.GetOrCreatePoco().InitialLookAt = value;
			}
		}

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x06007F41 RID: 32577 RVA: 0x001304FC File Offset: 0x0012E6FC
		// (set) Token: 0x06007F42 RID: 32578 RVA: 0x0013055D File Offset: 0x0012E75D
		public virtual IActorInitialEffect InitialEffects
		{
			get
			{
				if (this._InitialEffectsInited)
				{
					return this._InitialEffectsCache;
				}
				this._InitialEffectsInited = true;
				if (this.FbInstance != null)
				{
					this._InitialEffectsCache = IActorInitialEffect.Create(this.FbInstance.InitialEffects);
				}
				else
				{
					IActorInitialState_SetValue pocoInterface = this.PocoInterface;
					this._InitialEffectsCache = ((pocoInterface != null) ? pocoInterface.InitialEffects : null);
				}
				return this._InitialEffectsCache;
			}
			set
			{
				this.GetOrCreatePoco().InitialEffects = value;
				this._InitialEffectsInited = false;
			}
		}

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x06007F43 RID: 32579 RVA: 0x00130574 File Offset: 0x0012E774
		// (set) Token: 0x06007F44 RID: 32580 RVA: 0x001305AE File Offset: 0x0012E7AE
		public virtual int? InitialFaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitialFaceExpressionId;
				}
				IActorInitialState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitialFaceExpressionId;
			}
			set
			{
				this.GetOrCreatePoco().InitialFaceExpressionId = value;
			}
		}

		// Token: 0x040050E7 RID: 20711
		protected IActorInitialState FbInstance;

		// Token: 0x040050E8 RID: 20712
		protected IActorInitialState_SetValue PocoInterface;

		// Token: 0x040050E9 RID: 20713
		[Nullable(1)]
		private IActorInitialMontage _InitialMontageCache;

		// Token: 0x040050EA RID: 20714
		private bool _InitialMontageInited;

		// Token: 0x040050EB RID: 20715
		[Nullable(1)]
		private IActorInitialEffect _InitialEffectsCache;

		// Token: 0x040050EC RID: 20716
		private bool _InitialEffectsInited;
	}
}
