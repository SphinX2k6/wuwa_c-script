using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000168 RID: 360
	[NetMessage(EMessageId.BathPhotoResponse)]
	public sealed class BathPhotoResponse : IMessage<BathPhotoResponse>, IMessage, IEquatable<BathPhotoResponse>, IDeepCloneable<BathPhotoResponse>, IBufferMessage
	{
		// Token: 0x06002CEE RID: 11502 RVA: 0x00074D8E File Offset: 0x00072F8E
		[NullableContext(1)]
		public static BathPhotoResponse Create()
		{
			return new BathPhotoResponse();
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x00074D95 File Offset: 0x00072F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x00074D98 File Offset: 0x00072F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BathPhotoResponse.Descriptor;
			}
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00074D9F File Offset: 0x00072F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoResponse()
		{
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00074DA7 File Offset: 0x00072FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoResponse(BathPhotoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x00074DCC File Offset: 0x00072FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoResponse Clone()
		{
			return new BathPhotoResponse(this);
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x00074DD4 File Offset: 0x00072FD4
		// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x00074DDC File Offset: 0x00072FDC
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

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00074DE5 File Offset: 0x00072FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BathPhotoResponse);
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00074DF3 File Offset: 0x00072FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BathPhotoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00074E24 File Offset: 0x00073024
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

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00074E69 File Offset: 0x00073069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x00074E76 File Offset: 0x00073076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00074E7F File Offset: 0x0007307F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00074EB4 File Offset: 0x000730B4
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

		// Token: 0x06002CFD RID: 11517 RVA: 0x00074EF2 File Offset: 0x000730F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BathPhotoResponse other)
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

		// Token: 0x06002CFE RID: 11518 RVA: 0x00074F23 File Offset: 0x00073123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x00074F2C File Offset: 0x0007312C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400286A RID: 10346
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400286B RID: 10347
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400286C RID: 10348
		private ErrorCode errorCode_;
	}
}
