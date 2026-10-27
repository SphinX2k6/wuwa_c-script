using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001185 RID: 4485
	public struct UiPlayItem : IFlatbufferObject
	{
		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x0600E64C RID: 58956 RVA: 0x0033EC68 File Offset: 0x0033CE68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E64D RID: 58957 RVA: 0x0033EC75 File Offset: 0x0033CE75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E64E RID: 58958 RVA: 0x0033EC7C File Offset: 0x0033CE7C
		public static UiPlayItem GetRootAsUiPlayItem(ByteBuffer _bb)
		{
			return UiPlayItem.GetRootAsUiPlayItem(_bb, default(UiPlayItem));
		}

		// Token: 0x0600E64F RID: 58959 RVA: 0x0033EC98 File Offset: 0x0033CE98
		public static UiPlayItem GetRootAsUiPlayItem(ByteBuffer _bb, UiPlayItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E650 RID: 58960 RVA: 0x0033ECB5 File Offset: 0x0033CEB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E651 RID: 58961 RVA: 0x0033ECC4 File Offset: 0x0033CEC4
		public UiPlayItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x0600E652 RID: 58962 RVA: 0x0033ECD4 File Offset: 0x0033CED4
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

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x0600E653 RID: 58963 RVA: 0x0033ED10 File Offset: 0x0033CF10
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

		// Token: 0x0600E654 RID: 58964 RVA: 0x0033ED47 File Offset: 0x0033CF47
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E655 RID: 58965 RVA: 0x0033ED56 File Offset: 0x0033CF56
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x0600E656 RID: 58966 RVA: 0x0033ED70 File Offset: 0x0033CF70
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

		// Token: 0x0600E657 RID: 58967 RVA: 0x0033EDA7 File Offset: 0x0033CFA7
		public Span<byte> GetUiPlayKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E658 RID: 58968 RVA: 0x0033EDB6 File Offset: 0x0033CFB6
		public byte[] GetUiPlayKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x0600E659 RID: 58969 RVA: 0x0033EDD0 File Offset: 0x0033CFD0
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

		// Token: 0x040052CE RID: 21198
		private Table __p;
	}
}
