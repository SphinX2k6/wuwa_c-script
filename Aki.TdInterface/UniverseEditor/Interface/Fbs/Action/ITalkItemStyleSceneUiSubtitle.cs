using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ADC RID: 31452
	public struct ITalkItemStyleSceneUiSubtitle : IFlatbufferObject
	{
		// Token: 0x1700E9C0 RID: 59840
		// (get) Token: 0x06038316 RID: 230166 RVA: 0x0078FE2D File Offset: 0x0078E02D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038317 RID: 230167 RVA: 0x0078FE3A File Offset: 0x0078E03A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038318 RID: 230168 RVA: 0x0078FE44 File Offset: 0x0078E044
		public static ITalkItemStyleSceneUiSubtitle GetRootAsITalkItemStyleSceneUiSubtitle(ByteBuffer _bb)
		{
			return ITalkItemStyleSceneUiSubtitle.GetRootAsITalkItemStyleSceneUiSubtitle(_bb, default(ITalkItemStyleSceneUiSubtitle));
		}

		// Token: 0x06038319 RID: 230169 RVA: 0x0078FE60 File Offset: 0x0078E060
		public static ITalkItemStyleSceneUiSubtitle GetRootAsITalkItemStyleSceneUiSubtitle(ByteBuffer _bb, ITalkItemStyleSceneUiSubtitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603831A RID: 230170 RVA: 0x0078FE7D File Offset: 0x0078E07D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603831B RID: 230171 RVA: 0x0078FE8C File Offset: 0x0078E08C
		public ITalkItemStyleSceneUiSubtitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E9C1 RID: 59841
		// (get) Token: 0x0603831C RID: 230172 RVA: 0x0078FE9C File Offset: 0x0078E09C
		public ETalkItemStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkItemStyle.InnerVoice;
				}
				return (ETalkItemStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E9C2 RID: 59842
		// (get) Token: 0x0603831D RID: 230173 RVA: 0x0078FED8 File Offset: 0x0078E0D8
		public TSceneUiSubtitleStyle StyleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSceneUiSubtitleStyle.NONE;
				}
				return (TSceneUiSubtitleStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603831E RID: 230174 RVA: 0x0078FF14 File Offset: 0x0078E114
		public TTable? Style<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603831F RID: 230175 RVA: 0x0078FF58 File Offset: 0x0078E158
		public ISceneUiSubtitleAppear StyleAsISceneUiSubtitleAppear()
		{
			return this.Style<ISceneUiSubtitleAppear>().Value;
		}

		// Token: 0x06038320 RID: 230176 RVA: 0x0078FF74 File Offset: 0x0078E174
		public ISceneUiSubtitleScatter StyleAsISceneUiSubtitleScatter()
		{
			return this.Style<ISceneUiSubtitleScatter>().Value;
		}

		// Token: 0x06038321 RID: 230177 RVA: 0x0078FF8F File Offset: 0x0078E18F
		public static Offset<ITalkItemStyleSceneUiSubtitle> CreateITalkItemStyleSceneUiSubtitle(FlatBufferBuilder builder, ETalkItemStyle Type = ETalkItemStyle.InnerVoice, TSceneUiSubtitleStyle Style_type = TSceneUiSubtitleStyle.NONE, int StyleOffset = 0)
		{
			builder.StartTable(3);
			ITalkItemStyleSceneUiSubtitle.AddStyle(builder, StyleOffset);
			ITalkItemStyleSceneUiSubtitle.AddStyleType(builder, Style_type);
			ITalkItemStyleSceneUiSubtitle.AddType(builder, Type);
			return ITalkItemStyleSceneUiSubtitle.EndITalkItemStyleSceneUiSubtitle(builder);
		}

		// Token: 0x06038322 RID: 230178 RVA: 0x0078FFB3 File Offset: 0x0078E1B3
		public static void StartITalkItemStyleSceneUiSubtitle(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06038323 RID: 230179 RVA: 0x0078FFBC File Offset: 0x0078E1BC
		public static void AddType(FlatBufferBuilder builder, ETalkItemStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038324 RID: 230180 RVA: 0x0078FFC7 File Offset: 0x0078E1C7
		public static void AddStyleType(FlatBufferBuilder builder, TSceneUiSubtitleStyle styleType)
		{
			builder.AddByte(1, (byte)styleType, 0);
		}

		// Token: 0x06038325 RID: 230181 RVA: 0x0078FFD2 File Offset: 0x0078E1D2
		public static void AddStyle(FlatBufferBuilder builder, int styleOffset)
		{
			builder.AddOffset(2, styleOffset, 0);
		}

		// Token: 0x06038326 RID: 230182 RVA: 0x0078FFDD File Offset: 0x0078E1DD
		public static Offset<ITalkItemStyleSceneUiSubtitle> EndITalkItemStyleSceneUiSubtitle(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemStyleSceneUiSubtitle>(builder.EndTable());
		}

		// Token: 0x06038327 RID: 230183 RVA: 0x0078FFEC File Offset: 0x0078E1EC
		public ITalkItemStyleSceneUiSubtitleT UnPack()
		{
			ITalkItemStyleSceneUiSubtitleT talkItemStyleSceneUiSubtitleT = new ITalkItemStyleSceneUiSubtitleT();
			this.UnPackTo(talkItemStyleSceneUiSubtitleT);
			return talkItemStyleSceneUiSubtitleT;
		}

		// Token: 0x06038328 RID: 230184 RVA: 0x00790008 File Offset: 0x0078E208
		public void UnPackTo(ITalkItemStyleSceneUiSubtitleT _o)
		{
			_o.Type = this.Type;
			_o.Style = new TSceneUiSubtitleStyleUnion();
			_o.Style.Type = this.StyleType;
			TSceneUiSubtitleStyle styleType = this.StyleType;
			if (styleType == TSceneUiSubtitleStyle.ISceneUiSubtitleAppear)
			{
				_o.Style.Value = ((this.Style<ISceneUiSubtitleAppear>() != null) ? this.Style<ISceneUiSubtitleAppear>().Value.UnPack() : null);
				return;
			}
			if (styleType != TSceneUiSubtitleStyle.ISceneUiSubtitleScatter)
			{
				return;
			}
			_o.Style.Value = ((this.Style<ISceneUiSubtitleScatter>() != null) ? this.Style<ISceneUiSubtitleScatter>().Value.UnPack() : null);
		}

		// Token: 0x06038329 RID: 230185 RVA: 0x007900B8 File Offset: 0x0078E2B8
		public static Offset<ITalkItemStyleSceneUiSubtitle> Pack(FlatBufferBuilder builder, ITalkItemStyleSceneUiSubtitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemStyleSceneUiSubtitle>);
			}
			TSceneUiSubtitleStyle style_type = (_o.Style == null) ? TSceneUiSubtitleStyle.NONE : _o.Style.Type;
			int styleOffset = (_o.Style == null) ? 0 : TSceneUiSubtitleStyleUnion.Pack(builder, _o.Style);
			return ITalkItemStyleSceneUiSubtitle.CreateITalkItemStyleSceneUiSubtitle(builder, _o.Type, style_type, styleOffset);
		}

		// Token: 0x04012FE5 RID: 77797
		private Table __p;
	}
}
