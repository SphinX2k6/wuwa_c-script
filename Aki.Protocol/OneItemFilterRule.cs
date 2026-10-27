using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8C RID: 2956
	public sealed class OneItemFilterRule : IMessage<OneItemFilterRule>, IMessage, IEquatable<OneItemFilterRule>, IDeepCloneable<OneItemFilterRule>, IBufferMessage
	{
		// Token: 0x0601005C RID: 65628 RVA: 0x0025688E File Offset: 0x00254A8E
		[NullableContext(1)]
		public static OneItemFilterRule Create()
		{
			return new OneItemFilterRule();
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x0601005D RID: 65629 RVA: 0x00256895 File Offset: 0x00254A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneItemFilterRule> Parser
		{
			get
			{
				return OneItemFilterRule._parser;
			}
		}

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x0601005E RID: 65630 RVA: 0x0025689C File Offset: 0x00254A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x0601005F RID: 65631 RVA: 0x0025689F File Offset: 0x00254A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneItemFilterRule.Descriptor;
			}
		}

		// Token: 0x06010060 RID: 65632 RVA: 0x002568A6 File Offset: 0x00254AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneItemFilterRule()
		{
		}

		// Token: 0x06010061 RID: 65633 RVA: 0x002568B9 File Offset: 0x00254AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneItemFilterRule(OneItemFilterRule other) : this()
		{
			this.filterRuleId_ = other.filterRuleId_;
			this.idList_ = other.idList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010062 RID: 65634 RVA: 0x002568EF File Offset: 0x00254AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneItemFilterRule Clone()
		{
			return new OneItemFilterRule(this);
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x06010063 RID: 65635 RVA: 0x002568F7 File Offset: 0x00254AF7
		// (set) Token: 0x06010064 RID: 65636 RVA: 0x002568FF File Offset: 0x00254AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FilterRuleId
		{
			get
			{
				return this.filterRuleId_;
			}
			set
			{
				this.filterRuleId_ = value;
			}
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x06010065 RID: 65637 RVA: 0x00256908 File Offset: 0x00254B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IdList
		{
			get
			{
				return this.idList_;
			}
		}

		// Token: 0x06010066 RID: 65638 RVA: 0x00256910 File Offset: 0x00254B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneItemFilterRule);
		}

		// Token: 0x06010067 RID: 65639 RVA: 0x00256920 File Offset: 0x00254B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneItemFilterRule other)
		{
			return other != null && (other == this || (this.FilterRuleId == other.FilterRuleId && this.idList_.Equals(other.idList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010068 RID: 65640 RVA: 0x00256970 File Offset: 0x00254B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FilterRuleId != 0)
			{
				num ^= this.FilterRuleId.GetHashCode();
			}
			num ^= this.idList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010069 RID: 65641 RVA: 0x002569BD File Offset: 0x00254BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601006A RID: 65642 RVA: 0x002569CA File Offset: 0x00254BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601006B RID: 65643 RVA: 0x002569D4 File Offset: 0x00254BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FilterRuleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FilterRuleId);
			}
			this.idList_.WriteTo(ref output, OneItemFilterRule._repeated_idList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601006C RID: 65644 RVA: 0x00256A24 File Offset: 0x00254C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FilterRuleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FilterRuleId);
			}
			num += this.idList_.CalculateSize(OneItemFilterRule._repeated_idList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601006D RID: 65645 RVA: 0x00256A78 File Offset: 0x00254C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneItemFilterRule other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FilterRuleId != 0)
			{
				this.FilterRuleId = other.FilterRuleId;
			}
			this.idList_.Add(other.idList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601006E RID: 65646 RVA: 0x00256AC5 File Offset: 0x00254CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601006F RID: 65647 RVA: 0x00256AD0 File Offset: 0x00254CD0
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.idList_.AddEntriesFrom(ref input, OneItemFilterRule._repeated_idList_codec);
					}
				}
				else
				{
					this.FilterRuleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006626 RID: 26150
		private static readonly MessageParser<OneItemFilterRule> _parser = new MessageParser<OneItemFilterRule>(() => new OneItemFilterRule());

		// Token: 0x04006627 RID: 26151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006628 RID: 26152
		public const int FilterRuleIdFieldNumber = 1;

		// Token: 0x04006629 RID: 26153
		private int filterRuleId_;

		// Token: 0x0400662A RID: 26154
		public const int IdListFieldNumber = 2;

		// Token: 0x0400662B RID: 26155
		private static readonly FieldCodec<int> _repeated_idList_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400662C RID: 26156
		private readonly RepeatedField<int> idList_ = new RepeatedField<int>();
	}
}
