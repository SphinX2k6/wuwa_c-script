using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F70 RID: 3952
	public sealed class RoadBookMotorcycleInfo : IMessage<RoadBookMotorcycleInfo>, IMessage, IEquatable<RoadBookMotorcycleInfo>, IDeepCloneable<RoadBookMotorcycleInfo>, IBufferMessage
	{
		// Token: 0x0601520F RID: 86543 RVA: 0x003102DC File Offset: 0x0030E4DC
		[NullableContext(1)]
		public static RoadBookMotorcycleInfo Create()
		{
			return new RoadBookMotorcycleInfo();
		}

		// Token: 0x17004648 RID: 17992
		// (get) Token: 0x06015210 RID: 86544 RVA: 0x003102E3 File Offset: 0x0030E4E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoadBookMotorcycleInfo> Parser
		{
			get
			{
				return RoadBookMotorcycleInfo._parser;
			}
		}

		// Token: 0x17004649 RID: 17993
		// (get) Token: 0x06015211 RID: 86545 RVA: 0x003102EA File Offset: 0x0030E4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700464A RID: 17994
		// (get) Token: 0x06015212 RID: 86546 RVA: 0x003102ED File Offset: 0x0030E4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookMotorcycleInfo.Descriptor;
			}
		}

		// Token: 0x06015213 RID: 86547 RVA: 0x003102F4 File Offset: 0x0030E4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorcycleInfo()
		{
		}

		// Token: 0x06015214 RID: 86548 RVA: 0x00310308 File Offset: 0x0030E508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorcycleInfo(RoadBookMotorcycleInfo other) : this()
		{
			this.motorcyclePlayId_ = other.motorcyclePlayId_;
			this.historySoarScore_ = other.historySoarScore_;
			this.receiveIds_ = other.receiveIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015215 RID: 86549 RVA: 0x00310355 File Offset: 0x0030E555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorcycleInfo Clone()
		{
			return new RoadBookMotorcycleInfo(this);
		}

		// Token: 0x1700464B RID: 17995
		// (get) Token: 0x06015216 RID: 86550 RVA: 0x0031035D File Offset: 0x0030E55D
		// (set) Token: 0x06015217 RID: 86551 RVA: 0x00310365 File Offset: 0x0030E565
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

		// Token: 0x1700464C RID: 17996
		// (get) Token: 0x06015218 RID: 86552 RVA: 0x0031036E File Offset: 0x0030E56E
		// (set) Token: 0x06015219 RID: 86553 RVA: 0x00310376 File Offset: 0x0030E576
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

		// Token: 0x1700464D RID: 17997
		// (get) Token: 0x0601521A RID: 86554 RVA: 0x0031037F File Offset: 0x0030E57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReceiveIds
		{
			get
			{
				return this.receiveIds_;
			}
		}

		// Token: 0x0601521B RID: 86555 RVA: 0x00310387 File Offset: 0x0030E587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookMotorcycleInfo);
		}

		// Token: 0x0601521C RID: 86556 RVA: 0x00310398 File Offset: 0x0030E598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookMotorcycleInfo other)
		{
			return other != null && (other == this || (this.MotorcyclePlayId == other.MotorcyclePlayId && this.HistorySoarScore == other.HistorySoarScore && this.receiveIds_.Equals(other.receiveIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601521D RID: 86557 RVA: 0x003103F8 File Offset: 0x0030E5F8
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

		// Token: 0x0601521E RID: 86558 RVA: 0x0031045E File Offset: 0x0030E65E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601521F RID: 86559 RVA: 0x0031046B File Offset: 0x0030E66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015220 RID: 86560 RVA: 0x00310474 File Offset: 0x0030E674
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

		// Token: 0x06015221 RID: 86561 RVA: 0x003104E0 File Offset: 0x0030E6E0
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

		// Token: 0x06015222 RID: 86562 RVA: 0x0031054C File Offset: 0x0030E74C
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

		// Token: 0x06015223 RID: 86563 RVA: 0x003105AD File Offset: 0x0030E7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015224 RID: 86564 RVA: 0x003105B8 File Offset: 0x0030E7B8
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

		// Token: 0x04007F1B RID: 32539
		private static readonly MessageParser<RoadBookMotorcycleInfo> _parser = new MessageParser<RoadBookMotorcycleInfo>(() => new RoadBookMotorcycleInfo());

		// Token: 0x04007F1C RID: 32540
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F1D RID: 32541
		public const int MotorcyclePlayIdFieldNumber = 1;

		// Token: 0x04007F1E RID: 32542
		private int motorcyclePlayId_;

		// Token: 0x04007F1F RID: 32543
		public const int HistorySoarScoreFieldNumber = 2;

		// Token: 0x04007F20 RID: 32544
		private int historySoarScore_;

		// Token: 0x04007F21 RID: 32545
		public const int ReceiveIdsFieldNumber = 3;

		// Token: 0x04007F22 RID: 32546
		private static readonly FieldCodec<int> _repeated_receiveIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007F23 RID: 32547
		private readonly RepeatedField<int> receiveIds_ = new RepeatedField<int>();
	}
}
