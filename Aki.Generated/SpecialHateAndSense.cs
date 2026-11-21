using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001216 RID: 4630
	public struct SpecialHateAndSense : IFlatbufferObject
	{
		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x0600E52C RID: 58668 RVA: 0x0034953E File Offset: 0x0034773E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E52D RID: 58669 RVA: 0x0034954B File Offset: 0x0034774B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E52E RID: 58670 RVA: 0x00349554 File Offset: 0x00347754
		public static SpecialHateAndSense GetRootAsSpecialHateAndSense(ByteBuffer _bb)
		{
			return SpecialHateAndSense.GetRootAsSpecialHateAndSense(_bb, default(SpecialHateAndSense));
		}

		// Token: 0x0600E52F RID: 58671 RVA: 0x00349570 File Offset: 0x00347770
		public static SpecialHateAndSense GetRootAsSpecialHateAndSense(ByteBuffer _bb, SpecialHateAndSense obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E530 RID: 58672 RVA: 0x0034958D File Offset: 0x0034778D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E531 RID: 58673 RVA: 0x0034959C File Offset: 0x0034779C
		public SpecialHateAndSense __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x0600E532 RID: 58674 RVA: 0x003495AC File Offset: 0x003477AC
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

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x0600E533 RID: 58675 RVA: 0x003495E8 File Offset: 0x003477E8
		public string DescText
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

		// Token: 0x0600E534 RID: 58676 RVA: 0x0034961F File Offset: 0x0034781F
		public Span<byte> GetDescTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E535 RID: 58677 RVA: 0x0034962E File Offset: 0x0034782E
		public byte[] GetDescTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x0600E536 RID: 58678 RVA: 0x00349648 File Offset: 0x00347848
		public int AiHateId
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

		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x0600E537 RID: 58679 RVA: 0x00349684 File Offset: 0x00347884
		public int FirstAiSenseId
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

		// Token: 0x04005856 RID: 22614
		private Table __p;
	}
}
