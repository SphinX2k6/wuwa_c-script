using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002769 RID: 10089
	public class IActionContextType
	{
		// Token: 0x0600DFAA RID: 57258 RVA: 0x0020EFC3 File Offset: 0x0020D1C3
		public static IActionContextType Create(IActionContextType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActionContextType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x0600DFAB RID: 57259 RVA: 0x0020EFE2 File Offset: 0x0020D1E2
		public virtual TActionContextType Type
		{
			get
			{
				return (TActionContextType)this.Instance.Type;
			}
		}

		// Token: 0x040079B9 RID: 31161
		private IActionContextType Instance;
	}
}
