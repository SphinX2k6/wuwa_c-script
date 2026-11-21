using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F38 RID: 3896
	public class StreamingSourceTriggerPointComponent : IComponentBase
	{
		// Token: 0x06005781 RID: 22401 RVA: 0x000D6592 File Offset: 0x000D4792
		public static StreamingSourceTriggerPointComponent Create(IStreamingSourceTriggerPointComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StreamingSourceTriggerPointComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x06005782 RID: 22402 RVA: 0x000D65B4 File Offset: 0x000D47B4
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06005783 RID: 22403 RVA: 0x000D65EC File Offset: 0x000D47EC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06005784 RID: 22404 RVA: 0x000D6604 File Offset: 0x000D4804
		public virtual int? Radius
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Radius);
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06005785 RID: 22405 RVA: 0x000D663A File Offset: 0x000D483A
		public virtual IStreamingSourceConfigBase StreamingSource
		{
			get
			{
				if (this._StreamingSourceInited)
				{
					return this._StreamingSourceCache;
				}
				this._StreamingSourceInited = true;
				this._StreamingSourceCache = ComponentReadHelper.ReadStreamingSourceTriggerPointComponent_StreamingSource(this.Instance);
				return this._StreamingSourceCache;
			}
		}

		// Token: 0x0400323F RID: 12863
		private IStreamingSourceTriggerPointComponent Instance;

		// Token: 0x04003240 RID: 12864
		private IStreamingSourceConfigBase _StreamingSourceCache;

		// Token: 0x04003241 RID: 12865
		private bool _StreamingSourceInited;
	}
}
