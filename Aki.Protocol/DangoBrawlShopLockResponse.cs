using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000373 RID: 883
	[NetMessage(EMessageId.DangoBrawlShopLockResponse)]
	public sealed class DangoBrawlShopLockResponse : IMessage<DangoBrawlShopLockResponse>, IMessage, IEquatable<DangoBrawlShopLockResponse>, IDeepCloneable<DangoBrawlShopLockResponse>, IBufferMessage
	{
		// Token: 0x060057CA RID: 22474 RVA: 0x000D6604 File Offset: 0x000D4804
		[NullableContext(1)]
		public static DangoBrawlShopLockResponse Create()
		{
			return new DangoBrawlShopLockResponse();
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x060057CB RID: 22475 RVA: 0x000D660B File Offset: 0x000D480B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x060057CC RID: 22476 RVA: 0x000D660E File Offset: 0x000D480E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopLockResponse.Descriptor;
			}
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x000D6615 File Offset: 0x000D4815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockResponse()
		{
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x000D661D File Offset: 0x000D481D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockResponse(DangoBrawlShopLockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x000D6642 File Offset: 0x000D4842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockResponse Clone()
		{
			return new DangoBrawlShopLockResponse(this);
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x060057D0 RID: 22480 RVA: 0x000D664A File Offset: 0x000D484A
		// (set) Token: 0x060057D1 RID: 22481 RVA: 0x000D6652 File Offset: 0x000D4852
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

		// Token: 0x060057D2 RID: 22482 RVA: 0x000D665B File Offset: 0x000D485B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopLockResponse);
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x000D6669 File Offset: 0x000D4869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopLockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x000D6698 File Offset: 0x000D4898
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

		// Token: 0x060057D5 RID: 22485 RVA: 0x000D66DD File Offset: 0x000D48DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x000D66EA File Offset: 0x000D48EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x000D66F3 File Offset: 0x000D48F3
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

		// Token: 0x060057D8 RID: 22488 RVA: 0x000D6728 File Offset: 0x000D4928
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

		// Token: 0x060057D9 RID: 22489 RVA: 0x000D6766 File Offset: 0x000D4966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopLockResponse other)
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

		// Token: 0x060057DA RID: 22490 RVA: 0x000D6797 File Offset: 0x000D4997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x000D67A0 File Offset: 0x000D49A0
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

		// Token: 0x040034EE RID: 13550
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034EF RID: 13551
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040034F0 RID: 13552
		private ErrorCode errorCode_;
	}
}
