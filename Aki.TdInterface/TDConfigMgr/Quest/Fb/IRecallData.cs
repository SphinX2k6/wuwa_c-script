using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001452 RID: 5202
	public class IRecallData
	{
		// Token: 0x06007646 RID: 30278 RVA: 0x0011A8C2 File Offset: 0x00118AC2
		[NullableContext(1)]
		public static IRecallData Create(IRecallData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x06007647 RID: 30279 RVA: 0x0011A8E1 File Offset: 0x00118AE1
		public virtual ERecallDataType Type
		{
			get
			{
				return (ERecallDataType)this.Instance.Type;
			}
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x06007648 RID: 30280 RVA: 0x0011A8EE File Offset: 0x00118AEE
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040044AC RID: 17580
		private IRecallData Instance;
	}
}
