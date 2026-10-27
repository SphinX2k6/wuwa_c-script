using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D1D RID: 3357
	[NullableContext(2)]
	[Nullable(0)]
	public class IConnectorPointToPointPathAdvance : IConnectorLogicType
	{
		// Token: 0x06004C9F RID: 19615 RVA: 0x000BED8B File Offset: 0x000BCF8B
		[NullableContext(1)]
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

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06004CA0 RID: 19616 RVA: 0x000BEDAA File Offset: 0x000BCFAA
		public override EConnectorLogicType Type
		{
			get
			{
				return (EConnectorLogicType)this.Instance.Type;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06004CA1 RID: 19617 RVA: 0x000BEDB7 File Offset: 0x000BCFB7
		[Nullable(1)]
		public override IConnectorEffectConfig EffectConfig
		{
			[NullableContext(1)]
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

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06004CA2 RID: 19618 RVA: 0x000BEDEB File Offset: 0x000BCFEB
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

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06004CA3 RID: 19619 RVA: 0x000BEE1F File Offset: 0x000BD01F
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

		// Token: 0x04002BDA RID: 11226
		private IConnectorPointToPointPathAdvance Instance;

		// Token: 0x04002BDB RID: 11227
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04002BDC RID: 11228
		private bool _EffectConfigInited;

		// Token: 0x04002BDD RID: 11229
		private IConnectorPathAdvanceInitiator _InitiatorCache;

		// Token: 0x04002BDE RID: 11230
		private bool _InitiatorInited;

		// Token: 0x04002BDF RID: 11231
		private IConnectorPathAdvanceReceiver _ReceiverCache;

		// Token: 0x04002BE0 RID: 11232
		private bool _ReceiverInited;
	}
}
