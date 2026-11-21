using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054CC RID: 21708
	public struct IChildStateChangedConfig : IFlatbufferObject
	{
		// Token: 0x17009AFB RID: 39675
		// (get) Token: 0x060223E3 RID: 140259 RVA: 0x004B85A7 File Offset: 0x004B67A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060223E4 RID: 140260 RVA: 0x004B85B4 File Offset: 0x004B67B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060223E5 RID: 140261 RVA: 0x004B85BC File Offset: 0x004B67BC
		public static IChildStateChangedConfig GetRootAsIChildStateChangedConfig(ByteBuffer _bb)
		{
			return IChildStateChangedConfig.GetRootAsIChildStateChangedConfig(_bb, default(IChildStateChangedConfig));
		}

		// Token: 0x060223E6 RID: 140262 RVA: 0x004B85D8 File Offset: 0x004B67D8
		public static IChildStateChangedConfig GetRootAsIChildStateChangedConfig(ByteBuffer _bb, IChildStateChangedConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060223E7 RID: 140263 RVA: 0x004B85F5 File Offset: 0x004B67F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060223E8 RID: 140264 RVA: 0x004B8604 File Offset: 0x004B6804
		public IChildStateChangedConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AFC RID: 39676
		// (get) Token: 0x060223E9 RID: 140265 RVA: 0x004B8614 File Offset: 0x004B6814
		public string State
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

		// Token: 0x060223EA RID: 140266 RVA: 0x004B864B File Offset: 0x004B684B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060223EB RID: 140267 RVA: 0x004B865A File Offset: 0x004B685A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009AFD RID: 39677
		// (get) Token: 0x060223EC RID: 140268 RVA: 0x004B8668 File Offset: 0x004B6868
		public IDelayChangeState? DelayChangeState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDelayChangeState?(default(IDelayChangeState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060223ED RID: 140269 RVA: 0x004B86C5 File Offset: 0x004B68C5
		public static Offset<IChildStateChangedConfig> CreateIChildStateChangedConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), Offset<IDelayChangeState> DelayChangeStateOffset = default(Offset<IDelayChangeState>))
		{
			builder.StartTable(2);
			IChildStateChangedConfig.AddDelayChangeState(builder, DelayChangeStateOffset);
			IChildStateChangedConfig.AddState(builder, StateOffset);
			return IChildStateChangedConfig.EndIChildStateChangedConfig(builder);
		}

		// Token: 0x060223EE RID: 140270 RVA: 0x004B86E2 File Offset: 0x004B68E2
		public static void StartIChildStateChangedConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060223EF RID: 140271 RVA: 0x004B86EB File Offset: 0x004B68EB
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x060223F0 RID: 140272 RVA: 0x004B86FB File Offset: 0x004B68FB
		public static void AddDelayChangeState(FlatBufferBuilder builder, Offset<IDelayChangeState> delayChangeStateOffset)
		{
			builder.AddOffset(1, delayChangeStateOffset.Value, 0);
		}

		// Token: 0x060223F1 RID: 140273 RVA: 0x004B870B File Offset: 0x004B690B
		public static Offset<IChildStateChangedConfig> EndIChildStateChangedConfig(FlatBufferBuilder builder)
		{
			return new Offset<IChildStateChangedConfig>(builder.EndTable());
		}

		// Token: 0x060223F2 RID: 140274 RVA: 0x004B8718 File Offset: 0x004B6918
		public IChildStateChangedConfigT UnPack()
		{
			IChildStateChangedConfigT childStateChangedConfigT = new IChildStateChangedConfigT();
			this.UnPackTo(childStateChangedConfigT);
			return childStateChangedConfigT;
		}

		// Token: 0x060223F3 RID: 140275 RVA: 0x004B8734 File Offset: 0x004B6934
		public void UnPackTo(IChildStateChangedConfigT _o)
		{
			_o.State = this.State;
			_o.DelayChangeState = ((this.DelayChangeState != null) ? this.DelayChangeState.Value.UnPack() : null);
		}

		// Token: 0x060223F4 RID: 140276 RVA: 0x004B877C File Offset: 0x004B697C
		public static Offset<IChildStateChangedConfig> Pack(FlatBufferBuilder builder, IChildStateChangedConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildStateChangedConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			Offset<IDelayChangeState> delayChangeStateOffset = (_o.DelayChangeState == null) ? default(Offset<IDelayChangeState>) : IDelayChangeState.Pack(builder, _o.DelayChangeState);
			return IChildStateChangedConfig.CreateIChildStateChangedConfig(builder, stateOffset, delayChangeStateOffset);
		}

		// Token: 0x0400EA11 RID: 59921
		private Table __p;
	}
}
