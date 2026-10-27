using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000819 RID: 2073
	[NetMessage(EMessageId.InspirationUnlockChoiceResponse)]
	public sealed class InspirationUnlockChoiceResponse : IMessage<InspirationUnlockChoiceResponse>, IMessage, IEquatable<InspirationUnlockChoiceResponse>, IDeepCloneable<InspirationUnlockChoiceResponse>, IBufferMessage
	{
		// Token: 0x0600B94C RID: 47436 RVA: 0x001B9357 File Offset: 0x001B7557
		[NullableContext(1)]
		public static InspirationUnlockChoiceResponse Create()
		{
			return new InspirationUnlockChoiceResponse();
		}

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x0600B94D RID: 47437 RVA: 0x001B935E File Offset: 0x001B755E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x0600B94E RID: 47438 RVA: 0x001B9361 File Offset: 0x001B7561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InspirationUnlockChoiceResponse.Descriptor;
			}
		}

		// Token: 0x0600B94F RID: 47439 RVA: 0x001B9368 File Offset: 0x001B7568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceResponse()
		{
		}

		// Token: 0x0600B950 RID: 47440 RVA: 0x001B9370 File Offset: 0x001B7570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceResponse(InspirationUnlockChoiceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B951 RID: 47441 RVA: 0x001B9395 File Offset: 0x001B7595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceResponse Clone()
		{
			return new InspirationUnlockChoiceResponse(this);
		}

		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x0600B952 RID: 47442 RVA: 0x001B939D File Offset: 0x001B759D
		// (set) Token: 0x0600B953 RID: 47443 RVA: 0x001B93A5 File Offset: 0x001B75A5
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

		// Token: 0x0600B954 RID: 47444 RVA: 0x001B93AE File Offset: 0x001B75AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InspirationUnlockChoiceResponse);
		}

		// Token: 0x0600B955 RID: 47445 RVA: 0x001B93BC File Offset: 0x001B75BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InspirationUnlockChoiceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B956 RID: 47446 RVA: 0x001B93EC File Offset: 0x001B75EC
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

		// Token: 0x0600B957 RID: 47447 RVA: 0x001B9431 File Offset: 0x001B7631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B958 RID: 47448 RVA: 0x001B943E File Offset: 0x001B763E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B959 RID: 47449 RVA: 0x001B9447 File Offset: 0x001B7647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B95A RID: 47450 RVA: 0x001B947C File Offset: 0x001B767C
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

		// Token: 0x0600B95B RID: 47451 RVA: 0x001B94BA File Offset: 0x001B76BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InspirationUnlockChoiceResponse other)
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

		// Token: 0x0600B95C RID: 47452 RVA: 0x001B94EB File Offset: 0x001B76EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B95D RID: 47453 RVA: 0x001B94F4 File Offset: 0x001B76F4
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400517B RID: 20859
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400517C RID: 20860
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400517D RID: 20861
		private ErrorCode errorCode_;
	}
}
