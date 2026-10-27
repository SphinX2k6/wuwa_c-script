using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E1 RID: 2017
	[NetMessage(EMessageId.InfrLevelUpResponse)]
	public sealed class InfrLevelUpResponse : IMessage<InfrLevelUpResponse>, IMessage, IEquatable<InfrLevelUpResponse>, IDeepCloneable<InfrLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0600B50A RID: 46346 RVA: 0x001B08B6 File Offset: 0x001AEAB6
		[NullableContext(1)]
		public static InfrLevelUpResponse Create()
		{
			return new InfrLevelUpResponse();
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x0600B50B RID: 46347 RVA: 0x001B08BD File Offset: 0x001AEABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x0600B50C RID: 46348 RVA: 0x001B08C0 File Offset: 0x001AEAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0600B50D RID: 46349 RVA: 0x001B08C7 File Offset: 0x001AEAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpResponse()
		{
		}

		// Token: 0x0600B50E RID: 46350 RVA: 0x001B08CF File Offset: 0x001AEACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpResponse(InfrLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x001B08F4 File Offset: 0x001AEAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpResponse Clone()
		{
			return new InfrLevelUpResponse(this);
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x0600B510 RID: 46352 RVA: 0x001B08FC File Offset: 0x001AEAFC
		// (set) Token: 0x0600B511 RID: 46353 RVA: 0x001B0904 File Offset: 0x001AEB04
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

		// Token: 0x0600B512 RID: 46354 RVA: 0x001B090D File Offset: 0x001AEB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrLevelUpResponse);
		}

		// Token: 0x0600B513 RID: 46355 RVA: 0x001B091B File Offset: 0x001AEB1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B514 RID: 46356 RVA: 0x001B094C File Offset: 0x001AEB4C
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

		// Token: 0x0600B515 RID: 46357 RVA: 0x001B0991 File Offset: 0x001AEB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x001B099E File Offset: 0x001AEB9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B517 RID: 46359 RVA: 0x001B09A7 File Offset: 0x001AEBA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x001B09DC File Offset: 0x001AEBDC
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

		// Token: 0x0600B519 RID: 46361 RVA: 0x001B0A1A File Offset: 0x001AEC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrLevelUpResponse other)
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

		// Token: 0x0600B51A RID: 46362 RVA: 0x001B0A4B File Offset: 0x001AEC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B51B RID: 46363 RVA: 0x001B0A54 File Offset: 0x001AEC54
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400506A RID: 20586
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400506B RID: 20587
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400506C RID: 20588
		private ErrorCode errorCode_;
	}
}
