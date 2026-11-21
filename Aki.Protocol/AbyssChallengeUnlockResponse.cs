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
		// Token: 0x06001162 RID: 4450 RVA: 0x00030735 File Offset: 0x0002E935
		[NullableContext(1)]
		public static AbyssChallengeUnlockResponse Create()
		{
			return new AbyssChallengeUnlockResponse();
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0003073C File Offset: 0x0002E93C
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
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x0003073F File Offset: 0x0002E93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00030746 File Offset: 0x0002E946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockResponse()
		{
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0003074E File Offset: 0x0002E94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockResponse(AbyssChallengeUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00030773 File Offset: 0x0002E973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeUnlockResponse Clone()
		{
			return new AbyssChallengeUnlockResponse(this);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x0003077B File Offset: 0x0002E97B
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x00030783 File Offset: 0x0002E983
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

		// Token: 0x0600116A RID: 4458 RVA: 0x0003078C File Offset: 0x0002E98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeUnlockResponse);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0003079A File Offset: 0x0002E99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x000307C8 File Offset: 0x0002E9C8
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

		// Token: 0x0600116D RID: 4461 RVA: 0x0003080D File Offset: 0x0002EA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0003081A File Offset: 0x0002EA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00030823 File Offset: 0x0002EA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00030858 File Offset: 0x0002EA58
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

		// Token: 0x06001171 RID: 4465 RVA: 0x00030896 File Offset: 0x0002EA96
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

		// Token: 0x06001172 RID: 4466 RVA: 0x000308C7 File Offset: 0x0002EAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x000308D0 File Offset: 0x0002EAD0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001FBE RID: 8126
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FBF RID: 8127
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04001FC0 RID: 8128
		private ErrorCode errorCode_;
	}
}
