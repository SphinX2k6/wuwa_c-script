using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200027D RID: 637
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorPointToPointPathAdvance : IConnectorLogicType
	{
		// Token: 0x06000BB5 RID: 2997 RVA: 0x0002E760 File Offset: 0x0002C960
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

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0002E798 File Offset: 0x0002C998
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

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0002E7AB File Offset: 0x0002C9AB
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

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0002E7BE File Offset: 0x0002C9BE
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

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0002E7F5 File Offset: 0x0002C9F5
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x0002E820 File Offset: 0x0002CA20
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

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0002E830 File Offset: 0x0002CA30
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x0002E891 File Offset: 0x0002CA91
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

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0002E8A8 File Offset: 0x0002CAA8
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0002E909 File Offset: 0x0002CB09
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

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0002E920 File Offset: 0x0002CB20
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x0002E981 File Offset: 0x0002CB81
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

		// Token: 0x04000B33 RID: 2867
		[Nullable(2)]
		protected new IConnectorPointToPointPathAdvance FbInstance;

		// Token: 0x04000B34 RID: 2868
		[Nullable(2)]
		protected new IConnectorPointToPointPathAdvance_SetValue PocoInterface;

		// Token: 0x04000B35 RID: 2869
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04000B36 RID: 2870
		private bool _EffectConfigInited;

		// Token: 0x04000B37 RID: 2871
		private IConnectorPathAdvanceInitiator _InitiatorCache;

		// Token: 0x04000B38 RID: 2872
		private bool _InitiatorInited;

		// Token: 0x04000B39 RID: 2873
		private IConnectorPathAdvanceReceiver _ReceiverCache;

		// Token: 0x04000B3A RID: 2874
		private bool _ReceiverInited;
	}
}
