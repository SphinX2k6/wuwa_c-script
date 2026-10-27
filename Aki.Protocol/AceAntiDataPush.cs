using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000057 RID: 87
	[NetMessage(EMessageId.AceAntiDataPush)]
	public sealed class AceAntiDataPush : IMessage<AceAntiDataPush>, IMessage, IEquatable<AceAntiDataPush>, IDeepCloneable<AceAntiDataPush>, IBufferMessage
	{
		// Token: 0x06001560 RID: 5472 RVA: 0x00038C11 File Offset: 0x00036E11
		[NullableContext(1)]
		public static AceAntiDataPush Create()
		{
			return new AceAntiDataPush();
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x00038C18 File Offset: 0x00036E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x00038C1B File Offset: 0x00036E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AceAntiDataPush.Descriptor;
			}
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00038C22 File Offset: 0x00036E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataPush()
		{
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00038C35 File Offset: 0x00036E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataPush(AceAntiDataPush other) : this()
		{
			this.antiData_ = other.antiData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00038C5A File Offset: 0x00036E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataPush Clone()
		{
			return new AceAntiDataPush(this);
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00038C62 File Offset: 0x00036E62
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x00038C6A File Offset: 0x00036E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString AntiData
		{
			get
			{
				return this.antiData_;
			}
			set
			{
				this.antiData_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00038C7D File Offset: 0x00036E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AceAntiDataPush);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00038C8B File Offset: 0x00036E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AceAntiDataPush other)
		{
			return other != null && (other == this || (!(this.AntiData != other.AntiData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00038CC0 File Offset: 0x00036EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AntiData.Length != 0)
			{
				num ^= this.AntiData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00038D01 File Offset: 0x00036F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00038D0E File Offset: 0x00036F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00038D17 File Offset: 0x00036F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AntiData.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.AntiData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00038D50 File Offset: 0x00036F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AntiData.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.AntiData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00038D93 File Offset: 0x00036F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AceAntiDataPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AntiData.Length != 0)
			{
				this.AntiData = other.AntiData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00038DC9 File Offset: 0x00036FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00038DD4 File Offset: 0x00036FD4
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AntiData = input.ReadBytes();
				}
			}
		}

		// Token: 0x0400209C RID: 8348
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400209D RID: 8349
		public const int AntiDataFieldNumber = 5;

		// Token: 0x0400209E RID: 8350
		private ByteString antiData_ = ByteString.Empty;
	}
}
