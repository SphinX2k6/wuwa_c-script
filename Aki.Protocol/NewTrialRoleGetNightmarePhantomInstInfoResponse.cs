using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B56 RID: 2902
	[NetMessage(EMessageId.NewTrialRoleGetNightmarePhantomInstInfoResponse)]
	public sealed class NewTrialRoleGetNightmarePhantomInstInfoResponse : IMessage<NewTrialRoleGetNightmarePhantomInstInfoResponse>, IMessage, IEquatable<NewTrialRoleGetNightmarePhantomInstInfoResponse>, IDeepCloneable<NewTrialRoleGetNightmarePhantomInstInfoResponse>, IBufferMessage
	{
		// Token: 0x0600FB8B RID: 64395 RVA: 0x0024A566 File Offset: 0x00248766
		[NullableContext(1)]
		public static NewTrialRoleGetNightmarePhantomInstInfoResponse Create()
		{
			return new NewTrialRoleGetNightmarePhantomInstInfoResponse();
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600FB8C RID: 64396 RVA: 0x0024A56D File Offset: 0x0024876D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600FB8D RID: 64397 RVA: 0x0024A570 File Offset: 0x00248770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTrialRoleGetNightmarePhantomInstInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600FB8E RID: 64398 RVA: 0x0024A577 File Offset: 0x00248777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoResponse()
		{
		}

		// Token: 0x0600FB8F RID: 64399 RVA: 0x0024A598 File Offset: 0x00248798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoResponse(NewTrialRoleGetNightmarePhantomInstInfoResponse other) : this()
		{
			this.code_ = other.code_;
			this.insInfoList_ = other.insInfoList_.Clone();
			this.saveInsIdList_ = other.saveInsIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB90 RID: 64400 RVA: 0x0024A5EA File Offset: 0x002487EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoResponse Clone()
		{
			return new NewTrialRoleGetNightmarePhantomInstInfoResponse(this);
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600FB91 RID: 64401 RVA: 0x0024A5F2 File Offset: 0x002487F2
		// (set) Token: 0x0600FB92 RID: 64402 RVA: 0x0024A5FA File Offset: 0x002487FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600FB93 RID: 64403 RVA: 0x0024A603 File Offset: 0x00248803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NightmarePhantomInstInfo> InsInfoList
		{
			get
			{
				return this.insInfoList_;
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600FB94 RID: 64404 RVA: 0x0024A60B File Offset: 0x0024880B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SaveInsIdList
		{
			get
			{
				return this.saveInsIdList_;
			}
		}

		// Token: 0x0600FB95 RID: 64405 RVA: 0x0024A613 File Offset: 0x00248813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTrialRoleGetNightmarePhantomInstInfoResponse);
		}

		// Token: 0x0600FB96 RID: 64406 RVA: 0x0024A624 File Offset: 0x00248824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTrialRoleGetNightmarePhantomInstInfoResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.insInfoList_.Equals(other.insInfoList_) && this.saveInsIdList_.Equals(other.saveInsIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB97 RID: 64407 RVA: 0x0024A688 File Offset: 0x00248888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.insInfoList_.GetHashCode();
			num ^= this.saveInsIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FB98 RID: 64408 RVA: 0x0024A6E9 File Offset: 0x002488E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB99 RID: 64409 RVA: 0x0024A6F6 File Offset: 0x002488F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB9A RID: 64410 RVA: 0x0024A700 File Offset: 0x00248900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.insInfoList_.WriteTo(ref output, NewTrialRoleGetNightmarePhantomInstInfoResponse._repeated_insInfoList_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			this.saveInsIdList_.WriteTo(ref output, NewTrialRoleGetNightmarePhantomInstInfoResponse._repeated_saveInsIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB9B RID: 64411 RVA: 0x0024A760 File Offset: 0x00248960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.insInfoList_.CalculateSize(NewTrialRoleGetNightmarePhantomInstInfoResponse._repeated_insInfoList_codec);
			num += this.saveInsIdList_.CalculateSize(NewTrialRoleGetNightmarePhantomInstInfoResponse._repeated_saveInsIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FB9C RID: 64412 RVA: 0x0024A7C4 File Offset: 0x002489C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTrialRoleGetNightmarePhantomInstInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.insInfoList_.Add(other.insInfoList_);
			this.saveInsIdList_.Add(other.saveInsIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FB9D RID: 64413 RVA: 0x0024A822 File Offset: 0x00248A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB9E RID: 64414 RVA: 0x0024A82C File Offset: 0x00248A2C
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
					if (num == 18U)
					{
						this.insInfoList_.AddEntriesFrom(ref input, NewTrialRoleGetNightmarePhantomInstInfoResponse._repeated_insInfoList_codec);
						continue;
					}
					if (num == 32U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.saveInsIdList_.AddEntriesFrom(ref input, NewTrialRoleGetNightmarePhantomInstInfoResponse._repeated_saveInsIdList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006486 RID: 25734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006487 RID: 25735
		public const int CodeFieldNumber = 4;

		// Token: 0x04006488 RID: 25736
		private ErrorCode code_;

		// Token: 0x04006489 RID: 25737
		public const int InsInfoListFieldNumber = 2;

		// Token: 0x0400648A RID: 25738
		private static readonly FieldCodec<NightmarePhantomInstInfo> _repeated_insInfoList_codec = FieldCodec.ForMessage<NightmarePhantomInstInfo>(18U, NightmarePhantomInstInfo.Parser);

		// Token: 0x0400648B RID: 25739
		private readonly RepeatedField<NightmarePhantomInstInfo> insInfoList_ = new RepeatedField<NightmarePhantomInstInfo>();

		// Token: 0x0400648C RID: 25740
		public const int SaveInsIdListFieldNumber = 14;

		// Token: 0x0400648D RID: 25741
		private static readonly FieldCodec<int> _repeated_saveInsIdList_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400648E RID: 25742
		private readonly RepeatedField<int> saveInsIdList_ = new RepeatedField<int>();
	}
}
