using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A94 RID: 2708
	[NetMessage(EMessageId.MotorTaskOneKeyRewardResponse)]
	public sealed class MotorTaskOneKeyRewardResponse : IMessage<MotorTaskOneKeyRewardResponse>, IMessage, IEquatable<MotorTaskOneKeyRewardResponse>, IDeepCloneable<MotorTaskOneKeyRewardResponse>, IBufferMessage
	{
		// Token: 0x0600EC1B RID: 60443 RVA: 0x00227E1D File Offset: 0x0022601D
		[NullableContext(1)]
		public static MotorTaskOneKeyRewardResponse Create()
		{
			return new MotorTaskOneKeyRewardResponse();
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x0600EC1C RID: 60444 RVA: 0x00227E24 File Offset: 0x00226024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x0600EC1D RID: 60445 RVA: 0x00227E27 File Offset: 0x00226027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskOneKeyRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600EC1E RID: 60446 RVA: 0x00227E2E File Offset: 0x0022602E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardResponse()
		{
		}

		// Token: 0x0600EC1F RID: 60447 RVA: 0x00227E36 File Offset: 0x00226036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardResponse(MotorTaskOneKeyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC20 RID: 60448 RVA: 0x00227E5B File Offset: 0x0022605B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardResponse Clone()
		{
			return new MotorTaskOneKeyRewardResponse(this);
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x0600EC21 RID: 60449 RVA: 0x00227E63 File Offset: 0x00226063
		// (set) Token: 0x0600EC22 RID: 60450 RVA: 0x00227E6B File Offset: 0x0022606B
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

		// Token: 0x0600EC23 RID: 60451 RVA: 0x00227E74 File Offset: 0x00226074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskOneKeyRewardResponse);
		}

		// Token: 0x0600EC24 RID: 60452 RVA: 0x00227E82 File Offset: 0x00226082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskOneKeyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC25 RID: 60453 RVA: 0x00227EB0 File Offset: 0x002260B0
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

		// Token: 0x0600EC26 RID: 60454 RVA: 0x00227EF5 File Offset: 0x002260F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC27 RID: 60455 RVA: 0x00227F02 File Offset: 0x00226102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC28 RID: 60456 RVA: 0x00227F0B File Offset: 0x0022610B
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

		// Token: 0x0600EC29 RID: 60457 RVA: 0x00227F40 File Offset: 0x00226140
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

		// Token: 0x0600EC2A RID: 60458 RVA: 0x00227F7E File Offset: 0x0022617E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskOneKeyRewardResponse other)
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

		// Token: 0x0600EC2B RID: 60459 RVA: 0x00227FAF File Offset: 0x002261AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC2C RID: 60460 RVA: 0x00227FB8 File Offset: 0x002261B8
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

		// Token: 0x04006020 RID: 24608
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006021 RID: 24609
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04006022 RID: 24610
		private ErrorCode errorCode_;
	}
}
