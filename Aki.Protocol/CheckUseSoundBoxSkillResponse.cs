using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028C RID: 652
	[NetMessage(EMessageId.CheckUseSoundBoxSkillResponse)]
	public sealed class CheckUseSoundBoxSkillResponse : IMessage<CheckUseSoundBoxSkillResponse>, IMessage, IEquatable<CheckUseSoundBoxSkillResponse>, IDeepCloneable<CheckUseSoundBoxSkillResponse>, IBufferMessage
	{
		// Token: 0x06004445 RID: 17477 RVA: 0x000A7712 File Offset: 0x000A5912
		[NullableContext(1)]
		public static CheckUseSoundBoxSkillResponse Create()
		{
			return new CheckUseSoundBoxSkillResponse();
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06004446 RID: 17478 RVA: 0x000A7719 File Offset: 0x000A5919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x000A771C File Offset: 0x000A591C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckUseSoundBoxSkillResponse.Descriptor;
			}
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x000A7723 File Offset: 0x000A5923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillResponse()
		{
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x000A772B File Offset: 0x000A592B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillResponse(CheckUseSoundBoxSkillResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x000A7750 File Offset: 0x000A5950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillResponse Clone()
		{
			return new CheckUseSoundBoxSkillResponse(this);
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x0600444B RID: 17483 RVA: 0x000A7758 File Offset: 0x000A5958
		// (set) Token: 0x0600444C RID: 17484 RVA: 0x000A7760 File Offset: 0x000A5960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x000A7769 File Offset: 0x000A5969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckUseSoundBoxSkillResponse);
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x000A7777 File Offset: 0x000A5977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckUseSoundBoxSkillResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x000A77A8 File Offset: 0x000A59A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x000A77ED File Offset: 0x000A59ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x000A77FA File Offset: 0x000A59FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x000A7803 File Offset: 0x000A5A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x000A7838 File Offset: 0x000A5A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x000A7876 File Offset: 0x000A5A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckUseSoundBoxSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x000A78A7 File Offset: 0x000A5AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x000A78B0 File Offset: 0x000A5AB0
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002EE0 RID: 12000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EE1 RID: 12001
		public const int CodeFieldNumber = 15;

		// Token: 0x04002EE2 RID: 12002
		private ErrorCode code_;
	}
}
