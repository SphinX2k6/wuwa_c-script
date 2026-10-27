using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001139 RID: 4409
	public struct TowerDefenceMapMark : IFlatbufferObject
	{
		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x0600DFDC RID: 57308 RVA: 0x00330319 File Offset: 0x0032E519
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DFDD RID: 57309 RVA: 0x00330326 File Offset: 0x0032E526
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DFDE RID: 57310 RVA: 0x00330330 File Offset: 0x0032E530
		public static TowerDefenceMapMark GetRootAsTowerDefenceMapMark(ByteBuffer _bb)
		{
			return TowerDefenceMapMark.GetRootAsTowerDefenceMapMark(_bb, default(TowerDefenceMapMark));
		}

		// Token: 0x0600DFDF RID: 57311 RVA: 0x0033034C File Offset: 0x0032E54C
		public static TowerDefenceMapMark GetRootAsTowerDefenceMapMark(ByteBuffer _bb, TowerDefenceMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DFE0 RID: 57312 RVA: 0x00330369 File Offset: 0x0032E569
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DFE1 RID: 57313 RVA: 0x00330378 File Offset: 0x0032E578
		public TowerDefenceMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AD0 RID: 15056
		// (get) Token: 0x0600DFE2 RID: 57314 RVA: 0x00330388 File Offset: 0x0032E588
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

		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x0600DFE3 RID: 57315 RVA: 0x003303C4 File Offset: 0x0032E5C4
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

		// Token: 0x0400527A RID: 21114
		private Table __p;
	}
}
