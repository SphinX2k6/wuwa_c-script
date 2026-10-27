using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDA RID: 3546
	[NetMessage(EMessageId.PressResponse)]
	public sealed class PressResponse : IMessage<PressResponse>, IMessage, IEquatable<PressResponse>, IDeepCloneable<PressResponse>, IBufferMessage
	{
		// Token: 0x06013159 RID: 78169 RVA: 0x002C7E8F File Offset: 0x002C608F
		[NullableContext(1)]
		public static PressResponse Create()
		{
			return new PressResponse();
		}

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x0601315A RID: 78170 RVA: 0x002C7E96 File Offset: 0x002C6096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F53 RID: 16211
		// (get) Token: 0x0601315B RID: 78171 RVA: 0x002C7E99 File Offset: 0x002C6099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressResponse.Descriptor;
			}
		}

		// Token: 0x0601315C RID: 78172 RVA: 0x002C7EA0 File Offset: 0x002C60A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressResponse()
		{
		}

		// Token: 0x0601315D RID: 78173 RVA: 0x002C7EB3 File Offset: 0x002C60B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressResponse(PressResponse other) : this()
		{
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601315E RID: 78174 RVA: 0x002C7ED8 File Offset: 0x002C60D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressResponse Clone()
		{
			return new PressResponse(this);
		}

		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x0601315F RID: 78175 RVA: 0x002C7EE0 File Offset: 0x002C60E0
		// (set) Token: 0x06013160 RID: 78176 RVA: 0x002C7EE8 File Offset: 0x002C60E8
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

		// Token: 0x06013161 RID: 78177 RVA: 0x002C7EFB File Offset: 0x002C60FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressResponse);
		}

		// Token: 0x06013162 RID: 78178 RVA: 0x002C7F09 File Offset: 0x002C6109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressResponse other)
		{
			return other != null && (other == this || (!(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013163 RID: 78179 RVA: 0x002C7F3C File Offset: 0x002C613C
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

		// Token: 0x06013164 RID: 78180 RVA: 0x002C7F7D File Offset: 0x002C617D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013165 RID: 78181 RVA: 0x002C7F8A File Offset: 0x002C618A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013166 RID: 78182 RVA: 0x002C7F93 File Offset: 0x002C6193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Payload.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteBytes(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013167 RID: 78183 RVA: 0x002C7FCC File Offset: 0x002C61CC
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

		// Token: 0x06013168 RID: 78184 RVA: 0x002C800F File Offset: 0x002C620F
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

		// Token: 0x06013169 RID: 78185 RVA: 0x002C8045 File Offset: 0x002C6245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601316A RID: 78186 RVA: 0x002C8050 File Offset: 0x002C6250
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Payload = input.ReadBytes();
				}
			}
		}

		// Token: 0x040075B5 RID: 30133
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075B6 RID: 30134
		public const int PayloadFieldNumber = 10;

		// Token: 0x040075B7 RID: 30135
		private ByteString payload_ = ByteString.Empty;
	}
}
