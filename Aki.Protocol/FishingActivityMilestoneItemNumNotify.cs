using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000545 RID: 1349
	[NetMessage(EMessageId.FishingActivityMilestoneItemNumNotify)]
	public sealed class FishingActivityMilestoneItemNumNotify : IMessage<FishingActivityMilestoneItemNumNotify>, IMessage, IEquatable<FishingActivityMilestoneItemNumNotify>, IDeepCloneable<FishingActivityMilestoneItemNumNotify>, IBufferMessage
	{
		// Token: 0x06007E3C RID: 32316 RVA: 0x00131A99 File Offset: 0x0012FC99
		[NullableContext(1)]
		public static FishingActivityMilestoneItemNumNotify Create()
		{
			return new FishingActivityMilestoneItemNumNotify();
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06007E3D RID: 32317 RVA: 0x00131AA0 File Offset: 0x0012FCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06007E3E RID: 32318 RVA: 0x00131AA3 File Offset: 0x0012FCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityMilestoneItemNumNotify.Descriptor;
			}
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x00131AAA File Offset: 0x0012FCAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneItemNumNotify()
		{
		}

		// Token: 0x06007E40 RID: 32320 RVA: 0x00131AB2 File Offset: 0x0012FCB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneItemNumNotify(FishingActivityMilestoneItemNumNotify other) : this()
		{
			this.milestoneItemNum_ = other.milestoneItemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E41 RID: 32321 RVA: 0x00131AD7 File Offset: 0x0012FCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneItemNumNotify Clone()
		{
			return new FishingActivityMilestoneItemNumNotify(this);
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x06007E42 RID: 32322 RVA: 0x00131ADF File Offset: 0x0012FCDF
		// (set) Token: 0x06007E43 RID: 32323 RVA: 0x00131AE7 File Offset: 0x0012FCE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MilestoneItemNum
		{
			get
			{
				return this.milestoneItemNum_;
			}
			set
			{
				this.milestoneItemNum_ = value;
			}
		}

		// Token: 0x06007E44 RID: 32324 RVA: 0x00131AF0 File Offset: 0x0012FCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityMilestoneItemNumNotify);
		}

		// Token: 0x06007E45 RID: 32325 RVA: 0x00131AFE File Offset: 0x0012FCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityMilestoneItemNumNotify other)
		{
			return other != null && (other == this || (this.MilestoneItemNum == other.MilestoneItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E46 RID: 32326 RVA: 0x00131B2C File Offset: 0x0012FD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MilestoneItemNum != 0)
			{
				num ^= this.MilestoneItemNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E47 RID: 32327 RVA: 0x00131B6B File Offset: 0x0012FD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E48 RID: 32328 RVA: 0x00131B78 File Offset: 0x0012FD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E49 RID: 32329 RVA: 0x00131B81 File Offset: 0x0012FD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MilestoneItemNum != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.MilestoneItemNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E4A RID: 32330 RVA: 0x00131BB4 File Offset: 0x0012FDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MilestoneItemNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MilestoneItemNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E4B RID: 32331 RVA: 0x00131BF2 File Offset: 0x0012FDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingActivityMilestoneItemNumNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MilestoneItemNum != 0)
			{
				this.MilestoneItemNum = other.MilestoneItemNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E4C RID: 32332 RVA: 0x00131C23 File Offset: 0x0012FE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x00131C2C File Offset: 0x0012FE2C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MilestoneItemNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400400D RID: 16397
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400400E RID: 16398
		public const int MilestoneItemNumFieldNumber = 13;

		// Token: 0x0400400F RID: 16399
		private int milestoneItemNum_;
	}
}
