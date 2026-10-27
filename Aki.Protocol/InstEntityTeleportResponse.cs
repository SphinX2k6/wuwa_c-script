using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000822 RID: 2082
	[NetMessage(EMessageId.InstEntityTeleportResponse)]
	public sealed class InstEntityTeleportResponse : IMessage<InstEntityTeleportResponse>, IMessage, IEquatable<InstEntityTeleportResponse>, IDeepCloneable<InstEntityTeleportResponse>, IBufferMessage
	{
		// Token: 0x0600BA02 RID: 47618 RVA: 0x001BA9EC File Offset: 0x001B8BEC
		[NullableContext(1)]
		public static InstEntityTeleportResponse Create()
		{
			return new InstEntityTeleportResponse();
		}

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x0600BA03 RID: 47619 RVA: 0x001BA9F3 File Offset: 0x001B8BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x0600BA04 RID: 47620 RVA: 0x001BA9F6 File Offset: 0x001B8BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstEntityTeleportResponse.Descriptor;
			}
		}

		// Token: 0x0600BA05 RID: 47621 RVA: 0x001BA9FD File Offset: 0x001B8BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportResponse()
		{
		}

		// Token: 0x0600BA06 RID: 47622 RVA: 0x001BAA05 File Offset: 0x001B8C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportResponse(InstEntityTeleportResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA07 RID: 47623 RVA: 0x001BAA2A File Offset: 0x001B8C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportResponse Clone()
		{
			return new InstEntityTeleportResponse(this);
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x0600BA08 RID: 47624 RVA: 0x001BAA32 File Offset: 0x001B8C32
		// (set) Token: 0x0600BA09 RID: 47625 RVA: 0x001BAA3A File Offset: 0x001B8C3A
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

		// Token: 0x0600BA0A RID: 47626 RVA: 0x001BAA43 File Offset: 0x001B8C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstEntityTeleportResponse);
		}

		// Token: 0x0600BA0B RID: 47627 RVA: 0x001BAA51 File Offset: 0x001B8C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstEntityTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA0C RID: 47628 RVA: 0x001BAA80 File Offset: 0x001B8C80
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

		// Token: 0x0600BA0D RID: 47629 RVA: 0x001BAAC5 File Offset: 0x001B8CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA0E RID: 47630 RVA: 0x001BAAD2 File Offset: 0x001B8CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA0F RID: 47631 RVA: 0x001BAADB File Offset: 0x001B8CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA10 RID: 47632 RVA: 0x001BAB10 File Offset: 0x001B8D10
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

		// Token: 0x0600BA11 RID: 47633 RVA: 0x001BAB4E File Offset: 0x001B8D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstEntityTeleportResponse other)
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

		// Token: 0x0600BA12 RID: 47634 RVA: 0x001BAB7F File Offset: 0x001B8D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA13 RID: 47635 RVA: 0x001BAB88 File Offset: 0x001B8D88
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040051A9 RID: 20905
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051AA RID: 20906
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040051AB RID: 20907
		private ErrorCode errorCode_;
	}
}
