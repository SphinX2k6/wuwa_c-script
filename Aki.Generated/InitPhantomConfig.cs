using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011CA RID: 4554
	public struct InitPhantomConfig : IFlatbufferObject
	{
		// Token: 0x17003EE8 RID: 16104
		// (get) Token: 0x0600EA7F RID: 60031 RVA: 0x00348271 File Offset: 0x00346471
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA80 RID: 60032 RVA: 0x0034827E File Offset: 0x0034647E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA81 RID: 60033 RVA: 0x00348288 File Offset: 0x00346488
		public static InitPhantomConfig GetRootAsInitPhantomConfig(ByteBuffer _bb)
		{
			return InitPhantomConfig.GetRootAsInitPhantomConfig(_bb, default(InitPhantomConfig));
		}

		// Token: 0x0600EA82 RID: 60034 RVA: 0x003482A4 File Offset: 0x003464A4
		public static InitPhantomConfig GetRootAsInitPhantomConfig(ByteBuffer _bb, InitPhantomConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA83 RID: 60035 RVA: 0x003482C1 File Offset: 0x003464C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA84 RID: 60036 RVA: 0x003482D0 File Offset: 0x003464D0
		public InitPhantomConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EE9 RID: 16105
		// (get) Token: 0x0600EA85 RID: 60037 RVA: 0x003482E0 File Offset: 0x003464E0
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

		// Token: 0x17003EEA RID: 16106
		// (get) Token: 0x0600EA86 RID: 60038 RVA: 0x0034831C File Offset: 0x0034651C
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

		// Token: 0x17003EEB RID: 16107
		// (get) Token: 0x0600EA87 RID: 60039 RVA: 0x00348358 File Offset: 0x00346558
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

		// Token: 0x04005334 RID: 21300
		private Table __p;
	}
}
