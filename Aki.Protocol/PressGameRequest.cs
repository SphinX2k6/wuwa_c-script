using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD6 RID: 3542
	[NetMessage(EMessageId.PressGameRequest)]
	public sealed class PressGameRequest : IMessage<PressGameRequest>, IMessage, IEquatable<PressGameRequest>, IDeepCloneable<PressGameRequest>, IBufferMessage
	{
		// Token: 0x06013109 RID: 78089 RVA: 0x002C739D File Offset: 0x002C559D
		[NullableContext(1)]
		public static PressGameRequest Create()
		{
			return new PressGameRequest();
		}

		// Token: 0x17003F42 RID: 16194
		// (get) Token: 0x0601310A RID: 78090 RVA: 0x002C73A4 File Offset: 0x002C55A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F43 RID: 16195
		// (get) Token: 0x0601310B RID: 78091 RVA: 0x002C73A7 File Offset: 0x002C55A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressGameRequest.Descriptor;
			}
		}

		// Token: 0x0601310C RID: 78092 RVA: 0x002C73AE File Offset: 0x002C55AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameRequest()
		{
		}

		// Token: 0x0601310D RID: 78093 RVA: 0x002C73C1 File Offset: 0x002C55C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameRequest(PressGameRequest other) : this()
		{
			this.payloadSize_ = other.payloadSize_;
			this.notifyCount_ = other.notifyCount_;
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601310E RID: 78094 RVA: 0x002C73FE File Offset: 0x002C55FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressGameRequest Clone()
		{
			return new PressGameRequest(this);
		}

		// Token: 0x17003F44 RID: 16196
		// (get) Token: 0x0601310F RID: 78095 RVA: 0x002C7406 File Offset: 0x002C5606
		// (set) Token: 0x06013110 RID: 78096 RVA: 0x002C740E File Offset: 0x002C560E
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

		// Token: 0x17003F45 RID: 16197
		// (get) Token: 0x06013111 RID: 78097 RVA: 0x002C7417 File Offset: 0x002C5617
		// (set) Token: 0x06013112 RID: 78098 RVA: 0x002C741F File Offset: 0x002C561F
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

		// Token: 0x17003F46 RID: 16198
		// (get) Token: 0x06013113 RID: 78099 RVA: 0x002C7428 File Offset: 0x002C5628
		// (set) Token: 0x06013114 RID: 78100 RVA: 0x002C7430 File Offset: 0x002C5630
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

		// Token: 0x06013115 RID: 78101 RVA: 0x002C7443 File Offset: 0x002C5643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressGameRequest);
		}

		// Token: 0x06013116 RID: 78102 RVA: 0x002C7454 File Offset: 0x002C5654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressGameRequest other)
		{
			return other != null && (other == this || (this.PayloadSize == other.PayloadSize && this.NotifyCount == other.NotifyCount && !(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013117 RID: 78103 RVA: 0x002C74B4 File Offset: 0x002C56B4
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

		// Token: 0x06013118 RID: 78104 RVA: 0x002C7527 File Offset: 0x002C5727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013119 RID: 78105 RVA: 0x002C7534 File Offset: 0x002C5734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601311A RID: 78106 RVA: 0x002C7540 File Offset: 0x002C5740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NotifyCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NotifyCount);
			}
			if (this.PayloadSize != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PayloadSize);
			}
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

		// Token: 0x0601311B RID: 78107 RVA: 0x002C75BC File Offset: 0x002C57BC
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

		// Token: 0x0601311C RID: 78108 RVA: 0x002C7630 File Offset: 0x002C5830
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

		// Token: 0x0601311D RID: 78109 RVA: 0x002C7699 File Offset: 0x002C5899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601311E RID: 78110 RVA: 0x002C76A4 File Offset: 0x002C58A4
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
					if (num != 88U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.NotifyCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x040075A1 RID: 30113
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075A2 RID: 30114
		public const int PayloadSizeFieldNumber = 11;

		// Token: 0x040075A3 RID: 30115
		private int payloadSize_;

		// Token: 0x040075A4 RID: 30116
		public const int NotifyCountFieldNumber = 3;

		// Token: 0x040075A5 RID: 30117
		private int notifyCount_;

		// Token: 0x040075A6 RID: 30118
		public const int PayloadFieldNumber = 13;

		// Token: 0x040075A7 RID: 30119
		private ByteString payload_ = ByteString.Empty;
	}
}
