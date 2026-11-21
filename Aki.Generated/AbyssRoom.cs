using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8C RID: 2956
	public struct AbyssRoom : IFlatbufferObject
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060046ED RID: 18157 RVA: 0x001E7E8C File Offset: 0x001E608C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x001E7E99 File Offset: 0x001E6099
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x001E7EA0 File Offset: 0x001E60A0
		public static AbyssRoom GetRootAsAbyssRoom(ByteBuffer _bb)
		{
			return AbyssRoom.GetRootAsAbyssRoom(_bb, default(AbyssRoom));
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x001E7EBC File Offset: 0x001E60BC
		public static AbyssRoom GetRootAsAbyssRoom(ByteBuffer _bb, AbyssRoom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x001E7ED9 File Offset: 0x001E60D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x001E7EE8 File Offset: 0x001E60E8
		public AbyssRoom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060046F3 RID: 18163 RVA: 0x001E7EF8 File Offset: 0x001E60F8
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060046F4 RID: 18164 RVA: 0x001E7F34 File Offset: 0x001E6134
		public int BehaviorTree
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

		// Token: 0x04005061 RID: 20577
		private Table __p;
	}
}
