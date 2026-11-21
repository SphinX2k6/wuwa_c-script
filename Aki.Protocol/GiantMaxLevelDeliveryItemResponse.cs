using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CC RID: 1740
	[NetMessage(EMessageId.GiantMaxLevelDeliveryItemResponse)]
	public sealed class GiantMaxLevelDeliveryItemResponse : IMessage<GiantMaxLevelDeliveryItemResponse>, IMessage, IEquatable<GiantMaxLevelDeliveryItemResponse>, IDeepCloneable<GiantMaxLevelDeliveryItemResponse>, IBufferMessage
	{
		// Token: 0x06009F48 RID: 40776 RVA: 0x001823BD File Offset: 0x001805BD
		[NullableContext(1)]
		public static GiantMaxLevelDeliveryItemResponse Create()
		{
			return new GiantMaxLevelDeliveryItemResponse();
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06009F49 RID: 40777 RVA: 0x001823C4 File Offset: 0x001805C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x06009F4A RID: 40778 RVA: 0x001823C7 File Offset: 0x001805C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantMaxLevelDeliveryItemResponse.Descriptor;
			}
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x001823CE File Offset: 0x001805CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantMaxLevelDeliveryItemResponse()
		{
		}

		// Token: 0x06009F4C RID: 40780 RVA: 0x001823D8 File Offset: 0x001805D8
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

		// Token: 0x06009F4D RID: 40781 RVA: 0x0018243C File Offset: 0x0018063C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantMaxLevelDeliveryItemResponse Clone()
		{
			return new GiantMaxLevelDeliveryItemResponse(this);
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06009F4E RID: 40782 RVA: 0x00182444 File Offset: 0x00180644
		// (set) Token: 0x06009F4F RID: 40783 RVA: 0x0018244C File Offset: 0x0018064C
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

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x06009F50 RID: 40784 RVA: 0x00182455 File Offset: 0x00180655
		// (set) Token: 0x06009F51 RID: 40785 RVA: 0x0018245D File Offset: 0x0018065D
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

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06009F52 RID: 40786 RVA: 0x00182466 File Offset: 0x00180666
		// (set) Token: 0x06009F53 RID: 40787 RVA: 0x0018246E File Offset: 0x0018066E
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

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06009F54 RID: 40788 RVA: 0x00182477 File Offset: 0x00180677
		// (set) Token: 0x06009F55 RID: 40789 RVA: 0x0018247F File Offset: 0x0018067F
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

		// Token: 0x06009F56 RID: 40790 RVA: 0x00182488 File Offset: 0x00180688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantMaxLevelDeliveryItemResponse);
		}

		// Token: 0x06009F57 RID: 40791 RVA: 0x00182498 File Offset: 0x00180698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantMaxLevelDeliveryItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.GiantEcoInfo, other.GiantEcoInfo) && this.TopQuality == other.TopQuality && this.HasReward == other.HasReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F58 RID: 40792 RVA: 0x00182508 File Offset: 0x00180708
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

		// Token: 0x06009F59 RID: 40793 RVA: 0x00182595 File Offset: 0x00180795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F5A RID: 40794 RVA: 0x001825A2 File Offset: 0x001807A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F5B RID: 40795 RVA: 0x001825AC File Offset: 0x001807AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.giantEcoInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GiantEcoInfo);
			}
			if (this.TopQuality != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TopQuality);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
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

		// Token: 0x06009F5C RID: 40796 RVA: 0x00182640 File Offset: 0x00180840
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

		// Token: 0x06009F5D RID: 40797 RVA: 0x001826BC File Offset: 0x001808BC
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

		// Token: 0x06009F5E RID: 40798 RVA: 0x0018274C File Offset: 0x0018094C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F5F RID: 40799 RVA: 0x00182758 File Offset: 0x00180958
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
				if (num <= 40U)
				{
					if (num == 10U)
					{
						if (this.giantEcoInfo_ == null)
						{
							this.GiantEcoInfo = new GiantEcoInfoPb();
						}
						input.ReadMessage(this.GiantEcoInfo);
						continue;
					}
					if (num == 40U)
					{
						this.TopQuality = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
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

		// Token: 0x04004AB7 RID: 19127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AB8 RID: 19128
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004AB9 RID: 19129
		private ErrorCode errorCode_;

		// Token: 0x04004ABA RID: 19130
		public const int GiantEcoInfoFieldNumber = 1;

		// Token: 0x04004ABB RID: 19131
		private GiantEcoInfoPb giantEcoInfo_;

		// Token: 0x04004ABC RID: 19132
		public const int TopQualityFieldNumber = 5;

		// Token: 0x04004ABD RID: 19133
		private int topQuality_;

		// Token: 0x04004ABE RID: 19134
		public const int HasRewardFieldNumber = 14;

		// Token: 0x04004ABF RID: 19135
		private bool hasReward_;
	}
}
