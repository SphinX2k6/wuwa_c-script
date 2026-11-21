using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAD RID: 2989
	public struct AdventureTask : IFlatbufferObject
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600499D RID: 18845 RVA: 0x001EDD81 File Offset: 0x001EBF81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x001EDD8E File Offset: 0x001EBF8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x001EDD98 File Offset: 0x001EBF98
		public static AdventureTask GetRootAsAdventureTask(ByteBuffer _bb)
		{
			return AdventureTask.GetRootAsAdventureTask(_bb, default(AdventureTask));
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x001EDDB4 File Offset: 0x001EBFB4
		public static AdventureTask GetRootAsAdventureTask(ByteBuffer _bb, AdventureTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x001EDDD1 File Offset: 0x001EBFD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x001EDDE0 File Offset: 0x001EBFE0
		public AdventureTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060049A3 RID: 18851 RVA: 0x001EDDF0 File Offset: 0x001EBFF0
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060049A4 RID: 18852 RVA: 0x001EDE2C File Offset: 0x001EC02C
		public int ChapterId
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

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x001EDE68 File Offset: 0x001EC068
		public string TaskText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x001EDE9F File Offset: 0x001EC09F
		public Span<byte> GetTaskTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x001EDEAE File Offset: 0x001EC0AE
		public byte[] GetTaskTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x001EDEC8 File Offset: 0x001EC0C8
		public int RecordId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x001EDF08 File Offset: 0x001EC108
		public int RecordIdLength
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

		// Token: 0x060049AA RID: 18858 RVA: 0x001EDF34 File Offset: 0x001EC134
		public Span<int> GetRecordIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x001EDF44 File Offset: 0x001EC144
		public int[] GetRecordIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060049AC RID: 18860 RVA: 0x001EDF5C File Offset: 0x001EC15C
		public int NeedProgress
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060049AD RID: 18861 RVA: 0x001EDF9C File Offset: 0x001EC19C
		public int DropIds
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060049AE RID: 18862 RVA: 0x001EDFDC File Offset: 0x001EC1DC
		public int PathId
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

		// Token: 0x060049AF RID: 18863 RVA: 0x001EE01C File Offset: 0x001EC21C
		public DicIntString? JumpTo(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060049B0 RID: 18864 RVA: 0x001EE080 File Offset: 0x001EC280
		public int JumpToLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x001EE0AC File Offset: 0x001EC2AC
		[NullableContext(1)]
		public Dictionary<int, string> JumpTo()
		{
			return this.JumpToIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x001EE102 File Offset: 0x001EC302
		[NullableContext(1)]
		public IEnumerable<DicIntString> JumpToIter()
		{
			AdventureTask.<JumpToIter>d__31 <JumpToIter>d__ = new AdventureTask.<JumpToIter>d__31(-2);
			<JumpToIter>d__.<>3__<>4__this = this;
			return <JumpToIter>d__;
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x001EE117 File Offset: 0x001EC317
		[NullableContext(1)]
		public int[] RecordId()
		{
			return this.GetRecordIdArray();
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x001EE11F File Offset: 0x001EC31F
		[NullableContext(1)]
		public IEnumerable<int> RecordIdIter()
		{
			AdventureTask.<RecordIdIter>d__33 <RecordIdIter>d__ = new AdventureTask.<RecordIdIter>d__33(-2);
			<RecordIdIter>d__.<>3__<>4__this = this;
			return <RecordIdIter>d__;
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x001EE134 File Offset: 0x001EC334
		[NullableContext(2)]
		public string GetJumpTo(int key)
		{
			this.EnsureJumpToCacheIfNeeded();
			string result;
			if (!this.JumpToCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x001EE15C File Offset: 0x001EC35C
		private void EnsureJumpToCacheIfNeeded()
		{
			if (this.JumpToCache != null)
			{
				return;
			}
			this.JumpToCache = this.JumpToIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x001EE1C2 File Offset: 0x001EC3C2
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetJumpToFrozenDict()
		{
			this.EnsureJumpToCacheIfNeeded();
			return this.JumpToCache;
		}

		// Token: 0x0400508A RID: 20618
		private Table __p;

		// Token: 0x0400508B RID: 20619
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> JumpToCache;
	}
}
