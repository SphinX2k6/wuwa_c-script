using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C23 RID: 3107
	public class ISpecialAnimalTypeConfig
	{
		// Token: 0x06004731 RID: 18225 RVA: 0x000B3506 File Offset: 0x000B1706
		[NullableContext(1)]
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

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06004732 RID: 18226 RVA: 0x000B3525 File Offset: 0x000B1725
		public virtual ESpecialAnimalType Type
		{
			get
			{
				return (ESpecialAnimalType)this.Instance.Type;
			}
		}

		// Token: 0x0400286C RID: 10348
		private ISpecialAnimalTypeConfig Instance;
	}
}
