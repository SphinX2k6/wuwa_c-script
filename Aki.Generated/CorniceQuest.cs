using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8A RID: 3210
	public struct CorniceQuest : IFlatbufferObject
	{
		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06006022 RID: 24610 RVA: 0x00221896 File Offset: 0x0021FA96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x002218A3 File Offset: 0x0021FAA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x002218AC File Offset: 0x0021FAAC
		public static CorniceQuest GetRootAsCorniceQuest(ByteBuffer _bb)
		{
			return CorniceQuest.GetRootAsCorniceQuest(_bb, default(CorniceQuest));
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x002218C8 File Offset: 0x0021FAC8
		public static CorniceQuest GetRootAsCorniceQuest(ByteBuffer _bb, CorniceQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x002218E5 File Offset: 0x0021FAE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x002218F4 File Offset: 0x0021FAF4
		public CorniceQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06006028 RID: 24616 RVA: 0x00221904 File Offset: 0x0021FB04
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

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06006029 RID: 24617 RVA: 0x00221940 File Offset: 0x0021FB40
		public int QuestId
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

		// Token: 0x040051AD RID: 20909
		private Table __p;
	}
}
