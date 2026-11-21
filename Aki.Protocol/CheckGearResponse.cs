using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000288 RID: 648
	[NetMessage(EMessageId.CheckGearResponse)]
	public sealed class CheckGearResponse : IMessage<CheckGearResponse>, IMessage, IEquatable<CheckGearResponse>, IDeepCloneable<CheckGearResponse>, IBufferMessage
	{
		// Token: 0x060043FD RID: 17405 RVA: 0x000A6F35 File Offset: 0x000A5135
		[NullableContext(1)]
		public static CheckGearResponse Create()
		{
			return new CheckGearResponse();
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060043FE RID: 17406 RVA: 0x000A6F3C File Offset: 0x000A513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060043FF RID: 17407 RVA: 0x000A6F3F File Offset: 0x000A513F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckGearResponse.Descriptor;
			}
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x000A6F46 File Offset: 0x000A5146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearResponse()
		{
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x000A6F4E File Offset: 0x000A514E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearResponse(CheckGearResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x000A6F73 File Offset: 0x000A5173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearResponse Clone()
		{
			return new CheckGearResponse(this);
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06004403 RID: 17411 RVA: 0x000A6F7B File Offset: 0x000A517B
		// (set) Token: 0x06004404 RID: 17412 RVA: 0x000A6F83 File Offset: 0x000A5183
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

		// Token: 0x06004405 RID: 17413 RVA: 0x000A6F8C File Offset: 0x000A518C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckGearResponse);
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x000A6F9A File Offset: 0x000A519A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckGearResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x000A6FC8 File Offset: 0x000A51C8
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

		// Token: 0x06004408 RID: 17416 RVA: 0x000A700D File Offset: 0x000A520D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x000A701A File Offset: 0x000A521A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x000A7023 File Offset: 0x000A5223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x000A7058 File Offset: 0x000A5258
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

		// Token: 0x0600440C RID: 17420 RVA: 0x000A7096 File Offset: 0x000A5296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckGearResponse other)
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

		// Token: 0x0600440D RID: 17421 RVA: 0x000A70C7 File Offset: 0x000A52C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x000A70D0 File Offset: 0x000A52D0
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002ED4 RID: 11988
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ED5 RID: 11989
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04002ED6 RID: 11990
		private ErrorCode errorCode_;
	}
}
