using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000418 RID: 1048
	[NetMessage(EMessageId.DrownResponse)]
	public sealed class DrownResponse : IMessage<DrownResponse>, IMessage, IEquatable<DrownResponse>, IDeepCloneable<DrownResponse>, IBufferMessage
	{
		// Token: 0x060064BA RID: 25786 RVA: 0x000F1936 File Offset: 0x000EFB36
		[NullableContext(1)]
		public static DrownResponse Create()
		{
			return new DrownResponse();
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x060064BB RID: 25787 RVA: 0x000F193D File Offset: 0x000EFB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x060064BC RID: 25788 RVA: 0x000F1940 File Offset: 0x000EFB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownResponse.Descriptor;
			}
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x000F1947 File Offset: 0x000EFB47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownResponse()
		{
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x000F194F File Offset: 0x000EFB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownResponse(DrownResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x000F1974 File Offset: 0x000EFB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownResponse Clone()
		{
			return new DrownResponse(this);
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x060064C0 RID: 25792 RVA: 0x000F197C File Offset: 0x000EFB7C
		// (set) Token: 0x060064C1 RID: 25793 RVA: 0x000F1984 File Offset: 0x000EFB84
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

		// Token: 0x060064C2 RID: 25794 RVA: 0x000F198D File Offset: 0x000EFB8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownResponse);
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x000F199B File Offset: 0x000EFB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x000F19CC File Offset: 0x000EFBCC
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

		// Token: 0x060064C5 RID: 25797 RVA: 0x000F1A11 File Offset: 0x000EFC11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x000F1A1E File Offset: 0x000EFC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x000F1A27 File Offset: 0x000EFC27
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

		// Token: 0x060064C8 RID: 25800 RVA: 0x000F1A5C File Offset: 0x000EFC5C
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

		// Token: 0x060064C9 RID: 25801 RVA: 0x000F1A9A File Offset: 0x000EFC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownResponse other)
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

		// Token: 0x060064CA RID: 25802 RVA: 0x000F1ACB File Offset: 0x000EFCCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x000F1AD4 File Offset: 0x000EFCD4
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

		// Token: 0x0400386D RID: 14445
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400386E RID: 14446
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400386F RID: 14447
		private ErrorCode errorCode_;
	}
}
