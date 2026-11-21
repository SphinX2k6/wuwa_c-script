using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014D RID: 333
	public sealed class BabelTowerCtx : IMessage<BabelTowerCtx>, IMessage, IEquatable<BabelTowerCtx>, IDeepCloneable<BabelTowerCtx>, IBufferMessage
	{
		// Token: 0x06002AD5 RID: 10965 RVA: 0x0007068F File Offset: 0x0006E88F
		[NullableContext(1)]
		public static BabelTowerCtx Create()
		{
			return new BabelTowerCtx();
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002AD6 RID: 10966 RVA: 0x00070696 File Offset: 0x0006E896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x00070699 File Offset: 0x0006E899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerCtx.Descriptor;
			}
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000706A0 File Offset: 0x0006E8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerCtx()
		{
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000706C0 File Offset: 0x0006E8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerCtx(BabelTowerCtx other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.selectBuff_ = other.selectBuff_.Clone();
			this.skillBranchId_ = other.skillBranchId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00070712 File Offset: 0x0006E912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerCtx Clone()
		{
			return new BabelTowerCtx(this);
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x0007071A File Offset: 0x0006E91A
		// (set) Token: 0x06002ADC RID: 10972 RVA: 0x00070722 File Offset: 0x0006E922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelsId
		{
			get
			{
				return this.levelsId_;
			}
			set
			{
				this.levelsId_ = value;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x0007072B File Offset: 0x0006E92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectBuff
		{
			get
			{
				return this.selectBuff_;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x00070733 File Offset: 0x0006E933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x0007073B File Offset: 0x0006E93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerCtx);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x0007074C File Offset: 0x0006E94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerCtx other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.selectBuff_.Equals(other.selectBuff_) && this.skillBranchId_.Equals(other.skillBranchId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000707B0 File Offset: 0x0006E9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelsId != 0)
			{
				num ^= this.LevelsId.GetHashCode();
			}
			num ^= this.selectBuff_.GetHashCode();
			num ^= this.skillBranchId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x0007080B File Offset: 0x0006EA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x00070818 File Offset: 0x0006EA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x00070824 File Offset: 0x0006EA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelsId);
			}
			this.selectBuff_.WriteTo(ref output, BabelTowerCtx._repeated_selectBuff_codec);
			this.skillBranchId_.WriteTo(ref output, BabelTowerCtx._repeated_skillBranchId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x00070884 File Offset: 0x0006EA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelsId);
			}
			num += this.selectBuff_.CalculateSize(BabelTowerCtx._repeated_selectBuff_codec);
			num += this.skillBranchId_.CalculateSize(BabelTowerCtx._repeated_skillBranchId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x000708E8 File Offset: 0x0006EAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelsId != 0)
			{
				this.LevelsId = other.LevelsId;
			}
			this.selectBuff_.Add(other.selectBuff_);
			this.skillBranchId_.Add(other.skillBranchId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x00070946 File Offset: 0x0006EB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x00070950 File Offset: 0x0006EB50
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
						this.LevelsId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 24U || num == 26U)
					{
						this.skillBranchId_.AddEntriesFrom(ref input, BabelTowerCtx._repeated_skillBranchId_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.selectBuff_.AddEntriesFrom(ref input, BabelTowerCtx._repeated_selectBuff_codec);
			}
		}

		// Token: 0x040027D3 RID: 10195
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027D4 RID: 10196
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x040027D5 RID: 10197
		private int levelsId_;

		// Token: 0x040027D6 RID: 10198
		public const int SelectBuffFieldNumber = 2;

		// Token: 0x040027D7 RID: 10199
		private static readonly FieldCodec<int> _repeated_selectBuff_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040027D8 RID: 10200
		private readonly RepeatedField<int> selectBuff_ = new RepeatedField<int>();

		// Token: 0x040027D9 RID: 10201
		public const int SkillBranchIdFieldNumber = 3;

		// Token: 0x040027DA RID: 10202
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040027DB RID: 10203
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();
	}
}
