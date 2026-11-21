using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E0 RID: 17120
	public struct IInformationSubTitle : IFlatbufferObject
	{
		// Token: 0x1700753C RID: 30012
		// (get) Token: 0x0601807F RID: 98431 RVA: 0x0036E00A File Offset: 0x0036C20A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018080 RID: 98432 RVA: 0x0036E017 File Offset: 0x0036C217
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018081 RID: 98433 RVA: 0x0036E020 File Offset: 0x0036C220
		public static IInformationSubTitle GetRootAsIInformationSubTitle(ByteBuffer _bb)
		{
			return IInformationSubTitle.GetRootAsIInformationSubTitle(_bb, default(IInformationSubTitle));
		}

		// Token: 0x06018082 RID: 98434 RVA: 0x0036E03C File Offset: 0x0036C23C
		public static IInformationSubTitle GetRootAsIInformationSubTitle(ByteBuffer _bb, IInformationSubTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018083 RID: 98435 RVA: 0x0036E059 File Offset: 0x0036C259
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018084 RID: 98436 RVA: 0x0036E068 File Offset: 0x0036C268
		public IInformationSubTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700753D RID: 30013
		// (get) Token: 0x06018085 RID: 98437 RVA: 0x0036E078 File Offset: 0x0036C278
		public string TidTitle
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

		// Token: 0x06018086 RID: 98438 RVA: 0x0036E0AF File Offset: 0x0036C2AF
		public Span<byte> GetTidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06018087 RID: 98439 RVA: 0x0036E0BE File Offset: 0x0036C2BE
		public byte[] GetTidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700753E RID: 30014
		// (get) Token: 0x06018088 RID: 98440 RVA: 0x0036E0CC File Offset: 0x0036C2CC
		public string TidContent
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

		// Token: 0x06018089 RID: 98441 RVA: 0x0036E103 File Offset: 0x0036C303
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601808A RID: 98442 RVA: 0x0036E112 File Offset: 0x0036C312
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601808B RID: 98443 RVA: 0x0036E120 File Offset: 0x0036C320
		public static Offset<IInformationSubTitle> CreateIInformationSubTitle(FlatBufferBuilder builder, StringOffset TidTitleOffset = default(StringOffset), StringOffset TidContentOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInformationSubTitle.AddTidContent(builder, TidContentOffset);
			IInformationSubTitle.AddTidTitle(builder, TidTitleOffset);
			return IInformationSubTitle.EndIInformationSubTitle(builder);
		}

		// Token: 0x0601808C RID: 98444 RVA: 0x0036E13D File Offset: 0x0036C33D
		public static void StartIInformationSubTitle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601808D RID: 98445 RVA: 0x0036E146 File Offset: 0x0036C346
		public static void AddTidTitle(FlatBufferBuilder builder, StringOffset tidTitleOffset)
		{
			builder.AddOffset(0, tidTitleOffset.Value, 0);
		}

		// Token: 0x0601808E RID: 98446 RVA: 0x0036E156 File Offset: 0x0036C356
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(1, tidContentOffset.Value, 0);
		}

		// Token: 0x0601808F RID: 98447 RVA: 0x0036E166 File Offset: 0x0036C366
		public static Offset<IInformationSubTitle> EndIInformationSubTitle(FlatBufferBuilder builder)
		{
			return new Offset<IInformationSubTitle>(builder.EndTable());
		}

		// Token: 0x06018090 RID: 98448 RVA: 0x0036E174 File Offset: 0x0036C374
		public IInformationSubTitleT UnPack()
		{
			IInformationSubTitleT informationSubTitleT = new IInformationSubTitleT();
			this.UnPackTo(informationSubTitleT);
			return informationSubTitleT;
		}

		// Token: 0x06018091 RID: 98449 RVA: 0x0036E18F File Offset: 0x0036C38F
		public void UnPackTo(IInformationSubTitleT _o)
		{
			_o.TidTitle = this.TidTitle;
			_o.TidContent = this.TidContent;
		}

		// Token: 0x06018092 RID: 98450 RVA: 0x0036E1AC File Offset: 0x0036C3AC
		public static Offset<IInformationSubTitle> Pack(FlatBufferBuilder builder, IInformationSubTitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationSubTitle>);
			}
			StringOffset tidTitleOffset = (_o.TidTitle == null) ? default(StringOffset) : builder.CreateString(_o.TidTitle);
			StringOffset tidContentOffset = (_o.TidContent == null) ? default(StringOffset) : builder.CreateString(_o.TidContent);
			return IInformationSubTitle.CreateIInformationSubTitle(builder, tidTitleOffset, tidContentOffset);
		}

		// Token: 0x0400C24A RID: 49738
		private Table __p;
	}
}
