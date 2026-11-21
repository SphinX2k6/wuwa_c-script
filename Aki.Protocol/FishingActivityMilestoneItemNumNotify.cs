using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000530 RID: 1328
	[NetMessage(EMessageId.FishingActivityMilestoneItemNumNotify)]
	public sealed class FishingActivityMilestoneItemNumNotify : IMessage<FishingActivityMilestoneItemNumNotify>, IMessage, IEquatable<FishingActivityMilestoneItemNumNotify>, IDeepCloneable<FishingActivityMilestoneItemNumNotify>, IBufferMessage
	{
		// Token: 0x06007CD4 RID: 31956 RVA: 0x0012EE95 File Offset: 0x0012D095
		[NullableContext(1)]
		public static FishingActivityMilestoneItemNumNotify Create()
		{
			return new FishingActivityMilestoneItemNumNotify();
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06007CD5 RID: 31957 RVA: 0x0012EE9C File Offset: 0x0012D09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06007CD6 RID: 31958 RVA: 0x0012EE9F File Offset: 0x0012D09F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityMilestoneItemNumNotify.Descriptor;
			}
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x0012EEA6 File Offset: 0x0012D0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneItemNumNotify()
		{
		}

		// Token: 0x06007CD8 RID: 31960 RVA: 0x0012EEAE File Offset: 0x0012D0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneItemNumNotify(FishingActivityMilestoneItemNumNotify other) : this()
		{
			this.milestoneItemNum_ = other.milestoneItemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CD9 RID: 31961 RVA: 0x0012EED3 File Offset: 0x0012D0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneItemNumNotify Clone()
		{
			return new FishingActivityMilestoneItemNumNotify(this);
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06007CDA RID: 31962 RVA: 0x0012EEDB File Offset: 0x0012D0DB
		// (set) Token: 0x06007CDB RID: 31963 RVA: 0x0012EEE3 File Offset: 0x0012D0E3
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

		// Token: 0x06007CDC RID: 31964 RVA: 0x0012EEEC File Offset: 0x0012D0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityMilestoneItemNumNotify);
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x0012EEFA File Offset: 0x0012D0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityMilestoneItemNumNotify other)
		{
			return other != null && (other == this || (this.MilestoneItemNum == other.MilestoneItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x0012EF28 File Offset: 0x0012D128
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

		// Token: 0x06007CDF RID: 31967 RVA: 0x0012EF67 File Offset: 0x0012D167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007CE0 RID: 31968 RVA: 0x0012EF74 File Offset: 0x0012D174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CE1 RID: 31969 RVA: 0x0012EF7D File Offset: 0x0012D17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MilestoneItemNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MilestoneItemNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CE2 RID: 31970 RVA: 0x0012EFB0 File Offset: 0x0012D1B0
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

		// Token: 0x06007CE3 RID: 31971 RVA: 0x0012EFEE File Offset: 0x0012D1EE
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

		// Token: 0x06007CE4 RID: 31972 RVA: 0x0012F01F File Offset: 0x0012D21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x0012F028 File Offset: 0x0012D228
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MilestoneItemNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004003 RID: 16387
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004004 RID: 16388
		public const int MilestoneItemNumFieldNumber = 2;

		// Token: 0x04004005 RID: 16389
		private int milestoneItemNum_;
	}
}
