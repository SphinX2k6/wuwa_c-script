using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078B1 RID: 30897
	public struct IShowMessage : IFlatbufferObject
	{
		// Token: 0x1700E2A9 RID: 58025
		// (get) Token: 0x060365E9 RID: 222697 RVA: 0x00747758 File Offset: 0x00745958
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060365EA RID: 222698 RVA: 0x00747765 File Offset: 0x00745965
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060365EB RID: 222699 RVA: 0x0074776C File Offset: 0x0074596C
		public static IShowMessage GetRootAsIShowMessage(ByteBuffer _bb)
		{
			return IShowMessage.GetRootAsIShowMessage(_bb, default(IShowMessage));
		}

		// Token: 0x060365EC RID: 222700 RVA: 0x00747788 File Offset: 0x00745988
		public static IShowMessage GetRootAsIShowMessage(ByteBuffer _bb, IShowMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060365ED RID: 222701 RVA: 0x007477A5 File Offset: 0x007459A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060365EE RID: 222702 RVA: 0x007477B4 File Offset: 0x007459B4
		public IShowMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2AA RID: 58026
		// (get) Token: 0x060365EF RID: 222703 RVA: 0x007477C4 File Offset: 0x007459C4
		public string Content
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060365F0 RID: 222704 RVA: 0x007477FB File Offset: 0x007459FB
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060365F1 RID: 222705 RVA: 0x0074780A File Offset: 0x00745A0A
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060365F2 RID: 222706 RVA: 0x00747818 File Offset: 0x00745A18
		public static Offset<IShowMessage> CreateIShowMessage(FlatBufferBuilder builder, StringOffset ContentOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IShowMessage.AddContent(builder, ContentOffset);
			return IShowMessage.EndIShowMessage(builder);
		}

		// Token: 0x060365F3 RID: 222707 RVA: 0x0074782E File Offset: 0x00745A2E
		public static void StartIShowMessage(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060365F4 RID: 222708 RVA: 0x00747837 File Offset: 0x00745A37
		public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset)
		{
			builder.AddOffset(0, contentOffset.Value, 0);
		}

		// Token: 0x060365F5 RID: 222709 RVA: 0x00747847 File Offset: 0x00745A47
		public static Offset<IShowMessage> EndIShowMessage(FlatBufferBuilder builder)
		{
			return new Offset<IShowMessage>(builder.EndTable());
		}

		// Token: 0x060365F6 RID: 222710 RVA: 0x00747854 File Offset: 0x00745A54
		public IShowMessageT UnPack()
		{
			IShowMessageT showMessageT = new IShowMessageT();
			this.UnPackTo(showMessageT);
			return showMessageT;
		}

		// Token: 0x060365F7 RID: 222711 RVA: 0x0074786F File Offset: 0x00745A6F
		public void UnPackTo(IShowMessageT _o)
		{
			_o.Content = this.Content;
		}

		// Token: 0x060365F8 RID: 222712 RVA: 0x00747880 File Offset: 0x00745A80
		public static Offset<IShowMessage> Pack(FlatBufferBuilder builder, IShowMessageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowMessage>);
			}
			StringOffset contentOffset = (_o.Content == null) ? default(StringOffset) : builder.CreateString(_o.Content);
			return IShowMessage.CreateIShowMessage(builder, contentOffset);
		}

		// Token: 0x04012B50 RID: 76624
		private Table __p;
	}
}
