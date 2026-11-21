using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8F RID: 2959
	public struct AbyssSynthesis : IFlatbufferObject
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06004717 RID: 18199 RVA: 0x001E8470 File Offset: 0x001E6670
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x001E847D File Offset: 0x001E667D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x001E8484 File Offset: 0x001E6684
		public static AbyssSynthesis GetRootAsAbyssSynthesis(ByteBuffer _bb)
		{
			return AbyssSynthesis.GetRootAsAbyssSynthesis(_bb, default(AbyssSynthesis));
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x001E84A0 File Offset: 0x001E66A0
		public static AbyssSynthesis GetRootAsAbyssSynthesis(ByteBuffer _bb, AbyssSynthesis obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x001E84BD File Offset: 0x001E66BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x001E84CC File Offset: 0x001E66CC
		public AbyssSynthesis __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600471D RID: 18205 RVA: 0x001E84DC File Offset: 0x001E66DC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600471E RID: 18206 RVA: 0x001E8518 File Offset: 0x001E6718
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x001E8554 File Offset: 0x001E6754
		public DicIntInt? DecomposeInfo(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06004720 RID: 18208 RVA: 0x001E85B4 File Offset: 0x001E67B4
		public int DecomposeInfoLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x001E85E0 File Offset: 0x001E67E0
		[NullableContext(1)]
		public Dictionary<int, int> DecomposeInfo()
		{
			return this.DecomposeInfoIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x001E8636 File Offset: 0x001E6836
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DecomposeInfoIter()
		{
			AbyssSynthesis.<DecomposeInfoIter>d__16 <DecomposeInfoIter>d__ = new AbyssSynthesis.<DecomposeInfoIter>d__16(-2);
			<DecomposeInfoIter>d__.<>3__<>4__this = this;
			return <DecomposeInfoIter>d__;
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x001E864C File Offset: 0x001E684C
		public int? GetDecomposeInfo(int key)
		{
			this.EnsureDecomposeInfoCacheIfNeeded();
			int value;
			if (!this.DecomposeInfoCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x001E8680 File Offset: 0x001E6880
		private void EnsureDecomposeInfoCacheIfNeeded()
		{
			if (this.DecomposeInfoCache != null)
			{
				return;
			}
			this.DecomposeInfoCache = this.DecomposeInfoIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x001E86E6 File Offset: 0x001E68E6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDecomposeInfoFrozenDict()
		{
			this.EnsureDecomposeInfoCacheIfNeeded();
			return this.DecomposeInfoCache;
		}

		// Token: 0x04005065 RID: 20581
		private Table __p;

		// Token: 0x04005066 RID: 20582
		[Nullable(2)]
		private FrozenDictionary<int, int> DecomposeInfoCache;
	}
}
