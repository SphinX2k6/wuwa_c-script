using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7C RID: 2940
	public sealed class OneItemFilterRule : IMessage<OneItemFilterRule>, IMessage, IEquatable<OneItemFilterRule>, IDeepCloneable<OneItemFilterRule>, IBufferMessage
	{
		// Token: 0x0600FF58 RID: 65368 RVA: 0x002549BE File Offset: 0x00252BBE
		[NullableContext(1)]
		public static OneItemFilterRule Create()
		{
			return new OneItemFilterRule();
		}

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600FF59 RID: 65369 RVA: 0x002549C5 File Offset: 0x00252BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneItemFilterRule> Parser
		{
			get
			{
				return OneItemFilterRule._parser;
			}
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600FF5A RID: 65370 RVA: 0x002549CC File Offset: 0x00252BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600FF5B RID: 65371 RVA: 0x002549CF File Offset: 0x00252BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneItemFilterRule.Descriptor;
			}
		}

		// Token: 0x0600FF5C RID: 65372 RVA: 0x002549D6 File Offset: 0x00252BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneItemFilterRule()
		{
		}

		// Token: 0x0600FF5D RID: 65373 RVA: 0x002549E9 File Offset: 0x00252BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneItemFilterRule(OneItemFilterRule other) : this()
		{
			this.filterRuleId_ = other.filterRuleId_;
			this.idList_ = other.idList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FF5E RID: 65374 RVA: 0x00254A1F File Offset: 0x00252C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneItemFilterRule Clone()
		{
			return new OneItemFilterRule(this);
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600FF5F RID: 65375 RVA: 0x00254A27 File Offset: 0x00252C27
		// (set) Token: 0x0600FF60 RID: 65376 RVA: 0x00254A2F File Offset: 0x00252C2F
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

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0600FF61 RID: 65377 RVA: 0x00254A38 File Offset: 0x00252C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IdList
		{
			get
			{
				return this.idList_;
			}
		}

		// Token: 0x0600FF62 RID: 65378 RVA: 0x00254A40 File Offset: 0x00252C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneItemFilterRule);
		}

		// Token: 0x0600FF63 RID: 65379 RVA: 0x00254A50 File Offset: 0x00252C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneItemFilterRule other)
		{
			return other != null && (other == this || (this.FilterRuleId == other.FilterRuleId && this.idList_.Equals(other.idList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF64 RID: 65380 RVA: 0x00254AA0 File Offset: 0x00252CA0
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

		// Token: 0x0600FF65 RID: 65381 RVA: 0x00254AED File Offset: 0x00252CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF66 RID: 65382 RVA: 0x00254AFA File Offset: 0x00252CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF67 RID: 65383 RVA: 0x00254B04 File Offset: 0x00252D04
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

		// Token: 0x0600FF68 RID: 65384 RVA: 0x00254B54 File Offset: 0x00252D54
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

		// Token: 0x0600FF69 RID: 65385 RVA: 0x00254BA8 File Offset: 0x00252DA8
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

		// Token: 0x0600FF6A RID: 65386 RVA: 0x00254BF5 File Offset: 0x00252DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF6B RID: 65387 RVA: 0x00254C00 File Offset: 0x00252E00
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

		// Token: 0x04006636 RID: 26166
		private static readonly MessageParser<OneItemFilterRule> _parser = new MessageParser<OneItemFilterRule>(() => new OneItemFilterRule());

		// Token: 0x04006637 RID: 26167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006638 RID: 26168
		public const int FilterRuleIdFieldNumber = 1;

		// Token: 0x04006639 RID: 26169
		private int filterRuleId_;

		// Token: 0x0400663A RID: 26170
		public const int IdListFieldNumber = 2;

		// Token: 0x0400663B RID: 26171
		private static readonly FieldCodec<int> _repeated_idList_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400663C RID: 26172
		private readonly RepeatedField<int> idList_ = new RepeatedField<int>();
	}
}
