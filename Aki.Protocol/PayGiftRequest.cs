using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCE RID: 3022
	[NetMessage(EMessageId.PayGiftRequest)]
	public sealed class PayGiftRequest : IMessage<PayGiftRequest>, IMessage, IEquatable<PayGiftRequest>, IDeepCloneable<PayGiftRequest>, IBufferMessage
	{
		// Token: 0x0601065A RID: 67162 RVA: 0x002650B3 File Offset: 0x002632B3
		[NullableContext(1)]
		public static PayGiftRequest Create()
		{
			return new PayGiftRequest();
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0601065B RID: 67163 RVA: 0x002650BA File Offset: 0x002632BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0601065C RID: 67164 RVA: 0x002650BD File Offset: 0x002632BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftRequest.Descriptor;
			}
		}

		// Token: 0x0601065D RID: 67165 RVA: 0x002650C4 File Offset: 0x002632C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftRequest()
		{
		}

		// Token: 0x0601065E RID: 67166 RVA: 0x002650D7 File Offset: 0x002632D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftRequest(PayGiftRequest other) : this()
		{
			this.id_ = other.id_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601065F RID: 67167 RVA: 0x00265108 File Offset: 0x00263308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftRequest Clone()
		{
			return new PayGiftRequest(this);
		}

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x06010660 RID: 67168 RVA: 0x00265110 File Offset: 0x00263310
		// (set) Token: 0x06010661 RID: 67169 RVA: 0x00265118 File Offset: 0x00263318
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

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x06010662 RID: 67170 RVA: 0x00265121 File Offset: 0x00263321
		// (set) Token: 0x06010663 RID: 67171 RVA: 0x00265129 File Offset: 0x00263329
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

		// Token: 0x06010664 RID: 67172 RVA: 0x0026513C File Offset: 0x0026333C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftRequest);
		}

		// Token: 0x06010665 RID: 67173 RVA: 0x0026514C File Offset: 0x0026334C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010666 RID: 67174 RVA: 0x0026519C File Offset: 0x0026339C
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

		// Token: 0x06010667 RID: 67175 RVA: 0x002651F6 File Offset: 0x002633F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010668 RID: 67176 RVA: 0x00265203 File Offset: 0x00263403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010669 RID: 67177 RVA: 0x0026520C File Offset: 0x0026340C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601066A RID: 67178 RVA: 0x0026526C File Offset: 0x0026346C
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

		// Token: 0x0601066B RID: 67179 RVA: 0x002652C8 File Offset: 0x002634C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayGiftRequest other)
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

		// Token: 0x0601066C RID: 67180 RVA: 0x0026531D File Offset: 0x0026351D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601066D RID: 67181 RVA: 0x00265328 File Offset: 0x00263528
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
				if (num != 32U)
				{
					if (num != 122U)
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

		// Token: 0x04006887 RID: 26759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006888 RID: 26760
		public const int IdFieldNumber = 4;

		// Token: 0x04006889 RID: 26761
		private int id_;

		// Token: 0x0400688A RID: 26762
		public const int VersionFieldNumber = 15;

		// Token: 0x0400688B RID: 26763
		private string version_ = "";
	}
}
