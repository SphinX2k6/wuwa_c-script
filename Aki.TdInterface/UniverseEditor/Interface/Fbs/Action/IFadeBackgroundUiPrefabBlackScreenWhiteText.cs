using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E09 RID: 28169
	public struct IFadeBackgroundUiPrefabBlackScreenWhiteText : IFlatbufferObject
	{
		// Token: 0x1700CE6E RID: 52846
		// (get) Token: 0x06030A0F RID: 199183 RVA: 0x00699FE8 File Offset: 0x006981E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030A10 RID: 199184 RVA: 0x00699FF5 File Offset: 0x006981F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030A11 RID: 199185 RVA: 0x00699FFC File Offset: 0x006981FC
		public static IFadeBackgroundUiPrefabBlackScreenWhiteText GetRootAsIFadeBackgroundUiPrefabBlackScreenWhiteText(ByteBuffer _bb)
		{
			return IFadeBackgroundUiPrefabBlackScreenWhiteText.GetRootAsIFadeBackgroundUiPrefabBlackScreenWhiteText(_bb, default(IFadeBackgroundUiPrefabBlackScreenWhiteText));
		}

		// Token: 0x06030A12 RID: 199186 RVA: 0x0069A018 File Offset: 0x00698218
		public static IFadeBackgroundUiPrefabBlackScreenWhiteText GetRootAsIFadeBackgroundUiPrefabBlackScreenWhiteText(ByteBuffer _bb, IFadeBackgroundUiPrefabBlackScreenWhiteText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030A13 RID: 199187 RVA: 0x0069A035 File Offset: 0x00698235
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030A14 RID: 199188 RVA: 0x0069A044 File Offset: 0x00698244
		public IFadeBackgroundUiPrefabBlackScreenWhiteText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE6F RID: 52847
		// (get) Token: 0x06030A15 RID: 199189 RVA: 0x0069A054 File Offset: 0x00698254
		public EFadeBackgroundUiPrefabType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
				}
				return (EFadeBackgroundUiPrefabType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE70 RID: 52848
		// (get) Token: 0x06030A16 RID: 199190 RVA: 0x0069A090 File Offset: 0x00698290
		public EBlackScreenWhiteTextStartAnimName StartAnimName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EBlackScreenWhiteTextStartAnimName.Start01;
				}
				return (EBlackScreenWhiteTextStartAnimName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE71 RID: 52849
		// (get) Token: 0x06030A17 RID: 199191 RVA: 0x0069A0CC File Offset: 0x006982CC
		public string Text
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

		// Token: 0x06030A18 RID: 199192 RVA: 0x0069A103 File Offset: 0x00698303
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06030A19 RID: 199193 RVA: 0x0069A112 File Offset: 0x00698312
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700CE72 RID: 52850
		// (get) Token: 0x06030A1A RID: 199194 RVA: 0x0069A120 File Offset: 0x00698320
		public string AudioEvent
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

		// Token: 0x06030A1B RID: 199195 RVA: 0x0069A158 File Offset: 0x00698358
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06030A1C RID: 199196 RVA: 0x0069A168 File Offset: 0x00698368
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06030A1D RID: 199197 RVA: 0x0069A177 File Offset: 0x00698377
		public static Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText> CreateIFadeBackgroundUiPrefabBlackScreenWhiteText(FlatBufferBuilder builder, EFadeBackgroundUiPrefabType Type = EFadeBackgroundUiPrefabType.BlackScreenWhiteText, EBlackScreenWhiteTextStartAnimName StartAnimName = EBlackScreenWhiteTextStartAnimName.Start01, StringOffset TextOffset = default(StringOffset), StringOffset AudioEventOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IFadeBackgroundUiPrefabBlackScreenWhiteText.AddAudioEvent(builder, AudioEventOffset);
			IFadeBackgroundUiPrefabBlackScreenWhiteText.AddText(builder, TextOffset);
			IFadeBackgroundUiPrefabBlackScreenWhiteText.AddStartAnimName(builder, StartAnimName);
			IFadeBackgroundUiPrefabBlackScreenWhiteText.AddType(builder, Type);
			return IFadeBackgroundUiPrefabBlackScreenWhiteText.EndIFadeBackgroundUiPrefabBlackScreenWhiteText(builder);
		}

		// Token: 0x06030A1E RID: 199198 RVA: 0x0069A1A3 File Offset: 0x006983A3
		public static void StartIFadeBackgroundUiPrefabBlackScreenWhiteText(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030A1F RID: 199199 RVA: 0x0069A1AC File Offset: 0x006983AC
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundUiPrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030A20 RID: 199200 RVA: 0x0069A1B7 File Offset: 0x006983B7
		public static void AddStartAnimName(FlatBufferBuilder builder, EBlackScreenWhiteTextStartAnimName startAnimName)
		{
			builder.AddByte(1, (byte)startAnimName, 0);
		}

		// Token: 0x06030A21 RID: 199201 RVA: 0x0069A1C2 File Offset: 0x006983C2
		public static void AddText(FlatBufferBuilder builder, StringOffset textOffset)
		{
			builder.AddOffset(2, textOffset.Value, 0);
		}

		// Token: 0x06030A22 RID: 199202 RVA: 0x0069A1D2 File Offset: 0x006983D2
		public static void AddAudioEvent(FlatBufferBuilder builder, StringOffset audioEventOffset)
		{
			builder.AddOffset(3, audioEventOffset.Value, 0);
		}

		// Token: 0x06030A23 RID: 199203 RVA: 0x0069A1E2 File Offset: 0x006983E2
		public static Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText> EndIFadeBackgroundUiPrefabBlackScreenWhiteText(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText>(builder.EndTable());
		}

		// Token: 0x06030A24 RID: 199204 RVA: 0x0069A1F0 File Offset: 0x006983F0
		public IFadeBackgroundUiPrefabBlackScreenWhiteTextT UnPack()
		{
			IFadeBackgroundUiPrefabBlackScreenWhiteTextT fadeBackgroundUiPrefabBlackScreenWhiteTextT = new IFadeBackgroundUiPrefabBlackScreenWhiteTextT();
			this.UnPackTo(fadeBackgroundUiPrefabBlackScreenWhiteTextT);
			return fadeBackgroundUiPrefabBlackScreenWhiteTextT;
		}

		// Token: 0x06030A25 RID: 199205 RVA: 0x0069A20B File Offset: 0x0069840B
		public void UnPackTo(IFadeBackgroundUiPrefabBlackScreenWhiteTextT _o)
		{
			_o.Type = this.Type;
			_o.StartAnimName = this.StartAnimName;
			_o.Text = this.Text;
			_o.AudioEvent = this.AudioEvent;
		}

		// Token: 0x06030A26 RID: 199206 RVA: 0x0069A240 File Offset: 0x00698440
		public static Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText> Pack(FlatBufferBuilder builder, IFadeBackgroundUiPrefabBlackScreenWhiteTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText>);
			}
			StringOffset textOffset = (_o.Text == null) ? default(StringOffset) : builder.CreateString(_o.Text);
			StringOffset audioEventOffset = (_o.AudioEvent == null) ? default(StringOffset) : builder.CreateString(_o.AudioEvent);
			return IFadeBackgroundUiPrefabBlackScreenWhiteText.CreateIFadeBackgroundUiPrefabBlackScreenWhiteText(builder, _o.Type, _o.StartAnimName, textOffset, audioEventOffset);
		}

		// Token: 0x04011CBF RID: 72895
		private Table __p;
	}
}
