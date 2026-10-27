using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001121 RID: 4385
	[NetMessage(EMessageId.RoverRogueShopBuyRequest)]
	public sealed class RoverRogueShopBuyRequest : IMessage<RoverRogueShopBuyRequest>, IMessage, IEquatable<RoverRogueShopBuyRequest>, IDeepCloneable<RoverRogueShopBuyRequest>, IBufferMessage
	{
		// Token: 0x06017648 RID: 95816 RVA: 0x00365E4F File Offset: 0x0036404F
		[NullableContext(1)]
		public static RoverRogueShopBuyRequest Create()
		{
			return new RoverRogueShopBuyRequest();
		}

		// Token: 0x17004E82 RID: 20098
		// (get) Token: 0x06017649 RID: 95817 RVA: 0x00365E56 File Offset: 0x00364056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E83 RID: 20099
		// (get) Token: 0x0601764A RID: 95818 RVA: 0x00365E59 File Offset: 0x00364059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x0601764B RID: 95819 RVA: 0x00365E60 File Offset: 0x00364060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyRequest()
		{
		}

		// Token: 0x0601764C RID: 95820 RVA: 0x00365E68 File Offset: 0x00364068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyRequest(RoverRogueShopBuyRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.goodIncId_ = other.goodIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601764D RID: 95821 RVA: 0x00365E99 File Offset: 0x00364099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyRequest Clone()
		{
			return new RoverRogueShopBuyRequest(this);
		}

		// Token: 0x17004E84 RID: 20100
		// (get) Token: 0x0601764E RID: 95822 RVA: 0x00365EA1 File Offset: 0x003640A1
		// (set) Token: 0x0601764F RID: 95823 RVA: 0x00365EA9 File Offset: 0x003640A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17004E85 RID: 20101
		// (get) Token: 0x06017650 RID: 95824 RVA: 0x00365EB2 File Offset: 0x003640B2
		// (set) Token: 0x06017651 RID: 95825 RVA: 0x00365EBA File Offset: 0x003640BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoodIncId
		{
			get
			{
				return this.goodIncId_;
			}
			set
			{
				this.goodIncId_ = value;
			}
		}

		// Token: 0x06017652 RID: 95826 RVA: 0x00365EC3 File Offset: 0x003640C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopBuyRequest);
		}

		// Token: 0x06017653 RID: 95827 RVA: 0x00365ED1 File Offset: 0x003640D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopBuyRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.GoodIncId == other.GoodIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017654 RID: 95828 RVA: 0x00365F10 File Offset: 0x00364110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.GoodIncId != 0)
			{
				num ^= this.GoodIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017655 RID: 95829 RVA: 0x00365F68 File Offset: 0x00364168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017656 RID: 95830 RVA: 0x00365F75 File Offset: 0x00364175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017657 RID: 95831 RVA: 0x00365F80 File Offset: 0x00364180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.GoodIncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.GoodIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017658 RID: 95832 RVA: 0x00365FDC File Offset: 0x003641DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.GoodIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoodIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017659 RID: 95833 RVA: 0x00366034 File Offset: 0x00364234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopBuyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.GoodIncId != 0)
			{
				this.GoodIncId = other.GoodIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601765A RID: 95834 RVA: 0x00366084 File Offset: 0x00364284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601765B RID: 95835 RVA: 0x00366090 File Offset: 0x00364290
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GoodIncId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B29 RID: 35625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B2A RID: 35626
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04008B2B RID: 35627
		private int activityId_;

		// Token: 0x04008B2C RID: 35628
		public const int GoodIncIdFieldNumber = 14;

		// Token: 0x04008B2D RID: 35629
		private int goodIncId_;
	}
}
