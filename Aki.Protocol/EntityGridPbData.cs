using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000492 RID: 1170
	public sealed class EntityGridPbData : IMessage<EntityGridPbData>, IMessage, IEquatable<EntityGridPbData>, IDeepCloneable<EntityGridPbData>, IBufferMessage
	{
		// Token: 0x06006FD8 RID: 28632 RVA: 0x00112998 File Offset: 0x00110B98
		[NullableContext(1)]
		public static EntityGridPbData Create()
		{
			return new EntityGridPbData();
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06006FD9 RID: 28633 RVA: 0x0011299F File Offset: 0x00110B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06006FDA RID: 28634 RVA: 0x001129A2 File Offset: 0x00110BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityGridPbData.Descriptor;
			}
		}

		// Token: 0x06006FDB RID: 28635 RVA: 0x001129A9 File Offset: 0x00110BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGridPbData()
		{
		}

		// Token: 0x06006FDC RID: 28636 RVA: 0x001129B1 File Offset: 0x00110BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGridPbData(EntityGridPbData other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x001129D6 File Offset: 0x00110BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGridPbData Clone()
		{
			return new EntityGridPbData(this);
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06006FDE RID: 28638 RVA: 0x001129DE File Offset: 0x00110BDE
		// (set) Token: 0x06006FDF RID: 28639 RVA: 0x001129E6 File Offset: 0x00110BE6
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

		// Token: 0x06006FE0 RID: 28640 RVA: 0x001129EF File Offset: 0x00110BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityGridPbData);
		}

		// Token: 0x06006FE1 RID: 28641 RVA: 0x001129FD File Offset: 0x00110BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityGridPbData other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x00112A2C File Offset: 0x00110C2C
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

		// Token: 0x06006FE3 RID: 28643 RVA: 0x00112A6B File Offset: 0x00110C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006FE4 RID: 28644 RVA: 0x00112A78 File Offset: 0x00110C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x00112A81 File Offset: 0x00110C81
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

		// Token: 0x06006FE6 RID: 28646 RVA: 0x00112AB4 File Offset: 0x00110CB4
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

		// Token: 0x06006FE7 RID: 28647 RVA: 0x00112AF2 File Offset: 0x00110CF2
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

		// Token: 0x06006FE8 RID: 28648 RVA: 0x00112B23 File Offset: 0x00110D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x00112B2C File Offset: 0x00110D2C
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

		// Token: 0x04003C10 RID: 15376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C11 RID: 15377
		public const int IdFieldNumber = 1;

		// Token: 0x04003C12 RID: 15378
		private long id_;
	}
}
