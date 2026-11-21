using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200008C RID: 140
	[NetMessage(EMessageId.ActivityPayShopBuyResponse)]
	public sealed class ActivityPayShopBuyResponse : IMessage<ActivityPayShopBuyResponse>, IMessage, IEquatable<ActivityPayShopBuyResponse>, IDeepCloneable<ActivityPayShopBuyResponse>, IBufferMessage
	{
		// Token: 0x06001AE5 RID: 6885 RVA: 0x0004BDF0 File Offset: 0x00049FF0
		[NullableContext(1)]
		public static ActivityPayShopBuyResponse Create()
		{
			return new ActivityPayShopBuyResponse();
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0004BDF7 File Offset: 0x00049FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x0004BDFA File Offset: 0x00049FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityPayShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0004BE01 File Offset: 0x0004A001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyResponse()
		{
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x0004BE14 File Offset: 0x0004A014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyResponse(ActivityPayShopBuyResponse other) : this()
		{
			this.buyItems_ = other.buyItems_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0004BE4A File Offset: 0x0004A04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyResponse Clone()
		{
			return new ActivityPayShopBuyResponse(this);
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x0004BE52 File Offset: 0x0004A052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityBuyItem> BuyItems
		{
			get
			{
				return this.buyItems_;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x0004BE5A File Offset: 0x0004A05A
		// (set) Token: 0x06001AED RID: 6893 RVA: 0x0004BE62 File Offset: 0x0004A062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0004BE6B File Offset: 0x0004A06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityPayShopBuyResponse);
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0004BE7C File Offset: 0x0004A07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityPayShopBuyResponse other)
		{
			return other != null && (other == this || (this.buyItems_.Equals(other.buyItems_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0004BECC File Offset: 0x0004A0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buyItems_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0004BF1F File Offset: 0x0004A11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0004BF2C File Offset: 0x0004A12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0004BF38 File Offset: 0x0004A138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.buyItems_.WriteTo(ref output, ActivityPayShopBuyResponse._repeated_buyItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x0004BF88 File Offset: 0x0004A188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buyItems_.CalculateSize(ActivityPayShopBuyResponse._repeated_buyItems_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0004BFDC File Offset: 0x0004A1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityPayShopBuyResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.buyItems_.Add(other.buyItems_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0004C029 File Offset: 0x0004A229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0004C034 File Offset: 0x0004A234
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
				if (num != 40U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.buyItems_.AddEntriesFrom(ref input, ActivityPayShopBuyResponse._repeated_buyItems_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040022C3 RID: 8899
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022C4 RID: 8900
		public const int BuyItemsFieldNumber = 12;

		// Token: 0x040022C5 RID: 8901
		private static readonly FieldCodec<ActivityBuyItem> _repeated_buyItems_codec = FieldCodec.ForMessage<ActivityBuyItem>(98U, ActivityBuyItem.Parser);

		// Token: 0x040022C6 RID: 8902
		private readonly RepeatedField<ActivityBuyItem> buyItems_ = new RepeatedField<ActivityBuyItem>();

		// Token: 0x040022C7 RID: 8903
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040022C8 RID: 8904
		private ErrorCode errorCode_;
	}
}
