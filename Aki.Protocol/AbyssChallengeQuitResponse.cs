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
		// Token: 0x06001086 RID: 4230 RVA: 0x0002E156 File Offset: 0x0002C356
		[NullableContext(1)]
		public static AbyssChallengeQuitResponse Create()
		{
			return new AbyssChallengeQuitResponse();
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x0002E15D File Offset: 0x0002C35D
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
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0002E160 File Offset: 0x0002C360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeQuitResponse.Descriptor;
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0002E167 File Offset: 0x0002C367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitResponse()
		{
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0002E16F File Offset: 0x0002C36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitResponse(AbyssChallengeQuitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0002E194 File Offset: 0x0002C394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitResponse Clone()
		{
			return new AbyssChallengeQuitResponse(this);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x0002E19C File Offset: 0x0002C39C
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x0002E1A4 File Offset: 0x0002C3A4
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

		// Token: 0x0600108E RID: 4238 RVA: 0x0002E1AD File Offset: 0x0002C3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeQuitResponse);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0002E1BB File Offset: 0x0002C3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeQuitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0002E1EC File Offset: 0x0002C3EC
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

		// Token: 0x06001091 RID: 4241 RVA: 0x0002E231 File Offset: 0x0002C431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0002E23E File Offset: 0x0002C43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0002E247 File Offset: 0x0002C447
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

		// Token: 0x06001094 RID: 4244 RVA: 0x0002E27C File Offset: 0x0002C47C
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

		// Token: 0x06001095 RID: 4245 RVA: 0x0002E2BA File Offset: 0x0002C4BA
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

		// Token: 0x06001096 RID: 4246 RVA: 0x0002E2EB File Offset: 0x0002C4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0002E2F4 File Offset: 0x0002C4F4
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

		// Token: 0x04001F5D RID: 8029
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F5E RID: 8030
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04001F5F RID: 8031
		private ErrorCode errorCode_;
	}
}
