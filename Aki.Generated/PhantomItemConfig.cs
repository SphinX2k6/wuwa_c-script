using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200130C RID: 4876
	public struct PhantomItemConfig : IFlatbufferObject
	{
		// Token: 0x1700426C RID: 17004
		// (get) Token: 0x0600F85B RID: 63579 RVA: 0x00373B28 File Offset: 0x00371D28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F85C RID: 63580 RVA: 0x00373B35 File Offset: 0x00371D35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F85D RID: 63581 RVA: 0x00373B3C File Offset: 0x00371D3C
		public static PhantomItemConfig GetRootAsPhantomItemConfig(ByteBuffer _bb)
		{
			return PhantomItemConfig.GetRootAsPhantomItemConfig(_bb, default(PhantomItemConfig));
		}

		// Token: 0x0600F85E RID: 63582 RVA: 0x00373B58 File Offset: 0x00371D58
		public static PhantomItemConfig GetRootAsPhantomItemConfig(ByteBuffer _bb, PhantomItemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F85F RID: 63583 RVA: 0x00373B75 File Offset: 0x00371D75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F860 RID: 63584 RVA: 0x00373B84 File Offset: 0x00371D84
		public PhantomItemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700426D RID: 17005
		// (get) Token: 0x0600F861 RID: 63585 RVA: 0x00373B94 File Offset: 0x00371D94
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

		// Token: 0x1700426E RID: 17006
		// (get) Token: 0x0600F862 RID: 63586 RVA: 0x00373BD0 File Offset: 0x00371DD0
		public int Level
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

		// Token: 0x1700426F RID: 17007
		// (get) Token: 0x0600F863 RID: 63587 RVA: 0x00373C0C File Offset: 0x00371E0C
		public int MainType
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

		// Token: 0x17004270 RID: 17008
		// (get) Token: 0x0600F864 RID: 63588 RVA: 0x00373C48 File Offset: 0x00371E48
		public int MainVal
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

		// Token: 0x17004271 RID: 17009
		// (get) Token: 0x0600F865 RID: 63589 RVA: 0x00373C88 File Offset: 0x00371E88
		public int SubProperty
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

		// Token: 0x17004272 RID: 17010
		// (get) Token: 0x0600F866 RID: 63590 RVA: 0x00373CC8 File Offset: 0x00371EC8
		public int SubVal
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005987 RID: 22919
		private Table __p;
	}
}
