using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1C RID: 3100
	[NetMessage(EMessageId.PhantomBatchDirectRefiningRequest)]
	public sealed class PhantomBatchDirectRefiningRequest : IMessage<PhantomBatchDirectRefiningRequest>, IMessage, IEquatable<PhantomBatchDirectRefiningRequest>, IDeepCloneable<PhantomBatchDirectRefiningRequest>, IBufferMessage
	{
		// Token: 0x06010D39 RID: 68921 RVA: 0x00276DC8 File Offset: 0x00274FC8
		[NullableContext(1)]
		public static PhantomBatchDirectRefiningRequest Create()
		{
			return new PhantomBatchDirectRefiningRequest();
		}

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x06010D3A RID: 68922 RVA: 0x00276DCF File Offset: 0x00274FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x06010D3B RID: 68923 RVA: 0x00276DD2 File Offset: 0x00274FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchDirectRefiningRequest.Descriptor;
			}
		}

		// Token: 0x06010D3C RID: 68924 RVA: 0x00276DD9 File Offset: 0x00274FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchDirectRefiningRequest()
		{
		}

		// Token: 0x06010D3D RID: 68925 RVA: 0x00276DEC File Offset: 0x00274FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchDirectRefiningRequest(PhantomBatchDirectRefiningRequest other) : this()
		{
			this.targetFetterGroupId_ = other.targetFetterGroupId_;
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D3E RID: 68926 RVA: 0x00276E22 File Offset: 0x00275022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchDirectRefiningRequest Clone()
		{
			return new PhantomBatchDirectRefiningRequest(this);
		}

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x06010D3F RID: 68927 RVA: 0x00276E2A File Offset: 0x0027502A
		// (set) Token: 0x06010D40 RID: 68928 RVA: 0x00276E32 File Offset: 0x00275032
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

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x06010D41 RID: 68929 RVA: 0x00276E3B File Offset: 0x0027503B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06010D42 RID: 68930 RVA: 0x00276E43 File Offset: 0x00275043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchDirectRefiningRequest);
		}

		// Token: 0x06010D43 RID: 68931 RVA: 0x00276E54 File Offset: 0x00275054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchDirectRefiningRequest other)
		{
			return other != null && (other == this || (this.TargetFetterGroupId == other.TargetFetterGroupId && this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D44 RID: 68932 RVA: 0x00276EA4 File Offset: 0x002750A4
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

		// Token: 0x06010D45 RID: 68933 RVA: 0x00276EF1 File Offset: 0x002750F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D46 RID: 68934 RVA: 0x00276EFE File Offset: 0x002750FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D47 RID: 68935 RVA: 0x00276F08 File Offset: 0x00275108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stackEntries_.WriteTo(ref output, PhantomBatchDirectRefiningRequest._repeated_stackEntries_codec);
			if (this.TargetFetterGroupId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TargetFetterGroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D48 RID: 68936 RVA: 0x00276F58 File Offset: 0x00275158
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

		// Token: 0x06010D49 RID: 68937 RVA: 0x00276FAC File Offset: 0x002751AC
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

		// Token: 0x06010D4A RID: 68938 RVA: 0x00276FF9 File Offset: 0x002751F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D4B RID: 68939 RVA: 0x00277004 File Offset: 0x00275204
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
				if (num != 34U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetFetterGroupId = input.ReadInt32();
					}
				}
				else
				{
					this.stackEntries_.AddEntriesFrom(ref input, PhantomBatchDirectRefiningRequest._repeated_stackEntries_codec);
				}
			}
		}

		// Token: 0x04006AD5 RID: 27349
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AD6 RID: 27350
		public const int TargetFetterGroupIdFieldNumber = 14;

		// Token: 0x04006AD7 RID: 27351
		private int targetFetterGroupId_;

		// Token: 0x04006AD8 RID: 27352
		public const int StackEntriesFieldNumber = 4;

		// Token: 0x04006AD9 RID: 27353
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(34U, PhantomStackConsumeEntry.Parser);

		// Token: 0x04006ADA RID: 27354
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
