using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C7 RID: 4295
	public sealed class RoleTowerFloorBranchInfo : IMessage<RoleTowerFloorBranchInfo>, IMessage, IEquatable<RoleTowerFloorBranchInfo>, IDeepCloneable<RoleTowerFloorBranchInfo>, IBufferMessage
	{
		// Token: 0x06016F41 RID: 94017 RVA: 0x003565FE File Offset: 0x003547FE
		[NullableContext(1)]
		public static RoleTowerFloorBranchInfo Create()
		{
			return new RoleTowerFloorBranchInfo();
		}

		// Token: 0x17004CF8 RID: 19704
		// (get) Token: 0x06016F42 RID: 94018 RVA: 0x00356605 File Offset: 0x00354805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerFloorBranchInfo> Parser
		{
			get
			{
				return RoleTowerFloorBranchInfo._parser;
			}
		}

		// Token: 0x17004CF9 RID: 19705
		// (get) Token: 0x06016F43 RID: 94019 RVA: 0x0035660C File Offset: 0x0035480C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CFA RID: 19706
		// (get) Token: 0x06016F44 RID: 94020 RVA: 0x0035660F File Offset: 0x0035480F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerFloorBranchInfo.Descriptor;
			}
		}

		// Token: 0x06016F45 RID: 94021 RVA: 0x00356616 File Offset: 0x00354816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorBranchInfo()
		{
		}

		// Token: 0x06016F46 RID: 94022 RVA: 0x00356634 File Offset: 0x00354834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorBranchInfo(RoleTowerFloorBranchInfo other) : this()
		{
			this.branchIndex_ = other.branchIndex_;
			this.monsterPreviewIds_ = other.monsterPreviewIds_.Clone();
			this.tokenRewards_ = other.tokenRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F47 RID: 94023 RVA: 0x00356686 File Offset: 0x00354886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorBranchInfo Clone()
		{
			return new RoleTowerFloorBranchInfo(this);
		}

		// Token: 0x17004CFB RID: 19707
		// (get) Token: 0x06016F48 RID: 94024 RVA: 0x0035668E File Offset: 0x0035488E
		// (set) Token: 0x06016F49 RID: 94025 RVA: 0x00356696 File Offset: 0x00354896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BranchIndex
		{
			get
			{
				return this.branchIndex_;
			}
			set
			{
				this.branchIndex_ = value;
			}
		}

		// Token: 0x17004CFC RID: 19708
		// (get) Token: 0x06016F4A RID: 94026 RVA: 0x0035669F File Offset: 0x0035489F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterPreviewIds
		{
			get
			{
				return this.monsterPreviewIds_;
			}
		}

		// Token: 0x17004CFD RID: 19709
		// (get) Token: 0x06016F4B RID: 94027 RVA: 0x003566A7 File Offset: 0x003548A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerTokenCount> TokenRewards
		{
			get
			{
				return this.tokenRewards_;
			}
		}

		// Token: 0x06016F4C RID: 94028 RVA: 0x003566AF File Offset: 0x003548AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerFloorBranchInfo);
		}

		// Token: 0x06016F4D RID: 94029 RVA: 0x003566C0 File Offset: 0x003548C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerFloorBranchInfo other)
		{
			return other != null && (other == this || (this.BranchIndex == other.BranchIndex && this.monsterPreviewIds_.Equals(other.monsterPreviewIds_) && this.tokenRewards_.Equals(other.tokenRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016F4E RID: 94030 RVA: 0x00356724 File Offset: 0x00354924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BranchIndex != 0)
			{
				num ^= this.BranchIndex.GetHashCode();
			}
			num ^= this.monsterPreviewIds_.GetHashCode();
			num ^= this.tokenRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016F4F RID: 94031 RVA: 0x0035677F File Offset: 0x0035497F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F50 RID: 94032 RVA: 0x0035678C File Offset: 0x0035498C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F51 RID: 94033 RVA: 0x00356798 File Offset: 0x00354998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BranchIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BranchIndex);
			}
			this.monsterPreviewIds_.WriteTo(ref output, RoleTowerFloorBranchInfo._repeated_monsterPreviewIds_codec);
			this.tokenRewards_.WriteTo(ref output, RoleTowerFloorBranchInfo._repeated_tokenRewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F52 RID: 94034 RVA: 0x003567F8 File Offset: 0x003549F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BranchIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BranchIndex);
			}
			num += this.monsterPreviewIds_.CalculateSize(RoleTowerFloorBranchInfo._repeated_monsterPreviewIds_codec);
			num += this.tokenRewards_.CalculateSize(RoleTowerFloorBranchInfo._repeated_tokenRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016F53 RID: 94035 RVA: 0x0035685C File Offset: 0x00354A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerFloorBranchInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BranchIndex != 0)
			{
				this.BranchIndex = other.BranchIndex;
			}
			this.monsterPreviewIds_.Add(other.monsterPreviewIds_);
			this.tokenRewards_.Add(other.tokenRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016F54 RID: 94036 RVA: 0x003568BA File Offset: 0x00354ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F55 RID: 94037 RVA: 0x003568C4 File Offset: 0x00354AC4
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.BranchIndex = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_45;
					}
					if (num == 34U)
					{
						this.tokenRewards_.AddEntriesFrom(ref input, RoleTowerFloorBranchInfo._repeated_tokenRewards_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.monsterPreviewIds_.AddEntriesFrom(ref input, RoleTowerFloorBranchInfo._repeated_monsterPreviewIds_codec);
			}
		}

		// Token: 0x04008957 RID: 35159
		private static readonly MessageParser<RoleTowerFloorBranchInfo> _parser = new MessageParser<RoleTowerFloorBranchInfo>(() => new RoleTowerFloorBranchInfo());

		// Token: 0x04008958 RID: 35160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008959 RID: 35161
		public const int BranchIndexFieldNumber = 1;

		// Token: 0x0400895A RID: 35162
		private int branchIndex_;

		// Token: 0x0400895B RID: 35163
		public const int MonsterPreviewIdsFieldNumber = 3;

		// Token: 0x0400895C RID: 35164
		private static readonly FieldCodec<int> _repeated_monsterPreviewIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400895D RID: 35165
		private readonly RepeatedField<int> monsterPreviewIds_ = new RepeatedField<int>();

		// Token: 0x0400895E RID: 35166
		public const int TokenRewardsFieldNumber = 4;

		// Token: 0x0400895F RID: 35167
		private static readonly FieldCodec<RoleTowerTokenCount> _repeated_tokenRewards_codec = FieldCodec.ForMessage<RoleTowerTokenCount>(34U, RoleTowerTokenCount.Parser);

		// Token: 0x04008960 RID: 35168
		private readonly RepeatedField<RoleTowerTokenCount> tokenRewards_ = new RepeatedField<RoleTowerTokenCount>();
	}
}
