using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000022 RID: 34
	[NetMessage(EMessageId.AbyssChallengeUnlockResponse)]
	public sealed class AbyssChallengeUnlockResponse : IMessage<AbyssChallengeUnlockResponse>, IMessage, IEquatable<AbyssChallengeUnlockResponse>, IDeepCloneable<AbyssChallengeUnlockResponse>, IBufferMessage
	{
		// Token: 0x06001137 RID: 4407 RVA: 0x00030181 File Offset: 0x0002E381
		[NullableContext(1)]
		public static AbyssChallengeUnlockResponse Create()
		{
			return new AbyssChallengeUnlockResponse();
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x00030188 File Offset: 0x0002E388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0003018B File Offset: 0x0002E38B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeUnlockResponse.Descriptor;
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00030192 File Offset: 0x0002E392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockResponse()
		{
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0003019A File Offset: 0x0002E39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockResponse(AbyssChallengeUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x000301BF File Offset: 0x0002E3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockResponse Clone()
		{
			return new AbyssChallengeUnlockResponse(this);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x000301C7 File Offset: 0x0002E3C7
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x000301CF File Offset: 0x0002E3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x000301D8 File Offset: 0x0002E3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeUnlockResponse);
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x000301E6 File Offset: 0x0002E3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00030214 File Offset: 0x0002E414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00030259 File Offset: 0x0002E459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00030266 File Offset: 0x0002E466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0003026F File Offset: 0x0002E46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x000302A4 File Offset: 0x0002E4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x000302E2 File Offset: 0x0002E4E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00030313 File Offset: 0x0002E513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0003031C File Offset: 0x0002E51C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001F68 RID: 8040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F69 RID: 8041
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04001F6A RID: 8042
		private ErrorCode errorCode_;
	}
}
