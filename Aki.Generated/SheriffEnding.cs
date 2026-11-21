using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119A RID: 4506
	public struct SheriffEnding : IFlatbufferObject
	{
		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x0600D8A7 RID: 55463 RVA: 0x0032C011 File Offset: 0x0032A211
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D8A8 RID: 55464 RVA: 0x0032C01E File Offset: 0x0032A21E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D8A9 RID: 55465 RVA: 0x0032C028 File Offset: 0x0032A228
		public static SheriffEnding GetRootAsSheriffEnding(ByteBuffer _bb)
		{
			return SheriffEnding.GetRootAsSheriffEnding(_bb, default(SheriffEnding));
		}

		// Token: 0x0600D8AA RID: 55466 RVA: 0x0032C044 File Offset: 0x0032A244
		public static SheriffEnding GetRootAsSheriffEnding(ByteBuffer _bb, SheriffEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D8AB RID: 55467 RVA: 0x0032C061 File Offset: 0x0032A261
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D8AC RID: 55468 RVA: 0x0032C070 File Offset: 0x0032A270
		public SheriffEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x0600D8AD RID: 55469 RVA: 0x0032C080 File Offset: 0x0032A280
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

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x0600D8AE RID: 55470 RVA: 0x0032C0BC File Offset: 0x0032A2BC
		public int SheriffAnomalyId
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

		// Token: 0x0600D8AF RID: 55471 RVA: 0x0032C0F8 File Offset: 0x0032A2F8
		public int SheriffClueId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x0600D8B0 RID: 55472 RVA: 0x0032C138 File Offset: 0x0032A338
		public int SheriffClueIdLength
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

		// Token: 0x0600D8B1 RID: 55473 RVA: 0x0032C163 File Offset: 0x0032A363
		public Span<int> GetSheriffClueIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D8B2 RID: 55474 RVA: 0x0032C172 File Offset: 0x0032A372
		public int[] GetSheriffClueIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x0600D8B3 RID: 55475 RVA: 0x0032C18C File Offset: 0x0032A38C
		public string Context
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

		// Token: 0x0600D8B4 RID: 55476 RVA: 0x0032C1C4 File Offset: 0x0032A3C4
		public Span<byte> GetContextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D8B5 RID: 55477 RVA: 0x0032C1D4 File Offset: 0x0032A3D4
		public byte[] GetContextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x0600D8B6 RID: 55478 RVA: 0x0032C1EC File Offset: 0x0032A3EC
		public string Icon
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

		// Token: 0x0600D8B7 RID: 55479 RVA: 0x0032C224 File Offset: 0x0032A424
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D8B8 RID: 55480 RVA: 0x0032C234 File Offset: 0x0032A434
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D8B9 RID: 55481 RVA: 0x0032C24C File Offset: 0x0032A44C
		[NullableContext(1)]
		public int[] SheriffClueId()
		{
			return this.GetSheriffClueIdArray();
		}

		// Token: 0x0600D8BA RID: 55482 RVA: 0x0032C254 File Offset: 0x0032A454
		[NullableContext(1)]
		public IEnumerable<int> SheriffClueIdIter()
		{
			SheriffEnding.<SheriffClueIdIter>d__26 <SheriffClueIdIter>d__ = new SheriffEnding.<SheriffClueIdIter>d__26(-2);
			<SheriffClueIdIter>d__.<>3__<>4__this = this;
			return <SheriffClueIdIter>d__;
		}

		// Token: 0x040057AC RID: 22444
		private Table __p;
	}
}
