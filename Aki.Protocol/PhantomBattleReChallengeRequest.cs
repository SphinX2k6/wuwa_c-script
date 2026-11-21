using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8F RID: 3215
	[NetMessage(EMessageId.PhantomBattleReChallengeRequest)]
	public sealed class PhantomBattleReChallengeRequest : IMessage<PhantomBattleReChallengeRequest>, IMessage, IEquatable<PhantomBattleReChallengeRequest>, IDeepCloneable<PhantomBattleReChallengeRequest>, IBufferMessage
	{
		// Token: 0x06011723 RID: 71459 RVA: 0x0028ECDA File Offset: 0x0028CEDA
		[NullableContext(1)]
		public static PhantomBattleReChallengeRequest Create()
		{
			return new PhantomBattleReChallengeRequest();
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x06011724 RID: 71460 RVA: 0x0028ECE1 File Offset: 0x0028CEE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x06011725 RID: 71461 RVA: 0x0028ECE4 File Offset: 0x0028CEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReChallengeRequest.Descriptor;
			}
		}

		// Token: 0x06011726 RID: 71462 RVA: 0x0028ECEB File Offset: 0x0028CEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeRequest()
		{
		}

		// Token: 0x06011727 RID: 71463 RVA: 0x0028ECF3 File Offset: 0x0028CEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeRequest(PhantomBattleReChallengeRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011728 RID: 71464 RVA: 0x0028ED18 File Offset: 0x0028CF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeRequest Clone()
		{
			return new PhantomBattleReChallengeRequest(this);
		}

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x06011729 RID: 71465 RVA: 0x0028ED20 File Offset: 0x0028CF20
		// (set) Token: 0x0601172A RID: 71466 RVA: 0x0028ED28 File Offset: 0x0028CF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x0601172B RID: 71467 RVA: 0x0028ED31 File Offset: 0x0028CF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReChallengeRequest);
		}

		// Token: 0x0601172C RID: 71468 RVA: 0x0028ED3F File Offset: 0x0028CF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReChallengeRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601172D RID: 71469 RVA: 0x0028ED70 File Offset: 0x0028CF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601172E RID: 71470 RVA: 0x0028EDAF File Offset: 0x0028CFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601172F RID: 71471 RVA: 0x0028EDBC File Offset: 0x0028CFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011730 RID: 71472 RVA: 0x0028EDC5 File Offset: 0x0028CFC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011731 RID: 71473 RVA: 0x0028EDF8 File Offset: 0x0028CFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011732 RID: 71474 RVA: 0x0028EE36 File Offset: 0x0028D036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleReChallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011733 RID: 71475 RVA: 0x0028EE67 File Offset: 0x0028D067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011734 RID: 71476 RVA: 0x0028EE70 File Offset: 0x0028D070
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006E7F RID: 28287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E80 RID: 28288
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04006E81 RID: 28289
		private int challengeId_;
	}
}
