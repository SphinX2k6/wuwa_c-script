using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B0 RID: 432
	[NetMessage(EMessageId.BlackSwordChallengeMarkItemPanelInfoResponse)]
	public sealed class BlackSwordChallengeMarkItemPanelInfoResponse : IMessage<BlackSwordChallengeMarkItemPanelInfoResponse>, IMessage, IEquatable<BlackSwordChallengeMarkItemPanelInfoResponse>, IDeepCloneable<BlackSwordChallengeMarkItemPanelInfoResponse>, IBufferMessage
	{
		// Token: 0x0600325B RID: 12891 RVA: 0x0007FE85 File Offset: 0x0007E085
		[NullableContext(1)]
		public static BlackSwordChallengeMarkItemPanelInfoResponse Create()
		{
			return new BlackSwordChallengeMarkItemPanelInfoResponse();
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x0007FE8C File Offset: 0x0007E08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x0007FE8F File Offset: 0x0007E08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackSwordChallengeMarkItemPanelInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x0007FE96 File Offset: 0x0007E096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoResponse()
		{
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x0007FEAC File Offset: 0x0007E0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoResponse(BlackSwordChallengeMarkItemPanelInfoResponse other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.errorCode_ = other.errorCode_;
			this.levelPlayUiInfoList_ = other.levelPlayUiInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x0007FEF9 File Offset: 0x0007E0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoResponse Clone()
		{
			return new BlackSwordChallengeMarkItemPanelInfoResponse(this);
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x0007FF01 File Offset: 0x0007E101
		// (set) Token: 0x06003262 RID: 12898 RVA: 0x0007FF09 File Offset: 0x0007E109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x0007FF12 File Offset: 0x0007E112
		// (set) Token: 0x06003264 RID: 12900 RVA: 0x0007FF1A File Offset: 0x0007E11A
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

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06003265 RID: 12901 RVA: 0x0007FF23 File Offset: 0x0007E123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackSwordChallengeInfo> LevelPlayUiInfoList
		{
			get
			{
				return this.levelPlayUiInfoList_;
			}
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x0007FF2B File Offset: 0x0007E12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackSwordChallengeMarkItemPanelInfoResponse);
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x0007FF3C File Offset: 0x0007E13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackSwordChallengeMarkItemPanelInfoResponse other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.ErrorCode == other.ErrorCode && this.levelPlayUiInfoList_.Equals(other.levelPlayUiInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x0007FF9C File Offset: 0x0007E19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.levelPlayUiInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x00080008 File Offset: 0x0007E208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x00080015 File Offset: 0x0007E215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x00080020 File Offset: 0x0007E220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ChallengeId);
			}
			this.levelPlayUiInfoList_.WriteTo(ref output, BlackSwordChallengeMarkItemPanelInfoResponse._repeated_levelPlayUiInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x0008008C File Offset: 0x0007E28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.levelPlayUiInfoList_.CalculateSize(BlackSwordChallengeMarkItemPanelInfoResponse._repeated_levelPlayUiInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x000800F8 File Offset: 0x0007E2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackSwordChallengeMarkItemPanelInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.levelPlayUiInfoList_.Add(other.levelPlayUiInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x00080159 File Offset: 0x0007E359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x00080164 File Offset: 0x0007E364
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
				if (num != 40U)
				{
					if (num != 80U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.levelPlayUiInfoList_.AddEntriesFrom(ref input, BlackSwordChallengeMarkItemPanelInfoResponse._repeated_levelPlayUiInfoList_codec);
						}
					}
					else
					{
						this.ChallengeId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002972 RID: 10610
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002973 RID: 10611
		public const int ChallengeIdFieldNumber = 10;

		// Token: 0x04002974 RID: 10612
		private int challengeId_;

		// Token: 0x04002975 RID: 10613
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04002976 RID: 10614
		private ErrorCode errorCode_;

		// Token: 0x04002977 RID: 10615
		public const int LevelPlayUiInfoListFieldNumber = 11;

		// Token: 0x04002978 RID: 10616
		private static readonly FieldCodec<BlackSwordChallengeInfo> _repeated_levelPlayUiInfoList_codec = FieldCodec.ForMessage<BlackSwordChallengeInfo>(90U, BlackSwordChallengeInfo.Parser);

		// Token: 0x04002979 RID: 10617
		private readonly RepeatedField<BlackSwordChallengeInfo> levelPlayUiInfoList_ = new RepeatedField<BlackSwordChallengeInfo>();
	}
}
