using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AA RID: 4778
	public sealed class SolarSchoolFlowPb : IMessage<SolarSchoolFlowPb>, IMessage, IEquatable<SolarSchoolFlowPb>, IDeepCloneable<SolarSchoolFlowPb>, IBufferMessage
	{
		// Token: 0x06019814 RID: 104468 RVA: 0x003B8840 File Offset: 0x003B6A40
		[NullableContext(1)]
		public static SolarSchoolFlowPb Create()
		{
			return new SolarSchoolFlowPb();
		}

		// Token: 0x17005650 RID: 22096
		// (get) Token: 0x06019815 RID: 104469 RVA: 0x003B8847 File Offset: 0x003B6A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolFlowPb> Parser
		{
			get
			{
				return SolarSchoolFlowPb._parser;
			}
		}

		// Token: 0x17005651 RID: 22097
		// (get) Token: 0x06019816 RID: 104470 RVA: 0x003B884E File Offset: 0x003B6A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005652 RID: 22098
		// (get) Token: 0x06019817 RID: 104471 RVA: 0x003B8851 File Offset: 0x003B6A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolFlowPb.Descriptor;
			}
		}

		// Token: 0x06019818 RID: 104472 RVA: 0x003B8858 File Offset: 0x003B6A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolFlowPb()
		{
		}

		// Token: 0x06019819 RID: 104473 RVA: 0x003B886B File Offset: 0x003B6A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolFlowPb(SolarSchoolFlowPb other) : this()
		{
			this.solarSchoolFlowId_ = other.solarSchoolFlowId_;
			this.readPlotFlatBit_ = other.readPlotFlatBit_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601981A RID: 104474 RVA: 0x003B88A1 File Offset: 0x003B6AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolFlowPb Clone()
		{
			return new SolarSchoolFlowPb(this);
		}

		// Token: 0x17005653 RID: 22099
		// (get) Token: 0x0601981B RID: 104475 RVA: 0x003B88A9 File Offset: 0x003B6AA9
		// (set) Token: 0x0601981C RID: 104476 RVA: 0x003B88B1 File Offset: 0x003B6AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SolarSchoolFlowId
		{
			get
			{
				return this.solarSchoolFlowId_;
			}
			set
			{
				this.solarSchoolFlowId_ = value;
			}
		}

		// Token: 0x17005654 RID: 22100
		// (get) Token: 0x0601981D RID: 104477 RVA: 0x003B88BA File Offset: 0x003B6ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> ReadPlotFlatBit
		{
			get
			{
				return this.readPlotFlatBit_;
			}
		}

		// Token: 0x0601981E RID: 104478 RVA: 0x003B88C2 File Offset: 0x003B6AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolFlowPb);
		}

		// Token: 0x0601981F RID: 104479 RVA: 0x003B88D0 File Offset: 0x003B6AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolFlowPb other)
		{
			return other != null && (other == this || (this.SolarSchoolFlowId == other.SolarSchoolFlowId && this.readPlotFlatBit_.Equals(other.readPlotFlatBit_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019820 RID: 104480 RVA: 0x003B8920 File Offset: 0x003B6B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SolarSchoolFlowId != 0)
			{
				num ^= this.SolarSchoolFlowId.GetHashCode();
			}
			num ^= this.readPlotFlatBit_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019821 RID: 104481 RVA: 0x003B896D File Offset: 0x003B6B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019822 RID: 104482 RVA: 0x003B897A File Offset: 0x003B6B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019823 RID: 104483 RVA: 0x003B8984 File Offset: 0x003B6B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SolarSchoolFlowId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SolarSchoolFlowId);
			}
			this.readPlotFlatBit_.WriteTo(ref output, SolarSchoolFlowPb._repeated_readPlotFlatBit_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019824 RID: 104484 RVA: 0x003B89D4 File Offset: 0x003B6BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SolarSchoolFlowId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SolarSchoolFlowId);
			}
			num += this.readPlotFlatBit_.CalculateSize(SolarSchoolFlowPb._repeated_readPlotFlatBit_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019825 RID: 104485 RVA: 0x003B8A28 File Offset: 0x003B6C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolFlowPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SolarSchoolFlowId != 0)
			{
				this.SolarSchoolFlowId = other.SolarSchoolFlowId;
			}
			this.readPlotFlatBit_.Add(other.readPlotFlatBit_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019826 RID: 104486 RVA: 0x003B8A75 File Offset: 0x003B6C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019827 RID: 104487 RVA: 0x003B8A80 File Offset: 0x003B6C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 8U)
				{
					if (num != 24U && num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.readPlotFlatBit_.AddEntriesFrom(ref input, SolarSchoolFlowPb._repeated_readPlotFlatBit_codec);
					}
				}
				else
				{
					this.SolarSchoolFlowId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040096BC RID: 38588
		private static readonly MessageParser<SolarSchoolFlowPb> _parser = new MessageParser<SolarSchoolFlowPb>(() => new SolarSchoolFlowPb());

		// Token: 0x040096BD RID: 38589
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096BE RID: 38590
		public const int SolarSchoolFlowIdFieldNumber = 1;

		// Token: 0x040096BF RID: 38591
		private int solarSchoolFlowId_;

		// Token: 0x040096C0 RID: 38592
		public const int ReadPlotFlatBitFieldNumber = 3;

		// Token: 0x040096C1 RID: 38593
		private static readonly FieldCodec<long> _repeated_readPlotFlatBit_codec = FieldCodec.ForInt64(26U);

		// Token: 0x040096C2 RID: 38594
		private readonly RepeatedField<long> readPlotFlatBit_ = new RepeatedField<long>();
	}
}
