using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F32 RID: 3890
	public class IFixedStreamingSource : IStreamingSourceConfigBase
	{
		// Token: 0x06005760 RID: 22368 RVA: 0x000D61C5 File Offset: 0x000D43C5
		public static IFixedStreamingSource Create(IFixedStreamingSource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedStreamingSource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x06005761 RID: 22369 RVA: 0x000D61E4 File Offset: 0x000D43E4
		public override EStreamingSourceMode Type
		{
			get
			{
				return (EStreamingSourceMode)this.Instance.Type;
			}
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06005762 RID: 22370 RVA: 0x000D61F1 File Offset: 0x000D43F1
		public virtual IStreamingSourceConfig StreamingSourceConfig
		{
			get
			{
				if (this._StreamingSourceConfigInited)
				{
					return this._StreamingSourceConfigCache;
				}
				this._StreamingSourceConfigInited = true;
				this._StreamingSourceConfigCache = IStreamingSourceConfig.Create(this.Instance.StreamingSourceConfig);
				return this._StreamingSourceConfigCache;
			}
		}

		// Token: 0x04003229 RID: 12841
		private IFixedStreamingSource Instance;

		// Token: 0x0400322A RID: 12842
		[Nullable(2)]
		private IStreamingSourceConfig _StreamingSourceConfigCache;

		// Token: 0x0400322B RID: 12843
		private bool _StreamingSourceConfigInited;
	}
}
