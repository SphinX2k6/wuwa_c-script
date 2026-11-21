using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000486 RID: 1158
	[NetMessage(EMessageId.EntityIsVisibleResponse)]
	public sealed class EntityIsVisibleResponse : IMessage<EntityIsVisibleResponse>, IMessage, IEquatable<EntityIsVisibleResponse>, IDeepCloneable<EntityIsVisibleResponse>, IBufferMessage
	{
		// Token: 0x06006F30 RID: 28464 RVA: 0x00111AFA File Offset: 0x0010FCFA
		[NullableContext(1)]
		public static EntityIsVisibleResponse Create()
		{
			return new EntityIsVisibleResponse();
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06006F31 RID: 28465 RVA: 0x00111B01 File Offset: 0x0010FD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06006F32 RID: 28466 RVA: 0x00111B04 File Offset: 0x0010FD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityIsVisibleResponse.Descriptor;
			}
		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x00111B0B File Offset: 0x0010FD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleResponse()
		{
		}

		// Token: 0x06006F34 RID: 28468 RVA: 0x00111B13 File Offset: 0x0010FD13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleResponse(EntityIsVisibleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F35 RID: 28469 RVA: 0x00111B38 File Offset: 0x0010FD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleResponse Clone()
		{
			return new EntityIsVisibleResponse(this);
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06006F36 RID: 28470 RVA: 0x00111B40 File Offset: 0x0010FD40
		// (set) Token: 0x06006F37 RID: 28471 RVA: 0x00111B48 File Offset: 0x0010FD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x00111B51 File Offset: 0x0010FD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityIsVisibleResponse);
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x00111B5F File Offset: 0x0010FD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityIsVisibleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x00111B90 File Offset: 0x0010FD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F3B RID: 28475 RVA: 0x00111BD5 File Offset: 0x0010FDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F3C RID: 28476 RVA: 0x00111BE2 File Offset: 0x0010FDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F3D RID: 28477 RVA: 0x00111BEB File Offset: 0x0010FDEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x00111C20 File Offset: 0x0010FE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x00111C5E File Offset: 0x0010FE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityIsVisibleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x00111C8F File Offset: 0x0010FE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x00111C98 File Offset: 0x0010FE98
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003C3F RID: 15423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C40 RID: 15424
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04003C41 RID: 15425
		private ErrorCode errorCode_;
	}
}
