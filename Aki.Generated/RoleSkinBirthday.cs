using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001145 RID: 4421
	public struct RoleSkinBirthday : IFlatbufferObject
	{
		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600D173 RID: 53619 RVA: 0x0031C730 File Offset: 0x0031A930
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D174 RID: 53620 RVA: 0x0031C73D File Offset: 0x0031A93D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D175 RID: 53621 RVA: 0x0031C744 File Offset: 0x0031A944
		public static RoleSkinBirthday GetRootAsRoleSkinBirthday(ByteBuffer _bb)
		{
			return RoleSkinBirthday.GetRootAsRoleSkinBirthday(_bb, default(RoleSkinBirthday));
		}

		// Token: 0x0600D176 RID: 53622 RVA: 0x0031C760 File Offset: 0x0031A960
		public static RoleSkinBirthday GetRootAsRoleSkinBirthday(ByteBuffer _bb, RoleSkinBirthday obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D177 RID: 53623 RVA: 0x0031C77D File Offset: 0x0031A97D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D178 RID: 53624 RVA: 0x0031C78C File Offset: 0x0031A98C
		public RoleSkinBirthday __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600D179 RID: 53625 RVA: 0x0031C79C File Offset: 0x0031A99C
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

		// Token: 0x04005749 RID: 22345
		private Table __p;
	}
}
