using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200130B RID: 4875
	public struct PhantomEquipConfig : IFlatbufferObject
	{
		// Token: 0x17004269 RID: 17001
		// (get) Token: 0x0600F853 RID: 63571 RVA: 0x00373A44 File Offset: 0x00371C44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F854 RID: 63572 RVA: 0x00373A51 File Offset: 0x00371C51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F855 RID: 63573 RVA: 0x00373A58 File Offset: 0x00371C58
		public static PhantomEquipConfig GetRootAsPhantomEquipConfig(ByteBuffer _bb)
		{
			return PhantomEquipConfig.GetRootAsPhantomEquipConfig(_bb, default(PhantomEquipConfig));
		}

		// Token: 0x0600F856 RID: 63574 RVA: 0x00373A74 File Offset: 0x00371C74
		public static PhantomEquipConfig GetRootAsPhantomEquipConfig(ByteBuffer _bb, PhantomEquipConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F857 RID: 63575 RVA: 0x00373A91 File Offset: 0x00371C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F858 RID: 63576 RVA: 0x00373AA0 File Offset: 0x00371CA0
		public PhantomEquipConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700426A RID: 17002
		// (get) Token: 0x0600F859 RID: 63577 RVA: 0x00373AB0 File Offset: 0x00371CB0
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

		// Token: 0x1700426B RID: 17003
		// (get) Token: 0x0600F85A RID: 63578 RVA: 0x00373AEC File Offset: 0x00371CEC
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

		// Token: 0x04005986 RID: 22918
		private Table __p;
	}
}
