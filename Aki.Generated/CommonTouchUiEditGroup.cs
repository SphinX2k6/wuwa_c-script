using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C72 RID: 3186
	public struct CommonTouchUiEditGroup : IFlatbufferObject
	{
		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06005D87 RID: 23943 RVA: 0x0021B23C File Offset: 0x0021943C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x0021B249 File Offset: 0x00219449
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x0021B250 File Offset: 0x00219450
		public static CommonTouchUiEditGroup GetRootAsCommonTouchUiEditGroup(ByteBuffer _bb)
		{
			return CommonTouchUiEditGroup.GetRootAsCommonTouchUiEditGroup(_bb, default(CommonTouchUiEditGroup));
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x0021B26C File Offset: 0x0021946C
		public static CommonTouchUiEditGroup GetRootAsCommonTouchUiEditGroup(ByteBuffer _bb, CommonTouchUiEditGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x0021B289 File Offset: 0x00219489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x0021B298 File Offset: 0x00219498
		public CommonTouchUiEditGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06005D8D RID: 23949 RVA: 0x0021B2A8 File Offset: 0x002194A8
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

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06005D8E RID: 23950 RVA: 0x0021B2E4 File Offset: 0x002194E4
		public string BgTexturePath
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

		// Token: 0x06005D8F RID: 23951 RVA: 0x0021B31B File Offset: 0x0021951B
		public Span<byte> GetBgTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x0021B32A File Offset: 0x0021952A
		public byte[] GetBgTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005181 RID: 20865
		private Table __p;
	}
}
