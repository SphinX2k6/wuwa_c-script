using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D30 RID: 3376
	[NetMessage(EMessageId.PinballBonusFullWinRequest)]
	public sealed class PinballBonusFullWinRequest : IMessage<PinballBonusFullWinRequest>, IMessage, IEquatable<PinballBonusFullWinRequest>, IDeepCloneable<PinballBonusFullWinRequest>, IBufferMessage
	{
		// Token: 0x060123E0 RID: 74720 RVA: 0x002AA28D File Offset: 0x002A848D
		[NullableContext(1)]
		public static PinballBonusFullWinRequest Create()
		{
			return new PinballBonusFullWinRequest();
		}

		// Token: 0x17003C71 RID: 15473
		// (get) Token: 0x060123E1 RID: 74721 RVA: 0x002AA294 File Offset: 0x002A8494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C72 RID: 15474
		// (get) Token: 0x060123E2 RID: 74722 RVA: 0x002AA297 File Offset: 0x002A8497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballBonusFullWinRequest.Descriptor;
			}
		}

		// Token: 0x060123E3 RID: 74723 RVA: 0x002AA29E File Offset: 0x002A849E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinRequest()
		{
		}

		// Token: 0x060123E4 RID: 74724 RVA: 0x002AA2A6 File Offset: 0x002A84A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinRequest(PinballBonusFullWinRequest other) : this()
		{
			this.payload_ = ((other.payload_ != null) ? other.payload_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060123E5 RID: 74725 RVA: 0x002AA2DB File Offset: 0x002A84DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinRequest Clone()
		{
			return new PinballBonusFullWinRequest(this);
		}

		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x060123E6 RID: 74726 RVA: 0x002AA2E3 File Offset: 0x002A84E3
		// (set) Token: 0x060123E7 RID: 74727 RVA: 0x002AA2EB File Offset: 0x002A84EB
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

		// Token: 0x060123E8 RID: 74728 RVA: 0x002AA2F4 File Offset: 0x002A84F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballBonusFullWinRequest);
		}

		// Token: 0x060123E9 RID: 74729 RVA: 0x002AA302 File Offset: 0x002A8502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballBonusFullWinRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Payload, other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060123EA RID: 74730 RVA: 0x002AA338 File Offset: 0x002A8538
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

		// Token: 0x060123EB RID: 74731 RVA: 0x002AA374 File Offset: 0x002A8574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060123EC RID: 74732 RVA: 0x002AA381 File Offset: 0x002A8581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060123ED RID: 74733 RVA: 0x002AA38A File Offset: 0x002A858A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.payload_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060123EE RID: 74734 RVA: 0x002AA3BC File Offset: 0x002A85BC
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

		// Token: 0x060123EF RID: 74735 RVA: 0x002AA3FC File Offset: 0x002A85FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballBonusFullWinRequest other)
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

		// Token: 0x060123F0 RID: 74736 RVA: 0x002AA450 File Offset: 0x002A8650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060123F1 RID: 74737 RVA: 0x002AA45C File Offset: 0x002A865C
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

		// Token: 0x04007237 RID: 29239
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007238 RID: 29240
		public const int PayloadFieldNumber = 6;

		// Token: 0x04007239 RID: 29241
		private PinballSettlePayload payload_;
	}
}
