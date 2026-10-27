using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E5 RID: 28901
	public struct IShowMessage : IFlatbufferObject
	{
		// Token: 0x1700D6C6 RID: 54982
		// (get) Token: 0x06033347 RID: 209735 RVA: 0x006E714C File Offset: 0x006E534C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033348 RID: 209736 RVA: 0x006E7159 File Offset: 0x006E5359
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033349 RID: 209737 RVA: 0x006E7160 File Offset: 0x006E5360
		public static IShowMessage GetRootAsIShowMessage(ByteBuffer _bb)
		{
			return IShowMessage.GetRootAsIShowMessage(_bb, default(IShowMessage));
		}

		// Token: 0x0603334A RID: 209738 RVA: 0x006E717C File Offset: 0x006E537C
		public static IShowMessage GetRootAsIShowMessage(ByteBuffer _bb, IShowMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603334B RID: 209739 RVA: 0x006E7199 File Offset: 0x006E5399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603334C RID: 209740 RVA: 0x006E71A8 File Offset: 0x006E53A8
		public IShowMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6C7 RID: 54983
		// (get) Token: 0x0603334D RID: 209741 RVA: 0x006E71B8 File Offset: 0x006E53B8
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

		// Token: 0x0603334E RID: 209742 RVA: 0x006E71EF File Offset: 0x006E53EF
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603334F RID: 209743 RVA: 0x006E71FE File Offset: 0x006E53FE
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06033350 RID: 209744 RVA: 0x006E720C File Offset: 0x006E540C
		public static Offset<IShowMessage> CreateIShowMessage(FlatBufferBuilder builder, StringOffset ContentOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IShowMessage.AddContent(builder, ContentOffset);
			return IShowMessage.EndIShowMessage(builder);
		}

		// Token: 0x06033351 RID: 209745 RVA: 0x006E7222 File Offset: 0x006E5422
		public static void StartIShowMessage(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033352 RID: 209746 RVA: 0x006E722B File Offset: 0x006E542B
		public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset)
		{
			builder.AddOffset(0, contentOffset.Value, 0);
		}

		// Token: 0x06033353 RID: 209747 RVA: 0x006E723B File Offset: 0x006E543B
		public static Offset<IShowMessage> EndIShowMessage(FlatBufferBuilder builder)
		{
			return new Offset<IShowMessage>(builder.EndTable());
		}

		// Token: 0x06033354 RID: 209748 RVA: 0x006E7248 File Offset: 0x006E5448
		public IShowMessageT UnPack()
		{
			IShowMessageT showMessageT = new IShowMessageT();
			this.UnPackTo(showMessageT);
			return showMessageT;
		}

		// Token: 0x06033355 RID: 209749 RVA: 0x006E7263 File Offset: 0x006E5463
		public void UnPackTo(IShowMessageT _o)
		{
			_o.Content = this.Content;
		}

		// Token: 0x06033356 RID: 209750 RVA: 0x006E7274 File Offset: 0x006E5474
		public static Offset<IShowMessage> Pack(FlatBufferBuilder builder, IShowMessageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowMessage>);
			}
			StringOffset contentOffset = (_o.Content == null) ? default(StringOffset) : builder.CreateString(_o.Content);
			return IShowMessage.CreateIShowMessage(builder, contentOffset);
		}

		// Token: 0x04011B62 RID: 72546
		private Table __p;
	}
}
