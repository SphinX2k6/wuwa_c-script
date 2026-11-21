using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B59 RID: 11097
	public class IMontageId
	{
		// Token: 0x0600F3EA RID: 62442 RVA: 0x00239354 File Offset: 0x00237554
		public static IMontageId Create(IMontageId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E6 RID: 18918
		// (get) Token: 0x0600F3EB RID: 62443 RVA: 0x00239373 File Offset: 0x00237573
		public virtual int MontageId
		{
			get
			{
				return this.Instance.MontageId;
			}
		}

		// Token: 0x170049E7 RID: 18919
		// (get) Token: 0x0600F3EC RID: 62444 RVA: 0x00239380 File Offset: 0x00237580
		public virtual bool? IsAbp
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAbp);
			}
		}

		// Token: 0x040085C7 RID: 34247
		private IMontageId Instance;
	}
}
