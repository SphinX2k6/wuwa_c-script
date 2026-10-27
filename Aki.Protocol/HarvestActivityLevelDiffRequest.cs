using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000740 RID: 1856
	[NetMessage(EMessageId.HarvestActivityLevelDiffRequest)]
	public sealed class HarvestActivityLevelDiffRequest : IMessage<HarvestActivityLevelDiffRequest>, IMessage, IEquatable<HarvestActivityLevelDiffRequest>, IDeepCloneable<HarvestActivityLevelDiffRequest>, IBufferMessage
	{
		// Token: 0x0600A82E RID: 43054 RVA: 0x00194AF6 File Offset: 0x00192CF6
		[NullableContext(1)]
		public static HarvestActivityLevelDiffRequest Create()
		{
			return new HarvestActivityLevelDiffRequest();
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x0600A82F RID: 43055 RVA: 0x00194AFD File Offset: 0x00192CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x0600A830 RID: 43056 RVA: 0x00194B00 File Offset: 0x00192D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityLevelDiffRequest.Descriptor;
			}
		}

		// Token: 0x0600A831 RID: 43057 RVA: 0x00194B07 File Offset: 0x00192D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffRequest()
		{
		}

		// Token: 0x0600A832 RID: 43058 RVA: 0x00194B0F File Offset: 0x00192D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffRequest(HarvestActivityLevelDiffRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this.diff_ = other.diff_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A833 RID: 43059 RVA: 0x00194B4C File Offset: 0x00192D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffRequest Clone()
		{
			return new HarvestActivityLevelDiffRequest(this);
		}

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x0600A834 RID: 43060 RVA: 0x00194B54 File Offset: 0x00192D54
		// (set) Token: 0x0600A835 RID: 43061 RVA: 0x00194B5C File Offset: 0x00192D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x0600A836 RID: 43062 RVA: 0x00194B65 File Offset: 0x00192D65
		// (set) Token: 0x0600A837 RID: 43063 RVA: 0x00194B6D File Offset: 0x00192D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x0600A838 RID: 43064 RVA: 0x00194B76 File Offset: 0x00192D76
		// (set) Token: 0x0600A839 RID: 43065 RVA: 0x00194B7E File Offset: 0x00192D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Diff
		{
			get
			{
				return this.diff_;
			}
			set
			{
				this.diff_ = value;
			}
		}

		// Token: 0x0600A83A RID: 43066 RVA: 0x00194B87 File Offset: 0x00192D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityLevelDiffRequest);
		}

		// Token: 0x0600A83B RID: 43067 RVA: 0x00194B98 File Offset: 0x00192D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityLevelDiffRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && this.Diff == other.Diff && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A83C RID: 43068 RVA: 0x00194BF4 File Offset: 0x00192DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.Diff != 0)
			{
				num ^= this.Diff.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A83D RID: 43069 RVA: 0x00194C65 File Offset: 0x00192E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A83E RID: 43070 RVA: 0x00194C72 File Offset: 0x00192E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A83F RID: 43071 RVA: 0x00194C7C File Offset: 0x00192E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.InstId);
			}
			if (this.Diff != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Diff);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A840 RID: 43072 RVA: 0x00194CF4 File Offset: 0x00192EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.Diff != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Diff);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A841 RID: 43073 RVA: 0x00194D64 File Offset: 0x00192F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityLevelDiffRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.Diff != 0)
			{
				this.Diff = other.Diff;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A842 RID: 43074 RVA: 0x00194DC8 File Offset: 0x00192FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A843 RID: 43075 RVA: 0x00194DD4 File Offset: 0x00192FD4
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
				if (num != 40U)
				{
					if (num != 48U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Diff = input.ReadInt32();
						}
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004CC4 RID: 19652
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CC5 RID: 19653
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04004CC6 RID: 19654
		private int activityId_;

		// Token: 0x04004CC7 RID: 19655
		public const int InstIdFieldNumber = 6;

		// Token: 0x04004CC8 RID: 19656
		private int instId_;

		// Token: 0x04004CC9 RID: 19657
		public const int DiffFieldNumber = 10;

		// Token: 0x04004CCA RID: 19658
		private int diff_;
	}
}
