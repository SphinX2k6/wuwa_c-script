using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2E RID: 3886
	public struct PinballLevelTarget : IFlatbufferObject
	{
		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x0600AF33 RID: 44851 RVA: 0x002C2620 File Offset: 0x002C0820
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AF34 RID: 44852 RVA: 0x002C262D File Offset: 0x002C082D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AF35 RID: 44853 RVA: 0x002C2634 File Offset: 0x002C0834
		public static PinballLevelTarget GetRootAsPinballLevelTarget(ByteBuffer _bb)
		{
			return PinballLevelTarget.GetRootAsPinballLevelTarget(_bb, default(PinballLevelTarget));
		}

		// Token: 0x0600AF36 RID: 44854 RVA: 0x002C2650 File Offset: 0x002C0850
		public static PinballLevelTarget GetRootAsPinballLevelTarget(ByteBuffer _bb, PinballLevelTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AF37 RID: 44855 RVA: 0x002C266D File Offset: 0x002C086D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AF38 RID: 44856 RVA: 0x002C267C File Offset: 0x002C087C
		public PinballLevelTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x0600AF39 RID: 44857 RVA: 0x002C268C File Offset: 0x002C088C
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

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x0600AF3A RID: 44858 RVA: 0x002C26C8 File Offset: 0x002C08C8
		public int CondType
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

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x0600AF3B RID: 44859 RVA: 0x002C2704 File Offset: 0x002C0904
		public string CondDesc
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

		// Token: 0x0600AF3C RID: 44860 RVA: 0x002C273B File Offset: 0x002C093B
		public Span<byte> GetCondDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AF3D RID: 44861 RVA: 0x002C274A File Offset: 0x002C094A
		public byte[] GetCondDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x0600AF3E RID: 44862 RVA: 0x002C2764 File Offset: 0x002C0964
		public int NeedNum
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

		// Token: 0x04004FF8 RID: 20472
		private Table __p;
	}
}
