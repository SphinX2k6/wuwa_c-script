using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145E RID: 5214
	[NetMessage(EMessageId.TrapDefenseUseItemResponse)]
	public sealed class TrapDefenseUseItemResponse : IMessage<TrapDefenseUseItemResponse>, IMessage, IEquatable<TrapDefenseUseItemResponse>, IDeepCloneable<TrapDefenseUseItemResponse>, IBufferMessage
	{
		// Token: 0x0601B9B2 RID: 113074 RVA: 0x003FED95 File Offset: 0x003FCF95
		[NullableContext(1)]
		public static TrapDefenseUseItemResponse Create()
		{
			return new TrapDefenseUseItemResponse();
		}

		// Token: 0x17005D13 RID: 23827
		// (get) Token: 0x0601B9B3 RID: 113075 RVA: 0x003FED9C File Offset: 0x003FCF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D14 RID: 23828
		// (get) Token: 0x0601B9B4 RID: 113076 RVA: 0x003FED9F File Offset: 0x003FCF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseUseItemResponse.Descriptor;
			}
		}

		// Token: 0x0601B9B5 RID: 113077 RVA: 0x003FEDA6 File Offset: 0x003FCFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemResponse()
		{
		}

		// Token: 0x0601B9B6 RID: 113078 RVA: 0x003FEDAE File Offset: 0x003FCFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemResponse(TrapDefenseUseItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B9B7 RID: 113079 RVA: 0x003FEDD3 File Offset: 0x003FCFD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemResponse Clone()
		{
			return new TrapDefenseUseItemResponse(this);
		}

		// Token: 0x17005D15 RID: 23829
		// (get) Token: 0x0601B9B8 RID: 113080 RVA: 0x003FEDDB File Offset: 0x003FCFDB
		// (set) Token: 0x0601B9B9 RID: 113081 RVA: 0x003FEDE3 File Offset: 0x003FCFE3
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

		// Token: 0x0601B9BA RID: 113082 RVA: 0x003FEDEC File Offset: 0x003FCFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseUseItemResponse);
		}

		// Token: 0x0601B9BB RID: 113083 RVA: 0x003FEDFA File Offset: 0x003FCFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseUseItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B9BC RID: 113084 RVA: 0x003FEE28 File Offset: 0x003FD028
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

		// Token: 0x0601B9BD RID: 113085 RVA: 0x003FEE6D File Offset: 0x003FD06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B9BE RID: 113086 RVA: 0x003FEE7A File Offset: 0x003FD07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B9BF RID: 113087 RVA: 0x003FEE83 File Offset: 0x003FD083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B9C0 RID: 113088 RVA: 0x003FEEB8 File Offset: 0x003FD0B8
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

		// Token: 0x0601B9C1 RID: 113089 RVA: 0x003FEEF6 File Offset: 0x003FD0F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseUseItemResponse other)
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

		// Token: 0x0601B9C2 RID: 113090 RVA: 0x003FEF27 File Offset: 0x003FD127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B9C3 RID: 113091 RVA: 0x003FEF30 File Offset: 0x003FD130
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009F15 RID: 40725
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F16 RID: 40726
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009F17 RID: 40727
		private ErrorCode errorCode_;
	}
}
