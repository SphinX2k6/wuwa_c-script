using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA6 RID: 3494
	public struct Flow : IFlatbufferObject
	{
		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x06007B58 RID: 31576 RVA: 0x0025E7FD File Offset: 0x0025C9FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x0025E80A File Offset: 0x0025CA0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B5A RID: 31578 RVA: 0x0025E814 File Offset: 0x0025CA14
		public static Flow GetRootAsFlow(ByteBuffer _bb)
		{
			return Flow.GetRootAsFlow(_bb, default(Flow));
		}

		// Token: 0x06007B5B RID: 31579 RVA: 0x0025E830 File Offset: 0x0025CA30
		public static Flow GetRootAsFlow(ByteBuffer _bb, Flow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B5C RID: 31580 RVA: 0x0025E84D File Offset: 0x0025CA4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B5D RID: 31581 RVA: 0x0025E85C File Offset: 0x0025CA5C
		public Flow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x06007B5E RID: 31582 RVA: 0x0025E86C File Offset: 0x0025CA6C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007B5F RID: 31583 RVA: 0x0025E8A3 File Offset: 0x0025CAA3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007B60 RID: 31584 RVA: 0x0025E8B2 File Offset: 0x0025CAB2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06007B61 RID: 31585 RVA: 0x0025E8CC File Offset: 0x0025CACC
		public int DungeonId
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

		// Token: 0x06007B62 RID: 31586 RVA: 0x0025E908 File Offset: 0x0025CB08
		public int States(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x06007B63 RID: 31587 RVA: 0x0025E948 File Offset: 0x0025CB48
		public int StatesLength
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

		// Token: 0x06007B64 RID: 31588 RVA: 0x0025E973 File Offset: 0x0025CB73
		public Span<int> GetStatesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007B65 RID: 31589 RVA: 0x0025E982 File Offset: 0x0025CB82
		public int[] GetStatesArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06007B66 RID: 31590 RVA: 0x0025E999 File Offset: 0x0025CB99
		[NullableContext(1)]
		public int[] States()
		{
			return this.GetStatesArray();
		}

		// Token: 0x06007B67 RID: 31591 RVA: 0x0025E9A1 File Offset: 0x0025CBA1
		[NullableContext(1)]
		public IEnumerable<int> StatesIter()
		{
			Flow.<StatesIter>d__20 <StatesIter>d__ = new Flow.<StatesIter>d__20(-2);
			<StatesIter>d__.<>3__<>4__this = this;
			return <StatesIter>d__;
		}

		// Token: 0x04005316 RID: 21270
		private Table __p;
	}
}
