using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000071 RID: 113
	[NetMessage(EMessageId.ActionNotify)]
	public sealed class ActionNotify : IMessage<ActionNotify>, IMessage, IEquatable<ActionNotify>, IDeepCloneable<ActionNotify>, IBufferMessage
	{
		// Token: 0x06001797 RID: 6039 RVA: 0x0003D858 File Offset: 0x0003BA58
		[NullableContext(1)]
		public static ActionNotify Create()
		{
			return new ActionNotify();
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x0003D85F File Offset: 0x0003BA5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x0003D862 File Offset: 0x0003BA62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionNotify.Descriptor;
			}
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x0003D869 File Offset: 0x0003BA69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionNotify()
		{
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0003D874 File Offset: 0x0003BA74
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

		// Token: 0x0600179C RID: 6044 RVA: 0x0003D8FC File Offset: 0x0003BAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionNotify Clone()
		{
			return new ActionNotify(this);
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x0003D904 File Offset: 0x0003BB04
		// (set) Token: 0x0600179E RID: 6046 RVA: 0x0003D90C File Offset: 0x0003BB0C
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x0003D915 File Offset: 0x0003BB15
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x0003D91D File Offset: 0x0003BB1D
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

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x0003D926 File Offset: 0x0003BB26
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x0003D92E File Offset: 0x0003BB2E
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

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x0003D937 File Offset: 0x0003BB37
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0003D93F File Offset: 0x0003BB3F
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

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x0003D948 File Offset: 0x0003BB48
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x0003D950 File Offset: 0x0003BB50
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

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x0003D959 File Offset: 0x0003BB59
		// (set) Token: 0x060017A8 RID: 6056 RVA: 0x0003D961 File Offset: 0x0003BB61
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x0003D96A File Offset: 0x0003BB6A
		// (set) Token: 0x060017AA RID: 6058 RVA: 0x0003D972 File Offset: 0x0003BB72
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

		// Token: 0x060017AB RID: 6059 RVA: 0x0003D97B File Offset: 0x0003BB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionNotify);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0003D98C File Offset: 0x0003BB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && object.Equals(this.GameCtx, other.GameCtx) && this.TotalCount == other.TotalCount && this.StartIndex == other.StartIndex && this.EndIndex == other.EndIndex && this.NeedFinishReq == other.NeedFinishReq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0003DA2C File Offset: 0x0003BC2C
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

		// Token: 0x060017AE RID: 6062 RVA: 0x0003DAFE File Offset: 0x0003BCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0003DB0B File Offset: 0x0003BD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0003DB14 File Offset: 0x0003BD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameCtx);
			}
			if (this.TotalCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalCount);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerId);
			}
			if (this.StartIndex != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.StartIndex);
			}
			if (this.EndIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EndIndex);
			}
			if (this.NeedFinishReq)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.NeedFinishReq);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0003DBFC File Offset: 0x0003BDFC
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

		// Token: 0x060017B2 RID: 6066 RVA: 0x0003DCC0 File Offset: 0x0003BEC0
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

		// Token: 0x060017B3 RID: 6067 RVA: 0x0003DD8C File Offset: 0x0003BF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0003DD98 File Offset: 0x0003BF98
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
					if (num == 10U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
					if (num == 16U)
					{
						this.TotalCount = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 80U)
				{
					if (num == 64U)
					{
						this.StartIndex = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.EndIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.NeedFinishReq = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400217E RID: 8574
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400217F RID: 8575
		public const int PlayerIdFieldNumber = 6;

		// Token: 0x04002180 RID: 8576
		private int playerId_;

		// Token: 0x04002181 RID: 8577
		public const int IncIdFieldNumber = 12;

		// Token: 0x04002182 RID: 8578
		private int incId_;

		// Token: 0x04002183 RID: 8579
		public const int GameCtxFieldNumber = 1;

		// Token: 0x04002184 RID: 8580
		private GameCtxPb gameCtx_;

		// Token: 0x04002185 RID: 8581
		public const int TotalCountFieldNumber = 2;

		// Token: 0x04002186 RID: 8582
		private int totalCount_;

		// Token: 0x04002187 RID: 8583
		public const int StartIndexFieldNumber = 8;

		// Token: 0x04002188 RID: 8584
		private int startIndex_;

		// Token: 0x04002189 RID: 8585
		public const int EndIndexFieldNumber = 10;

		// Token: 0x0400218A RID: 8586
		private int endIndex_;

		// Token: 0x0400218B RID: 8587
		public const int NeedFinishReqFieldNumber = 11;

		// Token: 0x0400218C RID: 8588
		private bool needFinishReq_;
	}
}
