using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA4 RID: 4004
	[NetMessage(EMessageId.RoguelikeLastInfoResponse)]
	public sealed class RoguelikeLastInfoResponse : IMessage<RoguelikeLastInfoResponse>, IMessage, IEquatable<RoguelikeLastInfoResponse>, IDeepCloneable<RoguelikeLastInfoResponse>, IBufferMessage
	{
		// Token: 0x06015697 RID: 87703 RVA: 0x0031B9AE File Offset: 0x00319BAE
		[NullableContext(1)]
		public static RoguelikeLastInfoResponse Create()
		{
			return new RoguelikeLastInfoResponse();
		}

		// Token: 0x17004760 RID: 18272
		// (get) Token: 0x06015698 RID: 87704 RVA: 0x0031B9B5 File Offset: 0x00319BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004761 RID: 18273
		// (get) Token: 0x06015699 RID: 87705 RVA: 0x0031B9B8 File Offset: 0x00319BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeLastInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601569A RID: 87706 RVA: 0x0031B9BF File Offset: 0x00319BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfoResponse()
		{
		}

		// Token: 0x0601569B RID: 87707 RVA: 0x0031B9D4 File Offset: 0x00319BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfoResponse(RoguelikeLastInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.hasData_ = other.hasData_;
			this.roguelikeLastInfos_ = other.roguelikeLastInfos_.Clone();
			this.tempRogueArchiveInfo_ = ((other.tempRogueArchiveInfo_ != null) ? other.tempRogueArchiveInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601569C RID: 87708 RVA: 0x0031BA3D File Offset: 0x00319C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfoResponse Clone()
		{
			return new RoguelikeLastInfoResponse(this);
		}

		// Token: 0x17004762 RID: 18274
		// (get) Token: 0x0601569D RID: 87709 RVA: 0x0031BA45 File Offset: 0x00319C45
		// (set) Token: 0x0601569E RID: 87710 RVA: 0x0031BA4D File Offset: 0x00319C4D
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

		// Token: 0x17004763 RID: 18275
		// (get) Token: 0x0601569F RID: 87711 RVA: 0x0031BA56 File Offset: 0x00319C56
		// (set) Token: 0x060156A0 RID: 87712 RVA: 0x0031BA5E File Offset: 0x00319C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasData
		{
			get
			{
				return this.hasData_;
			}
			set
			{
				this.hasData_ = value;
			}
		}

		// Token: 0x17004764 RID: 18276
		// (get) Token: 0x060156A1 RID: 87713 RVA: 0x0031BA67 File Offset: 0x00319C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoguelikeLastInfo> RoguelikeLastInfos
		{
			get
			{
				return this.roguelikeLastInfos_;
			}
		}

		// Token: 0x17004765 RID: 18277
		// (get) Token: 0x060156A2 RID: 87714 RVA: 0x0031BA6F File Offset: 0x00319C6F
		// (set) Token: 0x060156A3 RID: 87715 RVA: 0x0031BA77 File Offset: 0x00319C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveInfo TempRogueArchiveInfo
		{
			get
			{
				return this.tempRogueArchiveInfo_;
			}
			set
			{
				this.tempRogueArchiveInfo_ = value;
			}
		}

		// Token: 0x060156A4 RID: 87716 RVA: 0x0031BA80 File Offset: 0x00319C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeLastInfoResponse);
		}

		// Token: 0x060156A5 RID: 87717 RVA: 0x0031BA90 File Offset: 0x00319C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeLastInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.HasData == other.HasData && this.roguelikeLastInfos_.Equals(other.roguelikeLastInfos_) && object.Equals(this.TempRogueArchiveInfo, other.TempRogueArchiveInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060156A6 RID: 87718 RVA: 0x0031BB04 File Offset: 0x00319D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.HasData)
			{
				num ^= this.HasData.GetHashCode();
			}
			num ^= this.roguelikeLastInfos_.GetHashCode();
			if (this.tempRogueArchiveInfo_ != null)
			{
				num ^= this.TempRogueArchiveInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060156A7 RID: 87719 RVA: 0x0031BB86 File Offset: 0x00319D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060156A8 RID: 87720 RVA: 0x0031BB93 File Offset: 0x00319D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060156A9 RID: 87721 RVA: 0x0031BB9C File Offset: 0x00319D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasData)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.HasData);
			}
			this.roguelikeLastInfos_.WriteTo(ref output, RoguelikeLastInfoResponse._repeated_roguelikeLastInfos_codec);
			if (this.tempRogueArchiveInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.TempRogueArchiveInfo);
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

		// Token: 0x060156AA RID: 87722 RVA: 0x0031BC24 File Offset: 0x00319E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.HasData)
			{
				num += 2;
			}
			num += this.roguelikeLastInfos_.CalculateSize(RoguelikeLastInfoResponse._repeated_roguelikeLastInfos_codec);
			if (this.tempRogueArchiveInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TempRogueArchiveInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060156AB RID: 87723 RVA: 0x0031BC9C File Offset: 0x00319E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeLastInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.HasData)
			{
				this.HasData = other.HasData;
			}
			this.roguelikeLastInfos_.Add(other.roguelikeLastInfos_);
			if (other.tempRogueArchiveInfo_ != null)
			{
				if (this.tempRogueArchiveInfo_ == null)
				{
					this.TempRogueArchiveInfo = new RogueArchiveInfo();
				}
				this.TempRogueArchiveInfo.MergeFrom(other.TempRogueArchiveInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060156AC RID: 87724 RVA: 0x0031BD29 File Offset: 0x00319F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060156AD RID: 87725 RVA: 0x0031BD34 File Offset: 0x00319F34
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
				if (num <= 74U)
				{
					if (num == 32U)
					{
						this.HasData = input.ReadBool();
						continue;
					}
					if (num == 74U)
					{
						this.roguelikeLastInfos_.AddEntriesFrom(ref input, RoguelikeLastInfoResponse._repeated_roguelikeLastInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.tempRogueArchiveInfo_ == null)
						{
							this.TempRogueArchiveInfo = new RogueArchiveInfo();
						}
						input.ReadMessage(this.TempRogueArchiveInfo);
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

		// Token: 0x040080CF RID: 32975
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080D0 RID: 32976
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040080D1 RID: 32977
		private ErrorCode errorCode_;

		// Token: 0x040080D2 RID: 32978
		public const int HasDataFieldNumber = 4;

		// Token: 0x040080D3 RID: 32979
		private bool hasData_;

		// Token: 0x040080D4 RID: 32980
		public const int RoguelikeLastInfosFieldNumber = 9;

		// Token: 0x040080D5 RID: 32981
		private static readonly FieldCodec<RoguelikeLastInfo> _repeated_roguelikeLastInfos_codec = FieldCodec.ForMessage<RoguelikeLastInfo>(74U, RoguelikeLastInfo.Parser);

		// Token: 0x040080D6 RID: 32982
		private readonly RepeatedField<RoguelikeLastInfo> roguelikeLastInfos_ = new RepeatedField<RoguelikeLastInfo>();

		// Token: 0x040080D7 RID: 32983
		public const int TempRogueArchiveInfoFieldNumber = 13;

		// Token: 0x040080D8 RID: 32984
		private RogueArchiveInfo tempRogueArchiveInfo_;
	}
}
