using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C3A RID: 3130
	public class IPointGroupGenerateType
	{
		// Token: 0x060047A9 RID: 18345 RVA: 0x000B46E1 File Offset: 0x000B28E1
		[NullableContext(1)]
		public static IPointGroupGenerateType Create(IPointGroupGenerateType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointGroupGenerateType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x060047AA RID: 18346 RVA: 0x000B4700 File Offset: 0x000B2900
		public virtual EPointGroupGenerateType Type
		{
			get
			{
				return (EPointGroupGenerateType)this.Instance.Type;
			}
		}

		// Token: 0x040028C1 RID: 10433
		private IPointGroupGenerateType Instance;
	}
}
