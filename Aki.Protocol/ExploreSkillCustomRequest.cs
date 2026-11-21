using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004EE RID: 1262
	[NetMessage(EMessageId.ExploreSkillCustomRequest)]
	public sealed class ExploreSkillCustomRequest : IMessage<ExploreSkillCustomRequest>, IMessage, IEquatable<ExploreSkillCustomRequest>, IDeepCloneable<ExploreSkillCustomRequest>, IBufferMessage
	{
		// Token: 0x06007779 RID: 30585 RVA: 0x001234F0 File Offset: 0x001216F0
		[NullableContext(1)]
		public static ExploreSkillCustomRequest Create()
		{
			return new ExploreSkillCustomRequest();
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x0600777A RID: 30586 RVA: 0x001234F7 File Offset: 0x001216F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x0600777B RID: 30587 RVA: 0x001234FA File Offset: 0x001216FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillCustomRequest.Descriptor;
			}
		}

		// Token: 0x0600777C RID: 30588 RVA: 0x00123501 File Offset: 0x00121701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomRequest()
		{
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x00123509 File Offset: 0x00121709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomRequest(ExploreSkillCustomRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600777E RID: 30590 RVA: 0x0012352E File Offset: 0x0012172E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomRequest Clone()
		{
			return new ExploreSkillCustomRequest(this);
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x0600777F RID: 30591 RVA: 0x00123536 File Offset: 0x00121736
		// (set) Token: 0x06007780 RID: 30592 RVA: 0x0012353E File Offset: 0x0012173E
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

		// Token: 0x06007781 RID: 30593 RVA: 0x00123547 File Offset: 0x00121747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillCustomRequest);
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x00123555 File Offset: 0x00121755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillCustomRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x00123584 File Offset: 0x00121784
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

		// Token: 0x06007784 RID: 30596 RVA: 0x001235C3 File Offset: 0x001217C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x001235D0 File Offset: 0x001217D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x001235D9 File Offset: 0x001217D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x0012360C File Offset: 0x0012180C
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

		// Token: 0x06007788 RID: 30600 RVA: 0x0012364A File Offset: 0x0012184A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillCustomRequest other)
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

		// Token: 0x06007789 RID: 30601 RVA: 0x0012367B File Offset: 0x0012187B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x00123684 File Offset: 0x00121884
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003E76 RID: 15990
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E77 RID: 15991
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04003E78 RID: 15992
		private long entityId_;
	}
}
