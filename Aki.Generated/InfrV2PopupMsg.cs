using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E50 RID: 3664
	public struct InfrV2PopupMsg : IFlatbufferObject
	{
		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06008A17 RID: 35351 RVA: 0x0027EA14 File Offset: 0x0027CC14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008A18 RID: 35352 RVA: 0x0027EA21 File Offset: 0x0027CC21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008A19 RID: 35353 RVA: 0x0027EA28 File Offset: 0x0027CC28
		public static InfrV2PopupMsg GetRootAsInfrV2PopupMsg(ByteBuffer _bb)
		{
			return InfrV2PopupMsg.GetRootAsInfrV2PopupMsg(_bb, default(InfrV2PopupMsg));
		}

		// Token: 0x06008A1A RID: 35354 RVA: 0x0027EA44 File Offset: 0x0027CC44
		public static InfrV2PopupMsg GetRootAsInfrV2PopupMsg(ByteBuffer _bb, InfrV2PopupMsg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008A1B RID: 35355 RVA: 0x0027EA61 File Offset: 0x0027CC61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A1C RID: 35356 RVA: 0x0027EA70 File Offset: 0x0027CC70
		public InfrV2PopupMsg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x06008A1D RID: 35357 RVA: 0x0027EA80 File Offset: 0x0027CC80
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

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x06008A1E RID: 35358 RVA: 0x0027EABC File Offset: 0x0027CCBC
		public int Type
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

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06008A1F RID: 35359 RVA: 0x0027EAF8 File Offset: 0x0027CCF8
		public int TreeId
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

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06008A20 RID: 35360 RVA: 0x0027EB34 File Offset: 0x0027CD34
		public string HeadTexturePath
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

		// Token: 0x06008A21 RID: 35361 RVA: 0x0027EB6C File Offset: 0x0027CD6C
		public Span<byte> GetHeadTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008A22 RID: 35362 RVA: 0x0027EB7C File Offset: 0x0027CD7C
		public byte[] GetHeadTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06008A23 RID: 35363 RVA: 0x0027EB94 File Offset: 0x0027CD94
		public string Text
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008A24 RID: 35364 RVA: 0x0027EBCC File Offset: 0x0027CDCC
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008A25 RID: 35365 RVA: 0x0027EBDC File Offset: 0x0027CDDC
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040053D3 RID: 21459
		private Table __p;
	}
}
