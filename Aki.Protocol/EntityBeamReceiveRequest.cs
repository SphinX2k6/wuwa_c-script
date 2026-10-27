using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000470 RID: 1136
	[NetMessage(EMessageId.EntityBeamReceiveRequest)]
	public sealed class EntityBeamReceiveRequest : IMessage<EntityBeamReceiveRequest>, IMessage, IEquatable<EntityBeamReceiveRequest>, IDeepCloneable<EntityBeamReceiveRequest>, IBufferMessage
	{
		// Token: 0x06006C5A RID: 27738 RVA: 0x00105A8E File Offset: 0x00103C8E
		[NullableContext(1)]
		public static EntityBeamReceiveRequest Create()
		{
			return new EntityBeamReceiveRequest();
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06006C5B RID: 27739 RVA: 0x00105A95 File Offset: 0x00103C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06006C5C RID: 27740 RVA: 0x00105A98 File Offset: 0x00103C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBeamReceiveRequest.Descriptor;
			}
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x00105A9F File Offset: 0x00103C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveRequest()
		{
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x00105AA7 File Offset: 0x00103CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveRequest(EntityBeamReceiveRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.receiveType_ = other.receiveType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x00105AD8 File Offset: 0x00103CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveRequest Clone()
		{
			return new EntityBeamReceiveRequest(this);
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06006C60 RID: 27744 RVA: 0x00105AE0 File Offset: 0x00103CE0
		// (set) Token: 0x06006C61 RID: 27745 RVA: 0x00105AE8 File Offset: 0x00103CE8
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

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06006C62 RID: 27746 RVA: 0x00105AF1 File Offset: 0x00103CF1
		// (set) Token: 0x06006C63 RID: 27747 RVA: 0x00105AF9 File Offset: 0x00103CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveType ReceiveType
		{
			get
			{
				return this.receiveType_;
			}
			set
			{
				this.receiveType_ = value;
			}
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x00105B02 File Offset: 0x00103D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBeamReceiveRequest);
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x00105B10 File Offset: 0x00103D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBeamReceiveRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ReceiveType == other.ReceiveType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x00105B50 File Offset: 0x00103D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				num ^= this.ReceiveType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x00105BAE File Offset: 0x00103DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x00105BBB File Offset: 0x00103DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C69 RID: 27753 RVA: 0x00105BC4 File Offset: 0x00103DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ReceiveType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C6A RID: 27754 RVA: 0x00105C20 File Offset: 0x00103E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ReceiveType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x00105C78 File Offset: 0x00103E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBeamReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				this.ReceiveType = other.ReceiveType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x00105CC8 File Offset: 0x00103EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x00105CD4 File Offset: 0x00103ED4
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
				if (num != 88U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.ReceiveType = (EntityBeamReceiveType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003AEC RID: 15084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AED RID: 15085
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04003AEE RID: 15086
		private long entityId_;

		// Token: 0x04003AEF RID: 15087
		public const int ReceiveTypeFieldNumber = 11;

		// Token: 0x04003AF0 RID: 15088
		private EntityBeamReceiveType receiveType_;
	}
}
