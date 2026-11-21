using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000188 RID: 392
	public sealed class BeControlledComponentPb : IMessage<BeControlledComponentPb>, IMessage, IEquatable<BeControlledComponentPb>, IDeepCloneable<BeControlledComponentPb>, IBufferMessage
	{
		// Token: 0x06002F58 RID: 12120 RVA: 0x00079A2C File Offset: 0x00077C2C
		[NullableContext(1)]
		public static BeControlledComponentPb Create()
		{
			return new BeControlledComponentPb();
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002F59 RID: 12121 RVA: 0x00079A33 File Offset: 0x00077C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002F5A RID: 12122 RVA: 0x00079A36 File Offset: 0x00077C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledComponentPb.Descriptor;
			}
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x00079A3D File Offset: 0x00077C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledComponentPb()
		{
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00079A48 File Offset: 0x00077C48
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

		// Token: 0x06002F5D RID: 12125 RVA: 0x00079AA8 File Offset: 0x00077CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledComponentPb Clone()
		{
			return new BeControlledComponentPb(this);
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x00079AB0 File Offset: 0x00077CB0
		// (set) Token: 0x06002F5F RID: 12127 RVA: 0x00079AB8 File Offset: 0x00077CB8
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

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x00079AC1 File Offset: 0x00077CC1
		// (set) Token: 0x06002F61 RID: 12129 RVA: 0x00079AC9 File Offset: 0x00077CC9
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

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06002F62 RID: 12130 RVA: 0x00079AD2 File Offset: 0x00077CD2
		// (set) Token: 0x06002F63 RID: 12131 RVA: 0x00079ADA File Offset: 0x00077CDA
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

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06002F64 RID: 12132 RVA: 0x00079AE3 File Offset: 0x00077CE3
		// (set) Token: 0x06002F65 RID: 12133 RVA: 0x00079AEB File Offset: 0x00077CEB
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

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06002F66 RID: 12134 RVA: 0x00079AF4 File Offset: 0x00077CF4
		// (set) Token: 0x06002F67 RID: 12135 RVA: 0x00079AFC File Offset: 0x00077CFC
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

		// Token: 0x06002F68 RID: 12136 RVA: 0x00079B05 File Offset: 0x00077D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledComponentPb);
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x00079B14 File Offset: 0x00077D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledComponentPb other)
		{
			return other != null && (other == this || (this.PlayerEntityId == other.PlayerEntityId && this.RelationId == other.RelationId && this.IsShow == other.IsShow && this.MatchIndex == other.MatchIndex && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x00079B90 File Offset: 0x00077D90
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

		// Token: 0x06002F6B RID: 12139 RVA: 0x00079C33 File Offset: 0x00077E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00079C40 File Offset: 0x00077E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x00079C4C File Offset: 0x00077E4C
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

		// Token: 0x06002F6E RID: 12142 RVA: 0x00079CF8 File Offset: 0x00077EF8
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

		// Token: 0x06002F6F RID: 12143 RVA: 0x00079D8C File Offset: 0x00077F8C
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

		// Token: 0x06002F70 RID: 12144 RVA: 0x00079E18 File Offset: 0x00078018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x00079E24 File Offset: 0x00078024
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

		// Token: 0x040028FF RID: 10495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002900 RID: 10496
		public const int PlayerEntityIdFieldNumber = 1;

		// Token: 0x04002901 RID: 10497
		private long playerEntityId_;

		// Token: 0x04002902 RID: 10498
		public const int RelationIdFieldNumber = 2;

		// Token: 0x04002903 RID: 10499
		private int relationId_;

		// Token: 0x04002904 RID: 10500
		public const int IsShowFieldNumber = 3;

		// Token: 0x04002905 RID: 10501
		private bool isShow_;

		// Token: 0x04002906 RID: 10502
		public const int MatchIndexFieldNumber = 4;

		// Token: 0x04002907 RID: 10503
		private int matchIndex_;

		// Token: 0x04002908 RID: 10504
		public const int ContextIdFieldNumber = 5;

		// Token: 0x04002909 RID: 10505
		private long contextId_;
	}
}
