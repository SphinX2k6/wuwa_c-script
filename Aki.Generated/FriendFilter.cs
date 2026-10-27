using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCF RID: 3279
	public struct FriendFilter : IFlatbufferObject
	{
		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x060076DB RID: 30427 RVA: 0x002433BD File Offset: 0x002415BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x002433CA File Offset: 0x002415CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060076DD RID: 30429 RVA: 0x002433D4 File Offset: 0x002415D4
		public static FriendFilter GetRootAsFriendFilter(ByteBuffer _bb)
		{
			return FriendFilter.GetRootAsFriendFilter(_bb, default(FriendFilter));
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x002433F0 File Offset: 0x002415F0
		public static FriendFilter GetRootAsFriendFilter(ByteBuffer _bb, FriendFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x0024340D File Offset: 0x0024160D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x0024341C File Offset: 0x0024161C
		public FriendFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x060076E1 RID: 30433 RVA: 0x0024342C File Offset: 0x0024162C
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

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x060076E2 RID: 30434 RVA: 0x00243468 File Offset: 0x00241668
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

		// Token: 0x060076E3 RID: 30435 RVA: 0x0024349F File Offset: 0x0024169F
		public Span<byte> GetFilterBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060076E4 RID: 30436 RVA: 0x002434AE File Offset: 0x002416AE
		public byte[] GetFilterArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x060076E5 RID: 30437 RVA: 0x002434C8 File Offset: 0x002416C8
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

		// Token: 0x060076E6 RID: 30438 RVA: 0x002434FF File Offset: 0x002416FF
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060076E7 RID: 30439 RVA: 0x0024350E File Offset: 0x0024170E
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D3F RID: 19775
		private Table __p;
	}
}
