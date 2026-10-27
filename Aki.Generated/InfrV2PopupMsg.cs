using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6B RID: 3435
	public struct InfrV2PopupMsg : IFlatbufferObject
	{
		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x060083FD RID: 33789 RVA: 0x002603DC File Offset: 0x0025E5DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060083FE RID: 33790 RVA: 0x002603E9 File Offset: 0x0025E5E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060083FF RID: 33791 RVA: 0x002603F0 File Offset: 0x0025E5F0
		public static InfrV2PopupMsg GetRootAsInfrV2PopupMsg(ByteBuffer _bb)
		{
			return InfrV2PopupMsg.GetRootAsInfrV2PopupMsg(_bb, default(InfrV2PopupMsg));
		}

		// Token: 0x06008400 RID: 33792 RVA: 0x0026040C File Offset: 0x0025E60C
		public static InfrV2PopupMsg GetRootAsInfrV2PopupMsg(ByteBuffer _bb, InfrV2PopupMsg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008401 RID: 33793 RVA: 0x00260429 File Offset: 0x0025E629
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008402 RID: 33794 RVA: 0x00260438 File Offset: 0x0025E638
		public InfrV2PopupMsg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06008403 RID: 33795 RVA: 0x00260448 File Offset: 0x0025E648
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

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06008404 RID: 33796 RVA: 0x00260484 File Offset: 0x0025E684
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

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06008405 RID: 33797 RVA: 0x002604C0 File Offset: 0x0025E6C0
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

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06008406 RID: 33798 RVA: 0x002604FC File Offset: 0x0025E6FC
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

		// Token: 0x06008407 RID: 33799 RVA: 0x00260534 File Offset: 0x0025E734
		public Span<byte> GetHeadTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008408 RID: 33800 RVA: 0x00260544 File Offset: 0x0025E744
		public byte[] GetHeadTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06008409 RID: 33801 RVA: 0x0026055C File Offset: 0x0025E75C
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

		// Token: 0x0600840A RID: 33802 RVA: 0x00260594 File Offset: 0x0025E794
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600840B RID: 33803 RVA: 0x002605A4 File Offset: 0x0025E7A4
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DEE RID: 19950
		private Table __p;
	}
}
