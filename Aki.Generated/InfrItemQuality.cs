using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D64 RID: 3428
	public struct InfrItemQuality : IFlatbufferObject
	{
		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06008335 RID: 33589 RVA: 0x0025E67D File Offset: 0x0025C87D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008336 RID: 33590 RVA: 0x0025E68A File Offset: 0x0025C88A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008337 RID: 33591 RVA: 0x0025E694 File Offset: 0x0025C894
		public static InfrItemQuality GetRootAsInfrItemQuality(ByteBuffer _bb)
		{
			return InfrItemQuality.GetRootAsInfrItemQuality(_bb, default(InfrItemQuality));
		}

		// Token: 0x06008338 RID: 33592 RVA: 0x0025E6B0 File Offset: 0x0025C8B0
		public static InfrItemQuality GetRootAsInfrItemQuality(ByteBuffer _bb, InfrItemQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008339 RID: 33593 RVA: 0x0025E6CD File Offset: 0x0025C8CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600833A RID: 33594 RVA: 0x0025E6DC File Offset: 0x0025C8DC
		public InfrItemQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x0600833B RID: 33595 RVA: 0x0025E6EC File Offset: 0x0025C8EC
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

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x0600833C RID: 33596 RVA: 0x0025E728 File Offset: 0x0025C928
		public string Color
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

		// Token: 0x0600833D RID: 33597 RVA: 0x0025E75F File Offset: 0x0025C95F
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600833E RID: 33598 RVA: 0x0025E76E File Offset: 0x0025C96E
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DE3 RID: 19939
		private Table __p;
	}
}
