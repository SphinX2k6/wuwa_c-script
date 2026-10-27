using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000056 RID: 86
	[NetMessage(EMessageId.AceAntiDataNotify)]
	public sealed class AceAntiDataNotify : IMessage<AceAntiDataNotify>, IMessage, IEquatable<AceAntiDataNotify>, IDeepCloneable<AceAntiDataNotify>, IBufferMessage
	{
		// Token: 0x0600154E RID: 5454 RVA: 0x00038A0A File Offset: 0x00036C0A
		[NullableContext(1)]
		public static AceAntiDataNotify Create()
		{
			return new AceAntiDataNotify();
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x00038A11 File Offset: 0x00036C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x00038A14 File Offset: 0x00036C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AceAntiDataNotify.Descriptor;
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00038A1B File Offset: 0x00036C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataNotify()
		{
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00038A2E File Offset: 0x00036C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataNotify(AceAntiDataNotify other) : this()
		{
			this.antiData_ = other.antiData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00038A53 File Offset: 0x00036C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataNotify Clone()
		{
			return new AceAntiDataNotify(this);
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x00038A5B File Offset: 0x00036C5B
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x00038A63 File Offset: 0x00036C63
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

		// Token: 0x06001556 RID: 5462 RVA: 0x00038A76 File Offset: 0x00036C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AceAntiDataNotify);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00038A84 File Offset: 0x00036C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AceAntiDataNotify other)
		{
			return other != null && (other == this || (!(this.AntiData != other.AntiData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00038AB8 File Offset: 0x00036CB8
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

		// Token: 0x06001559 RID: 5465 RVA: 0x00038AF9 File Offset: 0x00036CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00038B06 File Offset: 0x00036D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00038B0F File Offset: 0x00036D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AntiData.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteBytes(this.AntiData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00038B48 File Offset: 0x00036D48
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

		// Token: 0x0600155D RID: 5469 RVA: 0x00038B8B File Offset: 0x00036D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AceAntiDataNotify other)
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

		// Token: 0x0600155E RID: 5470 RVA: 0x00038BC1 File Offset: 0x00036DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00038BCC File Offset: 0x00036DCC
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
					this.AntiData = input.ReadBytes();
				}
			}
		}

		// Token: 0x04002099 RID: 8345
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400209A RID: 8346
		public const int AntiDataFieldNumber = 11;

		// Token: 0x0400209B RID: 8347
		private ByteString antiData_ = ByteString.Empty;
	}
}
