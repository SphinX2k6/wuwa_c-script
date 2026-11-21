using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E13 RID: 3603
	public struct HonamiStoryArea : IFlatbufferObject
	{
		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x060084FB RID: 34043 RVA: 0x00273A0C File Offset: 0x00271C0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060084FC RID: 34044 RVA: 0x00273A19 File Offset: 0x00271C19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060084FD RID: 34045 RVA: 0x00273A20 File Offset: 0x00271C20
		public static HonamiStoryArea GetRootAsHonamiStoryArea(ByteBuffer _bb)
		{
			return HonamiStoryArea.GetRootAsHonamiStoryArea(_bb, default(HonamiStoryArea));
		}

		// Token: 0x060084FE RID: 34046 RVA: 0x00273A3C File Offset: 0x00271C3C
		public static HonamiStoryArea GetRootAsHonamiStoryArea(ByteBuffer _bb, HonamiStoryArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060084FF RID: 34047 RVA: 0x00273A59 File Offset: 0x00271C59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008500 RID: 34048 RVA: 0x00273A68 File Offset: 0x00271C68
		public HonamiStoryArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06008501 RID: 34049 RVA: 0x00273A78 File Offset: 0x00271C78
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

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06008502 RID: 34050 RVA: 0x00273AB4 File Offset: 0x00271CB4
		public int ActivityId
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

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06008503 RID: 34051 RVA: 0x00273AF0 File Offset: 0x00271CF0
		public int Order
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

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06008504 RID: 34052 RVA: 0x00273B2C File Offset: 0x00271D2C
		public int MainBTId
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

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06008505 RID: 34053 RVA: 0x00273B6C File Offset: 0x00271D6C
		public int DangerLevel
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

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06008506 RID: 34054 RVA: 0x00273BAC File Offset: 0x00271DAC
		public int DropId
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

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06008507 RID: 34055 RVA: 0x00273BEC File Offset: 0x00271DEC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008508 RID: 34056 RVA: 0x00273C24 File Offset: 0x00271E24
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008509 RID: 34057 RVA: 0x00273C34 File Offset: 0x00271E34
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x0600850A RID: 34058 RVA: 0x00273C4C File Offset: 0x00271E4C
		public string LvSelectName
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600850B RID: 34059 RVA: 0x00273C84 File Offset: 0x00271E84
		public Span<byte> GetLvSelectNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600850C RID: 34060 RVA: 0x00273C94 File Offset: 0x00271E94
		public byte[] GetLvSelectNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x0600850D RID: 34061 RVA: 0x00273CAC File Offset: 0x00271EAC
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600850E RID: 34062 RVA: 0x00273CE4 File Offset: 0x00271EE4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600850F RID: 34063 RVA: 0x00273CF4 File Offset: 0x00271EF4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06008510 RID: 34064 RVA: 0x00273D0C File Offset: 0x00271F0C
		public string ToggleBgPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008511 RID: 34065 RVA: 0x00273D44 File Offset: 0x00271F44
		public Span<byte> GetToggleBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008512 RID: 34066 RVA: 0x00273D54 File Offset: 0x00271F54
		public byte[] GetToggleBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06008513 RID: 34067 RVA: 0x00273D6C File Offset: 0x00271F6C
		public string LvSelectBgPath
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008514 RID: 34068 RVA: 0x00273DA4 File Offset: 0x00271FA4
		public Span<byte> GetLvSelectBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008515 RID: 34069 RVA: 0x00273DB4 File Offset: 0x00271FB4
		public byte[] GetLvSelectBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06008516 RID: 34070 RVA: 0x00273DCC File Offset: 0x00271FCC
		public string UnLockTips
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008517 RID: 34071 RVA: 0x00273E04 File Offset: 0x00272004
		public Span<byte> GetUnLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008518 RID: 34072 RVA: 0x00273E14 File Offset: 0x00272014
		public byte[] GetUnLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06008519 RID: 34073 RVA: 0x00273E2C File Offset: 0x0027202C
		public bool IsNeedTips
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400538C RID: 21388
		private Table __p;
	}
}
