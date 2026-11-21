using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A21 RID: 2593
	[NetMessage(EMessageId.MotorDevelopTaskRewardResponse)]
	public sealed class MotorDevelopTaskRewardResponse : IMessage<MotorDevelopTaskRewardResponse>, IMessage, IEquatable<MotorDevelopTaskRewardResponse>, IDeepCloneable<MotorDevelopTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600E2DC RID: 58076 RVA: 0x00213585 File Offset: 0x00211785
		[NullableContext(1)]
		public static MotorDevelopTaskRewardResponse Create()
		{
			return new MotorDevelopTaskRewardResponse();
		}

		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x0600E2DD RID: 58077 RVA: 0x0021358C File Offset: 0x0021178C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x0600E2DE RID: 58078 RVA: 0x0021358F File Offset: 0x0021178F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDevelopTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600E2DF RID: 58079 RVA: 0x00213596 File Offset: 0x00211796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardResponse()
		{
		}

		// Token: 0x0600E2E0 RID: 58080 RVA: 0x0021359E File Offset: 0x0021179E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardResponse(MotorDevelopTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2E1 RID: 58081 RVA: 0x002135C3 File Offset: 0x002117C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardResponse Clone()
		{
			return new MotorDevelopTaskRewardResponse(this);
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x0600E2E2 RID: 58082 RVA: 0x002135CB File Offset: 0x002117CB
		// (set) Token: 0x0600E2E3 RID: 58083 RVA: 0x002135D3 File Offset: 0x002117D3
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

		// Token: 0x0600E2E4 RID: 58084 RVA: 0x002135DC File Offset: 0x002117DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDevelopTaskRewardResponse);
		}

		// Token: 0x0600E2E5 RID: 58085 RVA: 0x002135EA File Offset: 0x002117EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDevelopTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2E6 RID: 58086 RVA: 0x00213618 File Offset: 0x00211818
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

		// Token: 0x0600E2E7 RID: 58087 RVA: 0x0021365D File Offset: 0x0021185D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E2E8 RID: 58088 RVA: 0x0021366A File Offset: 0x0021186A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2E9 RID: 58089 RVA: 0x00213673 File Offset: 0x00211873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2EA RID: 58090 RVA: 0x002136A8 File Offset: 0x002118A8
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

		// Token: 0x0600E2EB RID: 58091 RVA: 0x002136E6 File Offset: 0x002118E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDevelopTaskRewardResponse other)
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

		// Token: 0x0600E2EC RID: 58092 RVA: 0x00213717 File Offset: 0x00211917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2ED RID: 58093 RVA: 0x00213720 File Offset: 0x00211920
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005D58 RID: 23896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D59 RID: 23897
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04005D5A RID: 23898
		private ErrorCode errorCode_;
	}
}
