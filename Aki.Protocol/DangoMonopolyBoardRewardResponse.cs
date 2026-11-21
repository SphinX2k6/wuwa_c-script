using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038B RID: 907
	[NetMessage(EMessageId.DangoMonopolyBoardRewardResponse)]
	public sealed class DangoMonopolyBoardRewardResponse : IMessage<DangoMonopolyBoardRewardResponse>, IMessage, IEquatable<DangoMonopolyBoardRewardResponse>, IDeepCloneable<DangoMonopolyBoardRewardResponse>, IBufferMessage
	{
		// Token: 0x060059F8 RID: 23032 RVA: 0x000DB758 File Offset: 0x000D9958
		[NullableContext(1)]
		public static DangoMonopolyBoardRewardResponse Create()
		{
			return new DangoMonopolyBoardRewardResponse();
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x060059F9 RID: 23033 RVA: 0x000DB75F File Offset: 0x000D995F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x060059FA RID: 23034 RVA: 0x000DB762 File Offset: 0x000D9962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyBoardRewardResponse.Descriptor;
			}
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x000DB769 File Offset: 0x000D9969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardResponse()
		{
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x000DB771 File Offset: 0x000D9971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardResponse(DangoMonopolyBoardRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x000DB796 File Offset: 0x000D9996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardResponse Clone()
		{
			return new DangoMonopolyBoardRewardResponse(this);
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x060059FE RID: 23038 RVA: 0x000DB79E File Offset: 0x000D999E
		// (set) Token: 0x060059FF RID: 23039 RVA: 0x000DB7A6 File Offset: 0x000D99A6
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

		// Token: 0x06005A00 RID: 23040 RVA: 0x000DB7AF File Offset: 0x000D99AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyBoardRewardResponse);
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x000DB7BD File Offset: 0x000D99BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyBoardRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x000DB7EC File Offset: 0x000D99EC
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

		// Token: 0x06005A03 RID: 23043 RVA: 0x000DB831 File Offset: 0x000D9A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x000DB83E File Offset: 0x000D9A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A05 RID: 23045 RVA: 0x000DB847 File Offset: 0x000D9A47
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

		// Token: 0x06005A06 RID: 23046 RVA: 0x000DB87C File Offset: 0x000D9A7C
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

		// Token: 0x06005A07 RID: 23047 RVA: 0x000DB8BA File Offset: 0x000D9ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyBoardRewardResponse other)
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

		// Token: 0x06005A08 RID: 23048 RVA: 0x000DB8EB File Offset: 0x000D9AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A09 RID: 23049 RVA: 0x000DB8F4 File Offset: 0x000D9AF4
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

		// Token: 0x040035E8 RID: 13800
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035E9 RID: 13801
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040035EA RID: 13802
		private ErrorCode errorCode_;
	}
}
