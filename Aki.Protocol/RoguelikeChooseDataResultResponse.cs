using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F87 RID: 3975
	[NetMessage(EMessageId.RoguelikeChooseDataResultResponse)]
	public sealed class RoguelikeChooseDataResultResponse : IMessage<RoguelikeChooseDataResultResponse>, IMessage, IEquatable<RoguelikeChooseDataResultResponse>, IDeepCloneable<RoguelikeChooseDataResultResponse>, IBufferMessage
	{
		// Token: 0x0601549D RID: 87197 RVA: 0x00317767 File Offset: 0x00315967
		[NullableContext(1)]
		public static RoguelikeChooseDataResultResponse Create()
		{
			return new RoguelikeChooseDataResultResponse();
		}

		// Token: 0x170046F6 RID: 18166
		// (get) Token: 0x0601549E RID: 87198 RVA: 0x0031776E File Offset: 0x0031596E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046F7 RID: 18167
		// (get) Token: 0x0601549F RID: 87199 RVA: 0x00317771 File Offset: 0x00315971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseDataResultResponse.Descriptor;
			}
		}

		// Token: 0x060154A0 RID: 87200 RVA: 0x00317778 File Offset: 0x00315978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResultResponse()
		{
		}

		// Token: 0x060154A1 RID: 87201 RVA: 0x003177A4 File Offset: 0x003159A4
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

		// Token: 0x060154A2 RID: 87202 RVA: 0x0031784B File Offset: 0x00315A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResultResponse Clone()
		{
			return new RoguelikeChooseDataResultResponse(this);
		}

		// Token: 0x170046F8 RID: 18168
		// (get) Token: 0x060154A3 RID: 87203 RVA: 0x00317853 File Offset: 0x00315A53
		// (set) Token: 0x060154A4 RID: 87204 RVA: 0x0031785B File Offset: 0x00315A5B
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

		// Token: 0x170046F9 RID: 18169
		// (get) Token: 0x060154A5 RID: 87205 RVA: 0x00317864 File Offset: 0x00315A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x170046FA RID: 18170
		// (get) Token: 0x060154A6 RID: 87206 RVA: 0x0031786C File Offset: 0x00315A6C
		// (set) Token: 0x060154A7 RID: 87207 RVA: 0x00317874 File Offset: 0x00315A74
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

		// Token: 0x170046FB RID: 18171
		// (get) Token: 0x060154A8 RID: 87208 RVA: 0x0031787D File Offset: 0x00315A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> RogueGainEntryList
		{
			get
			{
				return this.rogueGainEntryList_;
			}
		}

		// Token: 0x170046FC RID: 18172
		// (get) Token: 0x060154A9 RID: 87209 RVA: 0x00317885 File Offset: 0x00315A85
		// (set) Token: 0x060154AA RID: 87210 RVA: 0x0031788D File Offset: 0x00315A8D
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

		// Token: 0x170046FD RID: 18173
		// (get) Token: 0x060154AB RID: 87211 RVA: 0x00317896 File Offset: 0x00315A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> ExtraRogueGainEntrys
		{
			get
			{
				return this.extraRogueGainEntrys_;
			}
		}

		// Token: 0x170046FE RID: 18174
		// (get) Token: 0x060154AC RID: 87212 RVA: 0x0031789E File Offset: 0x00315A9E
		// (set) Token: 0x060154AD RID: 87213 RVA: 0x003178A6 File Offset: 0x00315AA6
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

		// Token: 0x060154AE RID: 87214 RVA: 0x003178AF File Offset: 0x00315AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseDataResultResponse);
		}

		// Token: 0x060154AF RID: 87215 RVA: 0x003178C0 File Offset: 0x00315AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseDataResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this.RoguelikeChooseDataNotify, other.RoguelikeChooseDataNotify) && this.rogueGainEntryList_.Equals(other.rogueGainEntryList_) && this.IsSelect == other.IsSelect && this.extraRogueGainEntrys_.Equals(other.extraRogueGainEntrys_) && object.Equals(this.RogueViewPackage, other.RogueViewPackage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060154B0 RID: 87216 RVA: 0x00317974 File Offset: 0x00315B74
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

		// Token: 0x060154B1 RID: 87217 RVA: 0x00317A28 File Offset: 0x00315C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060154B2 RID: 87218 RVA: 0x00317A35 File Offset: 0x00315C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060154B3 RID: 87219 RVA: 0x00317A40 File Offset: 0x00315C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.extraRogueGainEntrys_.WriteTo(ref output, RoguelikeChooseDataResultResponse._repeated_extraRogueGainEntrys_codec);
			if (this.IsSelect)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSelect);
			}
			if (this.rogueViewPackage_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueViewPackage);
			}
			this.errorParams_.WriteTo(ref output, RoguelikeChooseDataResultResponse._repeated_errorParams_codec);
			this.rogueGainEntryList_.WriteTo(ref output, RoguelikeChooseDataResultResponse._repeated_rogueGainEntryList_codec);
			if (this.roguelikeChooseDataNotify_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RoguelikeChooseDataNotify);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060154B4 RID: 87220 RVA: 0x00317B04 File Offset: 0x00315D04
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

		// Token: 0x060154B5 RID: 87221 RVA: 0x00317BB8 File Offset: 0x00315DB8
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

		// Token: 0x060154B6 RID: 87222 RVA: 0x00317C93 File Offset: 0x00315E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060154B7 RID: 87223 RVA: 0x00317C9C File Offset: 0x00315E9C
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
				if (num <= 50U)
				{
					if (num == 10U)
					{
						this.extraRogueGainEntrys_.AddEntriesFrom(ref input, RoguelikeChooseDataResultResponse._repeated_extraRogueGainEntrys_codec);
						continue;
					}
					if (num == 16U)
					{
						this.IsSelect = input.ReadBool();
						continue;
					}
					if (num == 50U)
					{
						if (this.rogueViewPackage_ == null)
						{
							this.RogueViewPackage = new RogueViewPackage();
						}
						input.ReadMessage(this.RogueViewPackage);
						continue;
					}
				}
				else if (num <= 106U)
				{
					if (num == 66U)
					{
						this.errorParams_.AddEntriesFrom(ref input, RoguelikeChooseDataResultResponse._repeated_errorParams_codec);
						continue;
					}
					if (num == 106U)
					{
						this.rogueGainEntryList_.AddEntriesFrom(ref input, RoguelikeChooseDataResultResponse._repeated_rogueGainEntryList_codec);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						if (this.roguelikeChooseDataNotify_ == null)
						{
							this.RoguelikeChooseDataNotify = new RoguelikeChooseDataNotify();
						}
						input.ReadMessage(this.RoguelikeChooseDataNotify);
						continue;
					}
					if (num == 120U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008092 RID: 32914
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008093 RID: 32915
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04008094 RID: 32916
		private ErrorCode errorCode_;

		// Token: 0x04008095 RID: 32917
		public const int ErrorParamsFieldNumber = 8;

		// Token: 0x04008096 RID: 32918
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(66U);

		// Token: 0x04008097 RID: 32919
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04008098 RID: 32920
		public const int RoguelikeChooseDataNotifyFieldNumber = 14;

		// Token: 0x04008099 RID: 32921
		private RoguelikeChooseDataNotify roguelikeChooseDataNotify_;

		// Token: 0x0400809A RID: 32922
		public const int RogueGainEntryListFieldNumber = 13;

		// Token: 0x0400809B RID: 32923
		private static readonly FieldCodec<RogueGainEntry> _repeated_rogueGainEntryList_codec = FieldCodec.ForMessage<RogueGainEntry>(106U, RogueGainEntry.Parser);

		// Token: 0x0400809C RID: 32924
		private readonly RepeatedField<RogueGainEntry> rogueGainEntryList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x0400809D RID: 32925
		public const int IsSelectFieldNumber = 2;

		// Token: 0x0400809E RID: 32926
		private bool isSelect_;

		// Token: 0x0400809F RID: 32927
		public const int ExtraRogueGainEntrysFieldNumber = 1;

		// Token: 0x040080A0 RID: 32928
		private static readonly FieldCodec<RogueGainEntry> _repeated_extraRogueGainEntrys_codec = FieldCodec.ForMessage<RogueGainEntry>(10U, RogueGainEntry.Parser);

		// Token: 0x040080A1 RID: 32929
		private readonly RepeatedField<RogueGainEntry> extraRogueGainEntrys_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x040080A2 RID: 32930
		public const int RogueViewPackageFieldNumber = 6;

		// Token: 0x040080A3 RID: 32931
		private RogueViewPackage rogueViewPackage_;
	}
}
