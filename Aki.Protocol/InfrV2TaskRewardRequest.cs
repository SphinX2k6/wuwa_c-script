using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000807 RID: 2055
	[NetMessage(EMessageId.InfrV2TaskRewardRequest)]
	public sealed class InfrV2TaskRewardRequest : IMessage<InfrV2TaskRewardRequest>, IMessage, IEquatable<InfrV2TaskRewardRequest>, IDeepCloneable<InfrV2TaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600B7EC RID: 47084 RVA: 0x001B6640 File Offset: 0x001B4840
		[NullableContext(1)]
		public static InfrV2TaskRewardRequest Create()
		{
			return new InfrV2TaskRewardRequest();
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x0600B7ED RID: 47085 RVA: 0x001B6647 File Offset: 0x001B4847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x0600B7EE RID: 47086 RVA: 0x001B664A File Offset: 0x001B484A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600B7EF RID: 47087 RVA: 0x001B6651 File Offset: 0x001B4851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardRequest()
		{
		}

		// Token: 0x0600B7F0 RID: 47088 RVA: 0x001B6664 File Offset: 0x001B4864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardRequest(InfrV2TaskRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7F1 RID: 47089 RVA: 0x001B668E File Offset: 0x001B488E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardRequest Clone()
		{
			return new InfrV2TaskRewardRequest(this);
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x0600B7F2 RID: 47090 RVA: 0x001B6696 File Offset: 0x001B4896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600B7F3 RID: 47091 RVA: 0x001B669E File Offset: 0x001B489E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TaskRewardRequest);
		}

		// Token: 0x0600B7F4 RID: 47092 RVA: 0x001B66AC File Offset: 0x001B48AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7F5 RID: 47093 RVA: 0x001B66E0 File Offset: 0x001B48E0
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

		// Token: 0x0600B7F6 RID: 47094 RVA: 0x001B6714 File Offset: 0x001B4914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B7F7 RID: 47095 RVA: 0x001B6721 File Offset: 0x001B4921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7F8 RID: 47096 RVA: 0x001B672A File Offset: 0x001B492A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, InfrV2TaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x001B6754 File Offset: 0x001B4954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(InfrV2TaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x001B678D File Offset: 0x001B498D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x001B67BB File Offset: 0x001B49BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7FC RID: 47100 RVA: 0x001B67C4 File Offset: 0x001B49C4
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, InfrV2TaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04005121 RID: 20769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005122 RID: 20770
		public const int TaskIdsFieldNumber = 8;

		// Token: 0x04005123 RID: 20771
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04005124 RID: 20772
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
