using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072B RID: 1835
	[NetMessage(EMessageId.H5CircumFluenceActivityDataNotify)]
	public sealed class H5CircumFluenceActivityDataNotify : IMessage<H5CircumFluenceActivityDataNotify>, IMessage, IEquatable<H5CircumFluenceActivityDataNotify>, IDeepCloneable<H5CircumFluenceActivityDataNotify>, IBufferMessage
	{
		// Token: 0x0600A69A RID: 42650 RVA: 0x001918D9 File Offset: 0x0018FAD9
		[NullableContext(1)]
		public static H5CircumFluenceActivityDataNotify Create()
		{
			return new H5CircumFluenceActivityDataNotify();
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x0600A69B RID: 42651 RVA: 0x001918E0 File Offset: 0x0018FAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x0600A69C RID: 42652 RVA: 0x001918E3 File Offset: 0x0018FAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5CircumFluenceActivityDataNotify.Descriptor;
			}
		}

		// Token: 0x0600A69D RID: 42653 RVA: 0x001918EA File Offset: 0x0018FAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityDataNotify()
		{
		}

		// Token: 0x0600A69E RID: 42654 RVA: 0x001918F2 File Offset: 0x0018FAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityDataNotify(H5CircumFluenceActivityDataNotify other) : this()
		{
			this.activityData_ = ((other.activityData_ != null) ? other.activityData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A69F RID: 42655 RVA: 0x00191927 File Offset: 0x0018FB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityDataNotify Clone()
		{
			return new H5CircumFluenceActivityDataNotify(this);
		}

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x0600A6A0 RID: 42656 RVA: 0x0019192F File Offset: 0x0018FB2F
		// (set) Token: 0x0600A6A1 RID: 42657 RVA: 0x00191937 File Offset: 0x0018FB37
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

		// Token: 0x0600A6A2 RID: 42658 RVA: 0x00191940 File Offset: 0x0018FB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5CircumFluenceActivityDataNotify);
		}

		// Token: 0x0600A6A3 RID: 42659 RVA: 0x0019194E File Offset: 0x0018FB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5CircumFluenceActivityDataNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityData, other.ActivityData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x00191984 File Offset: 0x0018FB84
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

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x001919C0 File Offset: 0x0018FBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x001919CD File Offset: 0x0018FBCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x001919D6 File Offset: 0x0018FBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityData_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ActivityData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x00191A08 File Offset: 0x0018FC08
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

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x00191A48 File Offset: 0x0018FC48
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

		// Token: 0x0600A6AA RID: 42666 RVA: 0x00191A9C File Offset: 0x0018FC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6AB RID: 42667 RVA: 0x00191AA8 File Offset: 0x0018FCA8
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
				if (num != 42U)
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

		// Token: 0x04004C64 RID: 19556
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C65 RID: 19557
		public const int ActivityDataFieldNumber = 5;

		// Token: 0x04004C66 RID: 19558
		private H5CircumFluenceActivityData activityData_;
	}
}
