using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000787 RID: 1927
	[NetMessage(EMessageId.HonamiStoryLimitShopConsumeNumNotify)]
	public sealed class HonamiStoryLimitShopConsumeNumNotify : IMessage<HonamiStoryLimitShopConsumeNumNotify>, IMessage, IEquatable<HonamiStoryLimitShopConsumeNumNotify>, IDeepCloneable<HonamiStoryLimitShopConsumeNumNotify>, IBufferMessage
	{
		// Token: 0x0600AE13 RID: 44563 RVA: 0x001A260B File Offset: 0x001A080B
		[NullableContext(1)]
		public static HonamiStoryLimitShopConsumeNumNotify Create()
		{
			return new HonamiStoryLimitShopConsumeNumNotify();
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x0600AE14 RID: 44564 RVA: 0x001A2612 File Offset: 0x001A0812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x0600AE15 RID: 44565 RVA: 0x001A2615 File Offset: 0x001A0815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLimitShopConsumeNumNotify.Descriptor;
			}
		}

		// Token: 0x0600AE16 RID: 44566 RVA: 0x001A261C File Offset: 0x001A081C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitShopConsumeNumNotify()
		{
		}

		// Token: 0x0600AE17 RID: 44567 RVA: 0x001A2624 File Offset: 0x001A0824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitShopConsumeNumNotify(HonamiStoryLimitShopConsumeNumNotify other) : this()
		{
			this.limitItemConsumeNum_ = other.limitItemConsumeNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE18 RID: 44568 RVA: 0x001A2649 File Offset: 0x001A0849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitShopConsumeNumNotify Clone()
		{
			return new HonamiStoryLimitShopConsumeNumNotify(this);
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x0600AE19 RID: 44569 RVA: 0x001A2651 File Offset: 0x001A0851
		// (set) Token: 0x0600AE1A RID: 44570 RVA: 0x001A2659 File Offset: 0x001A0859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitItemConsumeNum
		{
			get
			{
				return this.limitItemConsumeNum_;
			}
			set
			{
				this.limitItemConsumeNum_ = value;
			}
		}

		// Token: 0x0600AE1B RID: 44571 RVA: 0x001A2662 File Offset: 0x001A0862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLimitShopConsumeNumNotify);
		}

		// Token: 0x0600AE1C RID: 44572 RVA: 0x001A2670 File Offset: 0x001A0870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLimitShopConsumeNumNotify other)
		{
			return other != null && (other == this || (this.LimitItemConsumeNum == other.LimitItemConsumeNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE1D RID: 44573 RVA: 0x001A26A0 File Offset: 0x001A08A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LimitItemConsumeNum != 0)
			{
				num ^= this.LimitItemConsumeNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE1E RID: 44574 RVA: 0x001A26DF File Offset: 0x001A08DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE1F RID: 44575 RVA: 0x001A26EC File Offset: 0x001A08EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE20 RID: 44576 RVA: 0x001A26F5 File Offset: 0x001A08F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LimitItemConsumeNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LimitItemConsumeNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE21 RID: 44577 RVA: 0x001A2728 File Offset: 0x001A0928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LimitItemConsumeNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitItemConsumeNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE22 RID: 44578 RVA: 0x001A2766 File Offset: 0x001A0966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLimitShopConsumeNumNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LimitItemConsumeNum != 0)
			{
				this.LimitItemConsumeNum = other.LimitItemConsumeNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE23 RID: 44579 RVA: 0x001A2797 File Offset: 0x001A0997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE24 RID: 44580 RVA: 0x001A27A0 File Offset: 0x001A09A0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LimitItemConsumeNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004EA3 RID: 20131
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EA4 RID: 20132
		public const int LimitItemConsumeNumFieldNumber = 1;

		// Token: 0x04004EA5 RID: 20133
		private int limitItemConsumeNum_;
	}
}
