using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1A RID: 3610
	public struct HonamiStoryEquip : IFlatbufferObject
	{
		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x0600858E RID: 34190 RVA: 0x00274EF5 File Offset: 0x002730F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600858F RID: 34191 RVA: 0x00274F02 File Offset: 0x00273102
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008590 RID: 34192 RVA: 0x00274F0C File Offset: 0x0027310C
		public static HonamiStoryEquip GetRootAsHonamiStoryEquip(ByteBuffer _bb)
		{
			return HonamiStoryEquip.GetRootAsHonamiStoryEquip(_bb, default(HonamiStoryEquip));
		}

		// Token: 0x06008591 RID: 34193 RVA: 0x00274F28 File Offset: 0x00273128
		public static HonamiStoryEquip GetRootAsHonamiStoryEquip(ByteBuffer _bb, HonamiStoryEquip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008592 RID: 34194 RVA: 0x00274F45 File Offset: 0x00273145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008593 RID: 34195 RVA: 0x00274F54 File Offset: 0x00273154
		public HonamiStoryEquip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06008594 RID: 34196 RVA: 0x00274F64 File Offset: 0x00273164
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

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06008595 RID: 34197 RVA: 0x00274FA0 File Offset: 0x002731A0
		public int EnhanceLevel
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

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06008596 RID: 34198 RVA: 0x00274FDC File Offset: 0x002731DC
		public int RoleId
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

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06008597 RID: 34199 RVA: 0x00275018 File Offset: 0x00273218
		public int RoleEnhanceLevel
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

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06008598 RID: 34200 RVA: 0x00275058 File Offset: 0x00273258
		public int Tag
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

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06008599 RID: 34201 RVA: 0x00275098 File Offset: 0x00273298
		public int TagEnhanceLevel
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

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x0600859A RID: 34202 RVA: 0x002750D8 File Offset: 0x002732D8
		public int GroupId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005394 RID: 21396
		private Table __p;
	}
}
