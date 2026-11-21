using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D1 RID: 209
	[NetMessage(EMessageId.AdviceSetResponse)]
	public sealed class AdviceSetResponse : IMessage<AdviceSetResponse>, IMessage, IEquatable<AdviceSetResponse>, IDeepCloneable<AdviceSetResponse>, IBufferMessage
	{
		// Token: 0x06002047 RID: 8263 RVA: 0x00057651 File Offset: 0x00055851
		[NullableContext(1)]
		public static AdviceSetResponse Create()
		{
			return new AdviceSetResponse();
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x00057658 File Offset: 0x00055858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x0005765B File Offset: 0x0005585B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceSetResponse.Descriptor;
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00057662 File Offset: 0x00055862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetResponse()
		{
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0005766A File Offset: 0x0005586A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetResponse(AdviceSetResponse other) : this()
		{
			this.isShow_ = other.isShow_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0005769B File Offset: 0x0005589B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetResponse Clone()
		{
			return new AdviceSetResponse(this);
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x000576A3 File Offset: 0x000558A3
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x000576AB File Offset: 0x000558AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x000576B4 File Offset: 0x000558B4
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x000576BC File Offset: 0x000558BC
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

		// Token: 0x06002051 RID: 8273 RVA: 0x000576C5 File Offset: 0x000558C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceSetResponse);
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x000576D3 File Offset: 0x000558D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceSetResponse other)
		{
			return other != null && (other == this || (this.IsShow == other.IsShow && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00057714 File Offset: 0x00055914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
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

		// Token: 0x06002054 RID: 8276 RVA: 0x00057772 File Offset: 0x00055972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x0005777F File Offset: 0x0005597F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00057788 File Offset: 0x00055988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsShow);
			}
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

		// Token: 0x06002057 RID: 8279 RVA: 0x000577E0 File Offset: 0x000559E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsShow)
			{
				num += 2;
			}
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

		// Token: 0x06002058 RID: 8280 RVA: 0x0005782C File Offset: 0x00055A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceSetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0005787C File Offset: 0x00055A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00057888 File Offset: 0x00055A88
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
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.IsShow = input.ReadBool();
				}
			}
		}

		// Token: 0x0400243F RID: 9279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002440 RID: 9280
		public const int IsShowFieldNumber = 1;

		// Token: 0x04002441 RID: 9281
		private bool isShow_;

		// Token: 0x04002442 RID: 9282
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04002443 RID: 9283
		private ErrorCode errorCode_;
	}
}
