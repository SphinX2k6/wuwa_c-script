using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F5 RID: 2037
	[NetMessage(EMessageId.InfrV2TreeBuildRequest)]
	public sealed class InfrV2TreeBuildRequest : IMessage<InfrV2TreeBuildRequest>, IMessage, IEquatable<InfrV2TreeBuildRequest>, IDeepCloneable<InfrV2TreeBuildRequest>, IBufferMessage
	{
		// Token: 0x0600B6BA RID: 46778 RVA: 0x001B3FC1 File Offset: 0x001B21C1
		[NullableContext(1)]
		public static InfrV2TreeBuildRequest Create()
		{
			return new InfrV2TreeBuildRequest();
		}

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x0600B6BB RID: 46779 RVA: 0x001B3FC8 File Offset: 0x001B21C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x0600B6BC RID: 46780 RVA: 0x001B3FCB File Offset: 0x001B21CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TreeBuildRequest.Descriptor;
			}
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x001B3FD2 File Offset: 0x001B21D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildRequest()
		{
		}

		// Token: 0x0600B6BE RID: 46782 RVA: 0x001B3FDA File Offset: 0x001B21DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildRequest(InfrV2TreeBuildRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6BF RID: 46783 RVA: 0x001B3FFF File Offset: 0x001B21FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildRequest Clone()
		{
			return new InfrV2TreeBuildRequest(this);
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x0600B6C0 RID: 46784 RVA: 0x001B4007 File Offset: 0x001B2207
		// (set) Token: 0x0600B6C1 RID: 46785 RVA: 0x001B400F File Offset: 0x001B220F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600B6C2 RID: 46786 RVA: 0x001B4018 File Offset: 0x001B2218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TreeBuildRequest);
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x001B4026 File Offset: 0x001B2226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TreeBuildRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x001B4054 File Offset: 0x001B2254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B6C5 RID: 46789 RVA: 0x001B4093 File Offset: 0x001B2293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B6C6 RID: 46790 RVA: 0x001B40A0 File Offset: 0x001B22A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6C7 RID: 46791 RVA: 0x001B40A9 File Offset: 0x001B22A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6C8 RID: 46792 RVA: 0x001B40DC File Offset: 0x001B22DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B6C9 RID: 46793 RVA: 0x001B411A File Offset: 0x001B231A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TreeBuildRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B6CA RID: 46794 RVA: 0x001B414B File Offset: 0x001B234B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6CB RID: 46795 RVA: 0x001B4154 File Offset: 0x001B2354
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005121 RID: 20769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005122 RID: 20770
		public const int IdFieldNumber = 2;

		// Token: 0x04005123 RID: 20771
		private int id_;
	}
}
