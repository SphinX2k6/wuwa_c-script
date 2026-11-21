using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072C RID: 1836
	[NetMessage(EMessageId.HarvestActivityLevelDiffRequest)]
	public sealed class HarvestActivityLevelDiffRequest : IMessage<HarvestActivityLevelDiffRequest>, IMessage, IEquatable<HarvestActivityLevelDiffRequest>, IDeepCloneable<HarvestActivityLevelDiffRequest>, IBufferMessage
	{
		// Token: 0x0600A6D8 RID: 42712 RVA: 0x001920CA File Offset: 0x001902CA
		[NullableContext(1)]
		public static HarvestActivityLevelDiffRequest Create()
		{
			return new HarvestActivityLevelDiffRequest();
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x0600A6D9 RID: 42713 RVA: 0x001920D1 File Offset: 0x001902D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x0600A6DA RID: 42714 RVA: 0x001920D4 File Offset: 0x001902D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityLevelDiffRequest.Descriptor;
			}
		}

		// Token: 0x0600A6DB RID: 42715 RVA: 0x001920DB File Offset: 0x001902DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffRequest()
		{
		}

		// Token: 0x0600A6DC RID: 42716 RVA: 0x001920E3 File Offset: 0x001902E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffRequest(HarvestActivityLevelDiffRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this.diff_ = other.diff_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6DD RID: 42717 RVA: 0x00192120 File Offset: 0x00190320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffRequest Clone()
		{
			return new HarvestActivityLevelDiffRequest(this);
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x0600A6DE RID: 42718 RVA: 0x00192128 File Offset: 0x00190328
		// (set) Token: 0x0600A6DF RID: 42719 RVA: 0x00192130 File Offset: 0x00190330
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

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x0600A6E0 RID: 42720 RVA: 0x00192139 File Offset: 0x00190339
		// (set) Token: 0x0600A6E1 RID: 42721 RVA: 0x00192141 File Offset: 0x00190341
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

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x0600A6E2 RID: 42722 RVA: 0x0019214A File Offset: 0x0019034A
		// (set) Token: 0x0600A6E3 RID: 42723 RVA: 0x00192152 File Offset: 0x00190352
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

		// Token: 0x0600A6E4 RID: 42724 RVA: 0x0019215B File Offset: 0x0019035B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityLevelDiffRequest);
		}

		// Token: 0x0600A6E5 RID: 42725 RVA: 0x0019216C File Offset: 0x0019036C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityLevelDiffRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && this.Diff == other.Diff && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6E6 RID: 42726 RVA: 0x001921C8 File Offset: 0x001903C8
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

		// Token: 0x0600A6E7 RID: 42727 RVA: 0x00192239 File Offset: 0x00190439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A6E8 RID: 42728 RVA: 0x00192246 File Offset: 0x00190446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6E9 RID: 42729 RVA: 0x00192250 File Offset: 0x00190450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.InstId);
			}
			if (this.Diff != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Diff);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6EA RID: 42730 RVA: 0x001922C8 File Offset: 0x001904C8
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

		// Token: 0x0600A6EB RID: 42731 RVA: 0x00192338 File Offset: 0x00190538
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

		// Token: 0x0600A6EC RID: 42732 RVA: 0x0019239C File Offset: 0x0019059C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6ED RID: 42733 RVA: 0x001923A8 File Offset: 0x001905A8
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
				if (num != 32U)
				{
					if (num != 40U)
					{
						if (num != 56U)
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

		// Token: 0x04004CBD RID: 19645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CBE RID: 19646
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04004CBF RID: 19647
		private int activityId_;

		// Token: 0x04004CC0 RID: 19648
		public const int InstIdFieldNumber = 5;

		// Token: 0x04004CC1 RID: 19649
		private int instId_;

		// Token: 0x04004CC2 RID: 19650
		public const int DiffFieldNumber = 7;

		// Token: 0x04004CC3 RID: 19651
		private int diff_;
	}
}
