using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C38 RID: 3128
	public sealed class PhantomBattleBuffTriggerInfo : IMessage<PhantomBattleBuffTriggerInfo>, IMessage, IEquatable<PhantomBattleBuffTriggerInfo>, IDeepCloneable<PhantomBattleBuffTriggerInfo>, IBufferMessage
	{
		// Token: 0x06010F71 RID: 69489 RVA: 0x0027BD7F File Offset: 0x00279F7F
		[NullableContext(1)]
		public static PhantomBattleBuffTriggerInfo Create()
		{
			return new PhantomBattleBuffTriggerInfo();
		}

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x06010F72 RID: 69490 RVA: 0x0027BD86 File Offset: 0x00279F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleBuffTriggerInfo> Parser
		{
			get
			{
				return PhantomBattleBuffTriggerInfo._parser;
			}
		}

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x06010F73 RID: 69491 RVA: 0x0027BD8D File Offset: 0x00279F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x06010F74 RID: 69492 RVA: 0x0027BD90 File Offset: 0x00279F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBuffTriggerInfo.Descriptor;
			}
		}

		// Token: 0x06010F75 RID: 69493 RVA: 0x0027BD97 File Offset: 0x00279F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfo()
		{
		}

		// Token: 0x06010F76 RID: 69494 RVA: 0x0027BDAC File Offset: 0x00279FAC
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

		// Token: 0x06010F77 RID: 69495 RVA: 0x0027BE15 File Offset: 0x0027A015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBuffTriggerInfo Clone()
		{
			return new PhantomBattleBuffTriggerInfo(this);
		}

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x06010F78 RID: 69496 RVA: 0x0027BE1D File Offset: 0x0027A01D
		// (set) Token: 0x06010F79 RID: 69497 RVA: 0x0027BE25 File Offset: 0x0027A025
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

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x06010F7A RID: 69498 RVA: 0x0027BE2E File Offset: 0x0027A02E
		// (set) Token: 0x06010F7B RID: 69499 RVA: 0x0027BE36 File Offset: 0x0027A036
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

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x06010F7C RID: 69500 RVA: 0x0027BE3F File Offset: 0x0027A03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x06010F7D RID: 69501 RVA: 0x0027BE47 File Offset: 0x0027A047
		// (set) Token: 0x06010F7E RID: 69502 RVA: 0x0027BE4F File Offset: 0x0027A04F
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

		// Token: 0x06010F7F RID: 69503 RVA: 0x0027BE58 File Offset: 0x0027A058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBuffTriggerInfo);
		}

		// Token: 0x06010F80 RID: 69504 RVA: 0x0027BE68 File Offset: 0x0027A068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBuffTriggerInfo other)
		{
			return other != null && (other == this || (this.SourceFighterUId == other.SourceFighterUId && this.PhantomBattleBuffId == other.PhantomBattleBuffId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this.PhantomBattleEffectResultInfo, other.PhantomBattleEffectResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F81 RID: 69505 RVA: 0x0027BEDC File Offset: 0x0027A0DC
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

		// Token: 0x06010F82 RID: 69506 RVA: 0x0027BF58 File Offset: 0x0027A158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F83 RID: 69507 RVA: 0x0027BF65 File Offset: 0x0027A165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F84 RID: 69508 RVA: 0x0027BF70 File Offset: 0x0027A170
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

		// Token: 0x06010F85 RID: 69509 RVA: 0x0027BFF8 File Offset: 0x0027A1F8
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

		// Token: 0x06010F86 RID: 69510 RVA: 0x0027C07C File Offset: 0x0027A27C
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

		// Token: 0x06010F87 RID: 69511 RVA: 0x0027C109 File Offset: 0x0027A309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F88 RID: 69512 RVA: 0x0027C114 File Offset: 0x0027A314
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

		// Token: 0x04006B8F RID: 27535
		private static readonly MessageParser<PhantomBattleBuffTriggerInfo> _parser = new MessageParser<PhantomBattleBuffTriggerInfo>(() => new PhantomBattleBuffTriggerInfo());

		// Token: 0x04006B90 RID: 27536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B91 RID: 27537
		public const int SourceFighterUIdFieldNumber = 1;

		// Token: 0x04006B92 RID: 27538
		private int sourceFighterUId_;

		// Token: 0x04006B93 RID: 27539
		public const int PhantomBattleBuffIdFieldNumber = 2;

		// Token: 0x04006B94 RID: 27540
		private int phantomBattleBuffId_;

		// Token: 0x04006B95 RID: 27541
		public const int SelectFighterUIdFieldNumber = 3;

		// Token: 0x04006B96 RID: 27542
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006B97 RID: 27543
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x04006B98 RID: 27544
		public const int PhantomBattleEffectResultInfoFieldNumber = 4;

		// Token: 0x04006B99 RID: 27545
		private PhantomBattleEffectResultInfo phantomBattleEffectResultInfo_;
	}
}
