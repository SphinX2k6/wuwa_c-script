using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000507 RID: 1287
	[NetMessage(EMessageId.ExploreSkillPullGiantRequest)]
	public sealed class ExploreSkillPullGiantRequest : IMessage<ExploreSkillPullGiantRequest>, IMessage, IEquatable<ExploreSkillPullGiantRequest>, IDeepCloneable<ExploreSkillPullGiantRequest>, IBufferMessage
	{
		// Token: 0x0600792D RID: 31021 RVA: 0x00126A20 File Offset: 0x00124C20
		[NullableContext(1)]
		public static ExploreSkillPullGiantRequest Create()
		{
			return new ExploreSkillPullGiantRequest();
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x0600792E RID: 31022 RVA: 0x00126A27 File Offset: 0x00124C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x0600792F RID: 31023 RVA: 0x00126A2A File Offset: 0x00124C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillPullGiantRequest.Descriptor;
			}
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x00126A31 File Offset: 0x00124C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantRequest()
		{
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x00126A39 File Offset: 0x00124C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantRequest(ExploreSkillPullGiantRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007932 RID: 31026 RVA: 0x00126A5E File Offset: 0x00124C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillPullGiantRequest Clone()
		{
			return new ExploreSkillPullGiantRequest(this);
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06007933 RID: 31027 RVA: 0x00126A66 File Offset: 0x00124C66
		// (set) Token: 0x06007934 RID: 31028 RVA: 0x00126A6E File Offset: 0x00124C6E
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

		// Token: 0x06007935 RID: 31029 RVA: 0x00126A77 File Offset: 0x00124C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillPullGiantRequest);
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x00126A85 File Offset: 0x00124C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillPullGiantRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x00126AB4 File Offset: 0x00124CB4
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

		// Token: 0x06007938 RID: 31032 RVA: 0x00126AF3 File Offset: 0x00124CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x00126B00 File Offset: 0x00124D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x00126B09 File Offset: 0x00124D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x00126B3C File Offset: 0x00124D3C
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

		// Token: 0x0600793C RID: 31036 RVA: 0x00126B7A File Offset: 0x00124D7A
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

		// Token: 0x0600793D RID: 31037 RVA: 0x00126BAB File Offset: 0x00124DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x00126BB4 File Offset: 0x00124DB4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003E90 RID: 16016
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E91 RID: 16017
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003E92 RID: 16018
		private long entityId_;
	}
}
