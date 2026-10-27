using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB6 RID: 2742
	[NetMessage(EMessageId.MotorUseSkinResponse)]
	public sealed class MotorUseSkinResponse : IMessage<MotorUseSkinResponse>, IMessage, IEquatable<MotorUseSkinResponse>, IDeepCloneable<MotorUseSkinResponse>, IBufferMessage
	{
		// Token: 0x0600EE91 RID: 61073 RVA: 0x0022CDDD File Offset: 0x0022AFDD
		[NullableContext(1)]
		public static MotorUseSkinResponse Create()
		{
			return new MotorUseSkinResponse();
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x0600EE92 RID: 61074 RVA: 0x0022CDE4 File Offset: 0x0022AFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x0600EE93 RID: 61075 RVA: 0x0022CDE7 File Offset: 0x0022AFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorUseSkinResponse.Descriptor;
			}
		}

		// Token: 0x0600EE94 RID: 61076 RVA: 0x0022CDEE File Offset: 0x0022AFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinResponse()
		{
		}

		// Token: 0x0600EE95 RID: 61077 RVA: 0x0022CDF6 File Offset: 0x0022AFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinResponse(MotorUseSkinResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE96 RID: 61078 RVA: 0x0022CE1B File Offset: 0x0022B01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinResponse Clone()
		{
			return new MotorUseSkinResponse(this);
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x0600EE97 RID: 61079 RVA: 0x0022CE23 File Offset: 0x0022B023
		// (set) Token: 0x0600EE98 RID: 61080 RVA: 0x0022CE2B File Offset: 0x0022B02B
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

		// Token: 0x0600EE99 RID: 61081 RVA: 0x0022CE34 File Offset: 0x0022B034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorUseSkinResponse);
		}

		// Token: 0x0600EE9A RID: 61082 RVA: 0x0022CE42 File Offset: 0x0022B042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorUseSkinResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE9B RID: 61083 RVA: 0x0022CE70 File Offset: 0x0022B070
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

		// Token: 0x0600EE9C RID: 61084 RVA: 0x0022CEB5 File Offset: 0x0022B0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE9D RID: 61085 RVA: 0x0022CEC2 File Offset: 0x0022B0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE9E RID: 61086 RVA: 0x0022CECB File Offset: 0x0022B0CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE9F RID: 61087 RVA: 0x0022CF00 File Offset: 0x0022B100
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

		// Token: 0x0600EEA0 RID: 61088 RVA: 0x0022CF3E File Offset: 0x0022B13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorUseSkinResponse other)
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

		// Token: 0x0600EEA1 RID: 61089 RVA: 0x0022CF6F File Offset: 0x0022B16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EEA2 RID: 61090 RVA: 0x0022CF78 File Offset: 0x0022B178
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006076 RID: 24694
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006077 RID: 24695
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04006078 RID: 24696
		private ErrorCode errorCode_;
	}
}
