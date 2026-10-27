using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCE RID: 3022
	public struct DangoBrawlRewardTab : IFlatbufferObject
	{
		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06005F0B RID: 24331 RVA: 0x0020C791 File Offset: 0x0020A991
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x0020C79E File Offset: 0x0020A99E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x0020C7A8 File Offset: 0x0020A9A8
		public static DangoBrawlRewardTab GetRootAsDangoBrawlRewardTab(ByteBuffer _bb)
		{
			return DangoBrawlRewardTab.GetRootAsDangoBrawlRewardTab(_bb, default(DangoBrawlRewardTab));
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x0020C7C4 File Offset: 0x0020A9C4
		public static DangoBrawlRewardTab GetRootAsDangoBrawlRewardTab(ByteBuffer _bb, DangoBrawlRewardTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x0020C7E1 File Offset: 0x0020A9E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005F10 RID: 24336 RVA: 0x0020C7F0 File Offset: 0x0020A9F0
		public DangoBrawlRewardTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06005F11 RID: 24337 RVA: 0x0020C800 File Offset: 0x0020AA00
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

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06005F12 RID: 24338 RVA: 0x0020C83C File Offset: 0x0020AA3C
		public int ActivityId
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

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06005F13 RID: 24339 RVA: 0x0020C878 File Offset: 0x0020AA78
		public string Name
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

		// Token: 0x06005F14 RID: 24340 RVA: 0x0020C8AF File Offset: 0x0020AAAF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x0020C8BE File Offset: 0x0020AABE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BF8 RID: 19448
		private Table __p;
	}
}
