using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000351 RID: 849
	public sealed class DangoBrawlFightActionBuffRemoveInfo : IMessage<DangoBrawlFightActionBuffRemoveInfo>, IMessage, IEquatable<DangoBrawlFightActionBuffRemoveInfo>, IDeepCloneable<DangoBrawlFightActionBuffRemoveInfo>, IBufferMessage
	{
		// Token: 0x06005510 RID: 21776 RVA: 0x000CF7D4 File Offset: 0x000CD9D4
		[NullableContext(1)]
		public static DangoBrawlFightActionBuffRemoveInfo Create()
		{
			return new DangoBrawlFightActionBuffRemoveInfo();
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06005511 RID: 21777 RVA: 0x000CF7DB File Offset: 0x000CD9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06005512 RID: 21778 RVA: 0x000CF7DE File Offset: 0x000CD9DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionBuffRemoveInfo.Descriptor;
			}
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x000CF7E5 File Offset: 0x000CD9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffRemoveInfo()
		{
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x000CF7ED File Offset: 0x000CD9ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffRemoveInfo(DangoBrawlFightActionBuffRemoveInfo other) : this()
		{
			this.buffUId_ = other.buffUId_;
			this.targetFighterUId_ = other.targetFighterUId_;
			this.sourceItemUId_ = other.sourceItemUId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x000CF82A File Offset: 0x000CDA2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffRemoveInfo Clone()
		{
			return new DangoBrawlFightActionBuffRemoveInfo(this);
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06005516 RID: 21782 RVA: 0x000CF832 File Offset: 0x000CDA32
		// (set) Token: 0x06005517 RID: 21783 RVA: 0x000CF83A File Offset: 0x000CDA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffUId
		{
			get
			{
				return this.buffUId_;
			}
			set
			{
				this.buffUId_ = value;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06005518 RID: 21784 RVA: 0x000CF843 File Offset: 0x000CDA43
		// (set) Token: 0x06005519 RID: 21785 RVA: 0x000CF84B File Offset: 0x000CDA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x0600551A RID: 21786 RVA: 0x000CF854 File Offset: 0x000CDA54
		// (set) Token: 0x0600551B RID: 21787 RVA: 0x000CF85C File Offset: 0x000CDA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceItemUId
		{
			get
			{
				return this.sourceItemUId_;
			}
			set
			{
				this.sourceItemUId_ = value;
			}
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x000CF865 File Offset: 0x000CDA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionBuffRemoveInfo);
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x000CF874 File Offset: 0x000CDA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionBuffRemoveInfo other)
		{
			return other != null && (other == this || (this.BuffUId == other.BuffUId && this.TargetFighterUId == other.TargetFighterUId && this.SourceItemUId == other.SourceItemUId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x000CF8D0 File Offset: 0x000CDAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffUId != 0)
			{
				num ^= this.BuffUId.GetHashCode();
			}
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			if (this.SourceItemUId != 0)
			{
				num ^= this.SourceItemUId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x000CF941 File Offset: 0x000CDB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x000CF94E File Offset: 0x000CDB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x000CF958 File Offset: 0x000CDB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffUId);
			}
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TargetFighterUId);
			}
			if (this.SourceItemUId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SourceItemUId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x000CF9CC File Offset: 0x000CDBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffUId);
			}
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			if (this.SourceItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceItemUId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x000CFA3C File Offset: 0x000CDC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionBuffRemoveInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffUId != 0)
			{
				this.BuffUId = other.BuffUId;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			if (other.SourceItemUId != 0)
			{
				this.SourceItemUId = other.SourceItemUId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x000CFAA0 File Offset: 0x000CDCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x000CFAAC File Offset: 0x000CDCAC
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SourceItemUId = input.ReadInt32();
						}
					}
					else
					{
						this.TargetFighterUId = input.ReadInt32();
					}
				}
				else
				{
					this.BuffUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003451 RID: 13393
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003452 RID: 13394
		public const int BuffUIdFieldNumber = 1;

		// Token: 0x04003453 RID: 13395
		private int buffUId_;

		// Token: 0x04003454 RID: 13396
		public const int TargetFighterUIdFieldNumber = 2;

		// Token: 0x04003455 RID: 13397
		private int targetFighterUId_;

		// Token: 0x04003456 RID: 13398
		public const int SourceItemUIdFieldNumber = 3;

		// Token: 0x04003457 RID: 13399
		private int sourceItemUId_;
	}
}
