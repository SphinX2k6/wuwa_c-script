using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072F RID: 1839
	[NetMessage(EMessageId.HarvestActivityLevelRequest)]
	public sealed class HarvestActivityLevelRequest : IMessage<HarvestActivityLevelRequest>, IMessage, IEquatable<HarvestActivityLevelRequest>, IDeepCloneable<HarvestActivityLevelRequest>, IBufferMessage
	{
		// Token: 0x0600A714 RID: 42772 RVA: 0x001928A0 File Offset: 0x00190AA0
		[NullableContext(1)]
		public static HarvestActivityLevelRequest Create()
		{
			return new HarvestActivityLevelRequest();
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x0600A715 RID: 42773 RVA: 0x001928A7 File Offset: 0x00190AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x0600A716 RID: 42774 RVA: 0x001928AA File Offset: 0x00190AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityLevelRequest.Descriptor;
			}
		}

		// Token: 0x0600A717 RID: 42775 RVA: 0x001928B1 File Offset: 0x00190AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelRequest()
		{
		}

		// Token: 0x0600A718 RID: 42776 RVA: 0x001928B9 File Offset: 0x00190AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelRequest(HarvestActivityLevelRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A719 RID: 42777 RVA: 0x001928EA File Offset: 0x00190AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelRequest Clone()
		{
			return new HarvestActivityLevelRequest(this);
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x0600A71A RID: 42778 RVA: 0x001928F2 File Offset: 0x00190AF2
		// (set) Token: 0x0600A71B RID: 42779 RVA: 0x001928FA File Offset: 0x00190AFA
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

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x0600A71C RID: 42780 RVA: 0x00192903 File Offset: 0x00190B03
		// (set) Token: 0x0600A71D RID: 42781 RVA: 0x0019290B File Offset: 0x00190B0B
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

		// Token: 0x0600A71E RID: 42782 RVA: 0x00192914 File Offset: 0x00190B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityLevelRequest);
		}

		// Token: 0x0600A71F RID: 42783 RVA: 0x00192922 File Offset: 0x00190B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityLevelRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A720 RID: 42784 RVA: 0x00192960 File Offset: 0x00190B60
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A721 RID: 42785 RVA: 0x001929B8 File Offset: 0x00190BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A722 RID: 42786 RVA: 0x001929C5 File Offset: 0x00190BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A723 RID: 42787 RVA: 0x001929D0 File Offset: 0x00190BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A724 RID: 42788 RVA: 0x00192A2C File Offset: 0x00190C2C
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A725 RID: 42789 RVA: 0x00192A84 File Offset: 0x00190C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityLevelRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A726 RID: 42790 RVA: 0x00192AD4 File Offset: 0x00190CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A727 RID: 42791 RVA: 0x00192AE0 File Offset: 0x00190CE0
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
				if (num != 48U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04004CCD RID: 19661
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CCE RID: 19662
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04004CCF RID: 19663
		private int activityId_;

		// Token: 0x04004CD0 RID: 19664
		public const int InstIdFieldNumber = 14;

		// Token: 0x04004CD1 RID: 19665
		private int instId_;
	}
}
