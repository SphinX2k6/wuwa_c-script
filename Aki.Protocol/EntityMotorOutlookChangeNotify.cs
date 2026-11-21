using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048C RID: 1164
	[NetMessage(EMessageId.EntityMotorOutlookChangeNotify)]
	public sealed class EntityMotorOutlookChangeNotify : IMessage<EntityMotorOutlookChangeNotify>, IMessage, IEquatable<EntityMotorOutlookChangeNotify>, IDeepCloneable<EntityMotorOutlookChangeNotify>, IBufferMessage
	{
		// Token: 0x06006FAF RID: 28591 RVA: 0x00112CED File Offset: 0x00110EED
		[NullableContext(1)]
		public static EntityMotorOutlookChangeNotify Create()
		{
			return new EntityMotorOutlookChangeNotify();
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06006FB0 RID: 28592 RVA: 0x00112CF4 File Offset: 0x00110EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06006FB1 RID: 28593 RVA: 0x00112CF7 File Offset: 0x00110EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityMotorOutlookChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x00112CFE File Offset: 0x00110EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMotorOutlookChangeNotify()
		{
		}

		// Token: 0x06006FB3 RID: 28595 RVA: 0x00112D08 File Offset: 0x00110F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMotorOutlookChangeNotify(EntityMotorOutlookChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.motorOutlookEquipped_ = ((other.motorOutlookEquipped_ != null) ? other.motorOutlookEquipped_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FB4 RID: 28596 RVA: 0x00112D54 File Offset: 0x00110F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMotorOutlookChangeNotify Clone()
		{
			return new EntityMotorOutlookChangeNotify(this);
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06006FB5 RID: 28597 RVA: 0x00112D5C File Offset: 0x00110F5C
		// (set) Token: 0x06006FB6 RID: 28598 RVA: 0x00112D64 File Offset: 0x00110F64
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

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06006FB7 RID: 28599 RVA: 0x00112D6D File Offset: 0x00110F6D
		// (set) Token: 0x06006FB8 RID: 28600 RVA: 0x00112D75 File Offset: 0x00110F75
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

		// Token: 0x06006FB9 RID: 28601 RVA: 0x00112D7E File Offset: 0x00110F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityMotorOutlookChangeNotify);
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x00112D8C File Offset: 0x00110F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityMotorOutlookChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.MotorOutlookEquipped, other.MotorOutlookEquipped) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x00112DDC File Offset: 0x00110FDC
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

		// Token: 0x06006FBC RID: 28604 RVA: 0x00112E31 File Offset: 0x00111031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x00112E3E File Offset: 0x0011103E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x00112E48 File Offset: 0x00111048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlookEquipped_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.MotorOutlookEquipped);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x00112EA4 File Offset: 0x001110A4
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

		// Token: 0x06006FC0 RID: 28608 RVA: 0x00112EFC File Offset: 0x001110FC
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

		// Token: 0x06006FC1 RID: 28609 RVA: 0x00112F64 File Offset: 0x00111164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FC2 RID: 28610 RVA: 0x00112F70 File Offset: 0x00111170
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
				if (num != 42U)
				{
					if (num != 72U)
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

		// Token: 0x04003C66 RID: 15462
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C67 RID: 15463
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003C68 RID: 15464
		private long entityId_;

		// Token: 0x04003C69 RID: 15465
		public const int MotorOutlookEquippedFieldNumber = 5;

		// Token: 0x04003C6A RID: 15466
		private MotorOutlookEquippedPb motorOutlookEquipped_;
	}
}
