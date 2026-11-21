using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A8 RID: 10152
	public class IHeadStyle
	{
		// Token: 0x0600E0CC RID: 57548 RVA: 0x00211200 File Offset: 0x0020F400
		public static IHeadStyle Create(IHeadStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E2A RID: 15914
		// (get) Token: 0x0600E0CD RID: 57549 RVA: 0x0021121F File Offset: 0x0020F41F
		public virtual EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007A3E RID: 31294
		private IHeadStyle Instance;
	}
}
