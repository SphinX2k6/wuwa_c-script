using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B66 RID: 7014
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawConfig
	{
		// Token: 0x06009633 RID: 38451 RVA: 0x0015B0D0 File Offset: 0x001592D0
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

		// Token: 0x06009634 RID: 38452 RVA: 0x0015B108 File Offset: 0x00159308
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

		// Token: 0x06009635 RID: 38453 RVA: 0x0015B11B File Offset: 0x0015931B
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

		// Token: 0x06009636 RID: 38454 RVA: 0x0015B130 File Offset: 0x00159330
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

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x06009637 RID: 38455 RVA: 0x0015B17E File Offset: 0x0015937E
		// (set) Token: 0x06009638 RID: 38456 RVA: 0x0015B1A9 File Offset: 0x001593A9
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

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x06009639 RID: 38457 RVA: 0x0015B1B7 File Offset: 0x001593B7
		// (set) Token: 0x0600963A RID: 38458 RVA: 0x0015B1E2 File Offset: 0x001593E2
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

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x0600963B RID: 38459 RVA: 0x0015B1F0 File Offset: 0x001593F0
		// (set) Token: 0x0600963C RID: 38460 RVA: 0x0015B21B File Offset: 0x0015941B
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

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x0600963D RID: 38461 RVA: 0x0015B22C File Offset: 0x0015942C
		// (set) Token: 0x0600963E RID: 38462 RVA: 0x0015B266 File Offset: 0x00159466
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

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x0600963F RID: 38463 RVA: 0x0015B274 File Offset: 0x00159474
		// (set) Token: 0x06009640 RID: 38464 RVA: 0x0015B307 File Offset: 0x00159507
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

		// Token: 0x04005BDE RID: 23518
		[Nullable(2)]
		protected IJigsawConfig FbInstance;

		// Token: 0x04005BDF RID: 23519
		[Nullable(2)]
		protected IJigsawConfig_SetValue PocoInterface;

		// Token: 0x04005BE0 RID: 23520
		private List<IJigsawPiece> _PiecesCache;

		// Token: 0x04005BE1 RID: 23521
		private bool _PiecesInited;
	}
}
