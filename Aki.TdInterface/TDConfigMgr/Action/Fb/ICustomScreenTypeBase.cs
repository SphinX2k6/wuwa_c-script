using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200269B RID: 9883
	public class ICustomScreenTypeBase
	{
		// Token: 0x0600DD37 RID: 56631 RVA: 0x0020DF46 File Offset: 0x0020C146
		[NullableContext(1)]
		public static ICustomScreenTypeBase Create(ICustomScreenTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041C3 RID: 16835
		// (get) Token: 0x0600DD38 RID: 56632 RVA: 0x0020DF65 File Offset: 0x0020C165
		public virtual ECustomScreenType Type
		{
			get
			{
				return (ECustomScreenType)this.Instance.Type;
			}
		}

		// Token: 0x04007ADF RID: 31455
		private ICustomScreenTypeBase Instance;
	}
}
