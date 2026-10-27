using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007274 RID: 29300
	public struct ISwitchTrailChainEffectState : IFlatbufferObject
	{
		// Token: 0x1700D965 RID: 55653
		// (get) Token: 0x06033FBA RID: 212922 RVA: 0x006FD8E6 File Offset: 0x006FBAE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033FBB RID: 212923 RVA: 0x006FD8F3 File Offset: 0x006FBAF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033FBC RID: 212924 RVA: 0x006FD8FC File Offset: 0x006FBAFC
		public static ISwitchTrailChainEffectState GetRootAsISwitchTrailChainEffectState(ByteBuffer _bb)
		{
			return ISwitchTrailChainEffectState.GetRootAsISwitchTrailChainEffectState(_bb, default(ISwitchTrailChainEffectState));
		}

		// Token: 0x06033FBD RID: 212925 RVA: 0x006FD918 File Offset: 0x006FBB18
		public static ISwitchTrailChainEffectState GetRootAsISwitchTrailChainEffectState(ByteBuffer _bb, ISwitchTrailChainEffectState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033FBE RID: 212926 RVA: 0x006FD935 File Offset: 0x006FBB35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033FBF RID: 212927 RVA: 0x006FD944 File Offset: 0x006FBB44
		public ISwitchTrailChainEffectState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D966 RID: 55654
		// (get) Token: 0x06033FC0 RID: 212928 RVA: 0x006FD954 File Offset: 0x006FBB54
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

		// Token: 0x1700D967 RID: 55655
		// (get) Token: 0x06033FC1 RID: 212929 RVA: 0x006FD990 File Offset: 0x006FBB90
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

		// Token: 0x1700D968 RID: 55656
		// (get) Token: 0x06033FC2 RID: 212930 RVA: 0x006FD9CC File Offset: 0x006FBBCC
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

		// Token: 0x06033FC3 RID: 212931 RVA: 0x006FDA08 File Offset: 0x006FBC08
		public TTable? Pos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033FC4 RID: 212932 RVA: 0x006FDA50 File Offset: 0x006FBC50
		public IAbsolutePos2 PosAsIAbsolutePos2()
		{
			return this.Pos<IAbsolutePos2>().Value;
		}

		// Token: 0x06033FC5 RID: 212933 RVA: 0x006FDA6C File Offset: 0x006FBC6C
		public IEntityPos2 PosAsIEntityPos2()
		{
			return this.Pos<IEntityPos2>().Value;
		}

		// Token: 0x06033FC6 RID: 212934 RVA: 0x006FDA88 File Offset: 0x006FBC88
		public IPlayerPos2 PosAsIPlayerPos2()
		{
			return this.Pos<IPlayerPos2>().Value;
		}

		// Token: 0x06033FC7 RID: 212935 RVA: 0x006FDAA4 File Offset: 0x006FBCA4
		public IEffectPlayerPos2 PosAsIEffectPlayerPos2()
		{
			return this.Pos<IEffectPlayerPos2>().Value;
		}

		// Token: 0x06033FC8 RID: 212936 RVA: 0x006FDAC0 File Offset: 0x006FBCC0
		public IEffectEntityPos2 PosAsIEffectEntityPos2()
		{
			return this.Pos<IEffectEntityPos2>().Value;
		}

		// Token: 0x06033FC9 RID: 212937 RVA: 0x006FDADB File Offset: 0x006FBCDB
		public static Offset<ISwitchTrailChainEffectState> CreateISwitchTrailChainEffectState(FlatBufferBuilder builder, ESwitchEffectStateEffectType Type = ESwitchEffectStateEffectType.ScreenEffect, int Count = 0, TPos2 Pos_type = TPos2.NONE, int PosOffset = 0)
		{
			builder.StartTable(4);
			ISwitchTrailChainEffectState.AddPos(builder, PosOffset);
			ISwitchTrailChainEffectState.AddCount(builder, Count);
			ISwitchTrailChainEffectState.AddPosType(builder, Pos_type);
			ISwitchTrailChainEffectState.AddType(builder, Type);
			return ISwitchTrailChainEffectState.EndISwitchTrailChainEffectState(builder);
		}

		// Token: 0x06033FCA RID: 212938 RVA: 0x006FDB07 File Offset: 0x006FBD07
		public static void StartISwitchTrailChainEffectState(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033FCB RID: 212939 RVA: 0x006FDB10 File Offset: 0x006FBD10
		public static void AddType(FlatBufferBuilder builder, ESwitchEffectStateEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033FCC RID: 212940 RVA: 0x006FDB1B File Offset: 0x006FBD1B
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x06033FCD RID: 212941 RVA: 0x006FDB26 File Offset: 0x006FBD26
		public static void AddPosType(FlatBufferBuilder builder, TPos2 posType)
		{
			builder.AddByte(2, (byte)posType, 0);
		}

		// Token: 0x06033FCE RID: 212942 RVA: 0x006FDB31 File Offset: 0x006FBD31
		public static void AddPos(FlatBufferBuilder builder, int posOffset)
		{
			builder.AddOffset(3, posOffset, 0);
		}

		// Token: 0x06033FCF RID: 212943 RVA: 0x006FDB3C File Offset: 0x006FBD3C
		public static Offset<ISwitchTrailChainEffectState> EndISwitchTrailChainEffectState(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchTrailChainEffectState>(builder.EndTable());
		}

		// Token: 0x06033FD0 RID: 212944 RVA: 0x006FDB4C File Offset: 0x006FBD4C
		public ISwitchTrailChainEffectStateT UnPack()
		{
			ISwitchTrailChainEffectStateT switchTrailChainEffectStateT = new ISwitchTrailChainEffectStateT();
			this.UnPackTo(switchTrailChainEffectStateT);
			return switchTrailChainEffectStateT;
		}

		// Token: 0x06033FD1 RID: 212945 RVA: 0x006FDB68 File Offset: 0x006FBD68
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

		// Token: 0x06033FD2 RID: 212946 RVA: 0x006FDCE0 File Offset: 0x006FBEE0
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

		// Token: 0x04011D7A RID: 73082
		private Table __p;
	}
}
