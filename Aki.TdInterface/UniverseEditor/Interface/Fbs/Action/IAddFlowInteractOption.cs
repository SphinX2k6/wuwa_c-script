using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006128 RID: 24872
	public struct IAddFlowInteractOption : IFlatbufferObject
	{
		// Token: 0x1700B74C RID: 46924
		// (get) Token: 0x0602A835 RID: 174133 RVA: 0x005DABBA File Offset: 0x005D8DBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A836 RID: 174134 RVA: 0x005DABC7 File Offset: 0x005D8DC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A837 RID: 174135 RVA: 0x005DABD0 File Offset: 0x005D8DD0
		public static IAddFlowInteractOption GetRootAsIAddFlowInteractOption(ByteBuffer _bb)
		{
			return IAddFlowInteractOption.GetRootAsIAddFlowInteractOption(_bb, default(IAddFlowInteractOption));
		}

		// Token: 0x0602A838 RID: 174136 RVA: 0x005DABEC File Offset: 0x005D8DEC
		public static IAddFlowInteractOption GetRootAsIAddFlowInteractOption(ByteBuffer _bb, IAddFlowInteractOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A839 RID: 174137 RVA: 0x005DAC09 File Offset: 0x005D8E09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A83A RID: 174138 RVA: 0x005DAC18 File Offset: 0x005D8E18
		public IAddFlowInteractOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B74D RID: 46925
		// (get) Token: 0x0602A83B RID: 174139 RVA: 0x005DAC28 File Offset: 0x005D8E28
		public IInteractOption? Option
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IInteractOption?(default(IInteractOption).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B74E RID: 46926
		// (get) Token: 0x0602A83C RID: 174140 RVA: 0x005DAC88 File Offset: 0x005D8E88
		public int EntityId
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

		// Token: 0x1700B74F RID: 46927
		// (get) Token: 0x0602A83D RID: 174141 RVA: 0x005DACC4 File Offset: 0x005D8EC4
		public bool DelayRemoveByQuestEnd
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B750 RID: 46928
		// (get) Token: 0x0602A83E RID: 174142 RVA: 0x005DAD04 File Offset: 0x005D8F04
		public string InteractToken
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A83F RID: 174143 RVA: 0x005DAD3C File Offset: 0x005D8F3C
		public Span<byte> GetInteractTokenBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602A840 RID: 174144 RVA: 0x005DAD4C File Offset: 0x005D8F4C
		public byte[] GetInteractTokenArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700B751 RID: 46929
		// (get) Token: 0x0602A841 RID: 174145 RVA: 0x005DAD5C File Offset: 0x005D8F5C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A842 RID: 174146 RVA: 0x005DAD99 File Offset: 0x005D8F99
		public static Offset<IAddFlowInteractOption> CreateIAddFlowInteractOption(FlatBufferBuilder builder, Offset<IInteractOption> OptionOffset = default(Offset<IInteractOption>), int EntityId = 0, bool DelayRemoveByQuestEnd = false, StringOffset InteractTokenOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IAddFlowInteractOption.AddInteractToken(builder, InteractTokenOffset);
			IAddFlowInteractOption.AddEntityId(builder, EntityId);
			IAddFlowInteractOption.AddOption(builder, OptionOffset);
			IAddFlowInteractOption.AddNullMask(builder, NullMask);
			IAddFlowInteractOption.AddDelayRemoveByQuestEnd(builder, DelayRemoveByQuestEnd);
			return IAddFlowInteractOption.EndIAddFlowInteractOption(builder);
		}

		// Token: 0x0602A843 RID: 174147 RVA: 0x005DADCD File Offset: 0x005D8FCD
		public static void StartIAddFlowInteractOption(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602A844 RID: 174148 RVA: 0x005DADD6 File Offset: 0x005D8FD6
		public static void AddOption(FlatBufferBuilder builder, Offset<IInteractOption> optionOffset)
		{
			builder.AddOffset(0, optionOffset.Value, 0);
		}

		// Token: 0x0602A845 RID: 174149 RVA: 0x005DADE6 File Offset: 0x005D8FE6
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602A846 RID: 174150 RVA: 0x005DADF1 File Offset: 0x005D8FF1
		public static void AddDelayRemoveByQuestEnd(FlatBufferBuilder builder, bool delayRemoveByQuestEnd)
		{
			builder.AddBool(2, delayRemoveByQuestEnd, false);
		}

		// Token: 0x0602A847 RID: 174151 RVA: 0x005DADFC File Offset: 0x005D8FFC
		public static void AddInteractToken(FlatBufferBuilder builder, StringOffset interactTokenOffset)
		{
			builder.AddOffset(3, interactTokenOffset.Value, 0);
		}

		// Token: 0x0602A848 RID: 174152 RVA: 0x005DAE0C File Offset: 0x005D900C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602A849 RID: 174153 RVA: 0x005DAE17 File Offset: 0x005D9017
		public static Offset<IAddFlowInteractOption> EndIAddFlowInteractOption(FlatBufferBuilder builder)
		{
			return new Offset<IAddFlowInteractOption>(builder.EndTable());
		}

		// Token: 0x0602A84A RID: 174154 RVA: 0x005DAE24 File Offset: 0x005D9024
		public IAddFlowInteractOptionT UnPack()
		{
			IAddFlowInteractOptionT addFlowInteractOptionT = new IAddFlowInteractOptionT();
			this.UnPackTo(addFlowInteractOptionT);
			return addFlowInteractOptionT;
		}

		// Token: 0x0602A84B RID: 174155 RVA: 0x005DAE40 File Offset: 0x005D9040
		public void UnPackTo(IAddFlowInteractOptionT _o)
		{
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.DelayRemoveByQuestEnd = this.DelayRemoveByQuestEnd;
			_o.InteractToken = this.InteractToken;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A84C RID: 174156 RVA: 0x005DAEAC File Offset: 0x005D90AC
		public static Offset<IAddFlowInteractOption> Pack(FlatBufferBuilder builder, IAddFlowInteractOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddFlowInteractOption>);
			}
			Offset<IInteractOption> optionOffset = (_o.Option == null) ? default(Offset<IInteractOption>) : IInteractOption.Pack(builder, _o.Option);
			StringOffset interactTokenOffset = (_o.InteractToken == null) ? default(StringOffset) : builder.CreateString(_o.InteractToken);
			return IAddFlowInteractOption.CreateIAddFlowInteractOption(builder, optionOffset, _o.EntityId, _o.DelayRemoveByQuestEnd, interactTokenOffset, _o.NullMask);
		}

		// Token: 0x040104FA RID: 66810
		private Table __p;
	}
}
