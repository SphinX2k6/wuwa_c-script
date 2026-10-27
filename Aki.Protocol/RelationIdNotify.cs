using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EEC RID: 3820
	[NetMessage(EMessageId.RelationIdNotify)]
	public sealed class RelationIdNotify : IMessage<RelationIdNotify>, IMessage, IEquatable<RelationIdNotify>, IDeepCloneable<RelationIdNotify>, IBufferMessage
	{
		// Token: 0x06014784 RID: 83844 RVA: 0x002F95F0 File Offset: 0x002F77F0
		[NullableContext(1)]
		public static RelationIdNotify Create()
		{
			return new RelationIdNotify();
		}

		// Token: 0x17004411 RID: 17425
		// (get) Token: 0x06014785 RID: 83845 RVA: 0x002F95F7 File Offset: 0x002F77F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004412 RID: 17426
		// (get) Token: 0x06014786 RID: 83846 RVA: 0x002F95FA File Offset: 0x002F77FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelationIdNotify.Descriptor;
			}
		}

		// Token: 0x06014787 RID: 83847 RVA: 0x002F9601 File Offset: 0x002F7801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelationIdNotify()
		{
		}

		// Token: 0x06014788 RID: 83848 RVA: 0x002F960C File Offset: 0x002F780C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelationIdNotify(RelationIdNotify other) : this()
		{
			this.entityConfigId_ = other.entityConfigId_;
			this.relationId_ = other.relationId_;
			this.istId_ = other.istId_;
			this.matchIndex_ = other.matchIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014789 RID: 83849 RVA: 0x002F9660 File Offset: 0x002F7860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelationIdNotify Clone()
		{
			return new RelationIdNotify(this);
		}

		// Token: 0x17004413 RID: 17427
		// (get) Token: 0x0601478A RID: 83850 RVA: 0x002F9668 File Offset: 0x002F7868
		// (set) Token: 0x0601478B RID: 83851 RVA: 0x002F9670 File Offset: 0x002F7870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x17004414 RID: 17428
		// (get) Token: 0x0601478C RID: 83852 RVA: 0x002F9679 File Offset: 0x002F7879
		// (set) Token: 0x0601478D RID: 83853 RVA: 0x002F9681 File Offset: 0x002F7881
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

		// Token: 0x17004415 RID: 17429
		// (get) Token: 0x0601478E RID: 83854 RVA: 0x002F968A File Offset: 0x002F788A
		// (set) Token: 0x0601478F RID: 83855 RVA: 0x002F9692 File Offset: 0x002F7892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IstId
		{
			get
			{
				return this.istId_;
			}
			set
			{
				this.istId_ = value;
			}
		}

		// Token: 0x17004416 RID: 17430
		// (get) Token: 0x06014790 RID: 83856 RVA: 0x002F969B File Offset: 0x002F789B
		// (set) Token: 0x06014791 RID: 83857 RVA: 0x002F96A3 File Offset: 0x002F78A3
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

		// Token: 0x06014792 RID: 83858 RVA: 0x002F96AC File Offset: 0x002F78AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelationIdNotify);
		}

		// Token: 0x06014793 RID: 83859 RVA: 0x002F96BC File Offset: 0x002F78BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelationIdNotify other)
		{
			return other != null && (other == this || (this.EntityConfigId == other.EntityConfigId && this.RelationId == other.RelationId && this.IstId == other.IstId && this.MatchIndex == other.MatchIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014794 RID: 83860 RVA: 0x002F9728 File Offset: 0x002F7928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.RelationId != 0)
			{
				num ^= this.RelationId.GetHashCode();
			}
			if (this.IstId != 0)
			{
				num ^= this.IstId.GetHashCode();
			}
			if (this.MatchIndex != 0)
			{
				num ^= this.MatchIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014795 RID: 83861 RVA: 0x002F97B2 File Offset: 0x002F79B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014796 RID: 83862 RVA: 0x002F97BF File Offset: 0x002F79BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014797 RID: 83863 RVA: 0x002F97C8 File Offset: 0x002F79C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MatchIndex);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.IstId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.IstId);
			}
			if (this.RelationId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RelationId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014798 RID: 83864 RVA: 0x002F985C File Offset: 0x002F7A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.RelationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RelationId);
			}
			if (this.IstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IstId);
			}
			if (this.MatchIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MatchIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014799 RID: 83865 RVA: 0x002F98E4 File Offset: 0x002F7AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelationIdNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.RelationId != 0)
			{
				this.RelationId = other.RelationId;
			}
			if (other.IstId != 0)
			{
				this.IstId = other.IstId;
			}
			if (other.MatchIndex != 0)
			{
				this.MatchIndex = other.MatchIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601479A RID: 83866 RVA: 0x002F995C File Offset: 0x002F7B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601479B RID: 83867 RVA: 0x002F9968 File Offset: 0x002F7B68
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
				if (num <= 96U)
				{
					if (num == 48U)
					{
						this.MatchIndex = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.IstId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.RelationId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007C28 RID: 31784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C29 RID: 31785
		public const int EntityConfigIdFieldNumber = 12;

		// Token: 0x04007C2A RID: 31786
		private int entityConfigId_;

		// Token: 0x04007C2B RID: 31787
		public const int RelationIdFieldNumber = 14;

		// Token: 0x04007C2C RID: 31788
		private int relationId_;

		// Token: 0x04007C2D RID: 31789
		public const int IstIdFieldNumber = 13;

		// Token: 0x04007C2E RID: 31790
		private int istId_;

		// Token: 0x04007C2F RID: 31791
		public const int MatchIndexFieldNumber = 6;

		// Token: 0x04007C30 RID: 31792
		private int matchIndex_;
	}
}
