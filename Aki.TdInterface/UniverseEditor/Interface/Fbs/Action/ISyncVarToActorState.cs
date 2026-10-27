using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200727A RID: 29306
	public struct ISyncVarToActorState : IFlatbufferObject
	{
		// Token: 0x1700D96F RID: 55663
		// (get) Token: 0x06033FED RID: 212973 RVA: 0x006FDF79 File Offset: 0x006FC179
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033FEE RID: 212974 RVA: 0x006FDF86 File Offset: 0x006FC186
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033FEF RID: 212975 RVA: 0x006FDF90 File Offset: 0x006FC190
		public static ISyncVarToActorState GetRootAsISyncVarToActorState(ByteBuffer _bb)
		{
			return ISyncVarToActorState.GetRootAsISyncVarToActorState(_bb, default(ISyncVarToActorState));
		}

		// Token: 0x06033FF0 RID: 212976 RVA: 0x006FDFAC File Offset: 0x006FC1AC
		public static ISyncVarToActorState GetRootAsISyncVarToActorState(ByteBuffer _bb, ISyncVarToActorState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033FF1 RID: 212977 RVA: 0x006FDFC9 File Offset: 0x006FC1C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033FF2 RID: 212978 RVA: 0x006FDFD8 File Offset: 0x006FC1D8
		public ISyncVarToActorState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D970 RID: 55664
		// (get) Token: 0x06033FF3 RID: 212979 RVA: 0x006FDFE8 File Offset: 0x006FC1E8
		public string VarName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033FF4 RID: 212980 RVA: 0x006FE01F File Offset: 0x006FC21F
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06033FF5 RID: 212981 RVA: 0x006FE02E File Offset: 0x006FC22E
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D971 RID: 55665
		// (get) Token: 0x06033FF6 RID: 212982 RVA: 0x006FE03C File Offset: 0x006FC23C
		public string StateKey
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

		// Token: 0x06033FF7 RID: 212983 RVA: 0x006FE073 File Offset: 0x006FC273
		public Span<byte> GetStateKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033FF8 RID: 212984 RVA: 0x006FE082 File Offset: 0x006FC282
		public byte[] GetStateKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06033FF9 RID: 212985 RVA: 0x006FE090 File Offset: 0x006FC290
		public static Offset<ISyncVarToActorState> CreateISyncVarToActorState(FlatBufferBuilder builder, StringOffset VarNameOffset = default(StringOffset), StringOffset StateKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISyncVarToActorState.AddStateKey(builder, StateKeyOffset);
			ISyncVarToActorState.AddVarName(builder, VarNameOffset);
			return ISyncVarToActorState.EndISyncVarToActorState(builder);
		}

		// Token: 0x06033FFA RID: 212986 RVA: 0x006FE0AD File Offset: 0x006FC2AD
		public static void StartISyncVarToActorState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033FFB RID: 212987 RVA: 0x006FE0B6 File Offset: 0x006FC2B6
		public static void AddVarName(FlatBufferBuilder builder, StringOffset varNameOffset)
		{
			builder.AddOffset(0, varNameOffset.Value, 0);
		}

		// Token: 0x06033FFC RID: 212988 RVA: 0x006FE0C6 File Offset: 0x006FC2C6
		public static void AddStateKey(FlatBufferBuilder builder, StringOffset stateKeyOffset)
		{
			builder.AddOffset(1, stateKeyOffset.Value, 0);
		}

		// Token: 0x06033FFD RID: 212989 RVA: 0x006FE0D6 File Offset: 0x006FC2D6
		public static Offset<ISyncVarToActorState> EndISyncVarToActorState(FlatBufferBuilder builder)
		{
			return new Offset<ISyncVarToActorState>(builder.EndTable());
		}

		// Token: 0x06033FFE RID: 212990 RVA: 0x006FE0E4 File Offset: 0x006FC2E4
		public ISyncVarToActorStateT UnPack()
		{
			ISyncVarToActorStateT syncVarToActorStateT = new ISyncVarToActorStateT();
			this.UnPackTo(syncVarToActorStateT);
			return syncVarToActorStateT;
		}

		// Token: 0x06033FFF RID: 212991 RVA: 0x006FE0FF File Offset: 0x006FC2FF
		public void UnPackTo(ISyncVarToActorStateT _o)
		{
			_o.VarName = this.VarName;
			_o.StateKey = this.StateKey;
		}

		// Token: 0x06034000 RID: 212992 RVA: 0x006FE11C File Offset: 0x006FC31C
		public static Offset<ISyncVarToActorState> Pack(FlatBufferBuilder builder, ISyncVarToActorStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISyncVarToActorState>);
			}
			StringOffset varNameOffset = (_o.VarName == null) ? default(StringOffset) : builder.CreateString(_o.VarName);
			StringOffset stateKeyOffset = (_o.StateKey == null) ? default(StringOffset) : builder.CreateString(_o.StateKey);
			return ISyncVarToActorState.CreateISyncVarToActorState(builder, varNameOffset, stateKeyOffset);
		}

		// Token: 0x04011D80 RID: 73088
		private Table __p;
	}
}
