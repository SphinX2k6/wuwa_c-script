using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E49 RID: 3657
	public struct InfrItemQuality : IFlatbufferObject
	{
		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x0600894F RID: 35151 RVA: 0x0027CD11 File Offset: 0x0027AF11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008950 RID: 35152 RVA: 0x0027CD1E File Offset: 0x0027AF1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008951 RID: 35153 RVA: 0x0027CD28 File Offset: 0x0027AF28
		public static InfrItemQuality GetRootAsInfrItemQuality(ByteBuffer _bb)
		{
			return InfrItemQuality.GetRootAsInfrItemQuality(_bb, default(InfrItemQuality));
		}

		// Token: 0x06008952 RID: 35154 RVA: 0x0027CD44 File Offset: 0x0027AF44
		public static InfrItemQuality GetRootAsInfrItemQuality(ByteBuffer _bb, InfrItemQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008953 RID: 35155 RVA: 0x0027CD61 File Offset: 0x0027AF61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008954 RID: 35156 RVA: 0x0027CD70 File Offset: 0x0027AF70
		public InfrItemQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x06008955 RID: 35157 RVA: 0x0027CD80 File Offset: 0x0027AF80
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

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x06008956 RID: 35158 RVA: 0x0027CDBC File Offset: 0x0027AFBC
		public string Color
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

		// Token: 0x06008957 RID: 35159 RVA: 0x0027CDF3 File Offset: 0x0027AFF3
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008958 RID: 35160 RVA: 0x0027CE02 File Offset: 0x0027B002
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040053C8 RID: 21448
		private Table __p;
	}
}
