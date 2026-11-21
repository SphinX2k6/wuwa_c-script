using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002792 RID: 10130
	public class ICommonBtContext : IVarContext
	{
		// Token: 0x0600E05A RID: 57434 RVA: 0x0021041A File Offset: 0x0020E61A
		public static ICommonBtContext Create(ICommonBtContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DE4 RID: 15844
		// (get) Token: 0x0600E05B RID: 57435 RVA: 0x00210439 File Offset: 0x0020E639
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003DE5 RID: 15845
		// (get) Token: 0x0600E05C RID: 57436 RVA: 0x00210446 File Offset: 0x0020E646
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007A04 RID: 31236
		private ICommonBtContext Instance;
	}
}
