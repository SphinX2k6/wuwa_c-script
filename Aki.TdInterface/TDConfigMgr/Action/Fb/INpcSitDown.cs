using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AEA RID: 10986
	public class INpcSitDown : INpcLeisureInteractType
	{
		// Token: 0x0600F1CF RID: 61903 RVA: 0x002359EE File Offset: 0x00233BEE
		public static INpcSitDown Create(INpcSitDown? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSitDown
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048A9 RID: 18601
		// (get) Token: 0x0600F1D0 RID: 61904 RVA: 0x00235A0D File Offset: 0x00233C0D
		public override ENpcLeisureInteract Type
		{
			get
			{
				return (ENpcLeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170048AA RID: 18602
		// (get) Token: 0x0600F1D1 RID: 61905 RVA: 0x00235A1C File Offset: 0x00233C1C
		public override bool? KeepState
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepState);
			}
		}

		// Token: 0x170048AB RID: 18603
		// (get) Token: 0x0600F1D2 RID: 61906 RVA: 0x00235A52 File Offset: 0x00233C52
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				this._MontageIdCache = IMontageId.Create(this.Instance.MontageId);
				return this._MontageIdCache;
			}
		}

		// Token: 0x170048AC RID: 18604
		// (get) Token: 0x0600F1D3 RID: 61907 RVA: 0x00235A86 File Offset: 0x00233C86
		public virtual int PosEntityId
		{
			get
			{
				return this.Instance.PosEntityId;
			}
		}

		// Token: 0x170048AD RID: 18605
		// (get) Token: 0x0600F1D4 RID: 61908 RVA: 0x00235A93 File Offset: 0x00233C93
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x040084C8 RID: 33992
		private INpcSitDown Instance;

		// Token: 0x040084C9 RID: 33993
		[Nullable(2)]
		private IMontageId _MontageIdCache;

		// Token: 0x040084CA RID: 33994
		private bool _MontageIdInited;
	}
}
