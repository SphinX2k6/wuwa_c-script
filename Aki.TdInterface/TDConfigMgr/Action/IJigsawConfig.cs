using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D13 RID: 7443
	public class IJigsawConfig
	{
		// Token: 0x06009E15 RID: 40469 RVA: 0x0016BC7C File Offset: 0x00169E7C
		private IJigsawConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IJigsawConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IJigsawConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IJigsawConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009E16 RID: 40470 RVA: 0x0016BCB4 File Offset: 0x00169EB4
		public static IJigsawConfig Create([Nullable(2)] IJigsawConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E17 RID: 40471 RVA: 0x0016BCC7 File Offset: 0x00169EC7
		public static IJigsawConfig CreateFromSetValue([Nullable(2)] IJigsawConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IJigsawConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E18 RID: 40472 RVA: 0x0016BCDC File Offset: 0x00169EDC
		public IJigsawConfig_SetValue ToSetValue()
		{
			return new IJigsawConfig_SetValue
			{
				Row = this.Row,
				Column = this.Column,
				Size = this.Size,
				Shape = this.Shape,
				Pieces = this.Pieces
			};
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x06009E19 RID: 40473 RVA: 0x0016BD2A File Offset: 0x00169F2A
		// (set) Token: 0x06009E1A RID: 40474 RVA: 0x0016BD55 File Offset: 0x00169F55
		public virtual int Row
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Row;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Row;
			}
			set
			{
				this.GetOrCreatePoco().Row = value;
			}
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x06009E1B RID: 40475 RVA: 0x0016BD63 File Offset: 0x00169F63
		// (set) Token: 0x06009E1C RID: 40476 RVA: 0x0016BD8E File Offset: 0x00169F8E
		public virtual int Column
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Column;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Column;
			}
			set
			{
				this.GetOrCreatePoco().Column = value;
			}
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x06009E1D RID: 40477 RVA: 0x0016BD9C File Offset: 0x00169F9C
		// (set) Token: 0x06009E1E RID: 40478 RVA: 0x0016BDC7 File Offset: 0x00169FC7
		public virtual int Size
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Size;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Size;
			}
			set
			{
				this.GetOrCreatePoco().Size = value;
			}
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x06009E1F RID: 40479 RVA: 0x0016BDD8 File Offset: 0x00169FD8
		// (set) Token: 0x06009E20 RID: 40480 RVA: 0x0016BE12 File Offset: 0x0016A012
		public virtual EJigsawShape? Shape
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Shape;
				}
				IJigsawConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Shape;
			}
			set
			{
				this.GetOrCreatePoco().Shape = value;
			}
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x06009E21 RID: 40481 RVA: 0x0016BE20 File Offset: 0x0016A020
		// (set) Token: 0x06009E22 RID: 40482 RVA: 0x0016BEB3 File Offset: 0x0016A0B3
		public virtual List<IJigsawPiece> Pieces
		{
			get
			{
				if (this._PiecesInited)
				{
					return this._PiecesCache;
				}
				this._PiecesInited = true;
				if (this.FbInstance != null)
				{
					List<IJigsawPiece> pieces = this.FbInstance.Pieces;
					if (pieces != null)
					{
						this._PiecesCache = new List<IJigsawPiece>(pieces.Count);
						for (int i = 0; i < pieces.Count; i++)
						{
							this._PiecesCache.Add(IJigsawPiece.Create(pieces[i]));
						}
					}
				}
				else
				{
					IJigsawConfig_SetValue pocoInterface = this.PocoInterface;
					this._PiecesCache = ((pocoInterface != null) ? pocoInterface.Pieces : null);
				}
				return this._PiecesCache;
			}
			set
			{
				this.GetOrCreatePoco().Pieces = value;
				this._PiecesInited = false;
			}
		}

		// Token: 0x04006077 RID: 24695
		[Nullable(2)]
		protected IJigsawConfig FbInstance;

		// Token: 0x04006078 RID: 24696
		[Nullable(2)]
		protected IJigsawConfig_SetValue PocoInterface;

		// Token: 0x04006079 RID: 24697
		private List<IJigsawPiece> _PiecesCache;

		// Token: 0x0400607A RID: 24698
		private bool _PiecesInited;
	}
}
