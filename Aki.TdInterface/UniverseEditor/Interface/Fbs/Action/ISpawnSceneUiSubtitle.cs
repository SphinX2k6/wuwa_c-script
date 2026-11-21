using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200793E RID: 31038
	public struct ISpawnSceneUiSubtitle : IFlatbufferObject
	{
		// Token: 0x1700E3AC RID: 58284
		// (get) Token: 0x06036A91 RID: 223889 RVA: 0x007506FF File Offset: 0x0074E8FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A92 RID: 223890 RVA: 0x0075070C File Offset: 0x0074E90C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A93 RID: 223891 RVA: 0x00750714 File Offset: 0x0074E914
		public static ISpawnSceneUiSubtitle GetRootAsISpawnSceneUiSubtitle(ByteBuffer _bb)
		{
			return ISpawnSceneUiSubtitle.GetRootAsISpawnSceneUiSubtitle(_bb, default(ISpawnSceneUiSubtitle));
		}

		// Token: 0x06036A94 RID: 223892 RVA: 0x00750730 File Offset: 0x0074E930
		public static ISpawnSceneUiSubtitle GetRootAsISpawnSceneUiSubtitle(ByteBuffer _bb, ISpawnSceneUiSubtitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A95 RID: 223893 RVA: 0x0075074D File Offset: 0x0074E94D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A96 RID: 223894 RVA: 0x0075075C File Offset: 0x0074E95C
		public ISpawnSceneUiSubtitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3AD RID: 58285
		// (get) Token: 0x06036A97 RID: 223895 RVA: 0x0075076C File Offset: 0x0074E96C
		public ESceneUiSubtitleOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneUiSubtitleOperationType.Spawn;
				}
				return (ESceneUiSubtitleOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E3AE RID: 58286
		// (get) Token: 0x06036A98 RID: 223896 RVA: 0x007507A8 File Offset: 0x0074E9A8
		public string Mark
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

		// Token: 0x06036A99 RID: 223897 RVA: 0x007507DF File Offset: 0x0074E9DF
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036A9A RID: 223898 RVA: 0x007507EE File Offset: 0x0074E9EE
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E3AF RID: 58287
		// (get) Token: 0x06036A9B RID: 223899 RVA: 0x007507FC File Offset: 0x0074E9FC
		public TSceneUiSubtitleStyle StyleType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TSceneUiSubtitleStyle.NONE;
				}
				return (TSceneUiSubtitleStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036A9C RID: 223900 RVA: 0x00750838 File Offset: 0x0074EA38
		public TTable? Style<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036A9D RID: 223901 RVA: 0x00750880 File Offset: 0x0074EA80
		public ISceneUiSubtitleAppear StyleAsISceneUiSubtitleAppear()
		{
			return this.Style<ISceneUiSubtitleAppear>().Value;
		}

		// Token: 0x06036A9E RID: 223902 RVA: 0x0075089C File Offset: 0x0074EA9C
		public ISceneUiSubtitleScatter StyleAsISceneUiSubtitleScatter()
		{
			return this.Style<ISceneUiSubtitleScatter>().Value;
		}

		// Token: 0x1700E3B0 RID: 58288
		// (get) Token: 0x06036A9F RID: 223903 RVA: 0x007508B8 File Offset: 0x0074EAB8
		public TSceneUiSubtitleText TextType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TSceneUiSubtitleText.NONE;
				}
				return (TSceneUiSubtitleText)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036AA0 RID: 223904 RVA: 0x007508F8 File Offset: 0x0074EAF8
		public TTable? Text<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036AA1 RID: 223905 RVA: 0x00750940 File Offset: 0x0074EB40
		public ISceneUiSubtitleTextFlow TextAsISceneUiSubtitleTextFlow()
		{
			return this.Text<ISceneUiSubtitleTextFlow>().Value;
		}

		// Token: 0x06036AA2 RID: 223906 RVA: 0x0075095C File Offset: 0x0074EB5C
		public ISceneUiSubtitleTextKey TextAsISceneUiSubtitleTextKey()
		{
			return this.Text<ISceneUiSubtitleTextKey>().Value;
		}

		// Token: 0x1700E3B1 RID: 58289
		// (get) Token: 0x06036AA3 RID: 223907 RVA: 0x00750978 File Offset: 0x0074EB78
		public bool RemoveAfterPlay
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E3B2 RID: 58290
		// (get) Token: 0x06036AA4 RID: 223908 RVA: 0x007509B8 File Offset: 0x0074EBB8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036AA5 RID: 223909 RVA: 0x007509F8 File Offset: 0x0074EBF8
		public static Offset<ISpawnSceneUiSubtitle> CreateISpawnSceneUiSubtitle(FlatBufferBuilder builder, ESceneUiSubtitleOperationType Type = ESceneUiSubtitleOperationType.Spawn, StringOffset MarkOffset = default(StringOffset), TSceneUiSubtitleStyle Style_type = TSceneUiSubtitleStyle.NONE, int StyleOffset = 0, TSceneUiSubtitleText Text_type = TSceneUiSubtitleText.NONE, int TextOffset = 0, bool RemoveAfterPlay = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			ISpawnSceneUiSubtitle.AddText(builder, TextOffset);
			ISpawnSceneUiSubtitle.AddStyle(builder, StyleOffset);
			ISpawnSceneUiSubtitle.AddMark(builder, MarkOffset);
			ISpawnSceneUiSubtitle.AddNullMask(builder, NullMask);
			ISpawnSceneUiSubtitle.AddRemoveAfterPlay(builder, RemoveAfterPlay);
			ISpawnSceneUiSubtitle.AddTextType(builder, Text_type);
			ISpawnSceneUiSubtitle.AddStyleType(builder, Style_type);
			ISpawnSceneUiSubtitle.AddType(builder, Type);
			return ISpawnSceneUiSubtitle.EndISpawnSceneUiSubtitle(builder);
		}

		// Token: 0x06036AA6 RID: 223910 RVA: 0x00750A4F File Offset: 0x0074EC4F
		public static void StartISpawnSceneUiSubtitle(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06036AA7 RID: 223911 RVA: 0x00750A58 File Offset: 0x0074EC58
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitleOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036AA8 RID: 223912 RVA: 0x00750A63 File Offset: 0x0074EC63
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(1, markOffset.Value, 0);
		}

		// Token: 0x06036AA9 RID: 223913 RVA: 0x00750A73 File Offset: 0x0074EC73
		public static void AddStyleType(FlatBufferBuilder builder, TSceneUiSubtitleStyle styleType)
		{
			builder.AddByte(2, (byte)styleType, 0);
		}

		// Token: 0x06036AAA RID: 223914 RVA: 0x00750A7E File Offset: 0x0074EC7E
		public static void AddStyle(FlatBufferBuilder builder, int styleOffset)
		{
			builder.AddOffset(3, styleOffset, 0);
		}

		// Token: 0x06036AAB RID: 223915 RVA: 0x00750A89 File Offset: 0x0074EC89
		public static void AddTextType(FlatBufferBuilder builder, TSceneUiSubtitleText textType)
		{
			builder.AddByte(4, (byte)textType, 0);
		}

		// Token: 0x06036AAC RID: 223916 RVA: 0x00750A94 File Offset: 0x0074EC94
		public static void AddText(FlatBufferBuilder builder, int textOffset)
		{
			builder.AddOffset(5, textOffset, 0);
		}

		// Token: 0x06036AAD RID: 223917 RVA: 0x00750A9F File Offset: 0x0074EC9F
		public static void AddRemoveAfterPlay(FlatBufferBuilder builder, bool removeAfterPlay)
		{
			builder.AddBool(6, removeAfterPlay, false);
		}

		// Token: 0x06036AAE RID: 223918 RVA: 0x00750AAA File Offset: 0x0074ECAA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06036AAF RID: 223919 RVA: 0x00750AB5 File Offset: 0x0074ECB5
		public static Offset<ISpawnSceneUiSubtitle> EndISpawnSceneUiSubtitle(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnSceneUiSubtitle>(builder.EndTable());
		}

		// Token: 0x06036AB0 RID: 223920 RVA: 0x00750AC4 File Offset: 0x0074ECC4
		public ISpawnSceneUiSubtitleT UnPack()
		{
			ISpawnSceneUiSubtitleT spawnSceneUiSubtitleT = new ISpawnSceneUiSubtitleT();
			this.UnPackTo(spawnSceneUiSubtitleT);
			return spawnSceneUiSubtitleT;
		}

		// Token: 0x06036AB1 RID: 223921 RVA: 0x00750AE0 File Offset: 0x0074ECE0
		public void UnPackTo(ISpawnSceneUiSubtitleT _o)
		{
			_o.Type = this.Type;
			_o.Mark = this.Mark;
			_o.Style = new TSceneUiSubtitleStyleUnion();
			_o.Style.Type = this.StyleType;
			TSceneUiSubtitleStyle styleType = this.StyleType;
			if (styleType != TSceneUiSubtitleStyle.ISceneUiSubtitleAppear)
			{
				if (styleType == TSceneUiSubtitleStyle.ISceneUiSubtitleScatter)
				{
					_o.Style.Value = ((this.Style<ISceneUiSubtitleScatter>() != null) ? this.Style<ISceneUiSubtitleScatter>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Style.Value = ((this.Style<ISceneUiSubtitleAppear>() != null) ? this.Style<ISceneUiSubtitleAppear>().Value.UnPack() : null);
			}
			_o.Text = new TSceneUiSubtitleTextUnion();
			_o.Text.Type = this.TextType;
			TSceneUiSubtitleText textType = this.TextType;
			if (textType != TSceneUiSubtitleText.ISceneUiSubtitleTextFlow)
			{
				if (textType == TSceneUiSubtitleText.ISceneUiSubtitleTextKey)
				{
					_o.Text.Value = ((this.Text<ISceneUiSubtitleTextKey>() != null) ? this.Text<ISceneUiSubtitleTextKey>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Text.Value = ((this.Text<ISceneUiSubtitleTextFlow>() != null) ? this.Text<ISceneUiSubtitleTextFlow>().Value.UnPack() : null);
			}
			_o.RemoveAfterPlay = this.RemoveAfterPlay;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036AB2 RID: 223922 RVA: 0x00750C58 File Offset: 0x0074EE58
		public static Offset<ISpawnSceneUiSubtitle> Pack(FlatBufferBuilder builder, ISpawnSceneUiSubtitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnSceneUiSubtitle>);
			}
			StringOffset markOffset = (_o.Mark == null) ? default(StringOffset) : builder.CreateString(_o.Mark);
			TSceneUiSubtitleStyle style_type = (_o.Style == null) ? TSceneUiSubtitleStyle.NONE : _o.Style.Type;
			int styleOffset = (_o.Style == null) ? 0 : TSceneUiSubtitleStyleUnion.Pack(builder, _o.Style);
			TSceneUiSubtitleText text_type = (_o.Text == null) ? TSceneUiSubtitleText.NONE : _o.Text.Type;
			int textOffset = (_o.Text == null) ? 0 : TSceneUiSubtitleTextUnion.Pack(builder, _o.Text);
			return ISpawnSceneUiSubtitle.CreateISpawnSceneUiSubtitle(builder, _o.Type, markOffset, style_type, styleOffset, text_type, textOffset, _o.RemoveAfterPlay, _o.NullMask);
		}

		// Token: 0x04012C05 RID: 76805
		private Table __p;
	}
}
