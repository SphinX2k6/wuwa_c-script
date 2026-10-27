using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000743 RID: 1859
	[NetMessage(EMessageId.HarvestActivityLevelRequest)]
	public sealed class HarvestActivityLevelRequest : IMessage<HarvestActivityLevelRequest>, IMessage, IEquatable<HarvestActivityLevelRequest>, IDeepCloneable<HarvestActivityLevelRequest>, IBufferMessage
	{
		// Token: 0x0600A86A RID: 43114 RVA: 0x001952CC File Offset: 0x001934CC
		[NullableContext(1)]
		public static HarvestActivityLevelRequest Create()
		{
			return new HarvestActivityLevelRequest();
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x0600A86B RID: 43115 RVA: 0x001952D3 File Offset: 0x001934D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x0600A86C RID: 43116 RVA: 0x001952D6 File Offset: 0x001934D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityLevelRequest.Descriptor;
			}
		}

		// Token: 0x0600A86D RID: 43117 RVA: 0x001952DD File Offset: 0x001934DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelRequest()
		{
		}

		// Token: 0x0600A86E RID: 43118 RVA: 0x001952E5 File Offset: 0x001934E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelRequest(HarvestActivityLevelRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A86F RID: 43119 RVA: 0x00195316 File Offset: 0x00193516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelRequest Clone()
		{
			return new HarvestActivityLevelRequest(this);
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x0600A870 RID: 43120 RVA: 0x0019531E File Offset: 0x0019351E
		// (set) Token: 0x0600A871 RID: 43121 RVA: 0x00195326 File Offset: 0x00193526
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

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x0600A872 RID: 43122 RVA: 0x0019532F File Offset: 0x0019352F
		// (set) Token: 0x0600A873 RID: 43123 RVA: 0x00195337 File Offset: 0x00193537
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

		// Token: 0x0600A874 RID: 43124 RVA: 0x00195340 File Offset: 0x00193540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityLevelRequest);
		}

		// Token: 0x0600A875 RID: 43125 RVA: 0x0019534E File Offset: 0x0019354E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityLevelRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A876 RID: 43126 RVA: 0x0019538C File Offset: 0x0019358C
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

		// Token: 0x0600A877 RID: 43127 RVA: 0x001953E4 File Offset: 0x001935E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A878 RID: 43128 RVA: 0x001953F1 File Offset: 0x001935F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A879 RID: 43129 RVA: 0x001953FC File Offset: 0x001935FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A87A RID: 43130 RVA: 0x00195458 File Offset: 0x00193658
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

		// Token: 0x0600A87B RID: 43131 RVA: 0x001954B0 File Offset: 0x001936B0
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

		// Token: 0x0600A87C RID: 43132 RVA: 0x00195500 File Offset: 0x00193700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A87D RID: 43133 RVA: 0x0019550C File Offset: 0x0019370C
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
				if (num != 56U)
				{
					if (num != 120U)
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

		// Token: 0x04004CD4 RID: 19668
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CD5 RID: 19669
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04004CD6 RID: 19670
		private int activityId_;

		// Token: 0x04004CD7 RID: 19671
		public const int InstIdFieldNumber = 15;

		// Token: 0x04004CD8 RID: 19672
		private int instId_;
	}
}
