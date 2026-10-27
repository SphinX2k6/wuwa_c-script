using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D52 RID: 3410
	public sealed class PinballMonsterKilledCtxPb : IMessage<PinballMonsterKilledCtxPb>, IMessage, IEquatable<PinballMonsterKilledCtxPb>, IDeepCloneable<PinballMonsterKilledCtxPb>, IBufferMessage
	{
		// Token: 0x06012650 RID: 75344 RVA: 0x002AF374 File Offset: 0x002AD574
		[NullableContext(1)]
		public static PinballMonsterKilledCtxPb Create()
		{
			return new PinballMonsterKilledCtxPb();
		}

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x06012651 RID: 75345 RVA: 0x002AF37B File Offset: 0x002AD57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x06012652 RID: 75346 RVA: 0x002AF37E File Offset: 0x002AD57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballMonsterKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x06012653 RID: 75347 RVA: 0x002AF385 File Offset: 0x002AD585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballMonsterKilledCtxPb()
		{
		}

		// Token: 0x06012654 RID: 75348 RVA: 0x002AF38D File Offset: 0x002AD58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballMonsterKilledCtxPb(PinballMonsterKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012655 RID: 75349 RVA: 0x002AF3B2 File Offset: 0x002AD5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballMonsterKilledCtxPb Clone()
		{
			return new PinballMonsterKilledCtxPb(this);
		}

		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x06012656 RID: 75350 RVA: 0x002AF3BA File Offset: 0x002AD5BA
		// (set) Token: 0x06012657 RID: 75351 RVA: 0x002AF3C2 File Offset: 0x002AD5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
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

		// Token: 0x06012658 RID: 75352 RVA: 0x002AF3CB File Offset: 0x002AD5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballMonsterKilledCtxPb);
		}

		// Token: 0x06012659 RID: 75353 RVA: 0x002AF3D9 File Offset: 0x002AD5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballMonsterKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601265A RID: 75354 RVA: 0x002AF408 File Offset: 0x002AD608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601265B RID: 75355 RVA: 0x002AF447 File Offset: 0x002AD647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601265C RID: 75356 RVA: 0x002AF454 File Offset: 0x002AD654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601265D RID: 75357 RVA: 0x002AF45D File Offset: 0x002AD65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601265E RID: 75358 RVA: 0x002AF490 File Offset: 0x002AD690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601265F RID: 75359 RVA: 0x002AF4CE File Offset: 0x002AD6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballMonsterKilledCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012660 RID: 75360 RVA: 0x002AF4FF File Offset: 0x002AD6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012661 RID: 75361 RVA: 0x002AF508 File Offset: 0x002AD708
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007288 RID: 29320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007289 RID: 29321
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400728A RID: 29322
		private long entityId_;
	}
}
