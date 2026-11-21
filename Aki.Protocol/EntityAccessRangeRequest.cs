using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044A RID: 1098
	[NetMessage(EMessageId.EntityAccessRangeRequest)]
	public sealed class EntityAccessRangeRequest : IMessage<EntityAccessRangeRequest>, IMessage, IEquatable<EntityAccessRangeRequest>, IDeepCloneable<EntityAccessRangeRequest>, IBufferMessage
	{
		// Token: 0x06006978 RID: 27000 RVA: 0x000FF201 File Offset: 0x000FD401
		[NullableContext(1)]
		public static EntityAccessRangeRequest Create()
		{
			return new EntityAccessRangeRequest();
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06006979 RID: 27001 RVA: 0x000FF208 File Offset: 0x000FD408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x0600697A RID: 27002 RVA: 0x000FF20B File Offset: 0x000FD40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAccessRangeRequest.Descriptor;
			}
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x000FF212 File Offset: 0x000FD412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeRequest()
		{
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x000FF228 File Offset: 0x000FD428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeRequest(EntityAccessRangeRequest other) : this()
		{
			this.rangeEntityId_ = other.rangeEntityId_;
			this.accessEntityIds_ = other.accessEntityIds_.Clone();
			this.accessRangeType_ = other.accessRangeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x000FF275 File Offset: 0x000FD475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeRequest Clone()
		{
			return new EntityAccessRangeRequest(this);
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x0600697E RID: 27006 RVA: 0x000FF27D File Offset: 0x000FD47D
		// (set) Token: 0x0600697F RID: 27007 RVA: 0x000FF285 File Offset: 0x000FD485
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

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x06006980 RID: 27008 RVA: 0x000FF28E File Offset: 0x000FD48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> AccessEntityIds
		{
			get
			{
				return this.accessEntityIds_;
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x06006981 RID: 27009 RVA: 0x000FF296 File Offset: 0x000FD496
		// (set) Token: 0x06006982 RID: 27010 RVA: 0x000FF29E File Offset: 0x000FD49E
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

		// Token: 0x06006983 RID: 27011 RVA: 0x000FF2A7 File Offset: 0x000FD4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAccessRangeRequest);
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x000FF2B8 File Offset: 0x000FD4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAccessRangeRequest other)
		{
			return other != null && (other == this || (this.RangeEntityId == other.RangeEntityId && this.accessEntityIds_.Equals(other.accessEntityIds_) && this.AccessRangeType == other.AccessRangeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x000FF318 File Offset: 0x000FD518
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

		// Token: 0x06006986 RID: 27014 RVA: 0x000FF384 File Offset: 0x000FD584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x000FF391 File Offset: 0x000FD591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x000FF39C File Offset: 0x000FD59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.AccessRangeType);
			}
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.RangeEntityId);
			}
			this.accessEntityIds_.WriteTo(ref output, EntityAccessRangeRequest._repeated_accessEntityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x000FF408 File Offset: 0x000FD608
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

		// Token: 0x0600698A RID: 27018 RVA: 0x000FF474 File Offset: 0x000FD674
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

		// Token: 0x0600698B RID: 27019 RVA: 0x000FF4D5 File Offset: 0x000FD6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x000FF4E0 File Offset: 0x000FD6E0
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
				if (num <= 72U)
				{
					if (num == 56U)
					{
						this.AccessRangeType = (AccessRangeType)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.RangeEntityId = input.ReadInt64();
						continue;
					}
				}
				else if (num == 80U || num == 82U)
				{
					this.accessEntityIds_.AddEntriesFrom(ref input, EntityAccessRangeRequest._repeated_accessEntityIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A5F RID: 14943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A60 RID: 14944
		public const int RangeEntityIdFieldNumber = 9;

		// Token: 0x04003A61 RID: 14945
		private long rangeEntityId_;

		// Token: 0x04003A62 RID: 14946
		public const int AccessEntityIdsFieldNumber = 10;

		// Token: 0x04003A63 RID: 14947
		private static readonly FieldCodec<long> _repeated_accessEntityIds_codec = FieldCodec.ForInt64(82U);

		// Token: 0x04003A64 RID: 14948
		private readonly RepeatedField<long> accessEntityIds_ = new RepeatedField<long>();

		// Token: 0x04003A65 RID: 14949
		public const int AccessRangeTypeFieldNumber = 7;

		// Token: 0x04003A66 RID: 14950
		private AccessRangeType accessRangeType_;
	}
}
