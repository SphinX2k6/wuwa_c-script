using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8C RID: 3980
	public struct OutAreaBorderConfig : IFlatbufferObject
	{
		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x0600A85B RID: 43099 RVA: 0x002C1F2C File Offset: 0x002C012C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A85C RID: 43100 RVA: 0x002C1F39 File Offset: 0x002C0139
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A85D RID: 43101 RVA: 0x002C1F40 File Offset: 0x002C0140
		public static OutAreaBorderConfig GetRootAsOutAreaBorderConfig(ByteBuffer _bb)
		{
			return OutAreaBorderConfig.GetRootAsOutAreaBorderConfig(_bb, default(OutAreaBorderConfig));
		}

		// Token: 0x0600A85E RID: 43102 RVA: 0x002C1F5C File Offset: 0x002C015C
		public static OutAreaBorderConfig GetRootAsOutAreaBorderConfig(ByteBuffer _bb, OutAreaBorderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A85F RID: 43103 RVA: 0x002C1F79 File Offset: 0x002C0179
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A860 RID: 43104 RVA: 0x002C1F88 File Offset: 0x002C0188
		public OutAreaBorderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x0600A861 RID: 43105 RVA: 0x002C1F98 File Offset: 0x002C0198
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

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x0600A862 RID: 43106 RVA: 0x002C1FD4 File Offset: 0x002C01D4
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

		// Token: 0x0600A863 RID: 43107 RVA: 0x002C200B File Offset: 0x002C020B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A864 RID: 43108 RVA: 0x002C201A File Offset: 0x002C021A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x0600A865 RID: 43109 RVA: 0x002C2034 File Offset: 0x002C0234
		public string Data
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

		// Token: 0x0600A866 RID: 43110 RVA: 0x002C206B File Offset: 0x002C026B
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A867 RID: 43111 RVA: 0x002C207A File Offset: 0x002C027A
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x0600A868 RID: 43112 RVA: 0x002C2094 File Offset: 0x002C0294
		public string TidTipText
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

		// Token: 0x0600A869 RID: 43113 RVA: 0x002C20CC File Offset: 0x002C02CC
		public Span<byte> GetTidTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A86A RID: 43114 RVA: 0x002C20DC File Offset: 0x002C02DC
		public byte[] GetTidTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005541 RID: 21825
		private Table __p;
	}
}
