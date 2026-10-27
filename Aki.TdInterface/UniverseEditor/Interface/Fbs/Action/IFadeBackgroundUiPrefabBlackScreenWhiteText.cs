using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006789 RID: 26505
	public struct IFadeBackgroundUiPrefabBlackScreenWhiteText : IFlatbufferObject
	{
		// Token: 0x1700C4B8 RID: 50360
		// (get) Token: 0x0602E1C9 RID: 188873 RVA: 0x0064C8A4 File Offset: 0x0064AAA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E1CA RID: 188874 RVA: 0x0064C8B1 File Offset: 0x0064AAB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E1CB RID: 188875 RVA: 0x0064C8B8 File Offset: 0x0064AAB8
		public static IFadeBackgroundUiPrefabBlackScreenWhiteText GetRootAsIFadeBackgroundUiPrefabBlackScreenWhiteText(ByteBuffer _bb)
		{
			return IFadeBackgroundUiPrefabBlackScreenWhiteText.GetRootAsIFadeBackgroundUiPrefabBlackScreenWhiteText(_bb, default(IFadeBackgroundUiPrefabBlackScreenWhiteText));
		}

		// Token: 0x0602E1CC RID: 188876 RVA: 0x0064C8D4 File Offset: 0x0064AAD4
		public static IFadeBackgroundUiPrefabBlackScreenWhiteText GetRootAsIFadeBackgroundUiPrefabBlackScreenWhiteText(ByteBuffer _bb, IFadeBackgroundUiPrefabBlackScreenWhiteText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E1CD RID: 188877 RVA: 0x0064C8F1 File Offset: 0x0064AAF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E1CE RID: 188878 RVA: 0x0064C900 File Offset: 0x0064AB00
		public IFadeBackgroundUiPrefabBlackScreenWhiteText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4B9 RID: 50361
		// (get) Token: 0x0602E1CF RID: 188879 RVA: 0x0064C910 File Offset: 0x0064AB10
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

		// Token: 0x1700C4BA RID: 50362
		// (get) Token: 0x0602E1D0 RID: 188880 RVA: 0x0064C94C File Offset: 0x0064AB4C
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

		// Token: 0x1700C4BB RID: 50363
		// (get) Token: 0x0602E1D1 RID: 188881 RVA: 0x0064C988 File Offset: 0x0064AB88
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

		// Token: 0x0602E1D2 RID: 188882 RVA: 0x0064C9BF File Offset: 0x0064ABBF
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602E1D3 RID: 188883 RVA: 0x0064C9CE File Offset: 0x0064ABCE
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C4BC RID: 50364
		// (get) Token: 0x0602E1D4 RID: 188884 RVA: 0x0064C9DC File Offset: 0x0064ABDC
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

		// Token: 0x0602E1D5 RID: 188885 RVA: 0x0064CA14 File Offset: 0x0064AC14
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602E1D6 RID: 188886 RVA: 0x0064CA24 File Offset: 0x0064AC24
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0602E1D7 RID: 188887 RVA: 0x0064CA33 File Offset: 0x0064AC33
		public static Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText> CreateIFadeBackgroundUiPrefabBlackScreenWhiteText(FlatBufferBuilder builder, EFadeBackgroundUiPrefabType Type = EFadeBackgroundUiPrefabType.BlackScreenWhiteText, EBlackScreenWhiteTextStartAnimName StartAnimName = EBlackScreenWhiteTextStartAnimName.Start01, StringOffset TextOffset = default(StringOffset), StringOffset AudioEventOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IFadeBackgroundUiPrefabBlackScreenWhiteText.AddAudioEvent(builder, AudioEventOffset);
			IFadeBackgroundUiPrefabBlackScreenWhiteText.AddText(builder, TextOffset);
			IFadeBackgroundUiPrefabBlackScreenWhiteText.AddStartAnimName(builder, StartAnimName);
			IFadeBackgroundUiPrefabBlackScreenWhiteText.AddType(builder, Type);
			return IFadeBackgroundUiPrefabBlackScreenWhiteText.EndIFadeBackgroundUiPrefabBlackScreenWhiteText(builder);
		}

		// Token: 0x0602E1D8 RID: 188888 RVA: 0x0064CA5F File Offset: 0x0064AC5F
		public static void StartIFadeBackgroundUiPrefabBlackScreenWhiteText(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E1D9 RID: 188889 RVA: 0x0064CA68 File Offset: 0x0064AC68
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundUiPrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E1DA RID: 188890 RVA: 0x0064CA73 File Offset: 0x0064AC73
		public static void AddStartAnimName(FlatBufferBuilder builder, EBlackScreenWhiteTextStartAnimName startAnimName)
		{
			builder.AddByte(1, (byte)startAnimName, 0);
		}

		// Token: 0x0602E1DB RID: 188891 RVA: 0x0064CA7E File Offset: 0x0064AC7E
		public static void AddText(FlatBufferBuilder builder, StringOffset textOffset)
		{
			builder.AddOffset(2, textOffset.Value, 0);
		}

		// Token: 0x0602E1DC RID: 188892 RVA: 0x0064CA8E File Offset: 0x0064AC8E
		public static void AddAudioEvent(FlatBufferBuilder builder, StringOffset audioEventOffset)
		{
			builder.AddOffset(3, audioEventOffset.Value, 0);
		}

		// Token: 0x0602E1DD RID: 188893 RVA: 0x0064CA9E File Offset: 0x0064AC9E
		public static Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText> EndIFadeBackgroundUiPrefabBlackScreenWhiteText(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundUiPrefabBlackScreenWhiteText>(builder.EndTable());
		}

		// Token: 0x0602E1DE RID: 188894 RVA: 0x0064CAAC File Offset: 0x0064ACAC
		public IFadeBackgroundUiPrefabBlackScreenWhiteTextT UnPack()
		{
			IFadeBackgroundUiPrefabBlackScreenWhiteTextT fadeBackgroundUiPrefabBlackScreenWhiteTextT = new IFadeBackgroundUiPrefabBlackScreenWhiteTextT();
			this.UnPackTo(fadeBackgroundUiPrefabBlackScreenWhiteTextT);
			return fadeBackgroundUiPrefabBlackScreenWhiteTextT;
		}

		// Token: 0x0602E1DF RID: 188895 RVA: 0x0064CAC7 File Offset: 0x0064ACC7
		public void UnPackTo(IFadeBackgroundUiPrefabBlackScreenWhiteTextT _o)
		{
			_o.Type = this.Type;
			_o.StartAnimName = this.StartAnimName;
			_o.Text = this.Text;
			_o.AudioEvent = this.AudioEvent;
		}

		// Token: 0x0602E1E0 RID: 188896 RVA: 0x0064CAFC File Offset: 0x0064ACFC
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

		// Token: 0x04010E8D RID: 69261
		private Table __p;
	}
}
