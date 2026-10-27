using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F87 RID: 3975
	public sealed class RogueHotEntryInfo : IMessage<RogueHotEntryInfo>, IMessage, IEquatable<RogueHotEntryInfo>, IDeepCloneable<RogueHotEntryInfo>, IBufferMessage
	{
		// Token: 0x0601541C RID: 87068 RVA: 0x003154A8 File Offset: 0x003136A8
		[NullableContext(1)]
		public static RogueHotEntryInfo Create()
		{
			return new RogueHotEntryInfo();
		}

		// Token: 0x170046C7 RID: 18119
		// (get) Token: 0x0601541D RID: 87069 RVA: 0x003154AF File Offset: 0x003136AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueHotEntryInfo> Parser
		{
			get
			{
				return RogueHotEntryInfo._parser;
			}
		}

		// Token: 0x170046C8 RID: 18120
		// (get) Token: 0x0601541E RID: 87070 RVA: 0x003154B6 File Offset: 0x003136B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046C9 RID: 18121
		// (get) Token: 0x0601541F RID: 87071 RVA: 0x003154B9 File Offset: 0x003136B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueHotEntryInfo.Descriptor;
			}
		}

		// Token: 0x06015420 RID: 87072 RVA: 0x003154C0 File Offset: 0x003136C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHotEntryInfo()
		{
		}

		// Token: 0x06015421 RID: 87073 RVA: 0x00315500 File Offset: 0x00313700
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

		// Token: 0x06015422 RID: 87074 RVA: 0x00315591 File Offset: 0x00313791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHotEntryInfo Clone()
		{
			return new RogueHotEntryInfo(this);
		}

		// Token: 0x170046CA RID: 18122
		// (get) Token: 0x06015423 RID: 87075 RVA: 0x00315599 File Offset: 0x00313799
		// (set) Token: 0x06015424 RID: 87076 RVA: 0x003155A1 File Offset: 0x003137A1
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

		// Token: 0x170046CB RID: 18123
		// (get) Token: 0x06015425 RID: 87077 RVA: 0x003155AA File Offset: 0x003137AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> VisibleHotEntryGroupIds
		{
			get
			{
				return this.visibleHotEntryGroupIds_;
			}
		}

		// Token: 0x170046CC RID: 18124
		// (get) Token: 0x06015426 RID: 87078 RVA: 0x003155B2 File Offset: 0x003137B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectableHotEntryGroupIds
		{
			get
			{
				return this.selectableHotEntryGroupIds_;
			}
		}

		// Token: 0x170046CD RID: 18125
		// (get) Token: 0x06015427 RID: 87079 RVA: 0x003155BA File Offset: 0x003137BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockHotEntryGroupIds
		{
			get
			{
				return this.unlockHotEntryGroupIds_;
			}
		}

		// Token: 0x170046CE RID: 18126
		// (get) Token: 0x06015428 RID: 87080 RVA: 0x003155C2 File Offset: 0x003137C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> VisibleRoleIds
		{
			get
			{
				return this.visibleRoleIds_;
			}
		}

		// Token: 0x170046CF RID: 18127
		// (get) Token: 0x06015429 RID: 87081 RVA: 0x003155CA File Offset: 0x003137CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> VisiblePhantomIds
		{
			get
			{
				return this.visiblePhantomIds_;
			}
		}

		// Token: 0x170046D0 RID: 18128
		// (get) Token: 0x0601542A RID: 87082 RVA: 0x003155D2 File Offset: 0x003137D2
		// (set) Token: 0x0601542B RID: 87083 RVA: 0x003155DA File Offset: 0x003137DA
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

		// Token: 0x0601542C RID: 87084 RVA: 0x003155E3 File Offset: 0x003137E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueHotEntryInfo);
		}

		// Token: 0x0601542D RID: 87085 RVA: 0x003155F4 File Offset: 0x003137F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueHotEntryInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.visibleHotEntryGroupIds_.Equals(other.visibleHotEntryGroupIds_) && this.selectableHotEntryGroupIds_.Equals(other.selectableHotEntryGroupIds_) && this.unlockHotEntryGroupIds_.Equals(other.unlockHotEntryGroupIds_) && this.visibleRoleIds_.Equals(other.visibleRoleIds_) && this.visiblePhantomIds_.Equals(other.visiblePhantomIds_) && this.RoleShowLevel == other.RoleShowLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601542E RID: 87086 RVA: 0x003156A8 File Offset: 0x003138A8
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

		// Token: 0x0601542F RID: 87087 RVA: 0x00315746 File Offset: 0x00313946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015430 RID: 87088 RVA: 0x00315753 File Offset: 0x00313953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015431 RID: 87089 RVA: 0x0031575C File Offset: 0x0031395C
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

		// Token: 0x06015432 RID: 87090 RVA: 0x0031580C File Offset: 0x00313A0C
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

		// Token: 0x06015433 RID: 87091 RVA: 0x003158C4 File Offset: 0x00313AC4
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

		// Token: 0x06015434 RID: 87092 RVA: 0x00315969 File Offset: 0x00313B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015435 RID: 87093 RVA: 0x00315974 File Offset: 0x00313B74
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

		// Token: 0x04007FDA RID: 32730
		private static readonly MessageParser<RogueHotEntryInfo> _parser = new MessageParser<RogueHotEntryInfo>(() => new RogueHotEntryInfo());

		// Token: 0x04007FDB RID: 32731
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FDC RID: 32732
		public const int InstIdFieldNumber = 1;

		// Token: 0x04007FDD RID: 32733
		private int instId_;

		// Token: 0x04007FDE RID: 32734
		public const int VisibleHotEntryGroupIdsFieldNumber = 2;

		// Token: 0x04007FDF RID: 32735
		private static readonly FieldCodec<int> _repeated_visibleHotEntryGroupIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007FE0 RID: 32736
		private readonly RepeatedField<int> visibleHotEntryGroupIds_ = new RepeatedField<int>();

		// Token: 0x04007FE1 RID: 32737
		public const int SelectableHotEntryGroupIdsFieldNumber = 3;

		// Token: 0x04007FE2 RID: 32738
		private static readonly FieldCodec<int> _repeated_selectableHotEntryGroupIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007FE3 RID: 32739
		private readonly RepeatedField<int> selectableHotEntryGroupIds_ = new RepeatedField<int>();

		// Token: 0x04007FE4 RID: 32740
		public const int UnlockHotEntryGroupIdsFieldNumber = 4;

		// Token: 0x04007FE5 RID: 32741
		private static readonly FieldCodec<int> _repeated_unlockHotEntryGroupIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007FE6 RID: 32742
		private readonly RepeatedField<int> unlockHotEntryGroupIds_ = new RepeatedField<int>();

		// Token: 0x04007FE7 RID: 32743
		public const int VisibleRoleIdsFieldNumber = 5;

		// Token: 0x04007FE8 RID: 32744
		private static readonly FieldCodec<int> _repeated_visibleRoleIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007FE9 RID: 32745
		private readonly RepeatedField<int> visibleRoleIds_ = new RepeatedField<int>();

		// Token: 0x04007FEA RID: 32746
		public const int VisiblePhantomIdsFieldNumber = 6;

		// Token: 0x04007FEB RID: 32747
		private static readonly FieldCodec<int> _repeated_visiblePhantomIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007FEC RID: 32748
		private readonly RepeatedField<int> visiblePhantomIds_ = new RepeatedField<int>();

		// Token: 0x04007FED RID: 32749
		public const int RoleShowLevelFieldNumber = 7;

		// Token: 0x04007FEE RID: 32750
		private int roleShowLevel_;
	}
}
