using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000019 RID: 25
	[NetMessage(EMessageId.AbyssChallengeQuitResponse)]
	public sealed class AbyssChallengeQuitResponse : IMessage<AbyssChallengeQuitResponse>, IMessage, IEquatable<AbyssChallengeQuitResponse>, IDeepCloneable<AbyssChallengeQuitResponse>, IBufferMessage
	{
		// Token: 0x0600105B RID: 4187 RVA: 0x0002DBA2 File Offset: 0x0002BDA2
		[NullableContext(1)]
		public static AbyssChallengeQuitResponse Create()
		{
			return new AbyssChallengeQuitResponse();
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0002DBA9 File Offset: 0x0002BDA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x0002DBAC File Offset: 0x0002BDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeQuitResponse.Descriptor;
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0002DBB3 File Offset: 0x0002BDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitResponse()
		{
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0002DBBB File Offset: 0x0002BDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitResponse(AbyssChallengeQuitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0002DBE0 File Offset: 0x0002BDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitResponse Clone()
		{
			return new AbyssChallengeQuitResponse(this);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
		// (set) Token: 0x06001062 RID: 4194 RVA: 0x0002DBF0 File Offset: 0x0002BDF0
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

		// Token: 0x06001063 RID: 4195 RVA: 0x0002DBF9 File Offset: 0x0002BDF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeQuitResponse);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0002DC07 File Offset: 0x0002BE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeQuitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0002DC38 File Offset: 0x0002BE38
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

		// Token: 0x06001066 RID: 4198 RVA: 0x0002DC7D File Offset: 0x0002BE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0002DC8A File Offset: 0x0002BE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0002DC93 File Offset: 0x0002BE93
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

		// Token: 0x06001069 RID: 4201 RVA: 0x0002DCC8 File Offset: 0x0002BEC8
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

		// Token: 0x0600106A RID: 4202 RVA: 0x0002DD06 File Offset: 0x0002BF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeQuitResponse other)
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

		// Token: 0x0600106B RID: 4203 RVA: 0x0002DD37 File Offset: 0x0002BF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0002DD40 File Offset: 0x0002BF40
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

		// Token: 0x04001F07 RID: 7943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F08 RID: 7944
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04001F09 RID: 7945
		private ErrorCode errorCode_;
	}
}
