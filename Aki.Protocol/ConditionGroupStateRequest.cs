using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CA RID: 714
	[NetMessage(EMessageId.ConditionGroupStateRequest)]
	public sealed class ConditionGroupStateRequest : IMessage<ConditionGroupStateRequest>, IMessage, IEquatable<ConditionGroupStateRequest>, IDeepCloneable<ConditionGroupStateRequest>, IBufferMessage
	{
		// Token: 0x0600494E RID: 18766 RVA: 0x000B3749 File Offset: 0x000B1949
		[NullableContext(1)]
		public static ConditionGroupStateRequest Create()
		{
			return new ConditionGroupStateRequest();
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x0600494F RID: 18767 RVA: 0x000B3750 File Offset: 0x000B1950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06004950 RID: 18768 RVA: 0x000B3753 File Offset: 0x000B1953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionGroupStateRequest.Descriptor;
			}
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x000B375A File Offset: 0x000B195A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateRequest()
		{
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x000B376D File Offset: 0x000B196D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateRequest(ConditionGroupStateRequest other) : this()
		{
			this.conditionModule_ = other.conditionModule_;
			this.conditionGroupIds_ = other.conditionGroupIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x000B37A3 File Offset: 0x000B19A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateRequest Clone()
		{
			return new ConditionGroupStateRequest(this);
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06004954 RID: 18772 RVA: 0x000B37AB File Offset: 0x000B19AB
		// (set) Token: 0x06004955 RID: 18773 RVA: 0x000B37B3 File Offset: 0x000B19B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionModule
		{
			get
			{
				return this.conditionModule_;
			}
			set
			{
				this.conditionModule_ = value;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06004956 RID: 18774 RVA: 0x000B37BC File Offset: 0x000B19BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConditionGroupIds
		{
			get
			{
				return this.conditionGroupIds_;
			}
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x000B37C4 File Offset: 0x000B19C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionGroupStateRequest);
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x000B37D4 File Offset: 0x000B19D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionGroupStateRequest other)
		{
			return other != null && (other == this || (this.ConditionModule == other.ConditionModule && this.conditionGroupIds_.Equals(other.conditionGroupIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x000B3824 File Offset: 0x000B1A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConditionModule != 0)
			{
				num ^= this.ConditionModule.GetHashCode();
			}
			num ^= this.conditionGroupIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x000B3871 File Offset: 0x000B1A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x000B387E File Offset: 0x000B1A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x000B3888 File Offset: 0x000B1A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConditionModule != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ConditionModule);
			}
			this.conditionGroupIds_.WriteTo(ref output, ConditionGroupStateRequest._repeated_conditionGroupIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x000B38D8 File Offset: 0x000B1AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConditionModule != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionModule);
			}
			num += this.conditionGroupIds_.CalculateSize(ConditionGroupStateRequest._repeated_conditionGroupIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x000B392C File Offset: 0x000B1B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConditionGroupStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConditionModule != 0)
			{
				this.ConditionModule = other.ConditionModule;
			}
			this.conditionGroupIds_.Add(other.conditionGroupIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x000B3979 File Offset: 0x000B1B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x000B3984 File Offset: 0x000B1B84
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
				if (num != 88U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.conditionGroupIds_.AddEntriesFrom(ref input, ConditionGroupStateRequest._repeated_conditionGroupIds_codec);
					}
				}
				else
				{
					this.ConditionModule = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003024 RID: 12324
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003025 RID: 12325
		public const int ConditionModuleFieldNumber = 11;

		// Token: 0x04003026 RID: 12326
		private int conditionModule_;

		// Token: 0x04003027 RID: 12327
		public const int ConditionGroupIdsFieldNumber = 14;

		// Token: 0x04003028 RID: 12328
		private static readonly FieldCodec<int> _repeated_conditionGroupIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04003029 RID: 12329
		private readonly RepeatedField<int> conditionGroupIds_ = new RepeatedField<int>();
	}
}
