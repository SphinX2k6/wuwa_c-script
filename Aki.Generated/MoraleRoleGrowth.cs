using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F11 RID: 3857
	public struct MoraleRoleGrowth : IFlatbufferObject
	{
		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x06009C95 RID: 40085 RVA: 0x002A83CE File Offset: 0x002A65CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C96 RID: 40086 RVA: 0x002A83DB File Offset: 0x002A65DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C97 RID: 40087 RVA: 0x002A83E4 File Offset: 0x002A65E4
		public static MoraleRoleGrowth GetRootAsMoraleRoleGrowth(ByteBuffer _bb)
		{
			return MoraleRoleGrowth.GetRootAsMoraleRoleGrowth(_bb, default(MoraleRoleGrowth));
		}

		// Token: 0x06009C98 RID: 40088 RVA: 0x002A8400 File Offset: 0x002A6600
		public static MoraleRoleGrowth GetRootAsMoraleRoleGrowth(ByteBuffer _bb, MoraleRoleGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C99 RID: 40089 RVA: 0x002A841D File Offset: 0x002A661D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C9A RID: 40090 RVA: 0x002A842C File Offset: 0x002A662C
		public MoraleRoleGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x06009C9B RID: 40091 RVA: 0x002A843C File Offset: 0x002A663C
		public int Level
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

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x06009C9C RID: 40092 RVA: 0x002A8478 File Offset: 0x002A6678
		public int LifeMaxRatio
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

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x06009C9D RID: 40093 RVA: 0x002A84B4 File Offset: 0x002A66B4
		public int AtkRatio
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

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x06009C9E RID: 40094 RVA: 0x002A84F0 File Offset: 0x002A66F0
		public int DefRatio
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

		// Token: 0x040054B6 RID: 21686
		private Table __p;
	}
}
