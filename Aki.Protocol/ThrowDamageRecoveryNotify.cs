using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001369 RID: 4969
	[NetMessage(EMessageId.ThrowDamageRecoveryNotify)]
	public sealed class ThrowDamageRecoveryNotify : IMessage<ThrowDamageRecoveryNotify>, IMessage, IEquatable<ThrowDamageRecoveryNotify>, IDeepCloneable<ThrowDamageRecoveryNotify>, IBufferMessage
	{
		// Token: 0x0601A62C RID: 108076 RVA: 0x003D4B60 File Offset: 0x003D2D60
		[NullableContext(1)]
		public static ThrowDamageRecoveryNotify Create()
		{
			return new ThrowDamageRecoveryNotify();
		}

		// Token: 0x170058FE RID: 22782
		// (get) Token: 0x0601A62D RID: 108077 RVA: 0x003D4B67 File Offset: 0x003D2D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058FF RID: 22783
		// (get) Token: 0x0601A62E RID: 108078 RVA: 0x003D4B6A File Offset: 0x003D2D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThrowDamageRecoveryNotify.Descriptor;
			}
		}

		// Token: 0x0601A62F RID: 108079 RVA: 0x003D4B71 File Offset: 0x003D2D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRecoveryNotify()
		{
		}

		// Token: 0x0601A630 RID: 108080 RVA: 0x003D4B79 File Offset: 0x003D2D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRecoveryNotify(ThrowDamageRecoveryNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.durability_ = other.durability_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A631 RID: 108081 RVA: 0x003D4BAA File Offset: 0x003D2DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRecoveryNotify Clone()
		{
			return new ThrowDamageRecoveryNotify(this);
		}

		// Token: 0x17005900 RID: 22784
		// (get) Token: 0x0601A632 RID: 108082 RVA: 0x003D4BB2 File Offset: 0x003D2DB2
		// (set) Token: 0x0601A633 RID: 108083 RVA: 0x003D4BBA File Offset: 0x003D2DBA
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

		// Token: 0x17005901 RID: 22785
		// (get) Token: 0x0601A634 RID: 108084 RVA: 0x003D4BC3 File Offset: 0x003D2DC3
		// (set) Token: 0x0601A635 RID: 108085 RVA: 0x003D4BCB File Offset: 0x003D2DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Durability
		{
			get
			{
				return this.durability_;
			}
			set
			{
				this.durability_ = value;
			}
		}

		// Token: 0x0601A636 RID: 108086 RVA: 0x003D4BD4 File Offset: 0x003D2DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThrowDamageRecoveryNotify);
		}

		// Token: 0x0601A637 RID: 108087 RVA: 0x003D4BE2 File Offset: 0x003D2DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThrowDamageRecoveryNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Durability == other.Durability && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A638 RID: 108088 RVA: 0x003D4C20 File Offset: 0x003D2E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Durability != 0)
			{
				num ^= this.Durability.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A639 RID: 108089 RVA: 0x003D4C78 File Offset: 0x003D2E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A63A RID: 108090 RVA: 0x003D4C85 File Offset: 0x003D2E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A63B RID: 108091 RVA: 0x003D4C90 File Offset: 0x003D2E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.Durability != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Durability);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A63C RID: 108092 RVA: 0x003D4CEC File Offset: 0x003D2EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Durability != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Durability);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A63D RID: 108093 RVA: 0x003D4D44 File Offset: 0x003D2F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThrowDamageRecoveryNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Durability != 0)
			{
				this.Durability = other.Durability;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A63E RID: 108094 RVA: 0x003D4D94 File Offset: 0x003D2F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A63F RID: 108095 RVA: 0x003D4DA0 File Offset: 0x003D2FA0
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
				if (num != 48U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Durability = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040099AD RID: 39341
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099AE RID: 39342
		public const int EntityIdFieldNumber = 6;

		// Token: 0x040099AF RID: 39343
		private long entityId_;

		// Token: 0x040099B0 RID: 39344
		public const int DurabilityFieldNumber = 11;

		// Token: 0x040099B1 RID: 39345
		private int durability_;
	}
}
