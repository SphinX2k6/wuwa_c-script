using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5F RID: 3679
	public struct Interjection : IFlatbufferObject
	{
		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06008C3F RID: 35903 RVA: 0x00283950 File Offset: 0x00281B50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C40 RID: 35904 RVA: 0x0028395D File Offset: 0x00281B5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C41 RID: 35905 RVA: 0x00283964 File Offset: 0x00281B64
		public static Interjection GetRootAsInterjection(ByteBuffer _bb)
		{
			return Interjection.GetRootAsInterjection(_bb, default(Interjection));
		}

		// Token: 0x06008C42 RID: 35906 RVA: 0x00283980 File Offset: 0x00281B80
		public static Interjection GetRootAsInterjection(ByteBuffer _bb, Interjection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C43 RID: 35907 RVA: 0x0028399D File Offset: 0x00281B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C44 RID: 35908 RVA: 0x002839AC File Offset: 0x00281BAC
		public Interjection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06008C45 RID: 35909 RVA: 0x002839BC File Offset: 0x00281BBC
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

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06008C46 RID: 35910 RVA: 0x002839F8 File Offset: 0x00281BF8
		public int TimberId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06008C47 RID: 35911 RVA: 0x00283A34 File Offset: 0x00281C34
		public int UniversalToneId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x06008C48 RID: 35912 RVA: 0x00283A70 File Offset: 0x00281C70
		public string AkEvent
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

		// Token: 0x06008C49 RID: 35913 RVA: 0x00283AA8 File Offset: 0x00281CA8
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008C4A RID: 35914 RVA: 0x00283AB8 File Offset: 0x00281CB8
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040053E7 RID: 21479
		private Table __p;
	}
}
