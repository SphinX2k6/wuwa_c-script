using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001299 RID: 4761
	public struct TrapDefenseItem : IFlatbufferObject
	{
		// Token: 0x17003F93 RID: 16275
		// (get) Token: 0x0600F117 RID: 61719 RVA: 0x00363D1D File Offset: 0x00361F1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F118 RID: 61720 RVA: 0x00363D2A File Offset: 0x00361F2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F119 RID: 61721 RVA: 0x00363D34 File Offset: 0x00361F34
		public static TrapDefenseItem GetRootAsTrapDefenseItem(ByteBuffer _bb)
		{
			return TrapDefenseItem.GetRootAsTrapDefenseItem(_bb, default(TrapDefenseItem));
		}

		// Token: 0x0600F11A RID: 61722 RVA: 0x00363D50 File Offset: 0x00361F50
		public static TrapDefenseItem GetRootAsTrapDefenseItem(ByteBuffer _bb, TrapDefenseItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F11B RID: 61723 RVA: 0x00363D6D File Offset: 0x00361F6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F11C RID: 61724 RVA: 0x00363D7C File Offset: 0x00361F7C
		public TrapDefenseItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F94 RID: 16276
		// (get) Token: 0x0600F11D RID: 61725 RVA: 0x00363D8C File Offset: 0x00361F8C
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

		// Token: 0x17003F95 RID: 16277
		// (get) Token: 0x0600F11E RID: 61726 RVA: 0x00363DC8 File Offset: 0x00361FC8
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

		// Token: 0x17003F96 RID: 16278
		// (get) Token: 0x0600F11F RID: 61727 RVA: 0x00363E04 File Offset: 0x00362004
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

		// Token: 0x17003F97 RID: 16279
		// (get) Token: 0x0600F120 RID: 61728 RVA: 0x00363E40 File Offset: 0x00362040
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

		// Token: 0x0600F121 RID: 61729 RVA: 0x00363E78 File Offset: 0x00362078
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F122 RID: 61730 RVA: 0x00363E88 File Offset: 0x00362088
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F98 RID: 16280
		// (get) Token: 0x0600F123 RID: 61731 RVA: 0x00363EA0 File Offset: 0x003620A0
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

		// Token: 0x0600F124 RID: 61732 RVA: 0x00363ED8 File Offset: 0x003620D8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600F125 RID: 61733 RVA: 0x00363EE8 File Offset: 0x003620E8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F99 RID: 16281
		// (get) Token: 0x0600F126 RID: 61734 RVA: 0x00363F00 File Offset: 0x00362100
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

		// Token: 0x0600F127 RID: 61735 RVA: 0x00363F38 File Offset: 0x00362138
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600F128 RID: 61736 RVA: 0x00363F48 File Offset: 0x00362148
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F9A RID: 16282
		// (get) Token: 0x0600F129 RID: 61737 RVA: 0x00363F60 File Offset: 0x00362160
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

		// Token: 0x17003F9B RID: 16283
		// (get) Token: 0x0600F12A RID: 61738 RVA: 0x00363FA0 File Offset: 0x003621A0
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

		// Token: 0x17003F9C RID: 16284
		// (get) Token: 0x0600F12B RID: 61739 RVA: 0x00363FE0 File Offset: 0x003621E0
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

		// Token: 0x17003F9D RID: 16285
		// (get) Token: 0x0600F12C RID: 61740 RVA: 0x00364020 File Offset: 0x00362220
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

		// Token: 0x040058EC RID: 22764
		private Table __p;
	}
}
