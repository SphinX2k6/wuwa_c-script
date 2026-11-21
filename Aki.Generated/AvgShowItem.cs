using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF0 RID: 3056
	public struct AvgShowItem : IFlatbufferObject
	{
		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06004F43 RID: 20291 RVA: 0x001FA551 File Offset: 0x001F8751
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x001FA55E File Offset: 0x001F875E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x001FA568 File Offset: 0x001F8768
		public static AvgShowItem GetRootAsAvgShowItem(ByteBuffer _bb)
		{
			return AvgShowItem.GetRootAsAvgShowItem(_bb, default(AvgShowItem));
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x001FA584 File Offset: 0x001F8784
		public static AvgShowItem GetRootAsAvgShowItem(ByteBuffer _bb, AvgShowItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x001FA5A1 File Offset: 0x001F87A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x001FA5B0 File Offset: 0x001F87B0
		public AvgShowItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06004F49 RID: 20297 RVA: 0x001FA5C0 File Offset: 0x001F87C0
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

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06004F4A RID: 20298 RVA: 0x001FA5FC File Offset: 0x001F87FC
		public string Description
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

		// Token: 0x06004F4B RID: 20299 RVA: 0x001FA633 File Offset: 0x001F8833
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x001FA642 File Offset: 0x001F8842
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06004F4D RID: 20301 RVA: 0x001FA65C File Offset: 0x001F885C
		public string HeroinePicPath
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

		// Token: 0x06004F4E RID: 20302 RVA: 0x001FA693 File Offset: 0x001F8893
		public Span<byte> GetHeroinePicPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004F4F RID: 20303 RVA: 0x001FA6A2 File Offset: 0x001F88A2
		public byte[] GetHeroinePicPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06004F50 RID: 20304 RVA: 0x001FA6BC File Offset: 0x001F88BC
		public string HeroPicPath
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

		// Token: 0x06004F51 RID: 20305 RVA: 0x001FA6F4 File Offset: 0x001F88F4
		public Span<byte> GetHeroPicPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x001FA704 File Offset: 0x001F8904
		public byte[] GetHeroPicPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040050D8 RID: 20696
		private Table __p;
	}
}
