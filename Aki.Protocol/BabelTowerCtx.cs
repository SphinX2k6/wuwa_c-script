using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014A RID: 330
	public sealed class BabelTowerCtx : IMessage<BabelTowerCtx>, IMessage, IEquatable<BabelTowerCtx>, IDeepCloneable<BabelTowerCtx>, IBufferMessage
	{
		// Token: 0x06002A5E RID: 10846 RVA: 0x0006F25B File Offset: 0x0006D45B
		[NullableContext(1)]
		public static BabelTowerCtx Create()
		{
			return new BabelTowerCtx();
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x0006F262 File Offset: 0x0006D462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x0006F265 File Offset: 0x0006D465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerCtx.Descriptor;
			}
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x0006F26C File Offset: 0x0006D46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerCtx()
		{
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x0006F28C File Offset: 0x0006D48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerCtx(BabelTowerCtx other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.selectBuff_ = other.selectBuff_.Clone();
			this.skillBranchId_ = other.skillBranchId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x0006F2DE File Offset: 0x0006D4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerCtx Clone()
		{
			return new BabelTowerCtx(this);
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06002A64 RID: 10852 RVA: 0x0006F2E6 File Offset: 0x0006D4E6
		// (set) Token: 0x06002A65 RID: 10853 RVA: 0x0006F2EE File Offset: 0x0006D4EE
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

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002A66 RID: 10854 RVA: 0x0006F2F7 File Offset: 0x0006D4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectBuff
		{
			get
			{
				return this.selectBuff_;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x0006F2FF File Offset: 0x0006D4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x0006F307 File Offset: 0x0006D507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerCtx);
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x0006F318 File Offset: 0x0006D518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerCtx other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.selectBuff_.Equals(other.selectBuff_) && this.skillBranchId_.Equals(other.skillBranchId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x0006F37C File Offset: 0x0006D57C
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

		// Token: 0x06002A6B RID: 10859 RVA: 0x0006F3D7 File Offset: 0x0006D5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x0006F3E4 File Offset: 0x0006D5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x0006F3F0 File Offset: 0x0006D5F0
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

		// Token: 0x06002A6E RID: 10862 RVA: 0x0006F450 File Offset: 0x0006D650
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

		// Token: 0x06002A6F RID: 10863 RVA: 0x0006F4B4 File Offset: 0x0006D6B4
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

		// Token: 0x06002A70 RID: 10864 RVA: 0x0006F512 File Offset: 0x0006D712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x0006F51C File Offset: 0x0006D71C
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

		// Token: 0x0400275F RID: 10079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002760 RID: 10080
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x04002761 RID: 10081
		private int levelsId_;

		// Token: 0x04002762 RID: 10082
		public const int SelectBuffFieldNumber = 2;

		// Token: 0x04002763 RID: 10083
		private static readonly FieldCodec<int> _repeated_selectBuff_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002764 RID: 10084
		private readonly RepeatedField<int> selectBuff_ = new RepeatedField<int>();

		// Token: 0x04002765 RID: 10085
		public const int SkillBranchIdFieldNumber = 3;

		// Token: 0x04002766 RID: 10086
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002767 RID: 10087
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();
	}
}
