using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A54 RID: 2644
	[NetMessage(EMessageId.MotorFightRankListSelfDataResponse)]
	public sealed class MotorFightRankListSelfDataResponse : IMessage<MotorFightRankListSelfDataResponse>, IMessage, IEquatable<MotorFightRankListSelfDataResponse>, IDeepCloneable<MotorFightRankListSelfDataResponse>, IBufferMessage
	{
		// Token: 0x0600E6AB RID: 59051 RVA: 0x0021B225 File Offset: 0x00219425
		[NullableContext(1)]
		public static MotorFightRankListSelfDataResponse Create()
		{
			return new MotorFightRankListSelfDataResponse();
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x0600E6AC RID: 59052 RVA: 0x0021B22C File Offset: 0x0021942C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x0600E6AD RID: 59053 RVA: 0x0021B22F File Offset: 0x0021942F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRankListSelfDataResponse.Descriptor;
			}
		}

		// Token: 0x0600E6AE RID: 59054 RVA: 0x0021B236 File Offset: 0x00219436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataResponse()
		{
		}

		// Token: 0x0600E6AF RID: 59055 RVA: 0x0021B240 File Offset: 0x00219440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataResponse(MotorFightRankListSelfDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.selfData_ = ((other.selfData_ != null) ? other.selfData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E6B0 RID: 59056 RVA: 0x0021B28C File Offset: 0x0021948C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataResponse Clone()
		{
			return new MotorFightRankListSelfDataResponse(this);
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x0600E6B1 RID: 59057 RVA: 0x0021B294 File Offset: 0x00219494
		// (set) Token: 0x0600E6B2 RID: 59058 RVA: 0x0021B29C File Offset: 0x0021949C
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

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x0600E6B3 RID: 59059 RVA: 0x0021B2A5 File Offset: 0x002194A5
		// (set) Token: 0x0600E6B4 RID: 59060 RVA: 0x0021B2AD File Offset: 0x002194AD
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

		// Token: 0x0600E6B5 RID: 59061 RVA: 0x0021B2B6 File Offset: 0x002194B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRankListSelfDataResponse);
		}

		// Token: 0x0600E6B6 RID: 59062 RVA: 0x0021B2C4 File Offset: 0x002194C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRankListSelfDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.SelfData, other.SelfData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6B7 RID: 59063 RVA: 0x0021B314 File Offset: 0x00219514
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

		// Token: 0x0600E6B8 RID: 59064 RVA: 0x0021B36F File Offset: 0x0021956F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E6B9 RID: 59065 RVA: 0x0021B37C File Offset: 0x0021957C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6BA RID: 59066 RVA: 0x0021B388 File Offset: 0x00219588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.selfData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SelfData);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E6BB RID: 59067 RVA: 0x0021B3E4 File Offset: 0x002195E4
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

		// Token: 0x0600E6BC RID: 59068 RVA: 0x0021B43C File Offset: 0x0021963C
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

		// Token: 0x0600E6BD RID: 59069 RVA: 0x0021B4A4 File Offset: 0x002196A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6BE RID: 59070 RVA: 0x0021B4B0 File Offset: 0x002196B0
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
				if (num != 18U)
				{
					if (num != 96U)
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
					if (this.selfData_ == null)
					{
						this.SelfData = new MotorFightPlayerRankingInfo();
					}
					input.ReadMessage(this.SelfData);
				}
			}
		}

		// Token: 0x04005E0F RID: 24079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E10 RID: 24080
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04005E11 RID: 24081
		private ErrorCode errorCode_;

		// Token: 0x04005E12 RID: 24082
		public const int SelfDataFieldNumber = 2;

		// Token: 0x04005E13 RID: 24083
		private MotorFightPlayerRankingInfo selfData_;
	}
}
