using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000449 RID: 1097
	[NetMessage(EMessageId.EntityAccessRangeNotify)]
	public sealed class EntityAccessRangeNotify : IMessage<EntityAccessRangeNotify>, IMessage, IEquatable<EntityAccessRangeNotify>, IDeepCloneable<EntityAccessRangeNotify>, IBufferMessage
	{
		// Token: 0x06006962 RID: 26978 RVA: 0x000FEE9C File Offset: 0x000FD09C
		[NullableContext(1)]
		public static EntityAccessRangeNotify Create()
		{
			return new EntityAccessRangeNotify();
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x06006963 RID: 26979 RVA: 0x000FEEA3 File Offset: 0x000FD0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06006964 RID: 26980 RVA: 0x000FEEA6 File Offset: 0x000FD0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAccessRangeNotify.Descriptor;
			}
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x000FEEAD File Offset: 0x000FD0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeNotify()
		{
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x000FEEC0 File Offset: 0x000FD0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeNotify(EntityAccessRangeNotify other) : this()
		{
			this.rangeEntiyId_ = other.rangeEntiyId_;
			this.accessEntityIds_ = other.accessEntityIds_.Clone();
			this.accessRangeType_ = other.accessRangeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x000FEF0D File Offset: 0x000FD10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessRangeNotify Clone()
		{
			return new EntityAccessRangeNotify(this);
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06006968 RID: 26984 RVA: 0x000FEF15 File Offset: 0x000FD115
		// (set) Token: 0x06006969 RID: 26985 RVA: 0x000FEF1D File Offset: 0x000FD11D
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

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x0600696A RID: 26986 RVA: 0x000FEF26 File Offset: 0x000FD126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> AccessEntityIds
		{
			get
			{
				return this.accessEntityIds_;
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x0600696B RID: 26987 RVA: 0x000FEF2E File Offset: 0x000FD12E
		// (set) Token: 0x0600696C RID: 26988 RVA: 0x000FEF36 File Offset: 0x000FD136
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

		// Token: 0x0600696D RID: 26989 RVA: 0x000FEF3F File Offset: 0x000FD13F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAccessRangeNotify);
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x000FEF50 File Offset: 0x000FD150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAccessRangeNotify other)
		{
			return other != null && (other == this || (this.RangeEntiyId == other.RangeEntiyId && this.accessEntityIds_.Equals(other.accessEntityIds_) && this.AccessRangeType == other.AccessRangeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x000FEFB0 File Offset: 0x000FD1B0
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

		// Token: 0x06006970 RID: 26992 RVA: 0x000FF01C File Offset: 0x000FD21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x000FF029 File Offset: 0x000FD229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006972 RID: 26994 RVA: 0x000FF034 File Offset: 0x000FD234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RangeEntiyId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.RangeEntiyId);
			}
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.AccessRangeType);
			}
			this.accessEntityIds_.WriteTo(ref output, EntityAccessRangeNotify._repeated_accessEntityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006973 RID: 26995 RVA: 0x000FF0A0 File Offset: 0x000FD2A0
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

		// Token: 0x06006974 RID: 26996 RVA: 0x000FF10C File Offset: 0x000FD30C
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

		// Token: 0x06006975 RID: 26997 RVA: 0x000FF16D File Offset: 0x000FD36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006976 RID: 26998 RVA: 0x000FF178 File Offset: 0x000FD378
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
				if (num <= 88U)
				{
					if (num == 8U)
					{
						this.RangeEntiyId = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.AccessRangeType = (AccessRangeType)input.ReadEnum();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.accessEntityIds_.AddEntriesFrom(ref input, EntityAccessRangeNotify._repeated_accessEntityIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A57 RID: 14935
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A58 RID: 14936
		public const int RangeEntiyIdFieldNumber = 1;

		// Token: 0x04003A59 RID: 14937
		private long rangeEntiyId_;

		// Token: 0x04003A5A RID: 14938
		public const int AccessEntityIdsFieldNumber = 15;

		// Token: 0x04003A5B RID: 14939
		private static readonly FieldCodec<long> _repeated_accessEntityIds_codec = FieldCodec.ForInt64(122U);

		// Token: 0x04003A5C RID: 14940
		private readonly RepeatedField<long> accessEntityIds_ = new RepeatedField<long>();

		// Token: 0x04003A5D RID: 14941
		public const int AccessRangeTypeFieldNumber = 11;

		// Token: 0x04003A5E RID: 14942
		private AccessRangeType accessRangeType_;
	}
}
