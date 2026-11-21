using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F7 RID: 1271
	[NetMessage(EMessageId.ExploreToolAllNotify)]
	public sealed class ExploreToolAllNotify : IMessage<ExploreToolAllNotify>, IMessage, IEquatable<ExploreToolAllNotify>, IDeepCloneable<ExploreToolAllNotify>, IBufferMessage
	{
		// Token: 0x0600782E RID: 30766 RVA: 0x00124D4D File Offset: 0x00122F4D
		[NullableContext(1)]
		public static ExploreToolAllNotify Create()
		{
			return new ExploreToolAllNotify();
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x0600782F RID: 30767 RVA: 0x00124D54 File Offset: 0x00122F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06007830 RID: 30768 RVA: 0x00124D57 File Offset: 0x00122F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreToolAllNotify.Descriptor;
			}
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x00124D5E File Offset: 0x00122F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAllNotify()
		{
		}

		// Token: 0x06007832 RID: 30770 RVA: 0x00124D7C File Offset: 0x00122F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAllNotify(ExploreToolAllNotify other) : this()
		{
			this.skillList_ = other.skillList_.Clone();
			this.exploreSkill_ = other.exploreSkill_;
			this.newUnlock_ = other.newUnlock_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x00124DCE File Offset: 0x00122FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAllNotify Clone()
		{
			return new ExploreToolAllNotify(this);
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06007834 RID: 30772 RVA: 0x00124DD6 File Offset: 0x00122FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillList
		{
			get
			{
				return this.skillList_;
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06007835 RID: 30773 RVA: 0x00124DDE File Offset: 0x00122FDE
		// (set) Token: 0x06007836 RID: 30774 RVA: 0x00124DE6 File Offset: 0x00122FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExploreSkill
		{
			get
			{
				return this.exploreSkill_;
			}
			set
			{
				this.exploreSkill_ = value;
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06007837 RID: 30775 RVA: 0x00124DEF File Offset: 0x00122FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NewUnlock
		{
			get
			{
				return this.newUnlock_;
			}
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x00124DF7 File Offset: 0x00122FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreToolAllNotify);
		}

		// Token: 0x06007839 RID: 30777 RVA: 0x00124E08 File Offset: 0x00123008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreToolAllNotify other)
		{
			return other != null && (other == this || (this.skillList_.Equals(other.skillList_) && this.ExploreSkill == other.ExploreSkill && this.newUnlock_.Equals(other.newUnlock_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x00124E6C File Offset: 0x0012306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skillList_.GetHashCode();
			if (this.ExploreSkill != 0)
			{
				num ^= this.ExploreSkill.GetHashCode();
			}
			num ^= this.newUnlock_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x00124EC7 File Offset: 0x001230C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600783C RID: 30780 RVA: 0x00124ED4 File Offset: 0x001230D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x00124EE0 File Offset: 0x001230E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillList_.WriteTo(ref output, ExploreToolAllNotify._repeated_skillList_codec);
			this.newUnlock_.WriteTo(ref output, ExploreToolAllNotify._repeated_newUnlock_codec);
			if (this.ExploreSkill != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ExploreSkill);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x00124F40 File Offset: 0x00123140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skillList_.CalculateSize(ExploreToolAllNotify._repeated_skillList_codec);
			if (this.ExploreSkill != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExploreSkill);
			}
			num += this.newUnlock_.CalculateSize(ExploreToolAllNotify._repeated_newUnlock_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x00124FA4 File Offset: 0x001231A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreToolAllNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skillList_.Add(other.skillList_);
			if (other.ExploreSkill != 0)
			{
				this.ExploreSkill = other.ExploreSkill;
			}
			this.newUnlock_.Add(other.newUnlock_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x00125002 File Offset: 0x00123202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x0012500C File Offset: 0x0012320C
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
				if (num <= 50U)
				{
					if (num == 48U || num == 50U)
					{
						this.skillList_.AddEntriesFrom(ref input, ExploreToolAllNotify._repeated_skillList_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U || num == 98U)
					{
						this.newUnlock_.AddEntriesFrom(ref input, ExploreToolAllNotify._repeated_newUnlock_codec);
						continue;
					}
					if (num == 112U)
					{
						this.ExploreSkill = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003EA8 RID: 16040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EA9 RID: 16041
		public const int SkillListFieldNumber = 6;

		// Token: 0x04003EAA RID: 16042
		private static readonly FieldCodec<int> _repeated_skillList_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04003EAB RID: 16043
		private readonly RepeatedField<int> skillList_ = new RepeatedField<int>();

		// Token: 0x04003EAC RID: 16044
		public const int ExploreSkillFieldNumber = 14;

		// Token: 0x04003EAD RID: 16045
		private int exploreSkill_;

		// Token: 0x04003EAE RID: 16046
		public const int NewUnlockFieldNumber = 12;

		// Token: 0x04003EAF RID: 16047
		private static readonly FieldCodec<int> _repeated_newUnlock_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04003EB0 RID: 16048
		private readonly RepeatedField<int> newUnlock_ = new RepeatedField<int>();
	}
}
