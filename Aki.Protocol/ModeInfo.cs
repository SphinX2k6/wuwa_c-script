using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D4 RID: 2516
	public sealed class ModeInfo : IMessage<ModeInfo>, IMessage, IEquatable<ModeInfo>, IDeepCloneable<ModeInfo>, IBufferMessage
	{
		// Token: 0x0600DCD7 RID: 56535 RVA: 0x00206B69 File Offset: 0x00204D69
		[NullableContext(1)]
		public static ModeInfo Create()
		{
			return new ModeInfo();
		}

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x0600DCD8 RID: 56536 RVA: 0x00206B70 File Offset: 0x00204D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x0600DCD9 RID: 56537 RVA: 0x00206B73 File Offset: 0x00204D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModeInfo.Descriptor;
			}
		}

		// Token: 0x0600DCDA RID: 56538 RVA: 0x00206B7A File Offset: 0x00204D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModeInfo()
		{
		}

		// Token: 0x0600DCDB RID: 56539 RVA: 0x00206B84 File Offset: 0x00204D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModeInfo(ModeInfo other) : this()
		{
			this.isUnlock_ = other.isUnlock_;
			this.conditionGroupId_ = other.conditionGroupId_;
			this.waveId_ = other.waveId_;
			this.killMonsterCount_ = other.killMonsterCount_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCDC RID: 56540 RVA: 0x00206BE4 File Offset: 0x00204DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModeInfo Clone()
		{
			return new ModeInfo(this);
		}

		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x0600DCDD RID: 56541 RVA: 0x00206BEC File Offset: 0x00204DEC
		// (set) Token: 0x0600DCDE RID: 56542 RVA: 0x00206BF4 File Offset: 0x00204DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x0600DCDF RID: 56543 RVA: 0x00206BFD File Offset: 0x00204DFD
		// (set) Token: 0x0600DCE0 RID: 56544 RVA: 0x00206C05 File Offset: 0x00204E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionGroupId
		{
			get
			{
				return this.conditionGroupId_;
			}
			set
			{
				this.conditionGroupId_ = value;
			}
		}

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x0600DCE1 RID: 56545 RVA: 0x00206C0E File Offset: 0x00204E0E
		// (set) Token: 0x0600DCE2 RID: 56546 RVA: 0x00206C16 File Offset: 0x00204E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveId
		{
			get
			{
				return this.waveId_;
			}
			set
			{
				this.waveId_ = value;
			}
		}

		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x0600DCE3 RID: 56547 RVA: 0x00206C1F File Offset: 0x00204E1F
		// (set) Token: 0x0600DCE4 RID: 56548 RVA: 0x00206C27 File Offset: 0x00204E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KillMonsterCount
		{
			get
			{
				return this.killMonsterCount_;
			}
			set
			{
				this.killMonsterCount_ = value;
			}
		}

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x0600DCE5 RID: 56549 RVA: 0x00206C30 File Offset: 0x00204E30
		// (set) Token: 0x0600DCE6 RID: 56550 RVA: 0x00206C38 File Offset: 0x00204E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x0600DCE7 RID: 56551 RVA: 0x00206C41 File Offset: 0x00204E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModeInfo);
		}

		// Token: 0x0600DCE8 RID: 56552 RVA: 0x00206C50 File Offset: 0x00204E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModeInfo other)
		{
			return other != null && (other == this || (this.IsUnlock == other.IsUnlock && this.ConditionGroupId == other.ConditionGroupId && this.WaveId == other.WaveId && this.KillMonsterCount == other.KillMonsterCount && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCE9 RID: 56553 RVA: 0x00206CCC File Offset: 0x00204ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.ConditionGroupId != 0)
			{
				num ^= this.ConditionGroupId.GetHashCode();
			}
			if (this.WaveId != 0)
			{
				num ^= this.WaveId.GetHashCode();
			}
			if (this.KillMonsterCount != 0)
			{
				num ^= this.KillMonsterCount.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DCEA RID: 56554 RVA: 0x00206D6F File Offset: 0x00204F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DCEB RID: 56555 RVA: 0x00206D7C File Offset: 0x00204F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCEC RID: 56556 RVA: 0x00206D88 File Offset: 0x00204F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsUnlock)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsUnlock);
			}
			if (this.ConditionGroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConditionGroupId);
			}
			if (this.WaveId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WaveId);
			}
			if (this.KillMonsterCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.KillMonsterCount);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCED RID: 56557 RVA: 0x00206E34 File Offset: 0x00205034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.ConditionGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionGroupId);
			}
			if (this.WaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveId);
			}
			if (this.KillMonsterCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KillMonsterCount);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DCEE RID: 56558 RVA: 0x00206EBC File Offset: 0x002050BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.ConditionGroupId != 0)
			{
				this.ConditionGroupId = other.ConditionGroupId;
			}
			if (other.WaveId != 0)
			{
				this.WaveId = other.WaveId;
			}
			if (other.KillMonsterCount != 0)
			{
				this.KillMonsterCount = other.KillMonsterCount;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCEF RID: 56559 RVA: 0x00206F48 File Offset: 0x00205148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCF0 RID: 56560 RVA: 0x00206F54 File Offset: 0x00205154
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
						this.IsUnlock = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.ConditionGroupId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.WaveId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.KillMonsterCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.IsFinish = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005BBE RID: 23486
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BBF RID: 23487
		public const int IsUnlockFieldNumber = 1;

		// Token: 0x04005BC0 RID: 23488
		private bool isUnlock_;

		// Token: 0x04005BC1 RID: 23489
		public const int ConditionGroupIdFieldNumber = 2;

		// Token: 0x04005BC2 RID: 23490
		private int conditionGroupId_;

		// Token: 0x04005BC3 RID: 23491
		public const int WaveIdFieldNumber = 3;

		// Token: 0x04005BC4 RID: 23492
		private int waveId_;

		// Token: 0x04005BC5 RID: 23493
		public const int KillMonsterCountFieldNumber = 4;

		// Token: 0x04005BC6 RID: 23494
		private int killMonsterCount_;

		// Token: 0x04005BC7 RID: 23495
		public const int IsFinishFieldNumber = 5;

		// Token: 0x04005BC8 RID: 23496
		private bool isFinish_;
	}
}
