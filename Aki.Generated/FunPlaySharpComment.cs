using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD6 RID: 3286
	public struct FunPlaySharpComment : IFlatbufferObject
	{
		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06007758 RID: 30552 RVA: 0x0024438C File Offset: 0x0024258C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00244399 File Offset: 0x00242599
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x002443A0 File Offset: 0x002425A0
		public static FunPlaySharpComment GetRootAsFunPlaySharpComment(ByteBuffer _bb)
		{
			return FunPlaySharpComment.GetRootAsFunPlaySharpComment(_bb, default(FunPlaySharpComment));
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x002443BC File Offset: 0x002425BC
		public static FunPlaySharpComment GetRootAsFunPlaySharpComment(ByteBuffer _bb, FunPlaySharpComment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x002443D9 File Offset: 0x002425D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x002443E8 File Offset: 0x002425E8
		public FunPlaySharpComment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x0600775E RID: 30558 RVA: 0x002443F8 File Offset: 0x002425F8
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

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x0600775F RID: 30559 RVA: 0x00244434 File Offset: 0x00242634
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

		// Token: 0x06007760 RID: 30560 RVA: 0x0024446B File Offset: 0x0024266B
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x0024447A File Offset: 0x0024267A
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06007762 RID: 30562 RVA: 0x00244494 File Offset: 0x00242694
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

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06007763 RID: 30563 RVA: 0x002444D0 File Offset: 0x002426D0
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

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06007764 RID: 30564 RVA: 0x00244510 File Offset: 0x00242710
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

		// Token: 0x06007765 RID: 30565 RVA: 0x00244548 File Offset: 0x00242748
		public Span<byte> GetPhotoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x00244558 File Offset: 0x00242758
		public byte[] GetPhotoPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06007767 RID: 30567 RVA: 0x00244570 File Offset: 0x00242770
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

		// Token: 0x06007768 RID: 30568 RVA: 0x002445A8 File Offset: 0x002427A8
		public Span<byte> GetRoleHeadPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x002445B8 File Offset: 0x002427B8
		public byte[] GetRoleHeadPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x0600776A RID: 30570 RVA: 0x002445D0 File Offset: 0x002427D0
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

		// Token: 0x0600776B RID: 30571 RVA: 0x00244608 File Offset: 0x00242808
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x00244618 File Offset: 0x00242818
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x0600776D RID: 30573 RVA: 0x00244630 File Offset: 0x00242830
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

		// Token: 0x0600776E RID: 30574 RVA: 0x00244668 File Offset: 0x00242868
		public Span<byte> GetCommentBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x00244678 File Offset: 0x00242878
		public byte[] GetCommentArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06007770 RID: 30576 RVA: 0x00244690 File Offset: 0x00242890
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

		// Token: 0x06007771 RID: 30577 RVA: 0x002446C8 File Offset: 0x002428C8
		public Span<byte> GetTimeTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x002446D8 File Offset: 0x002428D8
		public byte[] GetTimeTxtArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D46 RID: 19782
		private Table __p;
	}
}
