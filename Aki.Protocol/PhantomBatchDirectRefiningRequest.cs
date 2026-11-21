using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0C RID: 3084
	[NetMessage(EMessageId.PhantomBatchDirectRefiningRequest)]
	public sealed class PhantomBatchDirectRefiningRequest : IMessage<PhantomBatchDirectRefiningRequest>, IMessage, IEquatable<PhantomBatchDirectRefiningRequest>, IDeepCloneable<PhantomBatchDirectRefiningRequest>, IBufferMessage
	{
		// Token: 0x06010C39 RID: 68665 RVA: 0x00275064 File Offset: 0x00273264
		[NullableContext(1)]
		public static PhantomBatchDirectRefiningRequest Create()
		{
			return new PhantomBatchDirectRefiningRequest();
		}

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x06010C3A RID: 68666 RVA: 0x0027506B File Offset: 0x0027326B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x06010C3B RID: 68667 RVA: 0x0027506E File Offset: 0x0027326E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchDirectRefiningRequest.Descriptor;
			}
		}

		// Token: 0x06010C3C RID: 68668 RVA: 0x00275075 File Offset: 0x00273275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchDirectRefiningRequest()
		{
		}

		// Token: 0x06010C3D RID: 68669 RVA: 0x00275088 File Offset: 0x00273288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchDirectRefiningRequest(PhantomBatchDirectRefiningRequest other) : this()
		{
			this.targetFetterGroupId_ = other.targetFetterGroupId_;
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C3E RID: 68670 RVA: 0x002750BE File Offset: 0x002732BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchDirectRefiningRequest Clone()
		{
			return new PhantomBatchDirectRefiningRequest(this);
		}

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x06010C3F RID: 68671 RVA: 0x002750C6 File Offset: 0x002732C6
		// (set) Token: 0x06010C40 RID: 68672 RVA: 0x002750CE File Offset: 0x002732CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFetterGroupId
		{
			get
			{
				return this.targetFetterGroupId_;
			}
			set
			{
				this.targetFetterGroupId_ = value;
			}
		}

		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x06010C41 RID: 68673 RVA: 0x002750D7 File Offset: 0x002732D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06010C42 RID: 68674 RVA: 0x002750DF File Offset: 0x002732DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchDirectRefiningRequest);
		}

		// Token: 0x06010C43 RID: 68675 RVA: 0x002750F0 File Offset: 0x002732F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchDirectRefiningRequest other)
		{
			return other != null && (other == this || (this.TargetFetterGroupId == other.TargetFetterGroupId && this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C44 RID: 68676 RVA: 0x00275140 File Offset: 0x00273340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetFetterGroupId != 0)
			{
				num ^= this.TargetFetterGroupId.GetHashCode();
			}
			num ^= this.stackEntries_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010C45 RID: 68677 RVA: 0x0027518D File Offset: 0x0027338D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C46 RID: 68678 RVA: 0x0027519A File Offset: 0x0027339A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C47 RID: 68679 RVA: 0x002751A4 File Offset: 0x002733A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetFetterGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetFetterGroupId);
			}
			this.stackEntries_.WriteTo(ref output, PhantomBatchDirectRefiningRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C48 RID: 68680 RVA: 0x002751F4 File Offset: 0x002733F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetFetterGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFetterGroupId);
			}
			num += this.stackEntries_.CalculateSize(PhantomBatchDirectRefiningRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C49 RID: 68681 RVA: 0x00275248 File Offset: 0x00273448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBatchDirectRefiningRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetFetterGroupId != 0)
			{
				this.TargetFetterGroupId = other.TargetFetterGroupId;
			}
			this.stackEntries_.Add(other.stackEntries_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010C4A RID: 68682 RVA: 0x00275295 File Offset: 0x00273495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C4B RID: 68683 RVA: 0x002752A0 File Offset: 0x002734A0
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.stackEntries_.AddEntriesFrom(ref input, PhantomBatchDirectRefiningRequest._repeated_stackEntries_codec);
					}
				}
				else
				{
					this.TargetFetterGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006AE9 RID: 27369
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AEA RID: 27370
		public const int TargetFetterGroupIdFieldNumber = 1;

		// Token: 0x04006AEB RID: 27371
		private int targetFetterGroupId_;

		// Token: 0x04006AEC RID: 27372
		public const int StackEntriesFieldNumber = 2;

		// Token: 0x04006AED RID: 27373
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(18U, PhantomStackConsumeEntry.Parser);

		// Token: 0x04006AEE RID: 27374
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
