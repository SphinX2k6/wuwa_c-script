using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B34 RID: 11060
	public class ILifePointColorBoard
	{
		// Token: 0x0600F33E RID: 62270 RVA: 0x0023817A File Offset: 0x0023637A
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

		// Token: 0x17004984 RID: 18820
		// (get) Token: 0x0600F33F RID: 62271 RVA: 0x0023819C File Offset: 0x0023639C
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

		// Token: 0x17004985 RID: 18821
		// (get) Token: 0x0600F340 RID: 62272 RVA: 0x00238208 File Offset: 0x00236408
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

		// Token: 0x17004986 RID: 18822
		// (get) Token: 0x0600F341 RID: 62273 RVA: 0x0023826C File Offset: 0x0023646C
		public virtual EPieceColorType TargetColor
		{
			get
			{
				return (EPieceColorType)this.Instance.TargetColor;
			}
		}

		// Token: 0x04008578 RID: 34168
		private ILifePointColorBoard Instance;

		// Token: 0x04008579 RID: 34169
		private List<IColorPiece> _ConfigCache;

		// Token: 0x0400857A RID: 34170
		private bool _ConfigInited;

		// Token: 0x0400857B RID: 34171
		private List<EPieceColorType> _ColorsCache;

		// Token: 0x0400857C RID: 34172
		private bool _ColorsInited;
	}
}
