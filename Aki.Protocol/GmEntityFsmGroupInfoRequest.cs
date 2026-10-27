using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FA RID: 1786
	[NetMessage(EMessageId.GmEntityFsmGroupInfoRequest)]
	public sealed class GmEntityFsmGroupInfoRequest : IMessage<GmEntityFsmGroupInfoRequest>, IMessage, IEquatable<GmEntityFsmGroupInfoRequest>, IDeepCloneable<GmEntityFsmGroupInfoRequest>, IBufferMessage
	{
		// Token: 0x0600A2AF RID: 41647 RVA: 0x00189519 File Offset: 0x00187719
		[NullableContext(1)]
		public static GmEntityFsmGroupInfoRequest Create()
		{
			return new GmEntityFsmGroupInfoRequest();
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x0600A2B0 RID: 41648 RVA: 0x00189520 File Offset: 0x00187720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x0600A2B1 RID: 41649 RVA: 0x00189523 File Offset: 0x00187723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmEntityFsmGroupInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x0018952A File Offset: 0x0018772A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoRequest()
		{
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x00189532 File Offset: 0x00187732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoRequest(GmEntityFsmGroupInfoRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x00189557 File Offset: 0x00187757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoRequest Clone()
		{
			return new GmEntityFsmGroupInfoRequest(this);
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x0600A2B5 RID: 41653 RVA: 0x0018955F File Offset: 0x0018775F
		// (set) Token: 0x0600A2B6 RID: 41654 RVA: 0x00189567 File Offset: 0x00187767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x00189570 File Offset: 0x00187770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmEntityFsmGroupInfoRequest);
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x0018957E File Offset: 0x0018777E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmEntityFsmGroupInfoRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2B9 RID: 41657 RVA: 0x001895AC File Offset: 0x001877AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2BA RID: 41658 RVA: 0x001895EB File Offset: 0x001877EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x001895F8 File Offset: 0x001877F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x00189601 File Offset: 0x00187801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2BD RID: 41661 RVA: 0x00189634 File Offset: 0x00187834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2BE RID: 41662 RVA: 0x00189672 File Offset: 0x00187872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmEntityFsmGroupInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A2BF RID: 41663 RVA: 0x001896A3 File Offset: 0x001878A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2C0 RID: 41664 RVA: 0x001896AC File Offset: 0x001878AC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004B55 RID: 19285
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B56 RID: 19286
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04004B57 RID: 19287
		private long entityId_;
	}
}
