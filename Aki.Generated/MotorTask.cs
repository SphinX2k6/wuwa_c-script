using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F51 RID: 3921
	public struct MotorTask : IFlatbufferObject
	{
		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x0600A299 RID: 41625 RVA: 0x002B59C8 File Offset: 0x002B3BC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x002B59D5 File Offset: 0x002B3BD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x002B59DC File Offset: 0x002B3BDC
		public static MotorTask GetRootAsMotorTask(ByteBuffer _bb)
		{
			return MotorTask.GetRootAsMotorTask(_bb, default(MotorTask));
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x002B59F8 File Offset: 0x002B3BF8
		public static MotorTask GetRootAsMotorTask(ByteBuffer _bb, MotorTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A29D RID: 41629 RVA: 0x002B5A15 File Offset: 0x002B3C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x002B5A24 File Offset: 0x002B3C24
		public MotorTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x0600A29F RID: 41631 RVA: 0x002B5A34 File Offset: 0x002B3C34
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

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x0600A2A0 RID: 41632 RVA: 0x002B5A70 File Offset: 0x002B3C70
		public int TreeType
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

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x0600A2A1 RID: 41633 RVA: 0x002B5AAC File Offset: 0x002B3CAC
		public int SortOrder
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

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x0600A2A2 RID: 41634 RVA: 0x002B5AE8 File Offset: 0x002B3CE8
		public string Title
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

		// Token: 0x0600A2A3 RID: 41635 RVA: 0x002B5B20 File Offset: 0x002B3D20
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A2A4 RID: 41636 RVA: 0x002B5B30 File Offset: 0x002B3D30
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x0600A2A5 RID: 41637 RVA: 0x002B5B48 File Offset: 0x002B3D48
		public int JumpId
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

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x0600A2A6 RID: 41638 RVA: 0x002B5B88 File Offset: 0x002B3D88
		public int RewardTpCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040054FF RID: 21759
		private Table __p;
	}
}
