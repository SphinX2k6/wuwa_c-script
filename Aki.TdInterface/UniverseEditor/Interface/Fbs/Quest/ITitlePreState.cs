using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E4 RID: 16868
	public struct ITitlePreState : IFlatbufferObject
	{
		// Token: 0x170077AB RID: 30635
		// (get) Token: 0x06018DE2 RID: 101858 RVA: 0x0039406B File Offset: 0x0039226B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018DE3 RID: 101859 RVA: 0x00394078 File Offset: 0x00392278
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018DE4 RID: 101860 RVA: 0x00394080 File Offset: 0x00392280
		public static ITitlePreState GetRootAsITitlePreState(ByteBuffer _bb)
		{
			return ITitlePreState.GetRootAsITitlePreState(_bb, default(ITitlePreState));
		}

		// Token: 0x06018DE5 RID: 101861 RVA: 0x0039409C File Offset: 0x0039229C
		public static ITitlePreState GetRootAsITitlePreState(ByteBuffer _bb, ITitlePreState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018DE6 RID: 101862 RVA: 0x003940B9 File Offset: 0x003922B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018DE7 RID: 101863 RVA: 0x003940C8 File Offset: 0x003922C8
		public ITitlePreState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077AC RID: 30636
		// (get) Token: 0x06018DE8 RID: 101864 RVA: 0x003940D8 File Offset: 0x003922D8
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

		// Token: 0x06018DE9 RID: 101865 RVA: 0x0039410F File Offset: 0x0039230F
		public Span<byte> GetTidPreStateTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06018DEA RID: 101866 RVA: 0x0039411E File Offset: 0x0039231E
		public byte[] GetTidPreStateTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170077AD RID: 30637
		// (get) Token: 0x06018DEB RID: 101867 RVA: 0x0039412C File Offset: 0x0039232C
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

		// Token: 0x06018DEC RID: 101868 RVA: 0x00394189 File Offset: 0x00392389
		public static Offset<ITitlePreState> CreateITitlePreState(FlatBufferBuilder builder, StringOffset TidPreStateTitleOffset = default(StringOffset), Offset<IConditionGroup> SwitchConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ITitlePreState.AddSwitchConditions(builder, SwitchConditionsOffset);
			ITitlePreState.AddTidPreStateTitle(builder, TidPreStateTitleOffset);
			return ITitlePreState.EndITitlePreState(builder);
		}

		// Token: 0x06018DED RID: 101869 RVA: 0x003941A6 File Offset: 0x003923A6
		public static void StartITitlePreState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018DEE RID: 101870 RVA: 0x003941AF File Offset: 0x003923AF
		public static void AddTidPreStateTitle(FlatBufferBuilder builder, StringOffset tidPreStateTitleOffset)
		{
			builder.AddOffset(0, tidPreStateTitleOffset.Value, 0);
		}

		// Token: 0x06018DEF RID: 101871 RVA: 0x003941BF File Offset: 0x003923BF
		public static void AddSwitchConditions(FlatBufferBuilder builder, Offset<IConditionGroup> switchConditionsOffset)
		{
			builder.AddOffset(1, switchConditionsOffset.Value, 0);
		}

		// Token: 0x06018DF0 RID: 101872 RVA: 0x003941CF File Offset: 0x003923CF
		public static Offset<ITitlePreState> EndITitlePreState(FlatBufferBuilder builder)
		{
			return new Offset<ITitlePreState>(builder.EndTable());
		}

		// Token: 0x06018DF1 RID: 101873 RVA: 0x003941DC File Offset: 0x003923DC
		public ITitlePreStateT UnPack()
		{
			ITitlePreStateT titlePreStateT = new ITitlePreStateT();
			this.UnPackTo(titlePreStateT);
			return titlePreStateT;
		}

		// Token: 0x06018DF2 RID: 101874 RVA: 0x003941F8 File Offset: 0x003923F8
		public void UnPackTo(ITitlePreStateT _o)
		{
			_o.TidPreStateTitle = this.TidPreStateTitle;
			_o.SwitchConditions = ((this.SwitchConditions != null) ? this.SwitchConditions.Value.UnPack() : null);
		}

		// Token: 0x06018DF3 RID: 101875 RVA: 0x00394240 File Offset: 0x00392440
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

		// Token: 0x0400BE39 RID: 48697
		private Table __p;
	}
}
