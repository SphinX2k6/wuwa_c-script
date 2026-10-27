using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A75 RID: 2677
	[NetMessage(EMessageId.MotorLevelOneKeyRewardResponse)]
	public sealed class MotorLevelOneKeyRewardResponse : IMessage<MotorLevelOneKeyRewardResponse>, IMessage, IEquatable<MotorLevelOneKeyRewardResponse>, IDeepCloneable<MotorLevelOneKeyRewardResponse>, IBufferMessage
	{
		// Token: 0x0600E95F RID: 59743 RVA: 0x002213CE File Offset: 0x0021F5CE
		[NullableContext(1)]
		public static MotorLevelOneKeyRewardResponse Create()
		{
			return new MotorLevelOneKeyRewardResponse();
		}

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x0600E960 RID: 59744 RVA: 0x002213D5 File Offset: 0x0021F5D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x0600E961 RID: 59745 RVA: 0x002213D8 File Offset: 0x0021F5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorLevelOneKeyRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600E962 RID: 59746 RVA: 0x002213DF File Offset: 0x0021F5DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardResponse()
		{
		}

		// Token: 0x0600E963 RID: 59747 RVA: 0x002213E7 File Offset: 0x0021F5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardResponse(MotorLevelOneKeyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorRewardedLvMax_ = other.motorRewardedLvMax_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E964 RID: 59748 RVA: 0x00221418 File Offset: 0x0021F618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardResponse Clone()
		{
			return new MotorLevelOneKeyRewardResponse(this);
		}

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x0600E965 RID: 59749 RVA: 0x00221420 File Offset: 0x0021F620
		// (set) Token: 0x0600E966 RID: 59750 RVA: 0x00221428 File Offset: 0x0021F628
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

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x0600E967 RID: 59751 RVA: 0x00221431 File Offset: 0x0021F631
		// (set) Token: 0x0600E968 RID: 59752 RVA: 0x00221439 File Offset: 0x0021F639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorRewardedLvMax
		{
			get
			{
				return this.motorRewardedLvMax_;
			}
			set
			{
				this.motorRewardedLvMax_ = value;
			}
		}

		// Token: 0x0600E969 RID: 59753 RVA: 0x00221442 File Offset: 0x0021F642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorLevelOneKeyRewardResponse);
		}

		// Token: 0x0600E96A RID: 59754 RVA: 0x00221450 File Offset: 0x0021F650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorLevelOneKeyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MotorRewardedLvMax == other.MotorRewardedLvMax && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E96B RID: 59755 RVA: 0x00221490 File Offset: 0x0021F690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.MotorRewardedLvMax != 0)
			{
				num ^= this.MotorRewardedLvMax.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E96C RID: 59756 RVA: 0x002214EE File Offset: 0x0021F6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E96D RID: 59757 RVA: 0x002214FB File Offset: 0x0021F6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E96E RID: 59758 RVA: 0x00221504 File Offset: 0x0021F704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.MotorRewardedLvMax != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MotorRewardedLvMax);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E96F RID: 59759 RVA: 0x00221560 File Offset: 0x0021F760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.MotorRewardedLvMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorRewardedLvMax);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E970 RID: 59760 RVA: 0x002215B8 File Offset: 0x0021F7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorLevelOneKeyRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.MotorRewardedLvMax != 0)
			{
				this.MotorRewardedLvMax = other.MotorRewardedLvMax;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E971 RID: 59761 RVA: 0x00221608 File Offset: 0x0021F808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E972 RID: 59762 RVA: 0x00221614 File Offset: 0x0021F814
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MotorRewardedLvMax = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005EE6 RID: 24294
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EE7 RID: 24295
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005EE8 RID: 24296
		private ErrorCode errorCode_;

		// Token: 0x04005EE9 RID: 24297
		public const int MotorRewardedLvMaxFieldNumber = 14;

		// Token: 0x04005EEA RID: 24298
		private int motorRewardedLvMax_;
	}
}
