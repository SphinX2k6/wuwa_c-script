using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000070 RID: 112
	[NetMessage(EMessageId.ActionNotify)]
	public sealed class ActionNotify : IMessage<ActionNotify>, IMessage, IEquatable<ActionNotify>, IDeepCloneable<ActionNotify>, IBufferMessage
	{
		// Token: 0x06001754 RID: 5972 RVA: 0x0003CEB8 File Offset: 0x0003B0B8
		[NullableContext(1)]
		public static ActionNotify Create()
		{
			return new ActionNotify();
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x0003CEBF File Offset: 0x0003B0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x0003CEC2 File Offset: 0x0003B0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionNotify.Descriptor;
			}
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0003CEC9 File Offset: 0x0003B0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionNotify()
		{
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0003CED4 File Offset: 0x0003B0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionNotify(ActionNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this.totalCount_ = other.totalCount_;
			this.startIndex_ = other.startIndex_;
			this.endIndex_ = other.endIndex_;
			this.needFinishReq_ = other.needFinishReq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0003CF5C File Offset: 0x0003B15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionNotify Clone()
		{
			return new ActionNotify(this);
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x0003CF64 File Offset: 0x0003B164
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x0003CF6C File Offset: 0x0003B16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x0003CF75 File Offset: 0x0003B175
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x0003CF7D File Offset: 0x0003B17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x0003CF86 File Offset: 0x0003B186
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x0003CF8E File Offset: 0x0003B18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb GameCtx
		{
			get
			{
				return this.gameCtx_;
			}
			set
			{
				this.gameCtx_ = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0003CF97 File Offset: 0x0003B197
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x0003CF9F File Offset: 0x0003B19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCount
		{
			get
			{
				return this.totalCount_;
			}
			set
			{
				this.totalCount_ = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x0003CFA8 File Offset: 0x0003B1A8
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x0003CFB0 File Offset: 0x0003B1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartIndex
		{
			get
			{
				return this.startIndex_;
			}
			set
			{
				this.startIndex_ = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x0003CFB9 File Offset: 0x0003B1B9
		// (set) Token: 0x06001765 RID: 5989 RVA: 0x0003CFC1 File Offset: 0x0003B1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EndIndex
		{
			get
			{
				return this.endIndex_;
			}
			set
			{
				this.endIndex_ = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x0003CFCA File Offset: 0x0003B1CA
		// (set) Token: 0x06001767 RID: 5991 RVA: 0x0003CFD2 File Offset: 0x0003B1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedFinishReq
		{
			get
			{
				return this.needFinishReq_;
			}
			set
			{
				this.needFinishReq_ = value;
			}
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0003CFDB File Offset: 0x0003B1DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionNotify);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0003CFEC File Offset: 0x0003B1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && object.Equals(this.GameCtx, other.GameCtx) && this.TotalCount == other.TotalCount && this.StartIndex == other.StartIndex && this.EndIndex == other.EndIndex && this.NeedFinishReq == other.NeedFinishReq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0003D08C File Offset: 0x0003B28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.gameCtx_ != null)
			{
				num ^= this.GameCtx.GetHashCode();
			}
			if (this.TotalCount != 0)
			{
				num ^= this.TotalCount.GetHashCode();
			}
			if (this.StartIndex != 0)
			{
				num ^= this.StartIndex.GetHashCode();
			}
			if (this.EndIndex != 0)
			{
				num ^= this.EndIndex.GetHashCode();
			}
			if (this.NeedFinishReq)
			{
				num ^= this.NeedFinishReq.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0003D15E File Offset: 0x0003B35E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0003D16B File Offset: 0x0003B36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x0003D174 File Offset: 0x0003B374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NeedFinishReq)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.NeedFinishReq);
			}
			if (this.EndIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EndIndex);
			}
			if (this.TotalCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalCount);
			}
			if (this.StartIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.StartIndex);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IncId);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.GameCtx);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0003D258 File Offset: 0x0003B458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.gameCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameCtx);
			}
			if (this.TotalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCount);
			}
			if (this.StartIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartIndex);
			}
			if (this.EndIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EndIndex);
			}
			if (this.NeedFinishReq)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0003D31C File Offset: 0x0003B51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.gameCtx_ != null)
			{
				if (this.gameCtx_ == null)
				{
					this.GameCtx = new GameCtxPb();
				}
				this.GameCtx.MergeFrom(other.GameCtx);
			}
			if (other.TotalCount != 0)
			{
				this.TotalCount = other.TotalCount;
			}
			if (other.StartIndex != 0)
			{
				this.StartIndex = other.StartIndex;
			}
			if (other.EndIndex != 0)
			{
				this.EndIndex = other.EndIndex;
			}
			if (other.NeedFinishReq)
			{
				this.NeedFinishReq = other.NeedFinishReq;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0003D3E8 File Offset: 0x0003B5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0003D3F4 File Offset: 0x0003B5F4
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.NeedFinishReq = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.EndIndex = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.TotalCount = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 72U)
				{
					if (num == 56U)
					{
						this.StartIndex = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
					if (num == 120U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400211F RID: 8479
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002120 RID: 8480
		public const int PlayerIdFieldNumber = 15;

		// Token: 0x04002121 RID: 8481
		private int playerId_;

		// Token: 0x04002122 RID: 8482
		public const int IncIdFieldNumber = 9;

		// Token: 0x04002123 RID: 8483
		private int incId_;

		// Token: 0x04002124 RID: 8484
		public const int GameCtxFieldNumber = 11;

		// Token: 0x04002125 RID: 8485
		private GameCtxPb gameCtx_;

		// Token: 0x04002126 RID: 8486
		public const int TotalCountFieldNumber = 3;

		// Token: 0x04002127 RID: 8487
		private int totalCount_;

		// Token: 0x04002128 RID: 8488
		public const int StartIndexFieldNumber = 7;

		// Token: 0x04002129 RID: 8489
		private int startIndex_;

		// Token: 0x0400212A RID: 8490
		public const int EndIndexFieldNumber = 2;

		// Token: 0x0400212B RID: 8491
		private int endIndex_;

		// Token: 0x0400212C RID: 8492
		public const int NeedFinishReqFieldNumber = 1;

		// Token: 0x0400212D RID: 8493
		private bool needFinishReq_;
	}
}
