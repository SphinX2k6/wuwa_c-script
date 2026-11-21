using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C47 RID: 3143
	public struct Chat : IFlatbufferObject
	{
		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060058C2 RID: 22722 RVA: 0x00210914 File Offset: 0x0020EB14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x00210921 File Offset: 0x0020EB21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x00210928 File Offset: 0x0020EB28
		public static Chat GetRootAsChat(ByteBuffer _bb)
		{
			return Chat.GetRootAsChat(_bb, default(Chat));
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x00210944 File Offset: 0x0020EB44
		public static Chat GetRootAsChat(ByteBuffer _bb, Chat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00210961 File Offset: 0x0020EB61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x00210970 File Offset: 0x0020EB70
		public Chat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060058C8 RID: 22728 RVA: 0x00210980 File Offset: 0x0020EB80
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

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060058C9 RID: 22729 RVA: 0x002109BC File Offset: 0x0020EBBC
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

		// Token: 0x060058CA RID: 22730 RVA: 0x002109F3 File Offset: 0x0020EBF3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x00210A02 File Offset: 0x0020EC02
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060058CC RID: 22732 RVA: 0x00210A1C File Offset: 0x0020EC1C
		public int BuildLimit
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

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060058CD RID: 22733 RVA: 0x00210A58 File Offset: 0x0020EC58
		public int SaveMsgLimit
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

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060058CE RID: 22734 RVA: 0x00210A98 File Offset: 0x0020EC98
		public int LocalSaveMsgLimit
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

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060058CF RID: 22735 RVA: 0x00210AD8 File Offset: 0x0020ECD8
		public int SaveMsgTime
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

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060058D0 RID: 22736 RVA: 0x00210B18 File Offset: 0x0020ED18
		public int ChatCd
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

		// Token: 0x04005149 RID: 20809
		private Table __p;
	}
}
