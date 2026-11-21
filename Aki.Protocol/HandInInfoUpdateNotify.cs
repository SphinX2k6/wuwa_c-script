using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000722 RID: 1826
	[NetMessage(EMessageId.HandInInfoUpdateNotify)]
	public sealed class HandInInfoUpdateNotify : IMessage<HandInInfoUpdateNotify>, IMessage, IEquatable<HandInInfoUpdateNotify>, IDeepCloneable<HandInInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600A60F RID: 42511 RVA: 0x001905B9 File Offset: 0x0018E7B9
		[NullableContext(1)]
		public static HandInInfoUpdateNotify Create()
		{
			return new HandInInfoUpdateNotify();
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x0600A610 RID: 42512 RVA: 0x001905C0 File Offset: 0x0018E7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x0600A611 RID: 42513 RVA: 0x001905C3 File Offset: 0x0018E7C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600A612 RID: 42514 RVA: 0x001905CA File Offset: 0x0018E7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfoUpdateNotify()
		{
		}

		// Token: 0x0600A613 RID: 42515 RVA: 0x001905D2 File Offset: 0x0018E7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfoUpdateNotify(HandInInfoUpdateNotify other) : this()
		{
			this.handInInfo_ = ((other.handInInfo_ != null) ? other.handInInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A614 RID: 42516 RVA: 0x00190607 File Offset: 0x0018E807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInInfoUpdateNotify Clone()
		{
			return new HandInInfoUpdateNotify(this);
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x0600A615 RID: 42517 RVA: 0x0019060F File Offset: 0x0018E80F
		// (set) Token: 0x0600A616 RID: 42518 RVA: 0x00190617 File Offset: 0x0018E817
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

		// Token: 0x0600A617 RID: 42519 RVA: 0x00190620 File Offset: 0x0018E820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInInfoUpdateNotify);
		}

		// Token: 0x0600A618 RID: 42520 RVA: 0x0019062E File Offset: 0x0018E82E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.HandInInfo, other.HandInInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A619 RID: 42521 RVA: 0x00190664 File Offset: 0x0018E864
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

		// Token: 0x0600A61A RID: 42522 RVA: 0x001906A0 File Offset: 0x0018E8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A61B RID: 42523 RVA: 0x001906AD File Offset: 0x0018E8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A61C RID: 42524 RVA: 0x001906B6 File Offset: 0x0018E8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.handInInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.HandInInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A61D RID: 42525 RVA: 0x001906E8 File Offset: 0x0018E8E8
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

		// Token: 0x0600A61E RID: 42526 RVA: 0x00190728 File Offset: 0x0018E928
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

		// Token: 0x0600A61F RID: 42527 RVA: 0x0019077C File Offset: 0x0018E97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A620 RID: 42528 RVA: 0x00190788 File Offset: 0x0018E988
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
				if (num != 18U)
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

		// Token: 0x04004C86 RID: 19590
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C87 RID: 19591
		public const int HandInInfoFieldNumber = 2;

		// Token: 0x04004C88 RID: 19592
		private HandInInfo handInInfo_;
	}
}
