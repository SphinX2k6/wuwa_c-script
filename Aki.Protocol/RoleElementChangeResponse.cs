using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106B RID: 4203
	[NetMessage(EMessageId.RoleElementChangeResponse)]
	public sealed class RoleElementChangeResponse : IMessage<RoleElementChangeResponse>, IMessage, IEquatable<RoleElementChangeResponse>, IDeepCloneable<RoleElementChangeResponse>, IBufferMessage
	{
		// Token: 0x0601675E RID: 91998 RVA: 0x00343E59 File Offset: 0x00342059
		[NullableContext(1)]
		public static RoleElementChangeResponse Create()
		{
			return new RoleElementChangeResponse();
		}

		// Token: 0x17004B31 RID: 19249
		// (get) Token: 0x0601675F RID: 91999 RVA: 0x00343E60 File Offset: 0x00342060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B32 RID: 19250
		// (get) Token: 0x06016760 RID: 92000 RVA: 0x00343E63 File Offset: 0x00342063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleElementChangeResponse.Descriptor;
			}
		}

		// Token: 0x06016761 RID: 92001 RVA: 0x00343E6A File Offset: 0x0034206A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeResponse()
		{
		}

		// Token: 0x06016762 RID: 92002 RVA: 0x00343E72 File Offset: 0x00342072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeResponse(RoleElementChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016763 RID: 92003 RVA: 0x00343E97 File Offset: 0x00342097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeResponse Clone()
		{
			return new RoleElementChangeResponse(this);
		}

		// Token: 0x17004B33 RID: 19251
		// (get) Token: 0x06016764 RID: 92004 RVA: 0x00343E9F File Offset: 0x0034209F
		// (set) Token: 0x06016765 RID: 92005 RVA: 0x00343EA7 File Offset: 0x003420A7
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

		// Token: 0x06016766 RID: 92006 RVA: 0x00343EB0 File Offset: 0x003420B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleElementChangeResponse);
		}

		// Token: 0x06016767 RID: 92007 RVA: 0x00343EBE File Offset: 0x003420BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleElementChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016768 RID: 92008 RVA: 0x00343EEC File Offset: 0x003420EC
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

		// Token: 0x06016769 RID: 92009 RVA: 0x00343F31 File Offset: 0x00342131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601676A RID: 92010 RVA: 0x00343F3E File Offset: 0x0034213E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601676B RID: 92011 RVA: 0x00343F47 File Offset: 0x00342147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601676C RID: 92012 RVA: 0x00343F78 File Offset: 0x00342178
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

		// Token: 0x0601676D RID: 92013 RVA: 0x00343FB6 File Offset: 0x003421B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleElementChangeResponse other)
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

		// Token: 0x0601676E RID: 92014 RVA: 0x00343FE7 File Offset: 0x003421E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601676F RID: 92015 RVA: 0x00343FF0 File Offset: 0x003421F0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400865A RID: 34394
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400865B RID: 34395
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400865C RID: 34396
		private ErrorCode errorCode_;
	}
}
