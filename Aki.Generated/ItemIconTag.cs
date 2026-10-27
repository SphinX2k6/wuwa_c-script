using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D80 RID: 3456
	public struct ItemIconTag : IFlatbufferObject
	{
		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x0600866D RID: 34413 RVA: 0x00265FED File Offset: 0x002641ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600866E RID: 34414 RVA: 0x00265FFA File Offset: 0x002641FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x00266004 File Offset: 0x00264204
		public static ItemIconTag GetRootAsItemIconTag(ByteBuffer _bb)
		{
			return ItemIconTag.GetRootAsItemIconTag(_bb, default(ItemIconTag));
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x00266020 File Offset: 0x00264220
		public static ItemIconTag GetRootAsItemIconTag(ByteBuffer _bb, ItemIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008671 RID: 34417 RVA: 0x0026603D File Offset: 0x0026423D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x0026604C File Offset: 0x0026424C
		public ItemIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06008673 RID: 34419 RVA: 0x0026605C File Offset: 0x0026425C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x00266093 File Offset: 0x00264293
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x002660A2 File Offset: 0x002642A2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06008676 RID: 34422 RVA: 0x002660BC File Offset: 0x002642BC
		public string ConfigParam
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

		// Token: 0x06008677 RID: 34423 RVA: 0x002660F3 File Offset: 0x002642F3
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x00266102 File Offset: 0x00264302
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E09 RID: 19977
		private Table __p;
	}
}
