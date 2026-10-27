using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D3 RID: 4563
	public struct OneItemConfig : IFlatbufferObject
	{
		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x0600EAD2 RID: 60114 RVA: 0x00348C6D File Offset: 0x00346E6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAD3 RID: 60115 RVA: 0x00348C7A File Offset: 0x00346E7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAD4 RID: 60116 RVA: 0x00348C84 File Offset: 0x00346E84
		public static OneItemConfig GetRootAsOneItemConfig(ByteBuffer _bb)
		{
			return OneItemConfig.GetRootAsOneItemConfig(_bb, default(OneItemConfig));
		}

		// Token: 0x0600EAD5 RID: 60117 RVA: 0x00348CA0 File Offset: 0x00346EA0
		public static OneItemConfig GetRootAsOneItemConfig(ByteBuffer _bb, OneItemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EAD6 RID: 60118 RVA: 0x00348CBD File Offset: 0x00346EBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EAD7 RID: 60119 RVA: 0x00348CCC File Offset: 0x00346ECC
		public OneItemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EFF RID: 16127
		// (get) Token: 0x0600EAD8 RID: 60120 RVA: 0x00348CDC File Offset: 0x00346EDC
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

		// Token: 0x17003F00 RID: 16128
		// (get) Token: 0x0600EAD9 RID: 60121 RVA: 0x00348D18 File Offset: 0x00346F18
		public int Count
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

		// Token: 0x04005341 RID: 21313
		private Table __p;
	}
}
