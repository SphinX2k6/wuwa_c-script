using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E8 RID: 232
	[NetMessage(EMessageId.AnimalDropResponse)]
	public sealed class AnimalDropResponse : IMessage<AnimalDropResponse>, IMessage, IEquatable<AnimalDropResponse>, IDeepCloneable<AnimalDropResponse>, IBufferMessage
	{
		// Token: 0x0600220B RID: 8715 RVA: 0x0005AF2D File Offset: 0x0005912D
		[NullableContext(1)]
		public static AnimalDropResponse Create()
		{
			return new AnimalDropResponse();
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x0005AF34 File Offset: 0x00059134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x0005AF37 File Offset: 0x00059137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDropResponse.Descriptor;
			}
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x0005AF3E File Offset: 0x0005913E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropResponse()
		{
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x0005AF46 File Offset: 0x00059146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropResponse(AnimalDropResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0005AF6B File Offset: 0x0005916B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropResponse Clone()
		{
			return new AnimalDropResponse(this);
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x0005AF73 File Offset: 0x00059173
		// (set) Token: 0x06002212 RID: 8722 RVA: 0x0005AF7B File Offset: 0x0005917B
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

		// Token: 0x06002213 RID: 8723 RVA: 0x0005AF84 File Offset: 0x00059184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDropResponse);
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x0005AF92 File Offset: 0x00059192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDropResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0005AFC0 File Offset: 0x000591C0
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

		// Token: 0x06002216 RID: 8726 RVA: 0x0005B005 File Offset: 0x00059205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0005B012 File Offset: 0x00059212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0005B01B File Offset: 0x0005921B
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

		// Token: 0x06002219 RID: 8729 RVA: 0x0005B050 File Offset: 0x00059250
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

		// Token: 0x0600221A RID: 8730 RVA: 0x0005B08E File Offset: 0x0005928E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDropResponse other)
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

		// Token: 0x0600221B RID: 8731 RVA: 0x0005B0BF File Offset: 0x000592BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0005B0C8 File Offset: 0x000592C8
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

		// Token: 0x040024B0 RID: 9392
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024B1 RID: 9393
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040024B2 RID: 9394
		private ErrorCode errorCode_;
	}
}
