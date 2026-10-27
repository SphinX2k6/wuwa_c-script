using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200008A RID: 138
	[NetMessage(EMessageId.ActivityPayShopBuyRequest)]
	public sealed class ActivityPayShopBuyRequest : IMessage<ActivityPayShopBuyRequest>, IMessage, IEquatable<ActivityPayShopBuyRequest>, IDeepCloneable<ActivityPayShopBuyRequest>, IBufferMessage
	{
		// Token: 0x06001A8A RID: 6794 RVA: 0x0004AF0B File Offset: 0x0004910B
		[NullableContext(1)]
		public static ActivityPayShopBuyRequest Create()
		{
			return new ActivityPayShopBuyRequest();
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0004AF12 File Offset: 0x00049112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0004AF15 File Offset: 0x00049115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityPayShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x0004AF1C File Offset: 0x0004911C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyRequest()
		{
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0004AF3A File Offset: 0x0004913A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyRequest(ActivityPayShopBuyRequest other) : this()
		{
			this.buyItems_ = other.buyItems_.Clone();
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0004AF70 File Offset: 0x00049170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyRequest Clone()
		{
			return new ActivityPayShopBuyRequest(this);
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x0004AF78 File Offset: 0x00049178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityBuyItem> BuyItems
		{
			get
			{
				return this.buyItems_;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x0004AF80 File Offset: 0x00049180
		// (set) Token: 0x06001A92 RID: 6802 RVA: 0x0004AF88 File Offset: 0x00049188
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

		// Token: 0x06001A93 RID: 6803 RVA: 0x0004AF9B File Offset: 0x0004919B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityPayShopBuyRequest);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0004AFAC File Offset: 0x000491AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityPayShopBuyRequest other)
		{
			return other != null && (other == this || (this.buyItems_.Equals(other.buyItems_) && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0004B000 File Offset: 0x00049200
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

		// Token: 0x06001A96 RID: 6806 RVA: 0x0004B04F File Offset: 0x0004924F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0004B05C File Offset: 0x0004925C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0004B068 File Offset: 0x00049268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buyItems_.WriteTo(ref output, ActivityPayShopBuyRequest._repeated_buyItems_codec);
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x0004B0BC File Offset: 0x000492BC
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

		// Token: 0x06001A9A RID: 6810 RVA: 0x0004B114 File Offset: 0x00049314
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

		// Token: 0x06001A9B RID: 6811 RVA: 0x0004B166 File Offset: 0x00049366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0004B170 File Offset: 0x00049370
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
				if (num != 58U)
				{
					if (num != 90U)
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

		// Token: 0x0400225C RID: 8796
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400225D RID: 8797
		public const int BuyItemsFieldNumber = 7;

		// Token: 0x0400225E RID: 8798
		private static readonly FieldCodec<ActivityBuyItem> _repeated_buyItems_codec = FieldCodec.ForMessage<ActivityBuyItem>(58U, ActivityBuyItem.Parser);

		// Token: 0x0400225F RID: 8799
		private readonly RepeatedField<ActivityBuyItem> buyItems_ = new RepeatedField<ActivityBuyItem>();

		// Token: 0x04002260 RID: 8800
		public const int VersionFieldNumber = 11;

		// Token: 0x04002261 RID: 8801
		private string version_ = "";
	}
}
