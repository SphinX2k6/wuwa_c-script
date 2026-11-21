using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA7 RID: 3239
	public sealed class PhantomBattleSkillTriggerInfo : IMessage<PhantomBattleSkillTriggerInfo>, IMessage, IEquatable<PhantomBattleSkillTriggerInfo>, IDeepCloneable<PhantomBattleSkillTriggerInfo>, IBufferMessage
	{
		// Token: 0x0601191A RID: 71962 RVA: 0x0029324D File Offset: 0x0029144D
		[NullableContext(1)]
		public static PhantomBattleSkillTriggerInfo Create()
		{
			return new PhantomBattleSkillTriggerInfo();
		}

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x0601191B RID: 71963 RVA: 0x00293254 File Offset: 0x00291454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleSkillTriggerInfo> Parser
		{
			get
			{
				return PhantomBattleSkillTriggerInfo._parser;
			}
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x0601191C RID: 71964 RVA: 0x0029325B File Offset: 0x0029145B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x0601191D RID: 71965 RVA: 0x0029325E File Offset: 0x0029145E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSkillTriggerInfo.Descriptor;
			}
		}

		// Token: 0x0601191E RID: 71966 RVA: 0x00293265 File Offset: 0x00291465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfo()
		{
		}

		// Token: 0x0601191F RID: 71967 RVA: 0x00293278 File Offset: 0x00291478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfo(PhantomBattleSkillTriggerInfo other) : this()
		{
			this.sourceFighterUId_ = other.sourceFighterUId_;
			this.skillId_ = other.skillId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this.phantomBattleEffectResultInfo_ = ((other.phantomBattleEffectResultInfo_ != null) ? other.phantomBattleEffectResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011920 RID: 71968 RVA: 0x002932E1 File Offset: 0x002914E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfo Clone()
		{
			return new PhantomBattleSkillTriggerInfo(this);
		}

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x06011921 RID: 71969 RVA: 0x002932E9 File Offset: 0x002914E9
		// (set) Token: 0x06011922 RID: 71970 RVA: 0x002932F1 File Offset: 0x002914F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceFighterUId
		{
			get
			{
				return this.sourceFighterUId_;
			}
			set
			{
				this.sourceFighterUId_ = value;
			}
		}

		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x06011923 RID: 71971 RVA: 0x002932FA File Offset: 0x002914FA
		// (set) Token: 0x06011924 RID: 71972 RVA: 0x00293302 File Offset: 0x00291502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x06011925 RID: 71973 RVA: 0x0029330B File Offset: 0x0029150B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x06011926 RID: 71974 RVA: 0x00293313 File Offset: 0x00291513
		// (set) Token: 0x06011927 RID: 71975 RVA: 0x0029331B File Offset: 0x0029151B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectResultInfo PhantomBattleEffectResultInfo
		{
			get
			{
				return this.phantomBattleEffectResultInfo_;
			}
			set
			{
				this.phantomBattleEffectResultInfo_ = value;
			}
		}

		// Token: 0x06011928 RID: 71976 RVA: 0x00293324 File Offset: 0x00291524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSkillTriggerInfo);
		}

		// Token: 0x06011929 RID: 71977 RVA: 0x00293334 File Offset: 0x00291534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSkillTriggerInfo other)
		{
			return other != null && (other == this || (this.SourceFighterUId == other.SourceFighterUId && this.SkillId == other.SkillId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this.PhantomBattleEffectResultInfo, other.PhantomBattleEffectResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601192A RID: 71978 RVA: 0x002933A8 File Offset: 0x002915A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SourceFighterUId != 0)
			{
				num ^= this.SourceFighterUId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			num ^= this.selectFighterUId_.GetHashCode();
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				num ^= this.PhantomBattleEffectResultInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601192B RID: 71979 RVA: 0x00293424 File Offset: 0x00291624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601192C RID: 71980 RVA: 0x00293431 File Offset: 0x00291631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601192D RID: 71981 RVA: 0x0029343C File Offset: 0x0029163C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SourceFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SourceFighterUId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillId);
			}
			this.selectFighterUId_.WriteTo(ref output, PhantomBattleSkillTriggerInfo._repeated_selectFighterUId_codec);
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PhantomBattleEffectResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601192E RID: 71982 RVA: 0x002934C4 File Offset: 0x002916C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SourceFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceFighterUId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			num += this.selectFighterUId_.CalculateSize(PhantomBattleSkillTriggerInfo._repeated_selectFighterUId_codec);
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleEffectResultInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601192F RID: 71983 RVA: 0x00293548 File Offset: 0x00291748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSkillTriggerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SourceFighterUId != 0)
			{
				this.SourceFighterUId = other.SourceFighterUId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this.selectFighterUId_.Add(other.selectFighterUId_);
			if (other.phantomBattleEffectResultInfo_ != null)
			{
				if (this.phantomBattleEffectResultInfo_ == null)
				{
					this.PhantomBattleEffectResultInfo = new PhantomBattleEffectResultInfo();
				}
				this.PhantomBattleEffectResultInfo.MergeFrom(other.PhantomBattleEffectResultInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011930 RID: 71984 RVA: 0x002935D5 File Offset: 0x002917D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011931 RID: 71985 RVA: 0x002935E0 File Offset: 0x002917E0
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
						this.SourceFighterUId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.selectFighterUId_.AddEntriesFrom(ref input, PhantomBattleSkillTriggerInfo._repeated_selectFighterUId_codec);
						continue;
					}
					if (num == 34U)
					{
						if (this.phantomBattleEffectResultInfo_ == null)
						{
							this.PhantomBattleEffectResultInfo = new PhantomBattleEffectResultInfo();
						}
						input.ReadMessage(this.PhantomBattleEffectResultInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006F1B RID: 28443
		private static readonly MessageParser<PhantomBattleSkillTriggerInfo> _parser = new MessageParser<PhantomBattleSkillTriggerInfo>(() => new PhantomBattleSkillTriggerInfo());

		// Token: 0x04006F1C RID: 28444
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F1D RID: 28445
		public const int SourceFighterUIdFieldNumber = 1;

		// Token: 0x04006F1E RID: 28446
		private int sourceFighterUId_;

		// Token: 0x04006F1F RID: 28447
		public const int SkillIdFieldNumber = 2;

		// Token: 0x04006F20 RID: 28448
		private int skillId_;

		// Token: 0x04006F21 RID: 28449
		public const int SelectFighterUIdFieldNumber = 3;

		// Token: 0x04006F22 RID: 28450
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006F23 RID: 28451
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x04006F24 RID: 28452
		public const int PhantomBattleEffectResultInfoFieldNumber = 4;

		// Token: 0x04006F25 RID: 28453
		private PhantomBattleEffectResultInfo phantomBattleEffectResultInfo_;
	}
}
