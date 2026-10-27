using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000730 RID: 1840
	[NetMessage(EMessageId.H5ViewActivityReadRequest)]
	public sealed class H5ViewActivityReadRequest : IMessage<H5ViewActivityReadRequest>, IMessage, IEquatable<H5ViewActivityReadRequest>, IDeepCloneable<H5ViewActivityReadRequest>, IBufferMessage
	{
		// Token: 0x0600A6F2 RID: 42738 RVA: 0x00192214 File Offset: 0x00190414
		[NullableContext(1)]
		public static H5ViewActivityReadRequest Create()
		{
			return new H5ViewActivityReadRequest();
		}

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x0600A6F3 RID: 42739 RVA: 0x0019221B File Offset: 0x0019041B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x0600A6F4 RID: 42740 RVA: 0x0019221E File Offset: 0x0019041E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5ViewActivityReadRequest.Descriptor;
			}
		}

		// Token: 0x0600A6F5 RID: 42741 RVA: 0x00192225 File Offset: 0x00190425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadRequest()
		{
		}

		// Token: 0x0600A6F6 RID: 42742 RVA: 0x0019222D File Offset: 0x0019042D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadRequest(H5ViewActivityReadRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6F7 RID: 42743 RVA: 0x00192252 File Offset: 0x00190452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadRequest Clone()
		{
			return new H5ViewActivityReadRequest(this);
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x0600A6F8 RID: 42744 RVA: 0x0019225A File Offset: 0x0019045A
		// (set) Token: 0x0600A6F9 RID: 42745 RVA: 0x00192262 File Offset: 0x00190462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x0600A6FA RID: 42746 RVA: 0x0019226B File Offset: 0x0019046B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5ViewActivityReadRequest);
		}

		// Token: 0x0600A6FB RID: 42747 RVA: 0x00192279 File Offset: 0x00190479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5ViewActivityReadRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6FC RID: 42748 RVA: 0x001922A8 File Offset: 0x001904A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6FD RID: 42749 RVA: 0x001922E7 File Offset: 0x001904E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A6FE RID: 42750 RVA: 0x001922F4 File Offset: 0x001904F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6FF RID: 42751 RVA: 0x001922FD File Offset: 0x001904FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A700 RID: 42752 RVA: 0x00192330 File Offset: 0x00190530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A701 RID: 42753 RVA: 0x0019236E File Offset: 0x0019056E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5ViewActivityReadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A702 RID: 42754 RVA: 0x0019239F File Offset: 0x0019059F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A703 RID: 42755 RVA: 0x001923A8 File Offset: 0x001905A8
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004C71 RID: 19569
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C72 RID: 19570
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04004C73 RID: 19571
		private int activityId_;
	}
}
