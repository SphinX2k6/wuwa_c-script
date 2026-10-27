using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AED RID: 2797
	[NetMessage(EMessageId.MutiplayerTeamRefreshNearListResponse)]
	public sealed class MutiplayerTeamRefreshNearListResponse : IMessage<MutiplayerTeamRefreshNearListResponse>, IMessage, IEquatable<MutiplayerTeamRefreshNearListResponse>, IDeepCloneable<MutiplayerTeamRefreshNearListResponse>, IBufferMessage
	{
		// Token: 0x0600F336 RID: 62262 RVA: 0x00238016 File Offset: 0x00236216
		[NullableContext(1)]
		public static MutiplayerTeamRefreshNearListResponse Create()
		{
			return new MutiplayerTeamRefreshNearListResponse();
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x0600F337 RID: 62263 RVA: 0x0023801D File Offset: 0x0023621D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x0600F338 RID: 62264 RVA: 0x00238020 File Offset: 0x00236220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MutiplayerTeamRefreshNearListResponse.Descriptor;
			}
		}

		// Token: 0x0600F339 RID: 62265 RVA: 0x00238027 File Offset: 0x00236227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerTeamRefreshNearListResponse()
		{
		}

		// Token: 0x0600F33A RID: 62266 RVA: 0x00238048 File Offset: 0x00236248
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

		// Token: 0x0600F33B RID: 62267 RVA: 0x002380A6 File Offset: 0x002362A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerTeamRefreshNearListResponse Clone()
		{
			return new MutiplayerTeamRefreshNearListResponse(this);
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x0600F33C RID: 62268 RVA: 0x002380AE File Offset: 0x002362AE
		// (set) Token: 0x0600F33D RID: 62269 RVA: 0x002380B6 File Offset: 0x002362B6
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

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x0600F33E RID: 62270 RVA: 0x002380BF File Offset: 0x002362BF
		// (set) Token: 0x0600F33F RID: 62271 RVA: 0x002380C7 File Offset: 0x002362C7
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

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x0600F340 RID: 62272 RVA: 0x002380D0 File Offset: 0x002362D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MutiplayerInfo> InfoList
		{
			get
			{
				return this.infoList_;
			}
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x0600F341 RID: 62273 RVA: 0x002380D8 File Offset: 0x002362D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x0600F342 RID: 62274 RVA: 0x002380E0 File Offset: 0x002362E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MutiplayerTeamRefreshNearListResponse);
		}

		// Token: 0x0600F343 RID: 62275 RVA: 0x002380F0 File Offset: 0x002362F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MutiplayerTeamRefreshNearListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NextRefreshTime == other.NextRefreshTime && this.infoList_.Equals(other.infoList_) && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F344 RID: 62276 RVA: 0x00238164 File Offset: 0x00236364
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

		// Token: 0x0600F345 RID: 62277 RVA: 0x002381DE File Offset: 0x002363DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F346 RID: 62278 RVA: 0x002381EB File Offset: 0x002363EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F347 RID: 62279 RVA: 0x002381F4 File Offset: 0x002363F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NextRefreshTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NextRefreshTime);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.infoList_.WriteTo(ref output, MutiplayerTeamRefreshNearListResponse._repeated_infoList_codec);
			this.errorParams_.WriteTo(ref output, MutiplayerTeamRefreshNearListResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F348 RID: 62280 RVA: 0x00238270 File Offset: 0x00236470
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

		// Token: 0x0600F349 RID: 62281 RVA: 0x002382EC File Offset: 0x002364EC
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

		// Token: 0x0600F34A RID: 62282 RVA: 0x0023835E File Offset: 0x0023655E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F34B RID: 62283 RVA: 0x00238368 File Offset: 0x00236568
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.NextRefreshTime = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.infoList_.AddEntriesFrom(ref input, MutiplayerTeamRefreshNearListResponse._repeated_infoList_codec);
						continue;
					}
					if (num == 114U)
					{
						this.errorParams_.AddEntriesFrom(ref input, MutiplayerTeamRefreshNearListResponse._repeated_errorParams_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400620A RID: 25098
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400620B RID: 25099
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400620C RID: 25100
		private ErrorCode errorCode_;

		// Token: 0x0400620D RID: 25101
		public const int NextRefreshTimeFieldNumber = 3;

		// Token: 0x0400620E RID: 25102
		private int nextRefreshTime_;

		// Token: 0x0400620F RID: 25103
		public const int InfoListFieldNumber = 12;

		// Token: 0x04006210 RID: 25104
		private static readonly FieldCodec<MutiplayerInfo> _repeated_infoList_codec = FieldCodec.ForMessage<MutiplayerInfo>(98U, MutiplayerInfo.Parser);

		// Token: 0x04006211 RID: 25105
		private readonly RepeatedField<MutiplayerInfo> infoList_ = new RepeatedField<MutiplayerInfo>();

		// Token: 0x04006212 RID: 25106
		public const int ErrorParamsFieldNumber = 14;

		// Token: 0x04006213 RID: 25107
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(114U);

		// Token: 0x04006214 RID: 25108
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
