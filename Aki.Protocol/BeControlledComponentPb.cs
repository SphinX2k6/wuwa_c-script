using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000185 RID: 389
	public sealed class BeControlledComponentPb : IMessage<BeControlledComponentPb>, IMessage, IEquatable<BeControlledComponentPb>, IDeepCloneable<BeControlledComponentPb>, IBufferMessage
	{
		// Token: 0x06002EE1 RID: 12001 RVA: 0x000785F8 File Offset: 0x000767F8
		[NullableContext(1)]
		public static BeControlledComponentPb Create()
		{
			return new BeControlledComponentPb();
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x000785FF File Offset: 0x000767FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x00078602 File Offset: 0x00076802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledComponentPb.Descriptor;
			}
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x00078609 File Offset: 0x00076809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledComponentPb()
		{
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x00078614 File Offset: 0x00076814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledComponentPb(BeControlledComponentPb other) : this()
		{
			this.playerEntityId_ = other.playerEntityId_;
			this.relationId_ = other.relationId_;
			this.isShow_ = other.isShow_;
			this.matchIndex_ = other.matchIndex_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x00078674 File Offset: 0x00076874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledComponentPb Clone()
		{
			return new BeControlledComponentPb(this);
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x0007867C File Offset: 0x0007687C
		// (set) Token: 0x06002EE8 RID: 12008 RVA: 0x00078684 File Offset: 0x00076884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerEntityId
		{
			get
			{
				return this.playerEntityId_;
			}
			set
			{
				this.playerEntityId_ = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x0007868D File Offset: 0x0007688D
		// (set) Token: 0x06002EEA RID: 12010 RVA: 0x00078695 File Offset: 0x00076895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RelationId
		{
			get
			{
				return this.relationId_;
			}
			set
			{
				this.relationId_ = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x0007869E File Offset: 0x0007689E
		// (set) Token: 0x06002EEC RID: 12012 RVA: 0x000786A6 File Offset: 0x000768A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x000786AF File Offset: 0x000768AF
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x000786B7 File Offset: 0x000768B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MatchIndex
		{
			get
			{
				return this.matchIndex_;
			}
			set
			{
				this.matchIndex_ = value;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x000786C0 File Offset: 0x000768C0
		// (set) Token: 0x06002EF0 RID: 12016 RVA: 0x000786C8 File Offset: 0x000768C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x000786D1 File Offset: 0x000768D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledComponentPb);
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x000786E0 File Offset: 0x000768E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledComponentPb other)
		{
			return other != null && (other == this || (this.PlayerEntityId == other.PlayerEntityId && this.RelationId == other.RelationId && this.IsShow == other.IsShow && this.MatchIndex == other.MatchIndex && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x0007875C File Offset: 0x0007695C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerEntityId != 0L)
			{
				num ^= this.PlayerEntityId.GetHashCode();
			}
			if (this.RelationId != 0)
			{
				num ^= this.RelationId.GetHashCode();
			}
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this.MatchIndex != 0)
			{
				num ^= this.MatchIndex.GetHashCode();
			}
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x000787FF File Offset: 0x000769FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x0007880C File Offset: 0x00076A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00078818 File Offset: 0x00076A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.PlayerEntityId);
			}
			if (this.RelationId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RelationId);
			}
			if (this.IsShow)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsShow);
			}
			if (this.MatchIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MatchIndex);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x000788C4 File Offset: 0x00076AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PlayerEntityId);
			}
			if (this.RelationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RelationId);
			}
			if (this.IsShow)
			{
				num += 2;
			}
			if (this.MatchIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MatchIndex);
			}
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00078958 File Offset: 0x00076B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerEntityId != 0L)
			{
				this.PlayerEntityId = other.PlayerEntityId;
			}
			if (other.RelationId != 0)
			{
				this.RelationId = other.RelationId;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			if (other.MatchIndex != 0)
			{
				this.MatchIndex = other.MatchIndex;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x000789E4 File Offset: 0x00076BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x000789F0 File Offset: 0x00076BF0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.PlayerEntityId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.RelationId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsShow = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.MatchIndex = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.ContextId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400288B RID: 10379
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400288C RID: 10380
		public const int PlayerEntityIdFieldNumber = 1;

		// Token: 0x0400288D RID: 10381
		private long playerEntityId_;

		// Token: 0x0400288E RID: 10382
		public const int RelationIdFieldNumber = 2;

		// Token: 0x0400288F RID: 10383
		private int relationId_;

		// Token: 0x04002890 RID: 10384
		public const int IsShowFieldNumber = 3;

		// Token: 0x04002891 RID: 10385
		private bool isShow_;

		// Token: 0x04002892 RID: 10386
		public const int MatchIndexFieldNumber = 4;

		// Token: 0x04002893 RID: 10387
		private int matchIndex_;

		// Token: 0x04002894 RID: 10388
		public const int ContextIdFieldNumber = 5;

		// Token: 0x04002895 RID: 10389
		private long contextId_;
	}
}
