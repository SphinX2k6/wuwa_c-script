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
	[NetMessage(EMessageId.ActivityPayShopBuyResponse)]
	public sealed class ActivityPayShopBuyResponse : IMessage<ActivityPayShopBuyResponse>, IMessage, IEquatable<ActivityPayShopBuyResponse>, IDeepCloneable<ActivityPayShopBuyResponse>, IBufferMessage
	{
		// Token: 0x06001A9E RID: 6814 RVA: 0x0004B1E0 File Offset: 0x000493E0
		[NullableContext(1)]
		public static ActivityPayShopBuyResponse Create()
		{
			return new ActivityPayShopBuyResponse();
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x0004B1E7 File Offset: 0x000493E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0004B1EA File Offset: 0x000493EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityPayShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x0004B1F1 File Offset: 0x000493F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyResponse()
		{
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x0004B204 File Offset: 0x00049404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyResponse(ActivityPayShopBuyResponse other) : this()
		{
			this.buyItems_ = other.buyItems_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x0004B23A File Offset: 0x0004943A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPayShopBuyResponse Clone()
		{
			return new ActivityPayShopBuyResponse(this);
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0004B242 File Offset: 0x00049442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityBuyItem> BuyItems
		{
			get
			{
				return this.buyItems_;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x0004B24A File Offset: 0x0004944A
		// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x0004B252 File Offset: 0x00049452
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

		// Token: 0x06001AA7 RID: 6823 RVA: 0x0004B25B File Offset: 0x0004945B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityPayShopBuyResponse);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0004B26C File Offset: 0x0004946C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityPayShopBuyResponse other)
		{
			return other != null && (other == this || (this.buyItems_.Equals(other.buyItems_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0004B2BC File Offset: 0x000494BC
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

		// Token: 0x06001AAA RID: 6826 RVA: 0x0004B30F File Offset: 0x0004950F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0004B31C File Offset: 0x0004951C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0004B328 File Offset: 0x00049528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buyItems_.WriteTo(ref output, ActivityPayShopBuyResponse._repeated_buyItems_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0004B378 File Offset: 0x00049578
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

		// Token: 0x06001AAE RID: 6830 RVA: 0x0004B3CC File Offset: 0x000495CC
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

		// Token: 0x06001AAF RID: 6831 RVA: 0x0004B419 File Offset: 0x00049619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0004B424 File Offset: 0x00049624
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
				if (num != 66U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.buyItems_.AddEntriesFrom(ref input, ActivityPayShopBuyResponse._repeated_buyItems_codec);
				}
			}
		}

		// Token: 0x04002262 RID: 8802
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002263 RID: 8803
		public const int BuyItemsFieldNumber = 8;

		// Token: 0x04002264 RID: 8804
		private static readonly FieldCodec<ActivityBuyItem> _repeated_buyItems_codec = FieldCodec.ForMessage<ActivityBuyItem>(66U, ActivityBuyItem.Parser);

		// Token: 0x04002265 RID: 8805
		private readonly RepeatedField<ActivityBuyItem> buyItems_ = new RepeatedField<ActivityBuyItem>();

		// Token: 0x04002266 RID: 8806
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002267 RID: 8807
		private ErrorCode errorCode_;
	}
}
