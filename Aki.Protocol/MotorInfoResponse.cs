using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A72 RID: 2674
	[NetMessage(EMessageId.MotorInfoResponse)]
	public sealed class MotorInfoResponse : IMessage<MotorInfoResponse>, IMessage, IEquatable<MotorInfoResponse>, IDeepCloneable<MotorInfoResponse>, IBufferMessage
	{
		// Token: 0x0600E925 RID: 59685 RVA: 0x00220C1E File Offset: 0x0021EE1E
		[NullableContext(1)]
		public static MotorInfoResponse Create()
		{
			return new MotorInfoResponse();
		}

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x0600E926 RID: 59686 RVA: 0x00220C25 File Offset: 0x0021EE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x0600E927 RID: 59687 RVA: 0x00220C28 File Offset: 0x0021EE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600E928 RID: 59688 RVA: 0x00220C2F File Offset: 0x0021EE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoResponse()
		{
		}

		// Token: 0x0600E929 RID: 59689 RVA: 0x00220C38 File Offset: 0x0021EE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoResponse(MotorInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motor_ = ((other.motor_ != null) ? other.motor_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E92A RID: 59690 RVA: 0x00220C84 File Offset: 0x0021EE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorInfoResponse Clone()
		{
			return new MotorInfoResponse(this);
		}

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x0600E92B RID: 59691 RVA: 0x00220C8C File Offset: 0x0021EE8C
		// (set) Token: 0x0600E92C RID: 59692 RVA: 0x00220C94 File Offset: 0x0021EE94
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

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x0600E92D RID: 59693 RVA: 0x00220C9D File Offset: 0x0021EE9D
		// (set) Token: 0x0600E92E RID: 59694 RVA: 0x00220CA5 File Offset: 0x0021EEA5
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

		// Token: 0x0600E92F RID: 59695 RVA: 0x00220CAE File Offset: 0x0021EEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorInfoResponse);
		}

		// Token: 0x0600E930 RID: 59696 RVA: 0x00220CBC File Offset: 0x0021EEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Motor, other.Motor) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E931 RID: 59697 RVA: 0x00220D0C File Offset: 0x0021EF0C
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

		// Token: 0x0600E932 RID: 59698 RVA: 0x00220D67 File Offset: 0x0021EF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E933 RID: 59699 RVA: 0x00220D74 File Offset: 0x0021EF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E934 RID: 59700 RVA: 0x00220D80 File Offset: 0x0021EF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.motor_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Motor);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E935 RID: 59701 RVA: 0x00220DDC File Offset: 0x0021EFDC
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

		// Token: 0x0600E936 RID: 59702 RVA: 0x00220E34 File Offset: 0x0021F034
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

		// Token: 0x0600E937 RID: 59703 RVA: 0x00220E9C File Offset: 0x0021F09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E938 RID: 59704 RVA: 0x00220EA8 File Offset: 0x0021F0A8
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
				if (num != 16U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005ED9 RID: 24281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EDA RID: 24282
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005EDB RID: 24283
		private ErrorCode errorCode_;

		// Token: 0x04005EDC RID: 24284
		public const int MotorFieldNumber = 14;

		// Token: 0x04005EDD RID: 24285
		private MotorPb motor_;
	}
}
