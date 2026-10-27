using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE8 RID: 3048
	[NetMessage(EMessageId.PayShopBuyRequest)]
	public sealed class PayShopBuyRequest : IMessage<PayShopBuyRequest>, IMessage, IEquatable<PayShopBuyRequest>, IDeepCloneable<PayShopBuyRequest>, IBufferMessage
	{
		// Token: 0x0601084A RID: 67658 RVA: 0x002697CD File Offset: 0x002679CD
		[NullableContext(1)]
		public static PayShopBuyRequest Create()
		{
			return new PayShopBuyRequest();
		}

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x0601084B RID: 67659 RVA: 0x002697D4 File Offset: 0x002679D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x0601084C RID: 67660 RVA: 0x002697D7 File Offset: 0x002679D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x0601084D RID: 67661 RVA: 0x002697DE File Offset: 0x002679DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyRequest()
		{
		}

		// Token: 0x0601084E RID: 67662 RVA: 0x002697F1 File Offset: 0x002679F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyRequest(PayShopBuyRequest other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601084F RID: 67663 RVA: 0x0026982E File Offset: 0x00267A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyRequest Clone()
		{
			return new PayShopBuyRequest(this);
		}

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x06010850 RID: 67664 RVA: 0x00269836 File Offset: 0x00267A36
		// (set) Token: 0x06010851 RID: 67665 RVA: 0x0026983E File Offset: 0x00267A3E
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

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x06010852 RID: 67666 RVA: 0x00269847 File Offset: 0x00267A47
		// (set) Token: 0x06010853 RID: 67667 RVA: 0x0026984F File Offset: 0x00267A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x06010854 RID: 67668 RVA: 0x00269858 File Offset: 0x00267A58
		// (set) Token: 0x06010855 RID: 67669 RVA: 0x00269860 File Offset: 0x00267A60
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

		// Token: 0x06010856 RID: 67670 RVA: 0x00269873 File Offset: 0x00267A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopBuyRequest);
		}

		// Token: 0x06010857 RID: 67671 RVA: 0x00269884 File Offset: 0x00267A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopBuyRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010858 RID: 67672 RVA: 0x002698E4 File Offset: 0x00267AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
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

		// Token: 0x06010859 RID: 67673 RVA: 0x00269957 File Offset: 0x00267B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601085A RID: 67674 RVA: 0x00269964 File Offset: 0x00267B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601085B RID: 67675 RVA: 0x00269970 File Offset: 0x00267B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Count);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601085C RID: 67676 RVA: 0x002699EC File Offset: 0x00267BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
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

		// Token: 0x0601085D RID: 67677 RVA: 0x00269A60 File Offset: 0x00267C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopBuyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601085E RID: 67678 RVA: 0x00269AC9 File Offset: 0x00267CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601085F RID: 67679 RVA: 0x00269AD4 File Offset: 0x00267CD4
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
					if (num != 48U)
					{
						if (num != 82U)
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
				else
				{
					this.Count = input.ReadInt32();
				}
			}
		}

		// Token: 0x040068CE RID: 26830
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068CF RID: 26831
		public const int IdFieldNumber = 6;

		// Token: 0x040068D0 RID: 26832
		private int id_;

		// Token: 0x040068D1 RID: 26833
		public const int CountFieldNumber = 4;

		// Token: 0x040068D2 RID: 26834
		private int count_;

		// Token: 0x040068D3 RID: 26835
		public const int VersionFieldNumber = 10;

		// Token: 0x040068D4 RID: 26836
		private string version_ = "";
	}
}
