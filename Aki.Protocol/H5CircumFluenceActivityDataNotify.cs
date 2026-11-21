using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000717 RID: 1815
	[NetMessage(EMessageId.H5CircumFluenceActivityDataNotify)]
	public sealed class H5CircumFluenceActivityDataNotify : IMessage<H5CircumFluenceActivityDataNotify>, IMessage, IEquatable<H5CircumFluenceActivityDataNotify>, IDeepCloneable<H5CircumFluenceActivityDataNotify>, IBufferMessage
	{
		// Token: 0x0600A544 RID: 42308 RVA: 0x0018EEA5 File Offset: 0x0018D0A5
		[NullableContext(1)]
		public static H5CircumFluenceActivityDataNotify Create()
		{
			return new H5CircumFluenceActivityDataNotify();
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x0600A545 RID: 42309 RVA: 0x0018EEAC File Offset: 0x0018D0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x0600A546 RID: 42310 RVA: 0x0018EEAF File Offset: 0x0018D0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5CircumFluenceActivityDataNotify.Descriptor;
			}
		}

		// Token: 0x0600A547 RID: 42311 RVA: 0x0018EEB6 File Offset: 0x0018D0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityDataNotify()
		{
		}

		// Token: 0x0600A548 RID: 42312 RVA: 0x0018EEBE File Offset: 0x0018D0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityDataNotify(H5CircumFluenceActivityDataNotify other) : this()
		{
			this.activityData_ = ((other.activityData_ != null) ? other.activityData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A549 RID: 42313 RVA: 0x0018EEF3 File Offset: 0x0018D0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityDataNotify Clone()
		{
			return new H5CircumFluenceActivityDataNotify(this);
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x0600A54A RID: 42314 RVA: 0x0018EEFB File Offset: 0x0018D0FB
		// (set) Token: 0x0600A54B RID: 42315 RVA: 0x0018EF03 File Offset: 0x0018D103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityData ActivityData
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

		// Token: 0x0600A54C RID: 42316 RVA: 0x0018EF0C File Offset: 0x0018D10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5CircumFluenceActivityDataNotify);
		}

		// Token: 0x0600A54D RID: 42317 RVA: 0x0018EF1A File Offset: 0x0018D11A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5CircumFluenceActivityDataNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityData, other.ActivityData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A54E RID: 42318 RVA: 0x0018EF50 File Offset: 0x0018D150
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

		// Token: 0x0600A54F RID: 42319 RVA: 0x0018EF8C File Offset: 0x0018D18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A550 RID: 42320 RVA: 0x0018EF99 File Offset: 0x0018D199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A551 RID: 42321 RVA: 0x0018EFA2 File Offset: 0x0018D1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ActivityData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A552 RID: 42322 RVA: 0x0018EFD4 File Offset: 0x0018D1D4
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

		// Token: 0x0600A553 RID: 42323 RVA: 0x0018F014 File Offset: 0x0018D214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5CircumFluenceActivityDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activityData_ != null)
			{
				if (this.activityData_ == null)
				{
					this.ActivityData = new H5CircumFluenceActivityData();
				}
				this.ActivityData.MergeFrom(other.ActivityData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A554 RID: 42324 RVA: 0x0018F068 File Offset: 0x0018D268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A555 RID: 42325 RVA: 0x0018F074 File Offset: 0x0018D274
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.activityData_ == null)
					{
						this.ActivityData = new H5CircumFluenceActivityData();
					}
					input.ReadMessage(this.ActivityData);
				}
			}
		}

		// Token: 0x04004C5D RID: 19549
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C5E RID: 19550
		public const int ActivityDataFieldNumber = 4;

		// Token: 0x04004C5F RID: 19551
		private H5CircumFluenceActivityData activityData_;
	}
}
