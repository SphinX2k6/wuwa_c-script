using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044F RID: 1103
	[NetMessage(EMessageId.EntityAddDynamicInteractNotify)]
	public sealed class EntityAddDynamicInteractNotify : IMessage<EntityAddDynamicInteractNotify>, IMessage, IEquatable<EntityAddDynamicInteractNotify>, IDeepCloneable<EntityAddDynamicInteractNotify>, IBufferMessage
	{
		// Token: 0x060069E6 RID: 27110 RVA: 0x00100328 File Offset: 0x000FE528
		[NullableContext(1)]
		public static EntityAddDynamicInteractNotify Create()
		{
			return new EntityAddDynamicInteractNotify();
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x060069E7 RID: 27111 RVA: 0x0010032F File Offset: 0x000FE52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x060069E8 RID: 27112 RVA: 0x00100332 File Offset: 0x000FE532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAddDynamicInteractNotify.Descriptor;
			}
		}

		// Token: 0x060069E9 RID: 27113 RVA: 0x00100339 File Offset: 0x000FE539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddDynamicInteractNotify()
		{
		}

		// Token: 0x060069EA RID: 27114 RVA: 0x00100358 File Offset: 0x000FE558
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

		// Token: 0x060069EB RID: 27115 RVA: 0x001003C8 File Offset: 0x000FE5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddDynamicInteractNotify Clone()
		{
			return new EntityAddDynamicInteractNotify(this);
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x060069EC RID: 27116 RVA: 0x001003D0 File Offset: 0x000FE5D0
		// (set) Token: 0x060069ED RID: 27117 RVA: 0x001003D8 File Offset: 0x000FE5D8
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

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x060069EE RID: 27118 RVA: 0x001003E1 File Offset: 0x000FE5E1
		// (set) Token: 0x060069EF RID: 27119 RVA: 0x001003E9 File Offset: 0x000FE5E9
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

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x060069F0 RID: 27120 RVA: 0x001003FC File Offset: 0x000FE5FC
		// (set) Token: 0x060069F1 RID: 27121 RVA: 0x00100404 File Offset: 0x000FE604
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

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x060069F2 RID: 27122 RVA: 0x0010040D File Offset: 0x000FE60D
		// (set) Token: 0x060069F3 RID: 27123 RVA: 0x00100415 File Offset: 0x000FE615
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

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x060069F4 RID: 27124 RVA: 0x00100428 File Offset: 0x000FE628
		// (set) Token: 0x060069F5 RID: 27125 RVA: 0x00100430 File Offset: 0x000FE630
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

		// Token: 0x060069F6 RID: 27126 RVA: 0x00100439 File Offset: 0x000FE639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAddDynamicInteractNotify);
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x00100448 File Offset: 0x000FE648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAddDynamicInteractNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.OptionGuid != other.OptionGuid) && object.Equals(this.GameCtx, other.GameCtx) && !(this.Text != other.Text) && this.DelayRemove == other.DelayRemove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x001004D0 File Offset: 0x000FE6D0
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

		// Token: 0x060069F9 RID: 27129 RVA: 0x00100574 File Offset: 0x000FE774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x00100581 File Offset: 0x000FE781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x0010058C File Offset: 0x000FE78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gameCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameCtx);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.DelayRemove)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.DelayRemove);
			}
			if (this.Text.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Text);
			}
			if (this.OptionGuid.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.OptionGuid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x00100644 File Offset: 0x000FE844
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

		// Token: 0x060069FD RID: 27133 RVA: 0x001006E0 File Offset: 0x000FE8E0
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

		// Token: 0x060069FE RID: 27134 RVA: 0x0010078E File Offset: 0x000FE98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x00100798 File Offset: 0x000FE998
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
					if (num == 10U)
					{
						if (this.gameCtx_ == null)
						{
							this.GameCtx = new GameCtxPb();
						}
						input.ReadMessage(this.GameCtx);
						continue;
					}
					if (num == 24U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.DelayRemove = input.ReadBool();
						continue;
					}
					if (num == 50U)
					{
						this.Text = input.ReadString();
						continue;
					}
					if (num == 114U)
					{
						this.OptionGuid = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A85 RID: 14981
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A86 RID: 14982
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04003A87 RID: 14983
		private long entityId_;

		// Token: 0x04003A88 RID: 14984
		public const int OptionGuidFieldNumber = 14;

		// Token: 0x04003A89 RID: 14985
		private string optionGuid_ = "";

		// Token: 0x04003A8A RID: 14986
		public const int GameCtxFieldNumber = 1;

		// Token: 0x04003A8B RID: 14987
		private GameCtxPb gameCtx_;

		// Token: 0x04003A8C RID: 14988
		public const int TextFieldNumber = 6;

		// Token: 0x04003A8D RID: 14989
		private string text_ = "";

		// Token: 0x04003A8E RID: 14990
		public const int DelayRemoveFieldNumber = 5;

		// Token: 0x04003A8F RID: 14991
		private bool delayRemove_;
	}
}
