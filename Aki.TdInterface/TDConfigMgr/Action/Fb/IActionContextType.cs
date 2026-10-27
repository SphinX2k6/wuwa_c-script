using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024C4 RID: 9412
	public class IActionContextType
	{
		// Token: 0x0600D255 RID: 53845 RVA: 0x001F3767 File Offset: 0x001F1967
		[NullableContext(1)]
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

		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x0600D256 RID: 53846 RVA: 0x001F3786 File Offset: 0x001F1986
		public virtual TActionContextType Type
		{
			get
			{
				return (TActionContextType)this.Instance.Type;
			}
		}

		// Token: 0x0400736C RID: 29548
		private IActionContextType Instance;
	}
}
