using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001368 RID: 4968
	[NetMessage(EMessageId.ThrowDamageNotify)]
	public sealed class ThrowDamageNotify : IMessage<ThrowDamageNotify>, IMessage, IEquatable<ThrowDamageNotify>, IDeepCloneable<ThrowDamageNotify>, IBufferMessage
	{
		// Token: 0x0601A618 RID: 108056 RVA: 0x003D48C8 File Offset: 0x003D2AC8
		[NullableContext(1)]
		public static ThrowDamageNotify Create()
		{
			return new ThrowDamageNotify();
		}

		// Token: 0x170058FA RID: 22778
		// (get) Token: 0x0601A619 RID: 108057 RVA: 0x003D48CF File Offset: 0x003D2ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058FB RID: 22779
		// (get) Token: 0x0601A61A RID: 108058 RVA: 0x003D48D2 File Offset: 0x003D2AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThrowDamageNotify.Descriptor;
			}
		}

		// Token: 0x0601A61B RID: 108059 RVA: 0x003D48D9 File Offset: 0x003D2AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageNotify()
		{
		}

		// Token: 0x0601A61C RID: 108060 RVA: 0x003D48E1 File Offset: 0x003D2AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageNotify(ThrowDamageNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.durability_ = other.durability_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A61D RID: 108061 RVA: 0x003D4912 File Offset: 0x003D2B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageNotify Clone()
		{
			return new ThrowDamageNotify(this);
		}

		// Token: 0x170058FC RID: 22780
		// (get) Token: 0x0601A61E RID: 108062 RVA: 0x003D491A File Offset: 0x003D2B1A
		// (set) Token: 0x0601A61F RID: 108063 RVA: 0x003D4922 File Offset: 0x003D2B22
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

		// Token: 0x170058FD RID: 22781
		// (get) Token: 0x0601A620 RID: 108064 RVA: 0x003D492B File Offset: 0x003D2B2B
		// (set) Token: 0x0601A621 RID: 108065 RVA: 0x003D4933 File Offset: 0x003D2B33
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

		// Token: 0x0601A622 RID: 108066 RVA: 0x003D493C File Offset: 0x003D2B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThrowDamageNotify);
		}

		// Token: 0x0601A623 RID: 108067 RVA: 0x003D494A File Offset: 0x003D2B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThrowDamageNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Durability == other.Durability && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A624 RID: 108068 RVA: 0x003D4988 File Offset: 0x003D2B88
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

		// Token: 0x0601A625 RID: 108069 RVA: 0x003D49E0 File Offset: 0x003D2BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A626 RID: 108070 RVA: 0x003D49ED File Offset: 0x003D2BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A627 RID: 108071 RVA: 0x003D49F8 File Offset: 0x003D2BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Durability != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Durability);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A628 RID: 108072 RVA: 0x003D4A54 File Offset: 0x003D2C54
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

		// Token: 0x0601A629 RID: 108073 RVA: 0x003D4AAC File Offset: 0x003D2CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThrowDamageNotify other)
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

		// Token: 0x0601A62A RID: 108074 RVA: 0x003D4AFC File Offset: 0x003D2CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A62B RID: 108075 RVA: 0x003D4B08 File Offset: 0x003D2D08
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
				if (num != 24U)
				{
					if (num != 96U)
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
					this.Durability = input.ReadInt32();
				}
			}
		}

		// Token: 0x040099A8 RID: 39336
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099A9 RID: 39337
		public const int EntityIdFieldNumber = 12;

		// Token: 0x040099AA RID: 39338
		private long entityId_;

		// Token: 0x040099AB RID: 39339
		public const int DurabilityFieldNumber = 3;

		// Token: 0x040099AC RID: 39340
		private int durability_;
	}
}
