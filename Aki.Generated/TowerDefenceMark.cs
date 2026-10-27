using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113A RID: 4410
	public struct TowerDefenceMark : IFlatbufferObject
	{
		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x0600DFE4 RID: 57316 RVA: 0x00330400 File Offset: 0x0032E600
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DFE5 RID: 57317 RVA: 0x0033040D File Offset: 0x0032E60D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DFE6 RID: 57318 RVA: 0x00330414 File Offset: 0x0032E614
		public static TowerDefenceMark GetRootAsTowerDefenceMark(ByteBuffer _bb)
		{
			return TowerDefenceMark.GetRootAsTowerDefenceMark(_bb, default(TowerDefenceMark));
		}

		// Token: 0x0600DFE7 RID: 57319 RVA: 0x00330430 File Offset: 0x0032E630
		public static TowerDefenceMark GetRootAsTowerDefenceMark(ByteBuffer _bb, TowerDefenceMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DFE8 RID: 57320 RVA: 0x0033044D File Offset: 0x0032E64D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DFE9 RID: 57321 RVA: 0x0033045C File Offset: 0x0032E65C
		public TowerDefenceMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x0600DFEA RID: 57322 RVA: 0x0033046C File Offset: 0x0032E66C
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

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x0600DFEB RID: 57323 RVA: 0x003304A8 File Offset: 0x0032E6A8
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

		// Token: 0x0400527B RID: 21115
		private Table __p;
	}
}
