using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C89 RID: 31881
	public struct ITuningStandBubbleConfig : IFlatbufferObject
	{
		// Token: 0x1700EEC0 RID: 61120
		// (get) Token: 0x060397F3 RID: 235507 RVA: 0x007C2E7B File Offset: 0x007C107B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060397F4 RID: 235508 RVA: 0x007C2E88 File Offset: 0x007C1088
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060397F5 RID: 235509 RVA: 0x007C2E90 File Offset: 0x007C1090
		public static ITuningStandBubbleConfig GetRootAsITuningStandBubbleConfig(ByteBuffer _bb)
		{
			return ITuningStandBubbleConfig.GetRootAsITuningStandBubbleConfig(_bb, default(ITuningStandBubbleConfig));
		}

		// Token: 0x060397F6 RID: 235510 RVA: 0x007C2EAC File Offset: 0x007C10AC
		public static ITuningStandBubbleConfig GetRootAsITuningStandBubbleConfig(ByteBuffer _bb, ITuningStandBubbleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060397F7 RID: 235511 RVA: 0x007C2EC9 File Offset: 0x007C10C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060397F8 RID: 235512 RVA: 0x007C2ED8 File Offset: 0x007C10D8
		public ITuningStandBubbleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EEC1 RID: 61121
		// (get) Token: 0x060397F9 RID: 235513 RVA: 0x007C2EE8 File Offset: 0x007C10E8
		public ETuningStandBubbleTriggerType TriggerType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETuningStandBubbleTriggerType.Enter;
				}
				return (ETuningStandBubbleTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EEC2 RID: 61122
		// (get) Token: 0x060397FA RID: 235514 RVA: 0x007C2F24 File Offset: 0x007C1124
		public IPlayFlow? Flow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060397FB RID: 235515 RVA: 0x007C2F81 File Offset: 0x007C1181
		public static Offset<ITuningStandBubbleConfig> CreateITuningStandBubbleConfig(FlatBufferBuilder builder, ETuningStandBubbleTriggerType TriggerType = ETuningStandBubbleTriggerType.Enter, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			ITuningStandBubbleConfig.AddFlow(builder, FlowOffset);
			ITuningStandBubbleConfig.AddTriggerType(builder, TriggerType);
			return ITuningStandBubbleConfig.EndITuningStandBubbleConfig(builder);
		}

		// Token: 0x060397FC RID: 235516 RVA: 0x007C2F9E File Offset: 0x007C119E
		public static void StartITuningStandBubbleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060397FD RID: 235517 RVA: 0x007C2FA7 File Offset: 0x007C11A7
		public static void AddTriggerType(FlatBufferBuilder builder, ETuningStandBubbleTriggerType triggerType)
		{
			builder.AddByte(0, (byte)triggerType, 0);
		}

		// Token: 0x060397FE RID: 235518 RVA: 0x007C2FB2 File Offset: 0x007C11B2
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x060397FF RID: 235519 RVA: 0x007C2FC2 File Offset: 0x007C11C2
		public static Offset<ITuningStandBubbleConfig> EndITuningStandBubbleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITuningStandBubbleConfig>(builder.EndTable());
		}

		// Token: 0x06039800 RID: 235520 RVA: 0x007C2FD0 File Offset: 0x007C11D0
		public ITuningStandBubbleConfigT UnPack()
		{
			ITuningStandBubbleConfigT tuningStandBubbleConfigT = new ITuningStandBubbleConfigT();
			this.UnPackTo(tuningStandBubbleConfigT);
			return tuningStandBubbleConfigT;
		}

		// Token: 0x06039801 RID: 235521 RVA: 0x007C2FEC File Offset: 0x007C11EC
		public void UnPackTo(ITuningStandBubbleConfigT _o)
		{
			_o.TriggerType = this.TriggerType;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x06039802 RID: 235522 RVA: 0x007C3034 File Offset: 0x007C1234
		public static Offset<ITuningStandBubbleConfig> Pack(FlatBufferBuilder builder, ITuningStandBubbleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITuningStandBubbleConfig>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return ITuningStandBubbleConfig.CreateITuningStandBubbleConfig(builder, _o.TriggerType, flowOffset);
		}

		// Token: 0x0401335D RID: 78685
		private Table __p;
	}
}
