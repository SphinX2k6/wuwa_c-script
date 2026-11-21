using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001270 RID: 4720
	public struct TowerDefenceMark : IFlatbufferObject
	{
		// Token: 0x17003E36 RID: 15926
		// (get) Token: 0x0600ED52 RID: 60754 RVA: 0x0035B888 File Offset: 0x00359A88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ED53 RID: 60755 RVA: 0x0035B895 File Offset: 0x00359A95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ED54 RID: 60756 RVA: 0x0035B89C File Offset: 0x00359A9C
		public static TowerDefenceMark GetRootAsTowerDefenceMark(ByteBuffer _bb)
		{
			return TowerDefenceMark.GetRootAsTowerDefenceMark(_bb, default(TowerDefenceMark));
		}

		// Token: 0x0600ED55 RID: 60757 RVA: 0x0035B8B8 File Offset: 0x00359AB8
		public static TowerDefenceMark GetRootAsTowerDefenceMark(ByteBuffer _bb, TowerDefenceMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ED56 RID: 60758 RVA: 0x0035B8D5 File Offset: 0x00359AD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ED57 RID: 60759 RVA: 0x0035B8E4 File Offset: 0x00359AE4
		public TowerDefenceMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x0600ED58 RID: 60760 RVA: 0x0035B8F4 File Offset: 0x00359AF4
		public int ActivityId
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

		// Token: 0x17003E38 RID: 15928
		// (get) Token: 0x0600ED59 RID: 60761 RVA: 0x0035B930 File Offset: 0x00359B30
		public int MarkId
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

		// Token: 0x040058BE RID: 22718
		private Table __p;
	}
}
