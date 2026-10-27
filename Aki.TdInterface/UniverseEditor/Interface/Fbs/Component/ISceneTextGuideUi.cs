using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DC RID: 22748
	public struct ISceneTextGuideUi : IFlatbufferObject
	{
		// Token: 0x1700AA62 RID: 43618
		// (get) Token: 0x06026680 RID: 157312 RVA: 0x0054AFAE File Offset: 0x005491AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026681 RID: 157313 RVA: 0x0054AFBB File Offset: 0x005491BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026682 RID: 157314 RVA: 0x0054AFC4 File Offset: 0x005491C4
		public static ISceneTextGuideUi GetRootAsISceneTextGuideUi(ByteBuffer _bb)
		{
			return ISceneTextGuideUi.GetRootAsISceneTextGuideUi(_bb, default(ISceneTextGuideUi));
		}

		// Token: 0x06026683 RID: 157315 RVA: 0x0054AFE0 File Offset: 0x005491E0
		public static ISceneTextGuideUi GetRootAsISceneTextGuideUi(ByteBuffer _bb, ISceneTextGuideUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026684 RID: 157316 RVA: 0x0054AFFD File Offset: 0x005491FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026685 RID: 157317 RVA: 0x0054B00C File Offset: 0x0054920C
		public ISceneTextGuideUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA63 RID: 43619
		// (get) Token: 0x06026686 RID: 157318 RVA: 0x0054B01C File Offset: 0x0054921C
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

		// Token: 0x1700AA64 RID: 43620
		// (get) Token: 0x06026687 RID: 157319 RVA: 0x0054B058 File Offset: 0x00549258
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

		// Token: 0x1700AA65 RID: 43621
		// (get) Token: 0x06026688 RID: 157320 RVA: 0x0054B0B8 File Offset: 0x005492B8
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

		// Token: 0x06026689 RID: 157321 RVA: 0x0054B115 File Offset: 0x00549315
		public static Offset<ISceneTextGuideUi> CreateISceneTextGuideUi(FlatBufferBuilder builder, ESceneTextType Type = ESceneTextType.SubtitleWithVoice, Offset<ISceneTextGuideUiScaleConfig> ScaleConfigOffset = default(Offset<ISceneTextGuideUiScaleConfig>), Offset<ISceneTextGuideUiContent> ContentOffset = default(Offset<ISceneTextGuideUiContent>))
		{
			builder.StartTable(3);
			ISceneTextGuideUi.AddContent(builder, ContentOffset);
			ISceneTextGuideUi.AddScaleConfig(builder, ScaleConfigOffset);
			ISceneTextGuideUi.AddType(builder, Type);
			return ISceneTextGuideUi.EndISceneTextGuideUi(builder);
		}

		// Token: 0x0602668A RID: 157322 RVA: 0x0054B139 File Offset: 0x00549339
		public static void StartISceneTextGuideUi(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602668B RID: 157323 RVA: 0x0054B142 File Offset: 0x00549342
		public static void AddType(FlatBufferBuilder builder, ESceneTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602668C RID: 157324 RVA: 0x0054B14D File Offset: 0x0054934D
		public static void AddScaleConfig(FlatBufferBuilder builder, Offset<ISceneTextGuideUiScaleConfig> scaleConfigOffset)
		{
			builder.AddOffset(1, scaleConfigOffset.Value, 0);
		}

		// Token: 0x0602668D RID: 157325 RVA: 0x0054B15D File Offset: 0x0054935D
		public static void AddContent(FlatBufferBuilder builder, Offset<ISceneTextGuideUiContent> contentOffset)
		{
			builder.AddOffset(2, contentOffset.Value, 0);
		}

		// Token: 0x0602668E RID: 157326 RVA: 0x0054B16D File Offset: 0x0054936D
		public static Offset<ISceneTextGuideUi> EndISceneTextGuideUi(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextGuideUi>(builder.EndTable());
		}

		// Token: 0x0602668F RID: 157327 RVA: 0x0054B17C File Offset: 0x0054937C
		public ISceneTextGuideUiT UnPack()
		{
			ISceneTextGuideUiT sceneTextGuideUiT = new ISceneTextGuideUiT();
			this.UnPackTo(sceneTextGuideUiT);
			return sceneTextGuideUiT;
		}

		// Token: 0x06026690 RID: 157328 RVA: 0x0054B198 File Offset: 0x00549398
		public void UnPackTo(ISceneTextGuideUiT _o)
		{
			_o.Type = this.Type;
			_o.ScaleConfig = ((this.ScaleConfig != null) ? this.ScaleConfig.Value.UnPack() : null);
			_o.Content = ((this.Content != null) ? this.Content.Value.UnPack() : null);
		}

		// Token: 0x06026691 RID: 157329 RVA: 0x0054B210 File Offset: 0x00549410
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

		// Token: 0x0400EE62 RID: 61026
		private Table __p;
	}
}
