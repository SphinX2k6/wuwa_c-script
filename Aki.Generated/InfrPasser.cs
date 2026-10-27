using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D66 RID: 3430
	public struct InfrPasser : IFlatbufferObject
	{
		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x0600837B RID: 33659 RVA: 0x0025F050 File Offset: 0x0025D250
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600837C RID: 33660 RVA: 0x0025F05D File Offset: 0x0025D25D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600837D RID: 33661 RVA: 0x0025F064 File Offset: 0x0025D264
		public static InfrPasser GetRootAsInfrPasser(ByteBuffer _bb)
		{
			return InfrPasser.GetRootAsInfrPasser(_bb, default(InfrPasser));
		}

		// Token: 0x0600837E RID: 33662 RVA: 0x0025F080 File Offset: 0x0025D280
		public static InfrPasser GetRootAsInfrPasser(ByteBuffer _bb, InfrPasser obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x0025F09D File Offset: 0x0025D29D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008380 RID: 33664 RVA: 0x0025F0AC File Offset: 0x0025D2AC
		public InfrPasser __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x06008381 RID: 33665 RVA: 0x0025F0BC File Offset: 0x0025D2BC
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

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06008382 RID: 33666 RVA: 0x0025F0F8 File Offset: 0x0025D2F8
		public string Name
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

		// Token: 0x06008383 RID: 33667 RVA: 0x0025F12F File Offset: 0x0025D32F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008384 RID: 33668 RVA: 0x0025F13E File Offset: 0x0025D33E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DE6 RID: 19942
		private Table __p;
	}
}
