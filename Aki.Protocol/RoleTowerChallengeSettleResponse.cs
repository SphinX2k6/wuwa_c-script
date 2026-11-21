using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C1 RID: 4289
	[NetMessage(EMessageId.RoleTowerChallengeSettleResponse)]
	public sealed class RoleTowerChallengeSettleResponse : IMessage<RoleTowerChallengeSettleResponse>, IMessage, IEquatable<RoleTowerChallengeSettleResponse>, IDeepCloneable<RoleTowerChallengeSettleResponse>, IBufferMessage
	{
		// Token: 0x06016ED5 RID: 93909 RVA: 0x00355A15 File Offset: 0x00353C15
		[NullableContext(1)]
		public static RoleTowerChallengeSettleResponse Create()
		{
			return new RoleTowerChallengeSettleResponse();
		}

		// Token: 0x17004CE6 RID: 19686
		// (get) Token: 0x06016ED6 RID: 93910 RVA: 0x00355A1C File Offset: 0x00353C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CE7 RID: 19687
		// (get) Token: 0x06016ED7 RID: 93911 RVA: 0x00355A1F File Offset: 0x00353C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerChallengeSettleResponse.Descriptor;
			}
		}

		// Token: 0x06016ED8 RID: 93912 RVA: 0x00355A26 File Offset: 0x00353C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleResponse()
		{
		}

		// Token: 0x06016ED9 RID: 93913 RVA: 0x00355A30 File Offset: 0x00353C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleResponse(RoleTowerChallengeSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.challengeSettleInfo_ = ((other.challengeSettleInfo_ != null) ? other.challengeSettleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016EDA RID: 93914 RVA: 0x00355A7C File Offset: 0x00353C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleResponse Clone()
		{
			return new RoleTowerChallengeSettleResponse(this);
		}

		// Token: 0x17004CE8 RID: 19688
		// (get) Token: 0x06016EDB RID: 93915 RVA: 0x00355A84 File Offset: 0x00353C84
		// (set) Token: 0x06016EDC RID: 93916 RVA: 0x00355A8C File Offset: 0x00353C8C
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

		// Token: 0x17004CE9 RID: 19689
		// (get) Token: 0x06016EDD RID: 93917 RVA: 0x00355A95 File Offset: 0x00353C95
		// (set) Token: 0x06016EDE RID: 93918 RVA: 0x00355A9D File Offset: 0x00353C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleInfo ChallengeSettleInfo
		{
			get
			{
				return this.challengeSettleInfo_;
			}
			set
			{
				this.challengeSettleInfo_ = value;
			}
		}

		// Token: 0x06016EDF RID: 93919 RVA: 0x00355AA6 File Offset: 0x00353CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerChallengeSettleResponse);
		}

		// Token: 0x06016EE0 RID: 93920 RVA: 0x00355AB4 File Offset: 0x00353CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerChallengeSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.ChallengeSettleInfo, other.ChallengeSettleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016EE1 RID: 93921 RVA: 0x00355B04 File Offset: 0x00353D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.challengeSettleInfo_ != null)
			{
				num ^= this.ChallengeSettleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016EE2 RID: 93922 RVA: 0x00355B5F File Offset: 0x00353D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016EE3 RID: 93923 RVA: 0x00355B6C File Offset: 0x00353D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016EE4 RID: 93924 RVA: 0x00355B78 File Offset: 0x00353D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.challengeSettleInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ChallengeSettleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016EE5 RID: 93925 RVA: 0x00355BD4 File Offset: 0x00353DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.challengeSettleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChallengeSettleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016EE6 RID: 93926 RVA: 0x00355C2C File Offset: 0x00353E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerChallengeSettleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.challengeSettleInfo_ != null)
			{
				if (this.challengeSettleInfo_ == null)
				{
					this.ChallengeSettleInfo = new RoleTowerChallengeSettleInfo();
				}
				this.ChallengeSettleInfo.MergeFrom(other.ChallengeSettleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016EE7 RID: 93927 RVA: 0x00355C94 File Offset: 0x00353E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016EE8 RID: 93928 RVA: 0x00355CA0 File Offset: 0x00353EA0
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.challengeSettleInfo_ == null)
						{
							this.ChallengeSettleInfo = new RoleTowerChallengeSettleInfo();
						}
						input.ReadMessage(this.ChallengeSettleInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008944 RID: 35140
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008945 RID: 35141
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04008946 RID: 35142
		private ErrorCode errorCode_;

		// Token: 0x04008947 RID: 35143
		public const int ChallengeSettleInfoFieldNumber = 10;

		// Token: 0x04008948 RID: 35144
		private RoleTowerChallengeSettleInfo challengeSettleInfo_;
	}
}
