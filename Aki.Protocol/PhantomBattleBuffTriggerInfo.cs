using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C28 RID: 3112
	public sealed class PhantomBattleBuffTriggerInfo : IMessage<PhantomBattleBuffTriggerInfo>, IMessage, IEquatable<PhantomBattleBuffTriggerInfo>, IDeepCloneable<PhantomBattleBuffTriggerInfo>, IBufferMessage
	{
		// Token: 0x06010E71 RID: 69233 RVA: 0x0027A01F File Offset: 0x0027821F
		[NullableContext(1)]
		public static PhantomBattleBuffTriggerInfo Create()
		{
			return new PhantomBattleBuffTriggerInfo();
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x06010E72 RID: 69234 RVA: 0x0027A026 File Offset: 0x00278226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleBuffTriggerInfo> Parser
		{
			get
			{
				return PhantomBattleBuffTriggerInfo._parser;
			}
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x06010E73 RID: 69235 RVA: 0x0027A02D File Offset: 0x0027822D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x06010E74 RID: 69236 RVA: 0x0027A030 File Offset: 0x00278230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBuffTriggerInfo.Descriptor;
			}
		}

		// Token: 0x06010E75 RID: 69237 RVA: 0x0027A037 File Offset: 0x00278237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfo()
		{
		}

		// Token: 0x06010E76 RID: 69238 RVA: 0x0027A04C File Offset: 0x0027824C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfo(PhantomBattleBuffTriggerInfo other) : this()
		{
			this.sourceFighterUId_ = other.sourceFighterUId_;
			this.phantomBattleBuffId_ = other.phantomBattleBuffId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this.phantomBattleEffectResultInfo_ = ((other.phantomBattleEffectResultInfo_ != null) ? other.phantomBattleEffectResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E77 RID: 69239 RVA: 0x0027A0B5 File Offset: 0x002782B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfo Clone()
		{
			return new PhantomBattleBuffTriggerInfo(this);
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x06010E78 RID: 69240 RVA: 0x0027A0BD File Offset: 0x002782BD
		// (set) Token: 0x06010E79 RID: 69241 RVA: 0x0027A0C5 File Offset: 0x002782C5
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

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x06010E7A RID: 69242 RVA: 0x0027A0CE File Offset: 0x002782CE
		// (set) Token: 0x06010E7B RID: 69243 RVA: 0x0027A0D6 File Offset: 0x002782D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleBuffId
		{
			get
			{
				return this.phantomBattleBuffId_;
			}
			set
			{
				this.phantomBattleBuffId_ = value;
			}
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x06010E7C RID: 69244 RVA: 0x0027A0DF File Offset: 0x002782DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x06010E7D RID: 69245 RVA: 0x0027A0E7 File Offset: 0x002782E7
		// (set) Token: 0x06010E7E RID: 69246 RVA: 0x0027A0EF File Offset: 0x002782EF
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

		// Token: 0x06010E7F RID: 69247 RVA: 0x0027A0F8 File Offset: 0x002782F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBuffTriggerInfo);
		}

		// Token: 0x06010E80 RID: 69248 RVA: 0x0027A108 File Offset: 0x00278308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBuffTriggerInfo other)
		{
			return other != null && (other == this || (this.SourceFighterUId == other.SourceFighterUId && this.PhantomBattleBuffId == other.PhantomBattleBuffId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this.PhantomBattleEffectResultInfo, other.PhantomBattleEffectResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E81 RID: 69249 RVA: 0x0027A17C File Offset: 0x0027837C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SourceFighterUId != 0)
			{
				num ^= this.SourceFighterUId.GetHashCode();
			}
			if (this.PhantomBattleBuffId != 0)
			{
				num ^= this.PhantomBattleBuffId.GetHashCode();
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

		// Token: 0x06010E82 RID: 69250 RVA: 0x0027A1F8 File Offset: 0x002783F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E83 RID: 69251 RVA: 0x0027A205 File Offset: 0x00278405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E84 RID: 69252 RVA: 0x0027A210 File Offset: 0x00278410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SourceFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SourceFighterUId);
			}
			if (this.PhantomBattleBuffId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PhantomBattleBuffId);
			}
			this.selectFighterUId_.WriteTo(ref output, PhantomBattleBuffTriggerInfo._repeated_selectFighterUId_codec);
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

		// Token: 0x06010E85 RID: 69253 RVA: 0x0027A298 File Offset: 0x00278498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SourceFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceFighterUId);
			}
			if (this.PhantomBattleBuffId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleBuffId);
			}
			num += this.selectFighterUId_.CalculateSize(PhantomBattleBuffTriggerInfo._repeated_selectFighterUId_codec);
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

		// Token: 0x06010E86 RID: 69254 RVA: 0x0027A31C File Offset: 0x0027851C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBuffTriggerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SourceFighterUId != 0)
			{
				this.SourceFighterUId = other.SourceFighterUId;
			}
			if (other.PhantomBattleBuffId != 0)
			{
				this.PhantomBattleBuffId = other.PhantomBattleBuffId;
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

		// Token: 0x06010E87 RID: 69255 RVA: 0x0027A3A9 File Offset: 0x002785A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E88 RID: 69256 RVA: 0x0027A3B4 File Offset: 0x002785B4
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
						this.PhantomBattleBuffId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.selectFighterUId_.AddEntriesFrom(ref input, PhantomBattleBuffTriggerInfo._repeated_selectFighterUId_codec);
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

		// Token: 0x04006BA3 RID: 27555
		private static readonly MessageParser<PhantomBattleBuffTriggerInfo> _parser = new MessageParser<PhantomBattleBuffTriggerInfo>(() => new PhantomBattleBuffTriggerInfo());

		// Token: 0x04006BA4 RID: 27556
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BA5 RID: 27557
		public const int SourceFighterUIdFieldNumber = 1;

		// Token: 0x04006BA6 RID: 27558
		private int sourceFighterUId_;

		// Token: 0x04006BA7 RID: 27559
		public const int PhantomBattleBuffIdFieldNumber = 2;

		// Token: 0x04006BA8 RID: 27560
		private int phantomBattleBuffId_;

		// Token: 0x04006BA9 RID: 27561
		public const int SelectFighterUIdFieldNumber = 3;

		// Token: 0x04006BAA RID: 27562
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006BAB RID: 27563
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x04006BAC RID: 27564
		public const int PhantomBattleEffectResultInfoFieldNumber = 4;

		// Token: 0x04006BAD RID: 27565
		private PhantomBattleEffectResultInfo phantomBattleEffectResultInfo_;
	}
}
