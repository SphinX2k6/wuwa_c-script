using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007EC RID: 2028
	[NetMessage(EMessageId.InfrV2ManualSwitchTraceTreeRequest)]
	public sealed class InfrV2ManualSwitchTraceTreeRequest : IMessage<InfrV2ManualSwitchTraceTreeRequest>, IMessage, IEquatable<InfrV2ManualSwitchTraceTreeRequest>, IDeepCloneable<InfrV2ManualSwitchTraceTreeRequest>, IBufferMessage
	{
		// Token: 0x0600B608 RID: 46600 RVA: 0x001B286C File Offset: 0x001B0A6C
		[NullableContext(1)]
		public static InfrV2ManualSwitchTraceTreeRequest Create()
		{
			return new InfrV2ManualSwitchTraceTreeRequest();
		}

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x0600B609 RID: 46601 RVA: 0x001B2873 File Offset: 0x001B0A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x0600B60A RID: 46602 RVA: 0x001B2876 File Offset: 0x001B0A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ManualSwitchTraceTreeRequest.Descriptor;
			}
		}

		// Token: 0x0600B60B RID: 46603 RVA: 0x001B287D File Offset: 0x001B0A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeRequest()
		{
		}

		// Token: 0x0600B60C RID: 46604 RVA: 0x001B2885 File Offset: 0x001B0A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeRequest(InfrV2ManualSwitchTraceTreeRequest other) : this()
		{
			this.treeId_ = other.treeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B60D RID: 46605 RVA: 0x001B28AA File Offset: 0x001B0AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeRequest Clone()
		{
			return new InfrV2ManualSwitchTraceTreeRequest(this);
		}

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x0600B60E RID: 46606 RVA: 0x001B28B2 File Offset: 0x001B0AB2
		// (set) Token: 0x0600B60F RID: 46607 RVA: 0x001B28BA File Offset: 0x001B0ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeId
		{
			get
			{
				return this.treeId_;
			}
			set
			{
				this.treeId_ = value;
			}
		}

		// Token: 0x0600B610 RID: 46608 RVA: 0x001B28C3 File Offset: 0x001B0AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ManualSwitchTraceTreeRequest);
		}

		// Token: 0x0600B611 RID: 46609 RVA: 0x001B28D1 File Offset: 0x001B0AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ManualSwitchTraceTreeRequest other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B612 RID: 46610 RVA: 0x001B2900 File Offset: 0x001B0B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B613 RID: 46611 RVA: 0x001B293F File Offset: 0x001B0B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B614 RID: 46612 RVA: 0x001B294C File Offset: 0x001B0B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x001B2955 File Offset: 0x001B0B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B616 RID: 46614 RVA: 0x001B2988 File Offset: 0x001B0B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B617 RID: 46615 RVA: 0x001B29C6 File Offset: 0x001B0BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2ManualSwitchTraceTreeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B618 RID: 46616 RVA: 0x001B29F7 File Offset: 0x001B0BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B619 RID: 46617 RVA: 0x001B2A00 File Offset: 0x001B0C00
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
					this.TreeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040050F0 RID: 20720
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050F1 RID: 20721
		public const int TreeIdFieldNumber = 2;

		// Token: 0x040050F2 RID: 20722
		private int treeId_;
	}
}
