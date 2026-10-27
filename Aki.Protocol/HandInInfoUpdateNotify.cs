using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000736 RID: 1846
	[NetMessage(EMessageId.HandInInfoUpdateNotify)]
	public sealed class HandInInfoUpdateNotify : IMessage<HandInInfoUpdateNotify>, IMessage, IEquatable<HandInInfoUpdateNotify>, IDeepCloneable<HandInInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600A765 RID: 42853 RVA: 0x00192FED File Offset: 0x001911ED
		[NullableContext(1)]
		public static HandInInfoUpdateNotify Create()
		{
			return new HandInInfoUpdateNotify();
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x0600A766 RID: 42854 RVA: 0x00192FF4 File Offset: 0x001911F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x0600A767 RID: 42855 RVA: 0x00192FF7 File Offset: 0x001911F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600A768 RID: 42856 RVA: 0x00192FFE File Offset: 0x001911FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfoUpdateNotify()
		{
		}

		// Token: 0x0600A769 RID: 42857 RVA: 0x00193006 File Offset: 0x00191206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfoUpdateNotify(HandInInfoUpdateNotify other) : this()
		{
			this.handInInfo_ = ((other.handInInfo_ != null) ? other.handInInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A76A RID: 42858 RVA: 0x0019303B File Offset: 0x0019123B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfoUpdateNotify Clone()
		{
			return new HandInInfoUpdateNotify(this);
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x0600A76B RID: 42859 RVA: 0x00193043 File Offset: 0x00191243
		// (set) Token: 0x0600A76C RID: 42860 RVA: 0x0019304B File Offset: 0x0019124B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfo HandInInfo
		{
			get
			{
				return this.handInInfo_;
			}
			set
			{
				this.handInInfo_ = value;
			}
		}

		// Token: 0x0600A76D RID: 42861 RVA: 0x00193054 File Offset: 0x00191254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInInfoUpdateNotify);
		}

		// Token: 0x0600A76E RID: 42862 RVA: 0x00193062 File Offset: 0x00191262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.HandInInfo, other.HandInInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A76F RID: 42863 RVA: 0x00193098 File Offset: 0x00191298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.handInInfo_ != null)
			{
				num ^= this.HandInInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A770 RID: 42864 RVA: 0x001930D4 File Offset: 0x001912D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A771 RID: 42865 RVA: 0x001930E1 File Offset: 0x001912E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A772 RID: 42866 RVA: 0x001930EA File Offset: 0x001912EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.handInInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.HandInInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x0019311C File Offset: 0x0019131C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.handInInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HandInInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A774 RID: 42868 RVA: 0x0019315C File Offset: 0x0019135C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandInInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.handInInfo_ != null)
			{
				if (this.handInInfo_ == null)
				{
					this.HandInInfo = new HandInInfo();
				}
				this.HandInInfo.MergeFrom(other.HandInInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A775 RID: 42869 RVA: 0x001931B0 File Offset: 0x001913B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A776 RID: 42870 RVA: 0x001931BC File Offset: 0x001913BC
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.handInInfo_ == null)
					{
						this.HandInInfo = new HandInInfo();
					}
					input.ReadMessage(this.HandInInfo);
				}
			}
		}

		// Token: 0x04004C8D RID: 19597
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C8E RID: 19598
		public const int HandInInfoFieldNumber = 14;

		// Token: 0x04004C8F RID: 19599
		private HandInInfo handInInfo_;
	}
}
