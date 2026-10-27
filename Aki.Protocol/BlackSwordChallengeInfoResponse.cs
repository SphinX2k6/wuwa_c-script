using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AE RID: 430
	[NetMessage(EMessageId.BlackSwordChallengeInfoResponse)]
	public sealed class BlackSwordChallengeInfoResponse : IMessage<BlackSwordChallengeInfoResponse>, IMessage, IEquatable<BlackSwordChallengeInfoResponse>, IDeepCloneable<BlackSwordChallengeInfoResponse>, IBufferMessage
	{
		// Token: 0x06003233 RID: 12851 RVA: 0x0007F949 File Offset: 0x0007DB49
		[NullableContext(1)]
		public static BlackSwordChallengeInfoResponse Create()
		{
			return new BlackSwordChallengeInfoResponse();
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x0007F950 File Offset: 0x0007DB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06003235 RID: 12853 RVA: 0x0007F953 File Offset: 0x0007DB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackSwordChallengeInfoResponse.Descriptor;
			}
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x0007F95A File Offset: 0x0007DB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoResponse()
		{
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x0007F970 File Offset: 0x0007DB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoResponse(BlackSwordChallengeInfoResponse other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.errorCode_ = other.errorCode_;
			this.levelPlayUiInfoList_ = other.levelPlayUiInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x0007F9BD File Offset: 0x0007DBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoResponse Clone()
		{
			return new BlackSwordChallengeInfoResponse(this);
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06003239 RID: 12857 RVA: 0x0007F9C5 File Offset: 0x0007DBC5
		// (set) Token: 0x0600323A RID: 12858 RVA: 0x0007F9CD File Offset: 0x0007DBCD
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

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600323B RID: 12859 RVA: 0x0007F9D6 File Offset: 0x0007DBD6
		// (set) Token: 0x0600323C RID: 12860 RVA: 0x0007F9DE File Offset: 0x0007DBDE
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

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x0600323D RID: 12861 RVA: 0x0007F9E7 File Offset: 0x0007DBE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackSwordChallengeInfo> LevelPlayUiInfoList
		{
			get
			{
				return this.levelPlayUiInfoList_;
			}
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x0007F9EF File Offset: 0x0007DBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackSwordChallengeInfoResponse);
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x0007FA00 File Offset: 0x0007DC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackSwordChallengeInfoResponse other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.ErrorCode == other.ErrorCode && this.levelPlayUiInfoList_.Equals(other.levelPlayUiInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x0007FA60 File Offset: 0x0007DC60
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

		// Token: 0x06003241 RID: 12865 RVA: 0x0007FACC File Offset: 0x0007DCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x0007FAD9 File Offset: 0x0007DCD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x0007FAE4 File Offset: 0x0007DCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.levelPlayUiInfoList_.WriteTo(ref output, BlackSwordChallengeInfoResponse._repeated_levelPlayUiInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x0007FB50 File Offset: 0x0007DD50
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
			num += this.levelPlayUiInfoList_.CalculateSize(BlackSwordChallengeInfoResponse._repeated_levelPlayUiInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x0007FBBC File Offset: 0x0007DDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackSwordChallengeInfoResponse other)
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

		// Token: 0x06003246 RID: 12870 RVA: 0x0007FC1D File Offset: 0x0007DE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x0007FC28 File Offset: 0x0007DE28
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
					if (num != 40U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.levelPlayUiInfoList_.AddEntriesFrom(ref input, BlackSwordChallengeInfoResponse._repeated_levelPlayUiInfoList_codec);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002967 RID: 10599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002968 RID: 10600
		public const int ChallengeIdFieldNumber = 2;

		// Token: 0x04002969 RID: 10601
		private int challengeId_;

		// Token: 0x0400296A RID: 10602
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400296B RID: 10603
		private ErrorCode errorCode_;

		// Token: 0x0400296C RID: 10604
		public const int LevelPlayUiInfoListFieldNumber = 9;

		// Token: 0x0400296D RID: 10605
		private static readonly FieldCodec<BlackSwordChallengeInfo> _repeated_levelPlayUiInfoList_codec = FieldCodec.ForMessage<BlackSwordChallengeInfo>(74U, BlackSwordChallengeInfo.Parser);

		// Token: 0x0400296E RID: 10606
		private readonly RepeatedField<BlackSwordChallengeInfo> levelPlayUiInfoList_ = new RepeatedField<BlackSwordChallengeInfo>();
	}
}
