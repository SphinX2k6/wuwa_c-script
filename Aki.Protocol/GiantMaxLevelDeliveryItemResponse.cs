using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E0 RID: 1760
	[NetMessage(EMessageId.GiantMaxLevelDeliveryItemResponse)]
	public sealed class GiantMaxLevelDeliveryItemResponse : IMessage<GiantMaxLevelDeliveryItemResponse>, IMessage, IEquatable<GiantMaxLevelDeliveryItemResponse>, IDeepCloneable<GiantMaxLevelDeliveryItemResponse>, IBufferMessage
	{
		// Token: 0x0600A09E RID: 41118 RVA: 0x00184DF2 File Offset: 0x00182FF2
		[NullableContext(1)]
		public static GiantMaxLevelDeliveryItemResponse Create()
		{
			return new GiantMaxLevelDeliveryItemResponse();
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x0600A09F RID: 41119 RVA: 0x00184DF9 File Offset: 0x00182FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x0600A0A0 RID: 41120 RVA: 0x00184DFC File Offset: 0x00182FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantMaxLevelDeliveryItemResponse.Descriptor;
			}
		}

		// Token: 0x0600A0A1 RID: 41121 RVA: 0x00184E03 File Offset: 0x00183003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantMaxLevelDeliveryItemResponse()
		{
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x00184E0C File Offset: 0x0018300C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantMaxLevelDeliveryItemResponse(GiantMaxLevelDeliveryItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.giantEcoInfo_ = ((other.giantEcoInfo_ != null) ? other.giantEcoInfo_.Clone() : null);
			this.topQuality_ = other.topQuality_;
			this.hasReward_ = other.hasReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x00184E70 File Offset: 0x00183070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantMaxLevelDeliveryItemResponse Clone()
		{
			return new GiantMaxLevelDeliveryItemResponse(this);
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x0600A0A4 RID: 41124 RVA: 0x00184E78 File Offset: 0x00183078
		// (set) Token: 0x0600A0A5 RID: 41125 RVA: 0x00184E80 File Offset: 0x00183080
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

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x0600A0A6 RID: 41126 RVA: 0x00184E89 File Offset: 0x00183089
		// (set) Token: 0x0600A0A7 RID: 41127 RVA: 0x00184E91 File Offset: 0x00183091
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

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x0600A0A8 RID: 41128 RVA: 0x00184E9A File Offset: 0x0018309A
		// (set) Token: 0x0600A0A9 RID: 41129 RVA: 0x00184EA2 File Offset: 0x001830A2
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

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x0600A0AA RID: 41130 RVA: 0x00184EAB File Offset: 0x001830AB
		// (set) Token: 0x0600A0AB RID: 41131 RVA: 0x00184EB3 File Offset: 0x001830B3
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

		// Token: 0x0600A0AC RID: 41132 RVA: 0x00184EBC File Offset: 0x001830BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantMaxLevelDeliveryItemResponse);
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x00184ECC File Offset: 0x001830CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantMaxLevelDeliveryItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.GiantEcoInfo, other.GiantEcoInfo) && this.TopQuality == other.TopQuality && this.HasReward == other.HasReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0AE RID: 41134 RVA: 0x00184F3C File Offset: 0x0018313C
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

		// Token: 0x0600A0AF RID: 41135 RVA: 0x00184FC9 File Offset: 0x001831C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x00184FD6 File Offset: 0x001831D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0B1 RID: 41137 RVA: 0x00184FE0 File Offset: 0x001831E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.TopQuality != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TopQuality);
			}
			if (this.giantEcoInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.GiantEcoInfo);
			}
			if (this.HasReward)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.HasReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0B2 RID: 41138 RVA: 0x00185074 File Offset: 0x00183274
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

		// Token: 0x0600A0B3 RID: 41139 RVA: 0x001850F0 File Offset: 0x001832F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantMaxLevelDeliveryItemResponse other)
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

		// Token: 0x0600A0B4 RID: 41140 RVA: 0x00185180 File Offset: 0x00183380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0B5 RID: 41141 RVA: 0x0018518C File Offset: 0x0018338C
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
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.TopQuality = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						if (this.giantEcoInfo_ == null)
						{
							this.GiantEcoInfo = new GiantEcoInfoPb();
						}
						input.ReadMessage(this.GiantEcoInfo);
						continue;
					}
					if (num == 112U)
					{
						this.HasReward = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004ABE RID: 19134
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ABF RID: 19135
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004AC0 RID: 19136
		private ErrorCode errorCode_;

		// Token: 0x04004AC1 RID: 19137
		public const int GiantEcoInfoFieldNumber = 6;

		// Token: 0x04004AC2 RID: 19138
		private GiantEcoInfoPb giantEcoInfo_;

		// Token: 0x04004AC3 RID: 19139
		public const int TopQualityFieldNumber = 4;

		// Token: 0x04004AC4 RID: 19140
		private int topQuality_;

		// Token: 0x04004AC5 RID: 19141
		public const int HasRewardFieldNumber = 14;

		// Token: 0x04004AC6 RID: 19142
		private bool hasReward_;
	}
}
