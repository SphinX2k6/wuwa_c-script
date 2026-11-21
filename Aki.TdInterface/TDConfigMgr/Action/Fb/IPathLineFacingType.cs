using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BAC RID: 11180
	public class IPathLineFacingType
	{
		// Token: 0x0600F65E RID: 63070 RVA: 0x0023E387 File Offset: 0x0023C587
		public static IPathLineFacingType Create(IPathLineFacingType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineFacingType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BB4 RID: 19380
		// (get) Token: 0x0600F65F RID: 63071 RVA: 0x0023E3A6 File Offset: 0x0023C5A6
		public virtual EPathLineFacingType Type
		{
			get
			{
				return (EPathLineFacingType)this.Instance.Type;
			}
		}

		// Token: 0x04008714 RID: 34580
		private IPathLineFacingType Instance;
	}
}
