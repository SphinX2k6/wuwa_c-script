using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C9 RID: 713
	public sealed class ConditionGroupFinishInfo : IMessage<ConditionGroupFinishInfo>, IMessage, IEquatable<ConditionGroupFinishInfo>, IDeepCloneable<ConditionGroupFinishInfo>, IBufferMessage
	{
		// Token: 0x06004939 RID: 18745 RVA: 0x000B347D File Offset: 0x000B167D
		[NullableContext(1)]
		public static ConditionGroupFinishInfo Create()
		{
			return new ConditionGroupFinishInfo();
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600493A RID: 18746 RVA: 0x000B3484 File Offset: 0x000B1684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConditionGroupFinishInfo> Parser
		{
			get
			{
				return ConditionGroupFinishInfo._parser;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600493B RID: 18747 RVA: 0x000B348B File Offset: 0x000B168B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600493C RID: 18748 RVA: 0x000B348E File Offset: 0x000B168E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionGroupFinishInfo.Descriptor;
			}
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x000B3495 File Offset: 0x000B1695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupFinishInfo()
		{
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x000B34A8 File Offset: 0x000B16A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupFinishInfo(ConditionGroupFinishInfo other) : this()
		{
			this.conditionGroupId_ = other.conditionGroupId_;
			this.finishConditions_ = other.finishConditions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x000B34DE File Offset: 0x000B16DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupFinishInfo Clone()
		{
			return new ConditionGroupFinishInfo(this);
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06004940 RID: 18752 RVA: 0x000B34E6 File Offset: 0x000B16E6
		// (set) Token: 0x06004941 RID: 18753 RVA: 0x000B34EE File Offset: 0x000B16EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionGroupId
		{
			get
			{
				return this.conditionGroupId_;
			}
			set
			{
				this.conditionGroupId_ = value;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06004942 RID: 18754 RVA: 0x000B34F7 File Offset: 0x000B16F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishConditions
		{
			get
			{
				return this.finishConditions_;
			}
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x000B34FF File Offset: 0x000B16FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionGroupFinishInfo);
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x000B3510 File Offset: 0x000B1710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionGroupFinishInfo other)
		{
			return other != null && (other == this || (this.ConditionGroupId == other.ConditionGroupId && this.finishConditions_.Equals(other.finishConditions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x000B3560 File Offset: 0x000B1760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConditionGroupId != 0)
			{
				num ^= this.ConditionGroupId.GetHashCode();
			}
			num ^= this.finishConditions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x000B35AD File Offset: 0x000B17AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x000B35BA File Offset: 0x000B17BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x000B35C4 File Offset: 0x000B17C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConditionGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConditionGroupId);
			}
			this.finishConditions_.WriteTo(ref output, ConditionGroupFinishInfo._repeated_finishConditions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x000B3614 File Offset: 0x000B1814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConditionGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionGroupId);
			}
			num += this.finishConditions_.CalculateSize(ConditionGroupFinishInfo._repeated_finishConditions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x000B3668 File Offset: 0x000B1868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConditionGroupFinishInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConditionGroupId != 0)
			{
				this.ConditionGroupId = other.ConditionGroupId;
			}
			this.finishConditions_.Add(other.finishConditions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x000B36B5 File Offset: 0x000B18B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x000B36C0 File Offset: 0x000B18C0
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
						this.finishConditions_.AddEntriesFrom(ref input, ConditionGroupFinishInfo._repeated_finishConditions_codec);
					}
				}
				else
				{
					this.ConditionGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400301D RID: 12317
		private static readonly MessageParser<ConditionGroupFinishInfo> _parser = new MessageParser<ConditionGroupFinishInfo>(() => new ConditionGroupFinishInfo());

		// Token: 0x0400301E RID: 12318
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400301F RID: 12319
		public const int ConditionGroupIdFieldNumber = 1;

		// Token: 0x04003020 RID: 12320
		private int conditionGroupId_;

		// Token: 0x04003021 RID: 12321
		public const int FinishConditionsFieldNumber = 2;

		// Token: 0x04003022 RID: 12322
		private static readonly FieldCodec<int> _repeated_finishConditions_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003023 RID: 12323
		private readonly RepeatedField<int> finishConditions_ = new RepeatedField<int>();
	}
}
