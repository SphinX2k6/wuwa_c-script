using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001110 RID: 4368
	public sealed class RoverRogueLootInfo : IMessage<RoverRogueLootInfo>, IMessage, IEquatable<RoverRogueLootInfo>, IDeepCloneable<RoverRogueLootInfo>, IBufferMessage
	{
		// Token: 0x060174C0 RID: 95424 RVA: 0x00361F3A File Offset: 0x0036013A
		[NullableContext(1)]
		public static RoverRogueLootInfo Create()
		{
			return new RoverRogueLootInfo();
		}

		// Token: 0x17004E21 RID: 20001
		// (get) Token: 0x060174C1 RID: 95425 RVA: 0x00361F41 File Offset: 0x00360141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E22 RID: 20002
		// (get) Token: 0x060174C2 RID: 95426 RVA: 0x00361F44 File Offset: 0x00360144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootInfo.Descriptor;
			}
		}

		// Token: 0x060174C3 RID: 95427 RVA: 0x00361F4B File Offset: 0x0036014B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfo()
		{
		}

		// Token: 0x060174C4 RID: 95428 RVA: 0x00361F54 File Offset: 0x00360154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfo(RoverRogueLootInfo other) : this()
		{
			this.lootRoomPassedCounter_ = other.lootRoomPassedCounter_;
			this.lootLv_ = other.lootLv_;
			this.unlock_ = other.unlock_;
			this.progress_ = other.progress_;
			this.target_ = other.target_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060174C5 RID: 95429 RVA: 0x00361FB4 File Offset: 0x003601B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfo Clone()
		{
			return new RoverRogueLootInfo(this);
		}

		// Token: 0x17004E23 RID: 20003
		// (get) Token: 0x060174C6 RID: 95430 RVA: 0x00361FBC File Offset: 0x003601BC
		// (set) Token: 0x060174C7 RID: 95431 RVA: 0x00361FC4 File Offset: 0x003601C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LootRoomPassedCounter
		{
			get
			{
				return this.lootRoomPassedCounter_;
			}
			set
			{
				this.lootRoomPassedCounter_ = value;
			}
		}

		// Token: 0x17004E24 RID: 20004
		// (get) Token: 0x060174C8 RID: 95432 RVA: 0x00361FCD File Offset: 0x003601CD
		// (set) Token: 0x060174C9 RID: 95433 RVA: 0x00361FD5 File Offset: 0x003601D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LootLv
		{
			get
			{
				return this.lootLv_;
			}
			set
			{
				this.lootLv_ = value;
			}
		}

		// Token: 0x17004E25 RID: 20005
		// (get) Token: 0x060174CA RID: 95434 RVA: 0x00361FDE File Offset: 0x003601DE
		// (set) Token: 0x060174CB RID: 95435 RVA: 0x00361FE6 File Offset: 0x003601E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x17004E26 RID: 20006
		// (get) Token: 0x060174CC RID: 95436 RVA: 0x00361FEF File Offset: 0x003601EF
		// (set) Token: 0x060174CD RID: 95437 RVA: 0x00361FF7 File Offset: 0x003601F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x17004E27 RID: 20007
		// (get) Token: 0x060174CE RID: 95438 RVA: 0x00362000 File Offset: 0x00360200
		// (set) Token: 0x060174CF RID: 95439 RVA: 0x00362008 File Offset: 0x00360208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x060174D0 RID: 95440 RVA: 0x00362011 File Offset: 0x00360211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootInfo);
		}

		// Token: 0x060174D1 RID: 95441 RVA: 0x00362020 File Offset: 0x00360220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootInfo other)
		{
			return other != null && (other == this || (this.LootRoomPassedCounter == other.LootRoomPassedCounter && this.LootLv == other.LootLv && this.Unlock == other.Unlock && this.Progress == other.Progress && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060174D2 RID: 95442 RVA: 0x0036209C File Offset: 0x0036029C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LootRoomPassedCounter != 0)
			{
				num ^= this.LootRoomPassedCounter.GetHashCode();
			}
			if (this.LootLv != 0)
			{
				num ^= this.LootLv.GetHashCode();
			}
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			if (this.Progress != 0)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060174D3 RID: 95443 RVA: 0x0036213F File Offset: 0x0036033F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060174D4 RID: 95444 RVA: 0x0036214C File Offset: 0x0036034C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060174D5 RID: 95445 RVA: 0x00362158 File Offset: 0x00360358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LootRoomPassedCounter != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LootRoomPassedCounter);
			}
			if (this.LootLv != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LootLv);
			}
			if (this.Unlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Unlock);
			}
			if (this.Progress != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Progress);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Target);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060174D6 RID: 95446 RVA: 0x00362204 File Offset: 0x00360404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LootRoomPassedCounter != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LootRoomPassedCounter);
			}
			if (this.LootLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LootLv);
			}
			if (this.Unlock)
			{
				num += 2;
			}
			if (this.Progress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Progress);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060174D7 RID: 95447 RVA: 0x00362298 File Offset: 0x00360498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueLootInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LootRoomPassedCounter != 0)
			{
				this.LootRoomPassedCounter = other.LootRoomPassedCounter;
			}
			if (other.LootLv != 0)
			{
				this.LootLv = other.LootLv;
			}
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			if (other.Progress != 0)
			{
				this.Progress = other.Progress;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060174D8 RID: 95448 RVA: 0x00362324 File Offset: 0x00360524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060174D9 RID: 95449 RVA: 0x00362330 File Offset: 0x00360530
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
						this.LootRoomPassedCounter = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LootLv = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Unlock = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.Progress = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008A93 RID: 35475
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A94 RID: 35476
		public const int LootRoomPassedCounterFieldNumber = 1;

		// Token: 0x04008A95 RID: 35477
		private int lootRoomPassedCounter_;

		// Token: 0x04008A96 RID: 35478
		public const int LootLvFieldNumber = 2;

		// Token: 0x04008A97 RID: 35479
		private int lootLv_;

		// Token: 0x04008A98 RID: 35480
		public const int UnlockFieldNumber = 3;

		// Token: 0x04008A99 RID: 35481
		private bool unlock_;

		// Token: 0x04008A9A RID: 35482
		public const int ProgressFieldNumber = 4;

		// Token: 0x04008A9B RID: 35483
		private int progress_;

		// Token: 0x04008A9C RID: 35484
		public const int TargetFieldNumber = 5;

		// Token: 0x04008A9D RID: 35485
		private int target_;
	}
}
