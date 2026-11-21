using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001108 RID: 4360
	public sealed class RoleTrialTask : IMessage<RoleTrialTask>, IMessage, IEquatable<RoleTrialTask>, IDeepCloneable<RoleTrialTask>, IBufferMessage
	{
		// Token: 0x060174DD RID: 95453 RVA: 0x00364208 File Offset: 0x00362408
		[NullableContext(1)]
		public static RoleTrialTask Create()
		{
			return new RoleTrialTask();
		}

		// Token: 0x17004E4B RID: 20043
		// (get) Token: 0x060174DE RID: 95454 RVA: 0x0036420F File Offset: 0x0036240F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTrialTask> Parser
		{
			get
			{
				return RoleTrialTask._parser;
			}
		}

		// Token: 0x17004E4C RID: 20044
		// (get) Token: 0x060174DF RID: 95455 RVA: 0x00364216 File Offset: 0x00362416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E4D RID: 20045
		// (get) Token: 0x060174E0 RID: 95456 RVA: 0x00364219 File Offset: 0x00362419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialTask.Descriptor;
			}
		}

		// Token: 0x060174E1 RID: 95457 RVA: 0x00364220 File Offset: 0x00362420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialTask()
		{
		}

		// Token: 0x060174E2 RID: 95458 RVA: 0x00364228 File Offset: 0x00362428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialTask(RoleTrialTask other) : this()
		{
			this.roleId_ = other.roleId_;
			this.challengeState_ = other.challengeState_;
			this.beginOpenTime_ = other.beginOpenTime_;
			this.endOpenTime_ = other.endOpenTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060174E3 RID: 95459 RVA: 0x0036427C File Offset: 0x0036247C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialTask Clone()
		{
			return new RoleTrialTask(this);
		}

		// Token: 0x17004E4E RID: 20046
		// (get) Token: 0x060174E4 RID: 95460 RVA: 0x00364284 File Offset: 0x00362484
		// (set) Token: 0x060174E5 RID: 95461 RVA: 0x0036428C File Offset: 0x0036248C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004E4F RID: 20047
		// (get) Token: 0x060174E6 RID: 95462 RVA: 0x00364295 File Offset: 0x00362495
		// (set) Token: 0x060174E7 RID: 95463 RVA: 0x0036429D File Offset: 0x0036249D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeState ChallengeState
		{
			get
			{
				return this.challengeState_;
			}
			set
			{
				this.challengeState_ = value;
			}
		}

		// Token: 0x17004E50 RID: 20048
		// (get) Token: 0x060174E8 RID: 95464 RVA: 0x003642A6 File Offset: 0x003624A6
		// (set) Token: 0x060174E9 RID: 95465 RVA: 0x003642AE File Offset: 0x003624AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginOpenTime
		{
			get
			{
				return this.beginOpenTime_;
			}
			set
			{
				this.beginOpenTime_ = value;
			}
		}

		// Token: 0x17004E51 RID: 20049
		// (get) Token: 0x060174EA RID: 95466 RVA: 0x003642B7 File Offset: 0x003624B7
		// (set) Token: 0x060174EB RID: 95467 RVA: 0x003642BF File Offset: 0x003624BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndOpenTime
		{
			get
			{
				return this.endOpenTime_;
			}
			set
			{
				this.endOpenTime_ = value;
			}
		}

		// Token: 0x060174EC RID: 95468 RVA: 0x003642C8 File Offset: 0x003624C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialTask);
		}

		// Token: 0x060174ED RID: 95469 RVA: 0x003642D8 File Offset: 0x003624D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialTask other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.ChallengeState == other.ChallengeState && this.BeginOpenTime == other.BeginOpenTime && this.EndOpenTime == other.EndOpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060174EE RID: 95470 RVA: 0x00364344 File Offset: 0x00362544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.ChallengeState != ChallengeState.Running)
			{
				num ^= this.ChallengeState.GetHashCode();
			}
			if (this.BeginOpenTime != 0L)
			{
				num ^= this.BeginOpenTime.GetHashCode();
			}
			if (this.EndOpenTime != 0L)
			{
				num ^= this.EndOpenTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060174EF RID: 95471 RVA: 0x003643D4 File Offset: 0x003625D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060174F0 RID: 95472 RVA: 0x003643E1 File Offset: 0x003625E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060174F1 RID: 95473 RVA: 0x003643EC File Offset: 0x003625EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.ChallengeState != ChallengeState.Running)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ChallengeState);
			}
			if (this.BeginOpenTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.BeginOpenTime);
			}
			if (this.EndOpenTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EndOpenTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060174F2 RID: 95474 RVA: 0x0036447C File Offset: 0x0036267C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.ChallengeState != ChallengeState.Running)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChallengeState);
			}
			if (this.BeginOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginOpenTime);
			}
			if (this.EndOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndOpenTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060174F3 RID: 95475 RVA: 0x00364504 File Offset: 0x00362704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrialTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.ChallengeState != ChallengeState.Running)
			{
				this.ChallengeState = other.ChallengeState;
			}
			if (other.BeginOpenTime != 0L)
			{
				this.BeginOpenTime = other.BeginOpenTime;
			}
			if (other.EndOpenTime != 0L)
			{
				this.EndOpenTime = other.EndOpenTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060174F4 RID: 95476 RVA: 0x0036457C File Offset: 0x0036277C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060174F5 RID: 95477 RVA: 0x00364588 File Offset: 0x00362788
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
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ChallengeState = (ChallengeState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.BeginOpenTime = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.EndOpenTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008B4C RID: 35660
		private static readonly MessageParser<RoleTrialTask> _parser = new MessageParser<RoleTrialTask>(() => new RoleTrialTask());

		// Token: 0x04008B4D RID: 35661
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B4E RID: 35662
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008B4F RID: 35663
		private int roleId_;

		// Token: 0x04008B50 RID: 35664
		public const int ChallengeStateFieldNumber = 2;

		// Token: 0x04008B51 RID: 35665
		private ChallengeState challengeState_;

		// Token: 0x04008B52 RID: 35666
		public const int BeginOpenTimeFieldNumber = 5;

		// Token: 0x04008B53 RID: 35667
		private long beginOpenTime_;

		// Token: 0x04008B54 RID: 35668
		public const int EndOpenTimeFieldNumber = 6;

		// Token: 0x04008B55 RID: 35669
		private long endOpenTime_;
	}
}
