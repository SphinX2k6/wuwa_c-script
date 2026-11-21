using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C0 RID: 704
	public class IConnectorPointToPointPathAdvance : IConnectorLogicType
	{
		// Token: 0x06000CCF RID: 3279 RVA: 0x00031450 File Offset: 0x0002F650
		private IConnectorPointToPointPathAdvance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConnectorPointToPointPathAdvance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConnectorPointToPointPathAdvance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConnectorPointToPointPathAdvance_SetValue());
			}
			return result;
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00031488 File Offset: 0x0002F688
		public static IConnectorPointToPointPathAdvance Create([Nullable(2)] IConnectorPointToPointPathAdvance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPointToPointPathAdvance
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0003149B File Offset: 0x0002F69B
		public static IConnectorPointToPointPathAdvance CreateFromSetValue([Nullable(2)] IConnectorPointToPointPathAdvance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConnectorPointToPointPathAdvance
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000314AE File Offset: 0x0002F6AE
		public new IConnectorPointToPointPathAdvance_SetValue ToSetValue()
		{
			return new IConnectorPointToPointPathAdvance_SetValue
			{
				Type = this.Type,
				EffectConfig = this.EffectConfig,
				Initiator = this.Initiator,
				Receiver = this.Receiver
			};
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x000314E5 File Offset: 0x0002F6E5
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x00031510 File Offset: 0x0002F710
		public override EConnectorLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EConnectorLogicType.Range;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00031520 File Offset: 0x0002F720
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00031581 File Offset: 0x0002F781
		public override IConnectorEffectConfig EffectConfig
		{
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EffectConfigCache = IConnectorEffectConfig.Create(this.FbInstance.EffectConfig);
				}
				else
				{
					IConnectorPointToPointPathAdvance_SetValue pocoInterface = this.PocoInterface;
					this._EffectConfigCache = ((pocoInterface != null) ? pocoInterface.EffectConfig : null);
				}
				return this._EffectConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().EffectConfig = value;
				this._EffectConfigInited = false;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x00031598 File Offset: 0x0002F798
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x000315F9 File Offset: 0x0002F7F9
		[Nullable(2)]
		public virtual IConnectorPathAdvanceInitiator Initiator
		{
			[NullableContext(2)]
			get
			{
				if (this._InitiatorInited)
				{
					return this._InitiatorCache;
				}
				this._InitiatorInited = true;
				if (this.FbInstance != null)
				{
					this._InitiatorCache = IConnectorPathAdvanceInitiator.Create(this.FbInstance.Initiator);
				}
				else
				{
					IConnectorPointToPointPathAdvance_SetValue pocoInterface = this.PocoInterface;
					this._InitiatorCache = ((pocoInterface != null) ? pocoInterface.Initiator : null);
				}
				return this._InitiatorCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Initiator = value;
				this._InitiatorInited = false;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x00031610 File Offset: 0x0002F810
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x00031671 File Offset: 0x0002F871
		[Nullable(2)]
		public virtual IConnectorPathAdvanceReceiver Receiver
		{
			[NullableContext(2)]
			get
			{
				if (this._ReceiverInited)
				{
					return this._ReceiverCache;
				}
				this._ReceiverInited = true;
				if (this.FbInstance != null)
				{
					this._ReceiverCache = IConnectorPathAdvanceReceiver.Create(this.FbInstance.Receiver);
				}
				else
				{
					IConnectorPointToPointPathAdvance_SetValue pocoInterface = this.PocoInterface;
					this._ReceiverCache = ((pocoInterface != null) ? pocoInterface.Receiver : null);
				}
				return this._ReceiverCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Receiver = value;
				this._ReceiverInited = false;
			}
		}

		// Token: 0x04000C14 RID: 3092
		[Nullable(2)]
		protected new IConnectorPointToPointPathAdvance FbInstance;

		// Token: 0x04000C15 RID: 3093
		[Nullable(2)]
		protected new IConnectorPointToPointPathAdvance_SetValue PocoInterface;

		// Token: 0x04000C16 RID: 3094
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04000C17 RID: 3095
		private bool _EffectConfigInited;

		// Token: 0x04000C18 RID: 3096
		private IConnectorPathAdvanceInitiator _InitiatorCache;

		// Token: 0x04000C19 RID: 3097
		private bool _InitiatorInited;

		// Token: 0x04000C1A RID: 3098
		private IConnectorPathAdvanceReceiver _ReceiverCache;

		// Token: 0x04000C1B RID: 3099
		private bool _ReceiverInited;
	}
}
