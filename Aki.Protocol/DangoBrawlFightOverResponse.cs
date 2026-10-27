using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035A RID: 858
	[NetMessage(EMessageId.DangoBrawlFightOverResponse)]
	public sealed class DangoBrawlFightOverResponse : IMessage<DangoBrawlFightOverResponse>, IMessage, IEquatable<DangoBrawlFightOverResponse>, IDeepCloneable<DangoBrawlFightOverResponse>, IBufferMessage
	{
		// Token: 0x060055B2 RID: 21938 RVA: 0x000D16A1 File Offset: 0x000CF8A1
		[NullableContext(1)]
		public static DangoBrawlFightOverResponse Create()
		{
			return new DangoBrawlFightOverResponse();
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x060055B3 RID: 21939 RVA: 0x000D16A8 File Offset: 0x000CF8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x060055B4 RID: 21940 RVA: 0x000D16AB File Offset: 0x000CF8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightOverResponse.Descriptor;
			}
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x000D16B2 File Offset: 0x000CF8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverResponse()
		{
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x000D16BA File Offset: 0x000CF8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverResponse(DangoBrawlFightOverResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x000D16DF File Offset: 0x000CF8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverResponse Clone()
		{
			return new DangoBrawlFightOverResponse(this);
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x060055B8 RID: 21944 RVA: 0x000D16E7 File Offset: 0x000CF8E7
		// (set) Token: 0x060055B9 RID: 21945 RVA: 0x000D16EF File Offset: 0x000CF8EF
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

		// Token: 0x060055BA RID: 21946 RVA: 0x000D16F8 File Offset: 0x000CF8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightOverResponse);
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x000D1706 File Offset: 0x000CF906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightOverResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x000D1734 File Offset: 0x000CF934
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

		// Token: 0x060055BD RID: 21949 RVA: 0x000D1779 File Offset: 0x000CF979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x000D1786 File Offset: 0x000CF986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x000D178F File Offset: 0x000CF98F
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

		// Token: 0x060055C0 RID: 21952 RVA: 0x000D17C4 File Offset: 0x000CF9C4
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

		// Token: 0x060055C1 RID: 21953 RVA: 0x000D1802 File Offset: 0x000CFA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightOverResponse other)
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

		// Token: 0x060055C2 RID: 21954 RVA: 0x000D1833 File Offset: 0x000CFA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x000D183C File Offset: 0x000CFA3C
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

		// Token: 0x0400343D RID: 13373
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400343E RID: 13374
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400343F RID: 13375
		private ErrorCode errorCode_;
	}
}
