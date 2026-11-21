using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFF RID: 3071
	public struct BabelTowerDeTerm : IFlatbufferObject
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600507F RID: 20607 RVA: 0x001FD238 File Offset: 0x001FB438
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005080 RID: 20608 RVA: 0x001FD245 File Offset: 0x001FB445
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x001FD24C File Offset: 0x001FB44C
		public static BabelTowerDeTerm GetRootAsBabelTowerDeTerm(ByteBuffer _bb)
		{
			return BabelTowerDeTerm.GetRootAsBabelTowerDeTerm(_bb, default(BabelTowerDeTerm));
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x001FD268 File Offset: 0x001FB468
		public static BabelTowerDeTerm GetRootAsBabelTowerDeTerm(ByteBuffer _bb, BabelTowerDeTerm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x001FD285 File Offset: 0x001FB485
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x001FD294 File Offset: 0x001FB494
		public BabelTowerDeTerm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06005085 RID: 20613 RVA: 0x001FD2A4 File Offset: 0x001FB4A4
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

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06005086 RID: 20614 RVA: 0x001FD2E0 File Offset: 0x001FB4E0
		public int GroupId
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

		// Token: 0x06005087 RID: 20615 RVA: 0x001FD31C File Offset: 0x001FB51C
		public int DifficultPreLevel(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06005088 RID: 20616 RVA: 0x001FD35C File Offset: 0x001FB55C
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

		// Token: 0x06005089 RID: 20617 RVA: 0x001FD387 File Offset: 0x001FB587
		public Span<int> GetDifficultPreLevelBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x001FD396 File Offset: 0x001FB596
		public int[] GetDifficultPreLevelArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x001FD3B0 File Offset: 0x001FB5B0
		public DicIntInt? DifficultPreLevelStar(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600508C RID: 20620 RVA: 0x001FD414 File Offset: 0x001FB614
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

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600508D RID: 20621 RVA: 0x001FD440 File Offset: 0x001FB640
		public int Star
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

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600508E RID: 20622 RVA: 0x001FD480 File Offset: 0x001FB680
		public int Line
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600508F RID: 20623 RVA: 0x001FD4C0 File Offset: 0x001FB6C0
		public string Texture
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

		// Token: 0x06005090 RID: 20624 RVA: 0x001FD4F8 File Offset: 0x001FB6F8
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x001FD508 File Offset: 0x001FB708
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06005092 RID: 20626 RVA: 0x001FD520 File Offset: 0x001FB720
		public string NameText
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

		// Token: 0x06005093 RID: 20627 RVA: 0x001FD558 File Offset: 0x001FB758
		public Span<byte> GetNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005094 RID: 20628 RVA: 0x001FD568 File Offset: 0x001FB768
		public byte[] GetNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06005095 RID: 20629 RVA: 0x001FD580 File Offset: 0x001FB780
		public string DesText
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x001FD5B8 File Offset: 0x001FB7B8
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x001FD5C8 File Offset: 0x001FB7C8
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x001FD5E0 File Offset: 0x001FB7E0
		[NullableContext(1)]
		public int[] DifficultPreLevel()
		{
			return this.GetDifficultPreLevelArray();
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x001FD5E8 File Offset: 0x001FB7E8
		[NullableContext(1)]
		public IEnumerable<int> DifficultPreLevelIter()
		{
			BabelTowerDeTerm.<DifficultPreLevelIter>d__37 <DifficultPreLevelIter>d__ = new BabelTowerDeTerm.<DifficultPreLevelIter>d__37(-2);
			<DifficultPreLevelIter>d__.<>3__<>4__this = this;
			return <DifficultPreLevelIter>d__;
		}

		// Token: 0x0600509A RID: 20634 RVA: 0x001FD600 File Offset: 0x001FB800
		[NullableContext(1)]
		public Dictionary<int, int> DifficultPreLevelStar()
		{
			return this.DifficultPreLevelStarIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x001FD656 File Offset: 0x001FB856
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DifficultPreLevelStarIter()
		{
			BabelTowerDeTerm.<DifficultPreLevelStarIter>d__39 <DifficultPreLevelStarIter>d__ = new BabelTowerDeTerm.<DifficultPreLevelStarIter>d__39(-2);
			<DifficultPreLevelStarIter>d__.<>3__<>4__this = this;
			return <DifficultPreLevelStarIter>d__;
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x001FD66C File Offset: 0x001FB86C
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

		// Token: 0x0600509D RID: 20637 RVA: 0x001FD6A0 File Offset: 0x001FB8A0
		private void EnsureDifficultPreLevelStarCacheIfNeeded()
		{
			if (this.DifficultPreLevelStarCache != null)
			{
				return;
			}
			this.DifficultPreLevelStarCache = this.DifficultPreLevelStarIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600509E RID: 20638 RVA: 0x001FD706 File Offset: 0x001FB906
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDifficultPreLevelStarFrozenDict()
		{
			this.EnsureDifficultPreLevelStarCacheIfNeeded();
			return this.DifficultPreLevelStarCache;
		}

		// Token: 0x040050EF RID: 20719
		private Table __p;

		// Token: 0x040050F0 RID: 20720
		[Nullable(2)]
		private FrozenDictionary<int, int> DifficultPreLevelStarCache;
	}
}
