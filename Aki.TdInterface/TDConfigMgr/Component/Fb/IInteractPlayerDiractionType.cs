using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A71 RID: 2673
	public class IInteractPlayerDiractionType
	{
		// Token: 0x06003D9D RID: 15773 RVA: 0x0009E1C1 File Offset: 0x0009C3C1
		[NullableContext(1)]
		public static IInteractPlayerDiractionType Create(IInteractPlayerDiractionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06003D9E RID: 15774 RVA: 0x0009E1E0 File Offset: 0x0009C3E0
		public virtual EInteractPlayerDiractionType Type
		{
			get
			{
				return (EInteractPlayerDiractionType)this.Instance.Type;
			}
		}

		// Token: 0x04002252 RID: 8786
		private IInteractPlayerDiractionType Instance;
	}
}
