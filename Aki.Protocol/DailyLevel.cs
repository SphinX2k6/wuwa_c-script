using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000323 RID: 803
	public sealed class DailyLevel : IMessage<DailyLevel>, IMessage, IEquatable<DailyLevel>, IDeepCloneable<DailyLevel>, IBufferMessage
	{
		// Token: 0x060050BE RID: 20670 RVA: 0x000C4B00 File Offset: 0x000C2D00
		[NullableContext(1)]
		public static DailyLevel Create()
		{
			return new DailyLevel();
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x060050BF RID: 20671 RVA: 0x000C4B07 File Offset: 0x000C2D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x060050C0 RID: 20672 RVA: 0x000C4B0A File Offset: 0x000C2D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyLevel.Descriptor;
			}
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x000C4B11 File Offset: 0x000C2D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyLevel()
		{
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x000C4B19 File Offset: 0x000C2D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyLevel(DailyLevel other) : this()
		{
			this.randomLevelId_ = other.randomLevelId_;
			this.reward_ = other.reward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x000C4B4A File Offset: 0x000C2D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyLevel Clone()
		{
			return new DailyLevel(this);
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x060050C4 RID: 20676 RVA: 0x000C4B52 File Offset: 0x000C2D52
		// (set) Token: 0x060050C5 RID: 20677 RVA: 0x000C4B5A File Offset: 0x000C2D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RandomLevelId
		{
			get
			{
				return this.randomLevelId_;
			}
			set
			{
				this.randomLevelId_ = value;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x060050C6 RID: 20678 RVA: 0x000C4B63 File Offset: 0x000C2D63
		// (set) Token: 0x060050C7 RID: 20679 RVA: 0x000C4B6B File Offset: 0x000C2D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Reward
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

		// Token: 0x060050C8 RID: 20680 RVA: 0x000C4B74 File Offset: 0x000C2D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyLevel);
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x000C4B82 File Offset: 0x000C2D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyLevel other)
		{
			return other != null && (other == this || (this.RandomLevelId == other.RandomLevelId && this.Reward == other.Reward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x000C4BC0 File Offset: 0x000C2DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RandomLevelId != 0)
			{
				num ^= this.RandomLevelId.GetHashCode();
			}
			if (this.Reward)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060050CB RID: 20683 RVA: 0x000C4C18 File Offset: 0x000C2E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x000C4C25 File Offset: 0x000C2E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x000C4C30 File Offset: 0x000C2E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RandomLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RandomLevelId);
			}
			if (this.Reward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x000C4C88 File Offset: 0x000C2E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RandomLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RandomLevelId);
			}
			if (this.Reward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x000C4CD4 File Offset: 0x000C2ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyLevel other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RandomLevelId != 0)
			{
				this.RandomLevelId = other.RandomLevelId;
			}
			if (other.Reward)
			{
				this.Reward = other.Reward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x000C4D24 File Offset: 0x000C2F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x000C4D30 File Offset: 0x000C2F30
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reward = input.ReadBool();
					}
				}
				else
				{
					this.RandomLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003277 RID: 12919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003278 RID: 12920
		public const int RandomLevelIdFieldNumber = 1;

		// Token: 0x04003279 RID: 12921
		private int randomLevelId_;

		// Token: 0x0400327A RID: 12922
		public const int RewardFieldNumber = 2;

		// Token: 0x0400327B RID: 12923
		private bool reward_;
	}
}
