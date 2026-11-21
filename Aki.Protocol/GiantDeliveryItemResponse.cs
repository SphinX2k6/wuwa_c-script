using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C4 RID: 1732
	[NetMessage(EMessageId.GiantDeliveryItemResponse)]
	public sealed class GiantDeliveryItemResponse : IMessage<GiantDeliveryItemResponse>, IMessage, IEquatable<GiantDeliveryItemResponse>, IDeepCloneable<GiantDeliveryItemResponse>, IBufferMessage
	{
		// Token: 0x06009EA1 RID: 40609 RVA: 0x00180CBE File Offset: 0x0017EEBE
		[NullableContext(1)]
		public static GiantDeliveryItemResponse Create()
		{
			return new GiantDeliveryItemResponse();
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x06009EA2 RID: 40610 RVA: 0x00180CC5 File Offset: 0x0017EEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x06009EA3 RID: 40611 RVA: 0x00180CC8 File Offset: 0x0017EEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantDeliveryItemResponse.Descriptor;
			}
		}

		// Token: 0x06009EA4 RID: 40612 RVA: 0x00180CCF File Offset: 0x0017EECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemResponse()
		{
		}

		// Token: 0x06009EA5 RID: 40613 RVA: 0x00180CD8 File Offset: 0x0017EED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemResponse(GiantDeliveryItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.giantEcoInfo_ = ((other.giantEcoInfo_ != null) ? other.giantEcoInfo_.Clone() : null);
			this.topQuality_ = other.topQuality_;
			this.hasReward_ = other.hasReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x00180D3C File Offset: 0x0017EF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemResponse Clone()
		{
			return new GiantDeliveryItemResponse(this);
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x06009EA7 RID: 40615 RVA: 0x00180D44 File Offset: 0x0017EF44
		// (set) Token: 0x06009EA8 RID: 40616 RVA: 0x00180D4C File Offset: 0x0017EF4C
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

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x06009EA9 RID: 40617 RVA: 0x00180D55 File Offset: 0x0017EF55
		// (set) Token: 0x06009EAA RID: 40618 RVA: 0x00180D5D File Offset: 0x0017EF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoInfoPb GiantEcoInfo
		{
			get
			{
				return this.giantEcoInfo_;
			}
			set
			{
				this.giantEcoInfo_ = value;
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x06009EAB RID: 40619 RVA: 0x00180D66 File Offset: 0x0017EF66
		// (set) Token: 0x06009EAC RID: 40620 RVA: 0x00180D6E File Offset: 0x0017EF6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TopQuality
		{
			get
			{
				return this.topQuality_;
			}
			set
			{
				this.topQuality_ = value;
			}
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x06009EAD RID: 40621 RVA: 0x00180D77 File Offset: 0x0017EF77
		// (set) Token: 0x06009EAE RID: 40622 RVA: 0x00180D7F File Offset: 0x0017EF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasReward
		{
			get
			{
				return this.hasReward_;
			}
			set
			{
				this.hasReward_ = value;
			}
		}

		// Token: 0x06009EAF RID: 40623 RVA: 0x00180D88 File Offset: 0x0017EF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantDeliveryItemResponse);
		}

		// Token: 0x06009EB0 RID: 40624 RVA: 0x00180D98 File Offset: 0x0017EF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantDeliveryItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.GiantEcoInfo, other.GiantEcoInfo) && this.TopQuality == other.TopQuality && this.HasReward == other.HasReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009EB1 RID: 40625 RVA: 0x00180E08 File Offset: 0x0017F008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.giantEcoInfo_ != null)
			{
				num ^= this.GiantEcoInfo.GetHashCode();
			}
			if (this.TopQuality != 0)
			{
				num ^= this.TopQuality.GetHashCode();
			}
			if (this.HasReward)
			{
				num ^= this.HasReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009EB2 RID: 40626 RVA: 0x00180E95 File Offset: 0x0017F095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009EB3 RID: 40627 RVA: 0x00180EA2 File Offset: 0x0017F0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EB4 RID: 40628 RVA: 0x00180EAC File Offset: 0x0017F0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasReward)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.HasReward);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.TopQuality != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TopQuality);
			}
			if (this.giantEcoInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.GiantEcoInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009EB5 RID: 40629 RVA: 0x00180F40 File Offset: 0x0017F140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.giantEcoInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GiantEcoInfo);
			}
			if (this.TopQuality != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TopQuality);
			}
			if (this.HasReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009EB6 RID: 40630 RVA: 0x00180FBC File Offset: 0x0017F1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantDeliveryItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.giantEcoInfo_ != null)
			{
				if (this.giantEcoInfo_ == null)
				{
					this.GiantEcoInfo = new GiantEcoInfoPb();
				}
				this.GiantEcoInfo.MergeFrom(other.GiantEcoInfo);
			}
			if (other.TopQuality != 0)
			{
				this.TopQuality = other.TopQuality;
			}
			if (other.HasReward)
			{
				this.HasReward = other.HasReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009EB7 RID: 40631 RVA: 0x0018104C File Offset: 0x0017F24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EB8 RID: 40632 RVA: 0x00181058 File Offset: 0x0017F258
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
					if (num == 24U)
					{
						this.HasReward = input.ReadBool();
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
					if (num == 80U)
					{
						this.TopQuality = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.giantEcoInfo_ == null)
						{
							this.GiantEcoInfo = new GiantEcoInfoPb();
						}
						input.ReadMessage(this.GiantEcoInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A85 RID: 19077
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A86 RID: 19078
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004A87 RID: 19079
		private ErrorCode errorCode_;

		// Token: 0x04004A88 RID: 19080
		public const int GiantEcoInfoFieldNumber = 14;

		// Token: 0x04004A89 RID: 19081
		private GiantEcoInfoPb giantEcoInfo_;

		// Token: 0x04004A8A RID: 19082
		public const int TopQualityFieldNumber = 10;

		// Token: 0x04004A8B RID: 19083
		private int topQuality_;

		// Token: 0x04004A8C RID: 19084
		public const int HasRewardFieldNumber = 3;

		// Token: 0x04004A8D RID: 19085
		private bool hasReward_;
	}
}
