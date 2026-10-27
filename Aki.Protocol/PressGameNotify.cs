using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD5 RID: 3541
	[NetMessage(EMessageId.PressGameNotify)]
	public sealed class PressGameNotify : IMessage<PressGameNotify>, IMessage, IEquatable<PressGameNotify>, IDeepCloneable<PressGameNotify>, IBufferMessage
	{
		// Token: 0x060130F7 RID: 78071 RVA: 0x002C7194 File Offset: 0x002C5394
		[NullableContext(1)]
		public static PressGameNotify Create()
		{
			return new PressGameNotify();
		}

		// Token: 0x17003F3F RID: 16191
		// (get) Token: 0x060130F8 RID: 78072 RVA: 0x002C719B File Offset: 0x002C539B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F40 RID: 16192
		// (get) Token: 0x060130F9 RID: 78073 RVA: 0x002C719E File Offset: 0x002C539E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressGameNotify.Descriptor;
			}
		}

		// Token: 0x060130FA RID: 78074 RVA: 0x002C71A5 File Offset: 0x002C53A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameNotify()
		{
		}

		// Token: 0x060130FB RID: 78075 RVA: 0x002C71B8 File Offset: 0x002C53B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameNotify(PressGameNotify other) : this()
		{
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060130FC RID: 78076 RVA: 0x002C71DD File Offset: 0x002C53DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameNotify Clone()
		{
			return new PressGameNotify(this);
		}

		// Token: 0x17003F41 RID: 16193
		// (get) Token: 0x060130FD RID: 78077 RVA: 0x002C71E5 File Offset: 0x002C53E5
		// (set) Token: 0x060130FE RID: 78078 RVA: 0x002C71ED File Offset: 0x002C53ED
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

		// Token: 0x060130FF RID: 78079 RVA: 0x002C7200 File Offset: 0x002C5400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressGameNotify);
		}

		// Token: 0x06013100 RID: 78080 RVA: 0x002C720E File Offset: 0x002C540E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressGameNotify other)
		{
			return other != null && (other == this || (!(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013101 RID: 78081 RVA: 0x002C7244 File Offset: 0x002C5444
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

		// Token: 0x06013102 RID: 78082 RVA: 0x002C7285 File Offset: 0x002C5485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013103 RID: 78083 RVA: 0x002C7292 File Offset: 0x002C5492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013104 RID: 78084 RVA: 0x002C729B File Offset: 0x002C549B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Payload.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteBytes(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013105 RID: 78085 RVA: 0x002C72D4 File Offset: 0x002C54D4
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

		// Token: 0x06013106 RID: 78086 RVA: 0x002C7317 File Offset: 0x002C5517
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

		// Token: 0x06013107 RID: 78087 RVA: 0x002C734D File Offset: 0x002C554D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013108 RID: 78088 RVA: 0x002C7358 File Offset: 0x002C5558
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Payload = input.ReadBytes();
				}
			}
		}

		// Token: 0x0400759E RID: 30110
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400759F RID: 30111
		public const int PayloadFieldNumber = 13;

		// Token: 0x040075A0 RID: 30112
		private ByteString payload_ = ByteString.Empty;
	}
}
