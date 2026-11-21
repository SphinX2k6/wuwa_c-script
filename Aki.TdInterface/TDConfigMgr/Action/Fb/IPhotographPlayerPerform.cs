using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002912 RID: 10514
	public class IPhotographPlayerPerform
	{
		// Token: 0x0600E9C6 RID: 59846 RVA: 0x00228486 File Offset: 0x00226686
		public static IPhotographPlayerPerform Create(IPhotographPlayerPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographPlayerPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004450 RID: 17488
		// (get) Token: 0x0600E9C7 RID: 59847 RVA: 0x002284A8 File Offset: 0x002266A8
		public virtual int? MontageId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MontageId);
			}
		}

		// Token: 0x17004451 RID: 17489
		// (get) Token: 0x0600E9C8 RID: 59848 RVA: 0x002284E0 File Offset: 0x002266E0
		public virtual int? FaceId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FaceId);
			}
		}

		// Token: 0x040080E0 RID: 32992
		private IPhotographPlayerPerform Instance;
	}
}
