using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006E RID: 110
	[NetMessage(EMessageId.ActionGroupCreateNotify)]
	public sealed class ActionGroupCreateNotify : IMessage<ActionGroupCreateNotify>, IMessage, IEquatable<ActionGroupCreateNotify>, IDeepCloneable<ActionGroupCreateNotify>, IBufferMessage
	{
		// Token: 0x0600172C RID: 5932 RVA: 0x0003C900 File Offset: 0x0003AB00
		[NullableContext(1)]
		public static ActionGroupCreateNotify Create()
		{
			return new ActionGroupCreateNotify();
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x0003C907 File Offset: 0x0003AB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x0003C90A File Offset: 0x0003AB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionGroupCreateNotify.Descriptor;
			}
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x0003C911 File Offset: 0x0003AB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCreateNotify()
		{
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0003C91C File Offset: 0x0003AB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCreateNotify(ActionGroupCreateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0003C974 File Offset: 0x0003AB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCreateNotify Clone()
		{
			return new ActionGroupCreateNotify(this);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x0003C97C File Offset: 0x0003AB7C
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x0003C984 File Offset: 0x0003AB84
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

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x0003C98D File Offset: 0x0003AB8D
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x0003C995 File Offset: 0x0003AB95
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

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x0003C99E File Offset: 0x0003AB9E
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x0003C9A6 File Offset: 0x0003ABA6
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

		// Token: 0x06001738 RID: 5944 RVA: 0x0003C9AF File Offset: 0x0003ABAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionGroupCreateNotify);
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0003C9C0 File Offset: 0x0003ABC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionGroupCreateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && object.Equals(this.GameCtx, other.GameCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0003CA20 File Offset: 0x0003AC20
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0003CA8E File Offset: 0x0003AC8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0003CA9B File Offset: 0x0003AC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0003CAA4 File Offset: 0x0003ACA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.GameCtx);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0003CB1C File Offset: 0x0003AD1C
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0003CB8C File Offset: 0x0003AD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionGroupCreateNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0003CC08 File Offset: 0x0003AE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0003CC14 File Offset: 0x0003AE14
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
				if (num != 50U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncId = input.ReadInt32();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					if (this.gameCtx_ == null)
					{
						this.GameCtx = new GameCtxPb();
					}
					input.ReadMessage(this.GameCtx);
				}
			}
		}

		// Token: 0x04002115 RID: 8469
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002116 RID: 8470
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x04002117 RID: 8471
		private int playerId_;

		// Token: 0x04002118 RID: 8472
		public const int IncIdFieldNumber = 13;

		// Token: 0x04002119 RID: 8473
		private int incId_;

		// Token: 0x0400211A RID: 8474
		public const int GameCtxFieldNumber = 6;

		// Token: 0x0400211B RID: 8475
		private GameCtxPb gameCtx_;
	}
}
