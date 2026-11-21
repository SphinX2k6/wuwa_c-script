using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A25 RID: 10789
	public class IPhotographicTip : ICommonTipType
	{
		// Token: 0x0600EE6C RID: 61036 RVA: 0x0022FB90 File Offset: 0x0022DD90
		public static IPhotographicTip Create(IPhotographicTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographicTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046D0 RID: 18128
		// (get) Token: 0x0600EE6D RID: 61037 RVA: 0x0022FBAF File Offset: 0x0022DDAF
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046D1 RID: 18129
		// (get) Token: 0x0600EE6E RID: 61038 RVA: 0x0022FBBC File Offset: 0x0022DDBC
		public virtual string MainText
		{
			get
			{
				return this.Instance.MainText;
			}
		}

		// Token: 0x04008305 RID: 33541
		private IPhotographicTip Instance;
	}
}
