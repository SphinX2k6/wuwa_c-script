using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCC RID: 4044
	[NetMessage(EMessageId.RoguelikeWriteCatRewardRequest)]
	public sealed class RoguelikeWriteCatRewardRequest : IMessage<RoguelikeWriteCatRewardRequest>, IMessage, IEquatable<RoguelikeWriteCatRewardRequest>, IDeepCloneable<RoguelikeWriteCatRewardRequest>, IBufferMessage
	{
		// Token: 0x060159E0 RID: 88544 RVA: 0x0032333D File Offset: 0x0032153D
		[NullableContext(1)]
		public static RoguelikeWriteCatRewardRequest Create()
		{
			return new RoguelikeWriteCatRewardRequest();
		}

		// Token: 0x17004816 RID: 18454
		// (get) Token: 0x060159E1 RID: 88545 RVA: 0x00323344 File Offset: 0x00321544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004817 RID: 18455
		// (get) Token: 0x060159E2 RID: 88546 RVA: 0x00323347 File Offset: 0x00321547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatRewardRequest.Descriptor;
			}
		}

		// Token: 0x060159E3 RID: 88547 RVA: 0x0032334E File Offset: 0x0032154E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardRequest()
		{
		}

		// Token: 0x060159E4 RID: 88548 RVA: 0x00323356 File Offset: 0x00321556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardRequest(RoguelikeWriteCatRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060159E5 RID: 88549 RVA: 0x00323387 File Offset: 0x00321587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatRewardRequest Clone()
		{
			return new RoguelikeWriteCatRewardRequest(this);
		}

		// Token: 0x17004818 RID: 18456
		// (get) Token: 0x060159E6 RID: 88550 RVA: 0x0032338F File Offset: 0x0032158F
		// (set) Token: 0x060159E7 RID: 88551 RVA: 0x00323397 File Offset: 0x00321597
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

		// Token: 0x17004819 RID: 18457
		// (get) Token: 0x060159E8 RID: 88552 RVA: 0x003233A0 File Offset: 0x003215A0
		// (set) Token: 0x060159E9 RID: 88553 RVA: 0x003233A8 File Offset: 0x003215A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060159EA RID: 88554 RVA: 0x003233B1 File Offset: 0x003215B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatRewardRequest);
		}

		// Token: 0x060159EB RID: 88555 RVA: 0x003233BF File Offset: 0x003215BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060159EC RID: 88556 RVA: 0x00323400 File Offset: 0x00321600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060159ED RID: 88557 RVA: 0x00323458 File Offset: 0x00321658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060159EE RID: 88558 RVA: 0x00323465 File Offset: 0x00321665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060159EF RID: 88559 RVA: 0x00323470 File Offset: 0x00321670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060159F0 RID: 88560 RVA: 0x003234CC File Offset: 0x003216CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060159F1 RID: 88561 RVA: 0x00323524 File Offset: 0x00321724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeWriteCatRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060159F2 RID: 88562 RVA: 0x00323574 File Offset: 0x00321774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060159F3 RID: 88563 RVA: 0x00323580 File Offset: 0x00321780
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
				if (num != 80U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040081D2 RID: 33234
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081D3 RID: 33235
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x040081D4 RID: 33236
		private int activityId_;

		// Token: 0x040081D5 RID: 33237
		public const int IndexFieldNumber = 15;

		// Token: 0x040081D6 RID: 33238
		private int index_;
	}
}
