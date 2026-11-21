using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EE0 RID: 3808
	public class IProceduralMaterialType
	{
		// Token: 0x060055C5 RID: 21957 RVA: 0x000D299B File Offset: 0x000D0B9B
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

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x060055C6 RID: 21958 RVA: 0x000D29BA File Offset: 0x000D0BBA
		public virtual EProceduralMaterialType Type
		{
			get
			{
				return (EProceduralMaterialType)this.Instance.Type;
			}
		}

		// Token: 0x04003113 RID: 12563
		private IProceduralMaterialType Instance;
	}
}
