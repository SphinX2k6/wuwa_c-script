using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002778 RID: 10104
	public class IFoldable
	{
		// Token: 0x0600DFE8 RID: 57320 RVA: 0x0020F650 File Offset: 0x0020D850
		public static IFoldable Create(IFoldable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoldable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x0600DFE9 RID: 57321 RVA: 0x0020F670 File Offset: 0x0020D870
		public virtual bool? _Folded
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance._Folded);
			}
		}

		// Token: 0x040079CC RID: 31180
		private IFoldable Instance;
	}
}
