using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4C RID: 3660
	public struct InfrPhoneMessage : IFlatbufferObject
	{
		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x0600899F RID: 35231 RVA: 0x0027D7CD File Offset: 0x0027B9CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060089A0 RID: 35232 RVA: 0x0027D7DA File Offset: 0x0027B9DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060089A1 RID: 35233 RVA: 0x0027D7E4 File Offset: 0x0027B9E4
		public static InfrPhoneMessage GetRootAsInfrPhoneMessage(ByteBuffer _bb)
		{
			return InfrPhoneMessage.GetRootAsInfrPhoneMessage(_bb, default(InfrPhoneMessage));
		}

		// Token: 0x060089A2 RID: 35234 RVA: 0x0027D800 File Offset: 0x0027BA00
		public static InfrPhoneMessage GetRootAsInfrPhoneMessage(ByteBuffer _bb, InfrPhoneMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060089A3 RID: 35235 RVA: 0x0027D81D File Offset: 0x0027BA1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x0027D82C File Offset: 0x0027BA2C
		public InfrPhoneMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x060089A5 RID: 35237 RVA: 0x0027D83C File Offset: 0x0027BA3C
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

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x060089A6 RID: 35238 RVA: 0x0027D878 File Offset: 0x0027BA78
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

		// Token: 0x060089A7 RID: 35239 RVA: 0x0027D8AF File Offset: 0x0027BAAF
		public Span<byte> GetRoleTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060089A8 RID: 35240 RVA: 0x0027D8BE File Offset: 0x0027BABE
		public byte[] GetRoleTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x060089A9 RID: 35241 RVA: 0x0027D8D8 File Offset: 0x0027BAD8
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

		// Token: 0x060089AA RID: 35242 RVA: 0x0027D90F File Offset: 0x0027BB0F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060089AB RID: 35243 RVA: 0x0027D91E File Offset: 0x0027BB1E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040053CC RID: 21452
		private Table __p;
	}
}
