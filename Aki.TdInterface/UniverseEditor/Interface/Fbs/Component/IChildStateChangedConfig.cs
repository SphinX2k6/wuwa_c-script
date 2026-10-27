using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F9D RID: 20381
	public struct IChildStateChangedConfig : IFlatbufferObject
	{
		// Token: 0x17009382 RID: 37762
		// (get) Token: 0x06020691 RID: 132753 RVA: 0x004825B7 File Offset: 0x004807B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020692 RID: 132754 RVA: 0x004825C4 File Offset: 0x004807C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020693 RID: 132755 RVA: 0x004825CC File Offset: 0x004807CC
		public static IChildStateChangedConfig GetRootAsIChildStateChangedConfig(ByteBuffer _bb)
		{
			return IChildStateChangedConfig.GetRootAsIChildStateChangedConfig(_bb, default(IChildStateChangedConfig));
		}

		// Token: 0x06020694 RID: 132756 RVA: 0x004825E8 File Offset: 0x004807E8
		public static IChildStateChangedConfig GetRootAsIChildStateChangedConfig(ByteBuffer _bb, IChildStateChangedConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020695 RID: 132757 RVA: 0x00482605 File Offset: 0x00480805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020696 RID: 132758 RVA: 0x00482614 File Offset: 0x00480814
		public IChildStateChangedConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009383 RID: 37763
		// (get) Token: 0x06020697 RID: 132759 RVA: 0x00482624 File Offset: 0x00480824
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

		// Token: 0x06020698 RID: 132760 RVA: 0x0048265B File Offset: 0x0048085B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06020699 RID: 132761 RVA: 0x0048266A File Offset: 0x0048086A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009384 RID: 37764
		// (get) Token: 0x0602069A RID: 132762 RVA: 0x00482678 File Offset: 0x00480878
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

		// Token: 0x0602069B RID: 132763 RVA: 0x004826D5 File Offset: 0x004808D5
		public static Offset<IChildStateChangedConfig> CreateIChildStateChangedConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), Offset<IDelayChangeState> DelayChangeStateOffset = default(Offset<IDelayChangeState>))
		{
			builder.StartTable(2);
			IChildStateChangedConfig.AddDelayChangeState(builder, DelayChangeStateOffset);
			IChildStateChangedConfig.AddState(builder, StateOffset);
			return IChildStateChangedConfig.EndIChildStateChangedConfig(builder);
		}

		// Token: 0x0602069C RID: 132764 RVA: 0x004826F2 File Offset: 0x004808F2
		public static void StartIChildStateChangedConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602069D RID: 132765 RVA: 0x004826FB File Offset: 0x004808FB
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x0602069E RID: 132766 RVA: 0x0048270B File Offset: 0x0048090B
		public static void AddDelayChangeState(FlatBufferBuilder builder, Offset<IDelayChangeState> delayChangeStateOffset)
		{
			builder.AddOffset(1, delayChangeStateOffset.Value, 0);
		}

		// Token: 0x0602069F RID: 132767 RVA: 0x0048271B File Offset: 0x0048091B
		public static Offset<IChildStateChangedConfig> EndIChildStateChangedConfig(FlatBufferBuilder builder)
		{
			return new Offset<IChildStateChangedConfig>(builder.EndTable());
		}

		// Token: 0x060206A0 RID: 132768 RVA: 0x00482728 File Offset: 0x00480928
		public IChildStateChangedConfigT UnPack()
		{
			IChildStateChangedConfigT childStateChangedConfigT = new IChildStateChangedConfigT();
			this.UnPackTo(childStateChangedConfigT);
			return childStateChangedConfigT;
		}

		// Token: 0x060206A1 RID: 132769 RVA: 0x00482744 File Offset: 0x00480944
		public void UnPackTo(IChildStateChangedConfigT _o)
		{
			_o.State = this.State;
			_o.DelayChangeState = ((this.DelayChangeState != null) ? this.DelayChangeState.Value.UnPack() : null);
		}

		// Token: 0x060206A2 RID: 132770 RVA: 0x0048278C File Offset: 0x0048098C
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

		// Token: 0x0400DE67 RID: 56935
		private Table __p;
	}
}
