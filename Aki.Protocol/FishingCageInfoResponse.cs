using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054D RID: 1357
	[NetMessage(EMessageId.FishingCageInfoResponse)]
	public sealed class FishingCageInfoResponse : IMessage<FishingCageInfoResponse>, IMessage, IEquatable<FishingCageInfoResponse>, IDeepCloneable<FishingCageInfoResponse>, IBufferMessage
	{
		// Token: 0x06007ED9 RID: 32473 RVA: 0x00132F3D File Offset: 0x0013113D
		[NullableContext(1)]
		public static FishingCageInfoResponse Create()
		{
			return new FishingCageInfoResponse();
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x06007EDA RID: 32474 RVA: 0x00132F44 File Offset: 0x00131144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06007EDB RID: 32475 RVA: 0x00132F47 File Offset: 0x00131147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCageInfoResponse.Descriptor;
			}
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x00132F4E File Offset: 0x0013114E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoResponse()
		{
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x00132F58 File Offset: 0x00131158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoResponse(FishingCageInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fishCageInfo_ = ((other.fishCageInfo_ != null) ? other.fishCageInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EDE RID: 32478 RVA: 0x00132FA4 File Offset: 0x001311A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoResponse Clone()
		{
			return new FishingCageInfoResponse(this);
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06007EDF RID: 32479 RVA: 0x00132FAC File Offset: 0x001311AC
		// (set) Token: 0x06007EE0 RID: 32480 RVA: 0x00132FB4 File Offset: 0x001311B4
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

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x06007EE1 RID: 32481 RVA: 0x00132FBD File Offset: 0x001311BD
		// (set) Token: 0x06007EE2 RID: 32482 RVA: 0x00132FC5 File Offset: 0x001311C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishCage FishCageInfo
		{
			get
			{
				return this.fishCageInfo_;
			}
			set
			{
				this.fishCageInfo_ = value;
			}
		}

		// Token: 0x06007EE3 RID: 32483 RVA: 0x00132FCE File Offset: 0x001311CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCageInfoResponse);
		}

		// Token: 0x06007EE4 RID: 32484 RVA: 0x00132FDC File Offset: 0x001311DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCageInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.FishCageInfo, other.FishCageInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007EE5 RID: 32485 RVA: 0x0013302C File Offset: 0x0013122C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.fishCageInfo_ != null)
			{
				num ^= this.FishCageInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007EE6 RID: 32486 RVA: 0x00133087 File Offset: 0x00131287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007EE7 RID: 32487 RVA: 0x00133094 File Offset: 0x00131294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x001330A0 File Offset: 0x001312A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishCageInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.FishCageInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007EE9 RID: 32489 RVA: 0x001330FC File Offset: 0x001312FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.fishCageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FishCageInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007EEA RID: 32490 RVA: 0x00133154 File Offset: 0x00131354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCageInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.fishCageInfo_ != null)
			{
				if (this.fishCageInfo_ == null)
				{
					this.FishCageInfo = new OneFishCage();
				}
				this.FishCageInfo.MergeFrom(other.FishCageInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007EEB RID: 32491 RVA: 0x001331BC File Offset: 0x001313BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EEC RID: 32492 RVA: 0x001331C8 File Offset: 0x001313C8
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.fishCageInfo_ == null)
					{
						this.FishCageInfo = new OneFishCage();
					}
					input.ReadMessage(this.FishCageInfo);
				}
			}
		}

		// Token: 0x04004037 RID: 16439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004038 RID: 16440
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004039 RID: 16441
		private ErrorCode errorCode_;

		// Token: 0x0400403A RID: 16442
		public const int FishCageInfoFieldNumber = 4;

		// Token: 0x0400403B RID: 16443
		private OneFishCage fishCageInfo_;
	}
}
