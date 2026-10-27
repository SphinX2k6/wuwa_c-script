using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007259 RID: 29273
	public struct ISwitchEffectState : IFlatbufferObject
	{
		// Token: 0x1700D932 RID: 55602
		// (get) Token: 0x06033ED0 RID: 212688 RVA: 0x006FBEF1 File Offset: 0x006FA0F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033ED1 RID: 212689 RVA: 0x006FBEFE File Offset: 0x006FA0FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033ED2 RID: 212690 RVA: 0x006FBF08 File Offset: 0x006FA108
		public static ISwitchEffectState GetRootAsISwitchEffectState(ByteBuffer _bb)
		{
			return ISwitchEffectState.GetRootAsISwitchEffectState(_bb, default(ISwitchEffectState));
		}

		// Token: 0x06033ED3 RID: 212691 RVA: 0x006FBF24 File Offset: 0x006FA124
		public static ISwitchEffectState GetRootAsISwitchEffectState(ByteBuffer _bb, ISwitchEffectState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033ED4 RID: 212692 RVA: 0x006FBF41 File Offset: 0x006FA141
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033ED5 RID: 212693 RVA: 0x006FBF50 File Offset: 0x006FA150
		public ISwitchEffectState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D933 RID: 55603
		// (get) Token: 0x06033ED6 RID: 212694 RVA: 0x006FBF60 File Offset: 0x006FA160
		public EEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectType.Effect;
				}
				return (EEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D934 RID: 55604
		// (get) Token: 0x06033ED7 RID: 212695 RVA: 0x006FBF9C File Offset: 0x006FA19C
		public string Path
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033ED8 RID: 212696 RVA: 0x006FBFD3 File Offset: 0x006FA1D3
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033ED9 RID: 212697 RVA: 0x006FBFE2 File Offset: 0x006FA1E2
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D935 RID: 55605
		// (get) Token: 0x06033EDA RID: 212698 RVA: 0x006FBFF0 File Offset: 0x006FA1F0
		public TSwitchEffectStateEffectType EffectTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TSwitchEffectStateEffectType.NONE;
				}
				return (TSwitchEffectStateEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033EDB RID: 212699 RVA: 0x006FC02C File Offset: 0x006FA22C
		public TTable? EffectType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033EDC RID: 212700 RVA: 0x006FC074 File Offset: 0x006FA274
		public ISwitchScreenEffectState EffectTypeAsISwitchScreenEffectState()
		{
			return this.EffectType<ISwitchScreenEffectState>().Value;
		}

		// Token: 0x06033EDD RID: 212701 RVA: 0x006FC090 File Offset: 0x006FA290
		public ISwitchTrailChainEffectState EffectTypeAsISwitchTrailChainEffectState()
		{
			return this.EffectType<ISwitchTrailChainEffectState>().Value;
		}

		// Token: 0x1700D936 RID: 55606
		// (get) Token: 0x06033EDE RID: 212702 RVA: 0x006FC0AC File Offset: 0x006FA2AC
		public int TargetStateIndex
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033EDF RID: 212703 RVA: 0x006FC0E9 File Offset: 0x006FA2E9
		public static Offset<ISwitchEffectState> CreateISwitchEffectState(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset), TSwitchEffectStateEffectType EffectType_type = TSwitchEffectStateEffectType.NONE, int EffectTypeOffset = 0, int TargetStateIndex = 0)
		{
			builder.StartTable(5);
			ISwitchEffectState.AddTargetStateIndex(builder, TargetStateIndex);
			ISwitchEffectState.AddEffectType(builder, EffectTypeOffset);
			ISwitchEffectState.AddPath(builder, PathOffset);
			ISwitchEffectState.AddEffectTypeType(builder, EffectType_type);
			ISwitchEffectState.AddType(builder, Type);
			return ISwitchEffectState.EndISwitchEffectState(builder);
		}

		// Token: 0x06033EE0 RID: 212704 RVA: 0x006FC11D File Offset: 0x006FA31D
		public static void StartISwitchEffectState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033EE1 RID: 212705 RVA: 0x006FC126 File Offset: 0x006FA326
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033EE2 RID: 212706 RVA: 0x006FC131 File Offset: 0x006FA331
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06033EE3 RID: 212707 RVA: 0x006FC141 File Offset: 0x006FA341
		public static void AddEffectTypeType(FlatBufferBuilder builder, TSwitchEffectStateEffectType effectTypeType)
		{
			builder.AddByte(2, (byte)effectTypeType, 0);
		}

		// Token: 0x06033EE4 RID: 212708 RVA: 0x006FC14C File Offset: 0x006FA34C
		public static void AddEffectType(FlatBufferBuilder builder, int effectTypeOffset)
		{
			builder.AddOffset(3, effectTypeOffset, 0);
		}

		// Token: 0x06033EE5 RID: 212709 RVA: 0x006FC157 File Offset: 0x006FA357
		public static void AddTargetStateIndex(FlatBufferBuilder builder, int targetStateIndex)
		{
			builder.AddInt(4, targetStateIndex, 0);
		}

		// Token: 0x06033EE6 RID: 212710 RVA: 0x006FC162 File Offset: 0x006FA362
		public static Offset<ISwitchEffectState> EndISwitchEffectState(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchEffectState>(builder.EndTable());
		}

		// Token: 0x06033EE7 RID: 212711 RVA: 0x006FC170 File Offset: 0x006FA370
		public ISwitchEffectStateT UnPack()
		{
			ISwitchEffectStateT switchEffectStateT = new ISwitchEffectStateT();
			this.UnPackTo(switchEffectStateT);
			return switchEffectStateT;
		}

		// Token: 0x06033EE8 RID: 212712 RVA: 0x006FC18C File Offset: 0x006FA38C
		public void UnPackTo(ISwitchEffectStateT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
			_o.EffectType = new TSwitchEffectStateEffectTypeUnion();
			_o.EffectType.Type = this.EffectTypeType;
			TSwitchEffectStateEffectType effectTypeType = this.EffectTypeType;
			if (effectTypeType != TSwitchEffectStateEffectType.ISwitchScreenEffectState)
			{
				if (effectTypeType == TSwitchEffectStateEffectType.ISwitchTrailChainEffectState)
				{
					_o.EffectType.Value = ((this.EffectType<ISwitchTrailChainEffectState>() != null) ? this.EffectType<ISwitchTrailChainEffectState>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.EffectType.Value = ((this.EffectType<ISwitchScreenEffectState>() != null) ? this.EffectType<ISwitchScreenEffectState>().Value.UnPack() : null);
			}
			_o.TargetStateIndex = this.TargetStateIndex;
		}

		// Token: 0x06033EE9 RID: 212713 RVA: 0x006FC258 File Offset: 0x006FA458
		public static Offset<ISwitchEffectState> Pack(FlatBufferBuilder builder, ISwitchEffectStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchEffectState>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			TSwitchEffectStateEffectType effectType_type = (_o.EffectType == null) ? TSwitchEffectStateEffectType.NONE : _o.EffectType.Type;
			int effectTypeOffset = (_o.EffectType == null) ? 0 : TSwitchEffectStateEffectTypeUnion.Pack(builder, _o.EffectType);
			return ISwitchEffectState.CreateISwitchEffectState(builder, _o.Type, pathOffset, effectType_type, effectTypeOffset, _o.TargetStateIndex);
		}

		// Token: 0x04011D50 RID: 73040
		private Table __p;
	}
}
