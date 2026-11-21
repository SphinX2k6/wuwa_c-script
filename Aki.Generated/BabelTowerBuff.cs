using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFC RID: 3068
	public struct BabelTowerBuff : IFlatbufferObject
	{
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600503E RID: 20542 RVA: 0x001FC954 File Offset: 0x001FAB54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x001FC961 File Offset: 0x001FAB61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x001FC968 File Offset: 0x001FAB68
		public static BabelTowerBuff GetRootAsBabelTowerBuff(ByteBuffer _bb)
		{
			return BabelTowerBuff.GetRootAsBabelTowerBuff(_bb, default(BabelTowerBuff));
		}

		// Token: 0x06005041 RID: 20545 RVA: 0x001FC984 File Offset: 0x001FAB84
		public static BabelTowerBuff GetRootAsBabelTowerBuff(ByteBuffer _bb, BabelTowerBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x001FC9A1 File Offset: 0x001FABA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x001FC9B0 File Offset: 0x001FABB0
		public BabelTowerBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06005044 RID: 20548 RVA: 0x001FC9C0 File Offset: 0x001FABC0
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

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06005045 RID: 20549 RVA: 0x001FC9FC File Offset: 0x001FABFC
		public int Star
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

		// Token: 0x06005046 RID: 20550 RVA: 0x001FCA38 File Offset: 0x001FAC38
		public int DifficultPreLevel(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06005047 RID: 20551 RVA: 0x001FCA78 File Offset: 0x001FAC78
		public int DifficultPreLevelLength
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

		// Token: 0x06005048 RID: 20552 RVA: 0x001FCAA3 File Offset: 0x001FACA3
		public Span<int> GetDifficultPreLevelBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x001FCAB2 File Offset: 0x001FACB2
		public int[] GetDifficultPreLevelArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x001FCACC File Offset: 0x001FACCC
		public DicIntInt? DifficultPreLevelStar(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x0600504B RID: 20555 RVA: 0x001FCB30 File Offset: 0x001FAD30
		public int DifficultPreLevelStarLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x0600504C RID: 20556 RVA: 0x001FCB5C File Offset: 0x001FAD5C
		public int DifficultLimitTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600504D RID: 20557 RVA: 0x001FCB9C File Offset: 0x001FAD9C
		public string Texture
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x001FCBD4 File Offset: 0x001FADD4
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x001FCBE4 File Offset: 0x001FADE4
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06005050 RID: 20560 RVA: 0x001FCBFC File Offset: 0x001FADFC
		public string NameText
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x001FCC34 File Offset: 0x001FAE34
		public Span<byte> GetNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x001FCC44 File Offset: 0x001FAE44
		public byte[] GetNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06005053 RID: 20563 RVA: 0x001FCC5C File Offset: 0x001FAE5C
		public string DesText
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x001FCC94 File Offset: 0x001FAE94
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x001FCCA4 File Offset: 0x001FAEA4
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x001FCCBC File Offset: 0x001FAEBC
		[NullableContext(1)]
		public int[] DifficultPreLevel()
		{
			return this.GetDifficultPreLevelArray();
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x001FCCC4 File Offset: 0x001FAEC4
		[NullableContext(1)]
		public IEnumerable<int> DifficultPreLevelIter()
		{
			BabelTowerBuff.<DifficultPreLevelIter>d__35 <DifficultPreLevelIter>d__ = new BabelTowerBuff.<DifficultPreLevelIter>d__35(-2);
			<DifficultPreLevelIter>d__.<>3__<>4__this = this;
			return <DifficultPreLevelIter>d__;
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x001FCCDC File Offset: 0x001FAEDC
		[NullableContext(1)]
		public Dictionary<int, int> DifficultPreLevelStar()
		{
			return this.DifficultPreLevelStarIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x001FCD32 File Offset: 0x001FAF32
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DifficultPreLevelStarIter()
		{
			BabelTowerBuff.<DifficultPreLevelStarIter>d__37 <DifficultPreLevelStarIter>d__ = new BabelTowerBuff.<DifficultPreLevelStarIter>d__37(-2);
			<DifficultPreLevelStarIter>d__.<>3__<>4__this = this;
			return <DifficultPreLevelStarIter>d__;
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x001FCD48 File Offset: 0x001FAF48
		public int? GetDifficultPreLevelStar(int key)
		{
			this.EnsureDifficultPreLevelStarCacheIfNeeded();
			int value;
			if (!this.DifficultPreLevelStarCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x001FCD7C File Offset: 0x001FAF7C
		private void EnsureDifficultPreLevelStarCacheIfNeeded()
		{
			if (this.DifficultPreLevelStarCache != null)
			{
				return;
			}
			this.DifficultPreLevelStarCache = this.DifficultPreLevelStarIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x001FCDE2 File Offset: 0x001FAFE2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDifficultPreLevelStarFrozenDict()
		{
			this.EnsureDifficultPreLevelStarCacheIfNeeded();
			return this.DifficultPreLevelStarCache;
		}

		// Token: 0x040050EB RID: 20715
		private Table __p;

		// Token: 0x040050EC RID: 20716
		[Nullable(2)]
		private FrozenDictionary<int, int> DifficultPreLevelStarCache;
	}
}
