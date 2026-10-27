using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E05 RID: 3589
	public struct MaterialDetection : IFlatbufferObject
	{
		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06009360 RID: 37728 RVA: 0x00283AC1 File Offset: 0x00281CC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009361 RID: 37729 RVA: 0x00283ACE File Offset: 0x00281CCE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009362 RID: 37730 RVA: 0x00283AD8 File Offset: 0x00281CD8
		public static MaterialDetection GetRootAsMaterialDetection(ByteBuffer _bb)
		{
			return MaterialDetection.GetRootAsMaterialDetection(_bb, default(MaterialDetection));
		}

		// Token: 0x06009363 RID: 37731 RVA: 0x00283AF4 File Offset: 0x00281CF4
		public static MaterialDetection GetRootAsMaterialDetection(ByteBuffer _bb, MaterialDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009364 RID: 37732 RVA: 0x00283B11 File Offset: 0x00281D11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009365 RID: 37733 RVA: 0x00283B20 File Offset: 0x00281D20
		public MaterialDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06009366 RID: 37734 RVA: 0x00283B30 File Offset: 0x00281D30
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

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x06009367 RID: 37735 RVA: 0x00283B6C File Offset: 0x00281D6C
		public int AccessPathId
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

		// Token: 0x04004EA6 RID: 20134
		private Table __p;
	}
}
