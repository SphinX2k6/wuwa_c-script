using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F37 RID: 3895
	[NullableContext(2)]
	[Nullable(0)]
	public class ElementalWellComponent : IComponentBase
	{
		// Token: 0x06005777 RID: 22391 RVA: 0x000D647F File Offset: 0x000D467F
		[NullableContext(0)]
		public static ElementalWellComponent Create(IElementalWellComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ElementalWellComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x000D64A0 File Offset: 0x000D46A0
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

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06005779 RID: 22393 RVA: 0x000D64D8 File Offset: 0x000D46D8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x0600577A RID: 22394 RVA: 0x000D64EE File Offset: 0x000D46EE
		public virtual EElementalWellEntryType WellType
		{
			get
			{
				return (EElementalWellEntryType)this.Instance.WellType;
			}
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x0600577B RID: 22395 RVA: 0x000D64FB File Offset: 0x000D46FB
		[Nullable(0)]
		public virtual IWellStreamingRenderConfig StreamingRenderConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._StreamingRenderConfigInited)
				{
					return this._StreamingRenderConfigCache;
				}
				this._StreamingRenderConfigInited = true;
				this._StreamingRenderConfigCache = IWellStreamingRenderConfig.Create(this.Instance.StreamingRenderConfig);
				return this._StreamingRenderConfigCache;
			}
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x0600577C RID: 22396 RVA: 0x000D652F File Offset: 0x000D472F
		[Nullable(0)]
		public virtual IStreamingWaitConfig StreamWaitConfig
		{
			[NullableContext(0)]
			get
			{
				if (this._StreamWaitConfigInited)
				{
					return this._StreamWaitConfigCache;
				}
				this._StreamWaitConfigInited = true;
				this._StreamWaitConfigCache = IStreamingWaitConfig.Create(this.Instance.StreamWaitConfig);
				return this._StreamWaitConfigCache;
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x0600577D RID: 22397 RVA: 0x000D6563 File Offset: 0x000D4763
		public virtual string StreamingFinishedToState
		{
			get
			{
				return this.Instance.StreamingFinishedToState;
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x0600577E RID: 22398 RVA: 0x000D6570 File Offset: 0x000D4770
		public virtual string LeaveRangeToState
		{
			get
			{
				return this.Instance.LeaveRangeToState;
			}
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x0600577F RID: 22399 RVA: 0x000D657D File Offset: 0x000D477D
		public virtual string PrefabBindPointKey
		{
			get
			{
				return this.Instance.PrefabBindPointKey;
			}
		}

		// Token: 0x0400323A RID: 12858
		private IElementalWellComponent Instance;

		// Token: 0x0400323B RID: 12859
		private IWellStreamingRenderConfig _StreamingRenderConfigCache;

		// Token: 0x0400323C RID: 12860
		private bool _StreamingRenderConfigInited;

		// Token: 0x0400323D RID: 12861
		private IStreamingWaitConfig _StreamWaitConfigCache;

		// Token: 0x0400323E RID: 12862
		private bool _StreamWaitConfigInited;
	}
}
