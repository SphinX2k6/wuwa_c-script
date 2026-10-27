using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B3 RID: 1203
	[NetMessage(EMessageId.EntityPosResetNotify)]
	public sealed class EntityPosResetNotify : IMessage<EntityPosResetNotify>, IMessage, IEquatable<EntityPosResetNotify>, IDeepCloneable<EntityPosResetNotify>, IBufferMessage
	{
		// Token: 0x060072A6 RID: 29350 RVA: 0x00119579 File Offset: 0x00117779
		[NullableContext(1)]
		public static EntityPosResetNotify Create()
		{
			return new EntityPosResetNotify();
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x060072A7 RID: 29351 RVA: 0x00119580 File Offset: 0x00117780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x060072A8 RID: 29352 RVA: 0x00119583 File Offset: 0x00117783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPosResetNotify.Descriptor;
			}
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x0011958A File Offset: 0x0011778A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosResetNotify()
		{
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x00119592 File Offset: 0x00117792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosResetNotify(EntityPosResetNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x001195B7 File Offset: 0x001177B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosResetNotify Clone()
		{
			return new EntityPosResetNotify(this);
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x060072AC RID: 29356 RVA: 0x001195BF File Offset: 0x001177BF
		// (set) Token: 0x060072AD RID: 29357 RVA: 0x001195C7 File Offset: 0x001177C7
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

		// Token: 0x060072AE RID: 29358 RVA: 0x001195D0 File Offset: 0x001177D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPosResetNotify);
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x001195DE File Offset: 0x001177DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPosResetNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x0011960C File Offset: 0x0011780C
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

		// Token: 0x060072B1 RID: 29361 RVA: 0x0011964B File Offset: 0x0011784B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x00119658 File Offset: 0x00117858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x00119661 File Offset: 0x00117861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x00119694 File Offset: 0x00117894
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

		// Token: 0x060072B5 RID: 29365 RVA: 0x001196D2 File Offset: 0x001178D2
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

		// Token: 0x060072B6 RID: 29366 RVA: 0x00119703 File Offset: 0x00117903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x0011970C File Offset: 0x0011790C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003CF1 RID: 15601
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CF2 RID: 15602
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003CF3 RID: 15603
		private int entityId_;
	}
}
