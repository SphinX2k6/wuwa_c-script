using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A64 RID: 2660
	[NetMessage(EMessageId.MotorLevelOneKeyRewardResponse)]
	public sealed class MotorLevelOneKeyRewardResponse : IMessage<MotorLevelOneKeyRewardResponse>, IMessage, IEquatable<MotorLevelOneKeyRewardResponse>, IDeepCloneable<MotorLevelOneKeyRewardResponse>, IBufferMessage
	{
		// Token: 0x0600E845 RID: 59461 RVA: 0x0021F1DA File Offset: 0x0021D3DA
		[NullableContext(1)]
		public static MotorLevelOneKeyRewardResponse Create()
		{
			return new MotorLevelOneKeyRewardResponse();
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x0600E846 RID: 59462 RVA: 0x0021F1E1 File Offset: 0x0021D3E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x0600E847 RID: 59463 RVA: 0x0021F1E4 File Offset: 0x0021D3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorLevelOneKeyRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600E848 RID: 59464 RVA: 0x0021F1EB File Offset: 0x0021D3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardResponse()
		{
		}

		// Token: 0x0600E849 RID: 59465 RVA: 0x0021F1F3 File Offset: 0x0021D3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardResponse(MotorLevelOneKeyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorRewardedLvMax_ = other.motorRewardedLvMax_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E84A RID: 59466 RVA: 0x0021F224 File Offset: 0x0021D424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLevelOneKeyRewardResponse Clone()
		{
			return new MotorLevelOneKeyRewardResponse(this);
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x0600E84B RID: 59467 RVA: 0x0021F22C File Offset: 0x0021D42C
		// (set) Token: 0x0600E84C RID: 59468 RVA: 0x0021F234 File Offset: 0x0021D434
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

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x0600E84D RID: 59469 RVA: 0x0021F23D File Offset: 0x0021D43D
		// (set) Token: 0x0600E84E RID: 59470 RVA: 0x0021F245 File Offset: 0x0021D445
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

		// Token: 0x0600E84F RID: 59471 RVA: 0x0021F24E File Offset: 0x0021D44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorLevelOneKeyRewardResponse);
		}

		// Token: 0x0600E850 RID: 59472 RVA: 0x0021F25C File Offset: 0x0021D45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorLevelOneKeyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MotorRewardedLvMax == other.MotorRewardedLvMax && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E851 RID: 59473 RVA: 0x0021F29C File Offset: 0x0021D49C
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

		// Token: 0x0600E852 RID: 59474 RVA: 0x0021F2FA File Offset: 0x0021D4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E853 RID: 59475 RVA: 0x0021F307 File Offset: 0x0021D507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E854 RID: 59476 RVA: 0x0021F310 File Offset: 0x0021D510
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
				output.WriteRawTag(96);
				output.WriteInt32(this.MotorRewardedLvMax);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E855 RID: 59477 RVA: 0x0021F36C File Offset: 0x0021D56C
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

		// Token: 0x0600E856 RID: 59478 RVA: 0x0021F3C4 File Offset: 0x0021D5C4
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

		// Token: 0x0600E857 RID: 59479 RVA: 0x0021F414 File Offset: 0x0021D614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E858 RID: 59480 RVA: 0x0021F420 File Offset: 0x0021D620
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
					if (num != 96U)
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

		// Token: 0x04005EEF RID: 24303
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EF0 RID: 24304
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005EF1 RID: 24305
		private ErrorCode errorCode_;

		// Token: 0x04005EF2 RID: 24306
		public const int MotorRewardedLvMaxFieldNumber = 12;

		// Token: 0x04005EF3 RID: 24307
		private int motorRewardedLvMax_;
	}
}
