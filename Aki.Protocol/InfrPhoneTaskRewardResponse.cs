using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D8 RID: 2008
	[NetMessage(EMessageId.InfrPhoneTaskRewardResponse)]
	public sealed class InfrPhoneTaskRewardResponse : IMessage<InfrPhoneTaskRewardResponse>, IMessage, IEquatable<InfrPhoneTaskRewardResponse>, IDeepCloneable<InfrPhoneTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600B491 RID: 46225 RVA: 0x001AFBF9 File Offset: 0x001ADDF9
		[NullableContext(1)]
		public static InfrPhoneTaskRewardResponse Create()
		{
			return new InfrPhoneTaskRewardResponse();
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x0600B492 RID: 46226 RVA: 0x001AFC00 File Offset: 0x001ADE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x0600B493 RID: 46227 RVA: 0x001AFC03 File Offset: 0x001ADE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrPhoneTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600B494 RID: 46228 RVA: 0x001AFC0A File Offset: 0x001ADE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardResponse()
		{
		}

		// Token: 0x0600B495 RID: 46229 RVA: 0x001AFC12 File Offset: 0x001ADE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardResponse(InfrPhoneTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B496 RID: 46230 RVA: 0x001AFC37 File Offset: 0x001ADE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardResponse Clone()
		{
			return new InfrPhoneTaskRewardResponse(this);
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x0600B497 RID: 46231 RVA: 0x001AFC3F File Offset: 0x001ADE3F
		// (set) Token: 0x0600B498 RID: 46232 RVA: 0x001AFC47 File Offset: 0x001ADE47
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

		// Token: 0x0600B499 RID: 46233 RVA: 0x001AFC50 File Offset: 0x001ADE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrPhoneTaskRewardResponse);
		}

		// Token: 0x0600B49A RID: 46234 RVA: 0x001AFC5E File Offset: 0x001ADE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrPhoneTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B49B RID: 46235 RVA: 0x001AFC8C File Offset: 0x001ADE8C
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

		// Token: 0x0600B49C RID: 46236 RVA: 0x001AFCD1 File Offset: 0x001ADED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B49D RID: 46237 RVA: 0x001AFCDE File Offset: 0x001ADEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B49E RID: 46238 RVA: 0x001AFCE7 File Offset: 0x001ADEE7
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

		// Token: 0x0600B49F RID: 46239 RVA: 0x001AFD18 File Offset: 0x001ADF18
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

		// Token: 0x0600B4A0 RID: 46240 RVA: 0x001AFD56 File Offset: 0x001ADF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrPhoneTaskRewardResponse other)
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

		// Token: 0x0600B4A1 RID: 46241 RVA: 0x001AFD87 File Offset: 0x001ADF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4A2 RID: 46242 RVA: 0x001AFD90 File Offset: 0x001ADF90
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

		// Token: 0x040050A2 RID: 20642
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050A3 RID: 20643
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040050A4 RID: 20644
		private ErrorCode errorCode_;
	}
}
