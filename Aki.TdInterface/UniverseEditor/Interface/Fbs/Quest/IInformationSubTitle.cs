using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EA2 RID: 16034
	public struct IInformationSubTitle : IFlatbufferObject
	{
		// Token: 0x17006F4F RID: 28495
		// (get) Token: 0x06016A32 RID: 92722 RVA: 0x00345082 File Offset: 0x00343282
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A33 RID: 92723 RVA: 0x0034508F File Offset: 0x0034328F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A34 RID: 92724 RVA: 0x00345098 File Offset: 0x00343298
		public static IInformationSubTitle GetRootAsIInformationSubTitle(ByteBuffer _bb)
		{
			return IInformationSubTitle.GetRootAsIInformationSubTitle(_bb, default(IInformationSubTitle));
		}

		// Token: 0x06016A35 RID: 92725 RVA: 0x003450B4 File Offset: 0x003432B4
		public static IInformationSubTitle GetRootAsIInformationSubTitle(ByteBuffer _bb, IInformationSubTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A36 RID: 92726 RVA: 0x003450D1 File Offset: 0x003432D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A37 RID: 92727 RVA: 0x003450E0 File Offset: 0x003432E0
		public IInformationSubTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F50 RID: 28496
		// (get) Token: 0x06016A38 RID: 92728 RVA: 0x003450F0 File Offset: 0x003432F0
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

		// Token: 0x06016A39 RID: 92729 RVA: 0x00345127 File Offset: 0x00343327
		public Span<byte> GetTidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06016A3A RID: 92730 RVA: 0x00345136 File Offset: 0x00343336
		public byte[] GetTidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006F51 RID: 28497
		// (get) Token: 0x06016A3B RID: 92731 RVA: 0x00345144 File Offset: 0x00343344
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

		// Token: 0x06016A3C RID: 92732 RVA: 0x0034517B File Offset: 0x0034337B
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06016A3D RID: 92733 RVA: 0x0034518A File Offset: 0x0034338A
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06016A3E RID: 92734 RVA: 0x00345198 File Offset: 0x00343398
		public static Offset<IInformationSubTitle> CreateIInformationSubTitle(FlatBufferBuilder builder, StringOffset TidTitleOffset = default(StringOffset), StringOffset TidContentOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInformationSubTitle.AddTidContent(builder, TidContentOffset);
			IInformationSubTitle.AddTidTitle(builder, TidTitleOffset);
			return IInformationSubTitle.EndIInformationSubTitle(builder);
		}

		// Token: 0x06016A3F RID: 92735 RVA: 0x003451B5 File Offset: 0x003433B5
		public static void StartIInformationSubTitle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016A40 RID: 92736 RVA: 0x003451BE File Offset: 0x003433BE
		public static void AddTidTitle(FlatBufferBuilder builder, StringOffset tidTitleOffset)
		{
			builder.AddOffset(0, tidTitleOffset.Value, 0);
		}

		// Token: 0x06016A41 RID: 92737 RVA: 0x003451CE File Offset: 0x003433CE
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(1, tidContentOffset.Value, 0);
		}

		// Token: 0x06016A42 RID: 92738 RVA: 0x003451DE File Offset: 0x003433DE
		public static Offset<IInformationSubTitle> EndIInformationSubTitle(FlatBufferBuilder builder)
		{
			return new Offset<IInformationSubTitle>(builder.EndTable());
		}

		// Token: 0x06016A43 RID: 92739 RVA: 0x003451EC File Offset: 0x003433EC
		public IInformationSubTitleT UnPack()
		{
			IInformationSubTitleT informationSubTitleT = new IInformationSubTitleT();
			this.UnPackTo(informationSubTitleT);
			return informationSubTitleT;
		}

		// Token: 0x06016A44 RID: 92740 RVA: 0x00345207 File Offset: 0x00343407
		public void UnPackTo(IInformationSubTitleT _o)
		{
			_o.TidTitle = this.TidTitle;
			_o.TidContent = this.TidContent;
		}

		// Token: 0x06016A45 RID: 92741 RVA: 0x00345224 File Offset: 0x00343424
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

		// Token: 0x0400B86E RID: 47214
		private Table __p;
	}
}
