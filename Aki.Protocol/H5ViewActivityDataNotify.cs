using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071B RID: 1819
	[NetMessage(EMessageId.H5ViewActivityDataNotify)]
	public sealed class H5ViewActivityDataNotify : IMessage<H5ViewActivityDataNotify>, IMessage, IEquatable<H5ViewActivityDataNotify>, IDeepCloneable<H5ViewActivityDataNotify>, IBufferMessage
	{
		// Token: 0x0600A58A RID: 42378 RVA: 0x0018F5BB File Offset: 0x0018D7BB
		[NullableContext(1)]
		public static H5ViewActivityDataNotify Create()
		{
			return new H5ViewActivityDataNotify();
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x0600A58B RID: 42379 RVA: 0x0018F5C2 File Offset: 0x0018D7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x0600A58C RID: 42380 RVA: 0x0018F5C5 File Offset: 0x0018D7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5ViewActivityDataNotify.Descriptor;
			}
		}

		// Token: 0x0600A58D RID: 42381 RVA: 0x0018F5CC File Offset: 0x0018D7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityDataNotify()
		{
		}

		// Token: 0x0600A58E RID: 42382 RVA: 0x0018F5D4 File Offset: 0x0018D7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityDataNotify(H5ViewActivityDataNotify other) : this()
		{
			this.activityData_ = ((other.activityData_ != null) ? other.activityData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A58F RID: 42383 RVA: 0x0018F609 File Offset: 0x0018D809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityDataNotify Clone()
		{
			return new H5ViewActivityDataNotify(this);
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x0600A590 RID: 42384 RVA: 0x0018F611 File Offset: 0x0018D811
		// (set) Token: 0x0600A591 RID: 42385 RVA: 0x0018F619 File Offset: 0x0018D819
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

		// Token: 0x0600A592 RID: 42386 RVA: 0x0018F622 File Offset: 0x0018D822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5ViewActivityDataNotify);
		}

		// Token: 0x0600A593 RID: 42387 RVA: 0x0018F630 File Offset: 0x0018D830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5ViewActivityDataNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityData, other.ActivityData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x0018F664 File Offset: 0x0018D864
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

		// Token: 0x0600A595 RID: 42389 RVA: 0x0018F6A0 File Offset: 0x0018D8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A596 RID: 42390 RVA: 0x0018F6AD File Offset: 0x0018D8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A597 RID: 42391 RVA: 0x0018F6B6 File Offset: 0x0018D8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ActivityData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A598 RID: 42392 RVA: 0x0018F6E8 File Offset: 0x0018D8E8
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

		// Token: 0x0600A599 RID: 42393 RVA: 0x0018F728 File Offset: 0x0018D928
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

		// Token: 0x0600A59A RID: 42394 RVA: 0x0018F77C File Offset: 0x0018D97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A59B RID: 42395 RVA: 0x0018F788 File Offset: 0x0018D988
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
				if (num != 10U)
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

		// Token: 0x04004C67 RID: 19559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C68 RID: 19560
		public const int ActivityDataFieldNumber = 1;

		// Token: 0x04004C69 RID: 19561
		private H5ViewActivityData activityData_;
	}
}
