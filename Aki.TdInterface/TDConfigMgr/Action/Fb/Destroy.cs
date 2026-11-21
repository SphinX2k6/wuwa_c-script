using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002937 RID: 10551
	public class Destroy : ActionParams
	{
		// Token: 0x0600EA7C RID: 60028 RVA: 0x002299BE File Offset: 0x00227BBE
		public static Destroy Create(IDestroy? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Destroy
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044BC RID: 17596
		// (get) Token: 0x0600EA7D RID: 60029 RVA: 0x002299E0 File Offset: 0x00227BE0
		public virtual bool? DelayDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DelayDestroy);
			}
		}

		// Token: 0x0400813F RID: 33087
		private IDestroy Instance;
	}
}
