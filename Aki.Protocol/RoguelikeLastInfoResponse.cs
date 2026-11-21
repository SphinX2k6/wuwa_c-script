using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F94 RID: 3988
	[NetMessage(EMessageId.RoguelikeLastInfoResponse)]
	public sealed class RoguelikeLastInfoResponse : IMessage<RoguelikeLastInfoResponse>, IMessage, IEquatable<RoguelikeLastInfoResponse>, IDeepCloneable<RoguelikeLastInfoResponse>, IBufferMessage
	{
		// Token: 0x060155B2 RID: 87474 RVA: 0x0031A302 File Offset: 0x00318502
		[NullableContext(1)]
		public static RoguelikeLastInfoResponse Create()
		{
			return new RoguelikeLastInfoResponse();
		}

		// Token: 0x17004736 RID: 18230
		// (get) Token: 0x060155B3 RID: 87475 RVA: 0x0031A309 File Offset: 0x00318509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004737 RID: 18231
		// (get) Token: 0x060155B4 RID: 87476 RVA: 0x0031A30C File Offset: 0x0031850C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeLastInfoResponse.Descriptor;
			}
		}

		// Token: 0x060155B5 RID: 87477 RVA: 0x0031A313 File Offset: 0x00318513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfoResponse()
		{
		}

		// Token: 0x060155B6 RID: 87478 RVA: 0x0031A328 File Offset: 0x00318528
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

		// Token: 0x060155B7 RID: 87479 RVA: 0x0031A391 File Offset: 0x00318591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfoResponse Clone()
		{
			return new RoguelikeLastInfoResponse(this);
		}

		// Token: 0x17004738 RID: 18232
		// (get) Token: 0x060155B8 RID: 87480 RVA: 0x0031A399 File Offset: 0x00318599
		// (set) Token: 0x060155B9 RID: 87481 RVA: 0x0031A3A1 File Offset: 0x003185A1
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

		// Token: 0x17004739 RID: 18233
		// (get) Token: 0x060155BA RID: 87482 RVA: 0x0031A3AA File Offset: 0x003185AA
		// (set) Token: 0x060155BB RID: 87483 RVA: 0x0031A3B2 File Offset: 0x003185B2
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

		// Token: 0x1700473A RID: 18234
		// (get) Token: 0x060155BC RID: 87484 RVA: 0x0031A3BB File Offset: 0x003185BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoguelikeLastInfo> RoguelikeLastInfos
		{
			get
			{
				return this.roguelikeLastInfos_;
			}
		}

		// Token: 0x1700473B RID: 18235
		// (get) Token: 0x060155BD RID: 87485 RVA: 0x0031A3C3 File Offset: 0x003185C3
		// (set) Token: 0x060155BE RID: 87486 RVA: 0x0031A3CB File Offset: 0x003185CB
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

		// Token: 0x060155BF RID: 87487 RVA: 0x0031A3D4 File Offset: 0x003185D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeLastInfoResponse);
		}

		// Token: 0x060155C0 RID: 87488 RVA: 0x0031A3E4 File Offset: 0x003185E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeLastInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.HasData == other.HasData && this.roguelikeLastInfos_.Equals(other.roguelikeLastInfos_) && object.Equals(this.TempRogueArchiveInfo, other.TempRogueArchiveInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060155C1 RID: 87489 RVA: 0x0031A458 File Offset: 0x00318658
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

		// Token: 0x060155C2 RID: 87490 RVA: 0x0031A4DA File Offset: 0x003186DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060155C3 RID: 87491 RVA: 0x0031A4E7 File Offset: 0x003186E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060155C4 RID: 87492 RVA: 0x0031A4F0 File Offset: 0x003186F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.tempRogueArchiveInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TempRogueArchiveInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.roguelikeLastInfos_.WriteTo(ref output, RoguelikeLastInfoResponse._repeated_roguelikeLastInfos_codec);
			if (this.HasData)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.HasData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060155C5 RID: 87493 RVA: 0x0031A578 File Offset: 0x00318778
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

		// Token: 0x060155C6 RID: 87494 RVA: 0x0031A5F0 File Offset: 0x003187F0
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

		// Token: 0x060155C7 RID: 87495 RVA: 0x0031A67D File Offset: 0x0031887D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060155C8 RID: 87496 RVA: 0x0031A688 File Offset: 0x00318888
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
				if (num <= 56U)
				{
					if (num == 42U)
					{
						if (this.tempRogueArchiveInfo_ == null)
						{
							this.TempRogueArchiveInfo = new RogueArchiveInfo();
						}
						input.ReadMessage(this.TempRogueArchiveInfo);
						continue;
					}
					if (num == 56U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.roguelikeLastInfos_.AddEntriesFrom(ref input, RoguelikeLastInfoResponse._repeated_roguelikeLastInfos_codec);
						continue;
					}
					if (num == 120U)
					{
						this.HasData = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040080F9 RID: 33017
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080FA RID: 33018
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040080FB RID: 33019
		private ErrorCode errorCode_;

		// Token: 0x040080FC RID: 33020
		public const int HasDataFieldNumber = 15;

		// Token: 0x040080FD RID: 33021
		private bool hasData_;

		// Token: 0x040080FE RID: 33022
		public const int RoguelikeLastInfosFieldNumber = 14;

		// Token: 0x040080FF RID: 33023
		private static readonly FieldCodec<RoguelikeLastInfo> _repeated_roguelikeLastInfos_codec = FieldCodec.ForMessage<RoguelikeLastInfo>(114U, RoguelikeLastInfo.Parser);

		// Token: 0x04008100 RID: 33024
		private readonly RepeatedField<RoguelikeLastInfo> roguelikeLastInfos_ = new RepeatedField<RoguelikeLastInfo>();

		// Token: 0x04008101 RID: 33025
		public const int TempRogueArchiveInfoFieldNumber = 5;

		// Token: 0x04008102 RID: 33026
		private RogueArchiveInfo tempRogueArchiveInfo_;
	}
}
