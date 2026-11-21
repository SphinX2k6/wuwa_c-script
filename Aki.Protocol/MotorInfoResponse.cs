using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A61 RID: 2657
	[NetMessage(EMessageId.MotorInfoResponse)]
	public sealed class MotorInfoResponse : IMessage<MotorInfoResponse>, IMessage, IEquatable<MotorInfoResponse>, IDeepCloneable<MotorInfoResponse>, IBufferMessage
	{
		// Token: 0x0600E80B RID: 59403 RVA: 0x0021EA2A File Offset: 0x0021CC2A
		[NullableContext(1)]
		public static MotorInfoResponse Create()
		{
			return new MotorInfoResponse();
		}

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x0600E80C RID: 59404 RVA: 0x0021EA31 File Offset: 0x0021CC31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x0600E80D RID: 59405 RVA: 0x0021EA34 File Offset: 0x0021CC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600E80E RID: 59406 RVA: 0x0021EA3B File Offset: 0x0021CC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoResponse()
		{
		}

		// Token: 0x0600E80F RID: 59407 RVA: 0x0021EA44 File Offset: 0x0021CC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoResponse(MotorInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motor_ = ((other.motor_ != null) ? other.motor_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E810 RID: 59408 RVA: 0x0021EA90 File Offset: 0x0021CC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoResponse Clone()
		{
			return new MotorInfoResponse(this);
		}

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x0600E811 RID: 59409 RVA: 0x0021EA98 File Offset: 0x0021CC98
		// (set) Token: 0x0600E812 RID: 59410 RVA: 0x0021EAA0 File Offset: 0x0021CCA0
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

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x0600E813 RID: 59411 RVA: 0x0021EAA9 File Offset: 0x0021CCA9
		// (set) Token: 0x0600E814 RID: 59412 RVA: 0x0021EAB1 File Offset: 0x0021CCB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPb Motor
		{
			get
			{
				return this.motor_;
			}
			set
			{
				this.motor_ = value;
			}
		}

		// Token: 0x0600E815 RID: 59413 RVA: 0x0021EABA File Offset: 0x0021CCBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorInfoResponse);
		}

		// Token: 0x0600E816 RID: 59414 RVA: 0x0021EAC8 File Offset: 0x0021CCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Motor, other.Motor) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E817 RID: 59415 RVA: 0x0021EB18 File Offset: 0x0021CD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.motor_ != null)
			{
				num ^= this.Motor.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E818 RID: 59416 RVA: 0x0021EB73 File Offset: 0x0021CD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E819 RID: 59417 RVA: 0x0021EB80 File Offset: 0x0021CD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E81A RID: 59418 RVA: 0x0021EB8C File Offset: 0x0021CD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motor_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Motor);
			}
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

		// Token: 0x0600E81B RID: 59419 RVA: 0x0021EBE8 File Offset: 0x0021CDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.motor_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motor);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E81C RID: 59420 RVA: 0x0021EC40 File Offset: 0x0021CE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.motor_ != null)
			{
				if (this.motor_ == null)
				{
					this.Motor = new MotorPb();
				}
				this.Motor.MergeFrom(other.Motor);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E81D RID: 59421 RVA: 0x0021ECA8 File Offset: 0x0021CEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E81E RID: 59422 RVA: 0x0021ECB4 File Offset: 0x0021CEB4
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
				if (num != 10U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.motor_ == null)
					{
						this.Motor = new MotorPb();
					}
					input.ReadMessage(this.Motor);
				}
			}
		}

		// Token: 0x04005EE2 RID: 24290
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EE3 RID: 24291
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04005EE4 RID: 24292
		private ErrorCode errorCode_;

		// Token: 0x04005EE5 RID: 24293
		public const int MotorFieldNumber = 1;

		// Token: 0x04005EE6 RID: 24294
		private MotorPb motor_;
	}
}
