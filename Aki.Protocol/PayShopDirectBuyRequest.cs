using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BEC RID: 3052
	[NetMessage(EMessageId.PayShopDirectBuyRequest)]
	public sealed class PayShopDirectBuyRequest : IMessage<PayShopDirectBuyRequest>, IMessage, IEquatable<PayShopDirectBuyRequest>, IDeepCloneable<PayShopDirectBuyRequest>, IBufferMessage
	{
		// Token: 0x060108A0 RID: 67744 RVA: 0x0026A495 File Offset: 0x00268695
		[NullableContext(1)]
		public static PayShopDirectBuyRequest Create()
		{
			return new PayShopDirectBuyRequest();
		}

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x060108A1 RID: 67745 RVA: 0x0026A49C File Offset: 0x0026869C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x060108A2 RID: 67746 RVA: 0x0026A49F File Offset: 0x0026869F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopDirectBuyRequest.Descriptor;
			}
		}

		// Token: 0x060108A3 RID: 67747 RVA: 0x0026A4A6 File Offset: 0x002686A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyRequest()
		{
		}

		// Token: 0x060108A4 RID: 67748 RVA: 0x0026A4B9 File Offset: 0x002686B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyRequest(PayShopDirectBuyRequest other) : this()
		{
			this.id_ = other.id_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060108A5 RID: 67749 RVA: 0x0026A4EA File Offset: 0x002686EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyRequest Clone()
		{
			return new PayShopDirectBuyRequest(this);
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x060108A6 RID: 67750 RVA: 0x0026A4F2 File Offset: 0x002686F2
		// (set) Token: 0x060108A7 RID: 67751 RVA: 0x0026A4FA File Offset: 0x002686FA
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

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x060108A8 RID: 67752 RVA: 0x0026A503 File Offset: 0x00268703
		// (set) Token: 0x060108A9 RID: 67753 RVA: 0x0026A50B File Offset: 0x0026870B
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

		// Token: 0x060108AA RID: 67754 RVA: 0x0026A51E File Offset: 0x0026871E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopDirectBuyRequest);
		}

		// Token: 0x060108AB RID: 67755 RVA: 0x0026A52C File Offset: 0x0026872C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopDirectBuyRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060108AC RID: 67756 RVA: 0x0026A57C File Offset: 0x0026877C
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

		// Token: 0x060108AD RID: 67757 RVA: 0x0026A5D6 File Offset: 0x002687D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060108AE RID: 67758 RVA: 0x0026A5E3 File Offset: 0x002687E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060108AF RID: 67759 RVA: 0x0026A5EC File Offset: 0x002687EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
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

		// Token: 0x060108B0 RID: 67760 RVA: 0x0026A64C File Offset: 0x0026884C
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

		// Token: 0x060108B1 RID: 67761 RVA: 0x0026A6A8 File Offset: 0x002688A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopDirectBuyRequest other)
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

		// Token: 0x060108B2 RID: 67762 RVA: 0x0026A6FD File Offset: 0x002688FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060108B3 RID: 67763 RVA: 0x0026A708 File Offset: 0x00268908
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
				if (num != 48U)
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

		// Token: 0x040068E9 RID: 26857
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068EA RID: 26858
		public const int IdFieldNumber = 6;

		// Token: 0x040068EB RID: 26859
		private int id_;

		// Token: 0x040068EC RID: 26860
		public const int VersionFieldNumber = 14;

		// Token: 0x040068ED RID: 26861
		private string version_ = "";
	}
}
