using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD8 RID: 3032
	[NetMessage(EMessageId.PayShopBuyRequest)]
	public sealed class PayShopBuyRequest : IMessage<PayShopBuyRequest>, IMessage, IEquatable<PayShopBuyRequest>, IDeepCloneable<PayShopBuyRequest>, IBufferMessage
	{
		// Token: 0x06010746 RID: 67398 RVA: 0x00267909 File Offset: 0x00265B09
		[NullableContext(1)]
		public static PayShopBuyRequest Create()
		{
			return new PayShopBuyRequest();
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x06010747 RID: 67399 RVA: 0x00267910 File Offset: 0x00265B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x06010748 RID: 67400 RVA: 0x00267913 File Offset: 0x00265B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x06010749 RID: 67401 RVA: 0x0026791A File Offset: 0x00265B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyRequest()
		{
		}

		// Token: 0x0601074A RID: 67402 RVA: 0x0026792D File Offset: 0x00265B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyRequest(PayShopBuyRequest other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601074B RID: 67403 RVA: 0x0026796A File Offset: 0x00265B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopBuyRequest Clone()
		{
			return new PayShopBuyRequest(this);
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0601074C RID: 67404 RVA: 0x00267972 File Offset: 0x00265B72
		// (set) Token: 0x0601074D RID: 67405 RVA: 0x0026797A File Offset: 0x00265B7A
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

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0601074E RID: 67406 RVA: 0x00267983 File Offset: 0x00265B83
		// (set) Token: 0x0601074F RID: 67407 RVA: 0x0026798B File Offset: 0x00265B8B
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

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x06010750 RID: 67408 RVA: 0x00267994 File Offset: 0x00265B94
		// (set) Token: 0x06010751 RID: 67409 RVA: 0x0026799C File Offset: 0x00265B9C
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

		// Token: 0x06010752 RID: 67410 RVA: 0x002679AF File Offset: 0x00265BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopBuyRequest);
		}

		// Token: 0x06010753 RID: 67411 RVA: 0x002679C0 File Offset: 0x00265BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopBuyRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010754 RID: 67412 RVA: 0x00267A20 File Offset: 0x00265C20
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

		// Token: 0x06010755 RID: 67413 RVA: 0x00267A93 File Offset: 0x00265C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010756 RID: 67414 RVA: 0x00267AA0 File Offset: 0x00265CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010757 RID: 67415 RVA: 0x00267AAC File Offset: 0x00265CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Count);
			}
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Version);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010758 RID: 67416 RVA: 0x00267B28 File Offset: 0x00265D28
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

		// Token: 0x06010759 RID: 67417 RVA: 0x00267B9C File Offset: 0x00265D9C
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

		// Token: 0x0601075A RID: 67418 RVA: 0x00267C05 File Offset: 0x00265E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601075B RID: 67419 RVA: 0x00267C10 File Offset: 0x00265E10
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
				if (num != 8U)
				{
					if (num != 26U)
					{
						if (num != 56U)
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
				else
				{
					this.Count = input.ReadInt32();
				}
			}
		}

		// Token: 0x040068DE RID: 26846
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068DF RID: 26847
		public const int IdFieldNumber = 7;

		// Token: 0x040068E0 RID: 26848
		private int id_;

		// Token: 0x040068E1 RID: 26849
		public const int CountFieldNumber = 1;

		// Token: 0x040068E2 RID: 26850
		private int count_;

		// Token: 0x040068E3 RID: 26851
		public const int VersionFieldNumber = 3;

		// Token: 0x040068E4 RID: 26852
		private string version_ = "";
	}
}
