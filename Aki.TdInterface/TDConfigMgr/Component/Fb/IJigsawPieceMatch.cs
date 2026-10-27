using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8C RID: 3212
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawPieceMatch
	{
		// Token: 0x0600497E RID: 18814 RVA: 0x000B82CD File Offset: 0x000B64CD
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

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x000B82EC File Offset: 0x000B64EC
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06004980 RID: 18816 RVA: 0x000B82F9 File Offset: 0x000B64F9
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

		// Token: 0x040029E9 RID: 10729
		private IJigsawPieceMatch Instance;

		// Token: 0x040029EA RID: 10730
		[Nullable(2)]
		private IPieceIndex _IndexCache;

		// Token: 0x040029EB RID: 10731
		private bool _IndexInited;
	}
}
