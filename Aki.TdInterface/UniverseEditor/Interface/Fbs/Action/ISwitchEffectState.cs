using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A2E RID: 31278
	public struct ISwitchEffectState : IFlatbufferObject
	{
		// Token: 0x1700E52B RID: 58667
		// (get) Token: 0x060371D2 RID: 225746 RVA: 0x0075D251 File Offset: 0x0075B451
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060371D3 RID: 225747 RVA: 0x0075D25E File Offset: 0x0075B45E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060371D4 RID: 225748 RVA: 0x0075D268 File Offset: 0x0075B468
		public static ISwitchEffectState GetRootAsISwitchEffectState(ByteBuffer _bb)
		{
			return ISwitchEffectState.GetRootAsISwitchEffectState(_bb, default(ISwitchEffectState));
		}

		// Token: 0x060371D5 RID: 225749 RVA: 0x0075D284 File Offset: 0x0075B484
		public static ISwitchEffectState GetRootAsISwitchEffectState(ByteBuffer _bb, ISwitchEffectState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060371D6 RID: 225750 RVA: 0x0075D2A1 File Offset: 0x0075B4A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060371D7 RID: 225751 RVA: 0x0075D2B0 File Offset: 0x0075B4B0
		public ISwitchEffectState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E52C RID: 58668
		// (get) Token: 0x060371D8 RID: 225752 RVA: 0x0075D2C0 File Offset: 0x0075B4C0
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

		// Token: 0x1700E52D RID: 58669
		// (get) Token: 0x060371D9 RID: 225753 RVA: 0x0075D2FC File Offset: 0x0075B4FC
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

		// Token: 0x060371DA RID: 225754 RVA: 0x0075D333 File Offset: 0x0075B533
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060371DB RID: 225755 RVA: 0x0075D342 File Offset: 0x0075B542
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E52E RID: 58670
		// (get) Token: 0x060371DC RID: 225756 RVA: 0x0075D350 File Offset: 0x0075B550
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

		// Token: 0x060371DD RID: 225757 RVA: 0x0075D38C File Offset: 0x0075B58C
		public TTable? EffectType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060371DE RID: 225758 RVA: 0x0075D3D4 File Offset: 0x0075B5D4
		public ISwitchScreenEffectState EffectTypeAsISwitchScreenEffectState()
		{
			return this.EffectType<ISwitchScreenEffectState>().Value;
		}

		// Token: 0x060371DF RID: 225759 RVA: 0x0075D3F0 File Offset: 0x0075B5F0
		public ISwitchTrailChainEffectState EffectTypeAsISwitchTrailChainEffectState()
		{
			return this.EffectType<ISwitchTrailChainEffectState>().Value;
		}

		// Token: 0x1700E52F RID: 58671
		// (get) Token: 0x060371E0 RID: 225760 RVA: 0x0075D40C File Offset: 0x0075B60C
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

		// Token: 0x060371E1 RID: 225761 RVA: 0x0075D449 File Offset: 0x0075B649
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

		// Token: 0x060371E2 RID: 225762 RVA: 0x0075D47D File Offset: 0x0075B67D
		public static void StartISwitchEffectState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060371E3 RID: 225763 RVA: 0x0075D486 File Offset: 0x0075B686
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060371E4 RID: 225764 RVA: 0x0075D491 File Offset: 0x0075B691
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x060371E5 RID: 225765 RVA: 0x0075D4A1 File Offset: 0x0075B6A1
		public static void AddEffectTypeType(FlatBufferBuilder builder, TSwitchEffectStateEffectType effectTypeType)
		{
			builder.AddByte(2, (byte)effectTypeType, 0);
		}

		// Token: 0x060371E6 RID: 225766 RVA: 0x0075D4AC File Offset: 0x0075B6AC
		public static void AddEffectType(FlatBufferBuilder builder, int effectTypeOffset)
		{
			builder.AddOffset(3, effectTypeOffset, 0);
		}

		// Token: 0x060371E7 RID: 225767 RVA: 0x0075D4B7 File Offset: 0x0075B6B7
		public static void AddTargetStateIndex(FlatBufferBuilder builder, int targetStateIndex)
		{
			builder.AddInt(4, targetStateIndex, 0);
		}

		// Token: 0x060371E8 RID: 225768 RVA: 0x0075D4C2 File Offset: 0x0075B6C2
		public static Offset<ISwitchEffectState> EndISwitchEffectState(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchEffectState>(builder.EndTable());
		}

		// Token: 0x060371E9 RID: 225769 RVA: 0x0075D4D0 File Offset: 0x0075B6D0
		public ISwitchEffectStateT UnPack()
		{
			ISwitchEffectStateT switchEffectStateT = new ISwitchEffectStateT();
			this.UnPackTo(switchEffectStateT);
			return switchEffectStateT;
		}

		// Token: 0x060371EA RID: 225770 RVA: 0x0075D4EC File Offset: 0x0075B6EC
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

		// Token: 0x060371EB RID: 225771 RVA: 0x0075D5B8 File Offset: 0x0075B7B8
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

		// Token: 0x04012D52 RID: 77138
		private Table __p;
	}
}
