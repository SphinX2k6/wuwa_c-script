using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADC RID: 2780
	[NetMessage(EMessageId.MutiplayerTeamRefreshNearListResponse)]
	public sealed class MutiplayerTeamRefreshNearListResponse : IMessage<MutiplayerTeamRefreshNearListResponse>, IMessage, IEquatable<MutiplayerTeamRefreshNearListResponse>, IDeepCloneable<MutiplayerTeamRefreshNearListResponse>, IBufferMessage
	{
		// Token: 0x0600F21C RID: 61980 RVA: 0x00235E0E File Offset: 0x0023400E
		[NullableContext(1)]
		public static MutiplayerTeamRefreshNearListResponse Create()
		{
			return new MutiplayerTeamRefreshNearListResponse();
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x0600F21D RID: 61981 RVA: 0x00235E15 File Offset: 0x00234015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x0600F21E RID: 61982 RVA: 0x00235E18 File Offset: 0x00234018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MutiplayerTeamRefreshNearListResponse.Descriptor;
			}
		}

		// Token: 0x0600F21F RID: 61983 RVA: 0x00235E1F File Offset: 0x0023401F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerTeamRefreshNearListResponse()
		{
		}

		// Token: 0x0600F220 RID: 61984 RVA: 0x00235E40 File Offset: 0x00234040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerTeamRefreshNearListResponse(MutiplayerTeamRefreshNearListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.nextRefreshTime_ = other.nextRefreshTime_;
			this.infoList_ = other.infoList_.Clone();
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F221 RID: 61985 RVA: 0x00235E9E File Offset: 0x0023409E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerTeamRefreshNearListResponse Clone()
		{
			return new MutiplayerTeamRefreshNearListResponse(this);
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x0600F222 RID: 61986 RVA: 0x00235EA6 File Offset: 0x002340A6
		// (set) Token: 0x0600F223 RID: 61987 RVA: 0x00235EAE File Offset: 0x002340AE
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

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x0600F224 RID: 61988 RVA: 0x00235EB7 File Offset: 0x002340B7
		// (set) Token: 0x0600F225 RID: 61989 RVA: 0x00235EBF File Offset: 0x002340BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NextRefreshTime
		{
			get
			{
				return this.nextRefreshTime_;
			}
			set
			{
				this.nextRefreshTime_ = value;
			}
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x0600F226 RID: 61990 RVA: 0x00235EC8 File Offset: 0x002340C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MutiplayerInfo> InfoList
		{
			get
			{
				return this.infoList_;
			}
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x0600F227 RID: 61991 RVA: 0x00235ED0 File Offset: 0x002340D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x0600F228 RID: 61992 RVA: 0x00235ED8 File Offset: 0x002340D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MutiplayerTeamRefreshNearListResponse);
		}

		// Token: 0x0600F229 RID: 61993 RVA: 0x00235EE8 File Offset: 0x002340E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MutiplayerTeamRefreshNearListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NextRefreshTime == other.NextRefreshTime && this.infoList_.Equals(other.infoList_) && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F22A RID: 61994 RVA: 0x00235F5C File Offset: 0x0023415C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.NextRefreshTime != 0)
			{
				num ^= this.NextRefreshTime.GetHashCode();
			}
			num ^= this.infoList_.GetHashCode();
			num ^= this.errorParams_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F22B RID: 61995 RVA: 0x00235FD6 File Offset: 0x002341D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F22C RID: 61996 RVA: 0x00235FE3 File Offset: 0x002341E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F22D RID: 61997 RVA: 0x00235FEC File Offset: 0x002341EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errorParams_.WriteTo(ref output, MutiplayerTeamRefreshNearListResponse._repeated_errorParams_codec);
			this.infoList_.WriteTo(ref output, MutiplayerTeamRefreshNearListResponse._repeated_infoList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.NextRefreshTime != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.NextRefreshTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F22E RID: 61998 RVA: 0x00236068 File Offset: 0x00234268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.NextRefreshTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NextRefreshTime);
			}
			num += this.infoList_.CalculateSize(MutiplayerTeamRefreshNearListResponse._repeated_infoList_codec);
			num += this.errorParams_.CalculateSize(MutiplayerTeamRefreshNearListResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F22F RID: 61999 RVA: 0x002360E4 File Offset: 0x002342E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MutiplayerTeamRefreshNearListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.NextRefreshTime != 0)
			{
				this.NextRefreshTime = other.NextRefreshTime;
			}
			this.infoList_.Add(other.infoList_);
			this.errorParams_.Add(other.errorParams_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F230 RID: 62000 RVA: 0x00236156 File Offset: 0x00234356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F231 RID: 62001 RVA: 0x00236160 File Offset: 0x00234360
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
				if (num <= 26U)
				{
					if (num == 18U)
					{
						this.errorParams_.AddEntriesFrom(ref input, MutiplayerTeamRefreshNearListResponse._repeated_errorParams_codec);
						continue;
					}
					if (num == 26U)
					{
						this.infoList_.AddEntriesFrom(ref input, MutiplayerTeamRefreshNearListResponse._repeated_infoList_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.NextRefreshTime = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006213 RID: 25107
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006214 RID: 25108
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04006215 RID: 25109
		private ErrorCode errorCode_;

		// Token: 0x04006216 RID: 25110
		public const int NextRefreshTimeFieldNumber = 15;

		// Token: 0x04006217 RID: 25111
		private int nextRefreshTime_;

		// Token: 0x04006218 RID: 25112
		public const int InfoListFieldNumber = 3;

		// Token: 0x04006219 RID: 25113
		private static readonly FieldCodec<MutiplayerInfo> _repeated_infoList_codec = FieldCodec.ForMessage<MutiplayerInfo>(26U, MutiplayerInfo.Parser);

		// Token: 0x0400621A RID: 25114
		private readonly RepeatedField<MutiplayerInfo> infoList_ = new RepeatedField<MutiplayerInfo>();

		// Token: 0x0400621B RID: 25115
		public const int ErrorParamsFieldNumber = 2;

		// Token: 0x0400621C RID: 25116
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(18U);

		// Token: 0x0400621D RID: 25117
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
