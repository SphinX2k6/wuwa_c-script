using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD9 RID: 3545
	[NetMessage(EMessageId.PressRequest)]
	public sealed class PressRequest : IMessage<PressRequest>, IMessage, IEquatable<PressRequest>, IDeepCloneable<PressRequest>, IBufferMessage
	{
		// Token: 0x06013143 RID: 78147 RVA: 0x002C7B1D File Offset: 0x002C5D1D
		[NullableContext(1)]
		public static PressRequest Create()
		{
			return new PressRequest();
		}

		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x06013144 RID: 78148 RVA: 0x002C7B24 File Offset: 0x002C5D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x06013145 RID: 78149 RVA: 0x002C7B27 File Offset: 0x002C5D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressRequest.Descriptor;
			}
		}

		// Token: 0x06013146 RID: 78150 RVA: 0x002C7B2E File Offset: 0x002C5D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressRequest()
		{
		}

		// Token: 0x06013147 RID: 78151 RVA: 0x002C7B41 File Offset: 0x002C5D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressRequest(PressRequest other) : this()
		{
			this.payloadSize_ = other.payloadSize_;
			this.notifyCount_ = other.notifyCount_;
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013148 RID: 78152 RVA: 0x002C7B7E File Offset: 0x002C5D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressRequest Clone()
		{
			return new PressRequest(this);
		}

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x06013149 RID: 78153 RVA: 0x002C7B86 File Offset: 0x002C5D86
		// (set) Token: 0x0601314A RID: 78154 RVA: 0x002C7B8E File Offset: 0x002C5D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PayloadSize
		{
			get
			{
				return this.payloadSize_;
			}
			set
			{
				this.payloadSize_ = value;
			}
		}

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x0601314B RID: 78155 RVA: 0x002C7B97 File Offset: 0x002C5D97
		// (set) Token: 0x0601314C RID: 78156 RVA: 0x002C7B9F File Offset: 0x002C5D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NotifyCount
		{
			get
			{
				return this.notifyCount_;
			}
			set
			{
				this.notifyCount_ = value;
			}
		}

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x0601314D RID: 78157 RVA: 0x002C7BA8 File Offset: 0x002C5DA8
		// (set) Token: 0x0601314E RID: 78158 RVA: 0x002C7BB0 File Offset: 0x002C5DB0
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

		// Token: 0x0601314F RID: 78159 RVA: 0x002C7BC3 File Offset: 0x002C5DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressRequest);
		}

		// Token: 0x06013150 RID: 78160 RVA: 0x002C7BD4 File Offset: 0x002C5DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressRequest other)
		{
			return other != null && (other == this || (this.PayloadSize == other.PayloadSize && this.NotifyCount == other.NotifyCount && !(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013151 RID: 78161 RVA: 0x002C7C34 File Offset: 0x002C5E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PayloadSize != 0)
			{
				num ^= this.PayloadSize.GetHashCode();
			}
			if (this.NotifyCount != 0)
			{
				num ^= this.NotifyCount.GetHashCode();
			}
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

		// Token: 0x06013152 RID: 78162 RVA: 0x002C7CA7 File Offset: 0x002C5EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013153 RID: 78163 RVA: 0x002C7CB4 File Offset: 0x002C5EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013154 RID: 78164 RVA: 0x002C7CC0 File Offset: 0x002C5EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PayloadSize != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PayloadSize);
			}
			if (this.Payload.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteBytes(this.Payload);
			}
			if (this.NotifyCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.NotifyCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013155 RID: 78165 RVA: 0x002C7D3C File Offset: 0x002C5F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PayloadSize != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PayloadSize);
			}
			if (this.NotifyCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NotifyCount);
			}
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

		// Token: 0x06013156 RID: 78166 RVA: 0x002C7DB0 File Offset: 0x002C5FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PressRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PayloadSize != 0)
			{
				this.PayloadSize = other.PayloadSize;
			}
			if (other.NotifyCount != 0)
			{
				this.NotifyCount = other.NotifyCount;
			}
			if (other.Payload.Length != 0)
			{
				this.Payload = other.Payload;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013157 RID: 78167 RVA: 0x002C7E19 File Offset: 0x002C6019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013158 RID: 78168 RVA: 0x002C7E24 File Offset: 0x002C6024
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
				if (num != 40U)
				{
					if (num != 66U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NotifyCount = input.ReadInt32();
						}
					}
					else
					{
						this.Payload = input.ReadBytes();
					}
				}
				else
				{
					this.PayloadSize = input.ReadInt32();
				}
			}
		}

		// Token: 0x040075AE RID: 30126
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075AF RID: 30127
		public const int PayloadSizeFieldNumber = 5;

		// Token: 0x040075B0 RID: 30128
		private int payloadSize_;

		// Token: 0x040075B1 RID: 30129
		public const int NotifyCountFieldNumber = 14;

		// Token: 0x040075B2 RID: 30130
		private int notifyCount_;

		// Token: 0x040075B3 RID: 30131
		public const int PayloadFieldNumber = 8;

		// Token: 0x040075B4 RID: 30132
		private ByteString payload_ = ByteString.Empty;
	}
}
