using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D75 RID: 3445
	public class IActivateSpecifiedPiece : IJigsawCompleteCondition
	{
		// Token: 0x06004E4A RID: 20042 RVA: 0x000C30FE File Offset: 0x000C12FE
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

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06004E4B RID: 20043 RVA: 0x000C311D File Offset: 0x000C131D
		public override EJigsawCompleteCondition Type
		{
			get
			{
				return (EJigsawCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06004E4C RID: 20044 RVA: 0x000C312C File Offset: 0x000C132C
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

		// Token: 0x04002C78 RID: 11384
		private IActivateSpecifiedPiece Instance;

		// Token: 0x04002C79 RID: 11385
		private List<IActivateSpecifiedPieceConfig> _ConfigCache;

		// Token: 0x04002C7A RID: 11386
		private bool _ConfigInited;
	}
}
