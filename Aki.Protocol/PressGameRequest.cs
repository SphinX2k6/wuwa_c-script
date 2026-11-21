using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC6 RID: 3526
	[NetMessage(EMessageId.PressGameRequest)]
	public sealed class PressGameRequest : IMessage<PressGameRequest>, IMessage, IEquatable<PressGameRequest>, IDeepCloneable<PressGameRequest>, IBufferMessage
	{
		// Token: 0x06013024 RID: 77860 RVA: 0x002C5CD9 File Offset: 0x002C3ED9
		[NullableContext(1)]
		public static PressGameRequest Create()
		{
			return new PressGameRequest();
		}

		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x06013025 RID: 77861 RVA: 0x002C5CE0 File Offset: 0x002C3EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x06013026 RID: 77862 RVA: 0x002C5CE3 File Offset: 0x002C3EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressGameRequest.Descriptor;
			}
		}

		// Token: 0x06013027 RID: 77863 RVA: 0x002C5CEA File Offset: 0x002C3EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameRequest()
		{
		}

		// Token: 0x06013028 RID: 77864 RVA: 0x002C5CFD File Offset: 0x002C3EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameRequest(PressGameRequest other) : this()
		{
			this.payloadSize_ = other.payloadSize_;
			this.notifyCount_ = other.notifyCount_;
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013029 RID: 77865 RVA: 0x002C5D3A File Offset: 0x002C3F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameRequest Clone()
		{
			return new PressGameRequest(this);
		}

		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x0601302A RID: 77866 RVA: 0x002C5D42 File Offset: 0x002C3F42
		// (set) Token: 0x0601302B RID: 77867 RVA: 0x002C5D4A File Offset: 0x002C3F4A
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

		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x0601302C RID: 77868 RVA: 0x002C5D53 File Offset: 0x002C3F53
		// (set) Token: 0x0601302D RID: 77869 RVA: 0x002C5D5B File Offset: 0x002C3F5B
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

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x0601302E RID: 77870 RVA: 0x002C5D64 File Offset: 0x002C3F64
		// (set) Token: 0x0601302F RID: 77871 RVA: 0x002C5D6C File Offset: 0x002C3F6C
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

		// Token: 0x06013030 RID: 77872 RVA: 0x002C5D7F File Offset: 0x002C3F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressGameRequest);
		}

		// Token: 0x06013031 RID: 77873 RVA: 0x002C5D90 File Offset: 0x002C3F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressGameRequest other)
		{
			return other != null && (other == this || (this.PayloadSize == other.PayloadSize && this.NotifyCount == other.NotifyCount && !(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013032 RID: 77874 RVA: 0x002C5DF0 File Offset: 0x002C3FF0
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

		// Token: 0x06013033 RID: 77875 RVA: 0x002C5E63 File Offset: 0x002C4063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013034 RID: 77876 RVA: 0x002C5E70 File Offset: 0x002C4070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013035 RID: 77877 RVA: 0x002C5E7C File Offset: 0x002C407C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Payload.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteBytes(this.Payload);
			}
			if (this.PayloadSize != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PayloadSize);
			}
			if (this.NotifyCount != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.NotifyCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013036 RID: 77878 RVA: 0x002C5EF8 File Offset: 0x002C40F8
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

		// Token: 0x06013037 RID: 77879 RVA: 0x002C5F6C File Offset: 0x002C416C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PressGameRequest other)
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

		// Token: 0x06013038 RID: 77880 RVA: 0x002C5FD5 File Offset: 0x002C41D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013039 RID: 77881 RVA: 0x002C5FE0 File Offset: 0x002C41E0
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
					if (num != 64U)
					{
						if (num != 120U)
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
						this.PayloadSize = input.ReadInt32();
					}
				}
				else
				{
					this.Payload = input.ReadBytes();
				}
			}
		}

		// Token: 0x040075CB RID: 30155
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075CC RID: 30156
		public const int PayloadSizeFieldNumber = 8;

		// Token: 0x040075CD RID: 30157
		private int payloadSize_;

		// Token: 0x040075CE RID: 30158
		public const int NotifyCountFieldNumber = 15;

		// Token: 0x040075CF RID: 30159
		private int notifyCount_;

		// Token: 0x040075D0 RID: 30160
		public const int PayloadFieldNumber = 6;

		// Token: 0x040075D1 RID: 30161
		private ByteString payload_ = ByteString.Empty;
	}
}
