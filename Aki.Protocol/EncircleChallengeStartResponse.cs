using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000425 RID: 1061
	[NetMessage(EMessageId.EncircleChallengeStartResponse)]
	public sealed class EncircleChallengeStartResponse : IMessage<EncircleChallengeStartResponse>, IMessage, IEquatable<EncircleChallengeStartResponse>, IDeepCloneable<EncircleChallengeStartResponse>, IBufferMessage
	{
		// Token: 0x06006643 RID: 26179 RVA: 0x000F62E1 File Offset: 0x000F44E1
		[NullableContext(1)]
		public static EncircleChallengeStartResponse Create()
		{
			return new EncircleChallengeStartResponse();
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06006644 RID: 26180 RVA: 0x000F62E8 File Offset: 0x000F44E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06006645 RID: 26181 RVA: 0x000F62EB File Offset: 0x000F44EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengeStartResponse.Descriptor;
			}
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x000F62F2 File Offset: 0x000F44F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartResponse()
		{
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x000F62FA File Offset: 0x000F44FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartResponse(EncircleChallengeStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x000F631F File Offset: 0x000F451F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartResponse Clone()
		{
			return new EncircleChallengeStartResponse(this);
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06006649 RID: 26185 RVA: 0x000F6327 File Offset: 0x000F4527
		// (set) Token: 0x0600664A RID: 26186 RVA: 0x000F632F File Offset: 0x000F452F
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

		// Token: 0x0600664B RID: 26187 RVA: 0x000F6338 File Offset: 0x000F4538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengeStartResponse);
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x000F6346 File Offset: 0x000F4546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengeStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600664D RID: 26189 RVA: 0x000F6374 File Offset: 0x000F4574
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

		// Token: 0x0600664E RID: 26190 RVA: 0x000F63B9 File Offset: 0x000F45B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x000F63C6 File Offset: 0x000F45C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x000F63CF File Offset: 0x000F45CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x000F6404 File Offset: 0x000F4604
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

		// Token: 0x06006652 RID: 26194 RVA: 0x000F6442 File Offset: 0x000F4642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EncircleChallengeStartResponse other)
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

		// Token: 0x06006653 RID: 26195 RVA: 0x000F6473 File Offset: 0x000F4673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x000F647C File Offset: 0x000F467C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003971 RID: 14705
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003972 RID: 14706
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003973 RID: 14707
		private ErrorCode errorCode_;
	}
}
