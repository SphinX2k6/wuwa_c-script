using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012BB RID: 4795
	public struct UiPlayItem : IFlatbufferObject
	{
		// Token: 0x170040A1 RID: 16545
		// (get) Token: 0x0600F3BA RID: 62394 RVA: 0x00369A60 File Offset: 0x00367C60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F3BB RID: 62395 RVA: 0x00369A6D File Offset: 0x00367C6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F3BC RID: 62396 RVA: 0x00369A74 File Offset: 0x00367C74
		public static UiPlayItem GetRootAsUiPlayItem(ByteBuffer _bb)
		{
			return UiPlayItem.GetRootAsUiPlayItem(_bb, default(UiPlayItem));
		}

		// Token: 0x0600F3BD RID: 62397 RVA: 0x00369A90 File Offset: 0x00367C90
		public static UiPlayItem GetRootAsUiPlayItem(ByteBuffer _bb, UiPlayItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F3BE RID: 62398 RVA: 0x00369AAD File Offset: 0x00367CAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F3BF RID: 62399 RVA: 0x00369ABC File Offset: 0x00367CBC
		public UiPlayItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170040A2 RID: 16546
		// (get) Token: 0x0600F3C0 RID: 62400 RVA: 0x00369ACC File Offset: 0x00367CCC
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

		// Token: 0x170040A3 RID: 16547
		// (get) Token: 0x0600F3C1 RID: 62401 RVA: 0x00369B08 File Offset: 0x00367D08
		public string Type
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

		// Token: 0x0600F3C2 RID: 62402 RVA: 0x00369B3F File Offset: 0x00367D3F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F3C3 RID: 62403 RVA: 0x00369B4E File Offset: 0x00367D4E
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170040A4 RID: 16548
		// (get) Token: 0x0600F3C4 RID: 62404 RVA: 0x00369B68 File Offset: 0x00367D68
		public string UiPlayKey
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

		// Token: 0x0600F3C5 RID: 62405 RVA: 0x00369B9F File Offset: 0x00367D9F
		public Span<byte> GetUiPlayKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F3C6 RID: 62406 RVA: 0x00369BAE File Offset: 0x00367DAE
		public byte[] GetUiPlayKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170040A5 RID: 16549
		// (get) Token: 0x0600F3C7 RID: 62407 RVA: 0x00369BC8 File Offset: 0x00367DC8
		public int FinishItem
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

		// Token: 0x04005911 RID: 22801
		private Table __p;
	}
}
