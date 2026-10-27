using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A72 RID: 2674
	public class IInteractPlayerDiractionToNpc : IInteractPlayerDiractionType
	{
		// Token: 0x06003DA0 RID: 15776 RVA: 0x0009E1F5 File Offset: 0x0009C3F5
		[NullableContext(1)]
		public static IInteractPlayerDiractionToNpc Create(IInteractPlayerDiractionToNpc? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionToNpc
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06003DA1 RID: 15777 RVA: 0x0009E214 File Offset: 0x0009C414
		public override EInteractPlayerDiractionType Type
		{
			get
			{
				return (EInteractPlayerDiractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002253 RID: 8787
		private IInteractPlayerDiractionToNpc Instance;
	}
}
