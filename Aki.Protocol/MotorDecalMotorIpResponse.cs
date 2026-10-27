using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2C RID: 2604
	[NetMessage(EMessageId.MotorDecalMotorIpResponse)]
	public sealed class MotorDecalMotorIpResponse : IMessage<MotorDecalMotorIpResponse>, IMessage, IEquatable<MotorDecalMotorIpResponse>, IDeepCloneable<MotorDecalMotorIpResponse>, IBufferMessage
	{
		// Token: 0x0600E386 RID: 58246 RVA: 0x00214A68 File Offset: 0x00212C68
		[NullableContext(1)]
		public static MotorDecalMotorIpResponse Create()
		{
			return new MotorDecalMotorIpResponse();
		}

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x0600E387 RID: 58247 RVA: 0x00214A6F File Offset: 0x00212C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x0600E388 RID: 58248 RVA: 0x00214A72 File Offset: 0x00212C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalMotorIpResponse.Descriptor;
			}
		}

		// Token: 0x0600E389 RID: 58249 RVA: 0x00214A79 File Offset: 0x00212C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpResponse()
		{
		}

		// Token: 0x0600E38A RID: 58250 RVA: 0x00214A81 File Offset: 0x00212C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpResponse(MotorDecalMotorIpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorIp_ = other.motorIp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E38B RID: 58251 RVA: 0x00214AB2 File Offset: 0x00212CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpResponse Clone()
		{
			return new MotorDecalMotorIpResponse(this);
		}

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x0600E38C RID: 58252 RVA: 0x00214ABA File Offset: 0x00212CBA
		// (set) Token: 0x0600E38D RID: 58253 RVA: 0x00214AC2 File Offset: 0x00212CC2
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

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x0600E38E RID: 58254 RVA: 0x00214ACB File Offset: 0x00212CCB
		// (set) Token: 0x0600E38F RID: 58255 RVA: 0x00214AD3 File Offset: 0x00212CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorIp
		{
			get
			{
				return this.motorIp_;
			}
			set
			{
				this.motorIp_ = value;
			}
		}

		// Token: 0x0600E390 RID: 58256 RVA: 0x00214ADC File Offset: 0x00212CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalMotorIpResponse);
		}

		// Token: 0x0600E391 RID: 58257 RVA: 0x00214AEA File Offset: 0x00212CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalMotorIpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MotorIp == other.MotorIp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E392 RID: 58258 RVA: 0x00214B28 File Offset: 0x00212D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.MotorIp != 0)
			{
				num ^= this.MotorIp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E393 RID: 58259 RVA: 0x00214B86 File Offset: 0x00212D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E394 RID: 58260 RVA: 0x00214B93 File Offset: 0x00212D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E395 RID: 58261 RVA: 0x00214B9C File Offset: 0x00212D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorIp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MotorIp);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E396 RID: 58262 RVA: 0x00214BF8 File Offset: 0x00212DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.MotorIp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorIp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E397 RID: 58263 RVA: 0x00214C50 File Offset: 0x00212E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDecalMotorIpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.MotorIp != 0)
			{
				this.MotorIp = other.MotorIp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E398 RID: 58264 RVA: 0x00214CA0 File Offset: 0x00212EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E399 RID: 58265 RVA: 0x00214CAC File Offset: 0x00212EAC
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
					if (num != 72U)
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
					this.MotorIp = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005D36 RID: 23862
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D37 RID: 23863
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04005D38 RID: 23864
		private ErrorCode errorCode_;

		// Token: 0x04005D39 RID: 23865
		public const int MotorIpFieldNumber = 6;

		// Token: 0x04005D3A RID: 23866
		private int motorIp_;
	}
}
