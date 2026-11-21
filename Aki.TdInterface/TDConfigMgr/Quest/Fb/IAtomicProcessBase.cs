using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001562 RID: 5474
	public class IAtomicProcessBase
	{
		// Token: 0x06007B73 RID: 31603 RVA: 0x00125A77 File Offset: 0x00123C77
		public static IAtomicProcessBase Create(IAtomicProcessBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAtomicProcessBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x06007B74 RID: 31604 RVA: 0x00125A96 File Offset: 0x00123C96
		public virtual EAtomicProcess Type
		{
			get
			{
				return (EAtomicProcess)this.Instance.Type;
			}
		}

		// Token: 0x04004720 RID: 18208
		private IAtomicProcessBase Instance;
	}
}
