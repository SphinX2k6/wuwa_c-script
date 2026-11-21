using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B2 RID: 434
	[NetMessage(EMessageId.BlackSwordChallengeInfoResponse)]
	public sealed class BlackSwordChallengeInfoResponse : IMessage<BlackSwordChallengeInfoResponse>, IMessage, IEquatable<BlackSwordChallengeInfoResponse>, IDeepCloneable<BlackSwordChallengeInfoResponse>, IBufferMessage
	{
		// Token: 0x060032C0 RID: 12992 RVA: 0x000810B5 File Offset: 0x0007F2B5
		[NullableContext(1)]
		public static BlackSwordChallengeInfoResponse Create()
		{
			return new BlackSwordChallengeInfoResponse();
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060032C1 RID: 12993 RVA: 0x000810BC File Offset: 0x0007F2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x000810BF File Offset: 0x0007F2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackSwordChallengeInfoResponse.Descriptor;
			}
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x000810C6 File Offset: 0x0007F2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoResponse()
		{
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x000810DC File Offset: 0x0007F2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoResponse(BlackSwordChallengeInfoResponse other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.errorCode_ = other.errorCode_;
			this.levelPlayUiInfoList_ = other.levelPlayUiInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x00081129 File Offset: 0x0007F329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfoResponse Clone()
		{
			return new BlackSwordChallengeInfoResponse(this);
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x00081131 File Offset: 0x0007F331
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x00081139 File Offset: 0x0007F339
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

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x00081142 File Offset: 0x0007F342
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x0008114A File Offset: 0x0007F34A
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

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x00081153 File Offset: 0x0007F353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackSwordChallengeInfo> LevelPlayUiInfoList
		{
			get
			{
				return this.levelPlayUiInfoList_;
			}
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x0008115B File Offset: 0x0007F35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackSwordChallengeInfoResponse);
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x0008116C File Offset: 0x0007F36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackSwordChallengeInfoResponse other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.ErrorCode == other.ErrorCode && this.levelPlayUiInfoList_.Equals(other.levelPlayUiInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x000811CC File Offset: 0x0007F3CC
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

		// Token: 0x060032CE RID: 13006 RVA: 0x00081238 File Offset: 0x0007F438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x00081245 File Offset: 0x0007F445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x00081250 File Offset: 0x0007F450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.levelPlayUiInfoList_.WriteTo(ref output, BlackSwordChallengeInfoResponse._repeated_levelPlayUiInfoList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000812BC File Offset: 0x0007F4BC
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

		// Token: 0x060032D2 RID: 13010 RVA: 0x00081328 File Offset: 0x0007F528
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

		// Token: 0x060032D3 RID: 13011 RVA: 0x00081389 File Offset: 0x0007F589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x00081394 File Offset: 0x0007F594
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
				if (num != 34U)
				{
					if (num != 48U)
					{
						if (num != 120U)
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
					this.levelPlayUiInfoList_.AddEntriesFrom(ref input, BlackSwordChallengeInfoResponse._repeated_levelPlayUiInfoList_codec);
				}
			}
		}

		// Token: 0x040029E2 RID: 10722
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029E3 RID: 10723
		public const int ChallengeIdFieldNumber = 15;

		// Token: 0x040029E4 RID: 10724
		private int challengeId_;

		// Token: 0x040029E5 RID: 10725
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040029E6 RID: 10726
		private ErrorCode errorCode_;

		// Token: 0x040029E7 RID: 10727
		public const int LevelPlayUiInfoListFieldNumber = 4;

		// Token: 0x040029E8 RID: 10728
		private static readonly FieldCodec<BlackSwordChallengeInfo> _repeated_levelPlayUiInfoList_codec = FieldCodec.ForMessage<BlackSwordChallengeInfo>(34U, BlackSwordChallengeInfo.Parser);

		// Token: 0x040029E9 RID: 10729
		private readonly RepeatedField<BlackSwordChallengeInfo> levelPlayUiInfoList_ = new RepeatedField<BlackSwordChallengeInfo>();
	}
}
