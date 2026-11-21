using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EE9 RID: 24297
	public struct ISceneTextGuideUi : IFlatbufferObject
	{
		// Token: 0x1700B392 RID: 45970
		// (get) Token: 0x06028BE2 RID: 166882 RVA: 0x00591AFA File Offset: 0x0058FCFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028BE3 RID: 166883 RVA: 0x00591B07 File Offset: 0x0058FD07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028BE4 RID: 166884 RVA: 0x00591B10 File Offset: 0x0058FD10
		public static ISceneTextGuideUi GetRootAsISceneTextGuideUi(ByteBuffer _bb)
		{
			return ISceneTextGuideUi.GetRootAsISceneTextGuideUi(_bb, default(ISceneTextGuideUi));
		}

		// Token: 0x06028BE5 RID: 166885 RVA: 0x00591B2C File Offset: 0x0058FD2C
		public static ISceneTextGuideUi GetRootAsISceneTextGuideUi(ByteBuffer _bb, ISceneTextGuideUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028BE6 RID: 166886 RVA: 0x00591B49 File Offset: 0x0058FD49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028BE7 RID: 166887 RVA: 0x00591B58 File Offset: 0x0058FD58
		public ISceneTextGuideUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B393 RID: 45971
		// (get) Token: 0x06028BE8 RID: 166888 RVA: 0x00591B68 File Offset: 0x0058FD68
		public ESceneTextType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneTextType.SubtitleWithVoice;
				}
				return (ESceneTextType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B394 RID: 45972
		// (get) Token: 0x06028BE9 RID: 166889 RVA: 0x00591BA4 File Offset: 0x0058FDA4
		public ISceneTextGuideUiScaleConfig? ScaleConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISceneTextGuideUiScaleConfig?(default(ISceneTextGuideUiScaleConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B395 RID: 45973
		// (get) Token: 0x06028BEA RID: 166890 RVA: 0x00591C04 File Offset: 0x0058FE04
		public ISceneTextGuideUiContent? Content
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISceneTextGuideUiContent?(default(ISceneTextGuideUiContent).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06028BEB RID: 166891 RVA: 0x00591C61 File Offset: 0x0058FE61
		public static Offset<ISceneTextGuideUi> CreateISceneTextGuideUi(FlatBufferBuilder builder, ESceneTextType Type = ESceneTextType.SubtitleWithVoice, Offset<ISceneTextGuideUiScaleConfig> ScaleConfigOffset = default(Offset<ISceneTextGuideUiScaleConfig>), Offset<ISceneTextGuideUiContent> ContentOffset = default(Offset<ISceneTextGuideUiContent>))
		{
			builder.StartTable(3);
			ISceneTextGuideUi.AddContent(builder, ContentOffset);
			ISceneTextGuideUi.AddScaleConfig(builder, ScaleConfigOffset);
			ISceneTextGuideUi.AddType(builder, Type);
			return ISceneTextGuideUi.EndISceneTextGuideUi(builder);
		}

		// Token: 0x06028BEC RID: 166892 RVA: 0x00591C85 File Offset: 0x0058FE85
		public static void StartISceneTextGuideUi(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028BED RID: 166893 RVA: 0x00591C8E File Offset: 0x0058FE8E
		public static void AddType(FlatBufferBuilder builder, ESceneTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028BEE RID: 166894 RVA: 0x00591C99 File Offset: 0x0058FE99
		public static void AddScaleConfig(FlatBufferBuilder builder, Offset<ISceneTextGuideUiScaleConfig> scaleConfigOffset)
		{
			builder.AddOffset(1, scaleConfigOffset.Value, 0);
		}

		// Token: 0x06028BEF RID: 166895 RVA: 0x00591CA9 File Offset: 0x0058FEA9
		public static void AddContent(FlatBufferBuilder builder, Offset<ISceneTextGuideUiContent> contentOffset)
		{
			builder.AddOffset(2, contentOffset.Value, 0);
		}

		// Token: 0x06028BF0 RID: 166896 RVA: 0x00591CB9 File Offset: 0x0058FEB9
		public static Offset<ISceneTextGuideUi> EndISceneTextGuideUi(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextGuideUi>(builder.EndTable());
		}

		// Token: 0x06028BF1 RID: 166897 RVA: 0x00591CC8 File Offset: 0x0058FEC8
		public ISceneTextGuideUiT UnPack()
		{
			ISceneTextGuideUiT sceneTextGuideUiT = new ISceneTextGuideUiT();
			this.UnPackTo(sceneTextGuideUiT);
			return sceneTextGuideUiT;
		}

		// Token: 0x06028BF2 RID: 166898 RVA: 0x00591CE4 File Offset: 0x0058FEE4
		public void UnPackTo(ISceneTextGuideUiT _o)
		{
			_o.Type = this.Type;
			_o.ScaleConfig = ((this.ScaleConfig != null) ? this.ScaleConfig.Value.UnPack() : null);
			_o.Content = ((this.Content != null) ? this.Content.Value.UnPack() : null);
		}

		// Token: 0x06028BF3 RID: 166899 RVA: 0x00591D5C File Offset: 0x0058FF5C
		public static Offset<ISceneTextGuideUi> Pack(FlatBufferBuilder builder, ISceneTextGuideUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneTextGuideUi>);
			}
			Offset<ISceneTextGuideUiScaleConfig> scaleConfigOffset = (_o.ScaleConfig == null) ? default(Offset<ISceneTextGuideUiScaleConfig>) : ISceneTextGuideUiScaleConfig.Pack(builder, _o.ScaleConfig);
			Offset<ISceneTextGuideUiContent> contentOffset = (_o.Content == null) ? default(Offset<ISceneTextGuideUiContent>) : ISceneTextGuideUiContent.Pack(builder, _o.Content);
			return ISceneTextGuideUi.CreateISceneTextGuideUi(builder, _o.Type, scaleConfigOffset, contentOffset);
		}

		// Token: 0x0400FB55 RID: 64341
		private Table __p;
	}
}
