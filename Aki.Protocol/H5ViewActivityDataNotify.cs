using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072F RID: 1839
	[NetMessage(EMessageId.H5ViewActivityDataNotify)]
	public sealed class H5ViewActivityDataNotify : IMessage<H5ViewActivityDataNotify>, IMessage, IEquatable<H5ViewActivityDataNotify>, IDeepCloneable<H5ViewActivityDataNotify>, IBufferMessage
	{
		// Token: 0x0600A6E0 RID: 42720 RVA: 0x00191FEF File Offset: 0x001901EF
		[NullableContext(1)]
		public static H5ViewActivityDataNotify Create()
		{
			return new H5ViewActivityDataNotify();
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x0600A6E1 RID: 42721 RVA: 0x00191FF6 File Offset: 0x001901F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x0600A6E2 RID: 42722 RVA: 0x00191FF9 File Offset: 0x001901F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5ViewActivityDataNotify.Descriptor;
			}
		}

		// Token: 0x0600A6E3 RID: 42723 RVA: 0x00192000 File Offset: 0x00190200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityDataNotify()
		{
		}

		// Token: 0x0600A6E4 RID: 42724 RVA: 0x00192008 File Offset: 0x00190208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityDataNotify(H5ViewActivityDataNotify other) : this()
		{
			this.activityData_ = ((other.activityData_ != null) ? other.activityData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6E5 RID: 42725 RVA: 0x0019203D File Offset: 0x0019023D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityDataNotify Clone()
		{
			return new H5ViewActivityDataNotify(this);
		}

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x0600A6E6 RID: 42726 RVA: 0x00192045 File Offset: 0x00190245
		// (set) Token: 0x0600A6E7 RID: 42727 RVA: 0x0019204D File Offset: 0x0019024D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityData ActivityData
		{
			get
			{
				return this.activityData_;
			}
			set
			{
				this.activityData_ = value;
			}
		}

		// Token: 0x0600A6E8 RID: 42728 RVA: 0x00192056 File Offset: 0x00190256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5ViewActivityDataNotify);
		}

		// Token: 0x0600A6E9 RID: 42729 RVA: 0x00192064 File Offset: 0x00190264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5ViewActivityDataNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityData, other.ActivityData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6EA RID: 42730 RVA: 0x00192098 File Offset: 0x00190298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.activityData_ != null)
			{
				num ^= this.ActivityData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6EB RID: 42731 RVA: 0x001920D4 File Offset: 0x001902D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A6EC RID: 42732 RVA: 0x001920E1 File Offset: 0x001902E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6ED RID: 42733 RVA: 0x001920EA File Offset: 0x001902EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ActivityData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6EE RID: 42734 RVA: 0x0019211C File Offset: 0x0019031C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.activityData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A6EF RID: 42735 RVA: 0x0019215C File Offset: 0x0019035C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5ViewActivityDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activityData_ != null)
			{
				if (this.activityData_ == null)
				{
					this.ActivityData = new H5ViewActivityData();
				}
				this.ActivityData.MergeFrom(other.ActivityData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A6F0 RID: 42736 RVA: 0x001921B0 File Offset: 0x001903B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6F1 RID: 42737 RVA: 0x001921BC File Offset: 0x001903BC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.activityData_ == null)
					{
						this.ActivityData = new H5ViewActivityData();
					}
					input.ReadMessage(this.ActivityData);
				}
			}
		}

		// Token: 0x04004C6E RID: 19566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C6F RID: 19567
		public const int ActivityDataFieldNumber = 3;

		// Token: 0x04004C70 RID: 19568
		private H5ViewActivityData activityData_;
	}
}
