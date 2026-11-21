using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6B RID: 2667
	[NetMessage(EMessageId.MotorOnlineRankRuleIdsNotify)]
	public sealed class MotorOnlineRankRuleIdsNotify : IMessage<MotorOnlineRankRuleIdsNotify>, IMessage, IEquatable<MotorOnlineRankRuleIdsNotify>, IDeepCloneable<MotorOnlineRankRuleIdsNotify>, IBufferMessage
	{
		// Token: 0x0600E8D2 RID: 59602 RVA: 0x002203C7 File Offset: 0x0021E5C7
		[NullableContext(1)]
		public static MotorOnlineRankRuleIdsNotify Create()
		{
			return new MotorOnlineRankRuleIdsNotify();
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x0600E8D3 RID: 59603 RVA: 0x002203CE File Offset: 0x0021E5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x0600E8D4 RID: 59604 RVA: 0x002203D1 File Offset: 0x0021E5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOnlineRankRuleIdsNotify.Descriptor;
			}
		}

		// Token: 0x0600E8D5 RID: 59605 RVA: 0x002203D8 File Offset: 0x0021E5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankRuleIdsNotify()
		{
		}

		// Token: 0x0600E8D6 RID: 59606 RVA: 0x002203EB File Offset: 0x0021E5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankRuleIdsNotify(MotorOnlineRankRuleIdsNotify other) : this()
		{
			this.instId_ = other.instId_;
			this.motorOnlinePlayerInfoList_ = other.motorOnlinePlayerInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E8D7 RID: 59607 RVA: 0x00220421 File Offset: 0x0021E621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankRuleIdsNotify Clone()
		{
			return new MotorOnlineRankRuleIdsNotify(this);
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x0600E8D8 RID: 59608 RVA: 0x00220429 File Offset: 0x0021E629
		// (set) Token: 0x0600E8D9 RID: 59609 RVA: 0x00220431 File Offset: 0x0021E631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x0600E8DA RID: 59610 RVA: 0x0022043A File Offset: 0x0021E63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOnlineParkPlayerRuleInfo> MotorOnlinePlayerInfoList
		{
			get
			{
				return this.motorOnlinePlayerInfoList_;
			}
		}

		// Token: 0x0600E8DB RID: 59611 RVA: 0x00220442 File Offset: 0x0021E642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOnlineRankRuleIdsNotify);
		}

		// Token: 0x0600E8DC RID: 59612 RVA: 0x00220450 File Offset: 0x0021E650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOnlineRankRuleIdsNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.motorOnlinePlayerInfoList_.Equals(other.motorOnlinePlayerInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E8DD RID: 59613 RVA: 0x002204A0 File Offset: 0x0021E6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.motorOnlinePlayerInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E8DE RID: 59614 RVA: 0x002204ED File Offset: 0x0021E6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E8DF RID: 59615 RVA: 0x002204FA File Offset: 0x0021E6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E8E0 RID: 59616 RVA: 0x00220504 File Offset: 0x0021E704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.InstId);
			}
			this.motorOnlinePlayerInfoList_.WriteTo(ref output, MotorOnlineRankRuleIdsNotify._repeated_motorOnlinePlayerInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E8E1 RID: 59617 RVA: 0x00220554 File Offset: 0x0021E754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.motorOnlinePlayerInfoList_.CalculateSize(MotorOnlineRankRuleIdsNotify._repeated_motorOnlinePlayerInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E8E2 RID: 59618 RVA: 0x002205A8 File Offset: 0x0021E7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOnlineRankRuleIdsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.motorOnlinePlayerInfoList_.Add(other.motorOnlinePlayerInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E8E3 RID: 59619 RVA: 0x002205F5 File Offset: 0x0021E7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E8E4 RID: 59620 RVA: 0x00220600 File Offset: 0x0021E800
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
				if (num != 40U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.motorOnlinePlayerInfoList_.AddEntriesFrom(ref input, MotorOnlineRankRuleIdsNotify._repeated_motorOnlinePlayerInfoList_codec);
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005F15 RID: 24341
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F16 RID: 24342
		public const int InstIdFieldNumber = 5;

		// Token: 0x04005F17 RID: 24343
		private int instId_;

		// Token: 0x04005F18 RID: 24344
		public const int MotorOnlinePlayerInfoListFieldNumber = 13;

		// Token: 0x04005F19 RID: 24345
		private static readonly FieldCodec<MotorOnlineParkPlayerRuleInfo> _repeated_motorOnlinePlayerInfoList_codec = FieldCodec.ForMessage<MotorOnlineParkPlayerRuleInfo>(106U, MotorOnlineParkPlayerRuleInfo.Parser);

		// Token: 0x04005F1A RID: 24346
		private readonly RepeatedField<MotorOnlineParkPlayerRuleInfo> motorOnlinePlayerInfoList_ = new RepeatedField<MotorOnlineParkPlayerRuleInfo>();
	}
}
