using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D53 RID: 3411
	[NetMessage(EMessageId.PinballQuitRequest)]
	public sealed class PinballQuitRequest : IMessage<PinballQuitRequest>, IMessage, IEquatable<PinballQuitRequest>, IDeepCloneable<PinballQuitRequest>, IBufferMessage
	{
		// Token: 0x06012662 RID: 75362 RVA: 0x002AF54C File Offset: 0x002AD74C
		[NullableContext(1)]
		public static PinballQuitRequest Create()
		{
			return new PinballQuitRequest();
		}

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x06012663 RID: 75363 RVA: 0x002AF553 File Offset: 0x002AD753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x06012664 RID: 75364 RVA: 0x002AF556 File Offset: 0x002AD756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballQuitRequest.Descriptor;
			}
		}

		// Token: 0x06012665 RID: 75365 RVA: 0x002AF55D File Offset: 0x002AD75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitRequest()
		{
		}

		// Token: 0x06012666 RID: 75366 RVA: 0x002AF568 File Offset: 0x002AD768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitRequest(PinballQuitRequest other) : this()
		{
			this.payload_ = ((other.payload_ != null) ? other.payload_.Clone() : null);
			this.needNotify_ = other.needNotify_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012667 RID: 75367 RVA: 0x002AF5B4 File Offset: 0x002AD7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitRequest Clone()
		{
			return new PinballQuitRequest(this);
		}

		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x06012668 RID: 75368 RVA: 0x002AF5BC File Offset: 0x002AD7BC
		// (set) Token: 0x06012669 RID: 75369 RVA: 0x002AF5C4 File Offset: 0x002AD7C4
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

		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x0601266A RID: 75370 RVA: 0x002AF5CD File Offset: 0x002AD7CD
		// (set) Token: 0x0601266B RID: 75371 RVA: 0x002AF5D5 File Offset: 0x002AD7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedNotify
		{
			get
			{
				return this.needNotify_;
			}
			set
			{
				this.needNotify_ = value;
			}
		}

		// Token: 0x0601266C RID: 75372 RVA: 0x002AF5DE File Offset: 0x002AD7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballQuitRequest);
		}

		// Token: 0x0601266D RID: 75373 RVA: 0x002AF5EC File Offset: 0x002AD7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballQuitRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Payload, other.Payload) && this.NeedNotify == other.NeedNotify && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601266E RID: 75374 RVA: 0x002AF63C File Offset: 0x002AD83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.payload_ != null)
			{
				num ^= this.Payload.GetHashCode();
			}
			if (this.NeedNotify)
			{
				num ^= this.NeedNotify.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601266F RID: 75375 RVA: 0x002AF691 File Offset: 0x002AD891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012670 RID: 75376 RVA: 0x002AF69E File Offset: 0x002AD89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012671 RID: 75377 RVA: 0x002AF6A8 File Offset: 0x002AD8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.payload_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Payload);
			}
			if (this.NeedNotify)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.NeedNotify);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012672 RID: 75378 RVA: 0x002AF704 File Offset: 0x002AD904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.payload_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Payload);
			}
			if (this.NeedNotify)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012673 RID: 75379 RVA: 0x002AF750 File Offset: 0x002AD950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballQuitRequest other)
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
			if (other.NeedNotify)
			{
				this.NeedNotify = other.NeedNotify;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012674 RID: 75380 RVA: 0x002AF7B8 File Offset: 0x002AD9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012675 RID: 75381 RVA: 0x002AF7C4 File Offset: 0x002AD9C4
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NeedNotify = input.ReadBool();
					}
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

		// Token: 0x0400728B RID: 29323
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400728C RID: 29324
		public const int PayloadFieldNumber = 1;

		// Token: 0x0400728D RID: 29325
		private PinballSettlePayload payload_;

		// Token: 0x0400728E RID: 29326
		public const int NeedNotifyFieldNumber = 13;

		// Token: 0x0400728F RID: 29327
		private bool needNotify_;
	}
}
