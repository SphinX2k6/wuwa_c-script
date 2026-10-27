using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA5 RID: 2725
	[NetMessage(EMessageId.MotorTaskOneKeyRewardResponse)]
	public sealed class MotorTaskOneKeyRewardResponse : IMessage<MotorTaskOneKeyRewardResponse>, IMessage, IEquatable<MotorTaskOneKeyRewardResponse>, IDeepCloneable<MotorTaskOneKeyRewardResponse>, IBufferMessage
	{
		// Token: 0x0600ED35 RID: 60725 RVA: 0x0022A019 File Offset: 0x00228219
		[NullableContext(1)]
		public static MotorTaskOneKeyRewardResponse Create()
		{
			return new MotorTaskOneKeyRewardResponse();
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x0600ED36 RID: 60726 RVA: 0x0022A020 File Offset: 0x00228220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x0600ED37 RID: 60727 RVA: 0x0022A023 File Offset: 0x00228223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskOneKeyRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600ED38 RID: 60728 RVA: 0x0022A02A File Offset: 0x0022822A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardResponse()
		{
		}

		// Token: 0x0600ED39 RID: 60729 RVA: 0x0022A032 File Offset: 0x00228232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardResponse(MotorTaskOneKeyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED3A RID: 60730 RVA: 0x0022A057 File Offset: 0x00228257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardResponse Clone()
		{
			return new MotorTaskOneKeyRewardResponse(this);
		}

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x0600ED3B RID: 60731 RVA: 0x0022A05F File Offset: 0x0022825F
		// (set) Token: 0x0600ED3C RID: 60732 RVA: 0x0022A067 File Offset: 0x00228267
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

		// Token: 0x0600ED3D RID: 60733 RVA: 0x0022A070 File Offset: 0x00228270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskOneKeyRewardResponse);
		}

		// Token: 0x0600ED3E RID: 60734 RVA: 0x0022A07E File Offset: 0x0022827E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskOneKeyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED3F RID: 60735 RVA: 0x0022A0AC File Offset: 0x002282AC
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

		// Token: 0x0600ED40 RID: 60736 RVA: 0x0022A0F1 File Offset: 0x002282F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED41 RID: 60737 RVA: 0x0022A0FE File Offset: 0x002282FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED42 RID: 60738 RVA: 0x0022A107 File Offset: 0x00228307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED43 RID: 60739 RVA: 0x0022A13C File Offset: 0x0022833C
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

		// Token: 0x0600ED44 RID: 60740 RVA: 0x0022A17A File Offset: 0x0022837A
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

		// Token: 0x0600ED45 RID: 60741 RVA: 0x0022A1AB File Offset: 0x002283AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED46 RID: 60742 RVA: 0x0022A1B4 File Offset: 0x002283B4
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006017 RID: 24599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006018 RID: 24600
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04006019 RID: 24601
		private ErrorCode errorCode_;
	}
}
