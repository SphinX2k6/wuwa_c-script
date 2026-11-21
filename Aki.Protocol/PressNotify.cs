using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC8 RID: 3528
	[NetMessage(EMessageId.PressNotify)]
	public sealed class PressNotify : IMessage<PressNotify>, IMessage, IEquatable<PressNotify>, IDeepCloneable<PressNotify>, IBufferMessage
	{
		// Token: 0x0601304C RID: 77900 RVA: 0x002C6251 File Offset: 0x002C4451
		[NullableContext(1)]
		public static PressNotify Create()
		{
			return new PressNotify();
		}

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x0601304D RID: 77901 RVA: 0x002C6258 File Offset: 0x002C4458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x0601304E RID: 77902 RVA: 0x002C625B File Offset: 0x002C445B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressNotify.Descriptor;
			}
		}

		// Token: 0x0601304F RID: 77903 RVA: 0x002C6262 File Offset: 0x002C4462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressNotify()
		{
		}

		// Token: 0x06013050 RID: 77904 RVA: 0x002C6275 File Offset: 0x002C4475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressNotify(PressNotify other) : this()
		{
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013051 RID: 77905 RVA: 0x002C629A File Offset: 0x002C449A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressNotify Clone()
		{
			return new PressNotify(this);
		}

		// Token: 0x17003F22 RID: 16162
		// (get) Token: 0x06013052 RID: 77906 RVA: 0x002C62A2 File Offset: 0x002C44A2
		// (set) Token: 0x06013053 RID: 77907 RVA: 0x002C62AA File Offset: 0x002C44AA
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

		// Token: 0x06013054 RID: 77908 RVA: 0x002C62BD File Offset: 0x002C44BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressNotify);
		}

		// Token: 0x06013055 RID: 77909 RVA: 0x002C62CB File Offset: 0x002C44CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressNotify other)
		{
			return other != null && (other == this || (!(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013056 RID: 77910 RVA: 0x002C6300 File Offset: 0x002C4500
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

		// Token: 0x06013057 RID: 77911 RVA: 0x002C6341 File Offset: 0x002C4541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013058 RID: 77912 RVA: 0x002C634E File Offset: 0x002C454E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013059 RID: 77913 RVA: 0x002C6357 File Offset: 0x002C4557
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

		// Token: 0x0601305A RID: 77914 RVA: 0x002C6390 File Offset: 0x002C4590
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

		// Token: 0x0601305B RID: 77915 RVA: 0x002C63D3 File Offset: 0x002C45D3
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

		// Token: 0x0601305C RID: 77916 RVA: 0x002C6409 File Offset: 0x002C4609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601305D RID: 77917 RVA: 0x002C6414 File Offset: 0x002C4614
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

		// Token: 0x040075D5 RID: 30165
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075D6 RID: 30166
		public const int PayloadFieldNumber = 15;

		// Token: 0x040075D7 RID: 30167
		private ByteString payload_ = ByteString.Empty;
	}
}
