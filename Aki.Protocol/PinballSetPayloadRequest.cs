using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5C RID: 3420
	[NetMessage(EMessageId.PinballSetPayloadRequest)]
	public sealed class PinballSetPayloadRequest : IMessage<PinballSetPayloadRequest>, IMessage, IEquatable<PinballSetPayloadRequest>, IDeepCloneable<PinballSetPayloadRequest>, IBufferMessage
	{
		// Token: 0x0601272C RID: 75564 RVA: 0x002B1361 File Offset: 0x002AF561
		[NullableContext(1)]
		public static PinballSetPayloadRequest Create()
		{
			return new PinballSetPayloadRequest();
		}

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x0601272D RID: 75565 RVA: 0x002B1368 File Offset: 0x002AF568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x0601272E RID: 75566 RVA: 0x002B136B File Offset: 0x002AF56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSetPayloadRequest.Descriptor;
			}
		}

		// Token: 0x0601272F RID: 75567 RVA: 0x002B1372 File Offset: 0x002AF572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadRequest()
		{
		}

		// Token: 0x06012730 RID: 75568 RVA: 0x002B137A File Offset: 0x002AF57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadRequest(PinballSetPayloadRequest other) : this()
		{
			this.payload_ = ((other.payload_ != null) ? other.payload_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012731 RID: 75569 RVA: 0x002B13AF File Offset: 0x002AF5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadRequest Clone()
		{
			return new PinballSetPayloadRequest(this);
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x06012732 RID: 75570 RVA: 0x002B13B7 File Offset: 0x002AF5B7
		// (set) Token: 0x06012733 RID: 75571 RVA: 0x002B13BF File Offset: 0x002AF5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePayload Payload
		{
			get
			{
				return this.payload_;
			}
			set
			{
				this.payload_ = value;
			}
		}

		// Token: 0x06012734 RID: 75572 RVA: 0x002B13C8 File Offset: 0x002AF5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSetPayloadRequest);
		}

		// Token: 0x06012735 RID: 75573 RVA: 0x002B13D6 File Offset: 0x002AF5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSetPayloadRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Payload, other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012736 RID: 75574 RVA: 0x002B140C File Offset: 0x002AF60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.payload_ != null)
			{
				num ^= this.Payload.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012737 RID: 75575 RVA: 0x002B1448 File Offset: 0x002AF648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012738 RID: 75576 RVA: 0x002B1455 File Offset: 0x002AF655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012739 RID: 75577 RVA: 0x002B145E File Offset: 0x002AF65E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.payload_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601273A RID: 75578 RVA: 0x002B1490 File Offset: 0x002AF690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.payload_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Payload);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601273B RID: 75579 RVA: 0x002B14D0 File Offset: 0x002AF6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballSetPayloadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.payload_ != null)
			{
				if (this.payload_ == null)
				{
					this.Payload = new PinballSettlePayload();
				}
				this.Payload.MergeFrom(other.Payload);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601273C RID: 75580 RVA: 0x002B1524 File Offset: 0x002AF724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601273D RID: 75581 RVA: 0x002B1530 File Offset: 0x002AF730
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.payload_ == null)
					{
						this.Payload = new PinballSettlePayload();
					}
					input.ReadMessage(this.Payload);
				}
			}
		}

		// Token: 0x040072D1 RID: 29393
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072D2 RID: 29394
		public const int PayloadFieldNumber = 10;

		// Token: 0x040072D3 RID: 29395
		private PinballSettlePayload payload_;
	}
}
