using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC7 RID: 3527
	[NetMessage(EMessageId.PressGameResponse)]
	public sealed class PressGameResponse : IMessage<PressGameResponse>, IMessage, IEquatable<PressGameResponse>, IDeepCloneable<PressGameResponse>, IBufferMessage
	{
		// Token: 0x0601303A RID: 77882 RVA: 0x002C604B File Offset: 0x002C424B
		[NullableContext(1)]
		public static PressGameResponse Create()
		{
			return new PressGameResponse();
		}

		// Token: 0x17003F1D RID: 16157
		// (get) Token: 0x0601303B RID: 77883 RVA: 0x002C6052 File Offset: 0x002C4252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x0601303C RID: 77884 RVA: 0x002C6055 File Offset: 0x002C4255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressGameResponse.Descriptor;
			}
		}

		// Token: 0x0601303D RID: 77885 RVA: 0x002C605C File Offset: 0x002C425C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameResponse()
		{
		}

		// Token: 0x0601303E RID: 77886 RVA: 0x002C606F File Offset: 0x002C426F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameResponse(PressGameResponse other) : this()
		{
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601303F RID: 77887 RVA: 0x002C6094 File Offset: 0x002C4294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameResponse Clone()
		{
			return new PressGameResponse(this);
		}

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x06013040 RID: 77888 RVA: 0x002C609C File Offset: 0x002C429C
		// (set) Token: 0x06013041 RID: 77889 RVA: 0x002C60A4 File Offset: 0x002C42A4
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

		// Token: 0x06013042 RID: 77890 RVA: 0x002C60B7 File Offset: 0x002C42B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressGameResponse);
		}

		// Token: 0x06013043 RID: 77891 RVA: 0x002C60C5 File Offset: 0x002C42C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressGameResponse other)
		{
			return other != null && (other == this || (!(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013044 RID: 77892 RVA: 0x002C60F8 File Offset: 0x002C42F8
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

		// Token: 0x06013045 RID: 77893 RVA: 0x002C6139 File Offset: 0x002C4339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013046 RID: 77894 RVA: 0x002C6146 File Offset: 0x002C4346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013047 RID: 77895 RVA: 0x002C614F File Offset: 0x002C434F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Payload.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteBytes(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013048 RID: 77896 RVA: 0x002C6188 File Offset: 0x002C4388
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

		// Token: 0x06013049 RID: 77897 RVA: 0x002C61CB File Offset: 0x002C43CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PressGameResponse other)
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

		// Token: 0x0601304A RID: 77898 RVA: 0x002C6201 File Offset: 0x002C4401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601304B RID: 77899 RVA: 0x002C620C File Offset: 0x002C440C
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Payload = input.ReadBytes();
				}
			}
		}

		// Token: 0x040075D2 RID: 30162
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075D3 RID: 30163
		public const int PayloadFieldNumber = 11;

		// Token: 0x040075D4 RID: 30164
		private ByteString payload_ = ByteString.Empty;
	}
}
