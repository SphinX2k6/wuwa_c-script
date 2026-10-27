using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000466 RID: 1126
	[NetMessage(EMessageId.EntityAddDynamicInteractNotify)]
	public sealed class EntityAddDynamicInteractNotify : IMessage<EntityAddDynamicInteractNotify>, IMessage, IEquatable<EntityAddDynamicInteractNotify>, IDeepCloneable<EntityAddDynamicInteractNotify>, IBufferMessage
	{
		// Token: 0x06006B74 RID: 27508 RVA: 0x00103398 File Offset: 0x00101598
		[NullableContext(1)]
		public static EntityAddDynamicInteractNotify Create()
		{
			return new EntityAddDynamicInteractNotify();
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06006B75 RID: 27509 RVA: 0x0010339F File Offset: 0x0010159F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06006B76 RID: 27510 RVA: 0x001033A2 File Offset: 0x001015A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAddDynamicInteractNotify.Descriptor;
			}
		}

		// Token: 0x06006B77 RID: 27511 RVA: 0x001033A9 File Offset: 0x001015A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddDynamicInteractNotify()
		{
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x001033C8 File Offset: 0x001015C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddDynamicInteractNotify(EntityAddDynamicInteractNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.optionGuid_ = other.optionGuid_;
			this.gameCtx_ = ((other.gameCtx_ != null) ? other.gameCtx_.Clone() : null);
			this.text_ = other.text_;
			this.delayRemove_ = other.delayRemove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x00103438 File Offset: 0x00101638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddDynamicInteractNotify Clone()
		{
			return new EntityAddDynamicInteractNotify(this);
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06006B7A RID: 27514 RVA: 0x00103440 File Offset: 0x00101640
		// (set) Token: 0x06006B7B RID: 27515 RVA: 0x00103448 File Offset: 0x00101648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06006B7C RID: 27516 RVA: 0x00103451 File Offset: 0x00101651
		// (set) Token: 0x06006B7D RID: 27517 RVA: 0x00103459 File Offset: 0x00101659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OptionGuid
		{
			get
			{
				return this.optionGuid_;
			}
			set
			{
				this.optionGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06006B7E RID: 27518 RVA: 0x0010346C File Offset: 0x0010166C
		// (set) Token: 0x06006B7F RID: 27519 RVA: 0x00103474 File Offset: 0x00101674
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

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06006B80 RID: 27520 RVA: 0x0010347D File Offset: 0x0010167D
		// (set) Token: 0x06006B81 RID: 27521 RVA: 0x00103485 File Offset: 0x00101685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Text
		{
			get
			{
				return this.text_;
			}
			set
			{
				this.text_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06006B82 RID: 27522 RVA: 0x00103498 File Offset: 0x00101698
		// (set) Token: 0x06006B83 RID: 27523 RVA: 0x001034A0 File Offset: 0x001016A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DelayRemove
		{
			get
			{
				return this.delayRemove_;
			}
			set
			{
				this.delayRemove_ = value;
			}
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x001034A9 File Offset: 0x001016A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAddDynamicInteractNotify);
		}

		// Token: 0x06006B85 RID: 27525 RVA: 0x001034B8 File Offset: 0x001016B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAddDynamicInteractNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.OptionGuid != other.OptionGuid) && object.Equals(this.GameCtx, other.GameCtx) && !(this.Text != other.Text) && this.DelayRemove == other.DelayRemove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x00103540 File Offset: 0x00101740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.OptionGuid.Length != 0)
			{
				num ^= this.OptionGuid.GetHashCode();
			}
			if (this.gameCtx_ != null)
			{
				num ^= this.GameCtx.GetHashCode();
			}
			if (this.Text.Length != 0)
			{
				num ^= this.Text.GetHashCode();
			}
			if (this.DelayRemove)
			{
				num ^= this.DelayRemove.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x001035E4 File Offset: 0x001017E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x001035F1 File Offset: 0x001017F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x001035FC File Offset: 0x001017FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DelayRemove)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.DelayRemove);
			}
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.GameCtx);
			}
			if (this.OptionGuid.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.OptionGuid);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.Text.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Text);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x001036B4 File Offset: 0x001018B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.OptionGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OptionGuid);
			}
			if (this.gameCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameCtx);
			}
			if (this.Text.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Text);
			}
			if (this.DelayRemove)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x00103750 File Offset: 0x00101950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAddDynamicInteractNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.OptionGuid.Length != 0)
			{
				this.OptionGuid = other.OptionGuid;
			}
			if (other.gameCtx_ != null)
			{
				if (this.gameCtx_ == null)
				{
					this.GameCtx = new GameCtxPb();
				}
				this.GameCtx.MergeFrom(other.GameCtx);
			}
			if (other.Text.Length != 0)
			{
				this.Text = other.Text;
			}
			if (other.DelayRemove)
			{
				this.DelayRemove = other.DelayRemove;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x001037FE File Offset: 0x001019FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x00103808 File Offset: 0x00101A08
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
				if (num <= 50U)
				{
					if (num == 16U)
					{
						this.DelayRemove = input.ReadBool();
						continue;
					}
					if (num == 50U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.OptionGuid = input.ReadString();
						continue;
					}
					if (num == 80U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 114U)
					{
						this.Text = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A97 RID: 14999
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A98 RID: 15000
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04003A99 RID: 15001
		private long entityId_;

		// Token: 0x04003A9A RID: 15002
		public const int OptionGuidFieldNumber = 8;

		// Token: 0x04003A9B RID: 15003
		private string optionGuid_ = "";

		// Token: 0x04003A9C RID: 15004
		public const int GameCtxFieldNumber = 6;

		// Token: 0x04003A9D RID: 15005
		private GameCtxPb gameCtx_;

		// Token: 0x04003A9E RID: 15006
		public const int TextFieldNumber = 14;

		// Token: 0x04003A9F RID: 15007
		private string text_ = "";

		// Token: 0x04003AA0 RID: 15008
		public const int DelayRemoveFieldNumber = 2;

		// Token: 0x04003AA1 RID: 15009
		private bool delayRemove_;
	}
}
