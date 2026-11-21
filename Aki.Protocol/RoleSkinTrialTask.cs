using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B2 RID: 4274
	public sealed class RoleSkinTrialTask : IMessage<RoleSkinTrialTask>, IMessage, IEquatable<RoleSkinTrialTask>, IDeepCloneable<RoleSkinTrialTask>, IBufferMessage
	{
		// Token: 0x06016D70 RID: 93552 RVA: 0x00351B89 File Offset: 0x0034FD89
		[NullableContext(1)]
		public static RoleSkinTrialTask Create()
		{
			return new RoleSkinTrialTask();
		}

		// Token: 0x17004C88 RID: 19592
		// (get) Token: 0x06016D71 RID: 93553 RVA: 0x00351B90 File Offset: 0x0034FD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleSkinTrialTask> Parser
		{
			get
			{
				return RoleSkinTrialTask._parser;
			}
		}

		// Token: 0x17004C89 RID: 19593
		// (get) Token: 0x06016D72 RID: 93554 RVA: 0x00351B97 File Offset: 0x0034FD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C8A RID: 19594
		// (get) Token: 0x06016D73 RID: 93555 RVA: 0x00351B9A File Offset: 0x0034FD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinTrialTask.Descriptor;
			}
		}

		// Token: 0x06016D74 RID: 93556 RVA: 0x00351BA1 File Offset: 0x0034FDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialTask()
		{
		}

		// Token: 0x06016D75 RID: 93557 RVA: 0x00351BA9 File Offset: 0x0034FDA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialTask(RoleSkinTrialTask other) : this()
		{
			this.roleSkinTrialInfoId_ = other.roleSkinTrialInfoId_;
			this.challengeState_ = other.challengeState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D76 RID: 93558 RVA: 0x00351BDA File Offset: 0x0034FDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialTask Clone()
		{
			return new RoleSkinTrialTask(this);
		}

		// Token: 0x17004C8B RID: 19595
		// (get) Token: 0x06016D77 RID: 93559 RVA: 0x00351BE2 File Offset: 0x0034FDE2
		// (set) Token: 0x06016D78 RID: 93560 RVA: 0x00351BEA File Offset: 0x0034FDEA
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

		// Token: 0x17004C8C RID: 19596
		// (get) Token: 0x06016D79 RID: 93561 RVA: 0x00351BF3 File Offset: 0x0034FDF3
		// (set) Token: 0x06016D7A RID: 93562 RVA: 0x00351BFB File Offset: 0x0034FDFB
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

		// Token: 0x06016D7B RID: 93563 RVA: 0x00351C04 File Offset: 0x0034FE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinTrialTask);
		}

		// Token: 0x06016D7C RID: 93564 RVA: 0x00351C12 File Offset: 0x0034FE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinTrialTask other)
		{
			return other != null && (other == this || (this.RoleSkinTrialInfoId == other.RoleSkinTrialInfoId && this.ChallengeState == other.ChallengeState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D7D RID: 93565 RVA: 0x00351C50 File Offset: 0x0034FE50
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

		// Token: 0x06016D7E RID: 93566 RVA: 0x00351CAE File Offset: 0x0034FEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D7F RID: 93567 RVA: 0x00351CBB File Offset: 0x0034FEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D80 RID: 93568 RVA: 0x00351CC4 File Offset: 0x0034FEC4
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

		// Token: 0x06016D81 RID: 93569 RVA: 0x00351D1C File Offset: 0x0034FF1C
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

		// Token: 0x06016D82 RID: 93570 RVA: 0x00351D74 File Offset: 0x0034FF74
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

		// Token: 0x06016D83 RID: 93571 RVA: 0x00351DC4 File Offset: 0x0034FFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D84 RID: 93572 RVA: 0x00351DD0 File Offset: 0x0034FFD0
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

		// Token: 0x040088A7 RID: 34983
		private static readonly MessageParser<RoleSkinTrialTask> _parser = new MessageParser<RoleSkinTrialTask>(() => new RoleSkinTrialTask());

		// Token: 0x040088A8 RID: 34984
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088A9 RID: 34985
		public const int RoleSkinTrialInfoIdFieldNumber = 1;

		// Token: 0x040088AA RID: 34986
		private int roleSkinTrialInfoId_;

		// Token: 0x040088AB RID: 34987
		public const int ChallengeStateFieldNumber = 2;

		// Token: 0x040088AC RID: 34988
		private ChallengeState challengeState_;
	}
}
