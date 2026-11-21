using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B4 RID: 436
	[NetMessage(EMessageId.BlackSwordChallengeMarkItemPanelInfoResponse)]
	public sealed class BlackSwordChallengeMarkItemPanelInfoResponse : IMessage<BlackSwordChallengeMarkItemPanelInfoResponse>, IMessage, IEquatable<BlackSwordChallengeMarkItemPanelInfoResponse>, IDeepCloneable<BlackSwordChallengeMarkItemPanelInfoResponse>, IBufferMessage
	{
		// Token: 0x060032E8 RID: 13032 RVA: 0x000815F1 File Offset: 0x0007F7F1
		[NullableContext(1)]
		public static BlackSwordChallengeMarkItemPanelInfoResponse Create()
		{
			return new BlackSwordChallengeMarkItemPanelInfoResponse();
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060032E9 RID: 13033 RVA: 0x000815F8 File Offset: 0x0007F7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x000815FB File Offset: 0x0007F7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackSwordChallengeMarkItemPanelInfoResponse.Descriptor;
			}
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x00081602 File Offset: 0x0007F802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoResponse()
		{
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x00081618 File Offset: 0x0007F818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoResponse(BlackSwordChallengeMarkItemPanelInfoResponse other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.errorCode_ = other.errorCode_;
			this.levelPlayUiInfoList_ = other.levelPlayUiInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x00081665 File Offset: 0x0007F865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoResponse Clone()
		{
			return new BlackSwordChallengeMarkItemPanelInfoResponse(this);
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x0008166D File Offset: 0x0007F86D
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x00081675 File Offset: 0x0007F875
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

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x0008167E File Offset: 0x0007F87E
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x00081686 File Offset: 0x0007F886
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

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x0008168F File Offset: 0x0007F88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackSwordChallengeInfo> LevelPlayUiInfoList
		{
			get
			{
				return this.levelPlayUiInfoList_;
			}
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x00081697 File Offset: 0x0007F897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackSwordChallengeMarkItemPanelInfoResponse);
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x000816A8 File Offset: 0x0007F8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackSwordChallengeMarkItemPanelInfoResponse other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.ErrorCode == other.ErrorCode && this.levelPlayUiInfoList_.Equals(other.levelPlayUiInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x00081708 File Offset: 0x0007F908
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

		// Token: 0x060032F6 RID: 13046 RVA: 0x00081774 File Offset: 0x0007F974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x00081781 File Offset: 0x0007F981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x0008178C File Offset: 0x0007F98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.levelPlayUiInfoList_.WriteTo(ref output, BlackSwordChallengeMarkItemPanelInfoResponse._repeated_levelPlayUiInfoList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000817F8 File Offset: 0x0007F9F8
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

		// Token: 0x060032FA RID: 13050 RVA: 0x00081864 File Offset: 0x0007FA64
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

		// Token: 0x060032FB RID: 13051 RVA: 0x000818C5 File Offset: 0x0007FAC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x000818D0 File Offset: 0x0007FAD0
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
					if (num != 32U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.levelPlayUiInfoList_.AddEntriesFrom(ref input, BlackSwordChallengeMarkItemPanelInfoResponse._repeated_levelPlayUiInfoList_codec);
				}
			}
		}

		// Token: 0x040029ED RID: 10733
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029EE RID: 10734
		public const int ChallengeIdFieldNumber = 14;

		// Token: 0x040029EF RID: 10735
		private int challengeId_;

		// Token: 0x040029F0 RID: 10736
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040029F1 RID: 10737
		private ErrorCode errorCode_;

		// Token: 0x040029F2 RID: 10738
		public const int LevelPlayUiInfoListFieldNumber = 2;

		// Token: 0x040029F3 RID: 10739
		private static readonly FieldCodec<BlackSwordChallengeInfo> _repeated_levelPlayUiInfoList_codec = FieldCodec.ForMessage<BlackSwordChallengeInfo>(18U, BlackSwordChallengeInfo.Parser);

		// Token: 0x040029F4 RID: 10740
		private readonly RepeatedField<BlackSwordChallengeInfo> levelPlayUiInfoList_ = new RepeatedField<BlackSwordChallengeInfo>();
	}
}
