using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D0E RID: 3342
	public class IParkourPointLayerConfig
	{
		// Token: 0x06004C1C RID: 19484 RVA: 0x000BEAC5 File Offset: 0x000BCCC5
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

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06004C1D RID: 19485 RVA: 0x000BEAE4 File Offset: 0x000BCCE4
		public virtual int Width
		{
			get
			{
				return this.Instance.Width;
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06004C1E RID: 19486 RVA: 0x000BEAF1 File Offset: 0x000BCCF1
		public virtual int Length
		{
			get
			{
				return this.Instance.Length;
			}
		}

		// Token: 0x04002B17 RID: 11031
		private IParkourPointLayerConfig Instance;
	}
}
