using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C2 RID: 1986
	[NetMessage(EMessageId.InfrArchiveTaskRewardRequest)]
	public sealed class InfrArchiveTaskRewardRequest : IMessage<InfrArchiveTaskRewardRequest>, IMessage, IEquatable<InfrArchiveTaskRewardRequest>, IDeepCloneable<InfrArchiveTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600B2E8 RID: 45800 RVA: 0x001AC691 File Offset: 0x001AA891
		[NullableContext(1)]
		public static InfrArchiveTaskRewardRequest Create()
		{
			return new InfrArchiveTaskRewardRequest();
		}

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x0600B2E9 RID: 45801 RVA: 0x001AC698 File Offset: 0x001AA898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x0600B2EA RID: 45802 RVA: 0x001AC69B File Offset: 0x001AA89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrArchiveTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600B2EB RID: 45803 RVA: 0x001AC6A2 File Offset: 0x001AA8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardRequest()
		{
		}

		// Token: 0x0600B2EC RID: 45804 RVA: 0x001AC6B5 File Offset: 0x001AA8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardRequest(InfrArchiveTaskRewardRequest other) : this()
		{
			this.targetIds_ = other.targetIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2ED RID: 45805 RVA: 0x001AC6DF File Offset: 0x001AA8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardRequest Clone()
		{
			return new InfrArchiveTaskRewardRequest(this);
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x0600B2EE RID: 45806 RVA: 0x001AC6E7 File Offset: 0x001AA8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TargetIds
		{
			get
			{
				return this.targetIds_;
			}
		}

		// Token: 0x0600B2EF RID: 45807 RVA: 0x001AC6EF File Offset: 0x001AA8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrArchiveTaskRewardRequest);
		}

		// Token: 0x0600B2F0 RID: 45808 RVA: 0x001AC6FD File Offset: 0x001AA8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrArchiveTaskRewardRequest other)
		{
			return other != null && (other == this || (this.targetIds_.Equals(other.targetIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2F1 RID: 45809 RVA: 0x001AC730 File Offset: 0x001AA930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.targetIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2F2 RID: 45810 RVA: 0x001AC764 File Offset: 0x001AA964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B2F3 RID: 45811 RVA: 0x001AC771 File Offset: 0x001AA971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2F4 RID: 45812 RVA: 0x001AC77A File Offset: 0x001AA97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.targetIds_.WriteTo(ref output, InfrArchiveTaskRewardRequest._repeated_targetIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x001AC7A4 File Offset: 0x001AA9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.targetIds_.CalculateSize(InfrArchiveTaskRewardRequest._repeated_targetIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2F6 RID: 45814 RVA: 0x001AC7DD File Offset: 0x001AA9DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrArchiveTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.targetIds_.Add(other.targetIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2F7 RID: 45815 RVA: 0x001AC80B File Offset: 0x001AAA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2F8 RID: 45816 RVA: 0x001AC814 File Offset: 0x001AAA14
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.targetIds_.AddEntriesFrom(ref input, InfrArchiveTaskRewardRequest._repeated_targetIds_codec);
				}
			}
		}

		// Token: 0x0400503A RID: 20538
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400503B RID: 20539
		public const int TargetIdsFieldNumber = 3;

		// Token: 0x0400503C RID: 20540
		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400503D RID: 20541
		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();
	}
}
