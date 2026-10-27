using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D6 RID: 2006
	[NetMessage(EMessageId.InfrArchiveTaskRewardRequest)]
	public sealed class InfrArchiveTaskRewardRequest : IMessage<InfrArchiveTaskRewardRequest>, IMessage, IEquatable<InfrArchiveTaskRewardRequest>, IDeepCloneable<InfrArchiveTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600B43E RID: 46142 RVA: 0x001AF0C5 File Offset: 0x001AD2C5
		[NullableContext(1)]
		public static InfrArchiveTaskRewardRequest Create()
		{
			return new InfrArchiveTaskRewardRequest();
		}

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x0600B43F RID: 46143 RVA: 0x001AF0CC File Offset: 0x001AD2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x0600B440 RID: 46144 RVA: 0x001AF0CF File Offset: 0x001AD2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrArchiveTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600B441 RID: 46145 RVA: 0x001AF0D6 File Offset: 0x001AD2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardRequest()
		{
		}

		// Token: 0x0600B442 RID: 46146 RVA: 0x001AF0E9 File Offset: 0x001AD2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardRequest(InfrArchiveTaskRewardRequest other) : this()
		{
			this.targetIds_ = other.targetIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B443 RID: 46147 RVA: 0x001AF113 File Offset: 0x001AD313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardRequest Clone()
		{
			return new InfrArchiveTaskRewardRequest(this);
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x0600B444 RID: 46148 RVA: 0x001AF11B File Offset: 0x001AD31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TargetIds
		{
			get
			{
				return this.targetIds_;
			}
		}

		// Token: 0x0600B445 RID: 46149 RVA: 0x001AF123 File Offset: 0x001AD323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrArchiveTaskRewardRequest);
		}

		// Token: 0x0600B446 RID: 46150 RVA: 0x001AF131 File Offset: 0x001AD331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrArchiveTaskRewardRequest other)
		{
			return other != null && (other == this || (this.targetIds_.Equals(other.targetIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B447 RID: 46151 RVA: 0x001AF164 File Offset: 0x001AD364
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

		// Token: 0x0600B448 RID: 46152 RVA: 0x001AF198 File Offset: 0x001AD398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B449 RID: 46153 RVA: 0x001AF1A5 File Offset: 0x001AD3A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B44A RID: 46154 RVA: 0x001AF1AE File Offset: 0x001AD3AE
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

		// Token: 0x0600B44B RID: 46155 RVA: 0x001AF1D8 File Offset: 0x001AD3D8
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

		// Token: 0x0600B44C RID: 46156 RVA: 0x001AF211 File Offset: 0x001AD411
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

		// Token: 0x0600B44D RID: 46157 RVA: 0x001AF23F File Offset: 0x001AD43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B44E RID: 46158 RVA: 0x001AF248 File Offset: 0x001AD448
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.targetIds_.AddEntriesFrom(ref input, InfrArchiveTaskRewardRequest._repeated_targetIds_codec);
				}
			}
		}

		// Token: 0x04005041 RID: 20545
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005042 RID: 20546
		public const int TargetIdsFieldNumber = 11;

		// Token: 0x04005043 RID: 20547
		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04005044 RID: 20548
		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();
	}
}
