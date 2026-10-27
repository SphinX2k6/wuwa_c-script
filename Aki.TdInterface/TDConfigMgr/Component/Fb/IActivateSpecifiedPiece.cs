using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C93 RID: 3219
	[NullableContext(1)]
	[Nullable(0)]
	public class IActivateSpecifiedPiece : IJigsawCompleteCondition
	{
		// Token: 0x0600499C RID: 18844 RVA: 0x000B86EE File Offset: 0x000B68EE
		public static IActivateSpecifiedPiece Create(IActivateSpecifiedPiece? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActivateSpecifiedPiece
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x0600499D RID: 18845 RVA: 0x000B870D File Offset: 0x000B690D
		public override EJigsawCompleteCondition Type
		{
			get
			{
				return (EJigsawCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x0600499E RID: 18846 RVA: 0x000B871C File Offset: 0x000B691C
		public virtual List<IActivateSpecifiedPieceConfig> Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				int configLength = this.Instance.ConfigLength;
				this._ConfigCache = new List<IActivateSpecifiedPieceConfig>(configLength);
				for (int i = 0; i < configLength; i++)
				{
					this._ConfigCache.Add(IActivateSpecifiedPieceConfig.Create(this.Instance.Config(i)));
				}
				return this._ConfigCache;
			}
		}

		// Token: 0x040029FE RID: 10750
		private IActivateSpecifiedPiece Instance;

		// Token: 0x040029FF RID: 10751
		private List<IActivateSpecifiedPieceConfig> _ConfigCache;

		// Token: 0x04002A00 RID: 10752
		private bool _ConfigInited;
	}
}
