using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDC RID: 3036
	[NetMessage(EMessageId.PayShopDirectBuyRequest)]
	public sealed class PayShopDirectBuyRequest : IMessage<PayShopDirectBuyRequest>, IMessage, IEquatable<PayShopDirectBuyRequest>, IDeepCloneable<PayShopDirectBuyRequest>, IBufferMessage
	{
		// Token: 0x0601079C RID: 67484 RVA: 0x002685D1 File Offset: 0x002667D1
		[NullableContext(1)]
		public static PayShopDirectBuyRequest Create()
		{
			return new PayShopDirectBuyRequest();
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0601079D RID: 67485 RVA: 0x002685D8 File Offset: 0x002667D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0601079E RID: 67486 RVA: 0x002685DB File Offset: 0x002667DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopDirectBuyRequest.Descriptor;
			}
		}

		// Token: 0x0601079F RID: 67487 RVA: 0x002685E2 File Offset: 0x002667E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyRequest()
		{
		}

		// Token: 0x060107A0 RID: 67488 RVA: 0x002685F5 File Offset: 0x002667F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyRequest(PayShopDirectBuyRequest other) : this()
		{
			this.id_ = other.id_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060107A1 RID: 67489 RVA: 0x00268626 File Offset: 0x00266826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyRequest Clone()
		{
			return new PayShopDirectBuyRequest(this);
		}

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x060107A2 RID: 67490 RVA: 0x0026862E File Offset: 0x0026682E
		// (set) Token: 0x060107A3 RID: 67491 RVA: 0x00268636 File Offset: 0x00266836
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

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x060107A4 RID: 67492 RVA: 0x0026863F File Offset: 0x0026683F
		// (set) Token: 0x060107A5 RID: 67493 RVA: 0x00268647 File Offset: 0x00266847
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

		// Token: 0x060107A6 RID: 67494 RVA: 0x0026865A File Offset: 0x0026685A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopDirectBuyRequest);
		}

		// Token: 0x060107A7 RID: 67495 RVA: 0x00268668 File Offset: 0x00266868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopDirectBuyRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060107A8 RID: 67496 RVA: 0x002686B8 File Offset: 0x002668B8
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

		// Token: 0x060107A9 RID: 67497 RVA: 0x00268712 File Offset: 0x00266912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060107AA RID: 67498 RVA: 0x0026871F File Offset: 0x0026691F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060107AB RID: 67499 RVA: 0x00268728 File Offset: 0x00266928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Version);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060107AC RID: 67500 RVA: 0x00268788 File Offset: 0x00266988
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

		// Token: 0x060107AD RID: 67501 RVA: 0x002687E4 File Offset: 0x002669E4
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

		// Token: 0x060107AE RID: 67502 RVA: 0x00268839 File Offset: 0x00266A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060107AF RID: 67503 RVA: 0x00268844 File Offset: 0x00266A44
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Version = input.ReadString();
				}
			}
		}

		// Token: 0x040068F9 RID: 26873
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068FA RID: 26874
		public const int IdFieldNumber = 12;

		// Token: 0x040068FB RID: 26875
		private int id_;

		// Token: 0x040068FC RID: 26876
		public const int VersionFieldNumber = 6;

		// Token: 0x040068FD RID: 26877
		private string version_ = "";
	}
}
