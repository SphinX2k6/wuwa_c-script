using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047B RID: 1147
	public sealed class EntityGridPbData : IMessage<EntityGridPbData>, IMessage, IEquatable<EntityGridPbData>, IDeepCloneable<EntityGridPbData>, IBufferMessage
	{
		// Token: 0x06006E4A RID: 28234 RVA: 0x0010F924 File Offset: 0x0010DB24
		[NullableContext(1)]
		public static EntityGridPbData Create()
		{
			return new EntityGridPbData();
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06006E4B RID: 28235 RVA: 0x0010F92B File Offset: 0x0010DB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06006E4C RID: 28236 RVA: 0x0010F92E File Offset: 0x0010DB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityGridPbData.Descriptor;
			}
		}

		// Token: 0x06006E4D RID: 28237 RVA: 0x0010F935 File Offset: 0x0010DB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGridPbData()
		{
		}

		// Token: 0x06006E4E RID: 28238 RVA: 0x0010F93D File Offset: 0x0010DB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGridPbData(EntityGridPbData other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E4F RID: 28239 RVA: 0x0010F962 File Offset: 0x0010DB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGridPbData Clone()
		{
			return new EntityGridPbData(this);
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06006E50 RID: 28240 RVA: 0x0010F96A File Offset: 0x0010DB6A
		// (set) Token: 0x06006E51 RID: 28241 RVA: 0x0010F972 File Offset: 0x0010DB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06006E52 RID: 28242 RVA: 0x0010F97B File Offset: 0x0010DB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityGridPbData);
		}

		// Token: 0x06006E53 RID: 28243 RVA: 0x0010F989 File Offset: 0x0010DB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityGridPbData other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E54 RID: 28244 RVA: 0x0010F9B8 File Offset: 0x0010DBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E55 RID: 28245 RVA: 0x0010F9F7 File Offset: 0x0010DBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006E56 RID: 28246 RVA: 0x0010FA04 File Offset: 0x0010DC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E57 RID: 28247 RVA: 0x0010FA0D File Offset: 0x0010DC0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x0010FA40 File Offset: 0x0010DC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x0010FA7E File Offset: 0x0010DC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityGridPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x0010FAAF File Offset: 0x0010DCAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E5B RID: 28251 RVA: 0x0010FAB8 File Offset: 0x0010DCB8
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003BFE RID: 15358
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BFF RID: 15359
		public const int IdFieldNumber = 1;

		// Token: 0x04003C00 RID: 15360
		private long id_;
	}
}
