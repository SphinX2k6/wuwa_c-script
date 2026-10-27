using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F97 RID: 3991
	[NetMessage(EMessageId.RoguelikeChooseDataResultResponse)]
	public sealed class RoguelikeChooseDataResultResponse : IMessage<RoguelikeChooseDataResultResponse>, IMessage, IEquatable<RoguelikeChooseDataResultResponse>, IDeepCloneable<RoguelikeChooseDataResultResponse>, IBufferMessage
	{
		// Token: 0x06015582 RID: 87426 RVA: 0x00318E16 File Offset: 0x00317016
		[NullableContext(1)]
		public static RoguelikeChooseDataResultResponse Create()
		{
			return new RoguelikeChooseDataResultResponse();
		}

		// Token: 0x17004720 RID: 18208
		// (get) Token: 0x06015583 RID: 87427 RVA: 0x00318E1D File Offset: 0x0031701D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004721 RID: 18209
		// (get) Token: 0x06015584 RID: 87428 RVA: 0x00318E20 File Offset: 0x00317020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseDataResultResponse.Descriptor;
			}
		}

		// Token: 0x06015585 RID: 87429 RVA: 0x00318E27 File Offset: 0x00317027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResultResponse()
		{
		}

		// Token: 0x06015586 RID: 87430 RVA: 0x00318E50 File Offset: 0x00317050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResultResponse(RoguelikeChooseDataResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.roguelikeChooseDataNotify_ = ((other.roguelikeChooseDataNotify_ != null) ? other.roguelikeChooseDataNotify_.Clone() : null);
			this.rogueGainEntryList_ = other.rogueGainEntryList_.Clone();
			this.isSelect_ = other.isSelect_;
			this.extraRogueGainEntrys_ = other.extraRogueGainEntrys_.Clone();
			this.rogueViewPackage_ = ((other.rogueViewPackage_ != null) ? other.rogueViewPackage_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015587 RID: 87431 RVA: 0x00318EF7 File Offset: 0x003170F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResultResponse Clone()
		{
			return new RoguelikeChooseDataResultResponse(this);
		}

		// Token: 0x17004722 RID: 18210
		// (get) Token: 0x06015588 RID: 87432 RVA: 0x00318EFF File Offset: 0x003170FF
		// (set) Token: 0x06015589 RID: 87433 RVA: 0x00318F07 File Offset: 0x00317107
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

		// Token: 0x17004723 RID: 18211
		// (get) Token: 0x0601558A RID: 87434 RVA: 0x00318F10 File Offset: 0x00317110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17004724 RID: 18212
		// (get) Token: 0x0601558B RID: 87435 RVA: 0x00318F18 File Offset: 0x00317118
		// (set) Token: 0x0601558C RID: 87436 RVA: 0x00318F20 File Offset: 0x00317120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataNotify RoguelikeChooseDataNotify
		{
			get
			{
				return this.roguelikeChooseDataNotify_;
			}
			set
			{
				this.roguelikeChooseDataNotify_ = value;
			}
		}

		// Token: 0x17004725 RID: 18213
		// (get) Token: 0x0601558D RID: 87437 RVA: 0x00318F29 File Offset: 0x00317129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> RogueGainEntryList
		{
			get
			{
				return this.rogueGainEntryList_;
			}
		}

		// Token: 0x17004726 RID: 18214
		// (get) Token: 0x0601558E RID: 87438 RVA: 0x00318F31 File Offset: 0x00317131
		// (set) Token: 0x0601558F RID: 87439 RVA: 0x00318F39 File Offset: 0x00317139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSelect
		{
			get
			{
				return this.isSelect_;
			}
			set
			{
				this.isSelect_ = value;
			}
		}

		// Token: 0x17004727 RID: 18215
		// (get) Token: 0x06015590 RID: 87440 RVA: 0x00318F42 File Offset: 0x00317142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> ExtraRogueGainEntrys
		{
			get
			{
				return this.extraRogueGainEntrys_;
			}
		}

		// Token: 0x17004728 RID: 18216
		// (get) Token: 0x06015591 RID: 87441 RVA: 0x00318F4A File Offset: 0x0031714A
		// (set) Token: 0x06015592 RID: 87442 RVA: 0x00318F52 File Offset: 0x00317152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewPackage RogueViewPackage
		{
			get
			{
				return this.rogueViewPackage_;
			}
			set
			{
				this.rogueViewPackage_ = value;
			}
		}

		// Token: 0x06015593 RID: 87443 RVA: 0x00318F5B File Offset: 0x0031715B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseDataResultResponse);
		}

		// Token: 0x06015594 RID: 87444 RVA: 0x00318F6C File Offset: 0x0031716C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseDataResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this.RoguelikeChooseDataNotify, other.RoguelikeChooseDataNotify) && this.rogueGainEntryList_.Equals(other.rogueGainEntryList_) && this.IsSelect == other.IsSelect && this.extraRogueGainEntrys_.Equals(other.extraRogueGainEntrys_) && object.Equals(this.RogueViewPackage, other.RogueViewPackage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015595 RID: 87445 RVA: 0x00319020 File Offset: 0x00317220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			if (this.roguelikeChooseDataNotify_ != null)
			{
				num ^= this.RoguelikeChooseDataNotify.GetHashCode();
			}
			num ^= this.rogueGainEntryList_.GetHashCode();
			if (this.IsSelect)
			{
				num ^= this.IsSelect.GetHashCode();
			}
			num ^= this.extraRogueGainEntrys_.GetHashCode();
			if (this.rogueViewPackage_ != null)
			{
				num ^= this.RogueViewPackage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015596 RID: 87446 RVA: 0x003190D4 File Offset: 0x003172D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015597 RID: 87447 RVA: 0x003190E1 File Offset: 0x003172E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015598 RID: 87448 RVA: 0x003190EC File Offset: 0x003172EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.extraRogueGainEntrys_.WriteTo(ref output, RoguelikeChooseDataResultResponse._repeated_extraRogueGainEntrys_codec);
			this.errorParams_.WriteTo(ref output, RoguelikeChooseDataResultResponse._repeated_errorParams_codec);
			this.rogueGainEntryList_.WriteTo(ref output, RoguelikeChooseDataResultResponse._repeated_rogueGainEntryList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.rogueViewPackage_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueViewPackage);
			}
			if (this.IsSelect)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsSelect);
			}
			if (this.roguelikeChooseDataNotify_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RoguelikeChooseDataNotify);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015599 RID: 87449 RVA: 0x003191B0 File Offset: 0x003173B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(RoguelikeChooseDataResultResponse._repeated_errorParams_codec);
			if (this.roguelikeChooseDataNotify_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoguelikeChooseDataNotify);
			}
			num += this.rogueGainEntryList_.CalculateSize(RoguelikeChooseDataResultResponse._repeated_rogueGainEntryList_codec);
			if (this.IsSelect)
			{
				num += 2;
			}
			num += this.extraRogueGainEntrys_.CalculateSize(RoguelikeChooseDataResultResponse._repeated_extraRogueGainEntrys_codec);
			if (this.rogueViewPackage_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueViewPackage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601559A RID: 87450 RVA: 0x00319264 File Offset: 0x00317464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeChooseDataResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			if (other.roguelikeChooseDataNotify_ != null)
			{
				if (this.roguelikeChooseDataNotify_ == null)
				{
					this.RoguelikeChooseDataNotify = new RoguelikeChooseDataNotify();
				}
				this.RoguelikeChooseDataNotify.MergeFrom(other.RoguelikeChooseDataNotify);
			}
			this.rogueGainEntryList_.Add(other.rogueGainEntryList_);
			if (other.IsSelect)
			{
				this.IsSelect = other.IsSelect;
			}
			this.extraRogueGainEntrys_.Add(other.extraRogueGainEntrys_);
			if (other.rogueViewPackage_ != null)
			{
				if (this.rogueViewPackage_ == null)
				{
					this.RogueViewPackage = new RogueViewPackage();
				}
				this.RogueViewPackage.MergeFrom(other.RogueViewPackage);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601559B RID: 87451 RVA: 0x0031933F File Offset: 0x0031753F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601559C RID: 87452 RVA: 0x00319348 File Offset: 0x00317548
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
				if (num <= 66U)
				{
					if (num == 26U)
					{
						this.extraRogueGainEntrys_.AddEntriesFrom(ref input, RoguelikeChooseDataResultResponse._repeated_extraRogueGainEntrys_codec);
						continue;
					}
					if (num == 50U)
					{
						this.errorParams_.AddEntriesFrom(ref input, RoguelikeChooseDataResultResponse._repeated_errorParams_codec);
						continue;
					}
					if (num == 66U)
					{
						this.rogueGainEntryList_.AddEntriesFrom(ref input, RoguelikeChooseDataResultResponse._repeated_rogueGainEntryList_codec);
						continue;
					}
				}
				else if (num <= 82U)
				{
					if (num == 72U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 82U)
					{
						if (this.rogueViewPackage_ == null)
						{
							this.RogueViewPackage = new RogueViewPackage();
						}
						input.ReadMessage(this.RogueViewPackage);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.IsSelect = input.ReadBool();
						continue;
					}
					if (num == 122U)
					{
						if (this.roguelikeChooseDataNotify_ == null)
						{
							this.RoguelikeChooseDataNotify = new RoguelikeChooseDataNotify();
						}
						input.ReadMessage(this.RoguelikeChooseDataNotify);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008068 RID: 32872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008069 RID: 32873
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400806A RID: 32874
		private ErrorCode errorCode_;

		// Token: 0x0400806B RID: 32875
		public const int ErrorParamsFieldNumber = 6;

		// Token: 0x0400806C RID: 32876
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(50U);

		// Token: 0x0400806D RID: 32877
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x0400806E RID: 32878
		public const int RoguelikeChooseDataNotifyFieldNumber = 15;

		// Token: 0x0400806F RID: 32879
		private RoguelikeChooseDataNotify roguelikeChooseDataNotify_;

		// Token: 0x04008070 RID: 32880
		public const int RogueGainEntryListFieldNumber = 8;

		// Token: 0x04008071 RID: 32881
		private static readonly FieldCodec<RogueGainEntry> _repeated_rogueGainEntryList_codec = FieldCodec.ForMessage<RogueGainEntry>(66U, RogueGainEntry.Parser);

		// Token: 0x04008072 RID: 32882
		private readonly RepeatedField<RogueGainEntry> rogueGainEntryList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x04008073 RID: 32883
		public const int IsSelectFieldNumber = 12;

		// Token: 0x04008074 RID: 32884
		private bool isSelect_;

		// Token: 0x04008075 RID: 32885
		public const int ExtraRogueGainEntrysFieldNumber = 3;

		// Token: 0x04008076 RID: 32886
		private static readonly FieldCodec<RogueGainEntry> _repeated_extraRogueGainEntrys_codec = FieldCodec.ForMessage<RogueGainEntry>(26U, RogueGainEntry.Parser);

		// Token: 0x04008077 RID: 32887
		private readonly RepeatedField<RogueGainEntry> extraRogueGainEntrys_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x04008078 RID: 32888
		public const int RogueViewPackageFieldNumber = 10;

		// Token: 0x04008079 RID: 32889
		private RogueViewPackage rogueViewPackage_;
	}
}
