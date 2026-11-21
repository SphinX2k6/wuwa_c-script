using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D48 RID: 11592
	public class ISetNpcHandInHandPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600FD1D RID: 64797 RVA: 0x00249092 File Offset: 0x00247292
		public static ISetNpcHandInHandPerform Create(ISetNpcHandInHandPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcHandInHandPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F3B RID: 20283
		// (get) Token: 0x0600FD1E RID: 64798 RVA: 0x002490B1 File Offset: 0x002472B1
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004F3C RID: 20284
		// (get) Token: 0x0600FD1F RID: 64799 RVA: 0x002490BE File Offset: 0x002472BE
		public virtual IHandInHandInitiator Initiator
		{
			get
			{
				if (this._InitiatorInited)
				{
					return this._InitiatorCache;
				}
				this._InitiatorInited = true;
				this._InitiatorCache = IHandInHandInitiator.Create(this.Instance.Initiator);
				return this._InitiatorCache;
			}
		}

		// Token: 0x17004F3D RID: 20285
		// (get) Token: 0x0600FD20 RID: 64800 RVA: 0x002490F2 File Offset: 0x002472F2
		public virtual int Follower
		{
			get
			{
				return this.Instance.Follower;
			}
		}

		// Token: 0x04008A2C RID: 35372
		private ISetNpcHandInHandPerform Instance;

		// Token: 0x04008A2D RID: 35373
		[Nullable(2)]
		private IHandInHandInitiator _InitiatorCache;

		// Token: 0x04008A2E RID: 35374
		private bool _InitiatorInited;
	}
}
