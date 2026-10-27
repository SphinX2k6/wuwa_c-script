using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A3 RID: 1187
	[NetMessage(EMessageId.EntityMotorOutlookChangeNotify)]
	public sealed class EntityMotorOutlookChangeNotify : IMessage<EntityMotorOutlookChangeNotify>, IMessage, IEquatable<EntityMotorOutlookChangeNotify>, IDeepCloneable<EntityMotorOutlookChangeNotify>, IBufferMessage
	{
		// Token: 0x0600713D RID: 28989 RVA: 0x00115D65 File Offset: 0x00113F65
		[NullableContext(1)]
		public static EntityMotorOutlookChangeNotify Create()
		{
			return new EntityMotorOutlookChangeNotify();
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x0600713E RID: 28990 RVA: 0x00115D6C File Offset: 0x00113F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x0600713F RID: 28991 RVA: 0x00115D6F File Offset: 0x00113F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityMotorOutlookChangeNotify.Descriptor;
			}
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x00115D76 File Offset: 0x00113F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMotorOutlookChangeNotify()
		{
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x00115D80 File Offset: 0x00113F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMotorOutlookChangeNotify(EntityMotorOutlookChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.motorOutlookEquipped_ = ((other.motorOutlookEquipped_ != null) ? other.motorOutlookEquipped_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x00115DCC File Offset: 0x00113FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMotorOutlookChangeNotify Clone()
		{
			return new EntityMotorOutlookChangeNotify(this);
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06007143 RID: 28995 RVA: 0x00115DD4 File Offset: 0x00113FD4
		// (set) Token: 0x06007144 RID: 28996 RVA: 0x00115DDC File Offset: 0x00113FDC
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

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06007145 RID: 28997 RVA: 0x00115DE5 File Offset: 0x00113FE5
		// (set) Token: 0x06007146 RID: 28998 RVA: 0x00115DED File Offset: 0x00113FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedPb MotorOutlookEquipped
		{
			get
			{
				return this.motorOutlookEquipped_;
			}
			set
			{
				this.motorOutlookEquipped_ = value;
			}
		}

		// Token: 0x06007147 RID: 28999 RVA: 0x00115DF6 File Offset: 0x00113FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityMotorOutlookChangeNotify);
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x00115E04 File Offset: 0x00114004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityMotorOutlookChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.MotorOutlookEquipped, other.MotorOutlookEquipped) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x00115E54 File Offset: 0x00114054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.motorOutlookEquipped_ != null)
			{
				num ^= this.MotorOutlookEquipped.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x00115EA9 File Offset: 0x001140A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x00115EB6 File Offset: 0x001140B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x00115EC0 File Offset: 0x001140C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlookEquipped_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.MotorOutlookEquipped);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x00115F1C File Offset: 0x0011411C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.motorOutlookEquipped_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlookEquipped);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x00115F74 File Offset: 0x00114174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityMotorOutlookChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.motorOutlookEquipped_ != null)
			{
				if (this.motorOutlookEquipped_ == null)
				{
					this.MotorOutlookEquipped = new MotorOutlookEquippedPb();
				}
				this.MotorOutlookEquipped.MergeFrom(other.MotorOutlookEquipped);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x00115FDC File Offset: 0x001141DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x00115FE8 File Offset: 0x001141E8
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
				if (num != 82U)
				{
					if (num != 88U)
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
					if (this.motorOutlookEquipped_ == null)
					{
						this.MotorOutlookEquipped = new MotorOutlookEquippedPb();
					}
					input.ReadMessage(this.MotorOutlookEquipped);
				}
			}
		}

		// Token: 0x04003C78 RID: 15480
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C79 RID: 15481
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04003C7A RID: 15482
		private long entityId_;

		// Token: 0x04003C7B RID: 15483
		public const int MotorOutlookEquippedFieldNumber = 10;

		// Token: 0x04003C7C RID: 15484
		private MotorOutlookEquippedPb motorOutlookEquipped_;
	}
}
