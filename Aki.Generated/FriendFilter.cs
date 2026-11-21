using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB3 RID: 3507
	public struct FriendFilter : IFlatbufferObject
	{
		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06007CE6 RID: 31974 RVA: 0x00261F98 File Offset: 0x00260198
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007CE7 RID: 31975 RVA: 0x00261FA5 File Offset: 0x002601A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007CE8 RID: 31976 RVA: 0x00261FAC File Offset: 0x002601AC
		public static FriendFilter GetRootAsFriendFilter(ByteBuffer _bb)
		{
			return FriendFilter.GetRootAsFriendFilter(_bb, default(FriendFilter));
		}

		// Token: 0x06007CE9 RID: 31977 RVA: 0x00261FC8 File Offset: 0x002601C8
		public static FriendFilter GetRootAsFriendFilter(ByteBuffer _bb, FriendFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007CEA RID: 31978 RVA: 0x00261FE5 File Offset: 0x002601E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007CEB RID: 31979 RVA: 0x00261FF4 File Offset: 0x002601F4
		public FriendFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06007CEC RID: 31980 RVA: 0x00262004 File Offset: 0x00260204
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

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06007CED RID: 31981 RVA: 0x00262040 File Offset: 0x00260240
		public string Filter
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

		// Token: 0x06007CEE RID: 31982 RVA: 0x00262077 File Offset: 0x00260277
		public Span<byte> GetFilterBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007CEF RID: 31983 RVA: 0x00262086 File Offset: 0x00260286
		public byte[] GetFilterArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06007CF0 RID: 31984 RVA: 0x002620A0 File Offset: 0x002602A0
		public string IconPath
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

		// Token: 0x06007CF1 RID: 31985 RVA: 0x002620D7 File Offset: 0x002602D7
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007CF2 RID: 31986 RVA: 0x002620E6 File Offset: 0x002602E6
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005323 RID: 21283
		private Table __p;
	}
}
