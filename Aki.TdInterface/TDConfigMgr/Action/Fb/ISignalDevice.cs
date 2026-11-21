using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B2F RID: 11055
	public class ISignalDevice : IUiGame
	{
		// Token: 0x0600F32A RID: 62250 RVA: 0x00237F58 File Offset: 0x00236158
		public static ISignalDevice Create(ISignalDevice? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISignalDevice
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700497A RID: 18810
		// (get) Token: 0x0600F32B RID: 62251 RVA: 0x00237F77 File Offset: 0x00236177
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700497B RID: 18811
		// (get) Token: 0x0600F32C RID: 62252 RVA: 0x00237F84 File Offset: 0x00236184
		public virtual List<IColorPiece> Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				int configLength = this.Instance.ConfigLength;
				this._ConfigCache = new List<IColorPiece>(configLength);
				for (int i = 0; i < configLength; i++)
				{
					this._ConfigCache.Add(IColorPiece.Create(this.Instance.Config(i)));
				}
				return this._ConfigCache;
			}
		}

		// Token: 0x0400856D RID: 34157
		private ISignalDevice Instance;

		// Token: 0x0400856E RID: 34158
		private List<IColorPiece> _ConfigCache;

		// Token: 0x0400856F RID: 34159
		private bool _ConfigInited;
	}
}
