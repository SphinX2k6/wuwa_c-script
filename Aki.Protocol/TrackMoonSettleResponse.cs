using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145E RID: 5214
	[NetMessage(EMessageId.TrackMoonSettleResponse)]
	public sealed class TrackMoonSettleResponse : IMessage<TrackMoonSettleResponse>, IMessage, IEquatable<TrackMoonSettleResponse>, IDeepCloneable<TrackMoonSettleResponse>, IBufferMessage
	{
		// Token: 0x0601BADE RID: 113374 RVA: 0x00404C2E File Offset: 0x00402E2E
		[NullableContext(1)]
		public static TrackMoonSettleResponse Create()
		{
			return new TrackMoonSettleResponse();
		}

		// Token: 0x17005DA1 RID: 23969
		// (get) Token: 0x0601BADF RID: 113375 RVA: 0x00404C35 File Offset: 0x00402E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DA2 RID: 23970
		// (get) Token: 0x0601BAE0 RID: 113376 RVA: 0x00404C38 File Offset: 0x00402E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonSettleResponse.Descriptor;
			}
		}

		// Token: 0x0601BAE1 RID: 113377 RVA: 0x00404C3F File Offset: 0x00402E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonSettleResponse()
		{
		}

		// Token: 0x0601BAE2 RID: 113378 RVA: 0x00404C48 File Offset: 0x00402E48
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

		// Token: 0x0601BAE3 RID: 113379 RVA: 0x00404CFC File Offset: 0x00402EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonSettleResponse Clone()
		{
			return new TrackMoonSettleResponse(this);
		}

		// Token: 0x17005DA3 RID: 23971
		// (get) Token: 0x0601BAE4 RID: 113380 RVA: 0x00404D04 File Offset: 0x00402F04
		// (set) Token: 0x0601BAE5 RID: 113381 RVA: 0x00404D0C File Offset: 0x00402F0C
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

		// Token: 0x17005DA4 RID: 23972
		// (get) Token: 0x0601BAE6 RID: 113382 RVA: 0x00404D15 File Offset: 0x00402F15
		// (set) Token: 0x0601BAE7 RID: 113383 RVA: 0x00404D1D File Offset: 0x00402F1D
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

		// Token: 0x17005DA5 RID: 23973
		// (get) Token: 0x0601BAE8 RID: 113384 RVA: 0x00404D26 File Offset: 0x00402F26
		// (set) Token: 0x0601BAE9 RID: 113385 RVA: 0x00404D2E File Offset: 0x00402F2E
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

		// Token: 0x17005DA6 RID: 23974
		// (get) Token: 0x0601BAEA RID: 113386 RVA: 0x00404D37 File Offset: 0x00402F37
		// (set) Token: 0x0601BAEB RID: 113387 RVA: 0x00404D3F File Offset: 0x00402F3F
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

		// Token: 0x17005DA7 RID: 23975
		// (get) Token: 0x0601BAEC RID: 113388 RVA: 0x00404D48 File Offset: 0x00402F48
		// (set) Token: 0x0601BAED RID: 113389 RVA: 0x00404D50 File Offset: 0x00402F50
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

		// Token: 0x17005DA8 RID: 23976
		// (get) Token: 0x0601BAEE RID: 113390 RVA: 0x00404D59 File Offset: 0x00402F59
		// (set) Token: 0x0601BAEF RID: 113391 RVA: 0x00404D61 File Offset: 0x00402F61
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

		// Token: 0x17005DA9 RID: 23977
		// (get) Token: 0x0601BAF0 RID: 113392 RVA: 0x00404D6A File Offset: 0x00402F6A
		// (set) Token: 0x0601BAF1 RID: 113393 RVA: 0x00404D72 File Offset: 0x00402F72
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

		// Token: 0x17005DAA RID: 23978
		// (get) Token: 0x0601BAF2 RID: 113394 RVA: 0x00404D7B File Offset: 0x00402F7B
		// (set) Token: 0x0601BAF3 RID: 113395 RVA: 0x00404D83 File Offset: 0x00402F83
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

		// Token: 0x0601BAF4 RID: 113396 RVA: 0x00404D8C File Offset: 0x00402F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonSettleResponse);
		}

		// Token: 0x0601BAF5 RID: 113397 RVA: 0x00404D9C File Offset: 0x00402F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.PopularTotal == other.PopularTotal && this.GoldTotal == other.GoldTotal && this.WishTotal == other.WishTotal && this.EntrustDo == other.EntrustDo && object.Equals(this.EntrustDoMost, other.EntrustDoMost) && object.Equals(this.AlwaysRoleId, other.AlwaysRoleId) && object.Equals(this.MostLikeRole, other.MostLikeRole) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BAF6 RID: 113398 RVA: 0x00404E54 File Offset: 0x00403054
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

		// Token: 0x0601BAF7 RID: 113399 RVA: 0x00404F3F File Offset: 0x0040313F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BAF8 RID: 113400 RVA: 0x00404F4C File Offset: 0x0040314C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BAF9 RID: 113401 RVA: 0x00404F58 File Offset: 0x00403158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.mostLikeRole_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MostLikeRole);
			}
			if (this.entrustDoMost_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.EntrustDoMost);
			}
			if (this.EntrustDo != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.EntrustDo);
			}
			if (this.alwaysRoleId_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.AlwaysRoleId);
			}
			if (this.WishTotal != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WishTotal);
			}
			if (this.GoldTotal != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.GoldTotal);
			}
			if (this.PopularTotal != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PopularTotal);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BAFA RID: 113402 RVA: 0x00405058 File Offset: 0x00403258
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

		// Token: 0x0601BAFB RID: 113403 RVA: 0x00405140 File Offset: 0x00403340
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

		// Token: 0x0601BAFC RID: 113404 RVA: 0x00405250 File Offset: 0x00403450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BAFD RID: 113405 RVA: 0x0040525C File Offset: 0x0040345C
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
				if (num <= 48U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num == 18U)
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
						if (num == 26U)
						{
							if (this.entrustDoMost_ == null)
							{
								this.EntrustDoMost = new SettleInfo();
							}
							input.ReadMessage(this.EntrustDoMost);
							continue;
						}
						if (num == 48U)
						{
							this.EntrustDo = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 66U)
					{
						if (this.alwaysRoleId_ == null)
						{
							this.AlwaysRoleId = new SettleInfo();
						}
						input.ReadMessage(this.AlwaysRoleId);
						continue;
					}
					if (num == 72U)
					{
						this.WishTotal = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.GoldTotal = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.PopularTotal = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A0AA RID: 41130
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0AB RID: 41131
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400A0AC RID: 41132
		private ErrorCode errorCode_;

		// Token: 0x0400A0AD RID: 41133
		public const int PopularTotalFieldNumber = 15;

		// Token: 0x0400A0AE RID: 41134
		private int popularTotal_;

		// Token: 0x0400A0AF RID: 41135
		public const int GoldTotalFieldNumber = 11;

		// Token: 0x0400A0B0 RID: 41136
		private int goldTotal_;

		// Token: 0x0400A0B1 RID: 41137
		public const int WishTotalFieldNumber = 9;

		// Token: 0x0400A0B2 RID: 41138
		private int wishTotal_;

		// Token: 0x0400A0B3 RID: 41139
		public const int EntrustDoFieldNumber = 6;

		// Token: 0x0400A0B4 RID: 41140
		private int entrustDo_;

		// Token: 0x0400A0B5 RID: 41141
		public const int EntrustDoMostFieldNumber = 3;

		// Token: 0x0400A0B6 RID: 41142
		private SettleInfo entrustDoMost_;

		// Token: 0x0400A0B7 RID: 41143
		public const int AlwaysRoleIdFieldNumber = 8;

		// Token: 0x0400A0B8 RID: 41144
		private SettleInfo alwaysRoleId_;

		// Token: 0x0400A0B9 RID: 41145
		public const int MostLikeRoleFieldNumber = 2;

		// Token: 0x0400A0BA RID: 41146
		private SettleInfo mostLikeRole_;
	}
}
