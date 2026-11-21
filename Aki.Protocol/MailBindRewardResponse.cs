using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000964 RID: 2404
	[NetMessage(EMessageId.MailBindRewardResponse)]
	public sealed class MailBindRewardResponse : IMessage<MailBindRewardResponse>, IMessage, IEquatable<MailBindRewardResponse>, IDeepCloneable<MailBindRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D3EE RID: 54254 RVA: 0x001F3742 File Offset: 0x001F1942
		[NullableContext(1)]
		public static MailBindRewardResponse Create()
		{
			return new MailBindRewardResponse();
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x0600D3EF RID: 54255 RVA: 0x001F3749 File Offset: 0x001F1949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x0600D3F0 RID: 54256 RVA: 0x001F374C File Offset: 0x001F194C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D3F1 RID: 54257 RVA: 0x001F3753 File Offset: 0x001F1953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardResponse()
		{
		}

		// Token: 0x0600D3F2 RID: 54258 RVA: 0x001F375B File Offset: 0x001F195B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardResponse(MailBindRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3F3 RID: 54259 RVA: 0x001F3780 File Offset: 0x001F1980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindRewardResponse Clone()
		{
			return new MailBindRewardResponse(this);
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x0600D3F4 RID: 54260 RVA: 0x001F3788 File Offset: 0x001F1988
		// (set) Token: 0x0600D3F5 RID: 54261 RVA: 0x001F3790 File Offset: 0x001F1990
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

		// Token: 0x0600D3F6 RID: 54262 RVA: 0x001F3799 File Offset: 0x001F1999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindRewardResponse);
		}

		// Token: 0x0600D3F7 RID: 54263 RVA: 0x001F37A7 File Offset: 0x001F19A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3F8 RID: 54264 RVA: 0x001F37D8 File Offset: 0x001F19D8
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

		// Token: 0x0600D3F9 RID: 54265 RVA: 0x001F381D File Offset: 0x001F1A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D3FA RID: 54266 RVA: 0x001F382A File Offset: 0x001F1A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3FB RID: 54267 RVA: 0x001F3833 File Offset: 0x001F1A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3FC RID: 54268 RVA: 0x001F3868 File Offset: 0x001F1A68
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

		// Token: 0x0600D3FD RID: 54269 RVA: 0x001F38A6 File Offset: 0x001F1AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindRewardResponse other)
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

		// Token: 0x0600D3FE RID: 54270 RVA: 0x001F38D7 File Offset: 0x001F1AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3FF RID: 54271 RVA: 0x001F38E0 File Offset: 0x001F1AE0
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005946 RID: 22854
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005947 RID: 22855
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005948 RID: 22856
		private ErrorCode errorCode_;
	}
}
