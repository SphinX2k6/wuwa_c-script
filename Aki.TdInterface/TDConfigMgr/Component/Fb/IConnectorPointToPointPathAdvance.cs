using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E17 RID: 3607
	[NullableContext(2)]
	[Nullable(0)]
	public class IConnectorPointToPointPathAdvance : IConnectorLogicType
	{
		// Token: 0x060051B9 RID: 20921 RVA: 0x000CA45F File Offset: 0x000C865F
		[NullableContext(0)]
		public static IConnectorPointToPointPathAdvance Create(IConnectorPointToPointPathAdvance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPointToPointPathAdvance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x060051BA RID: 20922 RVA: 0x000CA47E File Offset: 0x000C867E
		public override EConnectorLogicType Type
		{
			get
			{
				return (EConnectorLogicType)this.Instance.Type;
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x060051BB RID: 20923 RVA: 0x000CA48B File Offset: 0x000C868B
		[Nullable(0)]
		public override IConnectorEffectConfig EffectConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				this._EffectConfigCache = IConnectorEffectConfig.Create(this.Instance.EffectConfig);
				return this._EffectConfigCache;
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x060051BC RID: 20924 RVA: 0x000CA4BF File Offset: 0x000C86BF
		public virtual IConnectorPathAdvanceInitiator Initiator
		{
			get
			{
				if (this._InitiatorInited)
				{
					return this._InitiatorCache;
				}
				this._InitiatorInited = true;
				this._InitiatorCache = IConnectorPathAdvanceInitiator.Create(this.Instance.Initiator);
				return this._InitiatorCache;
			}
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x060051BD RID: 20925 RVA: 0x000CA4F3 File Offset: 0x000C86F3
		public virtual IConnectorPathAdvanceReceiver Receiver
		{
			get
			{
				if (this._ReceiverInited)
				{
					return this._ReceiverCache;
				}
				this._ReceiverInited = true;
				this._ReceiverCache = IConnectorPathAdvanceReceiver.Create(this.Instance.Receiver);
				return this._ReceiverCache;
			}
		}

		// Token: 0x04002E9A RID: 11930
		private IConnectorPointToPointPathAdvance Instance;

		// Token: 0x04002E9B RID: 11931
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04002E9C RID: 11932
		private bool _EffectConfigInited;

		// Token: 0x04002E9D RID: 11933
		private IConnectorPathAdvanceInitiator _InitiatorCache;

		// Token: 0x04002E9E RID: 11934
		private bool _InitiatorInited;

		// Token: 0x04002E9F RID: 11935
		private IConnectorPathAdvanceReceiver _ReceiverCache;

		// Token: 0x04002EA0 RID: 11936
		private bool _ReceiverInited;
	}
}
