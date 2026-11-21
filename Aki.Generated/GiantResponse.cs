using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE3 RID: 3555
	public struct GiantResponse : IFlatbufferObject
	{
		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x060080B5 RID: 32949 RVA: 0x0026A379 File Offset: 0x00268579
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x0026A386 File Offset: 0x00268586
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080B7 RID: 32951 RVA: 0x0026A390 File Offset: 0x00268590
		public static GiantResponse GetRootAsGiantResponse(ByteBuffer _bb)
		{
			return GiantResponse.GetRootAsGiantResponse(_bb, default(GiantResponse));
		}

		// Token: 0x060080B8 RID: 32952 RVA: 0x0026A3AC File Offset: 0x002685AC
		public static GiantResponse GetRootAsGiantResponse(ByteBuffer _bb, GiantResponse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080B9 RID: 32953 RVA: 0x0026A3C9 File Offset: 0x002685C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080BA RID: 32954 RVA: 0x0026A3D8 File Offset: 0x002685D8
		public GiantResponse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x060080BB RID: 32955 RVA: 0x0026A3E8 File Offset: 0x002685E8
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

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x060080BC RID: 32956 RVA: 0x0026A424 File Offset: 0x00268624
		public string Desc
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

		// Token: 0x060080BD RID: 32957 RVA: 0x0026A45B File Offset: 0x0026865B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060080BE RID: 32958 RVA: 0x0026A46A File Offset: 0x0026866A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x060080BF RID: 32959 RVA: 0x0026A484 File Offset: 0x00268684
		public string TriggerConditions
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

		// Token: 0x060080C0 RID: 32960 RVA: 0x0026A4BB File Offset: 0x002686BB
		public Span<byte> GetTriggerConditionsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060080C1 RID: 32961 RVA: 0x0026A4CA File Offset: 0x002686CA
		public byte[] GetTriggerConditionsArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x060080C2 RID: 32962 RVA: 0x0026A4E4 File Offset: 0x002686E4
		public string ResponseFunctions
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

		// Token: 0x060080C3 RID: 32963 RVA: 0x0026A51C File Offset: 0x0026871C
		public Span<byte> GetResponseFunctionsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060080C4 RID: 32964 RVA: 0x0026A52C File Offset: 0x0026872C
		public byte[] GetResponseFunctionsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005357 RID: 21335
		private Table __p;
	}
}
