using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F1 RID: 1265
	[NetMessage(EMessageId.ExploreSkillPullGiantRequest)]
	public sealed class ExploreSkillPullGiantRequest : IMessage<ExploreSkillPullGiantRequest>, IMessage, IEquatable<ExploreSkillPullGiantRequest>, IDeepCloneable<ExploreSkillPullGiantRequest>, IBufferMessage
	{
		// Token: 0x060077B1 RID: 30641 RVA: 0x00123B8C File Offset: 0x00121D8C
		[NullableContext(1)]
		public static ExploreSkillPullGiantRequest Create()
		{
			return new ExploreSkillPullGiantRequest();
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x060077B2 RID: 30642 RVA: 0x00123B93 File Offset: 0x00121D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x060077B3 RID: 30643 RVA: 0x00123B96 File Offset: 0x00121D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillPullGiantRequest.Descriptor;
			}
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x00123B9D File Offset: 0x00121D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantRequest()
		{
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x00123BA5 File Offset: 0x00121DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantRequest(ExploreSkillPullGiantRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x00123BCA File Offset: 0x00121DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantRequest Clone()
		{
			return new ExploreSkillPullGiantRequest(this);
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x060077B7 RID: 30647 RVA: 0x00123BD2 File Offset: 0x00121DD2
		// (set) Token: 0x060077B8 RID: 30648 RVA: 0x00123BDA File Offset: 0x00121DDA
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

		// Token: 0x060077B9 RID: 30649 RVA: 0x00123BE3 File Offset: 0x00121DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillPullGiantRequest);
		}

		// Token: 0x060077BA RID: 30650 RVA: 0x00123BF1 File Offset: 0x00121DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillPullGiantRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x00123C20 File Offset: 0x00121E20
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

		// Token: 0x060077BC RID: 30652 RVA: 0x00123C5F File Offset: 0x00121E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x00123C6C File Offset: 0x00121E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077BE RID: 30654 RVA: 0x00123C75 File Offset: 0x00121E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077BF RID: 30655 RVA: 0x00123CA8 File Offset: 0x00121EA8
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

		// Token: 0x060077C0 RID: 30656 RVA: 0x00123CE6 File Offset: 0x00121EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillPullGiantRequest other)
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

		// Token: 0x060077C1 RID: 30657 RVA: 0x00123D17 File Offset: 0x00121F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x00123D20 File Offset: 0x00121F20
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003E81 RID: 16001
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E82 RID: 16002
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04003E83 RID: 16003
		private long entityId_;
	}
}
