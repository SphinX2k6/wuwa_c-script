using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E16 RID: 11798
	public class ILiveDanmakuOperation
	{
		// Token: 0x0601004A RID: 65610 RVA: 0x0024E175 File Offset: 0x0024C375
		public static ILiveDanmakuOperation Create(ILiveDanmakuOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveDanmakuOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050CC RID: 20684
		// (get) Token: 0x0601004B RID: 65611 RVA: 0x0024E194 File Offset: 0x0024C394
		public virtual ELiveDanmakuOperationType Type
		{
			get
			{
				return (ELiveDanmakuOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008BDC RID: 35804
		private ILiveDanmakuOperation Instance;
	}
}
