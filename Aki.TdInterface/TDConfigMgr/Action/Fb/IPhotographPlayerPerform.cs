using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200264E RID: 9806
	public class IPhotographPlayerPerform
	{
		// Token: 0x0600DBEA RID: 56298 RVA: 0x0020BBAE File Offset: 0x00209DAE
		[NullableContext(1)]
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

		// Token: 0x17004110 RID: 16656
		// (get) Token: 0x0600DBEB RID: 56299 RVA: 0x0020BBD0 File Offset: 0x00209DD0
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

		// Token: 0x17004111 RID: 16657
		// (get) Token: 0x0600DBEC RID: 56300 RVA: 0x0020BC08 File Offset: 0x00209E08
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

		// Token: 0x04007A3E RID: 31294
		private IPhotographPlayerPerform Instance;
	}
}
