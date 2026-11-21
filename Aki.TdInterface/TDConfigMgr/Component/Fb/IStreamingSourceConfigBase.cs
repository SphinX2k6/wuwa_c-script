using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F31 RID: 3889
	public class IStreamingSourceConfigBase
	{
		// Token: 0x0600575D RID: 22365 RVA: 0x000D6191 File Offset: 0x000D4391
		public static IStreamingSourceConfigBase Create(IStreamingSourceConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingSourceConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x0600575E RID: 22366 RVA: 0x000D61B0 File Offset: 0x000D43B0
		public virtual EStreamingSourceMode Type
		{
			get
			{
				return (EStreamingSourceMode)this.Instance.Type;
			}
		}

		// Token: 0x04003228 RID: 12840
		private IStreamingSourceConfigBase Instance;
	}
}
