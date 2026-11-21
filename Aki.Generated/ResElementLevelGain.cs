using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A1 RID: 4257
	public struct ResElementLevelGain : IFlatbufferObject
	{
		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x0600C1E5 RID: 49637 RVA: 0x002F9C05 File Offset: 0x002F7E05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C1E6 RID: 49638 RVA: 0x002F9C12 File Offset: 0x002F7E12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C1E7 RID: 49639 RVA: 0x002F9C1C File Offset: 0x002F7E1C
		public static ResElementLevelGain GetRootAsResElementLevelGain(ByteBuffer _bb)
		{
			return ResElementLevelGain.GetRootAsResElementLevelGain(_bb, default(ResElementLevelGain));
		}

		// Token: 0x0600C1E8 RID: 49640 RVA: 0x002F9C38 File Offset: 0x002F7E38
		public static ResElementLevelGain GetRootAsResElementLevelGain(ByteBuffer _bb, ResElementLevelGain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C1E9 RID: 49641 RVA: 0x002F9C55 File Offset: 0x002F7E55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C1EA RID: 49642 RVA: 0x002F9C64 File Offset: 0x002F7E64
		public ResElementLevelGain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x0600C1EB RID: 49643 RVA: 0x002F9C74 File Offset: 0x002F7E74
		public int TargetType
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

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x0600C1EC RID: 49644 RVA: 0x002F9CB0 File Offset: 0x002F7EB0
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600C1ED RID: 49645 RVA: 0x002F9CF8 File Offset: 0x002F7EF8
		public long AddBuffs(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x0600C1EE RID: 49646 RVA: 0x002F9D44 File Offset: 0x002F7F44
		public int AddBuffsLength
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

		// Token: 0x0600C1EF RID: 49647 RVA: 0x002F9D6F File Offset: 0x002F7F6F
		public Span<long> GetAddBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600C1F0 RID: 49648 RVA: 0x002F9D83 File Offset: 0x002F7F83
		public long[] GetAddBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x0600C1F1 RID: 49649 RVA: 0x002F9DC0 File Offset: 0x002F7FC0
		public string TextId
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

		// Token: 0x0600C1F2 RID: 49650 RVA: 0x002F9DF8 File Offset: 0x002F7FF8
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x002F9E08 File Offset: 0x002F8008
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C1F4 RID: 49652 RVA: 0x002F9E20 File Offset: 0x002F8020
		public string TextIdArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x0600C1F5 RID: 49653 RVA: 0x002F9E5C File Offset: 0x002F805C
		public int TextIdArgsLength
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

		// Token: 0x0600C1F6 RID: 49654 RVA: 0x002F9E88 File Offset: 0x002F8088
		[NullableContext(1)]
		public long[] AddBuffs()
		{
			return this.GetAddBuffsArray();
		}

		// Token: 0x0600C1F7 RID: 49655 RVA: 0x002F9E90 File Offset: 0x002F8090
		[NullableContext(1)]
		public IEnumerable<long> AddBuffsIter()
		{
			ResElementLevelGain.<AddBuffsIter>d__25 <AddBuffsIter>d__ = new ResElementLevelGain.<AddBuffsIter>d__25(-2);
			<AddBuffsIter>d__.<>3__<>4__this = this;
			return <AddBuffsIter>d__;
		}

		// Token: 0x0600C1F8 RID: 49656 RVA: 0x002F9EA5 File Offset: 0x002F80A5
		[NullableContext(1)]
		public string[] TextIdArgs()
		{
			return this.TextIdArgsIter().ToArray<string>();
		}

		// Token: 0x0600C1F9 RID: 49657 RVA: 0x002F9EB2 File Offset: 0x002F80B2
		[NullableContext(1)]
		public IEnumerable<string> TextIdArgsIter()
		{
			ResElementLevelGain.<TextIdArgsIter>d__27 <TextIdArgsIter>d__ = new ResElementLevelGain.<TextIdArgsIter>d__27(-2);
			<TextIdArgsIter>d__.<>3__<>4__this = this;
			return <TextIdArgsIter>d__;
		}

		// Token: 0x0400567A RID: 22138
		private Table __p;
	}
}
