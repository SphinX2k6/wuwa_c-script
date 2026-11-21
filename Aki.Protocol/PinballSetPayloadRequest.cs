using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4C RID: 3404
	[NetMessage(EMessageId.PinballSetPayloadRequest)]
	public sealed class PinballSetPayloadRequest : IMessage<PinballSetPayloadRequest>, IMessage, IEquatable<PinballSetPayloadRequest>, IDeepCloneable<PinballSetPayloadRequest>, IBufferMessage
	{
		// Token: 0x06012630 RID: 75312 RVA: 0x002AF73D File Offset: 0x002AD93D
		[NullableContext(1)]
		public static PinballSetPayloadRequest Create()
		{
			return new PinballSetPayloadRequest();
		}

		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x06012631 RID: 75313 RVA: 0x002AF744 File Offset: 0x002AD944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x06012632 RID: 75314 RVA: 0x002AF747 File Offset: 0x002AD947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSetPayloadRequest.Descriptor;
			}
		}

		// Token: 0x06012633 RID: 75315 RVA: 0x002AF74E File Offset: 0x002AD94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadRequest()
		{
		}

		// Token: 0x06012634 RID: 75316 RVA: 0x002AF756 File Offset: 0x002AD956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadRequest(PinballSetPayloadRequest other) : this()
		{
			this.payload_ = ((other.payload_ != null) ? other.payload_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012635 RID: 75317 RVA: 0x002AF78B File Offset: 0x002AD98B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSetPayloadRequest Clone()
		{
			return new PinballSetPayloadRequest(this);
		}

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x06012636 RID: 75318 RVA: 0x002AF793 File Offset: 0x002AD993
		// (set) Token: 0x06012637 RID: 75319 RVA: 0x002AF79B File Offset: 0x002AD99B
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

		// Token: 0x06012638 RID: 75320 RVA: 0x002AF7A4 File Offset: 0x002AD9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSetPayloadRequest);
		}

		// Token: 0x06012639 RID: 75321 RVA: 0x002AF7B2 File Offset: 0x002AD9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSetPayloadRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Payload, other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601263A RID: 75322 RVA: 0x002AF7E8 File Offset: 0x002AD9E8
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

		// Token: 0x0601263B RID: 75323 RVA: 0x002AF824 File Offset: 0x002ADA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601263C RID: 75324 RVA: 0x002AF831 File Offset: 0x002ADA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601263D RID: 75325 RVA: 0x002AF83A File Offset: 0x002ADA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.payload_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601263E RID: 75326 RVA: 0x002AF86C File Offset: 0x002ADA6C
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

		// Token: 0x0601263F RID: 75327 RVA: 0x002AF8AC File Offset: 0x002ADAAC
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

		// Token: 0x06012640 RID: 75328 RVA: 0x002AF900 File Offset: 0x002ADB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012641 RID: 75329 RVA: 0x002AF90C File Offset: 0x002ADB0C
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
				if (num != 10U)
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

		// Token: 0x040072E9 RID: 29417
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072EA RID: 29418
		public const int PayloadFieldNumber = 1;

		// Token: 0x040072EB RID: 29419
		private PinballSettlePayload payload_;
	}
}
