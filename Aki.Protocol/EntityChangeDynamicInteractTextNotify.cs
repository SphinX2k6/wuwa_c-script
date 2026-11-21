using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000466 RID: 1126
	[NetMessage(EMessageId.EntityChangeDynamicInteractTextNotify)]
	public sealed class EntityChangeDynamicInteractTextNotify : IMessage<EntityChangeDynamicInteractTextNotify>, IMessage, IEquatable<EntityChangeDynamicInteractTextNotify>, IDeepCloneable<EntityChangeDynamicInteractTextNotify>, IBufferMessage
	{
		// Token: 0x06006BCE RID: 27598 RVA: 0x00104B83 File Offset: 0x00102D83
		[NullableContext(1)]
		public static EntityChangeDynamicInteractTextNotify Create()
		{
			return new EntityChangeDynamicInteractTextNotify();
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06006BCF RID: 27599 RVA: 0x00104B8A File Offset: 0x00102D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06006BD0 RID: 27600 RVA: 0x00104B8D File Offset: 0x00102D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityChangeDynamicInteractTextNotify.Descriptor;
			}
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x00104B94 File Offset: 0x00102D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityChangeDynamicInteractTextNotify()
		{
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x00104BB2 File Offset: 0x00102DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityChangeDynamicInteractTextNotify(EntityChangeDynamicInteractTextNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.optionGuid_ = other.optionGuid_;
			this.text_ = other.text_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x00104BEF File Offset: 0x00102DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityChangeDynamicInteractTextNotify Clone()
		{
			return new EntityChangeDynamicInteractTextNotify(this);
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06006BD4 RID: 27604 RVA: 0x00104BF7 File Offset: 0x00102DF7
		// (set) Token: 0x06006BD5 RID: 27605 RVA: 0x00104BFF File Offset: 0x00102DFF
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

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06006BD6 RID: 27606 RVA: 0x00104C08 File Offset: 0x00102E08
		// (set) Token: 0x06006BD7 RID: 27607 RVA: 0x00104C10 File Offset: 0x00102E10
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

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06006BD8 RID: 27608 RVA: 0x00104C23 File Offset: 0x00102E23
		// (set) Token: 0x06006BD9 RID: 27609 RVA: 0x00104C2B File Offset: 0x00102E2B
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

		// Token: 0x06006BDA RID: 27610 RVA: 0x00104C3E File Offset: 0x00102E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityChangeDynamicInteractTextNotify);
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x00104C4C File Offset: 0x00102E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityChangeDynamicInteractTextNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.OptionGuid != other.OptionGuid) && !(this.Text != other.Text) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x00104CB0 File Offset: 0x00102EB0
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
			if (this.Text.Length != 0)
			{
				num ^= this.Text.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x00104D25 File Offset: 0x00102F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x00104D32 File Offset: 0x00102F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x00104D3C File Offset: 0x00102F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.Text.Length != 0)
			{
				output.WriteRawTag(90);
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

		// Token: 0x06006BE0 RID: 27616 RVA: 0x00104DBC File Offset: 0x00102FBC
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
			if (this.Text.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Text);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x00104E34 File Offset: 0x00103034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityChangeDynamicInteractTextNotify other)
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
			if (other.Text.Length != 0)
			{
				this.Text = other.Text;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BE2 RID: 27618 RVA: 0x00104EA2 File Offset: 0x001030A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BE3 RID: 27619 RVA: 0x00104EAC File Offset: 0x001030AC
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
				if (num != 56U)
				{
					if (num != 90U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.OptionGuid = input.ReadString();
						}
					}
					else
					{
						this.Text = input.ReadString();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003B1B RID: 15131
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B1C RID: 15132
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04003B1D RID: 15133
		private long entityId_;

		// Token: 0x04003B1E RID: 15134
		public const int OptionGuidFieldNumber = 14;

		// Token: 0x04003B1F RID: 15135
		private string optionGuid_ = "";

		// Token: 0x04003B20 RID: 15136
		public const int TextFieldNumber = 11;

		// Token: 0x04003B21 RID: 15137
		private string text_ = "";
	}
}
