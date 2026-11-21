using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049C RID: 1180
	[NetMessage(EMessageId.EntityPosResetNotify)]
	public sealed class EntityPosResetNotify : IMessage<EntityPosResetNotify>, IMessage, IEquatable<EntityPosResetNotify>, IDeepCloneable<EntityPosResetNotify>, IBufferMessage
	{
		// Token: 0x06007116 RID: 28950 RVA: 0x00116455 File Offset: 0x00114655
		[NullableContext(1)]
		public static EntityPosResetNotify Create()
		{
			return new EntityPosResetNotify();
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06007117 RID: 28951 RVA: 0x0011645C File Offset: 0x0011465C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06007118 RID: 28952 RVA: 0x0011645F File Offset: 0x0011465F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPosResetNotify.Descriptor;
			}
		}

		// Token: 0x06007119 RID: 28953 RVA: 0x00116466 File Offset: 0x00114666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosResetNotify()
		{
		}

		// Token: 0x0600711A RID: 28954 RVA: 0x0011646E File Offset: 0x0011466E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosResetNotify(EntityPosResetNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x00116493 File Offset: 0x00114693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosResetNotify Clone()
		{
			return new EntityPosResetNotify(this);
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x0600711C RID: 28956 RVA: 0x0011649B File Offset: 0x0011469B
		// (set) Token: 0x0600711D RID: 28957 RVA: 0x001164A3 File Offset: 0x001146A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
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

		// Token: 0x0600711E RID: 28958 RVA: 0x001164AC File Offset: 0x001146AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPosResetNotify);
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x001164BA File Offset: 0x001146BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPosResetNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x001164E8 File Offset: 0x001146E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007121 RID: 28961 RVA: 0x00116527 File Offset: 0x00114727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x00116534 File Offset: 0x00114734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x0011653D File Offset: 0x0011473D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x00116570 File Offset: 0x00114770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007125 RID: 28965 RVA: 0x001165AE File Offset: 0x001147AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPosResetNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x001165DF File Offset: 0x001147DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007127 RID: 28967 RVA: 0x001165E8 File Offset: 0x001147E8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003CDD RID: 15581
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CDE RID: 15582
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04003CDF RID: 15583
		private int entityId_;
	}
}
