using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047D RID: 1149
	[NetMessage(EMessageId.EntityChangeDynamicInteractTextNotify)]
	public sealed class EntityChangeDynamicInteractTextNotify : IMessage<EntityChangeDynamicInteractTextNotify>, IMessage, IEquatable<EntityChangeDynamicInteractTextNotify>, IDeepCloneable<EntityChangeDynamicInteractTextNotify>, IBufferMessage
	{
		// Token: 0x06006D5C RID: 27996 RVA: 0x00107BF7 File Offset: 0x00105DF7
		[NullableContext(1)]
		public static EntityChangeDynamicInteractTextNotify Create()
		{
			return new EntityChangeDynamicInteractTextNotify();
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06006D5D RID: 27997 RVA: 0x00107BFE File Offset: 0x00105DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06006D5E RID: 27998 RVA: 0x00107C01 File Offset: 0x00105E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityChangeDynamicInteractTextNotify.Descriptor;
			}
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x00107C08 File Offset: 0x00105E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityChangeDynamicInteractTextNotify()
		{
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x00107C26 File Offset: 0x00105E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityChangeDynamicInteractTextNotify(EntityChangeDynamicInteractTextNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.optionGuid_ = other.optionGuid_;
			this.text_ = other.text_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x00107C63 File Offset: 0x00105E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityChangeDynamicInteractTextNotify Clone()
		{
			return new EntityChangeDynamicInteractTextNotify(this);
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06006D62 RID: 28002 RVA: 0x00107C6B File Offset: 0x00105E6B
		// (set) Token: 0x06006D63 RID: 28003 RVA: 0x00107C73 File Offset: 0x00105E73
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

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06006D64 RID: 28004 RVA: 0x00107C7C File Offset: 0x00105E7C
		// (set) Token: 0x06006D65 RID: 28005 RVA: 0x00107C84 File Offset: 0x00105E84
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

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06006D66 RID: 28006 RVA: 0x00107C97 File Offset: 0x00105E97
		// (set) Token: 0x06006D67 RID: 28007 RVA: 0x00107C9F File Offset: 0x00105E9F
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

		// Token: 0x06006D68 RID: 28008 RVA: 0x00107CB2 File Offset: 0x00105EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityChangeDynamicInteractTextNotify);
		}

		// Token: 0x06006D69 RID: 28009 RVA: 0x00107CC0 File Offset: 0x00105EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityChangeDynamicInteractTextNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.OptionGuid != other.OptionGuid) && !(this.Text != other.Text) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D6A RID: 28010 RVA: 0x00107D24 File Offset: 0x00105F24
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

		// Token: 0x06006D6B RID: 28011 RVA: 0x00107D99 File Offset: 0x00105F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x00107DA6 File Offset: 0x00105FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x00107DB0 File Offset: 0x00105FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Text.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Text);
			}
			if (this.OptionGuid.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.OptionGuid);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x00107E30 File Offset: 0x00106030
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

		// Token: 0x06006D6F RID: 28015 RVA: 0x00107EA8 File Offset: 0x001060A8
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

		// Token: 0x06006D70 RID: 28016 RVA: 0x00107F16 File Offset: 0x00106116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D71 RID: 28017 RVA: 0x00107F20 File Offset: 0x00106120
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
				if (num != 18U)
				{
					if (num != 34U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityId = input.ReadInt64();
						}
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
		}

		// Token: 0x04003B2D RID: 15149
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B2E RID: 15150
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04003B2F RID: 15151
		private long entityId_;

		// Token: 0x04003B30 RID: 15152
		public const int OptionGuidFieldNumber = 4;

		// Token: 0x04003B31 RID: 15153
		private string optionGuid_ = "";

		// Token: 0x04003B32 RID: 15154
		public const int TextFieldNumber = 2;

		// Token: 0x04003B33 RID: 15155
		private string text_ = "";
	}
}
