using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001522 RID: 5410
	public class IOperation
	{
		// Token: 0x06007A76 RID: 31350 RVA: 0x001242BC File Offset: 0x001224BC
		public static IOperation Create(IOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x06007A77 RID: 31351 RVA: 0x001242DB File Offset: 0x001224DB
		public virtual EOperation Type
		{
			get
			{
				return (EOperation)this.Instance.Type;
			}
		}

		// Token: 0x04004690 RID: 18064
		private IOperation Instance;
	}
}
