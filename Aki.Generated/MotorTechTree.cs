using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F55 RID: 3925
	public struct MotorTechTree : IFlatbufferObject
	{
		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x0600A302 RID: 41730 RVA: 0x002B6788 File Offset: 0x002B4988
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x002B6795 File Offset: 0x002B4995
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x002B679C File Offset: 0x002B499C
		public static MotorTechTree GetRootAsMotorTechTree(ByteBuffer _bb)
		{
			return MotorTechTree.GetRootAsMotorTechTree(_bb, default(MotorTechTree));
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x002B67B8 File Offset: 0x002B49B8
		public static MotorTechTree GetRootAsMotorTechTree(ByteBuffer _bb, MotorTechTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A306 RID: 41734 RVA: 0x002B67D5 File Offset: 0x002B49D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A307 RID: 41735 RVA: 0x002B67E4 File Offset: 0x002B49E4
		public MotorTechTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x0600A308 RID: 41736 RVA: 0x002B67F4 File Offset: 0x002B49F4
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

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x0600A309 RID: 41737 RVA: 0x002B6830 File Offset: 0x002B4A30
		public int UnlockCondition
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

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x0600A30A RID: 41738 RVA: 0x002B686C File Offset: 0x002B4A6C
		public int Order
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

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x0600A30B RID: 41739 RVA: 0x002B68A8 File Offset: 0x002B4AA8
		public int TpItemId
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

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x0600A30C RID: 41740 RVA: 0x002B68E8 File Offset: 0x002B4AE8
		public int TaskLimitPointNum
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

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x0600A30D RID: 41741 RVA: 0x002B6928 File Offset: 0x002B4B28
		public string Name
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A30E RID: 41742 RVA: 0x002B6960 File Offset: 0x002B4B60
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A30F RID: 41743 RVA: 0x002B6970 File Offset: 0x002B4B70
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x0600A310 RID: 41744 RVA: 0x002B6988 File Offset: 0x002B4B88
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x002B69C0 File Offset: 0x002B4BC0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x002B69D0 File Offset: 0x002B4BD0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x0600A313 RID: 41747 RVA: 0x002B69E8 File Offset: 0x002B4BE8
		public string Icon512
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x002B6A20 File Offset: 0x002B4C20
		public Span<byte> GetIcon512Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A315 RID: 41749 RVA: 0x002B6A30 File Offset: 0x002B4C30
		public byte[] GetIcon512Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x0600A316 RID: 41750 RVA: 0x002B6A48 File Offset: 0x002B4C48
		public int ComUiType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005503 RID: 21763
		private Table __p;
	}
}
