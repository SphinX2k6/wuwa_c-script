using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296D RID: 10605
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawConfig
	{
		// Token: 0x0600EB07 RID: 60167 RVA: 0x00226541 File Offset: 0x00224741
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

		// Token: 0x170049EF RID: 18927
		// (get) Token: 0x0600EB08 RID: 60168 RVA: 0x00226560 File Offset: 0x00224760
		public virtual int Row
		{
			get
			{
				return this.Instance.Row;
			}
		}

		// Token: 0x170049F0 RID: 18928
		// (get) Token: 0x0600EB09 RID: 60169 RVA: 0x0022656D File Offset: 0x0022476D
		public virtual int Column
		{
			get
			{
				return this.Instance.Column;
			}
		}

		// Token: 0x170049F1 RID: 18929
		// (get) Token: 0x0600EB0A RID: 60170 RVA: 0x0022657A File Offset: 0x0022477A
		public virtual int Size
		{
			get
			{
				return this.Instance.Size;
			}
		}

		// Token: 0x170049F2 RID: 18930
		// (get) Token: 0x0600EB0B RID: 60171 RVA: 0x00226588 File Offset: 0x00224788
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

		// Token: 0x170049F3 RID: 18931
		// (get) Token: 0x0600EB0C RID: 60172 RVA: 0x002265C0 File Offset: 0x002247C0
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

		// Token: 0x0400817B RID: 33147
		private IJigsawConfig Instance;

		// Token: 0x0400817C RID: 33148
		private List<IJigsawPiece> _PiecesCache;

		// Token: 0x0400817D RID: 33149
		private bool _PiecesInited;
	}
}
