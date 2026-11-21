using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCB RID: 4043
	public struct PhantomFetterGroup : IFlatbufferObject
	{
		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x0600AEAA RID: 44714 RVA: 0x002D0132 File Offset: 0x002CE332
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AEAB RID: 44715 RVA: 0x002D013F File Offset: 0x002CE33F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AEAC RID: 44716 RVA: 0x002D0148 File Offset: 0x002CE348
		public static PhantomFetterGroup GetRootAsPhantomFetterGroup(ByteBuffer _bb)
		{
			return PhantomFetterGroup.GetRootAsPhantomFetterGroup(_bb, default(PhantomFetterGroup));
		}

		// Token: 0x0600AEAD RID: 44717 RVA: 0x002D0164 File Offset: 0x002CE364
		public static PhantomFetterGroup GetRootAsPhantomFetterGroup(ByteBuffer _bb, PhantomFetterGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AEAE RID: 44718 RVA: 0x002D0181 File Offset: 0x002CE381
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AEAF RID: 44719 RVA: 0x002D0190 File Offset: 0x002CE390
		public PhantomFetterGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x0600AEB0 RID: 44720 RVA: 0x002D01A0 File Offset: 0x002CE3A0
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

		// Token: 0x0600AEB1 RID: 44721 RVA: 0x002D01DC File Offset: 0x002CE3DC
		public DicIntInt? FetterMap(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x0600AEB2 RID: 44722 RVA: 0x002D023C File Offset: 0x002CE43C
		public int FetterMapLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x0600AEB3 RID: 44723 RVA: 0x002D0268 File Offset: 0x002CE468
		public int FetterType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x0600AEB4 RID: 44724 RVA: 0x002D02A4 File Offset: 0x002CE4A4
		public string FetterGroupName
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

		// Token: 0x0600AEB5 RID: 44725 RVA: 0x002D02DC File Offset: 0x002CE4DC
		public Span<byte> GetFetterGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AEB6 RID: 44726 RVA: 0x002D02EC File Offset: 0x002CE4EC
		public byte[] GetFetterGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x0600AEB7 RID: 44727 RVA: 0x002D0304 File Offset: 0x002CE504
		public int AccessId
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

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x0600AEB8 RID: 44728 RVA: 0x002D0344 File Offset: 0x002CE544
		public string FetterGroupDesc
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

		// Token: 0x0600AEB9 RID: 44729 RVA: 0x002D037C File Offset: 0x002CE57C
		public Span<byte> GetFetterGroupDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AEBA RID: 44730 RVA: 0x002D038C File Offset: 0x002CE58C
		public byte[] GetFetterGroupDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x0600AEBB RID: 44731 RVA: 0x002D03A4 File Offset: 0x002CE5A4
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x0600AEBC RID: 44732 RVA: 0x002D03E4 File Offset: 0x002CE5E4
		public string FetterElementColor
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

		// Token: 0x0600AEBD RID: 44733 RVA: 0x002D041C File Offset: 0x002CE61C
		public Span<byte> GetFetterElementColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AEBE RID: 44734 RVA: 0x002D042C File Offset: 0x002CE62C
		public byte[] GetFetterElementColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x0600AEBF RID: 44735 RVA: 0x002D0444 File Offset: 0x002CE644
		public string FetterElementPath
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

		// Token: 0x0600AEC0 RID: 44736 RVA: 0x002D047C File Offset: 0x002CE67C
		public Span<byte> GetFetterElementPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AEC1 RID: 44737 RVA: 0x002D048C File Offset: 0x002CE68C
		public byte[] GetFetterElementPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x0600AEC2 RID: 44738 RVA: 0x002D04A4 File Offset: 0x002CE6A4
		public string AimModelElementPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AEC3 RID: 44739 RVA: 0x002D04DC File Offset: 0x002CE6DC
		public Span<byte> GetAimModelElementPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x002D04EC File Offset: 0x002CE6EC
		public byte[] GetAimModelElementPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x002D0504 File Offset: 0x002CE704
		[NullableContext(1)]
		public Dictionary<int, int> FetterMap()
		{
			return this.FetterMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AEC6 RID: 44742 RVA: 0x002D055A File Offset: 0x002CE75A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> FetterMapIter()
		{
			PhantomFetterGroup.<FetterMapIter>d__40 <FetterMapIter>d__ = new PhantomFetterGroup.<FetterMapIter>d__40(-2);
			<FetterMapIter>d__.<>3__<>4__this = this;
			return <FetterMapIter>d__;
		}

		// Token: 0x0600AEC7 RID: 44743 RVA: 0x002D0570 File Offset: 0x002CE770
		public int? GetFetterMap(int key)
		{
			this.EnsureFetterMapCacheIfNeeded();
			int value;
			if (!this.FetterMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x002D05A4 File Offset: 0x002CE7A4
		private void EnsureFetterMapCacheIfNeeded()
		{
			if (this.FetterMapCache != null)
			{
				return;
			}
			this.FetterMapCache = this.FetterMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x002D060A File Offset: 0x002CE80A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetFetterMapFrozenDict()
		{
			this.EnsureFetterMapCacheIfNeeded();
			return this.FetterMapCache;
		}

		// Token: 0x0400558C RID: 21900
		private Table __p;

		// Token: 0x0400558D RID: 21901
		[Nullable(2)]
		private FrozenDictionary<int, int> FetterMapCache;
	}
}
