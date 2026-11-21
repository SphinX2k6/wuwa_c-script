using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D4E RID: 11598
	public class ISetNpcSupportedWalkingPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600FD3C RID: 64828 RVA: 0x0024933A File Offset: 0x0024753A
		public static ISetNpcSupportedWalkingPerform Create(ISetNpcSupportedWalkingPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcSupportedWalkingPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F4E RID: 20302
		// (get) Token: 0x0600FD3D RID: 64829 RVA: 0x00249359 File Offset: 0x00247559
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004F4F RID: 20303
		// (get) Token: 0x0600FD3E RID: 64830 RVA: 0x00249366 File Offset: 0x00247566
		public virtual IPlayerInitiator Initiator
		{
			get
			{
				if (this._InitiatorInited)
				{
					return this._InitiatorCache;
				}
				this._InitiatorInited = true;
				this._InitiatorCache = IPlayerInitiator.Create(this.Instance.Initiator);
				return this._InitiatorCache;
			}
		}

		// Token: 0x17004F50 RID: 20304
		// (get) Token: 0x0600FD3F RID: 64831 RVA: 0x0024939A File Offset: 0x0024759A
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x04008A3A RID: 35386
		private ISetNpcSupportedWalkingPerform Instance;

		// Token: 0x04008A3B RID: 35387
		[Nullable(2)]
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x04008A3C RID: 35388
		private bool _InitiatorInited;
	}
}
