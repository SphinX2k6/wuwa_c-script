using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D5 RID: 4565
	[NetMessage(EMessageId.SetInitTagRequest)]
	public sealed class SetInitTagRequest : IMessage<SetInitTagRequest>, IMessage, IEquatable<SetInitTagRequest>, IDeepCloneable<SetInitTagRequest>, IBufferMessage
	{
		// Token: 0x06018580 RID: 99712 RVA: 0x0038A9AD File Offset: 0x00388BAD
		[NullableContext(1)]
		public static SetInitTagRequest Create()
		{
			return new SetInitTagRequest();
		}

		// Token: 0x170051F9 RID: 20985
		// (get) Token: 0x06018581 RID: 99713 RVA: 0x0038A9B4 File Offset: 0x00388BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051FA RID: 20986
		// (get) Token: 0x06018582 RID: 99714 RVA: 0x0038A9B7 File Offset: 0x00388BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetInitTagRequest.Descriptor;
			}
		}

		// Token: 0x06018583 RID: 99715 RVA: 0x0038A9BE File Offset: 0x00388BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagRequest()
		{
		}

		// Token: 0x06018584 RID: 99716 RVA: 0x0038A9C6 File Offset: 0x00388BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagRequest(SetInitTagRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018585 RID: 99717 RVA: 0x0038A9EB File Offset: 0x00388BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagRequest Clone()
		{
			return new SetInitTagRequest(this);
		}

		// Token: 0x170051FB RID: 20987
		// (get) Token: 0x06018586 RID: 99718 RVA: 0x0038A9F3 File Offset: 0x00388BF3
		// (set) Token: 0x06018587 RID: 99719 RVA: 0x0038A9FB File Offset: 0x00388BFB
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

		// Token: 0x06018588 RID: 99720 RVA: 0x0038AA04 File Offset: 0x00388C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetInitTagRequest);
		}

		// Token: 0x06018589 RID: 99721 RVA: 0x0038AA12 File Offset: 0x00388C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetInitTagRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601858A RID: 99722 RVA: 0x0038AA40 File Offset: 0x00388C40
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

		// Token: 0x0601858B RID: 99723 RVA: 0x0038AA7F File Offset: 0x00388C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601858C RID: 99724 RVA: 0x0038AA8C File Offset: 0x00388C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601858D RID: 99725 RVA: 0x0038AA95 File Offset: 0x00388C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601858E RID: 99726 RVA: 0x0038AAC8 File Offset: 0x00388CC8
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

		// Token: 0x0601858F RID: 99727 RVA: 0x0038AB06 File Offset: 0x00388D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetInitTagRequest other)
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

		// Token: 0x06018590 RID: 99728 RVA: 0x0038AB37 File Offset: 0x00388D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018591 RID: 99729 RVA: 0x0038AB40 File Offset: 0x00388D40
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009015 RID: 36885
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009016 RID: 36886
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04009017 RID: 36887
		private long entityId_;
	}
}
