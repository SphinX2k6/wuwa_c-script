using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A43 RID: 2627
	[NetMessage(EMessageId.MotorFightRankListSelfDataResponse)]
	public sealed class MotorFightRankListSelfDataResponse : IMessage<MotorFightRankListSelfDataResponse>, IMessage, IEquatable<MotorFightRankListSelfDataResponse>, IDeepCloneable<MotorFightRankListSelfDataResponse>, IBufferMessage
	{
		// Token: 0x0600E591 RID: 58769 RVA: 0x00219031 File Offset: 0x00217231
		[NullableContext(1)]
		public static MotorFightRankListSelfDataResponse Create()
		{
			return new MotorFightRankListSelfDataResponse();
		}

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x0600E592 RID: 58770 RVA: 0x00219038 File Offset: 0x00217238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x0600E593 RID: 58771 RVA: 0x0021903B File Offset: 0x0021723B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRankListSelfDataResponse.Descriptor;
			}
		}

		// Token: 0x0600E594 RID: 58772 RVA: 0x00219042 File Offset: 0x00217242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataResponse()
		{
		}

		// Token: 0x0600E595 RID: 58773 RVA: 0x0021904C File Offset: 0x0021724C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataResponse(MotorFightRankListSelfDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.selfData_ = ((other.selfData_ != null) ? other.selfData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E596 RID: 58774 RVA: 0x00219098 File Offset: 0x00217298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataResponse Clone()
		{
			return new MotorFightRankListSelfDataResponse(this);
		}

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x0600E597 RID: 58775 RVA: 0x002190A0 File Offset: 0x002172A0
		// (set) Token: 0x0600E598 RID: 58776 RVA: 0x002190A8 File Offset: 0x002172A8
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

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x0600E599 RID: 58777 RVA: 0x002190B1 File Offset: 0x002172B1
		// (set) Token: 0x0600E59A RID: 58778 RVA: 0x002190B9 File Offset: 0x002172B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerRankingInfo SelfData
		{
			get
			{
				return this.selfData_;
			}
			set
			{
				this.selfData_ = value;
			}
		}

		// Token: 0x0600E59B RID: 58779 RVA: 0x002190C2 File Offset: 0x002172C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRankListSelfDataResponse);
		}

		// Token: 0x0600E59C RID: 58780 RVA: 0x002190D0 File Offset: 0x002172D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRankListSelfDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.SelfData, other.SelfData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E59D RID: 58781 RVA: 0x00219120 File Offset: 0x00217320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.selfData_ != null)
			{
				num ^= this.SelfData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E59E RID: 58782 RVA: 0x0021917B File Offset: 0x0021737B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E59F RID: 58783 RVA: 0x00219188 File Offset: 0x00217388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5A0 RID: 58784 RVA: 0x00219194 File Offset: 0x00217394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.selfData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.SelfData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5A1 RID: 58785 RVA: 0x002191F0 File Offset: 0x002173F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.selfData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelfData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E5A2 RID: 58786 RVA: 0x00219248 File Offset: 0x00217448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRankListSelfDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.selfData_ != null)
			{
				if (this.selfData_ == null)
				{
					this.SelfData = new MotorFightPlayerRankingInfo();
				}
				this.SelfData.MergeFrom(other.SelfData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E5A3 RID: 58787 RVA: 0x002192B0 File Offset: 0x002174B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5A4 RID: 58788 RVA: 0x002192BC File Offset: 0x002174BC
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
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.selfData_ == null)
						{
							this.SelfData = new MotorFightPlayerRankingInfo();
						}
						input.ReadMessage(this.SelfData);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005E18 RID: 24088
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E19 RID: 24089
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005E1A RID: 24090
		private ErrorCode errorCode_;

		// Token: 0x04005E1B RID: 24091
		public const int SelfDataFieldNumber = 9;

		// Token: 0x04005E1C RID: 24092
		private MotorFightPlayerRankingInfo selfData_;
	}
}
