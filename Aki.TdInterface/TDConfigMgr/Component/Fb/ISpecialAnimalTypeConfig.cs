using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF6 RID: 3318
	public class ISpecialAnimalTypeConfig
	{
		// Token: 0x06004BA0 RID: 19360 RVA: 0x000BD83E File Offset: 0x000BBA3E
		public static ISpecialAnimalTypeConfig Create(ISpecialAnimalTypeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialAnimalTypeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x000BD85D File Offset: 0x000BBA5D
		public virtual ESpecialAnimalType Type
		{
			get
			{
				return (ESpecialAnimalType)this.Instance.Type;
			}
		}

		// Token: 0x04002ABF RID: 10943
		private ISpecialAnimalTypeConfig Instance;
	}
}
