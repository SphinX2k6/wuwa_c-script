using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001300 RID: 4864
	public struct InitPhantomConfig : IFlatbufferObject
	{
		// Token: 0x1700424D RID: 16973
		// (get) Token: 0x0600F7F0 RID: 63472 RVA: 0x00372EDD File Offset: 0x003710DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F7F1 RID: 63473 RVA: 0x00372EEA File Offset: 0x003710EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F7F2 RID: 63474 RVA: 0x00372EF4 File Offset: 0x003710F4
		public static InitPhantomConfig GetRootAsInitPhantomConfig(ByteBuffer _bb)
		{
			return InitPhantomConfig.GetRootAsInitPhantomConfig(_bb, default(InitPhantomConfig));
		}

		// Token: 0x0600F7F3 RID: 63475 RVA: 0x00372F10 File Offset: 0x00371110
		public static InitPhantomConfig GetRootAsInitPhantomConfig(ByteBuffer _bb, InitPhantomConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F7F4 RID: 63476 RVA: 0x00372F2D File Offset: 0x0037112D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F7F5 RID: 63477 RVA: 0x00372F3C File Offset: 0x0037113C
		public InitPhantomConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700424E RID: 16974
		// (get) Token: 0x0600F7F6 RID: 63478 RVA: 0x00372F4C File Offset: 0x0037114C
		public int ItemId
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

		// Token: 0x1700424F RID: 16975
		// (get) Token: 0x0600F7F7 RID: 63479 RVA: 0x00372F88 File Offset: 0x00371188
		public int RandGroupId
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

		// Token: 0x17004250 RID: 16976
		// (get) Token: 0x0600F7F8 RID: 63480 RVA: 0x00372FC4 File Offset: 0x003711C4
		public int RandNum
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

		// Token: 0x04005977 RID: 22903
		private Table __p;
	}
}
