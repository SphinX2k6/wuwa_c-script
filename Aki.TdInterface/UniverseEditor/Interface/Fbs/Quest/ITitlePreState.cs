using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200463D RID: 17981
	public struct ITitlePreState : IFlatbufferObject
	{
		// Token: 0x17007DD7 RID: 32215
		// (get) Token: 0x0601A538 RID: 107832 RVA: 0x003BF4BF File Offset: 0x003BD6BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A539 RID: 107833 RVA: 0x003BF4CC File Offset: 0x003BD6CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A53A RID: 107834 RVA: 0x003BF4D4 File Offset: 0x003BD6D4
		public static ITitlePreState GetRootAsITitlePreState(ByteBuffer _bb)
		{
			return ITitlePreState.GetRootAsITitlePreState(_bb, default(ITitlePreState));
		}

		// Token: 0x0601A53B RID: 107835 RVA: 0x003BF4F0 File Offset: 0x003BD6F0
		public static ITitlePreState GetRootAsITitlePreState(ByteBuffer _bb, ITitlePreState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A53C RID: 107836 RVA: 0x003BF50D File Offset: 0x003BD70D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A53D RID: 107837 RVA: 0x003BF51C File Offset: 0x003BD71C
		public ITitlePreState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DD8 RID: 32216
		// (get) Token: 0x0601A53E RID: 107838 RVA: 0x003BF52C File Offset: 0x003BD72C
		public string TidPreStateTitle
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

		// Token: 0x0601A53F RID: 107839 RVA: 0x003BF563 File Offset: 0x003BD763
		public Span<byte> GetTidPreStateTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601A540 RID: 107840 RVA: 0x003BF572 File Offset: 0x003BD772
		public byte[] GetTidPreStateTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17007DD9 RID: 32217
		// (get) Token: 0x0601A541 RID: 107841 RVA: 0x003BF580 File Offset: 0x003BD780
		public IConditionGroup? SwitchConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A542 RID: 107842 RVA: 0x003BF5DD File Offset: 0x003BD7DD
		public static Offset<ITitlePreState> CreateITitlePreState(FlatBufferBuilder builder, StringOffset TidPreStateTitleOffset = default(StringOffset), Offset<IConditionGroup> SwitchConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ITitlePreState.AddSwitchConditions(builder, SwitchConditionsOffset);
			ITitlePreState.AddTidPreStateTitle(builder, TidPreStateTitleOffset);
			return ITitlePreState.EndITitlePreState(builder);
		}

		// Token: 0x0601A543 RID: 107843 RVA: 0x003BF5FA File Offset: 0x003BD7FA
		public static void StartITitlePreState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A544 RID: 107844 RVA: 0x003BF603 File Offset: 0x003BD803
		public static void AddTidPreStateTitle(FlatBufferBuilder builder, StringOffset tidPreStateTitleOffset)
		{
			builder.AddOffset(0, tidPreStateTitleOffset.Value, 0);
		}

		// Token: 0x0601A545 RID: 107845 RVA: 0x003BF613 File Offset: 0x003BD813
		public static void AddSwitchConditions(FlatBufferBuilder builder, Offset<IConditionGroup> switchConditionsOffset)
		{
			builder.AddOffset(1, switchConditionsOffset.Value, 0);
		}

		// Token: 0x0601A546 RID: 107846 RVA: 0x003BF623 File Offset: 0x003BD823
		public static Offset<ITitlePreState> EndITitlePreState(FlatBufferBuilder builder)
		{
			return new Offset<ITitlePreState>(builder.EndTable());
		}

		// Token: 0x0601A547 RID: 107847 RVA: 0x003BF630 File Offset: 0x003BD830
		public ITitlePreStateT UnPack()
		{
			ITitlePreStateT titlePreStateT = new ITitlePreStateT();
			this.UnPackTo(titlePreStateT);
			return titlePreStateT;
		}

		// Token: 0x0601A548 RID: 107848 RVA: 0x003BF64C File Offset: 0x003BD84C
		public void UnPackTo(ITitlePreStateT _o)
		{
			_o.TidPreStateTitle = this.TidPreStateTitle;
			_o.SwitchConditions = ((this.SwitchConditions != null) ? this.SwitchConditions.Value.UnPack() : null);
		}

		// Token: 0x0601A549 RID: 107849 RVA: 0x003BF694 File Offset: 0x003BD894
		public static Offset<ITitlePreState> Pack(FlatBufferBuilder builder, ITitlePreStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITitlePreState>);
			}
			StringOffset tidPreStateTitleOffset = (_o.TidPreStateTitle == null) ? default(StringOffset) : builder.CreateString(_o.TidPreStateTitle);
			Offset<IConditionGroup> switchConditionsOffset = (_o.SwitchConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.SwitchConditions);
			return ITitlePreState.CreateITitlePreState(builder, tidPreStateTitleOffset, switchConditionsOffset);
		}

		// Token: 0x0400C843 RID: 51267
		private Table __p;
	}
}
