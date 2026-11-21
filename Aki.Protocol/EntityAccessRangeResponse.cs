using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044B RID: 1099
	[NetMessage(EMessageId.EntityAccessRangeResponse)]
	public sealed class EntityAccessRangeResponse : IMessage<EntityAccessRangeResponse>, IMessage, IEquatable<EntityAccessRangeResponse>, IDeepCloneable<EntityAccessRangeResponse>, IBufferMessage
	{
		// Token: 0x0600698E RID: 27022 RVA: 0x000FF56A File Offset: 0x000FD76A
		[NullableContext(1)]
		public static EntityAccessRangeResponse Create()
		{
			return new EntityAccessRangeResponse();
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x0600698F RID: 27023 RVA: 0x000FF571 File Offset: 0x000FD771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x06006990 RID: 27024 RVA: 0x000FF574 File Offset: 0x000FD774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAccessRangeResponse.Descriptor;
			}
		}

		// Token: 0x06006991 RID: 27025 RVA: 0x000FF57B File Offset: 0x000FD77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeResponse()
		{
		}

		// Token: 0x06006992 RID: 27026 RVA: 0x000FF590 File Offset: 0x000FD790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeResponse(EntityAccessRangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rangeEntityId_ = other.rangeEntityId_;
			this.entitiesAccessRangeResult_ = other.entitiesAccessRangeResult_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x000FF5DD File Offset: 0x000FD7DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeResponse Clone()
		{
			return new EntityAccessRangeResponse(this);
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x06006994 RID: 27028 RVA: 0x000FF5E5 File Offset: 0x000FD7E5
		// (set) Token: 0x06006995 RID: 27029 RVA: 0x000FF5ED File Offset: 0x000FD7ED
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

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x06006996 RID: 27030 RVA: 0x000FF5F6 File Offset: 0x000FD7F6
		// (set) Token: 0x06006997 RID: 27031 RVA: 0x000FF5FE File Offset: 0x000FD7FE
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

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x06006998 RID: 27032 RVA: 0x000FF607 File Offset: 0x000FD807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AccessRangeResultMessage> EntitiesAccessRangeResult
		{
			get
			{
				return this.entitiesAccessRangeResult_;
			}
		}

		// Token: 0x06006999 RID: 27033 RVA: 0x000FF60F File Offset: 0x000FD80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAccessRangeResponse);
		}

		// Token: 0x0600699A RID: 27034 RVA: 0x000FF620 File Offset: 0x000FD820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAccessRangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RangeEntityId == other.RangeEntityId && this.entitiesAccessRangeResult_.Equals(other.entitiesAccessRangeResult_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600699B RID: 27035 RVA: 0x000FF680 File Offset: 0x000FD880
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

		// Token: 0x0600699C RID: 27036 RVA: 0x000FF6EC File Offset: 0x000FD8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x000FF6F9 File Offset: 0x000FD8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x000FF704 File Offset: 0x000FD904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.RangeEntityId);
			}
			this.entitiesAccessRangeResult_.WriteTo(ref output, EntityAccessRangeResponse._repeated_entitiesAccessRangeResult_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x000FF770 File Offset: 0x000FD970
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

		// Token: 0x060069A0 RID: 27040 RVA: 0x000FF7DC File Offset: 0x000FD9DC
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

		// Token: 0x060069A1 RID: 27041 RVA: 0x000FF83D File Offset: 0x000FDA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x000FF848 File Offset: 0x000FDA48
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
					if (num != 64U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.entitiesAccessRangeResult_.AddEntriesFrom(ref input, EntityAccessRangeResponse._repeated_entitiesAccessRangeResult_codec);
						}
					}
					else
					{
						this.RangeEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003A67 RID: 14951
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A68 RID: 14952
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04003A69 RID: 14953
		private ErrorCode errorCode_;

		// Token: 0x04003A6A RID: 14954
		public const int RangeEntityIdFieldNumber = 8;

		// Token: 0x04003A6B RID: 14955
		private long rangeEntityId_;

		// Token: 0x04003A6C RID: 14956
		public const int EntitiesAccessRangeResultFieldNumber = 14;

		// Token: 0x04003A6D RID: 14957
		private static readonly FieldCodec<AccessRangeResultMessage> _repeated_entitiesAccessRangeResult_codec = FieldCodec.ForMessage<AccessRangeResultMessage>(114U, AccessRangeResultMessage.Parser);

		// Token: 0x04003A6E RID: 14958
		private readonly RepeatedField<AccessRangeResultMessage> entitiesAccessRangeResult_ = new RepeatedField<AccessRangeResultMessage>();
	}
}
