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
		// Token: 0x06001125 RID: 4389 RVA: 0x0002FFA7 File Offset: 0x0002E1A7
		[NullableContext(1)]
		public static AbyssChallengeUnlockRequest Create()
		{
			return new AbyssChallengeUnlockRequest();
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0002FFAE File Offset: 0x0002E1AE
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
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0002FFB1 File Offset: 0x0002E1B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0002FFB8 File Offset: 0x0002E1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockRequest()
		{
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0002FFC0 File Offset: 0x0002E1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockRequest(AbyssChallengeUnlockRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0002FFE5 File Offset: 0x0002E1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockRequest Clone()
		{
			return new AbyssChallengeUnlockRequest(this);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0002FFED File Offset: 0x0002E1ED
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0002FFF5 File Offset: 0x0002E1F5
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

		// Token: 0x0600112D RID: 4397 RVA: 0x0002FFFE File Offset: 0x0002E1FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeUnlockRequest);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0003000C File Offset: 0x0002E20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeUnlockRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0003003C File Offset: 0x0002E23C
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

		// Token: 0x06001130 RID: 4400 RVA: 0x0003007B File Offset: 0x0002E27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00030088 File Offset: 0x0002E288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00030091 File Offset: 0x0002E291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x000300C4 File Offset: 0x0002E2C4
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

		// Token: 0x06001134 RID: 4404 RVA: 0x00030102 File Offset: 0x0002E302
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

		// Token: 0x06001135 RID: 4405 RVA: 0x00030133 File Offset: 0x0002E333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0003013C File Offset: 0x0002E33C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001F65 RID: 8037
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F66 RID: 8038
		public const int ChallengeIdFieldNumber = 3;

		// Token: 0x04001F67 RID: 8039
		private int challengeId_;
	}
}
