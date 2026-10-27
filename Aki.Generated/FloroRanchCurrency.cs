using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA7 RID: 3239
	public struct FloroRanchCurrency : IFlatbufferObject
	{
		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06007316 RID: 29462 RVA: 0x0023A7B0 File Offset: 0x002389B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x0023A7BD File Offset: 0x002389BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x0023A7C4 File Offset: 0x002389C4
		public static FloroRanchCurrency GetRootAsFloroRanchCurrency(ByteBuffer _bb)
		{
			return FloroRanchCurrency.GetRootAsFloroRanchCurrency(_bb, default(FloroRanchCurrency));
		}

		// Token: 0x06007319 RID: 29465 RVA: 0x0023A7E0 File Offset: 0x002389E0
		public static FloroRanchCurrency GetRootAsFloroRanchCurrency(ByteBuffer _bb, FloroRanchCurrency obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600731A RID: 29466 RVA: 0x0023A7FD File Offset: 0x002389FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x0023A80C File Offset: 0x00238A0C
		public FloroRanchCurrency __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x0600731C RID: 29468 RVA: 0x0023A81C File Offset: 0x00238A1C
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

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x0600731D RID: 29469 RVA: 0x0023A858 File Offset: 0x00238A58
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

		// Token: 0x0600731E RID: 29470 RVA: 0x0023A88F File Offset: 0x00238A8F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x0023A89E File Offset: 0x00238A9E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06007320 RID: 29472 RVA: 0x0023A8B8 File Offset: 0x00238AB8
		public string Desc
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

		// Token: 0x06007321 RID: 29473 RVA: 0x0023A8EF File Offset: 0x00238AEF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x0023A8FE File Offset: 0x00238AFE
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06007323 RID: 29475 RVA: 0x0023A918 File Offset: 0x00238B18
		public string Icon
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

		// Token: 0x06007324 RID: 29476 RVA: 0x0023A950 File Offset: 0x00238B50
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x0023A960 File Offset: 0x00238B60
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06007326 RID: 29478 RVA: 0x0023A978 File Offset: 0x00238B78
		public int RarityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06007327 RID: 29479 RVA: 0x0023A9B8 File Offset: 0x00238BB8
		public string SmallIcon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007328 RID: 29480 RVA: 0x0023A9F0 File Offset: 0x00238BF0
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007329 RID: 29481 RVA: 0x0023AA00 File Offset: 0x00238C00
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D09 RID: 19721
		private Table __p;
	}
}
