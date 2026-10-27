using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000167 RID: 359
	public sealed class BattleFormation : IMessage<BattleFormation>, IMessage, IEquatable<BattleFormation>, IDeepCloneable<BattleFormation>, IBufferMessage
	{
		// Token: 0x06002CA5 RID: 11429 RVA: 0x00074080 File Offset: 0x00072280
		[NullableContext(1)]
		public static BattleFormation Create()
		{
			return new BattleFormation();
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x00074087 File Offset: 0x00072287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x0007408A File Offset: 0x0007228A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleFormation.Descriptor;
			}
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00074091 File Offset: 0x00072291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation()
		{
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x000740B0 File Offset: 0x000722B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation(BattleFormation other) : this()
		{
			this.selectRoles_ = other.selectRoles_.Clone();
			this.buffSelect_ = other.buffSelect_;
			this.skillBranchIds_ = other.skillBranchIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x00074102 File Offset: 0x00072302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation Clone()
		{
			return new BattleFormation(this);
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x0007410A File Offset: 0x0007230A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectRoles
		{
			get
			{
				return this.selectRoles_;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x00074112 File Offset: 0x00072312
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x0007411A File Offset: 0x0007231A
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

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x00074123 File Offset: 0x00072323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchIds
		{
			get
			{
				return this.skillBranchIds_;
			}
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x0007412B File Offset: 0x0007232B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleFormation);
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x0007413C File Offset: 0x0007233C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleFormation other)
		{
			return other != null && (other == this || (this.selectRoles_.Equals(other.selectRoles_) && this.BuffSelect == other.BuffSelect && this.skillBranchIds_.Equals(other.skillBranchIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x000741A0 File Offset: 0x000723A0
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

		// Token: 0x06002CB2 RID: 11442 RVA: 0x000741FB File Offset: 0x000723FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x00074208 File Offset: 0x00072408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x00074214 File Offset: 0x00072414
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

		// Token: 0x06002CB5 RID: 11445 RVA: 0x00074274 File Offset: 0x00072474
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

		// Token: 0x06002CB6 RID: 11446 RVA: 0x000742D8 File Offset: 0x000724D8
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

		// Token: 0x06002CB7 RID: 11447 RVA: 0x00074336 File Offset: 0x00072536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x00074340 File Offset: 0x00072540
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

		// Token: 0x04002806 RID: 10246
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002807 RID: 10247
		public const int SelectRolesFieldNumber = 1;

		// Token: 0x04002808 RID: 10248
		private static readonly FieldCodec<int> _repeated_selectRoles_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002809 RID: 10249
		private readonly RepeatedField<int> selectRoles_ = new RepeatedField<int>();

		// Token: 0x0400280A RID: 10250
		public const int BuffSelectFieldNumber = 2;

		// Token: 0x0400280B RID: 10251
		private int buffSelect_;

		// Token: 0x0400280C RID: 10252
		public const int SkillBranchIdsFieldNumber = 3;

		// Token: 0x0400280D RID: 10253
		private static readonly FieldCodec<int> _repeated_skillBranchIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400280E RID: 10254
		private readonly RepeatedField<int> skillBranchIds_ = new RepeatedField<int>();
	}
}
