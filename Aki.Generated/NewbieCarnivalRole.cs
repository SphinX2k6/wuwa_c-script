using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7D RID: 3709
	public struct NewbieCarnivalRole : IFlatbufferObject
	{
		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x06009E12 RID: 40466 RVA: 0x0029B6FD File Offset: 0x002998FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E13 RID: 40467 RVA: 0x0029B70A File Offset: 0x0029990A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E14 RID: 40468 RVA: 0x0029B714 File Offset: 0x00299914
		public static NewbieCarnivalRole GetRootAsNewbieCarnivalRole(ByteBuffer _bb)
		{
			return NewbieCarnivalRole.GetRootAsNewbieCarnivalRole(_bb, default(NewbieCarnivalRole));
		}

		// Token: 0x06009E15 RID: 40469 RVA: 0x0029B730 File Offset: 0x00299930
		public static NewbieCarnivalRole GetRootAsNewbieCarnivalRole(ByteBuffer _bb, NewbieCarnivalRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E16 RID: 40470 RVA: 0x0029B74D File Offset: 0x0029994D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E17 RID: 40471 RVA: 0x0029B75C File Offset: 0x0029995C
		public NewbieCarnivalRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x06009E18 RID: 40472 RVA: 0x0029B76C File Offset: 0x0029996C
		public int RoleId
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

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x06009E19 RID: 40473 RVA: 0x0029B7A8 File Offset: 0x002999A8
		public string DesText
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

		// Token: 0x06009E1A RID: 40474 RVA: 0x0029B7DF File Offset: 0x002999DF
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009E1B RID: 40475 RVA: 0x0029B7EE File Offset: 0x002999EE
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x06009E1C RID: 40476 RVA: 0x0029B808 File Offset: 0x00299A08
		public string Card
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

		// Token: 0x06009E1D RID: 40477 RVA: 0x0029B83F File Offset: 0x00299A3F
		public Span<byte> GetCardBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009E1E RID: 40478 RVA: 0x0029B84E File Offset: 0x00299A4E
		public byte[] GetCardArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x06009E1F RID: 40479 RVA: 0x0029B868 File Offset: 0x00299A68
		public string MainViewCard
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

		// Token: 0x06009E20 RID: 40480 RVA: 0x0029B8A0 File Offset: 0x00299AA0
		public Span<byte> GetMainViewCardBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009E21 RID: 40481 RVA: 0x0029B8B0 File Offset: 0x00299AB0
		public byte[] GetMainViewCardArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x06009E22 RID: 40482 RVA: 0x0029B8C8 File Offset: 0x00299AC8
		public string MainViewSpineItem
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

		// Token: 0x06009E23 RID: 40483 RVA: 0x0029B900 File Offset: 0x00299B00
		public Span<byte> GetMainViewSpineItemBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009E24 RID: 40484 RVA: 0x0029B910 File Offset: 0x00299B10
		public byte[] GetMainViewSpineItemArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x06009E25 RID: 40485 RVA: 0x0029B928 File Offset: 0x00299B28
		public string RoleViewSpineItem
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

		// Token: 0x06009E26 RID: 40486 RVA: 0x0029B960 File Offset: 0x00299B60
		public Span<byte> GetRoleViewSpineItemBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009E27 RID: 40487 RVA: 0x0029B970 File Offset: 0x00299B70
		public byte[] GetRoleViewSpineItemArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x06009E28 RID: 40488 RVA: 0x0029B988 File Offset: 0x00299B88
		public string HeadCard
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

		// Token: 0x06009E29 RID: 40489 RVA: 0x0029B9C0 File Offset: 0x00299BC0
		public Span<byte> GetHeadCardBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009E2A RID: 40490 RVA: 0x0029B9D0 File Offset: 0x00299BD0
		public byte[] GetHeadCardArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x06009E2B RID: 40491 RVA: 0x0029B9E8 File Offset: 0x00299BE8
		public int TrialRoleId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004F2B RID: 20267
		private Table __p;
	}
}
