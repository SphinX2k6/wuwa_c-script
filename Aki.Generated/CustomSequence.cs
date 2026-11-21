using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C90 RID: 3216
	public struct CustomSequence : IFlatbufferObject
	{
		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06006087 RID: 24711 RVA: 0x00222542 File Offset: 0x00220742
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x0022254F File Offset: 0x0022074F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x00222558 File Offset: 0x00220758
		public static CustomSequence GetRootAsCustomSequence(ByteBuffer _bb)
		{
			return CustomSequence.GetRootAsCustomSequence(_bb, default(CustomSequence));
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x00222574 File Offset: 0x00220774
		public static CustomSequence GetRootAsCustomSequence(ByteBuffer _bb, CustomSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x00222591 File Offset: 0x00220791
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600608C RID: 24716 RVA: 0x002225A0 File Offset: 0x002207A0
		public CustomSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x0600608D RID: 24717 RVA: 0x002225B0 File Offset: 0x002207B0
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

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x0600608E RID: 24718 RVA: 0x002225EC File Offset: 0x002207EC
		public int Name
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

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x0600608F RID: 24719 RVA: 0x00222628 File Offset: 0x00220828
		public string SeqDataPath
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

		// Token: 0x06006090 RID: 24720 RVA: 0x0022265F File Offset: 0x0022085F
		public Span<byte> GetSeqDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x0022266E File Offset: 0x0022086E
		public byte[] GetSeqDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06006092 RID: 24722 RVA: 0x00222688 File Offset: 0x00220888
		public string BinderType
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

		// Token: 0x06006093 RID: 24723 RVA: 0x002226C0 File Offset: 0x002208C0
		public Span<byte> GetBinderTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x002226D0 File Offset: 0x002208D0
		public byte[] GetBinderTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040051B3 RID: 20915
		private Table __p;
	}
}
