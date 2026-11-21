using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D97 RID: 19863
	public struct IFrequencyDetectTalkConfig : IFlatbufferObject
	{
		// Token: 0x17008E1F RID: 36383
		// (get) Token: 0x0601ECDF RID: 126175 RVA: 0x0044E6F0 File Offset: 0x0044C8F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ECE0 RID: 126176 RVA: 0x0044E6FD File Offset: 0x0044C8FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ECE1 RID: 126177 RVA: 0x0044E704 File Offset: 0x0044C904
		public static IFrequencyDetectTalkConfig GetRootAsIFrequencyDetectTalkConfig(ByteBuffer _bb)
		{
			return IFrequencyDetectTalkConfig.GetRootAsIFrequencyDetectTalkConfig(_bb, default(IFrequencyDetectTalkConfig));
		}

		// Token: 0x0601ECE2 RID: 126178 RVA: 0x0044E720 File Offset: 0x0044C920
		public static IFrequencyDetectTalkConfig GetRootAsIFrequencyDetectTalkConfig(ByteBuffer _bb, IFrequencyDetectTalkConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ECE3 RID: 126179 RVA: 0x0044E73D File Offset: 0x0044C93D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ECE4 RID: 126180 RVA: 0x0044E74C File Offset: 0x0044C94C
		public IFrequencyDetectTalkConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E20 RID: 36384
		// (get) Token: 0x0601ECE5 RID: 126181 RVA: 0x0044E75C File Offset: 0x0044C95C
		public EFrequencyDetectTalkTriggerTiming TriggerTiming
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFrequencyDetectTalkTriggerTiming.AiStartPaint;
				}
				return (EFrequencyDetectTalkTriggerTiming)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E21 RID: 36385
		// (get) Token: 0x0601ECE6 RID: 126182 RVA: 0x0044E798 File Offset: 0x0044C998
		public string LineId
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

		// Token: 0x0601ECE7 RID: 126183 RVA: 0x0044E7CF File Offset: 0x0044C9CF
		public Span<byte> GetLineIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601ECE8 RID: 126184 RVA: 0x0044E7DE File Offset: 0x0044C9DE
		public byte[] GetLineIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008E22 RID: 36386
		// (get) Token: 0x0601ECE9 RID: 126185 RVA: 0x0044E7EC File Offset: 0x0044C9EC
		public bool IsBlockPlayerOperation
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008E23 RID: 36387
		// (get) Token: 0x0601ECEA RID: 126186 RVA: 0x0044E82C File Offset: 0x0044CA2C
		public ICommonTalkMessage? Message
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ICommonTalkMessage?(default(ICommonTalkMessage).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601ECEB RID: 126187 RVA: 0x0044E88A File Offset: 0x0044CA8A
		public static Offset<IFrequencyDetectTalkConfig> CreateIFrequencyDetectTalkConfig(FlatBufferBuilder builder, EFrequencyDetectTalkTriggerTiming TriggerTiming = EFrequencyDetectTalkTriggerTiming.AiStartPaint, StringOffset LineIdOffset = default(StringOffset), bool IsBlockPlayerOperation = false, Offset<ICommonTalkMessage> MessageOffset = default(Offset<ICommonTalkMessage>))
		{
			builder.StartTable(4);
			IFrequencyDetectTalkConfig.AddMessage(builder, MessageOffset);
			IFrequencyDetectTalkConfig.AddLineId(builder, LineIdOffset);
			IFrequencyDetectTalkConfig.AddIsBlockPlayerOperation(builder, IsBlockPlayerOperation);
			IFrequencyDetectTalkConfig.AddTriggerTiming(builder, TriggerTiming);
			return IFrequencyDetectTalkConfig.EndIFrequencyDetectTalkConfig(builder);
		}

		// Token: 0x0601ECEC RID: 126188 RVA: 0x0044E8B6 File Offset: 0x0044CAB6
		public static void StartIFrequencyDetectTalkConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601ECED RID: 126189 RVA: 0x0044E8BF File Offset: 0x0044CABF
		public static void AddTriggerTiming(FlatBufferBuilder builder, EFrequencyDetectTalkTriggerTiming triggerTiming)
		{
			builder.AddByte(0, (byte)triggerTiming, 0);
		}

		// Token: 0x0601ECEE RID: 126190 RVA: 0x0044E8CA File Offset: 0x0044CACA
		public static void AddLineId(FlatBufferBuilder builder, StringOffset lineIdOffset)
		{
			builder.AddOffset(1, lineIdOffset.Value, 0);
		}

		// Token: 0x0601ECEF RID: 126191 RVA: 0x0044E8DA File Offset: 0x0044CADA
		public static void AddIsBlockPlayerOperation(FlatBufferBuilder builder, bool isBlockPlayerOperation)
		{
			builder.AddBool(2, isBlockPlayerOperation, false);
		}

		// Token: 0x0601ECF0 RID: 126192 RVA: 0x0044E8E5 File Offset: 0x0044CAE5
		public static void AddMessage(FlatBufferBuilder builder, Offset<ICommonTalkMessage> messageOffset)
		{
			builder.AddOffset(3, messageOffset.Value, 0);
		}

		// Token: 0x0601ECF1 RID: 126193 RVA: 0x0044E8F5 File Offset: 0x0044CAF5
		public static Offset<IFrequencyDetectTalkConfig> EndIFrequencyDetectTalkConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyDetectTalkConfig>(builder.EndTable());
		}

		// Token: 0x0601ECF2 RID: 126194 RVA: 0x0044E904 File Offset: 0x0044CB04
		public IFrequencyDetectTalkConfigT UnPack()
		{
			IFrequencyDetectTalkConfigT frequencyDetectTalkConfigT = new IFrequencyDetectTalkConfigT();
			this.UnPackTo(frequencyDetectTalkConfigT);
			return frequencyDetectTalkConfigT;
		}

		// Token: 0x0601ECF3 RID: 126195 RVA: 0x0044E920 File Offset: 0x0044CB20
		public void UnPackTo(IFrequencyDetectTalkConfigT _o)
		{
			_o.TriggerTiming = this.TriggerTiming;
			_o.LineId = this.LineId;
			_o.IsBlockPlayerOperation = this.IsBlockPlayerOperation;
			_o.Message = ((this.Message != null) ? this.Message.Value.UnPack() : null);
		}

		// Token: 0x0601ECF4 RID: 126196 RVA: 0x0044E980 File Offset: 0x0044CB80
		public static Offset<IFrequencyDetectTalkConfig> Pack(FlatBufferBuilder builder, IFrequencyDetectTalkConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyDetectTalkConfig>);
			}
			StringOffset lineIdOffset = (_o.LineId == null) ? default(StringOffset) : builder.CreateString(_o.LineId);
			Offset<ICommonTalkMessage> messageOffset = (_o.Message == null) ? default(Offset<ICommonTalkMessage>) : ICommonTalkMessage.Pack(builder, _o.Message);
			return IFrequencyDetectTalkConfig.CreateIFrequencyDetectTalkConfig(builder, _o.TriggerTiming, lineIdOffset, _o.IsBlockPlayerOperation, messageOffset);
		}

		// Token: 0x0400D9F3 RID: 55795
		private Table __p;
	}
}
