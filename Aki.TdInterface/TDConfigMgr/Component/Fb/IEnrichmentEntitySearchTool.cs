using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E4C RID: 3660
	public class IEnrichmentEntitySearchTool
	{
		// Token: 0x060052D3 RID: 21203 RVA: 0x000CCAA7 File Offset: 0x000CACA7
		public static IEnrichmentEntitySearchTool Create(IEnrichmentEntitySearchTool? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnrichmentEntitySearchTool
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x060052D4 RID: 21204 RVA: 0x000CCAC6 File Offset: 0x000CACC6
		public virtual int TargetType
		{
			get
			{
				return this.Instance.TargetType;
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x060052D5 RID: 21205 RVA: 0x000CCAD3 File Offset: 0x000CACD3
		public virtual float Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x060052D6 RID: 21206 RVA: 0x000CCAE0 File Offset: 0x000CACE0
		public virtual float Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x04002F4F RID: 12111
		private IEnrichmentEntitySearchTool Instance;
	}
}
