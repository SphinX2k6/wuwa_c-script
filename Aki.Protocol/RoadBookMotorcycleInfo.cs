using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F60 RID: 3936
	public sealed class RoadBookMotorcycleInfo : IMessage<RoadBookMotorcycleInfo>, IMessage, IEquatable<RoadBookMotorcycleInfo>, IDeepCloneable<RoadBookMotorcycleInfo>, IBufferMessage
	{
		// Token: 0x0601512A RID: 86314 RVA: 0x0030EC2D File Offset: 0x0030CE2D
		[NullableContext(1)]
		public static RoadBookMotorcycleInfo Create()
		{
			return new RoadBookMotorcycleInfo();
		}

		// Token: 0x1700461E RID: 17950
		// (get) Token: 0x0601512B RID: 86315 RVA: 0x0030EC34 File Offset: 0x0030CE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoadBookMotorcycleInfo> Parser
		{
			get
			{
				return RoadBookMotorcycleInfo._parser;
			}
		}

		// Token: 0x1700461F RID: 17951
		// (get) Token: 0x0601512C RID: 86316 RVA: 0x0030EC3B File Offset: 0x0030CE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004620 RID: 17952
		// (get) Token: 0x0601512D RID: 86317 RVA: 0x0030EC3E File Offset: 0x0030CE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookMotorcycleInfo.Descriptor;
			}
		}

		// Token: 0x0601512E RID: 86318 RVA: 0x0030EC45 File Offset: 0x0030CE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorcycleInfo()
		{
		}

		// Token: 0x0601512F RID: 86319 RVA: 0x0030EC58 File Offset: 0x0030CE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorcycleInfo(RoadBookMotorcycleInfo other) : this()
		{
			this.motorcyclePlayId_ = other.motorcyclePlayId_;
			this.historySoarScore_ = other.historySoarScore_;
			this.receiveIds_ = other.receiveIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015130 RID: 86320 RVA: 0x0030ECA5 File Offset: 0x0030CEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorcycleInfo Clone()
		{
			return new RoadBookMotorcycleInfo(this);
		}

		// Token: 0x17004621 RID: 17953
		// (get) Token: 0x06015131 RID: 86321 RVA: 0x0030ECAD File Offset: 0x0030CEAD
		// (set) Token: 0x06015132 RID: 86322 RVA: 0x0030ECB5 File Offset: 0x0030CEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorcyclePlayId
		{
			get
			{
				return this.motorcyclePlayId_;
			}
			set
			{
				this.motorcyclePlayId_ = value;
			}
		}

		// Token: 0x17004622 RID: 17954
		// (get) Token: 0x06015133 RID: 86323 RVA: 0x0030ECBE File Offset: 0x0030CEBE
		// (set) Token: 0x06015134 RID: 86324 RVA: 0x0030ECC6 File Offset: 0x0030CEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HistorySoarScore
		{
			get
			{
				return this.historySoarScore_;
			}
			set
			{
				this.historySoarScore_ = value;
			}
		}

		// Token: 0x17004623 RID: 17955
		// (get) Token: 0x06015135 RID: 86325 RVA: 0x0030ECCF File Offset: 0x0030CECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReceiveIds
		{
			get
			{
				return this.receiveIds_;
			}
		}

		// Token: 0x06015136 RID: 86326 RVA: 0x0030ECD7 File Offset: 0x0030CED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookMotorcycleInfo);
		}

		// Token: 0x06015137 RID: 86327 RVA: 0x0030ECE8 File Offset: 0x0030CEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookMotorcycleInfo other)
		{
			return other != null && (other == this || (this.MotorcyclePlayId == other.MotorcyclePlayId && this.HistorySoarScore == other.HistorySoarScore && this.receiveIds_.Equals(other.receiveIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015138 RID: 86328 RVA: 0x0030ED48 File Offset: 0x0030CF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MotorcyclePlayId != 0)
			{
				num ^= this.MotorcyclePlayId.GetHashCode();
			}
			if (this.HistorySoarScore != 0)
			{
				num ^= this.HistorySoarScore.GetHashCode();
			}
			num ^= this.receiveIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015139 RID: 86329 RVA: 0x0030EDAE File Offset: 0x0030CFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601513A RID: 86330 RVA: 0x0030EDBB File Offset: 0x0030CFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601513B RID: 86331 RVA: 0x0030EDC4 File Offset: 0x0030CFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorcyclePlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MotorcyclePlayId);
			}
			if (this.HistorySoarScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HistorySoarScore);
			}
			this.receiveIds_.WriteTo(ref output, RoadBookMotorcycleInfo._repeated_receiveIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601513C RID: 86332 RVA: 0x0030EE30 File Offset: 0x0030D030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MotorcyclePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorcyclePlayId);
			}
			if (this.HistorySoarScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HistorySoarScore);
			}
			num += this.receiveIds_.CalculateSize(RoadBookMotorcycleInfo._repeated_receiveIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601513D RID: 86333 RVA: 0x0030EE9C File Offset: 0x0030D09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookMotorcycleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MotorcyclePlayId != 0)
			{
				this.MotorcyclePlayId = other.MotorcyclePlayId;
			}
			if (other.HistorySoarScore != 0)
			{
				this.HistorySoarScore = other.HistorySoarScore;
			}
			this.receiveIds_.Add(other.receiveIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601513E RID: 86334 RVA: 0x0030EEFD File Offset: 0x0030D0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601513F RID: 86335 RVA: 0x0030EF08 File Offset: 0x0030D108
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.MotorcyclePlayId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.HistorySoarScore = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.receiveIds_.AddEntriesFrom(ref input, RoadBookMotorcycleInfo._repeated_receiveIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F45 RID: 32581
		private static readonly MessageParser<RoadBookMotorcycleInfo> _parser = new MessageParser<RoadBookMotorcycleInfo>(() => new RoadBookMotorcycleInfo());

		// Token: 0x04007F46 RID: 32582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F47 RID: 32583
		public const int MotorcyclePlayIdFieldNumber = 1;

		// Token: 0x04007F48 RID: 32584
		private int motorcyclePlayId_;

		// Token: 0x04007F49 RID: 32585
		public const int HistorySoarScoreFieldNumber = 2;

		// Token: 0x04007F4A RID: 32586
		private int historySoarScore_;

		// Token: 0x04007F4B RID: 32587
		public const int ReceiveIdsFieldNumber = 3;

		// Token: 0x04007F4C RID: 32588
		private static readonly FieldCodec<int> _repeated_receiveIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007F4D RID: 32589
		private readonly RepeatedField<int> receiveIds_ = new RepeatedField<int>();
	}
}
