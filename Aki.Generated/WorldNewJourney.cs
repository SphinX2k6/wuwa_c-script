using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012DC RID: 4828
	public struct WorldNewJourney : IFlatbufferObject
	{
		// Token: 0x170041D6 RID: 16854
		// (get) Token: 0x0600F6A6 RID: 63142 RVA: 0x003705F5 File Offset: 0x0036E7F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F6A7 RID: 63143 RVA: 0x00370602 File Offset: 0x0036E802
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F6A8 RID: 63144 RVA: 0x0037060C File Offset: 0x0036E80C
		public static WorldNewJourney GetRootAsWorldNewJourney(ByteBuffer _bb)
		{
			return WorldNewJourney.GetRootAsWorldNewJourney(_bb, default(WorldNewJourney));
		}

		// Token: 0x0600F6A9 RID: 63145 RVA: 0x00370628 File Offset: 0x0036E828
		public static WorldNewJourney GetRootAsWorldNewJourney(ByteBuffer _bb, WorldNewJourney obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F6AA RID: 63146 RVA: 0x00370645 File Offset: 0x0036E845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F6AB RID: 63147 RVA: 0x00370654 File Offset: 0x0036E854
		public WorldNewJourney __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041D7 RID: 16855
		// (get) Token: 0x0600F6AC RID: 63148 RVA: 0x00370664 File Offset: 0x0036E864
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

		// Token: 0x170041D8 RID: 16856
		// (get) Token: 0x0600F6AD RID: 63149 RVA: 0x003706A0 File Offset: 0x0036E8A0
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170041D9 RID: 16857
		// (get) Token: 0x0600F6AE RID: 63150 RVA: 0x003706E0 File Offset: 0x0036E8E0
		public int SourceType
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

		// Token: 0x170041DA RID: 16858
		// (get) Token: 0x0600F6AF RID: 63151 RVA: 0x0037071C File Offset: 0x0036E91C
		public int SourceId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170041DB RID: 16859
		// (get) Token: 0x0600F6B0 RID: 63152 RVA: 0x0037075C File Offset: 0x0036E95C
		public string SourceTitle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F6B1 RID: 63153 RVA: 0x00370794 File Offset: 0x0036E994
		public Span<byte> GetSourceTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600F6B2 RID: 63154 RVA: 0x003707A4 File Offset: 0x0036E9A4
		public byte[] GetSourceTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170041DC RID: 16860
		// (get) Token: 0x0600F6B3 RID: 63155 RVA: 0x003707BC File Offset: 0x0036E9BC
		public string SourceDesc
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

		// Token: 0x0600F6B4 RID: 63156 RVA: 0x003707F4 File Offset: 0x0036E9F4
		public Span<byte> GetSourceDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600F6B5 RID: 63157 RVA: 0x00370804 File Offset: 0x0036EA04
		public byte[] GetSourceDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170041DD RID: 16861
		// (get) Token: 0x0600F6B6 RID: 63158 RVA: 0x0037081C File Offset: 0x0036EA1C
		public int ConditionId
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

		// Token: 0x0600F6B7 RID: 63159 RVA: 0x0037085C File Offset: 0x0036EA5C
		public DicIntString? JumpTo(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170041DE RID: 16862
		// (get) Token: 0x0600F6B8 RID: 63160 RVA: 0x003708C0 File Offset: 0x0036EAC0
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

		// Token: 0x0600F6B9 RID: 63161 RVA: 0x003708EC File Offset: 0x0036EAEC
		[NullableContext(1)]
		public Dictionary<int, string> JumpTo()
		{
			return this.JumpToIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600F6BA RID: 63162 RVA: 0x00370942 File Offset: 0x0036EB42
		[NullableContext(1)]
		public IEnumerable<DicIntString> JumpToIter()
		{
			WorldNewJourney.<JumpToIter>d__30 <JumpToIter>d__ = new WorldNewJourney.<JumpToIter>d__30(-2);
			<JumpToIter>d__.<>3__<>4__this = this;
			return <JumpToIter>d__;
		}

		// Token: 0x0600F6BB RID: 63163 RVA: 0x00370958 File Offset: 0x0036EB58
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

		// Token: 0x0600F6BC RID: 63164 RVA: 0x00370980 File Offset: 0x0036EB80
		private void EnsureJumpToCacheIfNeeded()
		{
			if (this.JumpToCache != null)
			{
				return;
			}
			this.JumpToCache = this.JumpToIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600F6BD RID: 63165 RVA: 0x003709E6 File Offset: 0x0036EBE6
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetJumpToFrozenDict()
		{
			this.EnsureJumpToCacheIfNeeded();
			return this.JumpToCache;
		}

		// Token: 0x04005935 RID: 22837
		private Table __p;

		// Token: 0x04005936 RID: 22838
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> JumpToCache;
	}
}
