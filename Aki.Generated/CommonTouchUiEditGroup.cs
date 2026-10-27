using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B90 RID: 2960
	public struct CommonTouchUiEditGroup : IFlatbufferObject
	{
		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060057AE RID: 22446 RVA: 0x001FB444 File Offset: 0x001F9644
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x001FB451 File Offset: 0x001F9651
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x001FB458 File Offset: 0x001F9658
		public static CommonTouchUiEditGroup GetRootAsCommonTouchUiEditGroup(ByteBuffer _bb)
		{
			return CommonTouchUiEditGroup.GetRootAsCommonTouchUiEditGroup(_bb, default(CommonTouchUiEditGroup));
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x001FB474 File Offset: 0x001F9674
		public static CommonTouchUiEditGroup GetRootAsCommonTouchUiEditGroup(ByteBuffer _bb, CommonTouchUiEditGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x001FB491 File Offset: 0x001F9691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x001FB4A0 File Offset: 0x001F96A0
		public CommonTouchUiEditGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060057B4 RID: 22452 RVA: 0x001FB4B0 File Offset: 0x001F96B0
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

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060057B5 RID: 22453 RVA: 0x001FB4EC File Offset: 0x001F96EC
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

		// Token: 0x060057B6 RID: 22454 RVA: 0x001FB523 File Offset: 0x001F9723
		public Span<byte> GetBgTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x001FB532 File Offset: 0x001F9732
		public byte[] GetBgTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B9F RID: 19359
		private Table __p;
	}
}
