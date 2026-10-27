using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017C RID: 380
	[NetMessage(EMessageId.BattleScoreNotify)]
	public sealed class BattleScoreNotify : IMessage<BattleScoreNotify>, IMessage, IEquatable<BattleScoreNotify>, IDeepCloneable<BattleScoreNotify>, IBufferMessage
	{
		// Token: 0x06002E35 RID: 11829 RVA: 0x00077174 File Offset: 0x00075374
		[NullableContext(1)]
		public static BattleScoreNotify Create()
		{
			return new BattleScoreNotify();
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x0007717B File Offset: 0x0007537B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x0007717E File Offset: 0x0007537E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleScoreNotify.Descriptor;
			}
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00077185 File Offset: 0x00075385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreNotify()
		{
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x0007718D File Offset: 0x0007538D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreNotify(BattleScoreNotify other) : this()
		{
			this.battleScoreConfId_ = other.battleScoreConfId_;
			this.scoreTotal_ = other.scoreTotal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x000771BE File Offset: 0x000753BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreNotify Clone()
		{
			return new BattleScoreNotify(this);
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x000771C6 File Offset: 0x000753C6
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x000771CE File Offset: 0x000753CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BattleScoreConfId
		{
			get
			{
				return this.battleScoreConfId_;
			}
			set
			{
				this.battleScoreConfId_ = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x000771D7 File Offset: 0x000753D7
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x000771DF File Offset: 0x000753DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ScoreTotal
		{
			get
			{
				return this.scoreTotal_;
			}
			set
			{
				this.scoreTotal_ = value;
			}
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000771E8 File Offset: 0x000753E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleScoreNotify);
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x000771F6 File Offset: 0x000753F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleScoreNotify other)
		{
			return other != null && (other == this || (this.BattleScoreConfId == other.BattleScoreConfId && this.ScoreTotal == other.ScoreTotal && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x00077234 File Offset: 0x00075434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleScoreConfId != 0)
			{
				num ^= this.BattleScoreConfId.GetHashCode();
			}
			if (this.ScoreTotal != 0)
			{
				num ^= this.ScoreTotal.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x0007728C File Offset: 0x0007548C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x00077299 File Offset: 0x00075499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x000772A4 File Offset: 0x000754A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreTotal != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ScoreTotal);
			}
			if (this.BattleScoreConfId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.BattleScoreConfId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x00077300 File Offset: 0x00075500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleScoreConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleScoreConfId);
			}
			if (this.ScoreTotal != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ScoreTotal);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x00077358 File Offset: 0x00075558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleScoreNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleScoreConfId != 0)
			{
				this.BattleScoreConfId = other.BattleScoreConfId;
			}
			if (other.ScoreTotal != 0)
			{
				this.ScoreTotal = other.ScoreTotal;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x000773A8 File Offset: 0x000755A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x000773B4 File Offset: 0x000755B4
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
				if (num != 40U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BattleScoreConfId = input.ReadInt32();
					}
				}
				else
				{
					this.ScoreTotal = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002866 RID: 10342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002867 RID: 10343
		public const int BattleScoreConfIdFieldNumber = 15;

		// Token: 0x04002868 RID: 10344
		private int battleScoreConfId_;

		// Token: 0x04002869 RID: 10345
		public const int ScoreTotalFieldNumber = 5;

		// Token: 0x0400286A RID: 10346
		private int scoreTotal_;
	}
}
