using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A49 RID: 31305
	public struct ISwitchTrailChainEffectState : IFlatbufferObject
	{
		// Token: 0x1700E55E RID: 58718
		// (get) Token: 0x060372BC RID: 225980 RVA: 0x0075EC46 File Offset: 0x0075CE46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060372BD RID: 225981 RVA: 0x0075EC53 File Offset: 0x0075CE53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060372BE RID: 225982 RVA: 0x0075EC5C File Offset: 0x0075CE5C
		public static ISwitchTrailChainEffectState GetRootAsISwitchTrailChainEffectState(ByteBuffer _bb)
		{
			return ISwitchTrailChainEffectState.GetRootAsISwitchTrailChainEffectState(_bb, default(ISwitchTrailChainEffectState));
		}

		// Token: 0x060372BF RID: 225983 RVA: 0x0075EC78 File Offset: 0x0075CE78
		public static ISwitchTrailChainEffectState GetRootAsISwitchTrailChainEffectState(ByteBuffer _bb, ISwitchTrailChainEffectState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060372C0 RID: 225984 RVA: 0x0075EC95 File Offset: 0x0075CE95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060372C1 RID: 225985 RVA: 0x0075ECA4 File Offset: 0x0075CEA4
		public ISwitchTrailChainEffectState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E55F RID: 58719
		// (get) Token: 0x060372C2 RID: 225986 RVA: 0x0075ECB4 File Offset: 0x0075CEB4
		public ESwitchEffectStateEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESwitchEffectStateEffectType.ScreenEffect;
				}
				return (ESwitchEffectStateEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E560 RID: 58720
		// (get) Token: 0x060372C3 RID: 225987 RVA: 0x0075ECF0 File Offset: 0x0075CEF0
		public int Count
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E561 RID: 58721
		// (get) Token: 0x060372C4 RID: 225988 RVA: 0x0075ED2C File Offset: 0x0075CF2C
		public TPos2 PosType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TPos2.NONE;
				}
				return (TPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060372C5 RID: 225989 RVA: 0x0075ED68 File Offset: 0x0075CF68
		public TTable? Pos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060372C6 RID: 225990 RVA: 0x0075EDB0 File Offset: 0x0075CFB0
		public IAbsolutePos2 PosAsIAbsolutePos2()
		{
			return this.Pos<IAbsolutePos2>().Value;
		}

		// Token: 0x060372C7 RID: 225991 RVA: 0x0075EDCC File Offset: 0x0075CFCC
		public IEntityPos2 PosAsIEntityPos2()
		{
			return this.Pos<IEntityPos2>().Value;
		}

		// Token: 0x060372C8 RID: 225992 RVA: 0x0075EDE8 File Offset: 0x0075CFE8
		public IPlayerPos2 PosAsIPlayerPos2()
		{
			return this.Pos<IPlayerPos2>().Value;
		}

		// Token: 0x060372C9 RID: 225993 RVA: 0x0075EE04 File Offset: 0x0075D004
		public IEffectPlayerPos2 PosAsIEffectPlayerPos2()
		{
			return this.Pos<IEffectPlayerPos2>().Value;
		}

		// Token: 0x060372CA RID: 225994 RVA: 0x0075EE20 File Offset: 0x0075D020
		public IEffectEntityPos2 PosAsIEffectEntityPos2()
		{
			return this.Pos<IEffectEntityPos2>().Value;
		}

		// Token: 0x060372CB RID: 225995 RVA: 0x0075EE3B File Offset: 0x0075D03B
		public static Offset<ISwitchTrailChainEffectState> CreateISwitchTrailChainEffectState(FlatBufferBuilder builder, ESwitchEffectStateEffectType Type = ESwitchEffectStateEffectType.ScreenEffect, int Count = 0, TPos2 Pos_type = TPos2.NONE, int PosOffset = 0)
		{
			builder.StartTable(4);
			ISwitchTrailChainEffectState.AddPos(builder, PosOffset);
			ISwitchTrailChainEffectState.AddCount(builder, Count);
			ISwitchTrailChainEffectState.AddPosType(builder, Pos_type);
			ISwitchTrailChainEffectState.AddType(builder, Type);
			return ISwitchTrailChainEffectState.EndISwitchTrailChainEffectState(builder);
		}

		// Token: 0x060372CC RID: 225996 RVA: 0x0075EE67 File Offset: 0x0075D067
		public static void StartISwitchTrailChainEffectState(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060372CD RID: 225997 RVA: 0x0075EE70 File Offset: 0x0075D070
		public static void AddType(FlatBufferBuilder builder, ESwitchEffectStateEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060372CE RID: 225998 RVA: 0x0075EE7B File Offset: 0x0075D07B
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x060372CF RID: 225999 RVA: 0x0075EE86 File Offset: 0x0075D086
		public static void AddPosType(FlatBufferBuilder builder, TPos2 posType)
		{
			builder.AddByte(2, (byte)posType, 0);
		}

		// Token: 0x060372D0 RID: 226000 RVA: 0x0075EE91 File Offset: 0x0075D091
		public static void AddPos(FlatBufferBuilder builder, int posOffset)
		{
			builder.AddOffset(3, posOffset, 0);
		}

		// Token: 0x060372D1 RID: 226001 RVA: 0x0075EE9C File Offset: 0x0075D09C
		public static Offset<ISwitchTrailChainEffectState> EndISwitchTrailChainEffectState(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchTrailChainEffectState>(builder.EndTable());
		}

		// Token: 0x060372D2 RID: 226002 RVA: 0x0075EEAC File Offset: 0x0075D0AC
		public ISwitchTrailChainEffectStateT UnPack()
		{
			ISwitchTrailChainEffectStateT switchTrailChainEffectStateT = new ISwitchTrailChainEffectStateT();
			this.UnPackTo(switchTrailChainEffectStateT);
			return switchTrailChainEffectStateT;
		}

		// Token: 0x060372D3 RID: 226003 RVA: 0x0075EEC8 File Offset: 0x0075D0C8
		public void UnPackTo(ISwitchTrailChainEffectStateT _o)
		{
			_o.Type = this.Type;
			_o.Count = this.Count;
			_o.Pos = new TPos2Union();
			_o.Pos.Type = this.PosType;
			switch (this.PosType)
			{
			case TPos2.IAbsolutePos2:
				_o.Pos.Value = ((this.Pos<IAbsolutePos2>() != null) ? this.Pos<IAbsolutePos2>().Value.UnPack() : null);
				return;
			case TPos2.IEntityPos2:
				_o.Pos.Value = ((this.Pos<IEntityPos2>() != null) ? this.Pos<IEntityPos2>().Value.UnPack() : null);
				return;
			case TPos2.IPlayerPos2:
				_o.Pos.Value = ((this.Pos<IPlayerPos2>() != null) ? this.Pos<IPlayerPos2>().Value.UnPack() : null);
				return;
			case TPos2.IEffectPlayerPos2:
				_o.Pos.Value = ((this.Pos<IEffectPlayerPos2>() != null) ? this.Pos<IEffectPlayerPos2>().Value.UnPack() : null);
				return;
			case TPos2.IEffectEntityPos2:
				_o.Pos.Value = ((this.Pos<IEffectEntityPos2>() != null) ? this.Pos<IEffectEntityPos2>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060372D4 RID: 226004 RVA: 0x0075F040 File Offset: 0x0075D240
		public static Offset<ISwitchTrailChainEffectState> Pack(FlatBufferBuilder builder, ISwitchTrailChainEffectStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchTrailChainEffectState>);
			}
			TPos2 pos_type = (_o.Pos == null) ? TPos2.NONE : _o.Pos.Type;
			int posOffset = (_o.Pos == null) ? 0 : TPos2Union.Pack(builder, _o.Pos);
			return ISwitchTrailChainEffectState.CreateISwitchTrailChainEffectState(builder, _o.Type, _o.Count, pos_type, posOffset);
		}

		// Token: 0x04012D7C RID: 77180
		private Table __p;
	}
}
