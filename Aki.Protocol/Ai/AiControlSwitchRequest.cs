using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001728 RID: 5928
	[NetMessage(EMessageId.AiControlSwitchRequest)]
	public sealed class AiControlSwitchRequest : IMessage<AiControlSwitchRequest>, IMessage, IEquatable<AiControlSwitchRequest>, IDeepCloneable<AiControlSwitchRequest>, IBufferMessage
	{
		// Token: 0x0601DC1E RID: 121886 RVA: 0x0045D549 File Offset: 0x0045B749
		[NullableContext(1)]
		public static AiControlSwitchRequest Create()
		{
			return new AiControlSwitchRequest();
		}

		// Token: 0x17006551 RID: 25937
		// (get) Token: 0x0601DC1F RID: 121887 RVA: 0x0045D550 File Offset: 0x0045B750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006552 RID: 25938
		// (get) Token: 0x0601DC20 RID: 121888 RVA: 0x0045D553 File Offset: 0x0045B753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiControlSwitchRequest.Descriptor;
			}
		}

		// Token: 0x0601DC21 RID: 121889 RVA: 0x0045D55A File Offset: 0x0045B75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchRequest()
		{
		}

		// Token: 0x0601DC22 RID: 121890 RVA: 0x0045D562 File Offset: 0x0045B762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchRequest(AiControlSwitchRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DC23 RID: 121891 RVA: 0x0045D587 File Offset: 0x0045B787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchRequest Clone()
		{
			return new AiControlSwitchRequest(this);
		}

		// Token: 0x17006553 RID: 25939
		// (get) Token: 0x0601DC24 RID: 121892 RVA: 0x0045D58F File Offset: 0x0045B78F
		// (set) Token: 0x0601DC25 RID: 121893 RVA: 0x0045D597 File Offset: 0x0045B797
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

		// Token: 0x0601DC26 RID: 121894 RVA: 0x0045D5A0 File Offset: 0x0045B7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiControlSwitchRequest);
		}

		// Token: 0x0601DC27 RID: 121895 RVA: 0x0045D5AE File Offset: 0x0045B7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiControlSwitchRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DC28 RID: 121896 RVA: 0x0045D5DC File Offset: 0x0045B7DC
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

		// Token: 0x0601DC29 RID: 121897 RVA: 0x0045D61B File Offset: 0x0045B81B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DC2A RID: 121898 RVA: 0x0045D628 File Offset: 0x0045B828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DC2B RID: 121899 RVA: 0x0045D631 File Offset: 0x0045B831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DC2C RID: 121900 RVA: 0x0045D664 File Offset: 0x0045B864
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

		// Token: 0x0601DC2D RID: 121901 RVA: 0x0045D6A2 File Offset: 0x0045B8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiControlSwitchRequest other)
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

		// Token: 0x0601DC2E RID: 121902 RVA: 0x0045D6D3 File Offset: 0x0045B8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DC2F RID: 121903 RVA: 0x0045D6DC File Offset: 0x0045B8DC
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400C963 RID: 51555
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C964 RID: 51556
		public const int EntityIdFieldNumber = 6;

		// Token: 0x0400C965 RID: 51557
		private long entityId_;
	}
}
