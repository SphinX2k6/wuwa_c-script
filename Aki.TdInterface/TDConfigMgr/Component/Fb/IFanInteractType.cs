using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CCC RID: 3276
	public class IFanInteractType
	{
		// Token: 0x06004AE9 RID: 19177 RVA: 0x000BB6D3 File Offset: 0x000B98D3
		[NullableContext(1)]
		public static IFanInteractType Create(IFanInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06004AEA RID: 19178 RVA: 0x000BB6F2 File Offset: 0x000B98F2
		public virtual EFanInteractType Type
		{
			get
			{
				return (EFanInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002AE1 RID: 10977
		private IFanInteractType Instance;
	}
}
