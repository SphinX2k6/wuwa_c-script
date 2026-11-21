using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE5 RID: 3045
	public struct Artemis : IFlatbufferObject
	{
		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06004E6D RID: 20077 RVA: 0x001F8769 File Offset: 0x001F6969
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x001F8776 File Offset: 0x001F6976
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x001F8780 File Offset: 0x001F6980
		public static Artemis GetRootAsArtemis(ByteBuffer _bb)
		{
			return Artemis.GetRootAsArtemis(_bb, default(Artemis));
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x001F879C File Offset: 0x001F699C
		public static Artemis GetRootAsArtemis(ByteBuffer _bb, Artemis obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x001F87B9 File Offset: 0x001F69B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x001F87C8 File Offset: 0x001F69C8
		public Artemis __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06004E73 RID: 20083 RVA: 0x001F87D8 File Offset: 0x001F69D8
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

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06004E74 RID: 20084 RVA: 0x001F8814 File Offset: 0x001F6A14
		public int ActivityId
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

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06004E75 RID: 20085 RVA: 0x001F8850 File Offset: 0x001F6A50
		public int UnlockDay
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

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06004E76 RID: 20086 RVA: 0x001F888C File Offset: 0x001F6A8C
		public int OpenDay
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

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06004E77 RID: 20087 RVA: 0x001F88CC File Offset: 0x001F6ACC
		public int DropId
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

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06004E78 RID: 20088 RVA: 0x001F890C File Offset: 0x001F6B0C
		public int PreSignId
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

		// Token: 0x06004E79 RID: 20089 RVA: 0x001F894C File Offset: 0x001F6B4C
		public int ChatIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06004E7A RID: 20090 RVA: 0x001F898C File Offset: 0x001F6B8C
		public int ChatIdsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x001F89B8 File Offset: 0x001F6BB8
		public Span<int> GetChatIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x001F89C8 File Offset: 0x001F6BC8
		public int[] GetChatIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06004E7D RID: 20093 RVA: 0x001F89E0 File Offset: 0x001F6BE0
		public int QteId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x001F8A1D File Offset: 0x001F6C1D
		[NullableContext(1)]
		public int[] ChatIds()
		{
			return this.GetChatIdsArray();
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x001F8A25 File Offset: 0x001F6C25
		[NullableContext(1)]
		public IEnumerable<int> ChatIdsIter()
		{
			Artemis.<ChatIdsIter>d__28 <ChatIdsIter>d__ = new Artemis.<ChatIdsIter>d__28(-2);
			<ChatIdsIter>d__.<>3__<>4__this = this;
			return <ChatIdsIter>d__;
		}

		// Token: 0x040050CA RID: 20682
		private Table __p;
	}
}
