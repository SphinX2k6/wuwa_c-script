using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BE RID: 4286
	public struct RogueActivity : IFlatbufferObject
	{
		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x0600C44A RID: 50250 RVA: 0x002FEF75 File Offset: 0x002FD175
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C44B RID: 50251 RVA: 0x002FEF82 File Offset: 0x002FD182
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C44C RID: 50252 RVA: 0x002FEF8C File Offset: 0x002FD18C
		public static RogueActivity GetRootAsRogueActivity(ByteBuffer _bb)
		{
			return RogueActivity.GetRootAsRogueActivity(_bb, default(RogueActivity));
		}

		// Token: 0x0600C44D RID: 50253 RVA: 0x002FEFA8 File Offset: 0x002FD1A8
		public static RogueActivity GetRootAsRogueActivity(ByteBuffer _bb, RogueActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C44E RID: 50254 RVA: 0x002FEFC5 File Offset: 0x002FD1C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C44F RID: 50255 RVA: 0x002FEFD4 File Offset: 0x002FD1D4
		public RogueActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x0600C450 RID: 50256 RVA: 0x002FEFE4 File Offset: 0x002FD1E4
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

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x0600C451 RID: 50257 RVA: 0x002FF020 File Offset: 0x002FD220
		public int FunctionType
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

		// Token: 0x0600C452 RID: 50258 RVA: 0x002FF05C File Offset: 0x002FD25C
		public string FunctionParams(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x0600C453 RID: 50259 RVA: 0x002FF098 File Offset: 0x002FD298
		public int FunctionParamsLength
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

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x0600C454 RID: 50260 RVA: 0x002FF0C4 File Offset: 0x002FD2C4
		public string ActivityResource
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

		// Token: 0x0600C455 RID: 50261 RVA: 0x002FF0FC File Offset: 0x002FD2FC
		public Span<byte> GetActivityResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C456 RID: 50262 RVA: 0x002FF10C File Offset: 0x002FD30C
		public byte[] GetActivityResourceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C457 RID: 50263 RVA: 0x002FF124 File Offset: 0x002FD324
		[NullableContext(1)]
		public string[] FunctionParams()
		{
			return this.FunctionParamsIter().ToArray<string>();
		}

		// Token: 0x0600C458 RID: 50264 RVA: 0x002FF131 File Offset: 0x002FD331
		[NullableContext(1)]
		public IEnumerable<string> FunctionParamsIter()
		{
			RogueActivity.<FunctionParamsIter>d__20 <FunctionParamsIter>d__ = new RogueActivity.<FunctionParamsIter>d__20(-2);
			<FunctionParamsIter>d__.<>3__<>4__this = this;
			return <FunctionParamsIter>d__;
		}

		// Token: 0x0400569A RID: 22170
		private Table __p;
	}
}
