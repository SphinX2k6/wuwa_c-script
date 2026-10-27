using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF0 RID: 3056
	[NetMessage(EMessageId.PayShopInfoRequest)]
	public sealed class PayShopInfoRequest : IMessage<PayShopInfoRequest>, IMessage, IEquatable<PayShopInfoRequest>, IDeepCloneable<PayShopInfoRequest>, IBufferMessage
	{
		// Token: 0x06010908 RID: 67848 RVA: 0x0026B8F5 File Offset: 0x00269AF5
		[NullableContext(1)]
		public static PayShopInfoRequest Create()
		{
			return new PayShopInfoRequest();
		}

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x06010909 RID: 67849 RVA: 0x0026B8FC File Offset: 0x00269AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x0601090A RID: 67850 RVA: 0x0026B8FF File Offset: 0x00269AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601090B RID: 67851 RVA: 0x0026B906 File Offset: 0x00269B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoRequest()
		{
		}

		// Token: 0x0601090C RID: 67852 RVA: 0x0026B919 File Offset: 0x00269B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoRequest(PayShopInfoRequest other) : this()
		{
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601090D RID: 67853 RVA: 0x0026B93E File Offset: 0x00269B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfoRequest Clone()
		{
			return new PayShopInfoRequest(this);
		}

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x0601090E RID: 67854 RVA: 0x0026B946 File Offset: 0x00269B46
		// (set) Token: 0x0601090F RID: 67855 RVA: 0x0026B94E File Offset: 0x00269B4E
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

		// Token: 0x06010910 RID: 67856 RVA: 0x0026B961 File Offset: 0x00269B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopInfoRequest);
		}

		// Token: 0x06010911 RID: 67857 RVA: 0x0026B96F File Offset: 0x00269B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopInfoRequest other)
		{
			return other != null && (other == this || (!(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010912 RID: 67858 RVA: 0x0026B9A4 File Offset: 0x00269BA4
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

		// Token: 0x06010913 RID: 67859 RVA: 0x0026B9E5 File Offset: 0x00269BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010914 RID: 67860 RVA: 0x0026B9F2 File Offset: 0x00269BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010915 RID: 67861 RVA: 0x0026B9FB File Offset: 0x00269BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010916 RID: 67862 RVA: 0x0026BA34 File Offset: 0x00269C34
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

		// Token: 0x06010917 RID: 67863 RVA: 0x0026BA77 File Offset: 0x00269C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopInfoRequest other)
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

		// Token: 0x06010918 RID: 67864 RVA: 0x0026BAAD File Offset: 0x00269CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010919 RID: 67865 RVA: 0x0026BAB8 File Offset: 0x00269CB8
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Version = input.ReadString();
				}
			}
		}

		// Token: 0x0400691D RID: 26909
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400691E RID: 26910
		public const int VersionFieldNumber = 5;

		// Token: 0x0400691F RID: 26911
		private string version_ = "";
	}
}
