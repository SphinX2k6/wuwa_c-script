using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200008B RID: 139
	[NetMessage(EMessageId.ActivityPayShopBuyRequest)]
	public sealed class ActivityPayShopBuyRequest : IMessage<ActivityPayShopBuyRequest>, IMessage, IEquatable<ActivityPayShopBuyRequest>, IDeepCloneable<ActivityPayShopBuyRequest>, IBufferMessage
	{
		// Token: 0x06001AD1 RID: 6865 RVA: 0x0004BB1B File Offset: 0x00049D1B
		[NullableContext(1)]
		public static ActivityPayShopBuyRequest Create()
		{
			return new ActivityPayShopBuyRequest();
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x0004BB22 File Offset: 0x00049D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0004BB25 File Offset: 0x00049D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityPayShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0004BB2C File Offset: 0x00049D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyRequest()
		{
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0004BB4A File Offset: 0x00049D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyRequest(ActivityPayShopBuyRequest other) : this()
		{
			this.buyItems_ = other.buyItems_.Clone();
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0004BB80 File Offset: 0x00049D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyRequest Clone()
		{
			return new ActivityPayShopBuyRequest(this);
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x0004BB88 File Offset: 0x00049D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityBuyItem> BuyItems
		{
			get
			{
				return this.buyItems_;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x0004BB90 File Offset: 0x00049D90
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0004BB98 File Offset: 0x00049D98
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

		// Token: 0x06001ADA RID: 6874 RVA: 0x0004BBAB File Offset: 0x00049DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityPayShopBuyRequest);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x0004BBBC File Offset: 0x00049DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityPayShopBuyRequest other)
		{
			return other != null && (other == this || (this.buyItems_.Equals(other.buyItems_) && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0004BC10 File Offset: 0x00049E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buyItems_.GetHashCode();
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

		// Token: 0x06001ADD RID: 6877 RVA: 0x0004BC5F File Offset: 0x00049E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0004BC6C File Offset: 0x00049E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0004BC78 File Offset: 0x00049E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buyItems_.WriteTo(ref output, ActivityPayShopBuyRequest._repeated_buyItems_codec);
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

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0004BCCC File Offset: 0x00049ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buyItems_.CalculateSize(ActivityPayShopBuyRequest._repeated_buyItems_codec);
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

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0004BD24 File Offset: 0x00049F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityPayShopBuyRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.buyItems_.Add(other.buyItems_);
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0004BD76 File Offset: 0x00049F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0004BD80 File Offset: 0x00049F80
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
				if (num != 26U)
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
					this.buyItems_.AddEntriesFrom(ref input, ActivityPayShopBuyRequest._repeated_buyItems_codec);
				}
			}
		}

		// Token: 0x040022BD RID: 8893
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022BE RID: 8894
		public const int BuyItemsFieldNumber = 3;

		// Token: 0x040022BF RID: 8895
		private static readonly FieldCodec<ActivityBuyItem> _repeated_buyItems_codec = FieldCodec.ForMessage<ActivityBuyItem>(26U, ActivityBuyItem.Parser);

		// Token: 0x040022C0 RID: 8896
		private readonly RepeatedField<ActivityBuyItem> buyItems_ = new RepeatedField<ActivityBuyItem>();

		// Token: 0x040022C1 RID: 8897
		public const int VersionFieldNumber = 14;

		// Token: 0x040022C2 RID: 8898
		private string version_ = "";
	}
}
