using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC5 RID: 3525
	[NetMessage(EMessageId.PressGameNotify)]
	public sealed class PressGameNotify : IMessage<PressGameNotify>, IMessage, IEquatable<PressGameNotify>, IDeepCloneable<PressGameNotify>, IBufferMessage
	{
		// Token: 0x06013012 RID: 77842 RVA: 0x002C5AD0 File Offset: 0x002C3CD0
		[NullableContext(1)]
		public static PressGameNotify Create()
		{
			return new PressGameNotify();
		}

		// Token: 0x17003F15 RID: 16149
		// (get) Token: 0x06013013 RID: 77843 RVA: 0x002C5AD7 File Offset: 0x002C3CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F16 RID: 16150
		// (get) Token: 0x06013014 RID: 77844 RVA: 0x002C5ADA File Offset: 0x002C3CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressGameNotify.Descriptor;
			}
		}

		// Token: 0x06013015 RID: 77845 RVA: 0x002C5AE1 File Offset: 0x002C3CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameNotify()
		{
		}

		// Token: 0x06013016 RID: 77846 RVA: 0x002C5AF4 File Offset: 0x002C3CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameNotify(PressGameNotify other) : this()
		{
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013017 RID: 77847 RVA: 0x002C5B19 File Offset: 0x002C3D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameNotify Clone()
		{
			return new PressGameNotify(this);
		}

		// Token: 0x17003F17 RID: 16151
		// (get) Token: 0x06013018 RID: 77848 RVA: 0x002C5B21 File Offset: 0x002C3D21
		// (set) Token: 0x06013019 RID: 77849 RVA: 0x002C5B29 File Offset: 0x002C3D29
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

		// Token: 0x0601301A RID: 77850 RVA: 0x002C5B3C File Offset: 0x002C3D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressGameNotify);
		}

		// Token: 0x0601301B RID: 77851 RVA: 0x002C5B4A File Offset: 0x002C3D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressGameNotify other)
		{
			return other != null && (other == this || (!(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601301C RID: 77852 RVA: 0x002C5B80 File Offset: 0x002C3D80
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

		// Token: 0x0601301D RID: 77853 RVA: 0x002C5BC1 File Offset: 0x002C3DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601301E RID: 77854 RVA: 0x002C5BCE File Offset: 0x002C3DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601301F RID: 77855 RVA: 0x002C5BD7 File Offset: 0x002C3DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Payload.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteBytes(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013020 RID: 77856 RVA: 0x002C5C10 File Offset: 0x002C3E10
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

		// Token: 0x06013021 RID: 77857 RVA: 0x002C5C53 File Offset: 0x002C3E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PressGameNotify other)
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

		// Token: 0x06013022 RID: 77858 RVA: 0x002C5C89 File Offset: 0x002C3E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013023 RID: 77859 RVA: 0x002C5C94 File Offset: 0x002C3E94
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Payload = input.ReadBytes();
				}
			}
		}

		// Token: 0x040075C8 RID: 30152
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075C9 RID: 30153
		public const int PayloadFieldNumber = 15;

		// Token: 0x040075CA RID: 30154
		private ByteString payload_ = ByteString.Empty;
	}
}
