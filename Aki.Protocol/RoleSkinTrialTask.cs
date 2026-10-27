using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C2 RID: 4290
	public sealed class RoleSkinTrialTask : IMessage<RoleSkinTrialTask>, IMessage, IEquatable<RoleSkinTrialTask>, IDeepCloneable<RoleSkinTrialTask>, IBufferMessage
	{
		// Token: 0x06016E55 RID: 93781 RVA: 0x00353265 File Offset: 0x00351465
		[NullableContext(1)]
		public static RoleSkinTrialTask Create()
		{
			return new RoleSkinTrialTask();
		}

		// Token: 0x17004CB2 RID: 19634
		// (get) Token: 0x06016E56 RID: 93782 RVA: 0x0035326C File Offset: 0x0035146C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleSkinTrialTask> Parser
		{
			get
			{
				return RoleSkinTrialTask._parser;
			}
		}

		// Token: 0x17004CB3 RID: 19635
		// (get) Token: 0x06016E57 RID: 93783 RVA: 0x00353273 File Offset: 0x00351473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CB4 RID: 19636
		// (get) Token: 0x06016E58 RID: 93784 RVA: 0x00353276 File Offset: 0x00351476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinTrialTask.Descriptor;
			}
		}

		// Token: 0x06016E59 RID: 93785 RVA: 0x0035327D File Offset: 0x0035147D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialTask()
		{
		}

		// Token: 0x06016E5A RID: 93786 RVA: 0x00353285 File Offset: 0x00351485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialTask(RoleSkinTrialTask other) : this()
		{
			this.roleSkinTrialInfoId_ = other.roleSkinTrialInfoId_;
			this.challengeState_ = other.challengeState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E5B RID: 93787 RVA: 0x003532B6 File Offset: 0x003514B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialTask Clone()
		{
			return new RoleSkinTrialTask(this);
		}

		// Token: 0x17004CB5 RID: 19637
		// (get) Token: 0x06016E5C RID: 93788 RVA: 0x003532BE File Offset: 0x003514BE
		// (set) Token: 0x06016E5D RID: 93789 RVA: 0x003532C6 File Offset: 0x003514C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinTrialInfoId
		{
			get
			{
				return this.roleSkinTrialInfoId_;
			}
			set
			{
				this.roleSkinTrialInfoId_ = value;
			}
		}

		// Token: 0x17004CB6 RID: 19638
		// (get) Token: 0x06016E5E RID: 93790 RVA: 0x003532CF File Offset: 0x003514CF
		// (set) Token: 0x06016E5F RID: 93791 RVA: 0x003532D7 File Offset: 0x003514D7
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

		// Token: 0x06016E60 RID: 93792 RVA: 0x003532E0 File Offset: 0x003514E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinTrialTask);
		}

		// Token: 0x06016E61 RID: 93793 RVA: 0x003532EE File Offset: 0x003514EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinTrialTask other)
		{
			return other != null && (other == this || (this.RoleSkinTrialInfoId == other.RoleSkinTrialInfoId && this.ChallengeState == other.ChallengeState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E62 RID: 93794 RVA: 0x0035332C File Offset: 0x0035152C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleSkinTrialInfoId != 0)
			{
				num ^= this.RoleSkinTrialInfoId.GetHashCode();
			}
			if (this.ChallengeState != ChallengeState.Running)
			{
				num ^= this.ChallengeState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016E63 RID: 93795 RVA: 0x0035338A File Offset: 0x0035158A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E64 RID: 93796 RVA: 0x00353397 File Offset: 0x00351597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E65 RID: 93797 RVA: 0x003533A0 File Offset: 0x003515A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleSkinTrialInfoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleSkinTrialInfoId);
			}
			if (this.ChallengeState != ChallengeState.Running)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ChallengeState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E66 RID: 93798 RVA: 0x003533F8 File Offset: 0x003515F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleSkinTrialInfoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinTrialInfoId);
			}
			if (this.ChallengeState != ChallengeState.Running)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChallengeState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016E67 RID: 93799 RVA: 0x00353450 File Offset: 0x00351650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinTrialTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleSkinTrialInfoId != 0)
			{
				this.RoleSkinTrialInfoId = other.RoleSkinTrialInfoId;
			}
			if (other.ChallengeState != ChallengeState.Running)
			{
				this.ChallengeState = other.ChallengeState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E68 RID: 93800 RVA: 0x003534A0 File Offset: 0x003516A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E69 RID: 93801 RVA: 0x003534AC File Offset: 0x003516AC
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
						this.ChallengeState = (ChallengeState)input.ReadEnum();
					}
				}
				else
				{
					this.RoleSkinTrialInfoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400887D RID: 34941
		private static readonly MessageParser<RoleSkinTrialTask> _parser = new MessageParser<RoleSkinTrialTask>(() => new RoleSkinTrialTask());

		// Token: 0x0400887E RID: 34942
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400887F RID: 34943
		public const int RoleSkinTrialInfoIdFieldNumber = 1;

		// Token: 0x04008880 RID: 34944
		private int roleSkinTrialInfoId_;

		// Token: 0x04008881 RID: 34945
		public const int ChallengeStateFieldNumber = 2;

		// Token: 0x04008882 RID: 34946
		private ChallengeState challengeState_;
	}
}
