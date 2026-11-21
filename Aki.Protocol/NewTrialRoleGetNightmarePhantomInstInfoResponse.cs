using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B45 RID: 2885
	[NetMessage(EMessageId.NewTrialRoleGetNightmarePhantomInstInfoResponse)]
	public sealed class NewTrialRoleGetNightmarePhantomInstInfoResponse : IMessage<NewTrialRoleGetNightmarePhantomInstInfoResponse>, IMessage, IEquatable<NewTrialRoleGetNightmarePhantomInstInfoResponse>, IDeepCloneable<NewTrialRoleGetNightmarePhantomInstInfoResponse>, IBufferMessage
	{
		// Token: 0x0600FA71 RID: 64113 RVA: 0x00248352 File Offset: 0x00246552
		[NullableContext(1)]
		public static NewTrialRoleGetNightmarePhantomInstInfoResponse Create()
		{
			return new NewTrialRoleGetNightmarePhantomInstInfoResponse();
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600FA72 RID: 64114 RVA: 0x00248359 File Offset: 0x00246559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600FA73 RID: 64115 RVA: 0x0024835C File Offset: 0x0024655C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTrialRoleGetNightmarePhantomInstInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600FA74 RID: 64116 RVA: 0x00248363 File Offset: 0x00246563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoResponse()
		{
		}

		// Token: 0x0600FA75 RID: 64117 RVA: 0x00248384 File Offset: 0x00246584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoResponse(NewTrialRoleGetNightmarePhantomInstInfoResponse other) : this()
		{
			this.code_ = other.code_;
			this.insInfoList_ = other.insInfoList_.Clone();
			this.saveInsIdList_ = other.saveInsIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA76 RID: 64118 RVA: 0x002483D6 File Offset: 0x002465D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoResponse Clone()
		{
			return new NewTrialRoleGetNightmarePhantomInstInfoResponse(this);
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600FA77 RID: 64119 RVA: 0x002483DE File Offset: 0x002465DE
		// (set) Token: 0x0600FA78 RID: 64120 RVA: 0x002483E6 File Offset: 0x002465E6
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

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600FA79 RID: 64121 RVA: 0x002483EF File Offset: 0x002465EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NightmarePhantomInstInfo> InsInfoList
		{
			get
			{
				return this.insInfoList_;
			}
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600FA7A RID: 64122 RVA: 0x002483F7 File Offset: 0x002465F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SaveInsIdList
		{
			get
			{
				return this.saveInsIdList_;
			}
		}

		// Token: 0x0600FA7B RID: 64123 RVA: 0x002483FF File Offset: 0x002465FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTrialRoleGetNightmarePhantomInstInfoResponse);
		}

		// Token: 0x0600FA7C RID: 64124 RVA: 0x00248410 File Offset: 0x00246610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTrialRoleGetNightmarePhantomInstInfoResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.insInfoList_.Equals(other.insInfoList_) && this.saveInsIdList_.Equals(other.saveInsIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA7D RID: 64125 RVA: 0x00248474 File Offset: 0x00246674
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

		// Token: 0x0600FA7E RID: 64126 RVA: 0x002484D5 File Offset: 0x002466D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA7F RID: 64127 RVA: 0x002484E2 File Offset: 0x002466E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA80 RID: 64128 RVA: 0x002484EC File Offset: 0x002466EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			this.insInfoList_.WriteTo(ref output, NewTrialRoleGetNightmarePhantomInstInfoResponse._repeated_insInfoList_codec);
			this.saveInsIdList_.WriteTo(ref output, NewTrialRoleGetNightmarePhantomInstInfoResponse._repeated_saveInsIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA81 RID: 64129 RVA: 0x0024854C File Offset: 0x0024674C
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

		// Token: 0x0600FA82 RID: 64130 RVA: 0x002485B0 File Offset: 0x002467B0
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

		// Token: 0x0600FA83 RID: 64131 RVA: 0x0024860E File Offset: 0x0024680E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA84 RID: 64132 RVA: 0x00248618 File Offset: 0x00246818
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
				if (num <= 34U)
				{
					if (num == 8U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 34U)
					{
						this.insInfoList_.AddEntriesFrom(ref input, NewTrialRoleGetNightmarePhantomInstInfoResponse._repeated_insInfoList_codec);
						continue;
					}
				}
				else if (num == 56U || num == 58U)
				{
					this.saveInsIdList_.AddEntriesFrom(ref input, NewTrialRoleGetNightmarePhantomInstInfoResponse._repeated_saveInsIdList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400648F RID: 25743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006490 RID: 25744
		public const int CodeFieldNumber = 1;

		// Token: 0x04006491 RID: 25745
		private ErrorCode code_;

		// Token: 0x04006492 RID: 25746
		public const int InsInfoListFieldNumber = 4;

		// Token: 0x04006493 RID: 25747
		private static readonly FieldCodec<NightmarePhantomInstInfo> _repeated_insInfoList_codec = FieldCodec.ForMessage<NightmarePhantomInstInfo>(34U, NightmarePhantomInstInfo.Parser);

		// Token: 0x04006494 RID: 25748
		private readonly RepeatedField<NightmarePhantomInstInfo> insInfoList_ = new RepeatedField<NightmarePhantomInstInfo>();

		// Token: 0x04006495 RID: 25749
		public const int SaveInsIdListFieldNumber = 7;

		// Token: 0x04006496 RID: 25750
		private static readonly FieldCodec<int> _repeated_saveInsIdList_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04006497 RID: 25751
		private readonly RepeatedField<int> saveInsIdList_ = new RepeatedField<int>();
	}
}
