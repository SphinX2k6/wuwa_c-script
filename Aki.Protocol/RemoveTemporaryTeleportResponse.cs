using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0F RID: 3855
	[NetMessage(EMessageId.RemoveTemporaryTeleportResponse)]
	public sealed class RemoveTemporaryTeleportResponse : IMessage<RemoveTemporaryTeleportResponse>, IMessage, IEquatable<RemoveTemporaryTeleportResponse>, IDeepCloneable<RemoveTemporaryTeleportResponse>, IBufferMessage
	{
		// Token: 0x06014A44 RID: 84548 RVA: 0x002FF2F9 File Offset: 0x002FD4F9
		[NullableContext(1)]
		public static RemoveTemporaryTeleportResponse Create()
		{
			return new RemoveTemporaryTeleportResponse();
		}

		// Token: 0x1700449F RID: 17567
		// (get) Token: 0x06014A45 RID: 84549 RVA: 0x002FF300 File Offset: 0x002FD500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044A0 RID: 17568
		// (get) Token: 0x06014A46 RID: 84550 RVA: 0x002FF303 File Offset: 0x002FD503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveTemporaryTeleportResponse.Descriptor;
			}
		}

		// Token: 0x06014A47 RID: 84551 RVA: 0x002FF30A File Offset: 0x002FD50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportResponse()
		{
		}

		// Token: 0x06014A48 RID: 84552 RVA: 0x002FF312 File Offset: 0x002FD512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportResponse(RemoveTemporaryTeleportResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A49 RID: 84553 RVA: 0x002FF337 File Offset: 0x002FD537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTemporaryTeleportResponse Clone()
		{
			return new RemoveTemporaryTeleportResponse(this);
		}

		// Token: 0x170044A1 RID: 17569
		// (get) Token: 0x06014A4A RID: 84554 RVA: 0x002FF33F File Offset: 0x002FD53F
		// (set) Token: 0x06014A4B RID: 84555 RVA: 0x002FF347 File Offset: 0x002FD547
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

		// Token: 0x06014A4C RID: 84556 RVA: 0x002FF350 File Offset: 0x002FD550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveTemporaryTeleportResponse);
		}

		// Token: 0x06014A4D RID: 84557 RVA: 0x002FF35E File Offset: 0x002FD55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveTemporaryTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A4E RID: 84558 RVA: 0x002FF38C File Offset: 0x002FD58C
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

		// Token: 0x06014A4F RID: 84559 RVA: 0x002FF3D1 File Offset: 0x002FD5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A50 RID: 84560 RVA: 0x002FF3DE File Offset: 0x002FD5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A51 RID: 84561 RVA: 0x002FF3E7 File Offset: 0x002FD5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A52 RID: 84562 RVA: 0x002FF41C File Offset: 0x002FD61C
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

		// Token: 0x06014A53 RID: 84563 RVA: 0x002FF45A File Offset: 0x002FD65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveTemporaryTeleportResponse other)
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

		// Token: 0x06014A54 RID: 84564 RVA: 0x002FF48B File Offset: 0x002FD68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A55 RID: 84565 RVA: 0x002FF494 File Offset: 0x002FD694
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007CE3 RID: 31971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CE4 RID: 31972
		public const int ErrCodeFieldNumber = 6;

		// Token: 0x04007CE5 RID: 31973
		private ErrorCode errCode_;
	}
}
