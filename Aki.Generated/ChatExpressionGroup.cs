using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6C RID: 2924
	public struct ChatExpressionGroup : IFlatbufferObject
	{
		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060053D1 RID: 21457 RVA: 0x001F2668 File Offset: 0x001F0868
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x001F2675 File Offset: 0x001F0875
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x001F267C File Offset: 0x001F087C
		public static ChatExpressionGroup GetRootAsChatExpressionGroup(ByteBuffer _bb)
		{
			return ChatExpressionGroup.GetRootAsChatExpressionGroup(_bb, default(ChatExpressionGroup));
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x001F2698 File Offset: 0x001F0898
		public static ChatExpressionGroup GetRootAsChatExpressionGroup(ByteBuffer _bb, ChatExpressionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x001F26B5 File Offset: 0x001F08B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x001F26C4 File Offset: 0x001F08C4
		public ChatExpressionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060053D7 RID: 21463 RVA: 0x001F26D4 File Offset: 0x001F08D4
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

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060053D8 RID: 21464 RVA: 0x001F2710 File Offset: 0x001F0910
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

		// Token: 0x060053D9 RID: 21465 RVA: 0x001F2747 File Offset: 0x001F0947
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x001F2756 File Offset: 0x001F0956
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060053DB RID: 21467 RVA: 0x001F2770 File Offset: 0x001F0970
		public string GroupTexturePath
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

		// Token: 0x060053DC RID: 21468 RVA: 0x001F27A7 File Offset: 0x001F09A7
		public Span<byte> GetGroupTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x001F27B6 File Offset: 0x001F09B6
		public byte[] GetGroupTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B6E RID: 19310
		private Table __p;
	}
}
