using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000525 RID: 1317
	[NetMessage(EMessageId.FarmGoldLevelPlayResponse)]
	public sealed class FarmGoldLevelPlayResponse : IMessage<FarmGoldLevelPlayResponse>, IMessage, IEquatable<FarmGoldLevelPlayResponse>, IDeepCloneable<FarmGoldLevelPlayResponse>, IBufferMessage
	{
		// Token: 0x06007B94 RID: 31636 RVA: 0x0012BC24 File Offset: 0x00129E24
		[NullableContext(1)]
		public static FarmGoldLevelPlayResponse Create()
		{
			return new FarmGoldLevelPlayResponse();
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06007B95 RID: 31637 RVA: 0x0012BC2B File Offset: 0x00129E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06007B96 RID: 31638 RVA: 0x0012BC2E File Offset: 0x00129E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelPlayResponse.Descriptor;
			}
		}

		// Token: 0x06007B97 RID: 31639 RVA: 0x0012BC35 File Offset: 0x00129E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayResponse()
		{
		}

		// Token: 0x06007B98 RID: 31640 RVA: 0x0012BC3D File Offset: 0x00129E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayResponse(FarmGoldLevelPlayResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B99 RID: 31641 RVA: 0x0012BC62 File Offset: 0x00129E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayResponse Clone()
		{
			return new FarmGoldLevelPlayResponse(this);
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06007B9A RID: 31642 RVA: 0x0012BC6A File Offset: 0x00129E6A
		// (set) Token: 0x06007B9B RID: 31643 RVA: 0x0012BC72 File Offset: 0x00129E72
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

		// Token: 0x06007B9C RID: 31644 RVA: 0x0012BC7B File Offset: 0x00129E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelPlayResponse);
		}

		// Token: 0x06007B9D RID: 31645 RVA: 0x0012BC89 File Offset: 0x00129E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelPlayResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B9E RID: 31646 RVA: 0x0012BCB8 File Offset: 0x00129EB8
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

		// Token: 0x06007B9F RID: 31647 RVA: 0x0012BCFD File Offset: 0x00129EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007BA0 RID: 31648 RVA: 0x0012BD0A File Offset: 0x00129F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x0012BD13 File Offset: 0x00129F13
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

		// Token: 0x06007BA2 RID: 31650 RVA: 0x0012BD44 File Offset: 0x00129F44
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

		// Token: 0x06007BA3 RID: 31651 RVA: 0x0012BD82 File Offset: 0x00129F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelPlayResponse other)
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

		// Token: 0x06007BA4 RID: 31652 RVA: 0x0012BDB3 File Offset: 0x00129FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x0012BDBC File Offset: 0x00129FBC
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

		// Token: 0x04003F38 RID: 16184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F39 RID: 16185
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04003F3A RID: 16186
		private ErrorCode errorCode_;
	}
}
