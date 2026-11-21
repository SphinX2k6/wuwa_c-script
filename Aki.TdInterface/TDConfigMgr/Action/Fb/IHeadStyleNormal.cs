using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A9 RID: 10153
	public class IHeadStyleNormal : IHeadStyle
	{
		// Token: 0x0600E0CF RID: 57551 RVA: 0x00211234 File Offset: 0x0020F434
		public static IHeadStyleNormal Create(IHeadStyleNormal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleNormal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E2B RID: 15915
		// (get) Token: 0x0600E0D0 RID: 57552 RVA: 0x00211253 File Offset: 0x0020F453
		public override EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x17003E2C RID: 15916
		// (get) Token: 0x0600E0D1 RID: 57553 RVA: 0x00211260 File Offset: 0x0020F460
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x04007A3F RID: 31295
		private IHeadStyleNormal Instance;
	}
}
