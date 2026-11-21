using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200126F RID: 4719
	public struct TowerDefenceMapMark : IFlatbufferObject
	{
		// Token: 0x17003E33 RID: 15923
		// (get) Token: 0x0600ED4A RID: 60746 RVA: 0x0035B7A1 File Offset: 0x003599A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ED4B RID: 60747 RVA: 0x0035B7AE File Offset: 0x003599AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ED4C RID: 60748 RVA: 0x0035B7B8 File Offset: 0x003599B8
		public static TowerDefenceMapMark GetRootAsTowerDefenceMapMark(ByteBuffer _bb)
		{
			return TowerDefenceMapMark.GetRootAsTowerDefenceMapMark(_bb, default(TowerDefenceMapMark));
		}

		// Token: 0x0600ED4D RID: 60749 RVA: 0x0035B7D4 File Offset: 0x003599D4
		public static TowerDefenceMapMark GetRootAsTowerDefenceMapMark(ByteBuffer _bb, TowerDefenceMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ED4E RID: 60750 RVA: 0x0035B7F1 File Offset: 0x003599F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ED4F RID: 60751 RVA: 0x0035B800 File Offset: 0x00359A00
		public TowerDefenceMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x0600ED50 RID: 60752 RVA: 0x0035B810 File Offset: 0x00359A10
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

		// Token: 0x17003E35 RID: 15925
		// (get) Token: 0x0600ED51 RID: 60753 RVA: 0x0035B84C File Offset: 0x00359A4C
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

		// Token: 0x040058BD RID: 22717
		private Table __p;
	}
}
