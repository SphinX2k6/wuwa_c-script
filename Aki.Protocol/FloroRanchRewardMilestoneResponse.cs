using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DC RID: 1500
	[NetMessage(EMessageId.FloroRanchRewardMilestoneResponse)]
	public sealed class FloroRanchRewardMilestoneResponse : IMessage<FloroRanchRewardMilestoneResponse>, IMessage, IEquatable<FloroRanchRewardMilestoneResponse>, IDeepCloneable<FloroRanchRewardMilestoneResponse>, IBufferMessage
	{
		// Token: 0x06008AC7 RID: 35527 RVA: 0x0014F868 File Offset: 0x0014DA68
		[NullableContext(1)]
		public static FloroRanchRewardMilestoneResponse Create()
		{
			return new FloroRanchRewardMilestoneResponse();
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06008AC8 RID: 35528 RVA: 0x0014F86F File Offset: 0x0014DA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06008AC9 RID: 35529 RVA: 0x0014F872 File Offset: 0x0014DA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchRewardMilestoneResponse.Descriptor;
			}
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x0014F879 File Offset: 0x0014DA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneResponse()
		{
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x0014F881 File Offset: 0x0014DA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneResponse(FloroRanchRewardMilestoneResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x0014F8A6 File Offset: 0x0014DAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneResponse Clone()
		{
			return new FloroRanchRewardMilestoneResponse(this);
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06008ACD RID: 35533 RVA: 0x0014F8AE File Offset: 0x0014DAAE
		// (set) Token: 0x06008ACE RID: 35534 RVA: 0x0014F8B6 File Offset: 0x0014DAB6
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

		// Token: 0x06008ACF RID: 35535 RVA: 0x0014F8BF File Offset: 0x0014DABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchRewardMilestoneResponse);
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x0014F8CD File Offset: 0x0014DACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchRewardMilestoneResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008AD1 RID: 35537 RVA: 0x0014F8FC File Offset: 0x0014DAFC
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

		// Token: 0x06008AD2 RID: 35538 RVA: 0x0014F941 File Offset: 0x0014DB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x0014F94E File Offset: 0x0014DB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AD4 RID: 35540 RVA: 0x0014F957 File Offset: 0x0014DB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AD5 RID: 35541 RVA: 0x0014F98C File Offset: 0x0014DB8C
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

		// Token: 0x06008AD6 RID: 35542 RVA: 0x0014F9CA File Offset: 0x0014DBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchRewardMilestoneResponse other)
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

		// Token: 0x06008AD7 RID: 35543 RVA: 0x0014F9FB File Offset: 0x0014DBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AD8 RID: 35544 RVA: 0x0014FA04 File Offset: 0x0014DC04
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400441D RID: 17437
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400441E RID: 17438
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400441F RID: 17439
		private ErrorCode errorCode_;
	}
}
