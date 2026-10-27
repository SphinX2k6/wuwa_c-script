using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E3C RID: 3644
	[NullableContext(1)]
	[Nullable(0)]
	public class StreamingSourceTriggerPointComponent : IComponentBase
	{
		// Token: 0x0600525A RID: 21082 RVA: 0x000CACCA File Offset: 0x000C8ECA
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

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x0600525B RID: 21083 RVA: 0x000CACEC File Offset: 0x000C8EEC
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

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x0600525C RID: 21084 RVA: 0x000CAD24 File Offset: 0x000C8F24
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x0600525D RID: 21085 RVA: 0x000CAD3C File Offset: 0x000C8F3C
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

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x0600525E RID: 21086 RVA: 0x000CAD72 File Offset: 0x000C8F72
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

		// Token: 0x04002F77 RID: 12151
		private IStreamingSourceTriggerPointComponent Instance;

		// Token: 0x04002F78 RID: 12152
		private IStreamingSourceConfigBase _StreamingSourceCache;

		// Token: 0x04002F79 RID: 12153
		private bool _StreamingSourceInited;
	}
}
