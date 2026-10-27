using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000143 RID: 323
	[NetMessage(EMessageId.BabelActivityItemNumUpdateNotify)]
	public sealed class BabelActivityItemNumUpdateNotify : IMessage<BabelActivityItemNumUpdateNotify>, IMessage, IEquatable<BabelActivityItemNumUpdateNotify>, IDeepCloneable<BabelActivityItemNumUpdateNotify>, IBufferMessage
	{
		// Token: 0x060029BE RID: 10686 RVA: 0x0006D7E8 File Offset: 0x0006B9E8
		[NullableContext(1)]
		public static BabelActivityItemNumUpdateNotify Create()
		{
			return new BabelActivityItemNumUpdateNotify();
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060029BF RID: 10687 RVA: 0x0006D7EF File Offset: 0x0006B9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x0006D7F2 File Offset: 0x0006B9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityItemNumUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x0006D7F9 File Offset: 0x0006B9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityItemNumUpdateNotify()
		{
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x0006D801 File Offset: 0x0006BA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityItemNumUpdateNotify(BabelActivityItemNumUpdateNotify other) : this()
		{
			this.activityItemNum_ = other.activityItemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x0006D826 File Offset: 0x0006BA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityItemNumUpdateNotify Clone()
		{
			return new BabelActivityItemNumUpdateNotify(this);
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x0006D82E File Offset: 0x0006BA2E
		// (set) Token: 0x060029C5 RID: 10693 RVA: 0x0006D836 File Offset: 0x0006BA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityItemNum
		{
			get
			{
				return this.activityItemNum_;
			}
			set
			{
				this.activityItemNum_ = value;
			}
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x0006D83F File Offset: 0x0006BA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityItemNumUpdateNotify);
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x0006D84D File Offset: 0x0006BA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityItemNumUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityItemNum == other.ActivityItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x0006D87C File Offset: 0x0006BA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityItemNum != 0)
			{
				num ^= this.ActivityItemNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x0006D8BB File Offset: 0x0006BABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x0006D8C8 File Offset: 0x0006BAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x0006D8D1 File Offset: 0x0006BAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityItemNum != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityItemNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x0006D904 File Offset: 0x0006BB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityItemNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityItemNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x0006D942 File Offset: 0x0006BB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityItemNumUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityItemNum != 0)
			{
				this.ActivityItemNum = other.ActivityItemNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x0006D973 File Offset: 0x0006BB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x0006D97C File Offset: 0x0006BB7C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityItemNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002717 RID: 10007
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002718 RID: 10008
		public const int ActivityItemNumFieldNumber = 11;

		// Token: 0x04002719 RID: 10009
		private int activityItemNum_;
	}
}
