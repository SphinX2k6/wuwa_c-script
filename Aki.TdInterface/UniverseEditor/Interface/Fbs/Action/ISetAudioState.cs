using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB4 RID: 28596
	public struct ISetAudioState : IFlatbufferObject
	{
		// Token: 0x1700D457 RID: 54359
		// (get) Token: 0x060328A5 RID: 207013 RVA: 0x006D20C4 File Offset: 0x006D02C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060328A6 RID: 207014 RVA: 0x006D20D1 File Offset: 0x006D02D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060328A7 RID: 207015 RVA: 0x006D20D8 File Offset: 0x006D02D8
		public static ISetAudioState GetRootAsISetAudioState(ByteBuffer _bb)
		{
			return ISetAudioState.GetRootAsISetAudioState(_bb, default(ISetAudioState));
		}

		// Token: 0x060328A8 RID: 207016 RVA: 0x006D20F4 File Offset: 0x006D02F4
		public static ISetAudioState GetRootAsISetAudioState(ByteBuffer _bb, ISetAudioState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060328A9 RID: 207017 RVA: 0x006D2111 File Offset: 0x006D0311
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060328AA RID: 207018 RVA: 0x006D2120 File Offset: 0x006D0320
		public ISetAudioState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D458 RID: 54360
		// (get) Token: 0x060328AB RID: 207019 RVA: 0x006D2130 File Offset: 0x006D0330
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

		// Token: 0x060328AC RID: 207020 RVA: 0x006D218D File Offset: 0x006D038D
		public static Offset<ISetAudioState> CreateISetAudioState(FlatBufferBuilder builder, Offset<IAudioState> AudioConfigOffset = default(Offset<IAudioState>))
		{
			builder.StartTable(1);
			ISetAudioState.AddAudioConfig(builder, AudioConfigOffset);
			return ISetAudioState.EndISetAudioState(builder);
		}

		// Token: 0x060328AD RID: 207021 RVA: 0x006D21A3 File Offset: 0x006D03A3
		public static void StartISetAudioState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060328AE RID: 207022 RVA: 0x006D21AC File Offset: 0x006D03AC
		public static void AddAudioConfig(FlatBufferBuilder builder, Offset<IAudioState> audioConfigOffset)
		{
			builder.AddOffset(0, audioConfigOffset.Value, 0);
		}

		// Token: 0x060328AF RID: 207023 RVA: 0x006D21BC File Offset: 0x006D03BC
		public static Offset<ISetAudioState> EndISetAudioState(FlatBufferBuilder builder)
		{
			return new Offset<ISetAudioState>(builder.EndTable());
		}

		// Token: 0x060328B0 RID: 207024 RVA: 0x006D21CC File Offset: 0x006D03CC
		public ISetAudioStateT UnPack()
		{
			ISetAudioStateT setAudioStateT = new ISetAudioStateT();
			this.UnPackTo(setAudioStateT);
			return setAudioStateT;
		}

		// Token: 0x060328B1 RID: 207025 RVA: 0x006D21E8 File Offset: 0x006D03E8
		public void UnPackTo(ISetAudioStateT _o)
		{
			_o.AudioConfig = ((this.AudioConfig != null) ? this.AudioConfig.Value.UnPack() : null);
		}

		// Token: 0x060328B2 RID: 207026 RVA: 0x006D2224 File Offset: 0x006D0424
		public static Offset<ISetAudioState> Pack(FlatBufferBuilder builder, ISetAudioStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAudioState>);
			}
			Offset<IAudioState> audioConfigOffset = (_o.AudioConfig == null) ? default(Offset<IAudioState>) : IAudioState.Pack(builder, _o.AudioConfig);
			return ISetAudioState.CreateISetAudioState(builder, audioConfigOffset);
		}

		// Token: 0x040119BB RID: 72123
		private Table __p;
	}
}
