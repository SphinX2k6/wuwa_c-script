using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013EB RID: 5099
	[NetMessage(EMessageId.TrackMoonSettleResponse)]
	public sealed class TrackMoonSettleResponse : IMessage<TrackMoonSettleResponse>, IMessage, IEquatable<TrackMoonSettleResponse>, IDeepCloneable<TrackMoonSettleResponse>, IBufferMessage
	{
		// Token: 0x0601B053 RID: 110675 RVA: 0x003E9962 File Offset: 0x003E7B62
		[NullableContext(1)]
		public static TrackMoonSettleResponse Create()
		{
			return new TrackMoonSettleResponse();
		}

		// Token: 0x17005B0C RID: 23308
		// (get) Token: 0x0601B054 RID: 110676 RVA: 0x003E9969 File Offset: 0x003E7B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B0D RID: 23309
		// (get) Token: 0x0601B055 RID: 110677 RVA: 0x003E996C File Offset: 0x003E7B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonSettleResponse.Descriptor;
			}
		}

		// Token: 0x0601B056 RID: 110678 RVA: 0x003E9973 File Offset: 0x003E7B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonSettleResponse()
		{
		}

		// Token: 0x0601B057 RID: 110679 RVA: 0x003E997C File Offset: 0x003E7B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonSettleResponse(TrackMoonSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.popularTotal_ = other.popularTotal_;
			this.goldTotal_ = other.goldTotal_;
			this.wishTotal_ = other.wishTotal_;
			this.entrustDo_ = other.entrustDo_;
			this.entrustDoMost_ = ((other.entrustDoMost_ != null) ? other.entrustDoMost_.Clone() : null);
			this.alwaysRoleId_ = ((other.alwaysRoleId_ != null) ? other.alwaysRoleId_.Clone() : null);
			this.mostLikeRole_ = ((other.mostLikeRole_ != null) ? other.mostLikeRole_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B058 RID: 110680 RVA: 0x003E9A30 File Offset: 0x003E7C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonSettleResponse Clone()
		{
			return new TrackMoonSettleResponse(this);
		}

		// Token: 0x17005B0E RID: 23310
		// (get) Token: 0x0601B059 RID: 110681 RVA: 0x003E9A38 File Offset: 0x003E7C38
		// (set) Token: 0x0601B05A RID: 110682 RVA: 0x003E9A40 File Offset: 0x003E7C40
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

		// Token: 0x17005B0F RID: 23311
		// (get) Token: 0x0601B05B RID: 110683 RVA: 0x003E9A49 File Offset: 0x003E7C49
		// (set) Token: 0x0601B05C RID: 110684 RVA: 0x003E9A51 File Offset: 0x003E7C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PopularTotal
		{
			get
			{
				return this.popularTotal_;
			}
			set
			{
				this.popularTotal_ = value;
			}
		}

		// Token: 0x17005B10 RID: 23312
		// (get) Token: 0x0601B05D RID: 110685 RVA: 0x003E9A5A File Offset: 0x003E7C5A
		// (set) Token: 0x0601B05E RID: 110686 RVA: 0x003E9A62 File Offset: 0x003E7C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoldTotal
		{
			get
			{
				return this.goldTotal_;
			}
			set
			{
				this.goldTotal_ = value;
			}
		}

		// Token: 0x17005B11 RID: 23313
		// (get) Token: 0x0601B05F RID: 110687 RVA: 0x003E9A6B File Offset: 0x003E7C6B
		// (set) Token: 0x0601B060 RID: 110688 RVA: 0x003E9A73 File Offset: 0x003E7C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WishTotal
		{
			get
			{
				return this.wishTotal_;
			}
			set
			{
				this.wishTotal_ = value;
			}
		}

		// Token: 0x17005B12 RID: 23314
		// (get) Token: 0x0601B061 RID: 110689 RVA: 0x003E9A7C File Offset: 0x003E7C7C
		// (set) Token: 0x0601B062 RID: 110690 RVA: 0x003E9A84 File Offset: 0x003E7C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustDo
		{
			get
			{
				return this.entrustDo_;
			}
			set
			{
				this.entrustDo_ = value;
			}
		}

		// Token: 0x17005B13 RID: 23315
		// (get) Token: 0x0601B063 RID: 110691 RVA: 0x003E9A8D File Offset: 0x003E7C8D
		// (set) Token: 0x0601B064 RID: 110692 RVA: 0x003E9A95 File Offset: 0x003E7C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleInfo EntrustDoMost
		{
			get
			{
				return this.entrustDoMost_;
			}
			set
			{
				this.entrustDoMost_ = value;
			}
		}

		// Token: 0x17005B14 RID: 23316
		// (get) Token: 0x0601B065 RID: 110693 RVA: 0x003E9A9E File Offset: 0x003E7C9E
		// (set) Token: 0x0601B066 RID: 110694 RVA: 0x003E9AA6 File Offset: 0x003E7CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleInfo AlwaysRoleId
		{
			get
			{
				return this.alwaysRoleId_;
			}
			set
			{
				this.alwaysRoleId_ = value;
			}
		}

		// Token: 0x17005B15 RID: 23317
		// (get) Token: 0x0601B067 RID: 110695 RVA: 0x003E9AAF File Offset: 0x003E7CAF
		// (set) Token: 0x0601B068 RID: 110696 RVA: 0x003E9AB7 File Offset: 0x003E7CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleInfo MostLikeRole
		{
			get
			{
				return this.mostLikeRole_;
			}
			set
			{
				this.mostLikeRole_ = value;
			}
		}

		// Token: 0x0601B069 RID: 110697 RVA: 0x003E9AC0 File Offset: 0x003E7CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonSettleResponse);
		}

		// Token: 0x0601B06A RID: 110698 RVA: 0x003E9AD0 File Offset: 0x003E7CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.PopularTotal == other.PopularTotal && this.GoldTotal == other.GoldTotal && this.WishTotal == other.WishTotal && this.EntrustDo == other.EntrustDo && object.Equals(this.EntrustDoMost, other.EntrustDoMost) && object.Equals(this.AlwaysRoleId, other.AlwaysRoleId) && object.Equals(this.MostLikeRole, other.MostLikeRole) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B06B RID: 110699 RVA: 0x003E9B88 File Offset: 0x003E7D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.PopularTotal != 0)
			{
				num ^= this.PopularTotal.GetHashCode();
			}
			if (this.GoldTotal != 0)
			{
				num ^= this.GoldTotal.GetHashCode();
			}
			if (this.WishTotal != 0)
			{
				num ^= this.WishTotal.GetHashCode();
			}
			if (this.EntrustDo != 0)
			{
				num ^= this.EntrustDo.GetHashCode();
			}
			if (this.entrustDoMost_ != null)
			{
				num ^= this.EntrustDoMost.GetHashCode();
			}
			if (this.alwaysRoleId_ != null)
			{
				num ^= this.AlwaysRoleId.GetHashCode();
			}
			if (this.mostLikeRole_ != null)
			{
				num ^= this.MostLikeRole.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B06C RID: 110700 RVA: 0x003E9C73 File Offset: 0x003E7E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B06D RID: 110701 RVA: 0x003E9C80 File Offset: 0x003E7E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B06E RID: 110702 RVA: 0x003E9C8C File Offset: 0x003E7E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PopularTotal != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PopularTotal);
			}
			if (this.alwaysRoleId_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AlwaysRoleId);
			}
			if (this.GoldTotal != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GoldTotal);
			}
			if (this.WishTotal != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.WishTotal);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.mostLikeRole_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.MostLikeRole);
			}
			if (this.EntrustDo != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.EntrustDo);
			}
			if (this.entrustDoMost_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.EntrustDoMost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B06F RID: 110703 RVA: 0x003E9D8C File Offset: 0x003E7F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.PopularTotal != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PopularTotal);
			}
			if (this.GoldTotal != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoldTotal);
			}
			if (this.WishTotal != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WishTotal);
			}
			if (this.EntrustDo != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustDo);
			}
			if (this.entrustDoMost_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntrustDoMost);
			}
			if (this.alwaysRoleId_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AlwaysRoleId);
			}
			if (this.mostLikeRole_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MostLikeRole);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B070 RID: 110704 RVA: 0x003E9E74 File Offset: 0x003E8074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonSettleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.PopularTotal != 0)
			{
				this.PopularTotal = other.PopularTotal;
			}
			if (other.GoldTotal != 0)
			{
				this.GoldTotal = other.GoldTotal;
			}
			if (other.WishTotal != 0)
			{
				this.WishTotal = other.WishTotal;
			}
			if (other.EntrustDo != 0)
			{
				this.EntrustDo = other.EntrustDo;
			}
			if (other.entrustDoMost_ != null)
			{
				if (this.entrustDoMost_ == null)
				{
					this.EntrustDoMost = new SettleInfo();
				}
				this.EntrustDoMost.MergeFrom(other.EntrustDoMost);
			}
			if (other.alwaysRoleId_ != null)
			{
				if (this.alwaysRoleId_ == null)
				{
					this.AlwaysRoleId = new SettleInfo();
				}
				this.AlwaysRoleId.MergeFrom(other.AlwaysRoleId);
			}
			if (other.mostLikeRole_ != null)
			{
				if (this.mostLikeRole_ == null)
				{
					this.MostLikeRole = new SettleInfo();
				}
				this.MostLikeRole.MergeFrom(other.MostLikeRole);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B071 RID: 110705 RVA: 0x003E9F84 File Offset: 0x003E8184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B072 RID: 110706 RVA: 0x003E9F90 File Offset: 0x003E8190
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
				if (num <= 64U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.PopularTotal = input.ReadInt32();
							continue;
						}
						if (num == 18U)
						{
							if (this.alwaysRoleId_ == null)
							{
								this.AlwaysRoleId = new SettleInfo();
							}
							input.ReadMessage(this.AlwaysRoleId);
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.GoldTotal = input.ReadInt32();
							continue;
						}
						if (num == 64U)
						{
							this.WishTotal = input.ReadInt32();
							continue;
						}
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
						if (this.mostLikeRole_ == null)
						{
							this.MostLikeRole = new SettleInfo();
						}
						input.ReadMessage(this.MostLikeRole);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.EntrustDo = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.entrustDoMost_ == null)
						{
							this.EntrustDoMost = new SettleInfo();
						}
						input.ReadMessage(this.EntrustDoMost);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009C63 RID: 40035
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C64 RID: 40036
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04009C65 RID: 40037
		private ErrorCode errorCode_;

		// Token: 0x04009C66 RID: 40038
		public const int PopularTotalFieldNumber = 1;

		// Token: 0x04009C67 RID: 40039
		private int popularTotal_;

		// Token: 0x04009C68 RID: 40040
		public const int GoldTotalFieldNumber = 6;

		// Token: 0x04009C69 RID: 40041
		private int goldTotal_;

		// Token: 0x04009C6A RID: 40042
		public const int WishTotalFieldNumber = 8;

		// Token: 0x04009C6B RID: 40043
		private int wishTotal_;

		// Token: 0x04009C6C RID: 40044
		public const int EntrustDoFieldNumber = 12;

		// Token: 0x04009C6D RID: 40045
		private int entrustDo_;

		// Token: 0x04009C6E RID: 40046
		public const int EntrustDoMostFieldNumber = 14;

		// Token: 0x04009C6F RID: 40047
		private SettleInfo entrustDoMost_;

		// Token: 0x04009C70 RID: 40048
		public const int AlwaysRoleIdFieldNumber = 2;

		// Token: 0x04009C71 RID: 40049
		private SettleInfo alwaysRoleId_;

		// Token: 0x04009C72 RID: 40050
		public const int MostLikeRoleFieldNumber = 10;

		// Token: 0x04009C73 RID: 40051
		private SettleInfo mostLikeRole_;
	}
}
