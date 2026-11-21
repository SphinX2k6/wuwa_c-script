using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A4F RID: 31311
	public struct ISyncVarToActorState : IFlatbufferObject
	{
		// Token: 0x1700E568 RID: 58728
		// (get) Token: 0x060372EF RID: 226031 RVA: 0x0075F2D9 File Offset: 0x0075D4D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060372F0 RID: 226032 RVA: 0x0075F2E6 File Offset: 0x0075D4E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060372F1 RID: 226033 RVA: 0x0075F2F0 File Offset: 0x0075D4F0
		public static ISyncVarToActorState GetRootAsISyncVarToActorState(ByteBuffer _bb)
		{
			return ISyncVarToActorState.GetRootAsISyncVarToActorState(_bb, default(ISyncVarToActorState));
		}

		// Token: 0x060372F2 RID: 226034 RVA: 0x0075F30C File Offset: 0x0075D50C
		public static ISyncVarToActorState GetRootAsISyncVarToActorState(ByteBuffer _bb, ISyncVarToActorState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060372F3 RID: 226035 RVA: 0x0075F329 File Offset: 0x0075D529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060372F4 RID: 226036 RVA: 0x0075F338 File Offset: 0x0075D538
		public ISyncVarToActorState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E569 RID: 58729
		// (get) Token: 0x060372F5 RID: 226037 RVA: 0x0075F348 File Offset: 0x0075D548
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

		// Token: 0x060372F6 RID: 226038 RVA: 0x0075F37F File Offset: 0x0075D57F
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060372F7 RID: 226039 RVA: 0x0075F38E File Offset: 0x0075D58E
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E56A RID: 58730
		// (get) Token: 0x060372F8 RID: 226040 RVA: 0x0075F39C File Offset: 0x0075D59C
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

		// Token: 0x060372F9 RID: 226041 RVA: 0x0075F3D3 File Offset: 0x0075D5D3
		public Span<byte> GetStateKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060372FA RID: 226042 RVA: 0x0075F3E2 File Offset: 0x0075D5E2
		public byte[] GetStateKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060372FB RID: 226043 RVA: 0x0075F3F0 File Offset: 0x0075D5F0
		public static Offset<ISyncVarToActorState> CreateISyncVarToActorState(FlatBufferBuilder builder, StringOffset VarNameOffset = default(StringOffset), StringOffset StateKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISyncVarToActorState.AddStateKey(builder, StateKeyOffset);
			ISyncVarToActorState.AddVarName(builder, VarNameOffset);
			return ISyncVarToActorState.EndISyncVarToActorState(builder);
		}

		// Token: 0x060372FC RID: 226044 RVA: 0x0075F40D File Offset: 0x0075D60D
		public static void StartISyncVarToActorState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060372FD RID: 226045 RVA: 0x0075F416 File Offset: 0x0075D616
		public static void AddVarName(FlatBufferBuilder builder, StringOffset varNameOffset)
		{
			builder.AddOffset(0, varNameOffset.Value, 0);
		}

		// Token: 0x060372FE RID: 226046 RVA: 0x0075F426 File Offset: 0x0075D626
		public static void AddStateKey(FlatBufferBuilder builder, StringOffset stateKeyOffset)
		{
			builder.AddOffset(1, stateKeyOffset.Value, 0);
		}

		// Token: 0x060372FF RID: 226047 RVA: 0x0075F436 File Offset: 0x0075D636
		public static Offset<ISyncVarToActorState> EndISyncVarToActorState(FlatBufferBuilder builder)
		{
			return new Offset<ISyncVarToActorState>(builder.EndTable());
		}

		// Token: 0x06037300 RID: 226048 RVA: 0x0075F444 File Offset: 0x0075D644
		public ISyncVarToActorStateT UnPack()
		{
			ISyncVarToActorStateT syncVarToActorStateT = new ISyncVarToActorStateT();
			this.UnPackTo(syncVarToActorStateT);
			return syncVarToActorStateT;
		}

		// Token: 0x06037301 RID: 226049 RVA: 0x0075F45F File Offset: 0x0075D65F
		public void UnPackTo(ISyncVarToActorStateT _o)
		{
			_o.VarName = this.VarName;
			_o.StateKey = this.StateKey;
		}

		// Token: 0x06037302 RID: 226050 RVA: 0x0075F47C File Offset: 0x0075D67C
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

		// Token: 0x04012D82 RID: 77186
		private Table __p;
	}
}
