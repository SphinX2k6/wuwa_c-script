using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D53 RID: 3411
	[NetMessage(EMessageId.PinballTaskRewardRequest)]
	public sealed class PinballTaskRewardRequest : IMessage<PinballTaskRewardRequest>, IMessage, IEquatable<PinballTaskRewardRequest>, IDeepCloneable<PinballTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060126C0 RID: 75456 RVA: 0x002B0B8F File Offset: 0x002AED8F
		[NullableContext(1)]
		public static PinballTaskRewardRequest Create()
		{
			return new PinballTaskRewardRequest();
		}

		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x060126C1 RID: 75457 RVA: 0x002B0B96 File Offset: 0x002AED96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x060126C2 RID: 75458 RVA: 0x002B0B99 File Offset: 0x002AED99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060126C3 RID: 75459 RVA: 0x002B0BA0 File Offset: 0x002AEDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardRequest()
		{
		}

		// Token: 0x060126C4 RID: 75460 RVA: 0x002B0BB3 File Offset: 0x002AEDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardRequest(PinballTaskRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060126C5 RID: 75461 RVA: 0x002B0BDD File Offset: 0x002AEDDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardRequest Clone()
		{
			return new PinballTaskRewardRequest(this);
		}

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x060126C6 RID: 75462 RVA: 0x002B0BE5 File Offset: 0x002AEDE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x060126C7 RID: 75463 RVA: 0x002B0BED File Offset: 0x002AEDED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTaskRewardRequest);
		}

		// Token: 0x060126C8 RID: 75464 RVA: 0x002B0BFB File Offset: 0x002AEDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060126C9 RID: 75465 RVA: 0x002B0C30 File Offset: 0x002AEE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060126CA RID: 75466 RVA: 0x002B0C64 File Offset: 0x002AEE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060126CB RID: 75467 RVA: 0x002B0C71 File Offset: 0x002AEE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060126CC RID: 75468 RVA: 0x002B0C7A File Offset: 0x002AEE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, PinballTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060126CD RID: 75469 RVA: 0x002B0CA4 File Offset: 0x002AEEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(PinballTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060126CE RID: 75470 RVA: 0x002B0CDD File Offset: 0x002AEEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060126CF RID: 75471 RVA: 0x002B0D0B File Offset: 0x002AEF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060126D0 RID: 75472 RVA: 0x002B0D14 File Offset: 0x002AEF14
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
					this.taskIds_.AddEntriesFrom(ref input, PinballTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007311 RID: 29457
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007312 RID: 29458
		public const int TaskIdsFieldNumber = 3;

		// Token: 0x04007313 RID: 29459
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007314 RID: 29460
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
