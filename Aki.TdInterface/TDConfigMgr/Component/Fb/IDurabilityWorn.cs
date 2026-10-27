using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B68 RID: 2920
	public class IDurabilityWorn
	{
		// Token: 0x06004337 RID: 17207 RVA: 0x000AB58A File Offset: 0x000A978A
		[NullableContext(1)]
		public static IDurabilityWorn Create(IDurabilityWorn? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurabilityWorn
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06004338 RID: 17208 RVA: 0x000AB5AC File Offset: 0x000A97AC
		public virtual int? SlightWear
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SlightWear);
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06004339 RID: 17209 RVA: 0x000AB5E4 File Offset: 0x000A97E4
		public virtual int? SevereWear
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SevereWear);
			}
		}

		// Token: 0x040025F5 RID: 9717
		private IDurabilityWorn Instance;
	}
}
