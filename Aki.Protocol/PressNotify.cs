using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD8 RID: 3544
	[NetMessage(EMessageId.PressNotify)]
	public sealed class PressNotify : IMessage<PressNotify>, IMessage, IEquatable<PressNotify>, IDeepCloneable<PressNotify>, IBufferMessage
	{
		// Token: 0x06013131 RID: 78129 RVA: 0x002C7915 File Offset: 0x002C5B15
		[NullableContext(1)]
		public static PressNotify Create()
		{
			return new PressNotify();
		}

		// Token: 0x17003F4A RID: 16202
		// (get) Token: 0x06013132 RID: 78130 RVA: 0x002C791C File Offset: 0x002C5B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x06013133 RID: 78131 RVA: 0x002C791F File Offset: 0x002C5B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressNotify.Descriptor;
			}
		}

		// Token: 0x06013134 RID: 78132 RVA: 0x002C7926 File Offset: 0x002C5B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressNotify()
		{
		}

		// Token: 0x06013135 RID: 78133 RVA: 0x002C7939 File Offset: 0x002C5B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressNotify(PressNotify other) : this()
		{
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013136 RID: 78134 RVA: 0x002C795E File Offset: 0x002C5B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressNotify Clone()
		{
			return new PressNotify(this);
		}

		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x06013137 RID: 78135 RVA: 0x002C7966 File Offset: 0x002C5B66
		// (set) Token: 0x06013138 RID: 78136 RVA: 0x002C796E File Offset: 0x002C5B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString Payload
		{
			get
			{
				return this.payload_;
			}
			set
			{
				this.payload_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x06013139 RID: 78137 RVA: 0x002C7981 File Offset: 0x002C5B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressNotify);
		}

		// Token: 0x0601313A RID: 78138 RVA: 0x002C798F File Offset: 0x002C5B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressNotify other)
		{
			return other != null && (other == this || (!(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601313B RID: 78139 RVA: 0x002C79C4 File Offset: 0x002C5BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Payload.Length != 0)
			{
				num ^= this.Payload.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601313C RID: 78140 RVA: 0x002C7A05 File Offset: 0x002C5C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601313D RID: 78141 RVA: 0x002C7A12 File Offset: 0x002C5C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601313E RID: 78142 RVA: 0x002C7A1B File Offset: 0x002C5C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Payload.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601313F RID: 78143 RVA: 0x002C7A54 File Offset: 0x002C5C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Payload.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Payload);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013140 RID: 78144 RVA: 0x002C7A97 File Offset: 0x002C5C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PressNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Payload.Length != 0)
			{
				this.Payload = other.Payload;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013141 RID: 78145 RVA: 0x002C7ACD File Offset: 0x002C5CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013142 RID: 78146 RVA: 0x002C7AD8 File Offset: 0x002C5CD8
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Payload = input.ReadBytes();
				}
			}
		}

		// Token: 0x040075AB RID: 30123
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075AC RID: 30124
		public const int PayloadFieldNumber = 7;

		// Token: 0x040075AD RID: 30125
		private ByteString payload_ = ByteString.Empty;
	}
}
