using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000470 RID: 1136
	[NetMessage(EMessageId.EntityElementalAbilityEnableNotify)]
	public sealed class EntityElementalAbilityEnableNotify : IMessage<EntityElementalAbilityEnableNotify>, IMessage, IEquatable<EntityElementalAbilityEnableNotify>, IDeepCloneable<EntityElementalAbilityEnableNotify>, IBufferMessage
	{
		// Token: 0x06006D5C RID: 27996 RVA: 0x0010D4E0 File Offset: 0x0010B6E0
		[NullableContext(1)]
		public static EntityElementalAbilityEnableNotify Create()
		{
			return new EntityElementalAbilityEnableNotify();
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x06006D5D RID: 27997 RVA: 0x0010D4E7 File Offset: 0x0010B6E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06006D5E RID: 27998 RVA: 0x0010D4EA File Offset: 0x0010B6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityElementalAbilityEnableNotify.Descriptor;
			}
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x0010D4F1 File Offset: 0x0010B6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityElementalAbilityEnableNotify()
		{
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x0010D4F9 File Offset: 0x0010B6F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityElementalAbilityEnableNotify(EntityElementalAbilityEnableNotify other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this.enable_ = other.enable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x0010D52A File Offset: 0x0010B72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityElementalAbilityEnableNotify Clone()
		{
			return new EntityElementalAbilityEnableNotify(this);
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06006D62 RID: 28002 RVA: 0x0010D532 File Offset: 0x0010B732
		// (set) Token: 0x06006D63 RID: 28003 RVA: 0x0010D53A File Offset: 0x0010B73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06006D64 RID: 28004 RVA: 0x0010D543 File Offset: 0x0010B743
		// (set) Token: 0x06006D65 RID: 28005 RVA: 0x0010D54B File Offset: 0x0010B74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			get
			{
				return this.enable_;
			}
			set
			{
				this.enable_ = value;
			}
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x0010D554 File Offset: 0x0010B754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityElementalAbilityEnableNotify);
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x0010D562 File Offset: 0x0010B762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityElementalAbilityEnableNotify other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && this.Enable == other.Enable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x0010D5A0 File Offset: 0x0010B7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D69 RID: 28009 RVA: 0x0010D5F8 File Offset: 0x0010B7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D6A RID: 28010 RVA: 0x0010D605 File Offset: 0x0010B805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x0010D610 File Offset: 0x0010B810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityIncId);
			}
			if (this.Enable)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Enable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x0010D66C File Offset: 0x0010B86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this.Enable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x0010D6B8 File Offset: 0x0010B8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityElementalAbilityEnableNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x0010D708 File Offset: 0x0010B908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x0010D714 File Offset: 0x0010B914
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
				if (num != 32U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Enable = input.ReadBool();
					}
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003BB0 RID: 15280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BB1 RID: 15281
		public const int EntityIncIdFieldNumber = 4;

		// Token: 0x04003BB2 RID: 15282
		private long entityIncId_;

		// Token: 0x04003BB3 RID: 15283
		public const int EnableFieldNumber = 6;

		// Token: 0x04003BB4 RID: 15284
		private bool enable_;
	}
}
