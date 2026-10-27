using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE4 RID: 3556
	public class IProceduralMaterialType
	{
		// Token: 0x0600509E RID: 20638 RVA: 0x000C70D3 File Offset: 0x000C52D3
		[NullableContext(1)]
		public static IProceduralMaterialType Create(IProceduralMaterialType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProceduralMaterialType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x0600509F RID: 20639 RVA: 0x000C70F2 File Offset: 0x000C52F2
		public virtual EProceduralMaterialType Type
		{
			get
			{
				return (EProceduralMaterialType)this.Instance.Type;
			}
		}

		// Token: 0x04002E4B RID: 11851
		private IProceduralMaterialType Instance;
	}
}
