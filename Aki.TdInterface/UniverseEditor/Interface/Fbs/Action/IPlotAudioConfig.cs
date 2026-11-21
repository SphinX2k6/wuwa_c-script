using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C8 RID: 29896
	public struct IPlotAudioConfig : IFlatbufferObject
	{
		// Token: 0x1700DBFE RID: 56318
		// (get) Token: 0x06034685 RID: 214661 RVA: 0x0070EB1F File Offset: 0x0070CD1F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034686 RID: 214662 RVA: 0x0070EB2C File Offset: 0x0070CD2C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034687 RID: 214663 RVA: 0x0070EB34 File Offset: 0x0070CD34
		public static IPlotAudioConfig GetRootAsIPlotAudioConfig(ByteBuffer _bb)
		{
			return IPlotAudioConfig.GetRootAsIPlotAudioConfig(_bb, default(IPlotAudioConfig));
		}

		// Token: 0x06034688 RID: 214664 RVA: 0x0070EB50 File Offset: 0x0070CD50
		public static IPlotAudioConfig GetRootAsIPlotAudioConfig(ByteBuffer _bb, IPlotAudioConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034689 RID: 214665 RVA: 0x0070EB6D File Offset: 0x0070CD6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603468A RID: 214666 RVA: 0x0070EB7C File Offset: 0x0070CD7C
		public IPlotAudioConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DBFF RID: 56319
		// (get) Token: 0x0603468B RID: 214667 RVA: 0x0070EB8C File Offset: 0x0070CD8C
		public IPlotVoiceFadeOutOnInterrupt? VoiceFadeOutOnInterrupt
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPlotVoiceFadeOutOnInterrupt?(default(IPlotVoiceFadeOutOnInterrupt).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603468C RID: 214668 RVA: 0x0070EBE9 File Offset: 0x0070CDE9
		public static Offset<IPlotAudioConfig> CreateIPlotAudioConfig(FlatBufferBuilder builder, Offset<IPlotVoiceFadeOutOnInterrupt> VoiceFadeOutOnInterruptOffset = default(Offset<IPlotVoiceFadeOutOnInterrupt>))
		{
			builder.StartTable(1);
			IPlotAudioConfig.AddVoiceFadeOutOnInterrupt(builder, VoiceFadeOutOnInterruptOffset);
			return IPlotAudioConfig.EndIPlotAudioConfig(builder);
		}

		// Token: 0x0603468D RID: 214669 RVA: 0x0070EBFF File Offset: 0x0070CDFF
		public static void StartIPlotAudioConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603468E RID: 214670 RVA: 0x0070EC08 File Offset: 0x0070CE08
		public static void AddVoiceFadeOutOnInterrupt(FlatBufferBuilder builder, Offset<IPlotVoiceFadeOutOnInterrupt> voiceFadeOutOnInterruptOffset)
		{
			builder.AddOffset(0, voiceFadeOutOnInterruptOffset.Value, 0);
		}

		// Token: 0x0603468F RID: 214671 RVA: 0x0070EC18 File Offset: 0x0070CE18
		public static Offset<IPlotAudioConfig> EndIPlotAudioConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPlotAudioConfig>(builder.EndTable());
		}

		// Token: 0x06034690 RID: 214672 RVA: 0x0070EC28 File Offset: 0x0070CE28
		public IPlotAudioConfigT UnPack()
		{
			IPlotAudioConfigT plotAudioConfigT = new IPlotAudioConfigT();
			this.UnPackTo(plotAudioConfigT);
			return plotAudioConfigT;
		}

		// Token: 0x06034691 RID: 214673 RVA: 0x0070EC44 File Offset: 0x0070CE44
		public void UnPackTo(IPlotAudioConfigT _o)
		{
			_o.VoiceFadeOutOnInterrupt = ((this.VoiceFadeOutOnInterrupt != null) ? this.VoiceFadeOutOnInterrupt.Value.UnPack() : null);
		}

		// Token: 0x06034692 RID: 214674 RVA: 0x0070EC80 File Offset: 0x0070CE80
		public static Offset<IPlotAudioConfig> Pack(FlatBufferBuilder builder, IPlotAudioConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotAudioConfig>);
			}
			Offset<IPlotVoiceFadeOutOnInterrupt> voiceFadeOutOnInterruptOffset = (_o.VoiceFadeOutOnInterrupt == null) ? default(Offset<IPlotVoiceFadeOutOnInterrupt>) : IPlotVoiceFadeOutOnInterrupt.Pack(builder, _o.VoiceFadeOutOnInterrupt);
			return IPlotAudioConfig.CreateIPlotAudioConfig(builder, voiceFadeOutOnInterruptOffset);
		}

		// Token: 0x0401267E RID: 75390
		private Table __p;
	}
}
