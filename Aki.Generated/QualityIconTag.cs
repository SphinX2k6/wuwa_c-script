using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F62 RID: 3938
	public struct QualityIconTag : IFlatbufferObject
	{
		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x0600B400 RID: 46080 RVA: 0x002CCA8C File Offset: 0x002CAC8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B401 RID: 46081 RVA: 0x002CCA99 File Offset: 0x002CAC99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B402 RID: 46082 RVA: 0x002CCAA0 File Offset: 0x002CACA0
		public static QualityIconTag GetRootAsQualityIconTag(ByteBuffer _bb)
		{
			return QualityIconTag.GetRootAsQualityIconTag(_bb, default(QualityIconTag));
		}

		// Token: 0x0600B403 RID: 46083 RVA: 0x002CCABC File Offset: 0x002CACBC
		public static QualityIconTag GetRootAsQualityIconTag(ByteBuffer _bb, QualityIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B404 RID: 46084 RVA: 0x002CCAD9 File Offset: 0x002CACD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B405 RID: 46085 RVA: 0x002CCAE8 File Offset: 0x002CACE8
		public QualityIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x0600B406 RID: 46086 RVA: 0x002CCAF8 File Offset: 0x002CACF8
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

		// Token: 0x0600B407 RID: 46087 RVA: 0x002CCB2F File Offset: 0x002CAD2F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600B408 RID: 46088 RVA: 0x002CCB3E File Offset: 0x002CAD3E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x0600B409 RID: 46089 RVA: 0x002CCB58 File Offset: 0x002CAD58
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

		// Token: 0x0600B40A RID: 46090 RVA: 0x002CCB8F File Offset: 0x002CAD8F
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B40B RID: 46091 RVA: 0x002CCB9E File Offset: 0x002CAD9E
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005030 RID: 20528
		private Table __p;
	}
}
