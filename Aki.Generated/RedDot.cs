using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA5 RID: 4005
	public struct RedDot : IFlatbufferObject
	{
		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0600BA69 RID: 47721 RVA: 0x002DABAC File Offset: 0x002D8DAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA6A RID: 47722 RVA: 0x002DABB9 File Offset: 0x002D8DB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA6B RID: 47723 RVA: 0x002DABC0 File Offset: 0x002D8DC0
		public static RedDot GetRootAsRedDot(ByteBuffer _bb)
		{
			return RedDot.GetRootAsRedDot(_bb, default(RedDot));
		}

		// Token: 0x0600BA6C RID: 47724 RVA: 0x002DABDC File Offset: 0x002D8DDC
		public static RedDot GetRootAsRedDot(ByteBuffer _bb, RedDot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA6D RID: 47725 RVA: 0x002DABF9 File Offset: 0x002D8DF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA6E RID: 47726 RVA: 0x002DAC08 File Offset: 0x002D8E08
		public RedDot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x0600BA6F RID: 47727 RVA: 0x002DAC18 File Offset: 0x002D8E18
		public string Name
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

		// Token: 0x0600BA70 RID: 47728 RVA: 0x002DAC4F File Offset: 0x002D8E4F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600BA71 RID: 47729 RVA: 0x002DAC5E File Offset: 0x002D8E5E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x0600BA72 RID: 47730 RVA: 0x002DAC78 File Offset: 0x002D8E78
		public string RelativeName
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

		// Token: 0x0600BA73 RID: 47731 RVA: 0x002DACAF File Offset: 0x002D8EAF
		public Span<byte> GetRelativeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BA74 RID: 47732 RVA: 0x002DACBE File Offset: 0x002D8EBE
		public byte[] GetRelativeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400507E RID: 20606
		private Table __p;
	}
}
