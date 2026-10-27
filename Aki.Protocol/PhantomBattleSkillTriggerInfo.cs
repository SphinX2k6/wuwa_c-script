using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB7 RID: 3255
	public sealed class PhantomBattleSkillTriggerInfo : IMessage<PhantomBattleSkillTriggerInfo>, IMessage, IEquatable<PhantomBattleSkillTriggerInfo>, IDeepCloneable<PhantomBattleSkillTriggerInfo>, IBufferMessage
	{
		// Token: 0x06011A1A RID: 72218 RVA: 0x00294FB0 File Offset: 0x002931B0
		[NullableContext(1)]
		public static PhantomBattleSkillTriggerInfo Create()
		{
			return new PhantomBattleSkillTriggerInfo();
		}

		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x06011A1B RID: 72219 RVA: 0x00294FB7 File Offset: 0x002931B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleSkillTriggerInfo> Parser
		{
			get
			{
				return PhantomBattleSkillTriggerInfo._parser;
			}
		}

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x06011A1C RID: 72220 RVA: 0x00294FBE File Offset: 0x002931BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A6D RID: 14957
		// (get) Token: 0x06011A1D RID: 72221 RVA: 0x00294FC1 File Offset: 0x002931C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSkillTriggerInfo.Descriptor;
			}
		}

		// Token: 0x06011A1E RID: 72222 RVA: 0x00294FC8 File Offset: 0x002931C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfo()
		{
		}

		// Token: 0x06011A1F RID: 72223 RVA: 0x00294FDC File Offset: 0x002931DC
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

		// Token: 0x06011A20 RID: 72224 RVA: 0x00295045 File Offset: 0x00293245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfo Clone()
		{
			return new PhantomBattleSkillTriggerInfo(this);
		}

		// Token: 0x17003A6E RID: 14958
		// (get) Token: 0x06011A21 RID: 72225 RVA: 0x0029504D File Offset: 0x0029324D
		// (set) Token: 0x06011A22 RID: 72226 RVA: 0x00295055 File Offset: 0x00293255
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

		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x06011A23 RID: 72227 RVA: 0x0029505E File Offset: 0x0029325E
		// (set) Token: 0x06011A24 RID: 72228 RVA: 0x00295066 File Offset: 0x00293266
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

		// Token: 0x17003A70 RID: 14960
		// (get) Token: 0x06011A25 RID: 72229 RVA: 0x0029506F File Offset: 0x0029326F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x06011A26 RID: 72230 RVA: 0x00295077 File Offset: 0x00293277
		// (set) Token: 0x06011A27 RID: 72231 RVA: 0x0029507F File Offset: 0x0029327F
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

		// Token: 0x06011A28 RID: 72232 RVA: 0x00295088 File Offset: 0x00293288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSkillTriggerInfo);
		}

		// Token: 0x06011A29 RID: 72233 RVA: 0x00295098 File Offset: 0x00293298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSkillTriggerInfo other)
		{
			return other != null && (other == this || (this.SourceFighterUId == other.SourceFighterUId && this.SkillId == other.SkillId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this.PhantomBattleEffectResultInfo, other.PhantomBattleEffectResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A2A RID: 72234 RVA: 0x0029510C File Offset: 0x0029330C
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

		// Token: 0x06011A2B RID: 72235 RVA: 0x00295188 File Offset: 0x00293388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A2C RID: 72236 RVA: 0x00295195 File Offset: 0x00293395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A2D RID: 72237 RVA: 0x002951A0 File Offset: 0x002933A0
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

		// Token: 0x06011A2E RID: 72238 RVA: 0x00295228 File Offset: 0x00293428
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

		// Token: 0x06011A2F RID: 72239 RVA: 0x002952AC File Offset: 0x002934AC
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

		// Token: 0x06011A30 RID: 72240 RVA: 0x00295339 File Offset: 0x00293539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A31 RID: 72241 RVA: 0x00295344 File Offset: 0x00293544
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

		// Token: 0x04006F07 RID: 28423
		private static readonly MessageParser<PhantomBattleSkillTriggerInfo> _parser = new MessageParser<PhantomBattleSkillTriggerInfo>(() => new PhantomBattleSkillTriggerInfo());

		// Token: 0x04006F08 RID: 28424
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F09 RID: 28425
		public const int SourceFighterUIdFieldNumber = 1;

		// Token: 0x04006F0A RID: 28426
		private int sourceFighterUId_;

		// Token: 0x04006F0B RID: 28427
		public const int SkillIdFieldNumber = 2;

		// Token: 0x04006F0C RID: 28428
		private int skillId_;

		// Token: 0x04006F0D RID: 28429
		public const int SelectFighterUIdFieldNumber = 3;

		// Token: 0x04006F0E RID: 28430
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006F0F RID: 28431
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x04006F10 RID: 28432
		public const int PhantomBattleEffectResultInfoFieldNumber = 4;

		// Token: 0x04006F11 RID: 28433
		private PhantomBattleEffectResultInfo phantomBattleEffectResultInfo_;
	}
}
