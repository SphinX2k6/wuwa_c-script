using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F3 RID: 2035
	[NetMessage(EMessageId.InfrThemeActivityAwardResponse)]
	public sealed class InfrThemeActivityAwardResponse : IMessage<InfrThemeActivityAwardResponse>, IMessage, IEquatable<InfrThemeActivityAwardResponse>, IDeepCloneable<InfrThemeActivityAwardResponse>, IBufferMessage
	{
		// Token: 0x0600B670 RID: 46704 RVA: 0x001B3739 File Offset: 0x001B1939
		[NullableContext(1)]
		public static InfrThemeActivityAwardResponse Create()
		{
			return new InfrThemeActivityAwardResponse();
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x0600B671 RID: 46705 RVA: 0x001B3740 File Offset: 0x001B1940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x0600B672 RID: 46706 RVA: 0x001B3743 File Offset: 0x001B1943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrThemeActivityAwardResponse.Descriptor;
			}
		}

		// Token: 0x0600B673 RID: 46707 RVA: 0x001B374A File Offset: 0x001B194A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardResponse()
		{
		}

		// Token: 0x0600B674 RID: 46708 RVA: 0x001B3752 File Offset: 0x001B1952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardResponse(InfrThemeActivityAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B675 RID: 46709 RVA: 0x001B3777 File Offset: 0x001B1977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardResponse Clone()
		{
			return new InfrThemeActivityAwardResponse(this);
		}

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x0600B676 RID: 46710 RVA: 0x001B377F File Offset: 0x001B197F
		// (set) Token: 0x0600B677 RID: 46711 RVA: 0x001B3787 File Offset: 0x001B1987
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

		// Token: 0x0600B678 RID: 46712 RVA: 0x001B3790 File Offset: 0x001B1990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrThemeActivityAwardResponse);
		}

		// Token: 0x0600B679 RID: 46713 RVA: 0x001B379E File Offset: 0x001B199E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrThemeActivityAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B67A RID: 46714 RVA: 0x001B37CC File Offset: 0x001B19CC
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

		// Token: 0x0600B67B RID: 46715 RVA: 0x001B3811 File Offset: 0x001B1A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B67C RID: 46716 RVA: 0x001B381E File Offset: 0x001B1A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B67D RID: 46717 RVA: 0x001B3827 File Offset: 0x001B1A27
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

		// Token: 0x0600B67E RID: 46718 RVA: 0x001B385C File Offset: 0x001B1A5C
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

		// Token: 0x0600B67F RID: 46719 RVA: 0x001B389A File Offset: 0x001B1A9A
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

		// Token: 0x0600B680 RID: 46720 RVA: 0x001B38CB File Offset: 0x001B1ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B681 RID: 46721 RVA: 0x001B38D4 File Offset: 0x001B1AD4
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

		// Token: 0x040050CC RID: 20684
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050CD RID: 20685
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040050CE RID: 20686
		private ErrorCode errorCode_;
	}
}
