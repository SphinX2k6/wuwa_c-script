using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE5 RID: 3045
	[NetMessage(EMessageId.PayItemRequest)]
	public sealed class PayItemRequest : IMessage<PayItemRequest>, IMessage, IEquatable<PayItemRequest>, IDeepCloneable<PayItemRequest>, IBufferMessage
	{
		// Token: 0x06010808 RID: 67592 RVA: 0x00268D3E File Offset: 0x00266F3E
		[NullableContext(1)]
		public static PayItemRequest Create()
		{
			return new PayItemRequest();
		}

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x06010809 RID: 67593 RVA: 0x00268D45 File Offset: 0x00266F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0601080A RID: 67594 RVA: 0x00268D48 File Offset: 0x00266F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayItemRequest.Descriptor;
			}
		}

		// Token: 0x0601080B RID: 67595 RVA: 0x00268D4F File Offset: 0x00266F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemRequest()
		{
		}

		// Token: 0x0601080C RID: 67596 RVA: 0x00268D62 File Offset: 0x00266F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemRequest(PayItemRequest other) : this()
		{
			this.id_ = other.id_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601080D RID: 67597 RVA: 0x00268D93 File Offset: 0x00266F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemRequest Clone()
		{
			return new PayItemRequest(this);
		}

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0601080E RID: 67598 RVA: 0x00268D9B File Offset: 0x00266F9B
		// (set) Token: 0x0601080F RID: 67599 RVA: 0x00268DA3 File Offset: 0x00266FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x06010810 RID: 67600 RVA: 0x00268DAC File Offset: 0x00266FAC
		// (set) Token: 0x06010811 RID: 67601 RVA: 0x00268DB4 File Offset: 0x00266FB4
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

		// Token: 0x06010812 RID: 67602 RVA: 0x00268DC7 File Offset: 0x00266FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayItemRequest);
		}

		// Token: 0x06010813 RID: 67603 RVA: 0x00268DD8 File Offset: 0x00266FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayItemRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010814 RID: 67604 RVA: 0x00268E28 File Offset: 0x00267028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
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

		// Token: 0x06010815 RID: 67605 RVA: 0x00268E82 File Offset: 0x00267082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010816 RID: 67606 RVA: 0x00268E8F File Offset: 0x0026708F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010817 RID: 67607 RVA: 0x00268E98 File Offset: 0x00267098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010818 RID: 67608 RVA: 0x00268EF8 File Offset: 0x002670F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
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

		// Token: 0x06010819 RID: 67609 RVA: 0x00268F54 File Offset: 0x00267154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601081A RID: 67610 RVA: 0x00268FA9 File Offset: 0x002671A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601081B RID: 67611 RVA: 0x00268FB4 File Offset: 0x002671B4
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
				if (num != 64U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Version = input.ReadString();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040068B9 RID: 26809
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068BA RID: 26810
		public const int IdFieldNumber = 8;

		// Token: 0x040068BB RID: 26811
		private int id_;

		// Token: 0x040068BC RID: 26812
		public const int VersionFieldNumber = 14;

		// Token: 0x040068BD RID: 26813
		private string version_ = "";
	}
}
