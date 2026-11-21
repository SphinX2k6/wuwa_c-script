using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DF RID: 2015
	[NetMessage(EMessageId.InfrThemeActivityAwardResponse)]
	public sealed class InfrThemeActivityAwardResponse : IMessage<InfrThemeActivityAwardResponse>, IMessage, IEquatable<InfrThemeActivityAwardResponse>, IDeepCloneable<InfrThemeActivityAwardResponse>, IBufferMessage
	{
		// Token: 0x0600B51A RID: 46362 RVA: 0x001B0D01 File Offset: 0x001AEF01
		[NullableContext(1)]
		public static InfrThemeActivityAwardResponse Create()
		{
			return new InfrThemeActivityAwardResponse();
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x0600B51B RID: 46363 RVA: 0x001B0D08 File Offset: 0x001AEF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x0600B51C RID: 46364 RVA: 0x001B0D0B File Offset: 0x001AEF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrThemeActivityAwardResponse.Descriptor;
			}
		}

		// Token: 0x0600B51D RID: 46365 RVA: 0x001B0D12 File Offset: 0x001AEF12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardResponse()
		{
		}

		// Token: 0x0600B51E RID: 46366 RVA: 0x001B0D1A File Offset: 0x001AEF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardResponse(InfrThemeActivityAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B51F RID: 46367 RVA: 0x001B0D3F File Offset: 0x001AEF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardResponse Clone()
		{
			return new InfrThemeActivityAwardResponse(this);
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x0600B520 RID: 46368 RVA: 0x001B0D47 File Offset: 0x001AEF47
		// (set) Token: 0x0600B521 RID: 46369 RVA: 0x001B0D4F File Offset: 0x001AEF4F
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

		// Token: 0x0600B522 RID: 46370 RVA: 0x001B0D58 File Offset: 0x001AEF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrThemeActivityAwardResponse);
		}

		// Token: 0x0600B523 RID: 46371 RVA: 0x001B0D66 File Offset: 0x001AEF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrThemeActivityAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B524 RID: 46372 RVA: 0x001B0D94 File Offset: 0x001AEF94
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

		// Token: 0x0600B525 RID: 46373 RVA: 0x001B0DD9 File Offset: 0x001AEFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B526 RID: 46374 RVA: 0x001B0DE6 File Offset: 0x001AEFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B527 RID: 46375 RVA: 0x001B0DEF File Offset: 0x001AEFEF
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

		// Token: 0x0600B528 RID: 46376 RVA: 0x001B0E24 File Offset: 0x001AF024
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

		// Token: 0x0600B529 RID: 46377 RVA: 0x001B0E62 File Offset: 0x001AF062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrThemeActivityAwardResponse other)
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

		// Token: 0x0600B52A RID: 46378 RVA: 0x001B0E93 File Offset: 0x001AF093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B52B RID: 46379 RVA: 0x001B0E9C File Offset: 0x001AF09C
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

		// Token: 0x040050C5 RID: 20677
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050C6 RID: 20678
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040050C7 RID: 20679
		private ErrorCode errorCode_;
	}
}
