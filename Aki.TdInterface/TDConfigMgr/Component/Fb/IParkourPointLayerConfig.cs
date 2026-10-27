using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C3B RID: 3131
	public class IParkourPointLayerConfig
	{
		// Token: 0x060047AC RID: 18348 RVA: 0x000B4715 File Offset: 0x000B2915
		[NullableContext(1)]
		public static IParkourPointLayerConfig Create(IParkourPointLayerConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IParkourPointLayerConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x060047AD RID: 18349 RVA: 0x000B4734 File Offset: 0x000B2934
		public virtual int Width
		{
			get
			{
				return this.Instance.Width;
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x060047AE RID: 18350 RVA: 0x000B4741 File Offset: 0x000B2941
		public virtual int Length
		{
			get
			{
				return this.Instance.Length;
			}
		}

		// Token: 0x040028C2 RID: 10434
		private IParkourPointLayerConfig Instance;
	}
}
