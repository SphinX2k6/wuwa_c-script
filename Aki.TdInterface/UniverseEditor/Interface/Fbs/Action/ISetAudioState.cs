using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200777D RID: 30589
	public struct ISetAudioState : IFlatbufferObject
	{
		// Token: 0x1700E02B RID: 57387
		// (get) Token: 0x06035B0B RID: 219915 RVA: 0x00731D08 File Offset: 0x0072FF08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B0C RID: 219916 RVA: 0x00731D15 File Offset: 0x0072FF15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B0D RID: 219917 RVA: 0x00731D1C File Offset: 0x0072FF1C
		public static ISetAudioState GetRootAsISetAudioState(ByteBuffer _bb)
		{
			return ISetAudioState.GetRootAsISetAudioState(_bb, default(ISetAudioState));
		}

		// Token: 0x06035B0E RID: 219918 RVA: 0x00731D38 File Offset: 0x0072FF38
		public static ISetAudioState GetRootAsISetAudioState(ByteBuffer _bb, ISetAudioState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B0F RID: 219919 RVA: 0x00731D55 File Offset: 0x0072FF55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B10 RID: 219920 RVA: 0x00731D64 File Offset: 0x0072FF64
		public ISetAudioState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E02C RID: 57388
		// (get) Token: 0x06035B11 RID: 219921 RVA: 0x00731D74 File Offset: 0x0072FF74
		public IAudioState? AudioConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IAudioState?(default(IAudioState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035B12 RID: 219922 RVA: 0x00731DD1 File Offset: 0x0072FFD1
		public static Offset<ISetAudioState> CreateISetAudioState(FlatBufferBuilder builder, Offset<IAudioState> AudioConfigOffset = default(Offset<IAudioState>))
		{
			builder.StartTable(1);
			ISetAudioState.AddAudioConfig(builder, AudioConfigOffset);
			return ISetAudioState.EndISetAudioState(builder);
		}

		// Token: 0x06035B13 RID: 219923 RVA: 0x00731DE7 File Offset: 0x0072FFE7
		public static void StartISetAudioState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035B14 RID: 219924 RVA: 0x00731DF0 File Offset: 0x0072FFF0
		public static void AddAudioConfig(FlatBufferBuilder builder, Offset<IAudioState> audioConfigOffset)
		{
			builder.AddOffset(0, audioConfigOffset.Value, 0);
		}

		// Token: 0x06035B15 RID: 219925 RVA: 0x00731E00 File Offset: 0x00730000
		public static Offset<ISetAudioState> EndISetAudioState(FlatBufferBuilder builder)
		{
			return new Offset<ISetAudioState>(builder.EndTable());
		}

		// Token: 0x06035B16 RID: 219926 RVA: 0x00731E10 File Offset: 0x00730010
		public ISetAudioStateT UnPack()
		{
			ISetAudioStateT setAudioStateT = new ISetAudioStateT();
			this.UnPackTo(setAudioStateT);
			return setAudioStateT;
		}

		// Token: 0x06035B17 RID: 219927 RVA: 0x00731E2C File Offset: 0x0073002C
		public void UnPackTo(ISetAudioStateT _o)
		{
			_o.AudioConfig = ((this.AudioConfig != null) ? this.AudioConfig.Value.UnPack() : null);
		}

		// Token: 0x06035B18 RID: 219928 RVA: 0x00731E68 File Offset: 0x00730068
		public static Offset<ISetAudioState> Pack(FlatBufferBuilder builder, ISetAudioStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAudioState>);
			}
			Offset<IAudioState> audioConfigOffset = (_o.AudioConfig == null) ? default(Offset<IAudioState>) : IAudioState.Pack(builder, _o.AudioConfig);
			return ISetAudioState.CreateISetAudioState(builder, audioConfigOffset);
		}

		// Token: 0x040129A0 RID: 76192
		private Table __p;
	}
}
