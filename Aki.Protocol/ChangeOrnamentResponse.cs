using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000259 RID: 601
	[NetMessage(EMessageId.ChangeOrnamentResponse)]
	public sealed class ChangeOrnamentResponse : IMessage<ChangeOrnamentResponse>, IMessage, IEquatable<ChangeOrnamentResponse>, IDeepCloneable<ChangeOrnamentResponse>, IBufferMessage
	{
		// Token: 0x06004014 RID: 16404 RVA: 0x0009DDC3 File Offset: 0x0009BFC3
		[NullableContext(1)]
		public static ChangeOrnamentResponse Create()
		{
			return new ChangeOrnamentResponse();
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06004015 RID: 16405 RVA: 0x0009DDCA File Offset: 0x0009BFCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06004016 RID: 16406 RVA: 0x0009DDCD File Offset: 0x0009BFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeOrnamentResponse.Descriptor;
			}
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x0009DDD4 File Offset: 0x0009BFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentResponse()
		{
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x0009DDDC File Offset: 0x0009BFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentResponse(ChangeOrnamentResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x0009DE01 File Offset: 0x0009C001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentResponse Clone()
		{
			return new ChangeOrnamentResponse(this);
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x0600401A RID: 16410 RVA: 0x0009DE09 File Offset: 0x0009C009
		// (set) Token: 0x0600401B RID: 16411 RVA: 0x0009DE11 File Offset: 0x0009C011
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

		// Token: 0x0600401C RID: 16412 RVA: 0x0009DE1A File Offset: 0x0009C01A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeOrnamentResponse);
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x0009DE28 File Offset: 0x0009C028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeOrnamentResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x0009DE58 File Offset: 0x0009C058
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

		// Token: 0x0600401F RID: 16415 RVA: 0x0009DE9D File Offset: 0x0009C09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x0009DEAA File Offset: 0x0009C0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x0009DEB3 File Offset: 0x0009C0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x0009DEE8 File Offset: 0x0009C0E8
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

		// Token: 0x06004023 RID: 16419 RVA: 0x0009DF26 File Offset: 0x0009C126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeOrnamentResponse other)
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

		// Token: 0x06004024 RID: 16420 RVA: 0x0009DF57 File Offset: 0x0009C157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x0009DF60 File Offset: 0x0009C160
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002DA2 RID: 11682
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DA3 RID: 11683
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04002DA4 RID: 11684
		private ErrorCode errorCode_;
	}
}
