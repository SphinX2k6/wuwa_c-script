using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBA RID: 3514
	public struct FunPlaySharpComment : IFlatbufferObject
	{
		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06007D63 RID: 32099 RVA: 0x00262F28 File Offset: 0x00261128
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D64 RID: 32100 RVA: 0x00262F35 File Offset: 0x00261135
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D65 RID: 32101 RVA: 0x00262F3C File Offset: 0x0026113C
		public static FunPlaySharpComment GetRootAsFunPlaySharpComment(ByteBuffer _bb)
		{
			return FunPlaySharpComment.GetRootAsFunPlaySharpComment(_bb, default(FunPlaySharpComment));
		}

		// Token: 0x06007D66 RID: 32102 RVA: 0x00262F58 File Offset: 0x00261158
		public static FunPlaySharpComment GetRootAsFunPlaySharpComment(ByteBuffer _bb, FunPlaySharpComment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D67 RID: 32103 RVA: 0x00262F75 File Offset: 0x00261175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D68 RID: 32104 RVA: 0x00262F84 File Offset: 0x00261184
		public FunPlaySharpComment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06007D69 RID: 32105 RVA: 0x00262F94 File Offset: 0x00261194
		public int CommentId
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

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06007D6A RID: 32106 RVA: 0x00262FD0 File Offset: 0x002611D0
		public string VarName
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

		// Token: 0x06007D6B RID: 32107 RVA: 0x00263007 File Offset: 0x00261207
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x00263016 File Offset: 0x00261216
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06007D6D RID: 32109 RVA: 0x00263030 File Offset: 0x00261230
		public int VarState
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

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06007D6E RID: 32110 RVA: 0x0026306C File Offset: 0x0026126C
		public int VarPriority
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

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06007D6F RID: 32111 RVA: 0x002630AC File Offset: 0x002612AC
		public string PhotoPath
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

		// Token: 0x06007D70 RID: 32112 RVA: 0x002630E4 File Offset: 0x002612E4
		public Span<byte> GetPhotoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007D71 RID: 32113 RVA: 0x002630F4 File Offset: 0x002612F4
		public byte[] GetPhotoPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06007D72 RID: 32114 RVA: 0x0026310C File Offset: 0x0026130C
		public string RoleHeadPath
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

		// Token: 0x06007D73 RID: 32115 RVA: 0x00263144 File Offset: 0x00261344
		public Span<byte> GetRoleHeadPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007D74 RID: 32116 RVA: 0x00263154 File Offset: 0x00261354
		public byte[] GetRoleHeadPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06007D75 RID: 32117 RVA: 0x0026316C File Offset: 0x0026136C
		public string RoleName
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

		// Token: 0x06007D76 RID: 32118 RVA: 0x002631A4 File Offset: 0x002613A4
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007D77 RID: 32119 RVA: 0x002631B4 File Offset: 0x002613B4
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06007D78 RID: 32120 RVA: 0x002631CC File Offset: 0x002613CC
		public string Comment
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

		// Token: 0x06007D79 RID: 32121 RVA: 0x00263204 File Offset: 0x00261404
		public Span<byte> GetCommentBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007D7A RID: 32122 RVA: 0x00263214 File Offset: 0x00261414
		public byte[] GetCommentArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06007D7B RID: 32123 RVA: 0x0026322C File Offset: 0x0026142C
		public string TimeTxt
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

		// Token: 0x06007D7C RID: 32124 RVA: 0x00263264 File Offset: 0x00261464
		public Span<byte> GetTimeTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007D7D RID: 32125 RVA: 0x00263274 File Offset: 0x00261474
		public byte[] GetTimeTxtArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0400532A RID: 21290
		private Table __p;
	}
}
