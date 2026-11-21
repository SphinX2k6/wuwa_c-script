using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC9 RID: 3529
	[NetMessage(EMessageId.PressRequest)]
	public sealed class PressRequest : IMessage<PressRequest>, IMessage, IEquatable<PressRequest>, IDeepCloneable<PressRequest>, IBufferMessage
	{
		// Token: 0x0601305E RID: 77918 RVA: 0x002C6459 File Offset: 0x002C4659
		[NullableContext(1)]
		public static PressRequest Create()
		{
			return new PressRequest();
		}

		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x0601305F RID: 77919 RVA: 0x002C6460 File Offset: 0x002C4660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x06013060 RID: 77920 RVA: 0x002C6463 File Offset: 0x002C4663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PressRequest.Descriptor;
			}
		}

		// Token: 0x06013061 RID: 77921 RVA: 0x002C646A File Offset: 0x002C466A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressRequest()
		{
		}

		// Token: 0x06013062 RID: 77922 RVA: 0x002C647D File Offset: 0x002C467D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressRequest(PressRequest other) : this()
		{
			this.payloadSize_ = other.payloadSize_;
			this.notifyCount_ = other.notifyCount_;
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013063 RID: 77923 RVA: 0x002C64BA File Offset: 0x002C46BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PressRequest Clone()
		{
			return new PressRequest(this);
		}

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x06013064 RID: 77924 RVA: 0x002C64C2 File Offset: 0x002C46C2
		// (set) Token: 0x06013065 RID: 77925 RVA: 0x002C64CA File Offset: 0x002C46CA
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

		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x06013066 RID: 77926 RVA: 0x002C64D3 File Offset: 0x002C46D3
		// (set) Token: 0x06013067 RID: 77927 RVA: 0x002C64DB File Offset: 0x002C46DB
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

		// Token: 0x17003F27 RID: 16167
		// (get) Token: 0x06013068 RID: 77928 RVA: 0x002C64E4 File Offset: 0x002C46E4
		// (set) Token: 0x06013069 RID: 77929 RVA: 0x002C64EC File Offset: 0x002C46EC
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

		// Token: 0x0601306A RID: 77930 RVA: 0x002C64FF File Offset: 0x002C46FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PressRequest);
		}

		// Token: 0x0601306B RID: 77931 RVA: 0x002C6510 File Offset: 0x002C4710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PressRequest other)
		{
			return other != null && (other == this || (this.PayloadSize == other.PayloadSize && this.NotifyCount == other.NotifyCount && !(this.Payload != other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601306C RID: 77932 RVA: 0x002C6570 File Offset: 0x002C4770
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

		// Token: 0x0601306D RID: 77933 RVA: 0x002C65E3 File Offset: 0x002C47E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601306E RID: 77934 RVA: 0x002C65F0 File Offset: 0x002C47F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601306F RID: 77935 RVA: 0x002C65FC File Offset: 0x002C47FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NotifyCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NotifyCount);
			}
			if (this.PayloadSize != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PayloadSize);
			}
			if (this.Payload.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteBytes(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013070 RID: 77936 RVA: 0x002C6678 File Offset: 0x002C4878
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

		// Token: 0x06013071 RID: 77937 RVA: 0x002C66EC File Offset: 0x002C48EC
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

		// Token: 0x06013072 RID: 77938 RVA: 0x002C6755 File Offset: 0x002C4955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013073 RID: 77939 RVA: 0x002C6760 File Offset: 0x002C4960
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
				if (num != 16U)
				{
					if (num != 32U)
					{
						if (num != 114U)
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

		// Token: 0x040075D8 RID: 30168
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075D9 RID: 30169
		public const int PayloadSizeFieldNumber = 4;

		// Token: 0x040075DA RID: 30170
		private int payloadSize_;

		// Token: 0x040075DB RID: 30171
		public const int NotifyCountFieldNumber = 2;

		// Token: 0x040075DC RID: 30172
		private int notifyCount_;

		// Token: 0x040075DD RID: 30173
		public const int PayloadFieldNumber = 14;

		// Token: 0x040075DE RID: 30174
		private ByteString payload_ = ByteString.Empty;
	}
}
