using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000971 RID: 2417
	[NetMessage(EMessageId.MailBindInfoResponse)]
	public sealed class MailBindInfoResponse : IMessage<MailBindInfoResponse>, IMessage, IEquatable<MailBindInfoResponse>, IDeepCloneable<MailBindInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D4C6 RID: 54470 RVA: 0x001F535A File Offset: 0x001F355A
		[NullableContext(1)]
		public static MailBindInfoResponse Create()
		{
			return new MailBindInfoResponse();
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x0600D4C7 RID: 54471 RVA: 0x001F5361 File Offset: 0x001F3561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x0600D4C8 RID: 54472 RVA: 0x001F5364 File Offset: 0x001F3564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D4C9 RID: 54473 RVA: 0x001F536B File Offset: 0x001F356B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoResponse()
		{
		}

		// Token: 0x0600D4CA RID: 54474 RVA: 0x001F5373 File Offset: 0x001F3573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoResponse(MailBindInfoResponse other) : this()
		{
			this.mailBindInfo_ = ((other.mailBindInfo_ != null) ? other.mailBindInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4CB RID: 54475 RVA: 0x001F53A8 File Offset: 0x001F35A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoResponse Clone()
		{
			return new MailBindInfoResponse(this);
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x0600D4CC RID: 54476 RVA: 0x001F53B0 File Offset: 0x001F35B0
		// (set) Token: 0x0600D4CD RID: 54477 RVA: 0x001F53B8 File Offset: 0x001F35B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfo MailBindInfo
		{
			get
			{
				return this.mailBindInfo_;
			}
			set
			{
				this.mailBindInfo_ = value;
			}
		}

		// Token: 0x0600D4CE RID: 54478 RVA: 0x001F53C1 File Offset: 0x001F35C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindInfoResponse);
		}

		// Token: 0x0600D4CF RID: 54479 RVA: 0x001F53CF File Offset: 0x001F35CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.MailBindInfo, other.MailBindInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D4D0 RID: 54480 RVA: 0x001F5404 File Offset: 0x001F3604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.mailBindInfo_ != null)
			{
				num ^= this.MailBindInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D4D1 RID: 54481 RVA: 0x001F5440 File Offset: 0x001F3640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D4D2 RID: 54482 RVA: 0x001F544D File Offset: 0x001F364D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4D3 RID: 54483 RVA: 0x001F5456 File Offset: 0x001F3656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mailBindInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MailBindInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4D4 RID: 54484 RVA: 0x001F5488 File Offset: 0x001F3688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.mailBindInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MailBindInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D4D5 RID: 54485 RVA: 0x001F54C8 File Offset: 0x001F36C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.mailBindInfo_ != null)
			{
				if (this.mailBindInfo_ == null)
				{
					this.MailBindInfo = new MailBindInfo();
				}
				this.MailBindInfo.MergeFrom(other.MailBindInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4D6 RID: 54486 RVA: 0x001F551C File Offset: 0x001F371C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4D7 RID: 54487 RVA: 0x001F5528 File Offset: 0x001F3728
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
					if (this.mailBindInfo_ == null)
					{
						this.MailBindInfo = new MailBindInfo();
					}
					input.ReadMessage(this.MailBindInfo);
				}
			}
		}

		// Token: 0x04005937 RID: 22839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005938 RID: 22840
		public const int MailBindInfoFieldNumber = 1;

		// Token: 0x04005939 RID: 22841
		private MailBindInfo mailBindInfo_;
	}
}
