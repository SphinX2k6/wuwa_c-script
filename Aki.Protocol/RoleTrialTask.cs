using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CE RID: 4302
	public sealed class RoleTrialTask : IMessage<RoleTrialTask>, IMessage, IEquatable<RoleTrialTask>, IDeepCloneable<RoleTrialTask>, IBufferMessage
	{
		// Token: 0x06016F3E RID: 94014 RVA: 0x00354F51 File Offset: 0x00353151
		[NullableContext(1)]
		public static RoleTrialTask Create()
		{
			return new RoleTrialTask();
		}

		// Token: 0x17004CE0 RID: 19680
		// (get) Token: 0x06016F3F RID: 94015 RVA: 0x00354F58 File Offset: 0x00353158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTrialTask> Parser
		{
			get
			{
				return RoleTrialTask._parser;
			}
		}

		// Token: 0x17004CE1 RID: 19681
		// (get) Token: 0x06016F40 RID: 94016 RVA: 0x00354F5F File Offset: 0x0035315F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CE2 RID: 19682
		// (get) Token: 0x06016F41 RID: 94017 RVA: 0x00354F62 File Offset: 0x00353162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialTask.Descriptor;
			}
		}

		// Token: 0x06016F42 RID: 94018 RVA: 0x00354F69 File Offset: 0x00353169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialTask()
		{
		}

		// Token: 0x06016F43 RID: 94019 RVA: 0x00354F74 File Offset: 0x00353174
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

		// Token: 0x06016F44 RID: 94020 RVA: 0x00354FC8 File Offset: 0x003531C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialTask Clone()
		{
			return new RoleTrialTask(this);
		}

		// Token: 0x17004CE3 RID: 19683
		// (get) Token: 0x06016F45 RID: 94021 RVA: 0x00354FD0 File Offset: 0x003531D0
		// (set) Token: 0x06016F46 RID: 94022 RVA: 0x00354FD8 File Offset: 0x003531D8
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

		// Token: 0x17004CE4 RID: 19684
		// (get) Token: 0x06016F47 RID: 94023 RVA: 0x00354FE1 File Offset: 0x003531E1
		// (set) Token: 0x06016F48 RID: 94024 RVA: 0x00354FE9 File Offset: 0x003531E9
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

		// Token: 0x17004CE5 RID: 19685
		// (get) Token: 0x06016F49 RID: 94025 RVA: 0x00354FF2 File Offset: 0x003531F2
		// (set) Token: 0x06016F4A RID: 94026 RVA: 0x00354FFA File Offset: 0x003531FA
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

		// Token: 0x17004CE6 RID: 19686
		// (get) Token: 0x06016F4B RID: 94027 RVA: 0x00355003 File Offset: 0x00353203
		// (set) Token: 0x06016F4C RID: 94028 RVA: 0x0035500B File Offset: 0x0035320B
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

		// Token: 0x06016F4D RID: 94029 RVA: 0x00355014 File Offset: 0x00353214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialTask);
		}

		// Token: 0x06016F4E RID: 94030 RVA: 0x00355024 File Offset: 0x00353224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialTask other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.ChallengeState == other.ChallengeState && this.BeginOpenTime == other.BeginOpenTime && this.EndOpenTime == other.EndOpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016F4F RID: 94031 RVA: 0x00355090 File Offset: 0x00353290
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

		// Token: 0x06016F50 RID: 94032 RVA: 0x00355120 File Offset: 0x00353320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F51 RID: 94033 RVA: 0x0035512D File Offset: 0x0035332D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F52 RID: 94034 RVA: 0x00355138 File Offset: 0x00353338
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

		// Token: 0x06016F53 RID: 94035 RVA: 0x003551C8 File Offset: 0x003533C8
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

		// Token: 0x06016F54 RID: 94036 RVA: 0x00355250 File Offset: 0x00353450
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

		// Token: 0x06016F55 RID: 94037 RVA: 0x003552C8 File Offset: 0x003534C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F56 RID: 94038 RVA: 0x003552D4 File Offset: 0x003534D4
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

		// Token: 0x040088BB RID: 35003
		private static readonly MessageParser<RoleTrialTask> _parser = new MessageParser<RoleTrialTask>(() => new RoleTrialTask());

		// Token: 0x040088BC RID: 35004
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088BD RID: 35005
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040088BE RID: 35006
		private int roleId_;

		// Token: 0x040088BF RID: 35007
		public const int ChallengeStateFieldNumber = 2;

		// Token: 0x040088C0 RID: 35008
		private ChallengeState challengeState_;

		// Token: 0x040088C1 RID: 35009
		public const int BeginOpenTimeFieldNumber = 5;

		// Token: 0x040088C2 RID: 35010
		private long beginOpenTime_;

		// Token: 0x040088C3 RID: 35011
		public const int EndOpenTimeFieldNumber = 6;

		// Token: 0x040088C4 RID: 35012
		private long endOpenTime_;
	}
}
