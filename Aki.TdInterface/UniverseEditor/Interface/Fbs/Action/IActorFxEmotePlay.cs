using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060B0 RID: 24752
	public struct IActorFxEmotePlay : IFlatbufferObject
	{
		// Token: 0x1700B663 RID: 46691
		// (get) Token: 0x0602A40E RID: 173070 RVA: 0x005D3270 File Offset: 0x005D1470
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A40F RID: 173071 RVA: 0x005D327D File Offset: 0x005D147D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A410 RID: 173072 RVA: 0x005D3284 File Offset: 0x005D1484
		public static IActorFxEmotePlay GetRootAsIActorFxEmotePlay(ByteBuffer _bb)
		{
			return IActorFxEmotePlay.GetRootAsIActorFxEmotePlay(_bb, default(IActorFxEmotePlay));
		}

		// Token: 0x0602A411 RID: 173073 RVA: 0x005D32A0 File Offset: 0x005D14A0
		public static IActorFxEmotePlay GetRootAsIActorFxEmotePlay(ByteBuffer _bb, IActorFxEmotePlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A412 RID: 173074 RVA: 0x005D32BD File Offset: 0x005D14BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A413 RID: 173075 RVA: 0x005D32CC File Offset: 0x005D14CC
		public IActorFxEmotePlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B664 RID: 46692
		// (get) Token: 0x0602A414 RID: 173076 RVA: 0x005D32DC File Offset: 0x005D14DC
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

		// Token: 0x1700B665 RID: 46693
		// (get) Token: 0x0602A415 RID: 173077 RVA: 0x005D3318 File Offset: 0x005D1518
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

		// Token: 0x1700B666 RID: 46694
		// (get) Token: 0x0602A416 RID: 173078 RVA: 0x005D3358 File Offset: 0x005D1558
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

		// Token: 0x1700B667 RID: 46695
		// (get) Token: 0x0602A417 RID: 173079 RVA: 0x005D33B8 File Offset: 0x005D15B8
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

		// Token: 0x1700B668 RID: 46696
		// (get) Token: 0x0602A418 RID: 173080 RVA: 0x005D33FC File Offset: 0x005D15FC
		public bool LoopPlay
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B669 RID: 46697
		// (get) Token: 0x0602A419 RID: 173081 RVA: 0x005D343C File Offset: 0x005D163C
		public bool KeepPlay
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B66A RID: 46698
		// (get) Token: 0x0602A41A RID: 173082 RVA: 0x005D347C File Offset: 0x005D167C
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

		// Token: 0x0602A41B RID: 173083 RVA: 0x005D34BC File Offset: 0x005D16BC
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

		// Token: 0x0602A41C RID: 173084 RVA: 0x005D350B File Offset: 0x005D170B
		public static void StartIActorFxEmotePlay(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602A41D RID: 173085 RVA: 0x005D3514 File Offset: 0x005D1714
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A41E RID: 173086 RVA: 0x005D351F File Offset: 0x005D171F
		public static void AddFxEmoteId(FlatBufferBuilder builder, long fxEmoteId)
		{
			builder.AddLong(1, fxEmoteId, 0L);
		}

		// Token: 0x0602A41F RID: 173087 RVA: 0x005D352B File Offset: 0x005D172B
		public static void AddOverrideConfig(FlatBufferBuilder builder, Offset<IActorFxEmoteOverrideConfig> overrideConfigOffset)
		{
			builder.AddOffset(2, overrideConfigOffset.Value, 0);
		}

		// Token: 0x0602A420 RID: 173088 RVA: 0x005D353B File Offset: 0x005D173B
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x0602A421 RID: 173089 RVA: 0x005D354E File Offset: 0x005D174E
		public static void AddLoopPlay(FlatBufferBuilder builder, bool loopPlay)
		{
			builder.AddBool(4, loopPlay, false);
		}

		// Token: 0x0602A422 RID: 173090 RVA: 0x005D3559 File Offset: 0x005D1759
		public static void AddKeepPlay(FlatBufferBuilder builder, bool keepPlay)
		{
			builder.AddBool(5, keepPlay, false);
		}

		// Token: 0x0602A423 RID: 173091 RVA: 0x005D3564 File Offset: 0x005D1764
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602A424 RID: 173092 RVA: 0x005D356F File Offset: 0x005D176F
		public static Offset<IActorFxEmotePlay> EndIActorFxEmotePlay(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmotePlay>(builder.EndTable());
		}

		// Token: 0x0602A425 RID: 173093 RVA: 0x005D357C File Offset: 0x005D177C
		public IActorFxEmotePlayT UnPack()
		{
			IActorFxEmotePlayT actorFxEmotePlayT = new IActorFxEmotePlayT();
			this.UnPackTo(actorFxEmotePlayT);
			return actorFxEmotePlayT;
		}

		// Token: 0x0602A426 RID: 173094 RVA: 0x005D3598 File Offset: 0x005D1798
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

		// Token: 0x0602A427 RID: 173095 RVA: 0x005D361C File Offset: 0x005D181C
		public static Offset<IActorFxEmotePlay> Pack(FlatBufferBuilder builder, IActorFxEmotePlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmotePlay>);
			}
			Offset<IActorFxEmoteOverrideConfig> overrideConfigOffset = (_o.OverrideConfig == null) ? default(Offset<IActorFxEmoteOverrideConfig>) : IActorFxEmoteOverrideConfig.Pack(builder, _o.OverrideConfig);
			return IActorFxEmotePlay.CreateIActorFxEmotePlay(builder, _o.Type, _o.FxEmoteId, overrideConfigOffset, _o.DelayTime, _o.LoopPlay, _o.KeepPlay, _o.NullMask);
		}

		// Token: 0x0401044E RID: 66638
		private Table __p;
	}
}
