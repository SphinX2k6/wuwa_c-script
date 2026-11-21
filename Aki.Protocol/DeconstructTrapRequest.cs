using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A6 RID: 934
	[NetMessage(EMessageId.DeconstructTrapRequest)]
	public sealed class DeconstructTrapRequest : IMessage<DeconstructTrapRequest>, IMessage, IEquatable<DeconstructTrapRequest>, IDeepCloneable<DeconstructTrapRequest>, IBufferMessage
	{
		// Token: 0x06005C27 RID: 23591 RVA: 0x000E0333 File Offset: 0x000DE533
		[NullableContext(1)]
		public static DeconstructTrapRequest Create()
		{
			return new DeconstructTrapRequest();
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06005C28 RID: 23592 RVA: 0x000E033A File Offset: 0x000DE53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06005C29 RID: 23593 RVA: 0x000E033D File Offset: 0x000DE53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeconstructTrapRequest.Descriptor;
			}
		}

		// Token: 0x06005C2A RID: 23594 RVA: 0x000E0344 File Offset: 0x000DE544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapRequest()
		{
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x000E034C File Offset: 0x000DE54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapRequest(DeconstructTrapRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x000E0371 File Offset: 0x000DE571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapRequest Clone()
		{
			return new DeconstructTrapRequest(this);
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06005C2D RID: 23597 RVA: 0x000E0379 File Offset: 0x000DE579
		// (set) Token: 0x06005C2E RID: 23598 RVA: 0x000E0381 File Offset: 0x000DE581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x06005C2F RID: 23599 RVA: 0x000E038A File Offset: 0x000DE58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeconstructTrapRequest);
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x000E0398 File Offset: 0x000DE598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeconstructTrapRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x000E03C8 File Offset: 0x000DE5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x000E0407 File Offset: 0x000DE607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x000E0414 File Offset: 0x000DE614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x000E041D File Offset: 0x000DE61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x000E0450 File Offset: 0x000DE650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x000E048E File Offset: 0x000DE68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeconstructTrapRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x000E04BF File Offset: 0x000DE6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x000E04C8 File Offset: 0x000DE6C8
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
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400368D RID: 13965
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400368E RID: 13966
		public const int IdFieldNumber = 7;

		// Token: 0x0400368F RID: 13967
		private long id_;
	}
}
