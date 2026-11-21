using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD9 RID: 3289
	public struct DollGrabMachineHelpInfo : IFlatbufferObject
	{
		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060068AE RID: 26798 RVA: 0x002340D8 File Offset: 0x002322D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x002340E5 File Offset: 0x002322E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x002340EC File Offset: 0x002322EC
		public static DollGrabMachineHelpInfo GetRootAsDollGrabMachineHelpInfo(ByteBuffer _bb)
		{
			return DollGrabMachineHelpInfo.GetRootAsDollGrabMachineHelpInfo(_bb, default(DollGrabMachineHelpInfo));
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x00234108 File Offset: 0x00232308
		public static DollGrabMachineHelpInfo GetRootAsDollGrabMachineHelpInfo(ByteBuffer _bb, DollGrabMachineHelpInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060068B2 RID: 26802 RVA: 0x00234125 File Offset: 0x00232325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x00234134 File Offset: 0x00232334
		public DollGrabMachineHelpInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060068B4 RID: 26804 RVA: 0x00234144 File Offset: 0x00232344
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

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x060068B5 RID: 26805 RVA: 0x00234180 File Offset: 0x00232380
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

		// Token: 0x060068B6 RID: 26806 RVA: 0x002341B7 File Offset: 0x002323B7
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x002341C6 File Offset: 0x002323C6
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x060068B8 RID: 26808 RVA: 0x002341E0 File Offset: 0x002323E0
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

		// Token: 0x060068B9 RID: 26809 RVA: 0x00234217 File Offset: 0x00232417
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x00234226 File Offset: 0x00232426
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x060068BB RID: 26811 RVA: 0x00234240 File Offset: 0x00232440
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

		// Token: 0x060068BC RID: 26812 RVA: 0x00234278 File Offset: 0x00232478
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x00234288 File Offset: 0x00232488
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005206 RID: 20998
		private Table __p;
	}
}
