using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001052 RID: 4178
	[NetMessage(EMessageId.RogueWhiteCatRecordRequest)]
	public sealed class RogueWhiteCatRecordRequest : IMessage<RogueWhiteCatRecordRequest>, IMessage, IEquatable<RogueWhiteCatRecordRequest>, IDeepCloneable<RogueWhiteCatRecordRequest>, IBufferMessage
	{
		// Token: 0x06016530 RID: 91440 RVA: 0x0033E71D File Offset: 0x0033C91D
		[NullableContext(1)]
		public static RogueWhiteCatRecordRequest Create()
		{
			return new RogueWhiteCatRecordRequest();
		}

		// Token: 0x17004AAB RID: 19115
		// (get) Token: 0x06016531 RID: 91441 RVA: 0x0033E724 File Offset: 0x0033C924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AAC RID: 19116
		// (get) Token: 0x06016532 RID: 91442 RVA: 0x0033E727 File Offset: 0x0033C927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatRecordRequest.Descriptor;
			}
		}

		// Token: 0x06016533 RID: 91443 RVA: 0x0033E72E File Offset: 0x0033C92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordRequest()
		{
		}

		// Token: 0x06016534 RID: 91444 RVA: 0x0033E736 File Offset: 0x0033C936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordRequest(RogueWhiteCatRecordRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016535 RID: 91445 RVA: 0x0033E767 File Offset: 0x0033C967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordRequest Clone()
		{
			return new RogueWhiteCatRecordRequest(this);
		}

		// Token: 0x17004AAD RID: 19117
		// (get) Token: 0x06016536 RID: 91446 RVA: 0x0033E76F File Offset: 0x0033C96F
		// (set) Token: 0x06016537 RID: 91447 RVA: 0x0033E777 File Offset: 0x0033C977
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

		// Token: 0x17004AAE RID: 19118
		// (get) Token: 0x06016538 RID: 91448 RVA: 0x0033E780 File Offset: 0x0033C980
		// (set) Token: 0x06016539 RID: 91449 RVA: 0x0033E788 File Offset: 0x0033C988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x0601653A RID: 91450 RVA: 0x0033E791 File Offset: 0x0033C991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatRecordRequest);
		}

		// Token: 0x0601653B RID: 91451 RVA: 0x0033E79F File Offset: 0x0033C99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatRecordRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601653C RID: 91452 RVA: 0x0033E7E0 File Offset: 0x0033C9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601653D RID: 91453 RVA: 0x0033E838 File Offset: 0x0033CA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601653E RID: 91454 RVA: 0x0033E845 File Offset: 0x0033CA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601653F RID: 91455 RVA: 0x0033E850 File Offset: 0x0033CA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Value != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Value);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016540 RID: 91456 RVA: 0x0033E8AC File Offset: 0x0033CAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016541 RID: 91457 RVA: 0x0033E904 File Offset: 0x0033CB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWhiteCatRecordRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016542 RID: 91458 RVA: 0x0033E954 File Offset: 0x0033CB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016543 RID: 91459 RVA: 0x0033E960 File Offset: 0x0033CB60
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
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.Value = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400858C RID: 34188
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400858D RID: 34189
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x0400858E RID: 34190
		private int activityId_;

		// Token: 0x0400858F RID: 34191
		public const int ValueFieldNumber = 6;

		// Token: 0x04008590 RID: 34192
		private int value_;
	}
}
