using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AA RID: 426
	[NetMessage(EMessageId.BlackCoastThemeTaskRewardResponse)]
	public sealed class BlackCoastThemeTaskRewardResponse : IMessage<BlackCoastThemeTaskRewardResponse>, IMessage, IEquatable<BlackCoastThemeTaskRewardResponse>, IDeepCloneable<BlackCoastThemeTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060031E1 RID: 12769 RVA: 0x0007EEC8 File Offset: 0x0007D0C8
		[NullableContext(1)]
		public static BlackCoastThemeTaskRewardResponse Create()
		{
			return new BlackCoastThemeTaskRewardResponse();
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060031E2 RID: 12770 RVA: 0x0007EECF File Offset: 0x0007D0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x0007EED2 File Offset: 0x0007D0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x0007EED9 File Offset: 0x0007D0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardResponse()
		{
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x0007EEE1 File Offset: 0x0007D0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardResponse(BlackCoastThemeTaskRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x0007EF06 File Offset: 0x0007D106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeTaskRewardResponse Clone()
		{
			return new BlackCoastThemeTaskRewardResponse(this);
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x0007EF0E File Offset: 0x0007D10E
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x0007EF16 File Offset: 0x0007D116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x0007EF1F File Offset: 0x0007D11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeTaskRewardResponse);
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x0007EF2D File Offset: 0x0007D12D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeTaskRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x0007EF5C File Offset: 0x0007D15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x0007EFA1 File Offset: 0x0007D1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x0007EFAE File Offset: 0x0007D1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x0007EFB7 File Offset: 0x0007D1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x0007EFEC File Offset: 0x0007D1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x0007F02A File Offset: 0x0007D22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackCoastThemeTaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x0007F05B File Offset: 0x0007D25B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x0007F064 File Offset: 0x0007D264
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002952 RID: 10578
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002953 RID: 10579
		public const int ErrorFieldNumber = 2;

		// Token: 0x04002954 RID: 10580
		private ErrorCode error_;
	}
}
