using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000350 RID: 848
	public sealed class DangoBrawlFightActionBuffChangeInfo : IMessage<DangoBrawlFightActionBuffChangeInfo>, IMessage, IEquatable<DangoBrawlFightActionBuffChangeInfo>, IDeepCloneable<DangoBrawlFightActionBuffChangeInfo>, IBufferMessage
	{
		// Token: 0x060054F0 RID: 21744 RVA: 0x000CF145 File Offset: 0x000CD345
		[NullableContext(1)]
		public static DangoBrawlFightActionBuffChangeInfo Create()
		{
			return new DangoBrawlFightActionBuffChangeInfo();
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x000CF14C File Offset: 0x000CD34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x060054F2 RID: 21746 RVA: 0x000CF14F File Offset: 0x000CD34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionBuffChangeInfo.Descriptor;
			}
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x000CF156 File Offset: 0x000CD356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffChangeInfo()
		{
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x000CF160 File Offset: 0x000CD360
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

		// Token: 0x060054F5 RID: 21749 RVA: 0x000CF1E4 File Offset: 0x000CD3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffChangeInfo Clone()
		{
			return new DangoBrawlFightActionBuffChangeInfo(this);
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x060054F6 RID: 21750 RVA: 0x000CF1EC File Offset: 0x000CD3EC
		// (set) Token: 0x060054F7 RID: 21751 RVA: 0x000CF1F4 File Offset: 0x000CD3F4
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

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x060054F8 RID: 21752 RVA: 0x000CF1FD File Offset: 0x000CD3FD
		// (set) Token: 0x060054F9 RID: 21753 RVA: 0x000CF205 File Offset: 0x000CD405
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

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x060054FA RID: 21754 RVA: 0x000CF20E File Offset: 0x000CD40E
		// (set) Token: 0x060054FB RID: 21755 RVA: 0x000CF216 File Offset: 0x000CD416
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

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x060054FC RID: 21756 RVA: 0x000CF21F File Offset: 0x000CD41F
		// (set) Token: 0x060054FD RID: 21757 RVA: 0x000CF227 File Offset: 0x000CD427
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

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x060054FE RID: 21758 RVA: 0x000CF230 File Offset: 0x000CD430
		// (set) Token: 0x060054FF RID: 21759 RVA: 0x000CF238 File Offset: 0x000CD438
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

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06005500 RID: 21760 RVA: 0x000CF241 File Offset: 0x000CD441
		// (set) Token: 0x06005501 RID: 21761 RVA: 0x000CF249 File Offset: 0x000CD449
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

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06005502 RID: 21762 RVA: 0x000CF252 File Offset: 0x000CD452
		// (set) Token: 0x06005503 RID: 21763 RVA: 0x000CF25A File Offset: 0x000CD45A
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

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06005504 RID: 21764 RVA: 0x000CF263 File Offset: 0x000CD463
		// (set) Token: 0x06005505 RID: 21765 RVA: 0x000CF26B File Offset: 0x000CD46B
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

		// Token: 0x06005506 RID: 21766 RVA: 0x000CF274 File Offset: 0x000CD474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionBuffChangeInfo);
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x000CF284 File Offset: 0x000CD484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionBuffChangeInfo other)
		{
			return other != null && (other == this || (this.BuffUId == other.BuffUId && this.SourceFighterUId == other.SourceFighterUId && this.TargetFighterUId == other.TargetFighterUId && this.BuffConfigId == other.BuffConfigId && this.Stack == other.Stack && this.RemainingMs == other.RemainingMs && this.SourceItemUId == other.SourceItemUId && this.NextReadyMs == other.NextReadyMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x000CF330 File Offset: 0x000CD530
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

		// Token: 0x06005509 RID: 21769 RVA: 0x000CF41E File Offset: 0x000CD61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x000CF42B File Offset: 0x000CD62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x000CF434 File Offset: 0x000CD634
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

		// Token: 0x0600550C RID: 21772 RVA: 0x000CF534 File Offset: 0x000CD734
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

		// Token: 0x0600550D RID: 21773 RVA: 0x000CF61C File Offset: 0x000CD81C
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

		// Token: 0x0600550E RID: 21774 RVA: 0x000CF6E4 File Offset: 0x000CD8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x000CF6F0 File Offset: 0x000CD8F0
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

		// Token: 0x04003440 RID: 13376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003441 RID: 13377
		public const int BuffUIdFieldNumber = 1;

		// Token: 0x04003442 RID: 13378
		private int buffUId_;

		// Token: 0x04003443 RID: 13379
		public const int SourceFighterUIdFieldNumber = 2;

		// Token: 0x04003444 RID: 13380
		private int sourceFighterUId_;

		// Token: 0x04003445 RID: 13381
		public const int TargetFighterUIdFieldNumber = 3;

		// Token: 0x04003446 RID: 13382
		private int targetFighterUId_;

		// Token: 0x04003447 RID: 13383
		public const int BuffConfigIdFieldNumber = 4;

		// Token: 0x04003448 RID: 13384
		private int buffConfigId_;

		// Token: 0x04003449 RID: 13385
		public const int StackFieldNumber = 5;

		// Token: 0x0400344A RID: 13386
		private int stack_;

		// Token: 0x0400344B RID: 13387
		public const int RemainingMsFieldNumber = 6;

		// Token: 0x0400344C RID: 13388
		private int remainingMs_;

		// Token: 0x0400344D RID: 13389
		public const int SourceItemUIdFieldNumber = 7;

		// Token: 0x0400344E RID: 13390
		private int sourceItemUId_;

		// Token: 0x0400344F RID: 13391
		public const int NextReadyMsFieldNumber = 8;

		// Token: 0x04003450 RID: 13392
		private int nextReadyMs_;
	}
}
