using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A1 RID: 929
	[NetMessage(EMessageId.DeadeyeShootHitResponse)]
	public sealed class DeadeyeShootHitResponse : IMessage<DeadeyeShootHitResponse>, IMessage, IEquatable<DeadeyeShootHitResponse>, IDeepCloneable<DeadeyeShootHitResponse>, IBufferMessage
	{
		// Token: 0x06005BBD RID: 23485 RVA: 0x000DF4F0 File Offset: 0x000DD6F0
		[NullableContext(1)]
		public static DeadeyeShootHitResponse Create()
		{
			return new DeadeyeShootHitResponse();
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06005BBE RID: 23486 RVA: 0x000DF4F7 File Offset: 0x000DD6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06005BBF RID: 23487 RVA: 0x000DF4FA File Offset: 0x000DD6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeadeyeShootHitResponse.Descriptor;
			}
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x000DF501 File Offset: 0x000DD701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitResponse()
		{
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x000DF509 File Offset: 0x000DD709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitResponse(DeadeyeShootHitResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x000DF52E File Offset: 0x000DD72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitResponse Clone()
		{
			return new DeadeyeShootHitResponse(this);
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06005BC3 RID: 23491 RVA: 0x000DF536 File Offset: 0x000DD736
		// (set) Token: 0x06005BC4 RID: 23492 RVA: 0x000DF53E File Offset: 0x000DD73E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x000DF547 File Offset: 0x000DD747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeadeyeShootHitResponse);
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x000DF555 File Offset: 0x000DD755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeadeyeShootHitResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x000DF584 File Offset: 0x000DD784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x000DF5C9 File Offset: 0x000DD7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x000DF5D6 File Offset: 0x000DD7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x000DF5DF File Offset: 0x000DD7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x000DF610 File Offset: 0x000DD810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x000DF64E File Offset: 0x000DD84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeadeyeShootHitResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x000DF67F File Offset: 0x000DD87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BCE RID: 23502 RVA: 0x000DF688 File Offset: 0x000DD888
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400366E RID: 13934
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400366F RID: 13935
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04003670 RID: 13936
		private ErrorCode errCode_;
	}
}
