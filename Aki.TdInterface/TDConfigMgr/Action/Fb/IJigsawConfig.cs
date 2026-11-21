using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C52 RID: 11346
	public class IJigsawConfig
	{
		// Token: 0x0600F97D RID: 63869 RVA: 0x00243BF9 File Offset: 0x00241DF9
		public static IJigsawConfig Create(IJigsawConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D87 RID: 19847
		// (get) Token: 0x0600F97E RID: 63870 RVA: 0x00243C18 File Offset: 0x00241E18
		public virtual int Row
		{
			get
			{
				return this.Instance.Row;
			}
		}

		// Token: 0x17004D88 RID: 19848
		// (get) Token: 0x0600F97F RID: 63871 RVA: 0x00243C25 File Offset: 0x00241E25
		public virtual int Column
		{
			get
			{
				return this.Instance.Column;
			}
		}

		// Token: 0x17004D89 RID: 19849
		// (get) Token: 0x0600F980 RID: 63872 RVA: 0x00243C32 File Offset: 0x00241E32
		public virtual int Size
		{
			get
			{
				return this.Instance.Size;
			}
		}

		// Token: 0x17004D8A RID: 19850
		// (get) Token: 0x0600F981 RID: 63873 RVA: 0x00243C40 File Offset: 0x00241E40
		public virtual EJigsawShape? Shape
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EJigsawShape?((EJigsawShape)this.Instance.Shape);
			}
		}

		// Token: 0x17004D8B RID: 19851
		// (get) Token: 0x0600F982 RID: 63874 RVA: 0x00243C78 File Offset: 0x00241E78
		public virtual List<IJigsawPiece> Pieces
		{
			get
			{
				if (this._PiecesInited)
				{
					return this._PiecesCache;
				}
				this._PiecesInited = true;
				int piecesLength = this.Instance.PiecesLength;
				this._PiecesCache = new List<IJigsawPiece>(piecesLength);
				for (int i = 0; i < piecesLength; i++)
				{
					this._PiecesCache.Add(IJigsawPiece.Create(this.Instance.Pieces(i)));
				}
				return this._PiecesCache;
			}
		}

		// Token: 0x0400885C RID: 34908
		private IJigsawConfig Instance;

		// Token: 0x0400885D RID: 34909
		private List<IJigsawPiece> _PiecesCache;

		// Token: 0x0400885E RID: 34910
		private bool _PiecesInited;
	}
}
