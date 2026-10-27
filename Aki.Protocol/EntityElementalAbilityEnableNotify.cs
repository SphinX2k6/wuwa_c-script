using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000487 RID: 1159
	[NetMessage(EMessageId.EntityElementalAbilityEnableNotify)]
	public sealed class EntityElementalAbilityEnableNotify : IMessage<EntityElementalAbilityEnableNotify>, IMessage, IEquatable<EntityElementalAbilityEnableNotify>, IDeepCloneable<EntityElementalAbilityEnableNotify>, IBufferMessage
	{
		// Token: 0x06006EEA RID: 28394 RVA: 0x00110554 File Offset: 0x0010E754
		[NullableContext(1)]
		public static EntityElementalAbilityEnableNotify Create()
		{
			return new EntityElementalAbilityEnableNotify();
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06006EEB RID: 28395 RVA: 0x0011055B File Offset: 0x0010E75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06006EEC RID: 28396 RVA: 0x0011055E File Offset: 0x0010E75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityElementalAbilityEnableNotify.Descriptor;
			}
		}

		// Token: 0x06006EED RID: 28397 RVA: 0x00110565 File Offset: 0x0010E765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityElementalAbilityEnableNotify()
		{
		}

		// Token: 0x06006EEE RID: 28398 RVA: 0x0011056D File Offset: 0x0010E76D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityElementalAbilityEnableNotify(EntityElementalAbilityEnableNotify other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this.enable_ = other.enable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EEF RID: 28399 RVA: 0x0011059E File Offset: 0x0010E79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityElementalAbilityEnableNotify Clone()
		{
			return new EntityElementalAbilityEnableNotify(this);
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06006EF0 RID: 28400 RVA: 0x001105A6 File Offset: 0x0010E7A6
		// (set) Token: 0x06006EF1 RID: 28401 RVA: 0x001105AE File Offset: 0x0010E7AE
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

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06006EF2 RID: 28402 RVA: 0x001105B7 File Offset: 0x0010E7B7
		// (set) Token: 0x06006EF3 RID: 28403 RVA: 0x001105BF File Offset: 0x0010E7BF
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

		// Token: 0x06006EF4 RID: 28404 RVA: 0x001105C8 File Offset: 0x0010E7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityElementalAbilityEnableNotify);
		}

		// Token: 0x06006EF5 RID: 28405 RVA: 0x001105D6 File Offset: 0x0010E7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityElementalAbilityEnableNotify other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && this.Enable == other.Enable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006EF6 RID: 28406 RVA: 0x00110614 File Offset: 0x0010E814
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

		// Token: 0x06006EF7 RID: 28407 RVA: 0x0011066C File Offset: 0x0010E86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006EF8 RID: 28408 RVA: 0x00110679 File Offset: 0x0010E879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EF9 RID: 28409 RVA: 0x00110684 File Offset: 0x0010E884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityIncId);
			}
			if (this.Enable)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.Enable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x001106E0 File Offset: 0x0010E8E0
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

		// Token: 0x06006EFB RID: 28411 RVA: 0x0011072C File Offset: 0x0010E92C
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

		// Token: 0x06006EFC RID: 28412 RVA: 0x0011077C File Offset: 0x0010E97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x00110788 File Offset: 0x0010E988
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
					if (num != 104U)
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

		// Token: 0x04003BC2 RID: 15298
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BC3 RID: 15299
		public const int EntityIncIdFieldNumber = 7;

		// Token: 0x04003BC4 RID: 15300
		private long entityIncId_;

		// Token: 0x04003BC5 RID: 15301
		public const int EnableFieldNumber = 13;

		// Token: 0x04003BC6 RID: 15302
		private bool enable_;
	}
}
