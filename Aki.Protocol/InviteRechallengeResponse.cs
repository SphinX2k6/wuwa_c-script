using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000842 RID: 2114
	[NetMessage(EMessageId.InviteRechallengeResponse)]
	public sealed class InviteRechallengeResponse : IMessage<InviteRechallengeResponse>, IMessage, IEquatable<InviteRechallengeResponse>, IDeepCloneable<InviteRechallengeResponse>, IBufferMessage
	{
		// Token: 0x0600BCBA RID: 48314 RVA: 0x001C1132 File Offset: 0x001BF332
		[NullableContext(1)]
		public static InviteRechallengeResponse Create()
		{
			return new InviteRechallengeResponse();
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x0600BCBB RID: 48315 RVA: 0x001C1139 File Offset: 0x001BF339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x0600BCBC RID: 48316 RVA: 0x001C113C File Offset: 0x001BF33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InviteRechallengeResponse.Descriptor;
			}
		}

		// Token: 0x0600BCBD RID: 48317 RVA: 0x001C1143 File Offset: 0x001BF343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeResponse()
		{
		}

		// Token: 0x0600BCBE RID: 48318 RVA: 0x001C114B File Offset: 0x001BF34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeResponse(InviteRechallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCBF RID: 48319 RVA: 0x001C1170 File Offset: 0x001BF370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeResponse Clone()
		{
			return new InviteRechallengeResponse(this);
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x0600BCC0 RID: 48320 RVA: 0x001C1178 File Offset: 0x001BF378
		// (set) Token: 0x0600BCC1 RID: 48321 RVA: 0x001C1180 File Offset: 0x001BF380
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

		// Token: 0x0600BCC2 RID: 48322 RVA: 0x001C1189 File Offset: 0x001BF389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InviteRechallengeResponse);
		}

		// Token: 0x0600BCC3 RID: 48323 RVA: 0x001C1197 File Offset: 0x001BF397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InviteRechallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCC4 RID: 48324 RVA: 0x001C11C8 File Offset: 0x001BF3C8
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

		// Token: 0x0600BCC5 RID: 48325 RVA: 0x001C120D File Offset: 0x001BF40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BCC6 RID: 48326 RVA: 0x001C121A File Offset: 0x001BF41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCC7 RID: 48327 RVA: 0x001C1223 File Offset: 0x001BF423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BCC8 RID: 48328 RVA: 0x001C1258 File Offset: 0x001BF458
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

		// Token: 0x0600BCC9 RID: 48329 RVA: 0x001C1296 File Offset: 0x001BF496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InviteRechallengeResponse other)
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

		// Token: 0x0600BCCA RID: 48330 RVA: 0x001C12C7 File Offset: 0x001BF4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCCB RID: 48331 RVA: 0x001C12D0 File Offset: 0x001BF4D0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400529A RID: 21146
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400529B RID: 21147
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400529C RID: 21148
		private ErrorCode errorCode_;
	}
}
