using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDC RID: 3036
	[NetMessage(EMessageId.PayGiftInfoRequest)]
	public sealed class PayGiftInfoRequest : IMessage<PayGiftInfoRequest>, IMessage, IEquatable<PayGiftInfoRequest>, IDeepCloneable<PayGiftInfoRequest>, IBufferMessage
	{
		// Token: 0x06010736 RID: 67382 RVA: 0x002669E5 File Offset: 0x00264BE5
		[NullableContext(1)]
		public static PayGiftInfoRequest Create()
		{
			return new PayGiftInfoRequest();
		}

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x06010737 RID: 67383 RVA: 0x002669EC File Offset: 0x00264BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x06010738 RID: 67384 RVA: 0x002669EF File Offset: 0x00264BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftInfoRequest.Descriptor;
			}
		}

		// Token: 0x06010739 RID: 67385 RVA: 0x002669F6 File Offset: 0x00264BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoRequest()
		{
		}

		// Token: 0x0601073A RID: 67386 RVA: 0x00266A09 File Offset: 0x00264C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoRequest(PayGiftInfoRequest other) : this()
		{
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601073B RID: 67387 RVA: 0x00266A2E File Offset: 0x00264C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoRequest Clone()
		{
			return new PayGiftInfoRequest(this);
		}

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0601073C RID: 67388 RVA: 0x00266A36 File Offset: 0x00264C36
		// (set) Token: 0x0601073D RID: 67389 RVA: 0x00266A3E File Offset: 0x00264C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601073E RID: 67390 RVA: 0x00266A51 File Offset: 0x00264C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftInfoRequest);
		}

		// Token: 0x0601073F RID: 67391 RVA: 0x00266A5F File Offset: 0x00264C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftInfoRequest other)
		{
			return other != null && (other == this || (!(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010740 RID: 67392 RVA: 0x00266A94 File Offset: 0x00264C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Version.Length != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010741 RID: 67393 RVA: 0x00266AD5 File Offset: 0x00264CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010742 RID: 67394 RVA: 0x00266AE2 File Offset: 0x00264CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010743 RID: 67395 RVA: 0x00266AEB File Offset: 0x00264CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010744 RID: 67396 RVA: 0x00266B24 File Offset: 0x00264D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Version.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010745 RID: 67397 RVA: 0x00266B67 File Offset: 0x00264D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayGiftInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010746 RID: 67398 RVA: 0x00266B9D File Offset: 0x00264D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010747 RID: 67399 RVA: 0x00266BA8 File Offset: 0x00264DA8
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
					this.Version = input.ReadString();
				}
			}
		}

		// Token: 0x0400686C RID: 26732
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400686D RID: 26733
		public const int VersionFieldNumber = 6;

		// Token: 0x0400686E RID: 26734
		private string version_ = "";
	}
}
