using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016A RID: 362
	public sealed class BattleFormation : IMessage<BattleFormation>, IMessage, IEquatable<BattleFormation>, IDeepCloneable<BattleFormation>, IBufferMessage
	{
		// Token: 0x06002D1C RID: 11548 RVA: 0x000754B5 File Offset: 0x000736B5
		[NullableContext(1)]
		public static BattleFormation Create()
		{
			return new BattleFormation();
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x000754BC File Offset: 0x000736BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002D1E RID: 11550 RVA: 0x000754BF File Offset: 0x000736BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleFormation.Descriptor;
			}
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x000754C6 File Offset: 0x000736C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation()
		{
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x000754E4 File Offset: 0x000736E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation(BattleFormation other) : this()
		{
			this.selectRoles_ = other.selectRoles_.Clone();
			this.buffSelect_ = other.buffSelect_;
			this.skillBranchIds_ = other.skillBranchIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00075536 File Offset: 0x00073736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation Clone()
		{
			return new BattleFormation(this);
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x0007553E File Offset: 0x0007373E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectRoles
		{
			get
			{
				return this.selectRoles_;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x00075546 File Offset: 0x00073746
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x0007554E File Offset: 0x0007374E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffSelect
		{
			get
			{
				return this.buffSelect_;
			}
			set
			{
				this.buffSelect_ = value;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x00075557 File Offset: 0x00073757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchIds
		{
			get
			{
				return this.skillBranchIds_;
			}
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x0007555F File Offset: 0x0007375F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleFormation);
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00075570 File Offset: 0x00073770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleFormation other)
		{
			return other != null && (other == this || (this.selectRoles_.Equals(other.selectRoles_) && this.BuffSelect == other.BuffSelect && this.skillBranchIds_.Equals(other.skillBranchIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x000755D4 File Offset: 0x000737D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.selectRoles_.GetHashCode();
			if (this.BuffSelect != 0)
			{
				num ^= this.BuffSelect.GetHashCode();
			}
			num ^= this.skillBranchIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x0007562F File Offset: 0x0007382F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x0007563C File Offset: 0x0007383C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x00075648 File Offset: 0x00073848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selectRoles_.WriteTo(ref output, BattleFormation._repeated_selectRoles_codec);
			if (this.BuffSelect != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BuffSelect);
			}
			this.skillBranchIds_.WriteTo(ref output, BattleFormation._repeated_skillBranchIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x000756A8 File Offset: 0x000738A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.selectRoles_.CalculateSize(BattleFormation._repeated_selectRoles_codec);
			if (this.BuffSelect != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffSelect);
			}
			num += this.skillBranchIds_.CalculateSize(BattleFormation._repeated_skillBranchIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x0007570C File Offset: 0x0007390C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleFormation other)
		{
			if (other == null)
			{
				return;
			}
			this.selectRoles_.Add(other.selectRoles_);
			if (other.BuffSelect != 0)
			{
				this.BuffSelect = other.BuffSelect;
			}
			this.skillBranchIds_.Add(other.skillBranchIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x0007576A File Offset: 0x0007396A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00075774 File Offset: 0x00073974
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.selectRoles_.AddEntriesFrom(ref input, BattleFormation._repeated_selectRoles_codec);
						continue;
					}
				}
				else
				{
					if (num == 16U)
					{
						this.BuffSelect = input.ReadInt32();
						continue;
					}
					if (num == 24U || num == 26U)
					{
						this.skillBranchIds_.AddEntriesFrom(ref input, BattleFormation._repeated_skillBranchIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400287A RID: 10362
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400287B RID: 10363
		public const int SelectRolesFieldNumber = 1;

		// Token: 0x0400287C RID: 10364
		private static readonly FieldCodec<int> _repeated_selectRoles_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400287D RID: 10365
		private readonly RepeatedField<int> selectRoles_ = new RepeatedField<int>();

		// Token: 0x0400287E RID: 10366
		public const int BuffSelectFieldNumber = 2;

		// Token: 0x0400287F RID: 10367
		private int buffSelect_;

		// Token: 0x04002880 RID: 10368
		public const int SkillBranchIdsFieldNumber = 3;

		// Token: 0x04002881 RID: 10369
		private static readonly FieldCodec<int> _repeated_skillBranchIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002882 RID: 10370
		private readonly RepeatedField<int> skillBranchIds_ = new RepeatedField<int>();
	}
}
