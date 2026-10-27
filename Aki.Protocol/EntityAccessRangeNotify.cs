using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000460 RID: 1120
	[NetMessage(EMessageId.EntityAccessRangeNotify)]
	public sealed class EntityAccessRangeNotify : IMessage<EntityAccessRangeNotify>, IMessage, IEquatable<EntityAccessRangeNotify>, IDeepCloneable<EntityAccessRangeNotify>, IBufferMessage
	{
		// Token: 0x06006AF0 RID: 27376 RVA: 0x00101F04 File Offset: 0x00100104
		[NullableContext(1)]
		public static EntityAccessRangeNotify Create()
		{
			return new EntityAccessRangeNotify();
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06006AF1 RID: 27377 RVA: 0x00101F0B File Offset: 0x0010010B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06006AF2 RID: 27378 RVA: 0x00101F0E File Offset: 0x0010010E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAccessRangeNotify.Descriptor;
			}
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x00101F15 File Offset: 0x00100115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeNotify()
		{
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x00101F28 File Offset: 0x00100128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeNotify(EntityAccessRangeNotify other) : this()
		{
			this.rangeEntiyId_ = other.rangeEntiyId_;
			this.accessEntityIds_ = other.accessEntityIds_.Clone();
			this.accessRangeType_ = other.accessRangeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x00101F75 File Offset: 0x00100175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeNotify Clone()
		{
			return new EntityAccessRangeNotify(this);
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06006AF6 RID: 27382 RVA: 0x00101F7D File Offset: 0x0010017D
		// (set) Token: 0x06006AF7 RID: 27383 RVA: 0x00101F85 File Offset: 0x00100185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RangeEntiyId
		{
			get
			{
				return this.rangeEntiyId_;
			}
			set
			{
				this.rangeEntiyId_ = value;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06006AF8 RID: 27384 RVA: 0x00101F8E File Offset: 0x0010018E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> AccessEntityIds
		{
			get
			{
				return this.accessEntityIds_;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06006AF9 RID: 27385 RVA: 0x00101F96 File Offset: 0x00100196
		// (set) Token: 0x06006AFA RID: 27386 RVA: 0x00101F9E File Offset: 0x0010019E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeType AccessRangeType
		{
			get
			{
				return this.accessRangeType_;
			}
			set
			{
				this.accessRangeType_ = value;
			}
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x00101FA7 File Offset: 0x001001A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAccessRangeNotify);
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x00101FB8 File Offset: 0x001001B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAccessRangeNotify other)
		{
			return other != null && (other == this || (this.RangeEntiyId == other.RangeEntiyId && this.accessEntityIds_.Equals(other.accessEntityIds_) && this.AccessRangeType == other.AccessRangeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006AFD RID: 27389 RVA: 0x00102018 File Offset: 0x00100218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RangeEntiyId != 0L)
			{
				num ^= this.RangeEntiyId.GetHashCode();
			}
			num ^= this.accessEntityIds_.GetHashCode();
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				num ^= this.AccessRangeType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006AFE RID: 27390 RVA: 0x00102084 File Offset: 0x00100284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x00102091 File Offset: 0x00100291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x0010209C File Offset: 0x0010029C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.accessEntityIds_.WriteTo(ref output, EntityAccessRangeNotify._repeated_accessEntityIds_codec);
			if (this.RangeEntiyId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.RangeEntiyId);
			}
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.AccessRangeType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x00102108 File Offset: 0x00100308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RangeEntiyId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RangeEntiyId);
			}
			num += this.accessEntityIds_.CalculateSize(EntityAccessRangeNotify._repeated_accessEntityIds_codec);
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AccessRangeType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B02 RID: 27394 RVA: 0x00102174 File Offset: 0x00100374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAccessRangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RangeEntiyId != 0L)
			{
				this.RangeEntiyId = other.RangeEntiyId;
			}
			this.accessEntityIds_.Add(other.accessEntityIds_);
			if (other.AccessRangeType != AccessRangeType.RangeEnter)
			{
				this.AccessRangeType = other.AccessRangeType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x001021D5 File Offset: 0x001003D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x001021E0 File Offset: 0x001003E0
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
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.accessEntityIds_.AddEntriesFrom(ref input, EntityAccessRangeNotify._repeated_accessEntityIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.RangeEntiyId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.AccessRangeType = (AccessRangeType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A69 RID: 14953
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A6A RID: 14954
		public const int RangeEntiyIdFieldNumber = 9;

		// Token: 0x04003A6B RID: 14955
		private long rangeEntiyId_;

		// Token: 0x04003A6C RID: 14956
		public const int AccessEntityIdsFieldNumber = 4;

		// Token: 0x04003A6D RID: 14957
		private static readonly FieldCodec<long> _repeated_accessEntityIds_codec = FieldCodec.ForInt64(34U);

		// Token: 0x04003A6E RID: 14958
		private readonly RepeatedField<long> accessEntityIds_ = new RepeatedField<long>();

		// Token: 0x04003A6F RID: 14959
		public const int AccessRangeTypeFieldNumber = 15;

		// Token: 0x04003A70 RID: 14960
		private AccessRangeType accessRangeType_;
	}
}
