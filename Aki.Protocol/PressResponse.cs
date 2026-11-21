using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCA RID: 3530
	[NetMessage(EMessageId.PressResponse)]
	public sealed class PressResponse : IMessage<PressResponse>, IMessage, IEquatable<PressResponse>, IDeepCloneable<PressResponse>, IBufferMessage
	{
		// Token: 0x06013074 RID: 77940 RVA: 0x002C67CB File Offset: 0x002C49CB
		[NullableContext(1)]
		public static PressResponse Create()
		{
			return new PressResponse();
		}

		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x06013075 RID: 77941 RVA: 0x002C67D2 File Offset: 0x002C49D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F29 RID: 16169
		// (get) Token: 0x06013076 RID: 77942 RVA: 0x002C67D5 File Offset: 0x002C49D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressResponse.Descriptor;
			}
		}

		// Token: 0x06013077 RID: 77943 RVA: 0x002C67DC File Offset: 0x002C49DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressResponse()
		{
		}

		// Token: 0x06013078 RID: 77944 RVA: 0x002C67EF File Offset: 0x002C49EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressResponse(PressResponse other) : this()
		{
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013079 RID: 77945 RVA: 0x002C6814 File Offset: 0x002C4A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressResponse Clone()
		{
			return new PressResponse(this);
		}

		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x0601307A RID: 77946 RVA: 0x002C681C File Offset: 0x002C4A1C
		// (set) Token: 0x0601307B RID: 77947 RVA: 0x002C6824 File Offset: 0x002C4A24
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

		// Token: 0x0601307C RID: 77948 RVA: 0x002C6837 File Offset: 0x002C4A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressResponse);
		}

		// Token: 0x0601307D RID: 77949 RVA: 0x002C6845 File Offset: 0x002C4A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressResponse other)
		{
			return other != null && (other == this || (!(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601307E RID: 77950 RVA: 0x002C6878 File Offset: 0x002C4A78
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

		// Token: 0x0601307F RID: 77951 RVA: 0x002C68B9 File Offset: 0x002C4AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013080 RID: 77952 RVA: 0x002C68C6 File Offset: 0x002C4AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013081 RID: 77953 RVA: 0x002C68CF File Offset: 0x002C4ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Payload.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteBytes(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013082 RID: 77954 RVA: 0x002C6908 File Offset: 0x002C4B08
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

		// Token: 0x06013083 RID: 77955 RVA: 0x002C694B File Offset: 0x002C4B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PressResponse other)
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

		// Token: 0x06013084 RID: 77956 RVA: 0x002C6981 File Offset: 0x002C4B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013085 RID: 77957 RVA: 0x002C698C File Offset: 0x002C4B8C
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Payload = input.ReadBytes();
				}
			}
		}

		// Token: 0x040075DF RID: 30175
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075E0 RID: 30176
		public const int PayloadFieldNumber = 6;

		// Token: 0x040075E1 RID: 30177
		private ByteString payload_ = ByteString.Empty;
	}
}
