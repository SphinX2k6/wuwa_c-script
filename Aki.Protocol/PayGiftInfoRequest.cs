using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCC RID: 3020
	[NetMessage(EMessageId.PayGiftInfoRequest)]
	public sealed class PayGiftInfoRequest : IMessage<PayGiftInfoRequest>, IMessage, IEquatable<PayGiftInfoRequest>, IDeepCloneable<PayGiftInfoRequest>, IBufferMessage
	{
		// Token: 0x06010632 RID: 67122 RVA: 0x00264B29 File Offset: 0x00262D29
		[NullableContext(1)]
		public static PayGiftInfoRequest Create()
		{
			return new PayGiftInfoRequest();
		}

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x06010633 RID: 67123 RVA: 0x00264B30 File Offset: 0x00262D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x06010634 RID: 67124 RVA: 0x00264B33 File Offset: 0x00262D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftInfoRequest.Descriptor;
			}
		}

		// Token: 0x06010635 RID: 67125 RVA: 0x00264B3A File Offset: 0x00262D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoRequest()
		{
		}

		// Token: 0x06010636 RID: 67126 RVA: 0x00264B4D File Offset: 0x00262D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoRequest(PayGiftInfoRequest other) : this()
		{
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010637 RID: 67127 RVA: 0x00264B72 File Offset: 0x00262D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfoRequest Clone()
		{
			return new PayGiftInfoRequest(this);
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x06010638 RID: 67128 RVA: 0x00264B7A File Offset: 0x00262D7A
		// (set) Token: 0x06010639 RID: 67129 RVA: 0x00264B82 File Offset: 0x00262D82
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

		// Token: 0x0601063A RID: 67130 RVA: 0x00264B95 File Offset: 0x00262D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftInfoRequest);
		}

		// Token: 0x0601063B RID: 67131 RVA: 0x00264BA3 File Offset: 0x00262DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftInfoRequest other)
		{
			return other != null && (other == this || (!(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601063C RID: 67132 RVA: 0x00264BD8 File Offset: 0x00262DD8
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

		// Token: 0x0601063D RID: 67133 RVA: 0x00264C19 File Offset: 0x00262E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601063E RID: 67134 RVA: 0x00264C26 File Offset: 0x00262E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601063F RID: 67135 RVA: 0x00264C2F File Offset: 0x00262E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010640 RID: 67136 RVA: 0x00264C68 File Offset: 0x00262E68
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

		// Token: 0x06010641 RID: 67137 RVA: 0x00264CAB File Offset: 0x00262EAB
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

		// Token: 0x06010642 RID: 67138 RVA: 0x00264CE1 File Offset: 0x00262EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010643 RID: 67139 RVA: 0x00264CEC File Offset: 0x00262EEC
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
					this.Version = input.ReadString();
				}
			}
		}

		// Token: 0x0400687C RID: 26748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400687D RID: 26749
		public const int VersionFieldNumber = 2;

		// Token: 0x0400687E RID: 26750
		private string version_ = "";
	}
}
