using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF5 RID: 28661
	public struct IICenterTextTypeWriter : IFlatbufferObject
	{
		// Token: 0x1700D1ED RID: 53741
		// (get) Token: 0x06031A9C RID: 203420 RVA: 0x006BA24D File Offset: 0x006B844D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A9D RID: 203421 RVA: 0x006BA25A File Offset: 0x006B845A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A9E RID: 203422 RVA: 0x006BA264 File Offset: 0x006B8464
		public static IICenterTextTypeWriter GetRootAsIICenterTextTypeWriter(ByteBuffer _bb)
		{
			return IICenterTextTypeWriter.GetRootAsIICenterTextTypeWriter(_bb, default(IICenterTextTypeWriter));
		}

		// Token: 0x06031A9F RID: 203423 RVA: 0x006BA280 File Offset: 0x006B8480
		public static IICenterTextTypeWriter GetRootAsIICenterTextTypeWriter(ByteBuffer _bb, IICenterTextTypeWriter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031AA0 RID: 203424 RVA: 0x006BA29D File Offset: 0x006B849D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031AA1 RID: 203425 RVA: 0x006BA2AC File Offset: 0x006B84AC
		public IICenterTextTypeWriter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1EE RID: 53742
		// (get) Token: 0x06031AA2 RID: 203426 RVA: 0x006BA2BC File Offset: 0x006B84BC
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

		// Token: 0x1700D1EF RID: 53743
		// (get) Token: 0x06031AA3 RID: 203427 RVA: 0x006BA2F8 File Offset: 0x006B84F8
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

		// Token: 0x06031AA4 RID: 203428 RVA: 0x006BA334 File Offset: 0x006B8534
		public static Offset<IICenterTextTypeWriter> CreateIICenterTextTypeWriter(FlatBufferBuilder builder, ECenterTextShowAnim Type = ECenterTextShowAnim.ShowAll, int TextCountPerSecond = 0)
		{
			builder.StartTable(2);
			IICenterTextTypeWriter.AddTextCountPerSecond(builder, TextCountPerSecond);
			IICenterTextTypeWriter.AddType(builder, Type);
			return IICenterTextTypeWriter.EndIICenterTextTypeWriter(builder);
		}

		// Token: 0x06031AA5 RID: 203429 RVA: 0x006BA351 File Offset: 0x006B8551
		public static void StartIICenterTextTypeWriter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031AA6 RID: 203430 RVA: 0x006BA35A File Offset: 0x006B855A
		public static void AddType(FlatBufferBuilder builder, ECenterTextShowAnim type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031AA7 RID: 203431 RVA: 0x006BA365 File Offset: 0x006B8565
		public static void AddTextCountPerSecond(FlatBufferBuilder builder, int textCountPerSecond)
		{
			builder.AddInt(1, textCountPerSecond, 0);
		}

		// Token: 0x06031AA8 RID: 203432 RVA: 0x006BA370 File Offset: 0x006B8570
		public static Offset<IICenterTextTypeWriter> EndIICenterTextTypeWriter(FlatBufferBuilder builder)
		{
			return new Offset<IICenterTextTypeWriter>(builder.EndTable());
		}

		// Token: 0x06031AA9 RID: 203433 RVA: 0x006BA380 File Offset: 0x006B8580
		public IICenterTextTypeWriterT UnPack()
		{
			IICenterTextTypeWriterT iicenterTextTypeWriterT = new IICenterTextTypeWriterT();
			this.UnPackTo(iicenterTextTypeWriterT);
			return iicenterTextTypeWriterT;
		}

		// Token: 0x06031AAA RID: 203434 RVA: 0x006BA39B File Offset: 0x006B859B
		public void UnPackTo(IICenterTextTypeWriterT _o)
		{
			_o.Type = this.Type;
			_o.TextCountPerSecond = this.TextCountPerSecond;
		}

		// Token: 0x06031AAB RID: 203435 RVA: 0x006BA3B8 File Offset: 0x006B85B8
		public static Offset<IICenterTextTypeWriter> Pack(FlatBufferBuilder builder, IICenterTextTypeWriterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IICenterTextTypeWriter>);
			}
			return IICenterTextTypeWriter.CreateIICenterTextTypeWriter(builder, _o.Type, _o.TextCountPerSecond);
		}

		// Token: 0x04011F2C RID: 73516
		private Table __p;
	}
}
