using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200128E RID: 4750
	public struct TrapDefenseBd : IFlatbufferObject
	{
		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x0600EFF3 RID: 61427 RVA: 0x003615F5 File Offset: 0x0035F7F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EFF4 RID: 61428 RVA: 0x00361602 File Offset: 0x0035F802
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EFF5 RID: 61429 RVA: 0x0036160C File Offset: 0x0035F80C
		public static TrapDefenseBd GetRootAsTrapDefenseBd(ByteBuffer _bb)
		{
			return TrapDefenseBd.GetRootAsTrapDefenseBd(_bb, default(TrapDefenseBd));
		}

		// Token: 0x0600EFF6 RID: 61430 RVA: 0x00361628 File Offset: 0x0035F828
		public static TrapDefenseBd GetRootAsTrapDefenseBd(ByteBuffer _bb, TrapDefenseBd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EFF7 RID: 61431 RVA: 0x00361645 File Offset: 0x0035F845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EFF8 RID: 61432 RVA: 0x00361654 File Offset: 0x0035F854
		public TrapDefenseBd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x0600EFF9 RID: 61433 RVA: 0x00361664 File Offset: 0x0035F864
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

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x0600EFFA RID: 61434 RVA: 0x003616A0 File Offset: 0x0035F8A0
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EFFB RID: 61435 RVA: 0x003616D7 File Offset: 0x0035F8D7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EFFC RID: 61436 RVA: 0x003616E6 File Offset: 0x0035F8E6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x0600EFFD RID: 61437 RVA: 0x00361700 File Offset: 0x0035F900
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EFFE RID: 61438 RVA: 0x00361737 File Offset: 0x0035F937
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EFFF RID: 61439 RVA: 0x00361746 File Offset: 0x0035F946
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x0600F000 RID: 61440 RVA: 0x00361760 File Offset: 0x0035F960
		public int PurpleBuffCount
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

		// Token: 0x17003F34 RID: 16180
		// (get) Token: 0x0600F001 RID: 61441 RVA: 0x003617A0 File Offset: 0x0035F9A0
		public int GoldBuffCount
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

		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x0600F002 RID: 61442 RVA: 0x003617E0 File Offset: 0x0035F9E0
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

		// Token: 0x0600F003 RID: 61443 RVA: 0x00361818 File Offset: 0x0035FA18
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600F004 RID: 61444 RVA: 0x00361828 File Offset: 0x0035FA28
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x0600F005 RID: 61445 RVA: 0x00361840 File Offset: 0x0035FA40
		public string SimpleDesc
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

		// Token: 0x0600F006 RID: 61446 RVA: 0x00361878 File Offset: 0x0035FA78
		public Span<byte> GetSimpleDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600F007 RID: 61447 RVA: 0x00361888 File Offset: 0x0035FA88
		public byte[] GetSimpleDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x0600F008 RID: 61448 RVA: 0x003618A0 File Offset: 0x0035FAA0
		public string IconSmall
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

		// Token: 0x0600F009 RID: 61449 RVA: 0x003618D8 File Offset: 0x0035FAD8
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600F00A RID: 61450 RVA: 0x003618E8 File Offset: 0x0035FAE8
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x040058E0 RID: 22752
		private Table __p;
	}
}
