using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018FB RID: 6395
	[NullableContext(2)]
	[Nullable(0)]
	public class IActorInitialState
	{
		// Token: 0x06008629 RID: 34345 RVA: 0x0013F618 File Offset: 0x0013D818
		[NullableContext(0)]
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

		// Token: 0x0600862A RID: 34346 RVA: 0x0013F650 File Offset: 0x0013D850
		[NullableContext(0)]
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

		// Token: 0x0600862B RID: 34347 RVA: 0x0013F663 File Offset: 0x0013D863
		[NullableContext(0)]
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

		// Token: 0x0600862C RID: 34348 RVA: 0x0013F676 File Offset: 0x0013D876
		[NullableContext(0)]
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

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x0600862D RID: 34349 RVA: 0x0013F6B0 File Offset: 0x0013D8B0
		// (set) Token: 0x0600862E RID: 34350 RVA: 0x0013F711 File Offset: 0x0013D911
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

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x0600862F RID: 34351 RVA: 0x0013F726 File Offset: 0x0013D926
		// (set) Token: 0x06008630 RID: 34352 RVA: 0x0013F74D File Offset: 0x0013D94D
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

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x06008631 RID: 34353 RVA: 0x0013F75C File Offset: 0x0013D95C
		// (set) Token: 0x06008632 RID: 34354 RVA: 0x0013F7BD File Offset: 0x0013D9BD
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

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x06008633 RID: 34355 RVA: 0x0013F7D4 File Offset: 0x0013D9D4
		// (set) Token: 0x06008634 RID: 34356 RVA: 0x0013F80E File Offset: 0x0013DA0E
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

		// Token: 0x0400551D RID: 21789
		protected IActorInitialState FbInstance;

		// Token: 0x0400551E RID: 21790
		protected IActorInitialState_SetValue PocoInterface;

		// Token: 0x0400551F RID: 21791
		[Nullable(0)]
		private IActorInitialMontage _InitialMontageCache;

		// Token: 0x04005520 RID: 21792
		private bool _InitialMontageInited;

		// Token: 0x04005521 RID: 21793
		[Nullable(0)]
		private IActorInitialEffect _InitialEffectsCache;

		// Token: 0x04005522 RID: 21794
		private bool _InitialEffectsInited;
	}
}
