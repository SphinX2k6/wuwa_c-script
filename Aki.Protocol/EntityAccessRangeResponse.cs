using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000462 RID: 1122
	[NetMessage(EMessageId.EntityAccessRangeResponse)]
	public sealed class EntityAccessRangeResponse : IMessage<EntityAccessRangeResponse>, IMessage, IEquatable<EntityAccessRangeResponse>, IDeepCloneable<EntityAccessRangeResponse>, IBufferMessage
	{
		// Token: 0x06006B1C RID: 27420 RVA: 0x001025D2 File Offset: 0x001007D2
		[NullableContext(1)]
		public static EntityAccessRangeResponse Create()
		{
			return new EntityAccessRangeResponse();
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06006B1D RID: 27421 RVA: 0x001025D9 File Offset: 0x001007D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06006B1E RID: 27422 RVA: 0x001025DC File Offset: 0x001007DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAccessRangeResponse.Descriptor;
			}
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x001025E3 File Offset: 0x001007E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeResponse()
		{
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x001025F8 File Offset: 0x001007F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeResponse(EntityAccessRangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rangeEntityId_ = other.rangeEntityId_;
			this.entitiesAccessRangeResult_ = other.entitiesAccessRangeResult_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x00102645 File Offset: 0x00100845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeResponse Clone()
		{
			return new EntityAccessRangeResponse(this);
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06006B22 RID: 27426 RVA: 0x0010264D File Offset: 0x0010084D
		// (set) Token: 0x06006B23 RID: 27427 RVA: 0x00102655 File Offset: 0x00100855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06006B24 RID: 27428 RVA: 0x0010265E File Offset: 0x0010085E
		// (set) Token: 0x06006B25 RID: 27429 RVA: 0x00102666 File Offset: 0x00100866
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

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06006B26 RID: 27430 RVA: 0x0010266F File Offset: 0x0010086F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AccessRangeResultMessage> EntitiesAccessRangeResult
		{
			get
			{
				return this.entitiesAccessRangeResult_;
			}
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x00102677 File Offset: 0x00100877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAccessRangeResponse);
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x00102688 File Offset: 0x00100888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAccessRangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RangeEntityId == other.RangeEntityId && this.entitiesAccessRangeResult_.Equals(other.entitiesAccessRangeResult_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x001026E8 File Offset: 0x001008E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.RangeEntityId != 0L)
			{
				num ^= this.RangeEntityId.GetHashCode();
			}
			num ^= this.entitiesAccessRangeResult_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B2A RID: 27434 RVA: 0x00102754 File Offset: 0x00100954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B2B RID: 27435 RVA: 0x00102761 File Offset: 0x00100961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B2C RID: 27436 RVA: 0x0010276C File Offset: 0x0010096C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.entitiesAccessRangeResult_.WriteTo(ref output, EntityAccessRangeResponse._repeated_entitiesAccessRangeResult_codec);
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.RangeEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B2D RID: 27437 RVA: 0x001027D8 File Offset: 0x001009D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.RangeEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RangeEntityId);
			}
			num += this.entitiesAccessRangeResult_.CalculateSize(EntityAccessRangeResponse._repeated_entitiesAccessRangeResult_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B2E RID: 27438 RVA: 0x00102844 File Offset: 0x00100A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAccessRangeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.RangeEntityId != 0L)
			{
				this.RangeEntityId = other.RangeEntityId;
			}
			this.entitiesAccessRangeResult_.Add(other.entitiesAccessRangeResult_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B2F RID: 27439 RVA: 0x001028A5 File Offset: 0x00100AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B30 RID: 27440 RVA: 0x001028B0 File Offset: 0x00100AB0
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
				if (num != 16U)
				{
					if (num != 74U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RangeEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.entitiesAccessRangeResult_.AddEntriesFrom(ref input, EntityAccessRangeResponse._repeated_entitiesAccessRangeResult_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003A79 RID: 14969
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A7A RID: 14970
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04003A7B RID: 14971
		private ErrorCode errorCode_;

		// Token: 0x04003A7C RID: 14972
		public const int RangeEntityIdFieldNumber = 10;

		// Token: 0x04003A7D RID: 14973
		private long rangeEntityId_;

		// Token: 0x04003A7E RID: 14974
		public const int EntitiesAccessRangeResultFieldNumber = 9;

		// Token: 0x04003A7F RID: 14975
		private static readonly FieldCodec<AccessRangeResultMessage> _repeated_entitiesAccessRangeResult_codec = FieldCodec.ForMessage<AccessRangeResultMessage>(74U, AccessRangeResultMessage.Parser);

		// Token: 0x04003A80 RID: 14976
		private readonly RepeatedField<AccessRangeResultMessage> entitiesAccessRangeResult_ = new RepeatedField<AccessRangeResultMessage>();
	}
}
