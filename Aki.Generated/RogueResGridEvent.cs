using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001008 RID: 4104
	public struct RogueResGridEvent : IFlatbufferObject
	{
		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x0600C2DC RID: 49884 RVA: 0x002ED4A8 File Offset: 0x002EB6A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C2DD RID: 49885 RVA: 0x002ED4B5 File Offset: 0x002EB6B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C2DE RID: 49886 RVA: 0x002ED4BC File Offset: 0x002EB6BC
		public static RogueResGridEvent GetRootAsRogueResGridEvent(ByteBuffer _bb)
		{
			return RogueResGridEvent.GetRootAsRogueResGridEvent(_bb, default(RogueResGridEvent));
		}

		// Token: 0x0600C2DF RID: 49887 RVA: 0x002ED4D8 File Offset: 0x002EB6D8
		public static RogueResGridEvent GetRootAsRogueResGridEvent(ByteBuffer _bb, RogueResGridEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C2E0 RID: 49888 RVA: 0x002ED4F5 File Offset: 0x002EB6F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C2E1 RID: 49889 RVA: 0x002ED504 File Offset: 0x002EB704
		public RogueResGridEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x0600C2E2 RID: 49890 RVA: 0x002ED514 File Offset: 0x002EB714
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

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x0600C2E3 RID: 49891 RVA: 0x002ED550 File Offset: 0x002EB750
		public int Plot
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

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x0600C2E4 RID: 49892 RVA: 0x002ED58C File Offset: 0x002EB78C
		public int ProgressType
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

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x0600C2E5 RID: 49893 RVA: 0x002ED5C8 File Offset: 0x002EB7C8
		public string CondText
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

		// Token: 0x0600C2E6 RID: 49894 RVA: 0x002ED600 File Offset: 0x002EB800
		public Span<byte> GetCondTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C2E7 RID: 49895 RVA: 0x002ED610 File Offset: 0x002EB810
		public byte[] GetCondTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x0600C2E8 RID: 49896 RVA: 0x002ED628 File Offset: 0x002EB828
		public int ShowType
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

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x0600C2E9 RID: 49897 RVA: 0x002ED668 File Offset: 0x002EB868
		public string Fx
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

		// Token: 0x0600C2EA RID: 49898 RVA: 0x002ED6A0 File Offset: 0x002EB8A0
		public Span<byte> GetFxBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C2EB RID: 49899 RVA: 0x002ED6B0 File Offset: 0x002EB8B0
		public byte[] GetFxArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x0600C2EC RID: 49900 RVA: 0x002ED6C8 File Offset: 0x002EB8C8
		public int Star
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

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x0600C2ED RID: 49901 RVA: 0x002ED708 File Offset: 0x002EB908
		public string Icon
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

		// Token: 0x0600C2EE RID: 49902 RVA: 0x002ED740 File Offset: 0x002EB940
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C2EF RID: 49903 RVA: 0x002ED750 File Offset: 0x002EB950
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x0600C2F0 RID: 49904 RVA: 0x002ED768 File Offset: 0x002EB968
		public string Title
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

		// Token: 0x0600C2F1 RID: 49905 RVA: 0x002ED7A0 File Offset: 0x002EB9A0
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C2F2 RID: 49906 RVA: 0x002ED7B0 File Offset: 0x002EB9B0
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x0600C2F3 RID: 49907 RVA: 0x002ED7C8 File Offset: 0x002EB9C8
		public string Desc
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

		// Token: 0x0600C2F4 RID: 49908 RVA: 0x002ED800 File Offset: 0x002EBA00
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C2F5 RID: 49909 RVA: 0x002ED810 File Offset: 0x002EBA10
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x0600C2F6 RID: 49910 RVA: 0x002ED828 File Offset: 0x002EBA28
		public int EventType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040050F0 RID: 20720
		private Table __p;
	}
}
