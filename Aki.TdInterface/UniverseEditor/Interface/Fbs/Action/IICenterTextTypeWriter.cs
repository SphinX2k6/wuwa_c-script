using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006942 RID: 26946
	public struct IICenterTextTypeWriter : IFlatbufferObject
	{
		// Token: 0x1700C7EA RID: 51178
		// (get) Token: 0x0602F0CC RID: 192716 RVA: 0x00669D65 File Offset: 0x00667F65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F0CD RID: 192717 RVA: 0x00669D72 File Offset: 0x00667F72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F0CE RID: 192718 RVA: 0x00669D7C File Offset: 0x00667F7C
		public static IICenterTextTypeWriter GetRootAsIICenterTextTypeWriter(ByteBuffer _bb)
		{
			return IICenterTextTypeWriter.GetRootAsIICenterTextTypeWriter(_bb, default(IICenterTextTypeWriter));
		}

		// Token: 0x0602F0CF RID: 192719 RVA: 0x00669D98 File Offset: 0x00667F98
		public static IICenterTextTypeWriter GetRootAsIICenterTextTypeWriter(ByteBuffer _bb, IICenterTextTypeWriter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F0D0 RID: 192720 RVA: 0x00669DB5 File Offset: 0x00667FB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F0D1 RID: 192721 RVA: 0x00669DC4 File Offset: 0x00667FC4
		public IICenterTextTypeWriter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7EB RID: 51179
		// (get) Token: 0x0602F0D2 RID: 192722 RVA: 0x00669DD4 File Offset: 0x00667FD4
		public ECenterTextShowAnim Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECenterTextShowAnim.ShowAll;
				}
				return (ECenterTextShowAnim)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7EC RID: 51180
		// (get) Token: 0x0602F0D3 RID: 192723 RVA: 0x00669E10 File Offset: 0x00668010
		public int TextCountPerSecond
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

		// Token: 0x0602F0D4 RID: 192724 RVA: 0x00669E4C File Offset: 0x0066804C
		public static Offset<IICenterTextTypeWriter> CreateIICenterTextTypeWriter(FlatBufferBuilder builder, ECenterTextShowAnim Type = ECenterTextShowAnim.ShowAll, int TextCountPerSecond = 0)
		{
			builder.StartTable(2);
			IICenterTextTypeWriter.AddTextCountPerSecond(builder, TextCountPerSecond);
			IICenterTextTypeWriter.AddType(builder, Type);
			return IICenterTextTypeWriter.EndIICenterTextTypeWriter(builder);
		}

		// Token: 0x0602F0D5 RID: 192725 RVA: 0x00669E69 File Offset: 0x00668069
		public static void StartIICenterTextTypeWriter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F0D6 RID: 192726 RVA: 0x00669E72 File Offset: 0x00668072
		public static void AddType(FlatBufferBuilder builder, ECenterTextShowAnim type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F0D7 RID: 192727 RVA: 0x00669E7D File Offset: 0x0066807D
		public static void AddTextCountPerSecond(FlatBufferBuilder builder, int textCountPerSecond)
		{
			builder.AddInt(1, textCountPerSecond, 0);
		}

		// Token: 0x0602F0D8 RID: 192728 RVA: 0x00669E88 File Offset: 0x00668088
		public static Offset<IICenterTextTypeWriter> EndIICenterTextTypeWriter(FlatBufferBuilder builder)
		{
			return new Offset<IICenterTextTypeWriter>(builder.EndTable());
		}

		// Token: 0x0602F0D9 RID: 192729 RVA: 0x00669E98 File Offset: 0x00668098
		public IICenterTextTypeWriterT UnPack()
		{
			IICenterTextTypeWriterT iicenterTextTypeWriterT = new IICenterTextTypeWriterT();
			this.UnPackTo(iicenterTextTypeWriterT);
			return iicenterTextTypeWriterT;
		}

		// Token: 0x0602F0DA RID: 192730 RVA: 0x00669EB3 File Offset: 0x006680B3
		public void UnPackTo(IICenterTextTypeWriterT _o)
		{
			_o.Type = this.Type;
			_o.TextCountPerSecond = this.TextCountPerSecond;
		}

		// Token: 0x0602F0DB RID: 192731 RVA: 0x00669ED0 File Offset: 0x006680D0
		public static Offset<IICenterTextTypeWriter> Pack(FlatBufferBuilder builder, IICenterTextTypeWriterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IICenterTextTypeWriter>);
			}
			return IICenterTextTypeWriter.CreateIICenterTextTypeWriter(builder, _o.Type, _o.TextCountPerSecond);
		}

		// Token: 0x040110C0 RID: 69824
		private Table __p;
	}
}
