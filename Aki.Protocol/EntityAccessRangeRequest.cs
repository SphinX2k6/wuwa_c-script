using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000461 RID: 1121
	[NetMessage(EMessageId.EntityAccessRangeRequest)]
	public sealed class EntityAccessRangeRequest : IMessage<EntityAccessRangeRequest>, IMessage, IEquatable<EntityAccessRangeRequest>, IDeepCloneable<EntityAccessRangeRequest>, IBufferMessage
	{
		// Token: 0x06006B06 RID: 27398 RVA: 0x0010226A File Offset: 0x0010046A
		[NullableContext(1)]
		public static EntityAccessRangeRequest Create()
		{
			return new EntityAccessRangeRequest();
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06006B07 RID: 27399 RVA: 0x00102271 File Offset: 0x00100471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06006B08 RID: 27400 RVA: 0x00102274 File Offset: 0x00100474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAccessRangeRequest.Descriptor;
			}
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x0010227B File Offset: 0x0010047B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeRequest()
		{
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x00102290 File Offset: 0x00100490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeRequest(EntityAccessRangeRequest other) : this()
		{
			this.rangeEntityId_ = other.rangeEntityId_;
			this.accessEntityIds_ = other.accessEntityIds_.Clone();
			this.accessRangeType_ = other.accessRangeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x001022DD File Offset: 0x001004DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeRequest Clone()
		{
			return new EntityAccessRangeRequest(this);
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06006B0C RID: 27404 RVA: 0x001022E5 File Offset: 0x001004E5
		// (set) Token: 0x06006B0D RID: 27405 RVA: 0x001022ED File Offset: 0x001004ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RangeEntityId
		{
			get
			{
				return this.rangeEntityId_;
			}
			set
			{
				this.rangeEntityId_ = value;
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06006B0E RID: 27406 RVA: 0x001022F6 File Offset: 0x001004F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> AccessEntityIds
		{
			get
			{
				return this.accessEntityIds_;
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06006B0F RID: 27407 RVA: 0x001022FE File Offset: 0x001004FE
		// (set) Token: 0x06006B10 RID: 27408 RVA: 0x00102306 File Offset: 0x00100506
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

		// Token: 0x06006B11 RID: 27409 RVA: 0x0010230F File Offset: 0x0010050F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAccessRangeRequest);
		}

		// Token: 0x06006B12 RID: 27410 RVA: 0x00102320 File Offset: 0x00100520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAccessRangeRequest other)
		{
			return other != null && (other == this || (this.RangeEntityId == other.RangeEntityId && this.accessEntityIds_.Equals(other.accessEntityIds_) && this.AccessRangeType == other.AccessRangeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B13 RID: 27411 RVA: 0x00102380 File Offset: 0x00100580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RangeEntityId != 0L)
			{
				num ^= this.RangeEntityId.GetHashCode();
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

		// Token: 0x06006B14 RID: 27412 RVA: 0x001023EC File Offset: 0x001005EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B15 RID: 27413 RVA: 0x001023F9 File Offset: 0x001005F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x00102404 File Offset: 0x00100604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.AccessRangeType);
			}
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.RangeEntityId);
			}
			this.accessEntityIds_.WriteTo(ref output, EntityAccessRangeRequest._repeated_accessEntityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x00102470 File Offset: 0x00100670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RangeEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RangeEntityId);
			}
			num += this.accessEntityIds_.CalculateSize(EntityAccessRangeRequest._repeated_accessEntityIds_codec);
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

		// Token: 0x06006B18 RID: 27416 RVA: 0x001024DC File Offset: 0x001006DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAccessRangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RangeEntityId != 0L)
			{
				this.RangeEntityId = other.RangeEntityId;
			}
			this.accessEntityIds_.Add(other.accessEntityIds_);
			if (other.AccessRangeType != AccessRangeType.RangeEnter)
			{
				this.AccessRangeType = other.AccessRangeType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x0010253D File Offset: 0x0010073D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B1A RID: 27418 RVA: 0x00102548 File Offset: 0x00100748
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
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.AccessRangeType = (AccessRangeType)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.RangeEntityId = input.ReadInt64();
						continue;
					}
				}
				else if (num == 72U || num == 74U)
				{
					this.accessEntityIds_.AddEntriesFrom(ref input, EntityAccessRangeRequest._repeated_accessEntityIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A71 RID: 14961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A72 RID: 14962
		public const int RangeEntityIdFieldNumber = 5;

		// Token: 0x04003A73 RID: 14963
		private long rangeEntityId_;

		// Token: 0x04003A74 RID: 14964
		public const int AccessEntityIdsFieldNumber = 9;

		// Token: 0x04003A75 RID: 14965
		private static readonly FieldCodec<long> _repeated_accessEntityIds_codec = FieldCodec.ForInt64(74U);

		// Token: 0x04003A76 RID: 14966
		private readonly RepeatedField<long> accessEntityIds_ = new RepeatedField<long>();

		// Token: 0x04003A77 RID: 14967
		public const int AccessRangeTypeFieldNumber = 4;

		// Token: 0x04003A78 RID: 14968
		private AccessRangeType accessRangeType_;
	}
}
