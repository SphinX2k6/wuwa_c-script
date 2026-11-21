using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D6E RID: 3438
	public class IJigsawPieceMatch
	{
		// Token: 0x06004E2C RID: 20012 RVA: 0x000C2CDD File Offset: 0x000C0EDD
		public static IJigsawPieceMatch Create(IJigsawPieceMatch? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawPieceMatch
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06004E2D RID: 20013 RVA: 0x000C2CFC File Offset: 0x000C0EFC
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06004E2E RID: 20014 RVA: 0x000C2D09 File Offset: 0x000C0F09
		public virtual IPieceIndex Index
		{
			get
			{
				if (this._IndexInited)
				{
					return this._IndexCache;
				}
				this._IndexInited = true;
				this._IndexCache = IPieceIndex.Create(this.Instance.Index);
				return this._IndexCache;
			}
		}

		// Token: 0x04002C63 RID: 11363
		private IJigsawPieceMatch Instance;

		// Token: 0x04002C64 RID: 11364
		[Nullable(2)]
		private IPieceIndex _IndexCache;

		// Token: 0x04002C65 RID: 11365
		private bool _IndexInited;
	}
}
