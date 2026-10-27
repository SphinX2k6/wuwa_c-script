using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001283 RID: 4739
	[NetMessage(EMessageId.SpringSignPhotoRewardResponse)]
	public sealed class SpringSignPhotoRewardResponse : IMessage<SpringSignPhotoRewardResponse>, IMessage, IEquatable<SpringSignPhotoRewardResponse>, IDeepCloneable<SpringSignPhotoRewardResponse>, IBufferMessage
	{
		// Token: 0x060193D1 RID: 103377 RVA: 0x003ABDDA File Offset: 0x003A9FDA
		[NullableContext(1)]
		public static SpringSignPhotoRewardResponse Create()
		{
			return new SpringSignPhotoRewardResponse();
		}

		// Token: 0x17005524 RID: 21796
		// (get) Token: 0x060193D2 RID: 103378 RVA: 0x003ABDE1 File Offset: 0x003A9FE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005525 RID: 21797
		// (get) Token: 0x060193D3 RID: 103379 RVA: 0x003ABDE4 File Offset: 0x003A9FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignPhotoRewardResponse.Descriptor;
			}
		}

		// Token: 0x060193D4 RID: 103380 RVA: 0x003ABDEB File Offset: 0x003A9FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardResponse()
		{
		}

		// Token: 0x060193D5 RID: 103381 RVA: 0x003ABDF3 File Offset: 0x003A9FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardResponse(SpringSignPhotoRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060193D6 RID: 103382 RVA: 0x003ABE18 File Offset: 0x003AA018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignPhotoRewardResponse Clone()
		{
			return new SpringSignPhotoRewardResponse(this);
		}

		// Token: 0x17005526 RID: 21798
		// (get) Token: 0x060193D7 RID: 103383 RVA: 0x003ABE20 File Offset: 0x003AA020
		// (set) Token: 0x060193D8 RID: 103384 RVA: 0x003ABE28 File Offset: 0x003AA028
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

		// Token: 0x060193D9 RID: 103385 RVA: 0x003ABE31 File Offset: 0x003AA031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignPhotoRewardResponse);
		}

		// Token: 0x060193DA RID: 103386 RVA: 0x003ABE3F File Offset: 0x003AA03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignPhotoRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060193DB RID: 103387 RVA: 0x003ABE70 File Offset: 0x003AA070
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

		// Token: 0x060193DC RID: 103388 RVA: 0x003ABEB5 File Offset: 0x003AA0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060193DD RID: 103389 RVA: 0x003ABEC2 File Offset: 0x003AA0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060193DE RID: 103390 RVA: 0x003ABECB File Offset: 0x003AA0CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060193DF RID: 103391 RVA: 0x003ABF00 File Offset: 0x003AA100
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

		// Token: 0x060193E0 RID: 103392 RVA: 0x003ABF3E File Offset: 0x003AA13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignPhotoRewardResponse other)
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

		// Token: 0x060193E1 RID: 103393 RVA: 0x003ABF6F File Offset: 0x003AA16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060193E2 RID: 103394 RVA: 0x003ABF78 File Offset: 0x003AA178
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400947A RID: 38010
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400947B RID: 38011
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400947C RID: 38012
		private ErrorCode errorCode_;
	}
}
