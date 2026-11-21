using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F62 RID: 3938
	public struct NewbieCarnivalRole : IFlatbufferObject
	{
		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x0600A432 RID: 42034 RVA: 0x002B8DB4 File Offset: 0x002B6FB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A433 RID: 42035 RVA: 0x002B8DC1 File Offset: 0x002B6FC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A434 RID: 42036 RVA: 0x002B8DC8 File Offset: 0x002B6FC8
		public static NewbieCarnivalRole GetRootAsNewbieCarnivalRole(ByteBuffer _bb)
		{
			return NewbieCarnivalRole.GetRootAsNewbieCarnivalRole(_bb, default(NewbieCarnivalRole));
		}

		// Token: 0x0600A435 RID: 42037 RVA: 0x002B8DE4 File Offset: 0x002B6FE4
		public static NewbieCarnivalRole GetRootAsNewbieCarnivalRole(ByteBuffer _bb, NewbieCarnivalRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A436 RID: 42038 RVA: 0x002B8E01 File Offset: 0x002B7001
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A437 RID: 42039 RVA: 0x002B8E10 File Offset: 0x002B7010
		public NewbieCarnivalRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x0600A438 RID: 42040 RVA: 0x002B8E20 File Offset: 0x002B7020
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

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x0600A439 RID: 42041 RVA: 0x002B8E5C File Offset: 0x002B705C
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

		// Token: 0x0600A43A RID: 42042 RVA: 0x002B8E93 File Offset: 0x002B7093
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x002B8EA2 File Offset: 0x002B70A2
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x0600A43C RID: 42044 RVA: 0x002B8EBC File Offset: 0x002B70BC
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

		// Token: 0x0600A43D RID: 42045 RVA: 0x002B8EF3 File Offset: 0x002B70F3
		public Span<byte> GetCardBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x002B8F02 File Offset: 0x002B7102
		public byte[] GetCardArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x0600A43F RID: 42047 RVA: 0x002B8F1C File Offset: 0x002B711C
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

		// Token: 0x0600A440 RID: 42048 RVA: 0x002B8F54 File Offset: 0x002B7154
		public Span<byte> GetMainViewCardBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x002B8F64 File Offset: 0x002B7164
		public byte[] GetMainViewCardArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x0600A442 RID: 42050 RVA: 0x002B8F7C File Offset: 0x002B717C
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

		// Token: 0x0600A443 RID: 42051 RVA: 0x002B8FB4 File Offset: 0x002B71B4
		public Span<byte> GetMainViewSpineItemBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A444 RID: 42052 RVA: 0x002B8FC4 File Offset: 0x002B71C4
		public byte[] GetMainViewSpineItemArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x0600A445 RID: 42053 RVA: 0x002B8FDC File Offset: 0x002B71DC
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

		// Token: 0x0600A446 RID: 42054 RVA: 0x002B9014 File Offset: 0x002B7214
		public Span<byte> GetRoleViewSpineItemBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x002B9024 File Offset: 0x002B7224
		public byte[] GetRoleViewSpineItemArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x0600A448 RID: 42056 RVA: 0x002B903C File Offset: 0x002B723C
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

		// Token: 0x0600A449 RID: 42057 RVA: 0x002B9074 File Offset: 0x002B7274
		public Span<byte> GetHeadCardBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A44A RID: 42058 RVA: 0x002B9084 File Offset: 0x002B7284
		public byte[] GetHeadCardArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x0600A44B RID: 42059 RVA: 0x002B909C File Offset: 0x002B729C
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

		// Token: 0x04005510 RID: 21776
		private Table __p;
	}
}
