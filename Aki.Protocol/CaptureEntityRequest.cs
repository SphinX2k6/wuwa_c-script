using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000237 RID: 567
	[NetMessage(EMessageId.CaptureEntityRequest)]
	public sealed class CaptureEntityRequest : IMessage<CaptureEntityRequest>, IMessage, IEquatable<CaptureEntityRequest>, IDeepCloneable<CaptureEntityRequest>, IBufferMessage
	{
		// Token: 0x06003D37 RID: 15671 RVA: 0x00097ACC File Offset: 0x00095CCC
		[NullableContext(1)]
		public static CaptureEntityRequest Create()
		{
			return new CaptureEntityRequest();
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06003D38 RID: 15672 RVA: 0x00097AD3 File Offset: 0x00095CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x00097AD6 File Offset: 0x00095CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaptureEntityRequest.Descriptor;
			}
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x00097ADD File Offset: 0x00095CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityRequest()
		{
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x00097AE5 File Offset: 0x00095CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityRequest(CaptureEntityRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x00097B0A File Offset: 0x00095D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityRequest Clone()
		{
			return new CaptureEntityRequest(this);
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06003D3D RID: 15677 RVA: 0x00097B12 File Offset: 0x00095D12
		// (set) Token: 0x06003D3E RID: 15678 RVA: 0x00097B1A File Offset: 0x00095D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x00097B23 File Offset: 0x00095D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaptureEntityRequest);
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x00097B31 File Offset: 0x00095D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaptureEntityRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x00097B60 File Offset: 0x00095D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x00097B9F File Offset: 0x00095D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x00097BAC File Offset: 0x00095DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x00097BB5 File Offset: 0x00095DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x00097BE8 File Offset: 0x00095DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x00097C26 File Offset: 0x00095E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaptureEntityRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x00097C57 File Offset: 0x00095E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x00097C60 File Offset: 0x00095E60
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002C9C RID: 11420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C9D RID: 11421
		public const int IdFieldNumber = 3;

		// Token: 0x04002C9E RID: 11422
		private long id_;
	}
}
