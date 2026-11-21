using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F77 RID: 3959
	public sealed class RogueHotEntryInfo : IMessage<RogueHotEntryInfo>, IMessage, IEquatable<RogueHotEntryInfo>, IDeepCloneable<RogueHotEntryInfo>, IBufferMessage
	{
		// Token: 0x06015337 RID: 86839 RVA: 0x00313DF4 File Offset: 0x00311FF4
		[NullableContext(1)]
		public static RogueHotEntryInfo Create()
		{
			return new RogueHotEntryInfo();
		}

		// Token: 0x1700469D RID: 18077
		// (get) Token: 0x06015338 RID: 86840 RVA: 0x00313DFB File Offset: 0x00311FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueHotEntryInfo> Parser
		{
			get
			{
				return RogueHotEntryInfo._parser;
			}
		}

		// Token: 0x1700469E RID: 18078
		// (get) Token: 0x06015339 RID: 86841 RVA: 0x00313E02 File Offset: 0x00312002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700469F RID: 18079
		// (get) Token: 0x0601533A RID: 86842 RVA: 0x00313E05 File Offset: 0x00312005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueHotEntryInfo.Descriptor;
			}
		}

		// Token: 0x0601533B RID: 86843 RVA: 0x00313E0C File Offset: 0x0031200C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHotEntryInfo()
		{
		}

		// Token: 0x0601533C RID: 86844 RVA: 0x00313E4C File Offset: 0x0031204C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHotEntryInfo(RogueHotEntryInfo other) : this()
		{
			this.instId_ = other.instId_;
			this.visibleHotEntryGroupIds_ = other.visibleHotEntryGroupIds_.Clone();
			this.selectableHotEntryGroupIds_ = other.selectableHotEntryGroupIds_.Clone();
			this.unlockHotEntryGroupIds_ = other.unlockHotEntryGroupIds_.Clone();
			this.visibleRoleIds_ = other.visibleRoleIds_.Clone();
			this.visiblePhantomIds_ = other.visiblePhantomIds_.Clone();
			this.roleShowLevel_ = other.roleShowLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601533D RID: 86845 RVA: 0x00313EDD File Offset: 0x003120DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHotEntryInfo Clone()
		{
			return new RogueHotEntryInfo(this);
		}

		// Token: 0x170046A0 RID: 18080
		// (get) Token: 0x0601533E RID: 86846 RVA: 0x00313EE5 File Offset: 0x003120E5
		// (set) Token: 0x0601533F RID: 86847 RVA: 0x00313EED File Offset: 0x003120ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170046A1 RID: 18081
		// (get) Token: 0x06015340 RID: 86848 RVA: 0x00313EF6 File Offset: 0x003120F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> VisibleHotEntryGroupIds
		{
			get
			{
				return this.visibleHotEntryGroupIds_;
			}
		}

		// Token: 0x170046A2 RID: 18082
		// (get) Token: 0x06015341 RID: 86849 RVA: 0x00313EFE File Offset: 0x003120FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectableHotEntryGroupIds
		{
			get
			{
				return this.selectableHotEntryGroupIds_;
			}
		}

		// Token: 0x170046A3 RID: 18083
		// (get) Token: 0x06015342 RID: 86850 RVA: 0x00313F06 File Offset: 0x00312106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockHotEntryGroupIds
		{
			get
			{
				return this.unlockHotEntryGroupIds_;
			}
		}

		// Token: 0x170046A4 RID: 18084
		// (get) Token: 0x06015343 RID: 86851 RVA: 0x00313F0E File Offset: 0x0031210E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> VisibleRoleIds
		{
			get
			{
				return this.visibleRoleIds_;
			}
		}

		// Token: 0x170046A5 RID: 18085
		// (get) Token: 0x06015344 RID: 86852 RVA: 0x00313F16 File Offset: 0x00312116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> VisiblePhantomIds
		{
			get
			{
				return this.visiblePhantomIds_;
			}
		}

		// Token: 0x170046A6 RID: 18086
		// (get) Token: 0x06015345 RID: 86853 RVA: 0x00313F1E File Offset: 0x0031211E
		// (set) Token: 0x06015346 RID: 86854 RVA: 0x00313F26 File Offset: 0x00312126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleShowLevel
		{
			get
			{
				return this.roleShowLevel_;
			}
			set
			{
				this.roleShowLevel_ = value;
			}
		}

		// Token: 0x06015347 RID: 86855 RVA: 0x00313F2F File Offset: 0x0031212F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueHotEntryInfo);
		}

		// Token: 0x06015348 RID: 86856 RVA: 0x00313F40 File Offset: 0x00312140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueHotEntryInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.visibleHotEntryGroupIds_.Equals(other.visibleHotEntryGroupIds_) && this.selectableHotEntryGroupIds_.Equals(other.selectableHotEntryGroupIds_) && this.unlockHotEntryGroupIds_.Equals(other.unlockHotEntryGroupIds_) && this.visibleRoleIds_.Equals(other.visibleRoleIds_) && this.visiblePhantomIds_.Equals(other.visiblePhantomIds_) && this.RoleShowLevel == other.RoleShowLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015349 RID: 86857 RVA: 0x00313FF4 File Offset: 0x003121F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.visibleHotEntryGroupIds_.GetHashCode();
			num ^= this.selectableHotEntryGroupIds_.GetHashCode();
			num ^= this.unlockHotEntryGroupIds_.GetHashCode();
			num ^= this.visibleRoleIds_.GetHashCode();
			num ^= this.visiblePhantomIds_.GetHashCode();
			if (this.RoleShowLevel != 0)
			{
				num ^= this.RoleShowLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601534A RID: 86858 RVA: 0x00314092 File Offset: 0x00312292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601534B RID: 86859 RVA: 0x0031409F File Offset: 0x0031229F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601534C RID: 86860 RVA: 0x003140A8 File Offset: 0x003122A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			this.visibleHotEntryGroupIds_.WriteTo(ref output, RogueHotEntryInfo._repeated_visibleHotEntryGroupIds_codec);
			this.selectableHotEntryGroupIds_.WriteTo(ref output, RogueHotEntryInfo._repeated_selectableHotEntryGroupIds_codec);
			this.unlockHotEntryGroupIds_.WriteTo(ref output, RogueHotEntryInfo._repeated_unlockHotEntryGroupIds_codec);
			this.visibleRoleIds_.WriteTo(ref output, RogueHotEntryInfo._repeated_visibleRoleIds_codec);
			this.visiblePhantomIds_.WriteTo(ref output, RogueHotEntryInfo._repeated_visiblePhantomIds_codec);
			if (this.RoleShowLevel != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleShowLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601534D RID: 86861 RVA: 0x00314158 File Offset: 0x00312358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.visibleHotEntryGroupIds_.CalculateSize(RogueHotEntryInfo._repeated_visibleHotEntryGroupIds_codec);
			num += this.selectableHotEntryGroupIds_.CalculateSize(RogueHotEntryInfo._repeated_selectableHotEntryGroupIds_codec);
			num += this.unlockHotEntryGroupIds_.CalculateSize(RogueHotEntryInfo._repeated_unlockHotEntryGroupIds_codec);
			num += this.visibleRoleIds_.CalculateSize(RogueHotEntryInfo._repeated_visibleRoleIds_codec);
			num += this.visiblePhantomIds_.CalculateSize(RogueHotEntryInfo._repeated_visiblePhantomIds_codec);
			if (this.RoleShowLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleShowLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601534E RID: 86862 RVA: 0x00314210 File Offset: 0x00312410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueHotEntryInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.visibleHotEntryGroupIds_.Add(other.visibleHotEntryGroupIds_);
			this.selectableHotEntryGroupIds_.Add(other.selectableHotEntryGroupIds_);
			this.unlockHotEntryGroupIds_.Add(other.unlockHotEntryGroupIds_);
			this.visibleRoleIds_.Add(other.visibleRoleIds_);
			this.visiblePhantomIds_.Add(other.visiblePhantomIds_);
			if (other.RoleShowLevel != 0)
			{
				this.RoleShowLevel = other.RoleShowLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601534F RID: 86863 RVA: 0x003142B5 File Offset: 0x003124B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015350 RID: 86864 RVA: 0x003142C0 File Offset: 0x003124C0
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
				if (num <= 32U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.InstId = input.ReadInt32();
							continue;
						}
						if (num == 16U || num == 18U)
						{
							this.visibleHotEntryGroupIds_.AddEntriesFrom(ref input, RogueHotEntryInfo._repeated_visibleHotEntryGroupIds_codec);
							continue;
						}
					}
					else
					{
						if (num == 24U || num == 26U)
						{
							this.selectableHotEntryGroupIds_.AddEntriesFrom(ref input, RogueHotEntryInfo._repeated_selectableHotEntryGroupIds_codec);
							continue;
						}
						if (num == 32U)
						{
							goto IL_A7;
						}
					}
				}
				else if (num <= 42U)
				{
					if (num == 34U)
					{
						goto IL_A7;
					}
					if (num == 40U || num == 42U)
					{
						this.visibleRoleIds_.AddEntriesFrom(ref input, RogueHotEntryInfo._repeated_visibleRoleIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U || num == 50U)
					{
						this.visiblePhantomIds_.AddEntriesFrom(ref input, RogueHotEntryInfo._repeated_visiblePhantomIds_codec);
						continue;
					}
					if (num == 56U)
					{
						this.RoleShowLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_A7:
				this.unlockHotEntryGroupIds_.AddEntriesFrom(ref input, RogueHotEntryInfo._repeated_unlockHotEntryGroupIds_codec);
			}
		}

		// Token: 0x04008004 RID: 32772
		private static readonly MessageParser<RogueHotEntryInfo> _parser = new MessageParser<RogueHotEntryInfo>(() => new RogueHotEntryInfo());

		// Token: 0x04008005 RID: 32773
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008006 RID: 32774
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008007 RID: 32775
		private int instId_;

		// Token: 0x04008008 RID: 32776
		public const int VisibleHotEntryGroupIdsFieldNumber = 2;

		// Token: 0x04008009 RID: 32777
		private static readonly FieldCodec<int> _repeated_visibleHotEntryGroupIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400800A RID: 32778
		private readonly RepeatedField<int> visibleHotEntryGroupIds_ = new RepeatedField<int>();

		// Token: 0x0400800B RID: 32779
		public const int SelectableHotEntryGroupIdsFieldNumber = 3;

		// Token: 0x0400800C RID: 32780
		private static readonly FieldCodec<int> _repeated_selectableHotEntryGroupIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400800D RID: 32781
		private readonly RepeatedField<int> selectableHotEntryGroupIds_ = new RepeatedField<int>();

		// Token: 0x0400800E RID: 32782
		public const int UnlockHotEntryGroupIdsFieldNumber = 4;

		// Token: 0x0400800F RID: 32783
		private static readonly FieldCodec<int> _repeated_unlockHotEntryGroupIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04008010 RID: 32784
		private readonly RepeatedField<int> unlockHotEntryGroupIds_ = new RepeatedField<int>();

		// Token: 0x04008011 RID: 32785
		public const int VisibleRoleIdsFieldNumber = 5;

		// Token: 0x04008012 RID: 32786
		private static readonly FieldCodec<int> _repeated_visibleRoleIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04008013 RID: 32787
		private readonly RepeatedField<int> visibleRoleIds_ = new RepeatedField<int>();

		// Token: 0x04008014 RID: 32788
		public const int VisiblePhantomIdsFieldNumber = 6;

		// Token: 0x04008015 RID: 32789
		private static readonly FieldCodec<int> _repeated_visiblePhantomIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04008016 RID: 32790
		private readonly RepeatedField<int> visiblePhantomIds_ = new RepeatedField<int>();

		// Token: 0x04008017 RID: 32791
		public const int RoleShowLevelFieldNumber = 7;

		// Token: 0x04008018 RID: 32792
		private int roleShowLevel_;
	}
}
