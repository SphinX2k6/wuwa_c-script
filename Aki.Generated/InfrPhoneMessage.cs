using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D67 RID: 3431
	public struct InfrPhoneMessage : IFlatbufferObject
	{
		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06008385 RID: 33669 RVA: 0x0025F155 File Offset: 0x0025D355
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008386 RID: 33670 RVA: 0x0025F162 File Offset: 0x0025D362
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008387 RID: 33671 RVA: 0x0025F16C File Offset: 0x0025D36C
		public static InfrPhoneMessage GetRootAsInfrPhoneMessage(ByteBuffer _bb)
		{
			return InfrPhoneMessage.GetRootAsInfrPhoneMessage(_bb, default(InfrPhoneMessage));
		}

		// Token: 0x06008388 RID: 33672 RVA: 0x0025F188 File Offset: 0x0025D388
		public static InfrPhoneMessage GetRootAsInfrPhoneMessage(ByteBuffer _bb, InfrPhoneMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008389 RID: 33673 RVA: 0x0025F1A5 File Offset: 0x0025D3A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600838A RID: 33674 RVA: 0x0025F1B4 File Offset: 0x0025D3B4
		public InfrPhoneMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x0600838B RID: 33675 RVA: 0x0025F1C4 File Offset: 0x0025D3C4
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

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x0600838C RID: 33676 RVA: 0x0025F200 File Offset: 0x0025D400
		public string RoleTexturePath
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

		// Token: 0x0600838D RID: 33677 RVA: 0x0025F237 File Offset: 0x0025D437
		public Span<byte> GetRoleTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600838E RID: 33678 RVA: 0x0025F246 File Offset: 0x0025D446
		public byte[] GetRoleTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x0600838F RID: 33679 RVA: 0x0025F260 File Offset: 0x0025D460
		public string Name
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

		// Token: 0x06008390 RID: 33680 RVA: 0x0025F297 File Offset: 0x0025D497
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x0025F2A6 File Offset: 0x0025D4A6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DE7 RID: 19943
		private Table __p;
	}
}
