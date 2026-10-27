using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E5 RID: 2533
	public sealed class ModeInfo : IMessage<ModeInfo>, IMessage, IEquatable<ModeInfo>, IDeepCloneable<ModeInfo>, IBufferMessage
	{
		// Token: 0x0600DDF1 RID: 56817 RVA: 0x00208D55 File Offset: 0x00206F55
		[NullableContext(1)]
		public static ModeInfo Create()
		{
			return new ModeInfo();
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x0600DDF2 RID: 56818 RVA: 0x00208D5C File Offset: 0x00206F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x0600DDF3 RID: 56819 RVA: 0x00208D5F File Offset: 0x00206F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModeInfo.Descriptor;
			}
		}

		// Token: 0x0600DDF4 RID: 56820 RVA: 0x00208D66 File Offset: 0x00206F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModeInfo()
		{
		}

		// Token: 0x0600DDF5 RID: 56821 RVA: 0x00208D70 File Offset: 0x00206F70
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

		// Token: 0x0600DDF6 RID: 56822 RVA: 0x00208DD0 File Offset: 0x00206FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModeInfo Clone()
		{
			return new ModeInfo(this);
		}

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x0600DDF7 RID: 56823 RVA: 0x00208DD8 File Offset: 0x00206FD8
		// (set) Token: 0x0600DDF8 RID: 56824 RVA: 0x00208DE0 File Offset: 0x00206FE0
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

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x0600DDF9 RID: 56825 RVA: 0x00208DE9 File Offset: 0x00206FE9
		// (set) Token: 0x0600DDFA RID: 56826 RVA: 0x00208DF1 File Offset: 0x00206FF1
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

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x0600DDFB RID: 56827 RVA: 0x00208DFA File Offset: 0x00206FFA
		// (set) Token: 0x0600DDFC RID: 56828 RVA: 0x00208E02 File Offset: 0x00207002
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

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x0600DDFD RID: 56829 RVA: 0x00208E0B File Offset: 0x0020700B
		// (set) Token: 0x0600DDFE RID: 56830 RVA: 0x00208E13 File Offset: 0x00207013
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

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x0600DDFF RID: 56831 RVA: 0x00208E1C File Offset: 0x0020701C
		// (set) Token: 0x0600DE00 RID: 56832 RVA: 0x00208E24 File Offset: 0x00207024
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

		// Token: 0x0600DE01 RID: 56833 RVA: 0x00208E2D File Offset: 0x0020702D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModeInfo);
		}

		// Token: 0x0600DE02 RID: 56834 RVA: 0x00208E3C File Offset: 0x0020703C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModeInfo other)
		{
			return other != null && (other == this || (this.IsUnlock == other.IsUnlock && this.ConditionGroupId == other.ConditionGroupId && this.WaveId == other.WaveId && this.KillMonsterCount == other.KillMonsterCount && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE03 RID: 56835 RVA: 0x00208EB8 File Offset: 0x002070B8
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

		// Token: 0x0600DE04 RID: 56836 RVA: 0x00208F5B File Offset: 0x0020715B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE05 RID: 56837 RVA: 0x00208F68 File Offset: 0x00207168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE06 RID: 56838 RVA: 0x00208F74 File Offset: 0x00207174
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

		// Token: 0x0600DE07 RID: 56839 RVA: 0x00209020 File Offset: 0x00207220
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

		// Token: 0x0600DE08 RID: 56840 RVA: 0x002090A8 File Offset: 0x002072A8
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

		// Token: 0x0600DE09 RID: 56841 RVA: 0x00209134 File Offset: 0x00207334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE0A RID: 56842 RVA: 0x00209140 File Offset: 0x00207340
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

		// Token: 0x04005BB5 RID: 23477
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BB6 RID: 23478
		public const int IsUnlockFieldNumber = 1;

		// Token: 0x04005BB7 RID: 23479
		private bool isUnlock_;

		// Token: 0x04005BB8 RID: 23480
		public const int ConditionGroupIdFieldNumber = 2;

		// Token: 0x04005BB9 RID: 23481
		private int conditionGroupId_;

		// Token: 0x04005BBA RID: 23482
		public const int WaveIdFieldNumber = 3;

		// Token: 0x04005BBB RID: 23483
		private int waveId_;

		// Token: 0x04005BBC RID: 23484
		public const int KillMonsterCountFieldNumber = 4;

		// Token: 0x04005BBD RID: 23485
		private int killMonsterCount_;

		// Token: 0x04005BBE RID: 23486
		public const int IsFinishFieldNumber = 5;

		// Token: 0x04005BBF RID: 23487
		private bool isFinish_;
	}
}
