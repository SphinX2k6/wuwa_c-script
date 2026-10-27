using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E64 RID: 3684
	public struct MotorParkourReward : IFlatbufferObject
	{
		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x06009B7A RID: 39802 RVA: 0x00295E5D File Offset: 0x0029405D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B7B RID: 39803 RVA: 0x00295E6A File Offset: 0x0029406A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B7C RID: 39804 RVA: 0x00295E74 File Offset: 0x00294074
		public static MotorParkourReward GetRootAsMotorParkourReward(ByteBuffer _bb)
		{
			return MotorParkourReward.GetRootAsMotorParkourReward(_bb, default(MotorParkourReward));
		}

		// Token: 0x06009B7D RID: 39805 RVA: 0x00295E90 File Offset: 0x00294090
		public static MotorParkourReward GetRootAsMotorParkourReward(ByteBuffer _bb, MotorParkourReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B7E RID: 39806 RVA: 0x00295EAD File Offset: 0x002940AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B7F RID: 39807 RVA: 0x00295EBC File Offset: 0x002940BC
		public MotorParkourReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x06009B80 RID: 39808 RVA: 0x00295ECC File Offset: 0x002940CC
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

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x06009B81 RID: 39809 RVA: 0x00295F08 File Offset: 0x00294108
		public string Desc
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

		// Token: 0x06009B82 RID: 39810 RVA: 0x00295F3F File Offset: 0x0029413F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009B83 RID: 39811 RVA: 0x00295F4E File Offset: 0x0029414E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x06009B84 RID: 39812 RVA: 0x00295F68 File Offset: 0x00294168
		public int DropId
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

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x06009B85 RID: 39813 RVA: 0x00295FA4 File Offset: 0x002941A4
		public int JumpId
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

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x06009B86 RID: 39814 RVA: 0x00295FE4 File Offset: 0x002941E4
		public int RecordId
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

		// Token: 0x04004F10 RID: 20240
		private Table __p;
	}
}
