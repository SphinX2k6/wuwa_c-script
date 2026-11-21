using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004EB RID: 1259
	[NetMessage(EMessageId.ExploreSkillActionRequest)]
	public sealed class ExploreSkillActionRequest : IMessage<ExploreSkillActionRequest>, IMessage, IEquatable<ExploreSkillActionRequest>, IDeepCloneable<ExploreSkillActionRequest>, IBufferMessage
	{
		// Token: 0x06007741 RID: 30529 RVA: 0x00122E54 File Offset: 0x00121054
		[NullableContext(1)]
		public static ExploreSkillActionRequest Create()
		{
			return new ExploreSkillActionRequest();
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06007742 RID: 30530 RVA: 0x00122E5B File Offset: 0x0012105B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x06007743 RID: 30531 RVA: 0x00122E5E File Offset: 0x0012105E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillActionRequest.Descriptor;
			}
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x00122E65 File Offset: 0x00121065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionRequest()
		{
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x00122E6D File Offset: 0x0012106D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionRequest(ExploreSkillActionRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x00122E92 File Offset: 0x00121092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillActionRequest Clone()
		{
			return new ExploreSkillActionRequest(this);
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06007747 RID: 30535 RVA: 0x00122E9A File Offset: 0x0012109A
		// (set) Token: 0x06007748 RID: 30536 RVA: 0x00122EA2 File Offset: 0x001210A2
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

		// Token: 0x06007749 RID: 30537 RVA: 0x00122EAB File Offset: 0x001210AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillActionRequest);
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x00122EB9 File Offset: 0x001210B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillActionRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x00122EE8 File Offset: 0x001210E8
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

		// Token: 0x0600774C RID: 30540 RVA: 0x00122F27 File Offset: 0x00121127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x00122F34 File Offset: 0x00121134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x00122F3D File Offset: 0x0012113D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00122F70 File Offset: 0x00121170
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

		// Token: 0x06007750 RID: 30544 RVA: 0x00122FAE File Offset: 0x001211AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillActionRequest other)
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

		// Token: 0x06007751 RID: 30545 RVA: 0x00122FDF File Offset: 0x001211DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00122FE8 File Offset: 0x001211E8
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003E6B RID: 15979
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E6C RID: 15980
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04003E6D RID: 15981
		private long entityId_;
	}
}
