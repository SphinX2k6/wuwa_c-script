using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D48 RID: 3400
	[NetMessage(EMessageId.PinballFriendRankResponse)]
	public sealed class PinballFriendRankResponse : IMessage<PinballFriendRankResponse>, IMessage, IEquatable<PinballFriendRankResponse>, IDeepCloneable<PinballFriendRankResponse>, IBufferMessage
	{
		// Token: 0x0601257D RID: 75133 RVA: 0x002AD30E File Offset: 0x002AB50E
		[NullableContext(1)]
		public static PinballFriendRankResponse Create()
		{
			return new PinballFriendRankResponse();
		}

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x0601257E RID: 75134 RVA: 0x002AD315 File Offset: 0x002AB515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x0601257F RID: 75135 RVA: 0x002AD318 File Offset: 0x002AB518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballFriendRankResponse.Descriptor;
			}
		}

		// Token: 0x06012580 RID: 75136 RVA: 0x002AD31F File Offset: 0x002AB51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankResponse()
		{
		}

		// Token: 0x06012581 RID: 75137 RVA: 0x002AD334 File Offset: 0x002AB534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankResponse(PinballFriendRankResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rankData_ = other.rankData_.Clone();
			this.playerSelf_ = ((other.playerSelf_ != null) ? other.playerSelf_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012582 RID: 75138 RVA: 0x002AD391 File Offset: 0x002AB591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankResponse Clone()
		{
			return new PinballFriendRankResponse(this);
		}

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x06012583 RID: 75139 RVA: 0x002AD399 File Offset: 0x002AB599
		// (set) Token: 0x06012584 RID: 75140 RVA: 0x002AD3A1 File Offset: 0x002AB5A1
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

		// Token: 0x17003CCA RID: 15562
		// (get) Token: 0x06012585 RID: 75141 RVA: 0x002AD3AA File Offset: 0x002AB5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballRankData> RankData
		{
			get
			{
				return this.rankData_;
			}
		}

		// Token: 0x17003CCB RID: 15563
		// (get) Token: 0x06012586 RID: 75142 RVA: 0x002AD3B2 File Offset: 0x002AB5B2
		// (set) Token: 0x06012587 RID: 75143 RVA: 0x002AD3BA File Offset: 0x002AB5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRankData PlayerSelf
		{
			get
			{
				return this.playerSelf_;
			}
			set
			{
				this.playerSelf_ = value;
			}
		}

		// Token: 0x06012588 RID: 75144 RVA: 0x002AD3C3 File Offset: 0x002AB5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballFriendRankResponse);
		}

		// Token: 0x06012589 RID: 75145 RVA: 0x002AD3D4 File Offset: 0x002AB5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballFriendRankResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.rankData_.Equals(other.rankData_) && object.Equals(this.PlayerSelf, other.PlayerSelf) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601258A RID: 75146 RVA: 0x002AD438 File Offset: 0x002AB638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.rankData_.GetHashCode();
			if (this.playerSelf_ != null)
			{
				num ^= this.PlayerSelf.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601258B RID: 75147 RVA: 0x002AD4A1 File Offset: 0x002AB6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601258C RID: 75148 RVA: 0x002AD4AE File Offset: 0x002AB6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601258D RID: 75149 RVA: 0x002AD4B8 File Offset: 0x002AB6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rankData_.WriteTo(ref output, PinballFriendRankResponse._repeated_rankData_codec);
			if (this.playerSelf_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PlayerSelf);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601258E RID: 75150 RVA: 0x002AD524 File Offset: 0x002AB724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rankData_.CalculateSize(PinballFriendRankResponse._repeated_rankData_codec);
			if (this.playerSelf_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerSelf);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601258F RID: 75151 RVA: 0x002AD590 File Offset: 0x002AB790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballFriendRankResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rankData_.Add(other.rankData_);
			if (other.playerSelf_ != null)
			{
				if (this.playerSelf_ == null)
				{
					this.PlayerSelf = new PinballRankData();
				}
				this.PlayerSelf.MergeFrom(other.PlayerSelf);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012590 RID: 75152 RVA: 0x002AD609 File Offset: 0x002AB809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012591 RID: 75153 RVA: 0x002AD614 File Offset: 0x002AB814
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
				if (num != 26U)
				{
					if (num != 82U)
					{
						if (num != 96U)
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
						if (this.playerSelf_ == null)
						{
							this.PlayerSelf = new PinballRankData();
						}
						input.ReadMessage(this.PlayerSelf);
					}
				}
				else
				{
					this.rankData_.AddEntriesFrom(ref input, PinballFriendRankResponse._repeated_rankData_codec);
				}
			}
		}

		// Token: 0x04007249 RID: 29257
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400724A RID: 29258
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400724B RID: 29259
		private ErrorCode errorCode_;

		// Token: 0x0400724C RID: 29260
		public const int RankDataFieldNumber = 3;

		// Token: 0x0400724D RID: 29261
		private static readonly FieldCodec<PinballRankData> _repeated_rankData_codec = FieldCodec.ForMessage<PinballRankData>(26U, PinballRankData.Parser);

		// Token: 0x0400724E RID: 29262
		private readonly RepeatedField<PinballRankData> rankData_ = new RepeatedField<PinballRankData>();

		// Token: 0x0400724F RID: 29263
		public const int PlayerSelfFieldNumber = 10;

		// Token: 0x04007250 RID: 29264
		private PinballRankData playerSelf_;
	}
}
