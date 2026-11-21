using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012B1 RID: 4785
	public struct TuningNode : IFlatbufferObject
	{
		// Token: 0x1700405C RID: 16476
		// (get) Token: 0x0600F309 RID: 62217 RVA: 0x00368111 File Offset: 0x00366311
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F30A RID: 62218 RVA: 0x0036811E File Offset: 0x0036631E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F30B RID: 62219 RVA: 0x00368128 File Offset: 0x00366328
		public static TuningNode GetRootAsTuningNode(ByteBuffer _bb)
		{
			return TuningNode.GetRootAsTuningNode(_bb, default(TuningNode));
		}

		// Token: 0x0600F30C RID: 62220 RVA: 0x00368144 File Offset: 0x00366344
		public static TuningNode GetRootAsTuningNode(ByteBuffer _bb, TuningNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F30D RID: 62221 RVA: 0x00368161 File Offset: 0x00366361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F30E RID: 62222 RVA: 0x00368170 File Offset: 0x00366370
		public TuningNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700405D RID: 16477
		// (get) Token: 0x0600F30F RID: 62223 RVA: 0x00368180 File Offset: 0x00366380
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

		// Token: 0x1700405E RID: 16478
		// (get) Token: 0x0600F310 RID: 62224 RVA: 0x003681BC File Offset: 0x003663BC
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F311 RID: 62225 RVA: 0x003681F3 File Offset: 0x003663F3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F312 RID: 62226 RVA: 0x00368202 File Offset: 0x00366402
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700405F RID: 16479
		// (get) Token: 0x0600F313 RID: 62227 RVA: 0x0036821C File Offset: 0x0036641C
		public string AkEvent
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

		// Token: 0x0600F314 RID: 62228 RVA: 0x00368253 File Offset: 0x00366453
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F315 RID: 62229 RVA: 0x00368262 File Offset: 0x00366462
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005904 RID: 22788
		private Table __p;
	}
}
