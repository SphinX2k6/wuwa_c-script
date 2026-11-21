using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006712 RID: 26386
	public struct IActorFxEmotePlay : IFlatbufferObject
	{
		// Token: 0x1700BFCE RID: 49102
		// (get) Token: 0x0602CAEF RID: 183023 RVA: 0x0061D218 File Offset: 0x0061B418
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CAF0 RID: 183024 RVA: 0x0061D225 File Offset: 0x0061B425
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CAF1 RID: 183025 RVA: 0x0061D22C File Offset: 0x0061B42C
		public static IActorFxEmotePlay GetRootAsIActorFxEmotePlay(ByteBuffer _bb)
		{
			return IActorFxEmotePlay.GetRootAsIActorFxEmotePlay(_bb, default(IActorFxEmotePlay));
		}

		// Token: 0x0602CAF2 RID: 183026 RVA: 0x0061D248 File Offset: 0x0061B448
		public static IActorFxEmotePlay GetRootAsIActorFxEmotePlay(ByteBuffer _bb, IActorFxEmotePlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CAF3 RID: 183027 RVA: 0x0061D265 File Offset: 0x0061B465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CAF4 RID: 183028 RVA: 0x0061D274 File Offset: 0x0061B474
		public IActorFxEmotePlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFCF RID: 49103
		// (get) Token: 0x0602CAF5 RID: 183029 RVA: 0x0061D284 File Offset: 0x0061B484
		public EActorFxEmoteType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorFxEmoteType.Play;
				}
				return (EActorFxEmoteType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFD0 RID: 49104
		// (get) Token: 0x0602CAF6 RID: 183030 RVA: 0x0061D2C0 File Offset: 0x0061B4C0
		public long FxEmoteId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFD1 RID: 49105
		// (get) Token: 0x0602CAF7 RID: 183031 RVA: 0x0061D300 File Offset: 0x0061B500
		public IActorFxEmoteOverrideConfig? OverrideConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IActorFxEmoteOverrideConfig?(default(IActorFxEmoteOverrideConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BFD2 RID: 49106
		// (get) Token: 0x0602CAF8 RID: 183032 RVA: 0x0061D360 File Offset: 0x0061B560
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFD3 RID: 49107
		// (get) Token: 0x0602CAF9 RID: 183033 RVA: 0x0061D3A4 File Offset: 0x0061B5A4
		public bool LoopPlay
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BFD4 RID: 49108
		// (get) Token: 0x0602CAFA RID: 183034 RVA: 0x0061D3E4 File Offset: 0x0061B5E4
		public bool KeepPlay
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BFD5 RID: 49109
		// (get) Token: 0x0602CAFB RID: 183035 RVA: 0x0061D424 File Offset: 0x0061B624
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CAFC RID: 183036 RVA: 0x0061D464 File Offset: 0x0061B664
		public static Offset<IActorFxEmotePlay> CreateIActorFxEmotePlay(FlatBufferBuilder builder, EActorFxEmoteType Type = EActorFxEmoteType.Play, long FxEmoteId = 0L, Offset<IActorFxEmoteOverrideConfig> OverrideConfigOffset = default(Offset<IActorFxEmoteOverrideConfig>), float DelayTime = 0f, bool LoopPlay = false, bool KeepPlay = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IActorFxEmotePlay.AddFxEmoteId(builder, FxEmoteId);
			IActorFxEmotePlay.AddDelayTime(builder, DelayTime);
			IActorFxEmotePlay.AddOverrideConfig(builder, OverrideConfigOffset);
			IActorFxEmotePlay.AddNullMask(builder, NullMask);
			IActorFxEmotePlay.AddKeepPlay(builder, KeepPlay);
			IActorFxEmotePlay.AddLoopPlay(builder, LoopPlay);
			IActorFxEmotePlay.AddType(builder, Type);
			return IActorFxEmotePlay.EndIActorFxEmotePlay(builder);
		}

		// Token: 0x0602CAFD RID: 183037 RVA: 0x0061D4B3 File Offset: 0x0061B6B3
		public static void StartIActorFxEmotePlay(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602CAFE RID: 183038 RVA: 0x0061D4BC File Offset: 0x0061B6BC
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CAFF RID: 183039 RVA: 0x0061D4C7 File Offset: 0x0061B6C7
		public static void AddFxEmoteId(FlatBufferBuilder builder, long fxEmoteId)
		{
			builder.AddLong(1, fxEmoteId, 0L);
		}

		// Token: 0x0602CB00 RID: 183040 RVA: 0x0061D4D3 File Offset: 0x0061B6D3
		public static void AddOverrideConfig(FlatBufferBuilder builder, Offset<IActorFxEmoteOverrideConfig> overrideConfigOffset)
		{
			builder.AddOffset(2, overrideConfigOffset.Value, 0);
		}

		// Token: 0x0602CB01 RID: 183041 RVA: 0x0061D4E3 File Offset: 0x0061B6E3
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x0602CB02 RID: 183042 RVA: 0x0061D4F6 File Offset: 0x0061B6F6
		public static void AddLoopPlay(FlatBufferBuilder builder, bool loopPlay)
		{
			builder.AddBool(4, loopPlay, false);
		}

		// Token: 0x0602CB03 RID: 183043 RVA: 0x0061D501 File Offset: 0x0061B701
		public static void AddKeepPlay(FlatBufferBuilder builder, bool keepPlay)
		{
			builder.AddBool(5, keepPlay, false);
		}

		// Token: 0x0602CB04 RID: 183044 RVA: 0x0061D50C File Offset: 0x0061B70C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602CB05 RID: 183045 RVA: 0x0061D517 File Offset: 0x0061B717
		public static Offset<IActorFxEmotePlay> EndIActorFxEmotePlay(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmotePlay>(builder.EndTable());
		}

		// Token: 0x0602CB06 RID: 183046 RVA: 0x0061D524 File Offset: 0x0061B724
		public IActorFxEmotePlayT UnPack()
		{
			IActorFxEmotePlayT actorFxEmotePlayT = new IActorFxEmotePlayT();
			this.UnPackTo(actorFxEmotePlayT);
			return actorFxEmotePlayT;
		}

		// Token: 0x0602CB07 RID: 183047 RVA: 0x0061D540 File Offset: 0x0061B740
		public void UnPackTo(IActorFxEmotePlayT _o)
		{
			_o.Type = this.Type;
			_o.FxEmoteId = this.FxEmoteId;
			_o.OverrideConfig = ((this.OverrideConfig != null) ? this.OverrideConfig.Value.UnPack() : null);
			_o.DelayTime = this.DelayTime;
			_o.LoopPlay = this.LoopPlay;
			_o.KeepPlay = this.KeepPlay;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CB08 RID: 183048 RVA: 0x0061D5C4 File Offset: 0x0061B7C4
		public static Offset<IActorFxEmotePlay> Pack(FlatBufferBuilder builder, IActorFxEmotePlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmotePlay>);
			}
			Offset<IActorFxEmoteOverrideConfig> overrideConfigOffset = (_o.OverrideConfig == null) ? default(Offset<IActorFxEmoteOverrideConfig>) : IActorFxEmoteOverrideConfig.Pack(builder, _o.OverrideConfig);
			return IActorFxEmotePlay.CreateIActorFxEmotePlay(builder, _o.Type, _o.FxEmoteId, overrideConfigOffset, _o.DelayTime, _o.LoopPlay, _o.KeepPlay, _o.NullMask);
		}

		// Token: 0x04011252 RID: 70226
		private Table __p;
	}
}
