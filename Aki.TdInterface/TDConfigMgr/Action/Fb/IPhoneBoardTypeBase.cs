using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DB9 RID: 11705
	public class IPhoneBoardTypeBase
	{
		// Token: 0x0600FEF4 RID: 65268 RVA: 0x0024C122 File Offset: 0x0024A322
		public static IPhoneBoardTypeBase Create(IPhoneBoardTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneBoardTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005030 RID: 20528
		// (get) Token: 0x0600FEF5 RID: 65269 RVA: 0x0024C141 File Offset: 0x0024A341
		public virtual EPhoneBoardType Type
		{
			get
			{
				return (EPhoneBoardType)this.Instance.Type;
			}
		}

		// Token: 0x04008B27 RID: 35623
		private IPhoneBoardTypeBase Instance;
	}
}
