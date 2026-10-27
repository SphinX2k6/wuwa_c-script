using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8C RID: 2956
	public struct CommonBtData : IFlatbufferObject
	{
		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06005750 RID: 22352 RVA: 0x001FA709 File Offset: 0x001F8909
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x001FA716 File Offset: 0x001F8916
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x001FA720 File Offset: 0x001F8920
		public static CommonBtData GetRootAsCommonBtData(ByteBuffer _bb)
		{
			return CommonBtData.GetRootAsCommonBtData(_bb, default(CommonBtData));
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x001FA73C File Offset: 0x001F893C
		public static CommonBtData GetRootAsCommonBtData(ByteBuffer _bb, CommonBtData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x001FA759 File Offset: 0x001F8959
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x001FA768 File Offset: 0x001F8968
		public CommonBtData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x001FA778 File Offset: 0x001F8978
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

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06005757 RID: 22359 RVA: 0x001FA7B4 File Offset: 0x001F89B4
		public int LevelId
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

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06005758 RID: 22360 RVA: 0x001FA7F0 File Offset: 0x001F89F0
		public string RawData
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

		// Token: 0x06005759 RID: 22361 RVA: 0x001FA827 File Offset: 0x001F8A27
		public Span<byte> GetRawDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x001FA836 File Offset: 0x001F8A36
		public byte[] GetRawDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B9B RID: 19355
		private Table __p;
	}
}
