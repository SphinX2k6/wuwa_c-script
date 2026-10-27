using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A59 RID: 10841
	[NullableContext(1)]
	[Nullable(0)]
	public class IHandInHandInitiator
	{
		// Token: 0x0600EE7E RID: 61054 RVA: 0x0022B647 File Offset: 0x00229847
		public static IHandInHandInitiator Create(IHandInHandInitiator? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInHandInitiator
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B8E RID: 19342
		// (get) Token: 0x0600EE7F RID: 61055 RVA: 0x0022B666 File Offset: 0x00229866
		public virtual IHandInHandInitiatorType Initiator
		{
			get
			{
				if (this._InitiatorInited)
				{
					return this._InitiatorCache;
				}
				this._InitiatorInited = true;
				this._InitiatorCache = ActionReadHelper.ReadIHandInHandInitiator_Initiator(this.Instance);
				return this._InitiatorCache;
			}
		}

		// Token: 0x17004B8F RID: 19343
		// (get) Token: 0x0600EE80 RID: 61056 RVA: 0x0022B695 File Offset: 0x00229895
		public virtual EHandType HandType
		{
			get
			{
				return (EHandType)this.Instance.HandType;
			}
		}

		// Token: 0x04008335 RID: 33589
		private IHandInHandInitiator Instance;

		// Token: 0x04008336 RID: 33590
		private IHandInHandInitiatorType _InitiatorCache;

		// Token: 0x04008337 RID: 33591
		private bool _InitiatorInited;
	}
}
