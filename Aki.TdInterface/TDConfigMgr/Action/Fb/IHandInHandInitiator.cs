using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D46 RID: 11590
	public class IHandInHandInitiator
	{
		// Token: 0x0600FD16 RID: 64790 RVA: 0x00248FFB File Offset: 0x002471FB
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

		// Token: 0x17004F38 RID: 20280
		// (get) Token: 0x0600FD17 RID: 64791 RVA: 0x0024901A File Offset: 0x0024721A
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

		// Token: 0x17004F39 RID: 20281
		// (get) Token: 0x0600FD18 RID: 64792 RVA: 0x00249049 File Offset: 0x00247249
		public virtual EHandType HandType
		{
			get
			{
				return (EHandType)this.Instance.HandType;
			}
		}

		// Token: 0x04008A28 RID: 35368
		private IHandInHandInitiator Instance;

		// Token: 0x04008A29 RID: 35369
		private IHandInHandInitiatorType _InitiatorCache;

		// Token: 0x04008A2A RID: 35370
		private bool _InitiatorInited;
	}
}
