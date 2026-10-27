using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8D RID: 3469
	public struct KingShipAttribute : IFlatbufferObject
	{
		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x060087AE RID: 34734 RVA: 0x00268F05 File Offset: 0x00267105
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060087AF RID: 34735 RVA: 0x00268F12 File Offset: 0x00267112
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x00268F1C File Offset: 0x0026711C
		public static KingShipAttribute GetRootAsKingShipAttribute(ByteBuffer _bb)
		{
			return KingShipAttribute.GetRootAsKingShipAttribute(_bb, default(KingShipAttribute));
		}

		// Token: 0x060087B1 RID: 34737 RVA: 0x00268F38 File Offset: 0x00267138
		public static KingShipAttribute GetRootAsKingShipAttribute(ByteBuffer _bb, KingShipAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060087B2 RID: 34738 RVA: 0x00268F55 File Offset: 0x00267155
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060087B3 RID: 34739 RVA: 0x00268F64 File Offset: 0x00267164
		public KingShipAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x060087B4 RID: 34740 RVA: 0x00268F74 File Offset: 0x00267174
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

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x060087B5 RID: 34741 RVA: 0x00268FB0 File Offset: 0x002671B0
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

		// Token: 0x060087B6 RID: 34742 RVA: 0x00268FE7 File Offset: 0x002671E7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060087B7 RID: 34743 RVA: 0x00268FF6 File Offset: 0x002671F6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x060087B8 RID: 34744 RVA: 0x00269010 File Offset: 0x00267210
		public string Icon
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

		// Token: 0x060087B9 RID: 34745 RVA: 0x00269047 File Offset: 0x00267247
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060087BA RID: 34746 RVA: 0x00269056 File Offset: 0x00267256
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x060087BB RID: 34747 RVA: 0x00269070 File Offset: 0x00267270
		public string DesText
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060087BC RID: 34748 RVA: 0x002690A8 File Offset: 0x002672A8
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060087BD RID: 34749 RVA: 0x002690B8 File Offset: 0x002672B8
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E19 RID: 19993
		private Table __p;
	}
}
