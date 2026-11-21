using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8E RID: 2958
	public struct AbyssSettle : IFlatbufferObject
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06004702 RID: 18178 RVA: 0x001E8130 File Offset: 0x001E6330
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x001E813D File Offset: 0x001E633D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x001E8144 File Offset: 0x001E6344
		public static AbyssSettle GetRootAsAbyssSettle(ByteBuffer _bb)
		{
			return AbyssSettle.GetRootAsAbyssSettle(_bb, default(AbyssSettle));
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x001E8160 File Offset: 0x001E6360
		public static AbyssSettle GetRootAsAbyssSettle(ByteBuffer _bb, AbyssSettle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x001E817D File Offset: 0x001E637D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x001E818C File Offset: 0x001E638C
		public AbyssSettle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x001E819C File Offset: 0x001E639C
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

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06004709 RID: 18185 RVA: 0x001E81D8 File Offset: 0x001E63D8
		public string BattleScoreName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x001E820F File Offset: 0x001E640F
		public Span<byte> GetBattleScoreNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x001E821E File Offset: 0x001E641E
		public byte[] GetBattleScoreNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600470C RID: 18188 RVA: 0x001E8238 File Offset: 0x001E6438
		public bool IsTotalRatio
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600470D RID: 18189 RVA: 0x001E8278 File Offset: 0x001E6478
		public string BaseTitle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x001E82B0 File Offset: 0x001E64B0
		public Span<byte> GetBaseTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x001E82C0 File Offset: 0x001E64C0
		public byte[] GetBaseTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x001E82D8 File Offset: 0x001E64D8
		public DicIntString? Title(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06004711 RID: 18193 RVA: 0x001E833C File Offset: 0x001E653C
		public int TitleLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x001E8368 File Offset: 0x001E6568
		[NullableContext(1)]
		public Dictionary<int, string> Title()
		{
			return this.TitleIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x001E83BE File Offset: 0x001E65BE
		[NullableContext(1)]
		public IEnumerable<DicIntString> TitleIter()
		{
			AbyssSettle.<TitleIter>d__24 <TitleIter>d__ = new AbyssSettle.<TitleIter>d__24(-2);
			<TitleIter>d__.<>3__<>4__this = this;
			return <TitleIter>d__;
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x001E83D4 File Offset: 0x001E65D4
		[NullableContext(2)]
		public string GetTitle(int key)
		{
			this.EnsureTitleCacheIfNeeded();
			string result;
			if (!this.TitleCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x001E83FC File Offset: 0x001E65FC
		private void EnsureTitleCacheIfNeeded()
		{
			if (this.TitleCache != null)
			{
				return;
			}
			this.TitleCache = this.TitleIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x001E8462 File Offset: 0x001E6662
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetTitleFrozenDict()
		{
			this.EnsureTitleCacheIfNeeded();
			return this.TitleCache;
		}

		// Token: 0x04005063 RID: 20579
		private Table __p;

		// Token: 0x04005064 RID: 20580
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TitleCache;
	}
}
