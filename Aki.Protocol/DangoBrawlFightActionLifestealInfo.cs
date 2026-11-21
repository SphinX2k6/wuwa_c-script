using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000359 RID: 857
	public sealed class DangoBrawlFightActionLifestealInfo : IMessage<DangoBrawlFightActionLifestealInfo>, IMessage, IEquatable<DangoBrawlFightActionLifestealInfo>, IDeepCloneable<DangoBrawlFightActionLifestealInfo>, IBufferMessage
	{
		// Token: 0x060055D8 RID: 21976 RVA: 0x000D1F43 File Offset: 0x000D0143
		[NullableContext(1)]
		public static DangoBrawlFightActionLifestealInfo Create()
		{
			return new DangoBrawlFightActionLifestealInfo();
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x060055D9 RID: 21977 RVA: 0x000D1F4A File Offset: 0x000D014A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x060055DA RID: 21978 RVA: 0x000D1F4D File Offset: 0x000D014D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionLifestealInfo.Descriptor;
			}
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x000D1F54 File Offset: 0x000D0154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionLifestealInfo()
		{
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x000D1F67 File Offset: 0x000D0167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionLifestealInfo(DangoBrawlFightActionLifestealInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.healValues_ = other.healValues_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x000D1F9D File Offset: 0x000D019D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionLifestealInfo Clone()
		{
			return new DangoBrawlFightActionLifestealInfo(this);
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x060055DE RID: 21982 RVA: 0x000D1FA5 File Offset: 0x000D01A5
		// (set) Token: 0x060055DF RID: 21983 RVA: 0x000D1FAD File Offset: 0x000D01AD
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

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x060055E0 RID: 21984 RVA: 0x000D1FB6 File Offset: 0x000D01B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HealValues
		{
			get
			{
				return this.healValues_;
			}
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x000D1FBE File Offset: 0x000D01BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionLifestealInfo);
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x000D1FCC File Offset: 0x000D01CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionLifestealInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.healValues_.Equals(other.healValues_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x000D201C File Offset: 0x000D021C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			num ^= this.healValues_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x000D2069 File Offset: 0x000D0269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x000D2076 File Offset: 0x000D0276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x000D2080 File Offset: 0x000D0280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetFighterUId);
			}
			this.healValues_.WriteTo(ref output, DangoBrawlFightActionLifestealInfo._repeated_healValues_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x000D20D0 File Offset: 0x000D02D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			num += this.healValues_.CalculateSize(DangoBrawlFightActionLifestealInfo._repeated_healValues_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x000D2124 File Offset: 0x000D0324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionLifestealInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			this.healValues_.Add(other.healValues_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x000D2171 File Offset: 0x000D0371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x000D217C File Offset: 0x000D037C
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.healValues_.AddEntriesFrom(ref input, DangoBrawlFightActionLifestealInfo._repeated_healValues_codec);
					}
				}
				else
				{
					this.TargetFighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003494 RID: 13460
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003495 RID: 13461
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x04003496 RID: 13462
		private int targetFighterUId_;

		// Token: 0x04003497 RID: 13463
		public const int HealValuesFieldNumber = 2;

		// Token: 0x04003498 RID: 13464
		private static readonly FieldCodec<int> _repeated_healValues_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003499 RID: 13465
		private readonly RepeatedField<int> healValues_ = new RepeatedField<int>();
	}
}
