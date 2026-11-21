using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D43 RID: 3395
	[NetMessage(EMessageId.PinballQuitRequest)]
	public sealed class PinballQuitRequest : IMessage<PinballQuitRequest>, IMessage, IEquatable<PinballQuitRequest>, IDeepCloneable<PinballQuitRequest>, IBufferMessage
	{
		// Token: 0x06012566 RID: 75110 RVA: 0x002AD92C File Offset: 0x002ABB2C
		[NullableContext(1)]
		public static PinballQuitRequest Create()
		{
			return new PinballQuitRequest();
		}

		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x06012567 RID: 75111 RVA: 0x002AD933 File Offset: 0x002ABB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x06012568 RID: 75112 RVA: 0x002AD936 File Offset: 0x002ABB36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballQuitRequest.Descriptor;
			}
		}

		// Token: 0x06012569 RID: 75113 RVA: 0x002AD93D File Offset: 0x002ABB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitRequest()
		{
		}

		// Token: 0x0601256A RID: 75114 RVA: 0x002AD948 File Offset: 0x002ABB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitRequest(PinballQuitRequest other) : this()
		{
			this.payload_ = ((other.payload_ != null) ? other.payload_.Clone() : null);
			this.needNotify_ = other.needNotify_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601256B RID: 75115 RVA: 0x002AD994 File Offset: 0x002ABB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitRequest Clone()
		{
			return new PinballQuitRequest(this);
		}

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x0601256C RID: 75116 RVA: 0x002AD99C File Offset: 0x002ABB9C
		// (set) Token: 0x0601256D RID: 75117 RVA: 0x002AD9A4 File Offset: 0x002ABBA4
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

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x0601256E RID: 75118 RVA: 0x002AD9AD File Offset: 0x002ABBAD
		// (set) Token: 0x0601256F RID: 75119 RVA: 0x002AD9B5 File Offset: 0x002ABBB5
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

		// Token: 0x06012570 RID: 75120 RVA: 0x002AD9BE File Offset: 0x002ABBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballQuitRequest);
		}

		// Token: 0x06012571 RID: 75121 RVA: 0x002AD9CC File Offset: 0x002ABBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballQuitRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Payload, other.Payload) && this.NeedNotify == other.NeedNotify && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012572 RID: 75122 RVA: 0x002ADA1C File Offset: 0x002ABC1C
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

		// Token: 0x06012573 RID: 75123 RVA: 0x002ADA71 File Offset: 0x002ABC71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012574 RID: 75124 RVA: 0x002ADA7E File Offset: 0x002ABC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012575 RID: 75125 RVA: 0x002ADA88 File Offset: 0x002ABC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NeedNotify)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.NeedNotify);
			}
			if (this.payload_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012576 RID: 75126 RVA: 0x002ADAE4 File Offset: 0x002ABCE4
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

		// Token: 0x06012577 RID: 75127 RVA: 0x002ADB30 File Offset: 0x002ABD30
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

		// Token: 0x06012578 RID: 75128 RVA: 0x002ADB98 File Offset: 0x002ABD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012579 RID: 75129 RVA: 0x002ADBA4 File Offset: 0x002ABDA4
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
					if (num != 42U)
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
				else
				{
					this.NeedNotify = input.ReadBool();
				}
			}
		}

		// Token: 0x040072A3 RID: 29347
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072A4 RID: 29348
		public const int PayloadFieldNumber = 5;

		// Token: 0x040072A5 RID: 29349
		private PinballSettlePayload payload_;

		// Token: 0x040072A6 RID: 29350
		public const int NeedNotifyFieldNumber = 3;

		// Token: 0x040072A7 RID: 29351
		private bool needNotify_;
	}
}
