using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF7 RID: 3063
	public struct DollGrabMachineHelpInfo : IFlatbufferObject
	{
		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060062D0 RID: 25296 RVA: 0x00214A20 File Offset: 0x00212C20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060062D1 RID: 25297 RVA: 0x00214A2D File Offset: 0x00212C2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x00214A34 File Offset: 0x00212C34
		public static DollGrabMachineHelpInfo GetRootAsDollGrabMachineHelpInfo(ByteBuffer _bb)
		{
			return DollGrabMachineHelpInfo.GetRootAsDollGrabMachineHelpInfo(_bb, default(DollGrabMachineHelpInfo));
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x00214A50 File Offset: 0x00212C50
		public static DollGrabMachineHelpInfo GetRootAsDollGrabMachineHelpInfo(ByteBuffer _bb, DollGrabMachineHelpInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x00214A6D File Offset: 0x00212C6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x00214A7C File Offset: 0x00212C7C
		public DollGrabMachineHelpInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060062D6 RID: 25302 RVA: 0x00214A8C File Offset: 0x00212C8C
		public int CategoryId
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

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060062D7 RID: 25303 RVA: 0x00214AC8 File Offset: 0x00212CC8
		public string IconPath
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

		// Token: 0x060062D8 RID: 25304 RVA: 0x00214AFF File Offset: 0x00212CFF
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060062D9 RID: 25305 RVA: 0x00214B0E File Offset: 0x00212D0E
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060062DA RID: 25306 RVA: 0x00214B28 File Offset: 0x00212D28
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

		// Token: 0x060062DB RID: 25307 RVA: 0x00214B5F File Offset: 0x00212D5F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x00214B6E File Offset: 0x00212D6E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060062DD RID: 25309 RVA: 0x00214B88 File Offset: 0x00212D88
		public string Description
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

		// Token: 0x060062DE RID: 25310 RVA: 0x00214BC0 File Offset: 0x00212DC0
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x00214BD0 File Offset: 0x00212DD0
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C24 RID: 19492
		private Table __p;
	}
}
