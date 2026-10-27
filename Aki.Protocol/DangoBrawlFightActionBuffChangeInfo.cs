using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000348 RID: 840
	public sealed class DangoBrawlFightActionBuffChangeInfo : IMessage<DangoBrawlFightActionBuffChangeInfo>, IMessage, IEquatable<DangoBrawlFightActionBuffChangeInfo>, IDeepCloneable<DangoBrawlFightActionBuffChangeInfo>, IBufferMessage
	{
		// Token: 0x06005403 RID: 21507 RVA: 0x000CCAB9 File Offset: 0x000CACB9
		[NullableContext(1)]
		public static DangoBrawlFightActionBuffChangeInfo Create()
		{
			return new DangoBrawlFightActionBuffChangeInfo();
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06005404 RID: 21508 RVA: 0x000CCAC0 File Offset: 0x000CACC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06005405 RID: 21509 RVA: 0x000CCAC3 File Offset: 0x000CACC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionBuffChangeInfo.Descriptor;
			}
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x000CCACA File Offset: 0x000CACCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffChangeInfo()
		{
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x000CCAD4 File Offset: 0x000CACD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffChangeInfo(DangoBrawlFightActionBuffChangeInfo other) : this()
		{
			this.buffUId_ = other.buffUId_;
			this.sourceFighterUId_ = other.sourceFighterUId_;
			this.targetFighterUId_ = other.targetFighterUId_;
			this.buffConfigId_ = other.buffConfigId_;
			this.stack_ = other.stack_;
			this.remainingMs_ = other.remainingMs_;
			this.sourceItemUId_ = other.sourceItemUId_;
			this.nextReadyMs_ = other.nextReadyMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x000CCB58 File Offset: 0x000CAD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffChangeInfo Clone()
		{
			return new DangoBrawlFightActionBuffChangeInfo(this);
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06005409 RID: 21513 RVA: 0x000CCB60 File Offset: 0x000CAD60
		// (set) Token: 0x0600540A RID: 21514 RVA: 0x000CCB68 File Offset: 0x000CAD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffUId
		{
			get
			{
				return this.buffUId_;
			}
			set
			{
				this.buffUId_ = value;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x0600540B RID: 21515 RVA: 0x000CCB71 File Offset: 0x000CAD71
		// (set) Token: 0x0600540C RID: 21516 RVA: 0x000CCB79 File Offset: 0x000CAD79
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

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x0600540D RID: 21517 RVA: 0x000CCB82 File Offset: 0x000CAD82
		// (set) Token: 0x0600540E RID: 21518 RVA: 0x000CCB8A File Offset: 0x000CAD8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x0600540F RID: 21519 RVA: 0x000CCB93 File Offset: 0x000CAD93
		// (set) Token: 0x06005410 RID: 21520 RVA: 0x000CCB9B File Offset: 0x000CAD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffConfigId
		{
			get
			{
				return this.buffConfigId_;
			}
			set
			{
				this.buffConfigId_ = value;
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06005411 RID: 21521 RVA: 0x000CCBA4 File Offset: 0x000CADA4
		// (set) Token: 0x06005412 RID: 21522 RVA: 0x000CCBAC File Offset: 0x000CADAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Stack
		{
			get
			{
				return this.stack_;
			}
			set
			{
				this.stack_ = value;
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06005413 RID: 21523 RVA: 0x000CCBB5 File Offset: 0x000CADB5
		// (set) Token: 0x06005414 RID: 21524 RVA: 0x000CCBBD File Offset: 0x000CADBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainingMs
		{
			get
			{
				return this.remainingMs_;
			}
			set
			{
				this.remainingMs_ = value;
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06005415 RID: 21525 RVA: 0x000CCBC6 File Offset: 0x000CADC6
		// (set) Token: 0x06005416 RID: 21526 RVA: 0x000CCBCE File Offset: 0x000CADCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceItemUId
		{
			get
			{
				return this.sourceItemUId_;
			}
			set
			{
				this.sourceItemUId_ = value;
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06005417 RID: 21527 RVA: 0x000CCBD7 File Offset: 0x000CADD7
		// (set) Token: 0x06005418 RID: 21528 RVA: 0x000CCBDF File Offset: 0x000CADDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NextReadyMs
		{
			get
			{
				return this.nextReadyMs_;
			}
			set
			{
				this.nextReadyMs_ = value;
			}
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x000CCBE8 File Offset: 0x000CADE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionBuffChangeInfo);
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x000CCBF8 File Offset: 0x000CADF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionBuffChangeInfo other)
		{
			return other != null && (other == this || (this.BuffUId == other.BuffUId && this.SourceFighterUId == other.SourceFighterUId && this.TargetFighterUId == other.TargetFighterUId && this.BuffConfigId == other.BuffConfigId && this.Stack == other.Stack && this.RemainingMs == other.RemainingMs && this.SourceItemUId == other.SourceItemUId && this.NextReadyMs == other.NextReadyMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x000CCCA4 File Offset: 0x000CAEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffUId != 0)
			{
				num ^= this.BuffUId.GetHashCode();
			}
			if (this.SourceFighterUId != 0)
			{
				num ^= this.SourceFighterUId.GetHashCode();
			}
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			if (this.BuffConfigId != 0)
			{
				num ^= this.BuffConfigId.GetHashCode();
			}
			if (this.Stack != 0)
			{
				num ^= this.Stack.GetHashCode();
			}
			if (this.RemainingMs != 0)
			{
				num ^= this.RemainingMs.GetHashCode();
			}
			if (this.SourceItemUId != 0)
			{
				num ^= this.SourceItemUId.GetHashCode();
			}
			if (this.NextReadyMs != 0)
			{
				num ^= this.NextReadyMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x000CCD92 File Offset: 0x000CAF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x000CCD9F File Offset: 0x000CAF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x000CCDA8 File Offset: 0x000CAFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffUId);
			}
			if (this.SourceFighterUId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SourceFighterUId);
			}
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetFighterUId);
			}
			if (this.BuffConfigId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BuffConfigId);
			}
			if (this.Stack != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Stack);
			}
			if (this.RemainingMs != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RemainingMs);
			}
			if (this.SourceItemUId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SourceItemUId);
			}
			if (this.NextReadyMs != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.NextReadyMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x000CCEA8 File Offset: 0x000CB0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffUId);
			}
			if (this.SourceFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceFighterUId);
			}
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			if (this.BuffConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffConfigId);
			}
			if (this.Stack != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Stack);
			}
			if (this.RemainingMs != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainingMs);
			}
			if (this.SourceItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceItemUId);
			}
			if (this.NextReadyMs != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NextReadyMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x000CCF90 File Offset: 0x000CB190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionBuffChangeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffUId != 0)
			{
				this.BuffUId = other.BuffUId;
			}
			if (other.SourceFighterUId != 0)
			{
				this.SourceFighterUId = other.SourceFighterUId;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			if (other.BuffConfigId != 0)
			{
				this.BuffConfigId = other.BuffConfigId;
			}
			if (other.Stack != 0)
			{
				this.Stack = other.Stack;
			}
			if (other.RemainingMs != 0)
			{
				this.RemainingMs = other.RemainingMs;
			}
			if (other.SourceItemUId != 0)
			{
				this.SourceItemUId = other.SourceItemUId;
			}
			if (other.NextReadyMs != 0)
			{
				this.NextReadyMs = other.NextReadyMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x000CD058 File Offset: 0x000CB258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x000CD064 File Offset: 0x000CB264
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
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.BuffUId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.SourceFighterUId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.TargetFighterUId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.BuffConfigId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.Stack = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.RemainingMs = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.SourceItemUId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.NextReadyMs = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040033A4 RID: 13220
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033A5 RID: 13221
		public const int BuffUIdFieldNumber = 1;

		// Token: 0x040033A6 RID: 13222
		private int buffUId_;

		// Token: 0x040033A7 RID: 13223
		public const int SourceFighterUIdFieldNumber = 2;

		// Token: 0x040033A8 RID: 13224
		private int sourceFighterUId_;

		// Token: 0x040033A9 RID: 13225
		public const int TargetFighterUIdFieldNumber = 3;

		// Token: 0x040033AA RID: 13226
		private int targetFighterUId_;

		// Token: 0x040033AB RID: 13227
		public const int BuffConfigIdFieldNumber = 4;

		// Token: 0x040033AC RID: 13228
		private int buffConfigId_;

		// Token: 0x040033AD RID: 13229
		public const int StackFieldNumber = 5;

		// Token: 0x040033AE RID: 13230
		private int stack_;

		// Token: 0x040033AF RID: 13231
		public const int RemainingMsFieldNumber = 6;

		// Token: 0x040033B0 RID: 13232
		private int remainingMs_;

		// Token: 0x040033B1 RID: 13233
		public const int SourceItemUIdFieldNumber = 7;

		// Token: 0x040033B2 RID: 13234
		private int sourceItemUId_;

		// Token: 0x040033B3 RID: 13235
		public const int NextReadyMsFieldNumber = 8;

		// Token: 0x040033B4 RID: 13236
		private int nextReadyMs_;
	}
}
