using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007496 RID: 29846
	public struct ITuningStandBubbleConfig : IFlatbufferObject
	{
		// Token: 0x1700E2A1 RID: 58017
		// (get) Token: 0x06036406 RID: 222214 RVA: 0x007600BF File Offset: 0x0075E2BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036407 RID: 222215 RVA: 0x007600CC File Offset: 0x0075E2CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036408 RID: 222216 RVA: 0x007600D4 File Offset: 0x0075E2D4
		public static ITuningStandBubbleConfig GetRootAsITuningStandBubbleConfig(ByteBuffer _bb)
		{
			return ITuningStandBubbleConfig.GetRootAsITuningStandBubbleConfig(_bb, default(ITuningStandBubbleConfig));
		}

		// Token: 0x06036409 RID: 222217 RVA: 0x007600F0 File Offset: 0x0075E2F0
		public static ITuningStandBubbleConfig GetRootAsITuningStandBubbleConfig(ByteBuffer _bb, ITuningStandBubbleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603640A RID: 222218 RVA: 0x0076010D File Offset: 0x0075E30D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603640B RID: 222219 RVA: 0x0076011C File Offset: 0x0075E31C
		public ITuningStandBubbleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2A2 RID: 58018
		// (get) Token: 0x0603640C RID: 222220 RVA: 0x0076012C File Offset: 0x0075E32C
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

		// Token: 0x1700E2A3 RID: 58019
		// (get) Token: 0x0603640D RID: 222221 RVA: 0x00760168 File Offset: 0x0075E368
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

		// Token: 0x0603640E RID: 222222 RVA: 0x007601C5 File Offset: 0x0075E3C5
		public static Offset<ITuningStandBubbleConfig> CreateITuningStandBubbleConfig(FlatBufferBuilder builder, ETuningStandBubbleTriggerType TriggerType = ETuningStandBubbleTriggerType.Enter, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			ITuningStandBubbleConfig.AddFlow(builder, FlowOffset);
			ITuningStandBubbleConfig.AddTriggerType(builder, TriggerType);
			return ITuningStandBubbleConfig.EndITuningStandBubbleConfig(builder);
		}

		// Token: 0x0603640F RID: 222223 RVA: 0x007601E2 File Offset: 0x0075E3E2
		public static void StartITuningStandBubbleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036410 RID: 222224 RVA: 0x007601EB File Offset: 0x0075E3EB
		public static void AddTriggerType(FlatBufferBuilder builder, ETuningStandBubbleTriggerType triggerType)
		{
			builder.AddByte(0, (byte)triggerType, 0);
		}

		// Token: 0x06036411 RID: 222225 RVA: 0x007601F6 File Offset: 0x0075E3F6
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x06036412 RID: 222226 RVA: 0x00760206 File Offset: 0x0075E406
		public static Offset<ITuningStandBubbleConfig> EndITuningStandBubbleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITuningStandBubbleConfig>(builder.EndTable());
		}

		// Token: 0x06036413 RID: 222227 RVA: 0x00760214 File Offset: 0x0075E414
		public ITuningStandBubbleConfigT UnPack()
		{
			ITuningStandBubbleConfigT tuningStandBubbleConfigT = new ITuningStandBubbleConfigT();
			this.UnPackTo(tuningStandBubbleConfigT);
			return tuningStandBubbleConfigT;
		}

		// Token: 0x06036414 RID: 222228 RVA: 0x00760230 File Offset: 0x0075E430
		public void UnPackTo(ITuningStandBubbleConfigT _o)
		{
			_o.TriggerType = this.TriggerType;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x06036415 RID: 222229 RVA: 0x00760278 File Offset: 0x0075E478
		public static Offset<ITuningStandBubbleConfig> Pack(FlatBufferBuilder builder, ITuningStandBubbleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITuningStandBubbleConfig>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return ITuningStandBubbleConfig.CreateITuningStandBubbleConfig(builder, _o.TriggerType, flowOffset);
		}

		// Token: 0x04012335 RID: 74549
		private Table __p;
	}
}
