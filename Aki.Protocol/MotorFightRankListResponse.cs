using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A41 RID: 2625
	[NetMessage(EMessageId.MotorFightRankListResponse)]
	public sealed class MotorFightRankListResponse : IMessage<MotorFightRankListResponse>, IMessage, IEquatable<MotorFightRankListResponse>, IDeepCloneable<MotorFightRankListResponse>, IBufferMessage
	{
		// Token: 0x0600E569 RID: 58729 RVA: 0x00218AB9 File Offset: 0x00216CB9
		[NullableContext(1)]
		public static MotorFightRankListResponse Create()
		{
			return new MotorFightRankListResponse();
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x0600E56A RID: 58730 RVA: 0x00218AC0 File Offset: 0x00216CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x0600E56B RID: 58731 RVA: 0x00218AC3 File Offset: 0x00216CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRankListResponse.Descriptor;
			}
		}

		// Token: 0x0600E56C RID: 58732 RVA: 0x00218ACA File Offset: 0x00216CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListResponse()
		{
		}

		// Token: 0x0600E56D RID: 58733 RVA: 0x00218AE0 File Offset: 0x00216CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListResponse(MotorFightRankListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.friendData_ = other.friendData_.Clone();
			this.selfData_ = ((other.selfData_ != null) ? other.selfData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E56E RID: 58734 RVA: 0x00218B3D File Offset: 0x00216D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListResponse Clone()
		{
			return new MotorFightRankListResponse(this);
		}

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x0600E56F RID: 58735 RVA: 0x00218B45 File Offset: 0x00216D45
		// (set) Token: 0x0600E570 RID: 58736 RVA: 0x00218B4D File Offset: 0x00216D4D
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

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x0600E571 RID: 58737 RVA: 0x00218B56 File Offset: 0x00216D56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightPlayerRankingInfo> FriendData
		{
			get
			{
				return this.friendData_;
			}
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x0600E572 RID: 58738 RVA: 0x00218B5E File Offset: 0x00216D5E
		// (set) Token: 0x0600E573 RID: 58739 RVA: 0x00218B66 File Offset: 0x00216D66
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

		// Token: 0x0600E574 RID: 58740 RVA: 0x00218B6F File Offset: 0x00216D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRankListResponse);
		}

		// Token: 0x0600E575 RID: 58741 RVA: 0x00218B80 File Offset: 0x00216D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRankListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.friendData_.Equals(other.friendData_) && object.Equals(this.SelfData, other.SelfData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E576 RID: 58742 RVA: 0x00218BE4 File Offset: 0x00216DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.friendData_.GetHashCode();
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

		// Token: 0x0600E577 RID: 58743 RVA: 0x00218C4D File Offset: 0x00216E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E578 RID: 58744 RVA: 0x00218C5A File Offset: 0x00216E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E579 RID: 58745 RVA: 0x00218C64 File Offset: 0x00216E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.friendData_.WriteTo(ref output, MotorFightRankListResponse._repeated_friendData_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.selfData_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.SelfData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E57A RID: 58746 RVA: 0x00218CD0 File Offset: 0x00216ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.friendData_.CalculateSize(MotorFightRankListResponse._repeated_friendData_codec);
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

		// Token: 0x0600E57B RID: 58747 RVA: 0x00218D3C File Offset: 0x00216F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRankListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.friendData_.Add(other.friendData_);
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

		// Token: 0x0600E57C RID: 58748 RVA: 0x00218DB5 File Offset: 0x00216FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E57D RID: 58749 RVA: 0x00218DC0 File Offset: 0x00216FC0
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
					if (num != 104U)
					{
						if (num != 114U)
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
				else
				{
					this.friendData_.AddEntriesFrom(ref input, MotorFightRankListResponse._repeated_friendData_codec);
				}
			}
		}

		// Token: 0x04005E0D RID: 24077
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E0E RID: 24078
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04005E0F RID: 24079
		private ErrorCode errorCode_;

		// Token: 0x04005E10 RID: 24080
		public const int FriendDataFieldNumber = 2;

		// Token: 0x04005E11 RID: 24081
		private static readonly FieldCodec<MotorFightPlayerRankingInfo> _repeated_friendData_codec = FieldCodec.ForMessage<MotorFightPlayerRankingInfo>(18U, MotorFightPlayerRankingInfo.Parser);

		// Token: 0x04005E12 RID: 24082
		private readonly RepeatedField<MotorFightPlayerRankingInfo> friendData_ = new RepeatedField<MotorFightPlayerRankingInfo>();

		// Token: 0x04005E13 RID: 24083
		public const int SelfDataFieldNumber = 14;

		// Token: 0x04005E14 RID: 24084
		private MotorFightPlayerRankingInfo selfData_;
	}
}
