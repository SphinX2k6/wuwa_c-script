using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002861 RID: 10337
	[NullableContext(1)]
	[Nullable(0)]
	public class ILifePointColorBoard
	{
		// Token: 0x0600E519 RID: 58649 RVA: 0x0021B316 File Offset: 0x00219516
		public static ILifePointColorBoard Create(ILifePointColorBoard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILifePointColorBoard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004619 RID: 17945
		// (get) Token: 0x0600E51A RID: 58650 RVA: 0x0021B338 File Offset: 0x00219538
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

		// Token: 0x1700461A RID: 17946
		// (get) Token: 0x0600E51B RID: 58651 RVA: 0x0021B3A4 File Offset: 0x002195A4
		public virtual List<EPieceColorType> Colors
		{
			get
			{
				if (this._ColorsInited)
				{
					return this._ColorsCache;
				}
				this._ColorsInited = true;
				int colorsLength = this.Instance.ColorsLength;
				this._ColorsCache = new List<EPieceColorType>(colorsLength);
				for (int i = 0; i < colorsLength; i++)
				{
					this._ColorsCache.Add((EPieceColorType)this.Instance.Colors(i));
				}
				return this._ColorsCache;
			}
		}

		// Token: 0x1700461B RID: 17947
		// (get) Token: 0x0600E51C RID: 58652 RVA: 0x0021B408 File Offset: 0x00219608
		public virtual EPieceColorType TargetColor
		{
			get
			{
				return (EPieceColorType)this.Instance.TargetColor;
			}
		}

		// Token: 0x04007EBB RID: 32443
		private ILifePointColorBoard Instance;

		// Token: 0x04007EBC RID: 32444
		private List<IColorPiece> _ConfigCache;

		// Token: 0x04007EBD RID: 32445
		private bool _ConfigInited;

		// Token: 0x04007EBE RID: 32446
		private List<EPieceColorType> _ColorsCache;

		// Token: 0x04007EBF RID: 32447
		private bool _ColorsInited;
	}
}
