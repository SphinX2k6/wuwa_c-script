using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F2 RID: 5362
	[NetMessage(EMessageId.UiGamePlayResponse)]
	public sealed class UiGamePlayResponse : IMessage<UiGamePlayResponse>, IMessage, IEquatable<UiGamePlayResponse>, IDeepCloneable<UiGamePlayResponse>, IBufferMessage
	{
		// Token: 0x0601C6DC RID: 116444 RVA: 0x0041FAD6 File Offset: 0x0041DCD6
		[NullableContext(1)]
		public static UiGamePlayResponse Create()
		{
			return new UiGamePlayResponse();
		}

		// Token: 0x17006036 RID: 24630
		// (get) Token: 0x0601C6DD RID: 116445 RVA: 0x0041FADD File Offset: 0x0041DCDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006037 RID: 24631
		// (get) Token: 0x0601C6DE RID: 116446 RVA: 0x0041FAE0 File Offset: 0x0041DCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UiGamePlayResponse.Descriptor;
			}
		}

		// Token: 0x0601C6DF RID: 116447 RVA: 0x0041FAE7 File Offset: 0x0041DCE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayResponse()
		{
		}

		// Token: 0x0601C6E0 RID: 116448 RVA: 0x0041FAEF File Offset: 0x0041DCEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayResponse(UiGamePlayResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C6E1 RID: 116449 RVA: 0x0041FB14 File Offset: 0x0041DD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayResponse Clone()
		{
			return new UiGamePlayResponse(this);
		}

		// Token: 0x17006038 RID: 24632
		// (get) Token: 0x0601C6E2 RID: 116450 RVA: 0x0041FB1C File Offset: 0x0041DD1C
		// (set) Token: 0x0601C6E3 RID: 116451 RVA: 0x0041FB24 File Offset: 0x0041DD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0601C6E4 RID: 116452 RVA: 0x0041FB2D File Offset: 0x0041DD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UiGamePlayResponse);
		}

		// Token: 0x0601C6E5 RID: 116453 RVA: 0x0041FB3B File Offset: 0x0041DD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UiGamePlayResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C6E6 RID: 116454 RVA: 0x0041FB6C File Offset: 0x0041DD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C6E7 RID: 116455 RVA: 0x0041FBB1 File Offset: 0x0041DDB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C6E8 RID: 116456 RVA: 0x0041FBBE File Offset: 0x0041DDBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C6E9 RID: 116457 RVA: 0x0041FBC7 File Offset: 0x0041DDC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C6EA RID: 116458 RVA: 0x0041FBFC File Offset: 0x0041DDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C6EB RID: 116459 RVA: 0x0041FC3A File Offset: 0x0041DE3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UiGamePlayResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C6EC RID: 116460 RVA: 0x0041FC6B File Offset: 0x0041DE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C6ED RID: 116461 RVA: 0x0041FC74 File Offset: 0x0041DE74
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A423 RID: 42019
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A424 RID: 42020
		public const int ErrorIdFieldNumber = 2;

		// Token: 0x0400A425 RID: 42021
		private ErrorCode errorId_;
	}
}
