using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000463 RID: 1123
	[NetMessage(EMessageId.EntityActiveRequest)]
	public sealed class EntityActiveRequest : IMessage<EntityActiveRequest>, IMessage, IEquatable<EntityActiveRequest>, IDeepCloneable<EntityActiveRequest>, IBufferMessage
	{
		// Token: 0x06006B32 RID: 27442 RVA: 0x00102933 File Offset: 0x00100B33
		[NullableContext(1)]
		public static EntityActiveRequest Create()
		{
			return new EntityActiveRequest();
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06006B33 RID: 27443 RVA: 0x0010293A File Offset: 0x00100B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06006B34 RID: 27444 RVA: 0x0010293D File Offset: 0x00100B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityActiveRequest.Descriptor;
			}
		}

		// Token: 0x06006B35 RID: 27445 RVA: 0x00102944 File Offset: 0x00100B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityActiveRequest()
		{
		}

		// Token: 0x06006B36 RID: 27446 RVA: 0x0010294C File Offset: 0x00100B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityActiveRequest(EntityActiveRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B37 RID: 27447 RVA: 0x00102971 File Offset: 0x00100B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityActiveRequest Clone()
		{
			return new EntityActiveRequest(this);
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06006B38 RID: 27448 RVA: 0x00102979 File Offset: 0x00100B79
		// (set) Token: 0x06006B39 RID: 27449 RVA: 0x00102981 File Offset: 0x00100B81
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

		// Token: 0x06006B3A RID: 27450 RVA: 0x0010298A File Offset: 0x00100B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityActiveRequest);
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x00102998 File Offset: 0x00100B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityActiveRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x001029C8 File Offset: 0x00100BC8
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

		// Token: 0x06006B3D RID: 27453 RVA: 0x00102A07 File Offset: 0x00100C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x00102A14 File Offset: 0x00100C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x00102A1D File Offset: 0x00100C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x00102A50 File Offset: 0x00100C50
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

		// Token: 0x06006B41 RID: 27457 RVA: 0x00102A8E File Offset: 0x00100C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityActiveRequest other)
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

		// Token: 0x06006B42 RID: 27458 RVA: 0x00102ABF File Offset: 0x00100CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x00102AC8 File Offset: 0x00100CC8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003A81 RID: 14977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A82 RID: 14978
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04003A83 RID: 14979
		private long entityId_;
	}
}
