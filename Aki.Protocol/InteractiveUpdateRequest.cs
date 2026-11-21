using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081E RID: 2078
	[NetMessage(EMessageId.InteractiveUpdateRequest)]
	public sealed class InteractiveUpdateRequest : IMessage<InteractiveUpdateRequest>, IMessage, IEquatable<InteractiveUpdateRequest>, IDeepCloneable<InteractiveUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600BA26 RID: 47654 RVA: 0x001BBF2C File Offset: 0x001BA12C
		[NullableContext(1)]
		public static InteractiveUpdateRequest Create()
		{
			return new InteractiveUpdateRequest();
		}

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x0600BA27 RID: 47655 RVA: 0x001BBF33 File Offset: 0x001BA133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x0600BA28 RID: 47656 RVA: 0x001BBF36 File Offset: 0x001BA136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractiveUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600BA29 RID: 47657 RVA: 0x001BBF3D File Offset: 0x001BA13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateRequest()
		{
		}

		// Token: 0x0600BA2A RID: 47658 RVA: 0x001BBF45 File Offset: 0x001BA145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateRequest(InteractiveUpdateRequest other) : this()
		{
			this.interactiveId_ = other.interactiveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA2B RID: 47659 RVA: 0x001BBF6A File Offset: 0x001BA16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractiveUpdateRequest Clone()
		{
			return new InteractiveUpdateRequest(this);
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x0600BA2C RID: 47660 RVA: 0x001BBF72 File Offset: 0x001BA172
		// (set) Token: 0x0600BA2D RID: 47661 RVA: 0x001BBF7A File Offset: 0x001BA17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InteractiveId
		{
			get
			{
				return this.interactiveId_;
			}
			set
			{
				this.interactiveId_ = value;
			}
		}

		// Token: 0x0600BA2E RID: 47662 RVA: 0x001BBF83 File Offset: 0x001BA183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractiveUpdateRequest);
		}

		// Token: 0x0600BA2F RID: 47663 RVA: 0x001BBF91 File Offset: 0x001BA191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractiveUpdateRequest other)
		{
			return other != null && (other == this || (this.InteractiveId == other.InteractiveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA30 RID: 47664 RVA: 0x001BBFC0 File Offset: 0x001BA1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InteractiveId != 0)
			{
				num ^= this.InteractiveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA31 RID: 47665 RVA: 0x001BBFFF File Offset: 0x001BA1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA32 RID: 47666 RVA: 0x001BC00C File Offset: 0x001BA20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA33 RID: 47667 RVA: 0x001BC015 File Offset: 0x001BA215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractiveId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.InteractiveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA34 RID: 47668 RVA: 0x001BC048 File Offset: 0x001BA248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InteractiveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InteractiveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA35 RID: 47669 RVA: 0x001BC086 File Offset: 0x001BA286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractiveUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InteractiveId != 0)
			{
				this.InteractiveId = other.InteractiveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA36 RID: 47670 RVA: 0x001BC0B7 File Offset: 0x001BA2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x001BC0C0 File Offset: 0x001BA2C0
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InteractiveId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005244 RID: 21060
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005245 RID: 21061
		public const int InteractiveIdFieldNumber = 7;

		// Token: 0x04005246 RID: 21062
		private int interactiveId_;
	}
}
