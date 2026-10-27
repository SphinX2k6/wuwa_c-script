using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D5 RID: 4565
	public struct PhantomItemConfig : IFlatbufferObject
	{
		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x0600EAE2 RID: 60130 RVA: 0x00348E38 File Offset: 0x00347038
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAE3 RID: 60131 RVA: 0x00348E45 File Offset: 0x00347045
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAE4 RID: 60132 RVA: 0x00348E4C File Offset: 0x0034704C
		public static PhantomItemConfig GetRootAsPhantomItemConfig(ByteBuffer _bb)
		{
			return PhantomItemConfig.GetRootAsPhantomItemConfig(_bb, default(PhantomItemConfig));
		}

		// Token: 0x0600EAE5 RID: 60133 RVA: 0x00348E68 File Offset: 0x00347068
		public static PhantomItemConfig GetRootAsPhantomItemConfig(ByteBuffer _bb, PhantomItemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EAE6 RID: 60134 RVA: 0x00348E85 File Offset: 0x00347085
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EAE7 RID: 60135 RVA: 0x00348E94 File Offset: 0x00347094
		public PhantomItemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F05 RID: 16133
		// (get) Token: 0x0600EAE8 RID: 60136 RVA: 0x00348EA4 File Offset: 0x003470A4
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

		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x0600EAE9 RID: 60137 RVA: 0x00348EE0 File Offset: 0x003470E0
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

		// Token: 0x17003F07 RID: 16135
		// (get) Token: 0x0600EAEA RID: 60138 RVA: 0x00348F1C File Offset: 0x0034711C
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

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x0600EAEB RID: 60139 RVA: 0x00348F58 File Offset: 0x00347158
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

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x0600EAEC RID: 60140 RVA: 0x00348F98 File Offset: 0x00347198
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

		// Token: 0x17003F0A RID: 16138
		// (get) Token: 0x0600EAED RID: 60141 RVA: 0x00348FD8 File Offset: 0x003471D8
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

		// Token: 0x04005343 RID: 21315
		private Table __p;
	}
}
