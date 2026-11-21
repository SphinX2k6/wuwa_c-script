using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000057 RID: 87
	[NetMessage(EMessageId.AceAntiDataNotify)]
	public sealed class AceAntiDataNotify : IMessage<AceAntiDataNotify>, IMessage, IEquatable<AceAntiDataNotify>, IDeepCloneable<AceAntiDataNotify>, IBufferMessage
	{
		// Token: 0x06001591 RID: 5521 RVA: 0x000393AE File Offset: 0x000375AE
		[NullableContext(1)]
		public static AceAntiDataNotify Create()
		{
			return new AceAntiDataNotify();
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x000393B5 File Offset: 0x000375B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x000393B8 File Offset: 0x000375B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AceAntiDataNotify.Descriptor;
			}
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x000393BF File Offset: 0x000375BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataNotify()
		{
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x000393D2 File Offset: 0x000375D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataNotify(AceAntiDataNotify other) : this()
		{
			this.antiData_ = other.antiData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x000393F7 File Offset: 0x000375F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiDataNotify Clone()
		{
			return new AceAntiDataNotify(this);
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x000393FF File Offset: 0x000375FF
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x00039407 File Offset: 0x00037607
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

		// Token: 0x06001599 RID: 5529 RVA: 0x0003941A File Offset: 0x0003761A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AceAntiDataNotify);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00039428 File Offset: 0x00037628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AceAntiDataNotify other)
		{
			return other != null && (other == this || (!(this.AntiData != other.AntiData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x0003945C File Offset: 0x0003765C
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

		// Token: 0x0600159C RID: 5532 RVA: 0x0003949D File Offset: 0x0003769D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x000394AA File Offset: 0x000376AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000394B3 File Offset: 0x000376B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AntiData.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.AntiData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000394EC File Offset: 0x000376EC
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

		// Token: 0x060015A0 RID: 5536 RVA: 0x0003952F File Offset: 0x0003772F
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

		// Token: 0x060015A1 RID: 5537 RVA: 0x00039565 File Offset: 0x00037765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00039570 File Offset: 0x00037770
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AntiData = input.ReadBytes();
				}
			}
		}

		// Token: 0x040020F8 RID: 8440
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020F9 RID: 8441
		public const int AntiDataFieldNumber = 2;

		// Token: 0x040020FA RID: 8442
		private ByteString antiData_ = ByteString.Empty;
	}
}
