using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001163 RID: 4451
	public struct TrapDefenseItem : IFlatbufferObject
	{
		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x0600E3A9 RID: 58281 RVA: 0x00338D39 File Offset: 0x00336F39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E3AA RID: 58282 RVA: 0x00338D46 File Offset: 0x00336F46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E3AB RID: 58283 RVA: 0x00338D50 File Offset: 0x00336F50
		public static TrapDefenseItem GetRootAsTrapDefenseItem(ByteBuffer _bb)
		{
			return TrapDefenseItem.GetRootAsTrapDefenseItem(_bb, default(TrapDefenseItem));
		}

		// Token: 0x0600E3AC RID: 58284 RVA: 0x00338D6C File Offset: 0x00336F6C
		public static TrapDefenseItem GetRootAsTrapDefenseItem(ByteBuffer _bb, TrapDefenseItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E3AD RID: 58285 RVA: 0x00338D89 File Offset: 0x00336F89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E3AE RID: 58286 RVA: 0x00338D98 File Offset: 0x00336F98
		public TrapDefenseItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x0600E3AF RID: 58287 RVA: 0x00338DA8 File Offset: 0x00336FA8
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

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x0600E3B0 RID: 58288 RVA: 0x00338DE4 File Offset: 0x00336FE4
		public int ExploreToolId
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

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x0600E3B1 RID: 58289 RVA: 0x00338E20 File Offset: 0x00337020
		public int ItemType
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

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x0600E3B2 RID: 58290 RVA: 0x00338E5C File Offset: 0x0033705C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E3B3 RID: 58291 RVA: 0x00338E94 File Offset: 0x00337094
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E3B4 RID: 58292 RVA: 0x00338EA4 File Offset: 0x003370A4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x0600E3B5 RID: 58293 RVA: 0x00338EBC File Offset: 0x003370BC
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E3B6 RID: 58294 RVA: 0x00338EF4 File Offset: 0x003370F4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E3B7 RID: 58295 RVA: 0x00338F04 File Offset: 0x00337104
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x0600E3B8 RID: 58296 RVA: 0x00338F1C File Offset: 0x0033711C
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E3B9 RID: 58297 RVA: 0x00338F54 File Offset: 0x00337154
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E3BA RID: 58298 RVA: 0x00338F64 File Offset: 0x00337164
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x0600E3BB RID: 58299 RVA: 0x00338F7C File Offset: 0x0033717C
		public int Quality
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

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x0600E3BC RID: 58300 RVA: 0x00338FBC File Offset: 0x003371BC
		public int SkillIndex
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x0600E3BD RID: 58301 RVA: 0x00338FFC File Offset: 0x003371FC
		public int CarryLimit
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 20;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x0600E3BE RID: 58302 RVA: 0x0033903C File Offset: 0x0033723C
		public int MaxCarryLimit
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 99;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052A9 RID: 21161
		private Table __p;
	}
}
