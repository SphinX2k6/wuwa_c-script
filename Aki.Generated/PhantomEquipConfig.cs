using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D4 RID: 4564
	public struct PhantomEquipConfig : IFlatbufferObject
	{
		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x0600EADA RID: 60122 RVA: 0x00348D54 File Offset: 0x00346F54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EADB RID: 60123 RVA: 0x00348D61 File Offset: 0x00346F61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EADC RID: 60124 RVA: 0x00348D68 File Offset: 0x00346F68
		public static PhantomEquipConfig GetRootAsPhantomEquipConfig(ByteBuffer _bb)
		{
			return PhantomEquipConfig.GetRootAsPhantomEquipConfig(_bb, default(PhantomEquipConfig));
		}

		// Token: 0x0600EADD RID: 60125 RVA: 0x00348D84 File Offset: 0x00346F84
		public static PhantomEquipConfig GetRootAsPhantomEquipConfig(ByteBuffer _bb, PhantomEquipConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EADE RID: 60126 RVA: 0x00348DA1 File Offset: 0x00346FA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EADF RID: 60127 RVA: 0x00348DB0 File Offset: 0x00346FB0
		public PhantomEquipConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x0600EAE0 RID: 60128 RVA: 0x00348DC0 File Offset: 0x00346FC0
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

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x0600EAE1 RID: 60129 RVA: 0x00348DFC File Offset: 0x00346FFC
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

		// Token: 0x04005342 RID: 21314
		private Table __p;
	}
}
