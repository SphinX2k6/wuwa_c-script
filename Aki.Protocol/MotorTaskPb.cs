using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A95 RID: 2709
	public sealed class MotorTaskPb : IMessage<MotorTaskPb>, IMessage, IEquatable<MotorTaskPb>, IDeepCloneable<MotorTaskPb>, IBufferMessage
	{
		// Token: 0x0600EC2D RID: 60461 RVA: 0x00227FFD File Offset: 0x002261FD
		[NullableContext(1)]
		public static MotorTaskPb Create()
		{
			return new MotorTaskPb();
		}

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x0600EC2E RID: 60462 RVA: 0x00228004 File Offset: 0x00226204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorTaskPb> Parser
		{
			get
			{
				return MotorTaskPb._parser;
			}
		}

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x0600EC2F RID: 60463 RVA: 0x0022800B File Offset: 0x0022620B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x0600EC30 RID: 60464 RVA: 0x0022800E File Offset: 0x0022620E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskPb.Descriptor;
			}
		}

		// Token: 0x0600EC31 RID: 60465 RVA: 0x00228015 File Offset: 0x00226215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskPb()
		{
		}

		// Token: 0x0600EC32 RID: 60466 RVA: 0x00228020 File Offset: 0x00226220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskPb(MotorTaskPb other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.process_ = ((other.process_ != null) ? other.process_.Clone() : null);
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.endTime_ = other.endTime_;
			this.startTime_ = other.startTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC33 RID: 60467 RVA: 0x002280AC File Offset: 0x002262AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskPb Clone()
		{
			return new MotorTaskPb(this);
		}

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x0600EC34 RID: 60468 RVA: 0x002280B4 File Offset: 0x002262B4
		// (set) Token: 0x0600EC35 RID: 60469 RVA: 0x002280BC File Offset: 0x002262BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x0600EC36 RID: 60470 RVA: 0x002280C5 File Offset: 0x002262C5
		// (set) Token: 0x0600EC37 RID: 60471 RVA: 0x002280CD File Offset: 0x002262CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskTypePb Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x0600EC38 RID: 60472 RVA: 0x002280D6 File Offset: 0x002262D6
		// (set) Token: 0x0600EC39 RID: 60473 RVA: 0x002280DE File Offset: 0x002262DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskProcessPb Process
		{
			get
			{
				return this.process_;
			}
			set
			{
				this.process_ = value;
			}
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x0600EC3A RID: 60474 RVA: 0x002280E7 File Offset: 0x002262E7
		// (set) Token: 0x0600EC3B RID: 60475 RVA: 0x002280EF File Offset: 0x002262EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskRewardPb Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x0600EC3C RID: 60476 RVA: 0x002280F8 File Offset: 0x002262F8
		// (set) Token: 0x0600EC3D RID: 60477 RVA: 0x00228100 File Offset: 0x00226300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x0600EC3E RID: 60478 RVA: 0x00228109 File Offset: 0x00226309
		// (set) Token: 0x0600EC3F RID: 60479 RVA: 0x00228111 File Offset: 0x00226311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		// Token: 0x0600EC40 RID: 60480 RVA: 0x0022811A File Offset: 0x0022631A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskPb);
		}

		// Token: 0x0600EC41 RID: 60481 RVA: 0x00228128 File Offset: 0x00226328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && object.Equals(this.Process, other.Process) && object.Equals(this.Reward, other.Reward) && this.EndTime == other.EndTime && this.StartTime == other.StartTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC42 RID: 60482 RVA: 0x002281BC File Offset: 0x002263BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != MotorTaskTypePb.Unknown)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.process_ != null)
			{
				num ^= this.Process.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EC43 RID: 60483 RVA: 0x00228278 File Offset: 0x00226478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC44 RID: 60484 RVA: 0x00228285 File Offset: 0x00226485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC45 RID: 60485 RVA: 0x00228290 File Offset: 0x00226490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Type != MotorTaskTypePb.Unknown)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.process_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Process);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Reward);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EndTime);
			}
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.StartTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EC46 RID: 60486 RVA: 0x00228358 File Offset: 0x00226558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Type != MotorTaskTypePb.Unknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.process_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Process);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EC47 RID: 60487 RVA: 0x00228410 File Offset: 0x00226610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != MotorTaskTypePb.Unknown)
			{
				this.Type = other.Type;
			}
			if (other.process_ != null)
			{
				if (this.process_ == null)
				{
					this.Process = new MotorTaskProcessPb();
				}
				this.Process.MergeFrom(other.Process);
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new MotorTaskRewardPb();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EC48 RID: 60488 RVA: 0x002284E0 File Offset: 0x002266E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC49 RID: 60489 RVA: 0x002284EC File Offset: 0x002266EC
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Type = (MotorTaskTypePb)input.ReadEnum();
						continue;
					}
					if (num == 26U)
					{
						if (this.process_ == null)
						{
							this.Process = new MotorTaskProcessPb();
						}
						input.ReadMessage(this.Process);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new MotorTaskRewardPb();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 40U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.StartTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006023 RID: 24611
		private static readonly MessageParser<MotorTaskPb> _parser = new MessageParser<MotorTaskPb>(() => new MotorTaskPb());

		// Token: 0x04006024 RID: 24612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006025 RID: 24613
		public const int IdFieldNumber = 1;

		// Token: 0x04006026 RID: 24614
		private int id_;

		// Token: 0x04006027 RID: 24615
		public const int TypeFieldNumber = 2;

		// Token: 0x04006028 RID: 24616
		private MotorTaskTypePb type_;

		// Token: 0x04006029 RID: 24617
		public const int ProcessFieldNumber = 3;

		// Token: 0x0400602A RID: 24618
		private MotorTaskProcessPb process_;

		// Token: 0x0400602B RID: 24619
		public const int RewardFieldNumber = 4;

		// Token: 0x0400602C RID: 24620
		private MotorTaskRewardPb reward_;

		// Token: 0x0400602D RID: 24621
		public const int EndTimeFieldNumber = 5;

		// Token: 0x0400602E RID: 24622
		private long endTime_;

		// Token: 0x0400602F RID: 24623
		public const int StartTimeFieldNumber = 6;

		// Token: 0x04006030 RID: 24624
		private long startTime_;
	}
}
