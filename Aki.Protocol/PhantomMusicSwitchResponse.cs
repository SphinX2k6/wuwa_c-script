using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDD RID: 3293
	[NetMessage(EMessageId.PhantomMusicSwitchResponse)]
	public sealed class PhantomMusicSwitchResponse : IMessage<PhantomMusicSwitchResponse>, IMessage, IEquatable<PhantomMusicSwitchResponse>, IDeepCloneable<PhantomMusicSwitchResponse>, IBufferMessage
	{
		// Token: 0x06011D5C RID: 73052 RVA: 0x0029C51D File Offset: 0x0029A71D
		[NullableContext(1)]
		public static PhantomMusicSwitchResponse Create()
		{
			return new PhantomMusicSwitchResponse();
		}

		// Token: 0x17003B18 RID: 15128
		// (get) Token: 0x06011D5D RID: 73053 RVA: 0x0029C524 File Offset: 0x0029A724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x06011D5E RID: 73054 RVA: 0x0029C527 File Offset: 0x0029A727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicSwitchResponse.Descriptor;
			}
		}

		// Token: 0x06011D5F RID: 73055 RVA: 0x0029C52E File Offset: 0x0029A72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchResponse()
		{
		}

		// Token: 0x06011D60 RID: 73056 RVA: 0x0029C536 File Offset: 0x0029A736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchResponse(PhantomMusicSwitchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D61 RID: 73057 RVA: 0x0029C55B File Offset: 0x0029A75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSwitchResponse Clone()
		{
			return new PhantomMusicSwitchResponse(this);
		}

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x06011D62 RID: 73058 RVA: 0x0029C563 File Offset: 0x0029A763
		// (set) Token: 0x06011D63 RID: 73059 RVA: 0x0029C56B File Offset: 0x0029A76B
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

		// Token: 0x06011D64 RID: 73060 RVA: 0x0029C574 File Offset: 0x0029A774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicSwitchResponse);
		}

		// Token: 0x06011D65 RID: 73061 RVA: 0x0029C582 File Offset: 0x0029A782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicSwitchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D66 RID: 73062 RVA: 0x0029C5B0 File Offset: 0x0029A7B0
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

		// Token: 0x06011D67 RID: 73063 RVA: 0x0029C5F5 File Offset: 0x0029A7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D68 RID: 73064 RVA: 0x0029C602 File Offset: 0x0029A802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D69 RID: 73065 RVA: 0x0029C60B File Offset: 0x0029A80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D6A RID: 73066 RVA: 0x0029C63C File Offset: 0x0029A83C
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

		// Token: 0x06011D6B RID: 73067 RVA: 0x0029C67A File Offset: 0x0029A87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicSwitchResponse other)
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

		// Token: 0x06011D6C RID: 73068 RVA: 0x0029C6AB File Offset: 0x0029A8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D6D RID: 73069 RVA: 0x0029C6B4 File Offset: 0x0029A8B4
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400705D RID: 28765
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400705E RID: 28766
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400705F RID: 28767
		private ErrorCode errorCode_;
	}
}
