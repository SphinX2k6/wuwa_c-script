using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6A RID: 3946
	public struct NewOccupationConfig : IFlatbufferObject
	{
		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x0600A4BB RID: 42171 RVA: 0x002B9F5E File Offset: 0x002B815E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A4BC RID: 42172 RVA: 0x002B9F6B File Offset: 0x002B816B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A4BD RID: 42173 RVA: 0x002B9F74 File Offset: 0x002B8174
		public static NewOccupationConfig GetRootAsNewOccupationConfig(ByteBuffer _bb)
		{
			return NewOccupationConfig.GetRootAsNewOccupationConfig(_bb, default(NewOccupationConfig));
		}

		// Token: 0x0600A4BE RID: 42174 RVA: 0x002B9F90 File Offset: 0x002B8190
		public static NewOccupationConfig GetRootAsNewOccupationConfig(ByteBuffer _bb, NewOccupationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A4BF RID: 42175 RVA: 0x002B9FAD File Offset: 0x002B81AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A4C0 RID: 42176 RVA: 0x002B9FBC File Offset: 0x002B81BC
		public NewOccupationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x0600A4C1 RID: 42177 RVA: 0x002B9FCC File Offset: 0x002B81CC
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

		// Token: 0x0600A4C2 RID: 42178 RVA: 0x002BA003 File Offset: 0x002B8203
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x002BA012 File Offset: 0x002B8212
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x0600A4C4 RID: 42180 RVA: 0x002BA02C File Offset: 0x002B822C
		public string OccupationType
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

		// Token: 0x0600A4C5 RID: 42181 RVA: 0x002BA063 File Offset: 0x002B8263
		public Span<byte> GetOccupationTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A4C6 RID: 42182 RVA: 0x002BA072 File Offset: 0x002B8272
		public byte[] GetOccupationTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x0600A4C7 RID: 42183 RVA: 0x002BA08C File Offset: 0x002B828C
		public string OccupationData
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

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x002BA0C3 File Offset: 0x002B82C3
		public Span<byte> GetOccupationDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A4C9 RID: 42185 RVA: 0x002BA0D2 File Offset: 0x002B82D2
		public byte[] GetOccupationDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x0600A4CA RID: 42186 RVA: 0x002BA0EC File Offset: 0x002B82EC
		public string OccupationNameStringKey
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

		// Token: 0x0600A4CB RID: 42187 RVA: 0x002BA124 File Offset: 0x002B8324
		public Span<byte> GetOccupationNameStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A4CC RID: 42188 RVA: 0x002BA134 File Offset: 0x002B8334
		public byte[] GetOccupationNameStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005518 RID: 21784
		private Table __p;
	}
}
