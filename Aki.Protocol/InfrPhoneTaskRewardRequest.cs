using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007EB RID: 2027
	[NetMessage(EMessageId.InfrPhoneTaskRewardRequest)]
	public sealed class InfrPhoneTaskRewardRequest : IMessage<InfrPhoneTaskRewardRequest>, IMessage, IEquatable<InfrPhoneTaskRewardRequest>, IDeepCloneable<InfrPhoneTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600B5D5 RID: 46549 RVA: 0x001B244A File Offset: 0x001B064A
		[NullableContext(1)]
		public static InfrPhoneTaskRewardRequest Create()
		{
			return new InfrPhoneTaskRewardRequest();
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x0600B5D6 RID: 46550 RVA: 0x001B2451 File Offset: 0x001B0651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x0600B5D7 RID: 46551 RVA: 0x001B2454 File Offset: 0x001B0654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrPhoneTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600B5D8 RID: 46552 RVA: 0x001B245B File Offset: 0x001B065B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardRequest()
		{
		}

		// Token: 0x0600B5D9 RID: 46553 RVA: 0x001B246E File Offset: 0x001B066E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardRequest(InfrPhoneTaskRewardRequest other) : this()
		{
			this.targetIds_ = other.targetIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5DA RID: 46554 RVA: 0x001B2498 File Offset: 0x001B0698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardRequest Clone()
		{
			return new InfrPhoneTaskRewardRequest(this);
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x0600B5DB RID: 46555 RVA: 0x001B24A0 File Offset: 0x001B06A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TargetIds
		{
			get
			{
				return this.targetIds_;
			}
		}

		// Token: 0x0600B5DC RID: 46556 RVA: 0x001B24A8 File Offset: 0x001B06A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrPhoneTaskRewardRequest);
		}

		// Token: 0x0600B5DD RID: 46557 RVA: 0x001B24B6 File Offset: 0x001B06B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrPhoneTaskRewardRequest other)
		{
			return other != null && (other == this || (this.targetIds_.Equals(other.targetIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B5DE RID: 46558 RVA: 0x001B24EC File Offset: 0x001B06EC
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

		// Token: 0x0600B5DF RID: 46559 RVA: 0x001B2520 File Offset: 0x001B0720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B5E0 RID: 46560 RVA: 0x001B252D File Offset: 0x001B072D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5E1 RID: 46561 RVA: 0x001B2536 File Offset: 0x001B0736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.targetIds_.WriteTo(ref output, InfrPhoneTaskRewardRequest._repeated_targetIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5E2 RID: 46562 RVA: 0x001B2560 File Offset: 0x001B0760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.targetIds_.CalculateSize(InfrPhoneTaskRewardRequest._repeated_targetIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B5E3 RID: 46563 RVA: 0x001B2599 File Offset: 0x001B0799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrPhoneTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.targetIds_.Add(other.targetIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5E4 RID: 46564 RVA: 0x001B25C7 File Offset: 0x001B07C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5E5 RID: 46565 RVA: 0x001B25D0 File Offset: 0x001B07D0
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.targetIds_.AddEntriesFrom(ref input, InfrPhoneTaskRewardRequest._repeated_targetIds_codec);
				}
			}
		}

		// Token: 0x040050A5 RID: 20645
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050A6 RID: 20646
		public const int TargetIdsFieldNumber = 10;

		// Token: 0x040050A7 RID: 20647
		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040050A8 RID: 20648
		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();
	}
}
