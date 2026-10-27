using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B8 RID: 952
	[NetMessage(EMessageId.DeadeyeShootHitResponse)]
	public sealed class DeadeyeShootHitResponse : IMessage<DeadeyeShootHitResponse>, IMessage, IEquatable<DeadeyeShootHitResponse>, IDeepCloneable<DeadeyeShootHitResponse>, IBufferMessage
	{
		// Token: 0x06005D4F RID: 23887 RVA: 0x000E2734 File Offset: 0x000E0934
		[NullableContext(1)]
		public static DeadeyeShootHitResponse Create()
		{
			return new DeadeyeShootHitResponse();
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06005D50 RID: 23888 RVA: 0x000E273B File Offset: 0x000E093B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06005D51 RID: 23889 RVA: 0x000E273E File Offset: 0x000E093E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeadeyeShootHitResponse.Descriptor;
			}
		}

		// Token: 0x06005D52 RID: 23890 RVA: 0x000E2745 File Offset: 0x000E0945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitResponse()
		{
		}

		// Token: 0x06005D53 RID: 23891 RVA: 0x000E274D File Offset: 0x000E094D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitResponse(DeadeyeShootHitResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x000E2772 File Offset: 0x000E0972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeadeyeShootHitResponse Clone()
		{
			return new DeadeyeShootHitResponse(this);
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06005D55 RID: 23893 RVA: 0x000E277A File Offset: 0x000E097A
		// (set) Token: 0x06005D56 RID: 23894 RVA: 0x000E2782 File Offset: 0x000E0982
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

		// Token: 0x06005D57 RID: 23895 RVA: 0x000E278B File Offset: 0x000E098B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeadeyeShootHitResponse);
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x000E2799 File Offset: 0x000E0999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeadeyeShootHitResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D59 RID: 23897 RVA: 0x000E27C8 File Offset: 0x000E09C8
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

		// Token: 0x06005D5A RID: 23898 RVA: 0x000E280D File Offset: 0x000E0A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D5B RID: 23899 RVA: 0x000E281A File Offset: 0x000E0A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x000E2823 File Offset: 0x000E0A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x000E2858 File Offset: 0x000E0A58
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

		// Token: 0x06005D5E RID: 23902 RVA: 0x000E2896 File Offset: 0x000E0A96
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

		// Token: 0x06005D5F RID: 23903 RVA: 0x000E28C7 File Offset: 0x000E0AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D60 RID: 23904 RVA: 0x000E28D0 File Offset: 0x000E0AD0
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003683 RID: 13955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003684 RID: 13956
		public const int ErrCodeFieldNumber = 3;

		// Token: 0x04003685 RID: 13957
		private ErrorCode errCode_;
	}
}
