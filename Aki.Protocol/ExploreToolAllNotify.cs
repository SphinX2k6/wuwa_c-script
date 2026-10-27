using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050D RID: 1293
	[NetMessage(EMessageId.ExploreToolAllNotify)]
	public sealed class ExploreToolAllNotify : IMessage<ExploreToolAllNotify>, IMessage, IEquatable<ExploreToolAllNotify>, IDeepCloneable<ExploreToolAllNotify>, IBufferMessage
	{
		// Token: 0x060079AA RID: 31146 RVA: 0x00127BE1 File Offset: 0x00125DE1
		[NullableContext(1)]
		public static ExploreToolAllNotify Create()
		{
			return new ExploreToolAllNotify();
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x060079AB RID: 31147 RVA: 0x00127BE8 File Offset: 0x00125DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x060079AC RID: 31148 RVA: 0x00127BEB File Offset: 0x00125DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreToolAllNotify.Descriptor;
			}
		}

		// Token: 0x060079AD RID: 31149 RVA: 0x00127BF2 File Offset: 0x00125DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAllNotify()
		{
		}

		// Token: 0x060079AE RID: 31150 RVA: 0x00127C10 File Offset: 0x00125E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAllNotify(ExploreToolAllNotify other) : this()
		{
			this.skillList_ = other.skillList_.Clone();
			this.exploreSkill_ = other.exploreSkill_;
			this.newUnlock_ = other.newUnlock_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079AF RID: 31151 RVA: 0x00127C62 File Offset: 0x00125E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolAllNotify Clone()
		{
			return new ExploreToolAllNotify(this);
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x060079B0 RID: 31152 RVA: 0x00127C6A File Offset: 0x00125E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillList
		{
			get
			{
				return this.skillList_;
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x060079B1 RID: 31153 RVA: 0x00127C72 File Offset: 0x00125E72
		// (set) Token: 0x060079B2 RID: 31154 RVA: 0x00127C7A File Offset: 0x00125E7A
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

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x060079B3 RID: 31155 RVA: 0x00127C83 File Offset: 0x00125E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NewUnlock
		{
			get
			{
				return this.newUnlock_;
			}
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x00127C8B File Offset: 0x00125E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreToolAllNotify);
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x00127C9C File Offset: 0x00125E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreToolAllNotify other)
		{
			return other != null && (other == this || (this.skillList_.Equals(other.skillList_) && this.ExploreSkill == other.ExploreSkill && this.newUnlock_.Equals(other.newUnlock_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079B6 RID: 31158 RVA: 0x00127D00 File Offset: 0x00125F00
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

		// Token: 0x060079B7 RID: 31159 RVA: 0x00127D5B File Offset: 0x00125F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x00127D68 File Offset: 0x00125F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x00127D74 File Offset: 0x00125F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillList_.WriteTo(ref output, ExploreToolAllNotify._repeated_skillList_codec);
			this.newUnlock_.WriteTo(ref output, ExploreToolAllNotify._repeated_newUnlock_codec);
			if (this.ExploreSkill != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ExploreSkill);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x00127DD4 File Offset: 0x00125FD4
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

		// Token: 0x060079BB RID: 31163 RVA: 0x00127E38 File Offset: 0x00126038
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

		// Token: 0x060079BC RID: 31164 RVA: 0x00127E96 File Offset: 0x00126096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x00127EA0 File Offset: 0x001260A0
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.skillList_.AddEntriesFrom(ref input, ExploreToolAllNotify._repeated_skillList_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U || num == 74U)
					{
						this.newUnlock_.AddEntriesFrom(ref input, ExploreToolAllNotify._repeated_newUnlock_codec);
						continue;
					}
					if (num == 120U)
					{
						this.ExploreSkill = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003EB7 RID: 16055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EB8 RID: 16056
		public const int SkillListFieldNumber = 3;

		// Token: 0x04003EB9 RID: 16057
		private static readonly FieldCodec<int> _repeated_skillList_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04003EBA RID: 16058
		private readonly RepeatedField<int> skillList_ = new RepeatedField<int>();

		// Token: 0x04003EBB RID: 16059
		public const int ExploreSkillFieldNumber = 15;

		// Token: 0x04003EBC RID: 16060
		private int exploreSkill_;

		// Token: 0x04003EBD RID: 16061
		public const int NewUnlockFieldNumber = 9;

		// Token: 0x04003EBE RID: 16062
		private static readonly FieldCodec<int> _repeated_newUnlock_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04003EBF RID: 16063
		private readonly RepeatedField<int> newUnlock_ = new RepeatedField<int>();
	}
}
