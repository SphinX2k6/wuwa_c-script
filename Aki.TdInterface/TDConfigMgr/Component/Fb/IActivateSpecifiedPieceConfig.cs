using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C92 RID: 3218
	[NullableContext(1)]
	[Nullable(0)]
	public class IActivateSpecifiedPieceConfig
	{
		// Token: 0x06004998 RID: 18840 RVA: 0x000B8686 File Offset: 0x000B6886
		public static IActivateSpecifiedPieceConfig Create(IActivateSpecifiedPieceConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActivateSpecifiedPieceConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06004999 RID: 18841 RVA: 0x000B86A5 File Offset: 0x000B68A5
		public virtual IJigsawConfig Jigsaw
		{
			get
			{
				if (this._JigsawInited)
				{
					return this._JigsawCache;
				}
				this._JigsawInited = true;
				this._JigsawCache = IJigsawConfig.Create(this.Instance.Jigsaw);
				return this._JigsawCache;
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x0600499A RID: 18842 RVA: 0x000B86D9 File Offset: 0x000B68D9
		public virtual string SelfState
		{
			get
			{
				return this.Instance.SelfState;
			}
		}

		// Token: 0x040029FB RID: 10747
		private IActivateSpecifiedPieceConfig Instance;

		// Token: 0x040029FC RID: 10748
		[Nullable(2)]
		private IJigsawConfig _JigsawCache;

		// Token: 0x040029FD RID: 10749
		private bool _JigsawInited;
	}
}
