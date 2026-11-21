using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000021 RID: 33
	[NetMessage(EMessageId.AbyssChallengeUnlockRequest)]
	public sealed class AbyssChallengeUnlockRequest : IMessage<AbyssChallengeUnlockRequest>, IMessage, IEquatable<AbyssChallengeUnlockRequest>, IDeepCloneable<AbyssChallengeUnlockRequest>, IBufferMessage
	{
		// Token: 0x06001150 RID: 4432 RVA: 0x0003055B File Offset: 0x0002E75B
		[NullableContext(1)]
		public static AbyssChallengeUnlockRequest Create()
		{
			return new AbyssChallengeUnlockRequest();
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00030562 File Offset: 0x0002E762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x00030565 File Offset: 0x0002E765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0003056C File Offset: 0x0002E76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockRequest()
		{
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00030574 File Offset: 0x0002E774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockRequest(AbyssChallengeUnlockRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00030599 File Offset: 0x0002E799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockRequest Clone()
		{
			return new AbyssChallengeUnlockRequest(this);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x000305A1 File Offset: 0x0002E7A1
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x000305A9 File Offset: 0x0002E7A9
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

		// Token: 0x06001158 RID: 4440 RVA: 0x000305B2 File Offset: 0x0002E7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeUnlockRequest);
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x000305C0 File Offset: 0x0002E7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeUnlockRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x000305F0 File Offset: 0x0002E7F0
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

		// Token: 0x0600115B RID: 4443 RVA: 0x0003062F File Offset: 0x0002E82F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0003063C File Offset: 0x0002E83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00030645 File Offset: 0x0002E845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00030678 File Offset: 0x0002E878
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

		// Token: 0x0600115F RID: 4447 RVA: 0x000306B6 File Offset: 0x0002E8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeUnlockRequest other)
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

		// Token: 0x06001160 RID: 4448 RVA: 0x000306E7 File Offset: 0x0002E8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x000306F0 File Offset: 0x0002E8F0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001FBB RID: 8123
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FBC RID: 8124
		public const int ChallengeIdFieldNumber = 9;

		// Token: 0x04001FBD RID: 8125
		private int challengeId_;
	}
}
