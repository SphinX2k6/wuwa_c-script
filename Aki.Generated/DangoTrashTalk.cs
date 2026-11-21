using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC2 RID: 3266
	public struct DangoTrashTalk : IFlatbufferObject
	{
		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060066BB RID: 26299 RVA: 0x0022FF4D File Offset: 0x0022E14D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x0022FF5A File Offset: 0x0022E15A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x0022FF64 File Offset: 0x0022E164
		public static DangoTrashTalk GetRootAsDangoTrashTalk(ByteBuffer _bb)
		{
			return DangoTrashTalk.GetRootAsDangoTrashTalk(_bb, default(DangoTrashTalk));
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x0022FF80 File Offset: 0x0022E180
		public static DangoTrashTalk GetRootAsDangoTrashTalk(ByteBuffer _bb, DangoTrashTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x0022FF9D File Offset: 0x0022E19D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x0022FFAC File Offset: 0x0022E1AC
		public DangoTrashTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060066C1 RID: 26305 RVA: 0x0022FFBC File Offset: 0x0022E1BC
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

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060066C2 RID: 26306 RVA: 0x0022FFF8 File Offset: 0x0022E1F8
		public string Textkey
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

		// Token: 0x060066C3 RID: 26307 RVA: 0x0023002F File Offset: 0x0022E22F
		public Span<byte> GetTextkeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x0023003E File Offset: 0x0022E23E
		public byte[] GetTextkeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060066C5 RID: 26309 RVA: 0x00230058 File Offset: 0x0022E258
		public string AudioEvent
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

		// Token: 0x060066C6 RID: 26310 RVA: 0x0023008F File Offset: 0x0022E28F
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x0023009E File Offset: 0x0022E29E
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040051EF RID: 20975
		private Table __p;
	}
}
