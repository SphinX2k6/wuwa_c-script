using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001508 RID: 5384
	[NetMessage(EMessageId.WeekCardRewardRequest)]
	public sealed class WeekCardRewardRequest : IMessage<WeekCardRewardRequest>, IMessage, IEquatable<WeekCardRewardRequest>, IDeepCloneable<WeekCardRewardRequest>, IBufferMessage
	{
		// Token: 0x0601C754 RID: 116564 RVA: 0x0041C4BA File Offset: 0x0041A6BA
		[NullableContext(1)]
		public static WeekCardRewardRequest Create()
		{
			return new WeekCardRewardRequest();
		}

		// Token: 0x17005FF0 RID: 24560
		// (get) Token: 0x0601C755 RID: 116565 RVA: 0x0041C4C1 File Offset: 0x0041A6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FF1 RID: 24561
		// (get) Token: 0x0601C756 RID: 116566 RVA: 0x0041C4C4 File Offset: 0x0041A6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601C757 RID: 116567 RVA: 0x0041C4CB File Offset: 0x0041A6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardRequest()
		{
		}

		// Token: 0x0601C758 RID: 116568 RVA: 0x0041C4D3 File Offset: 0x0041A6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardRequest(WeekCardRewardRequest other) : this()
		{
			this.weekCardContentId_ = other.weekCardContentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C759 RID: 116569 RVA: 0x0041C4F8 File Offset: 0x0041A6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardRequest Clone()
		{
			return new WeekCardRewardRequest(this);
		}

		// Token: 0x17005FF2 RID: 24562
		// (get) Token: 0x0601C75A RID: 116570 RVA: 0x0041C500 File Offset: 0x0041A700
		// (set) Token: 0x0601C75B RID: 116571 RVA: 0x0041C508 File Offset: 0x0041A708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeekCardContentId
		{
			get
			{
				return this.weekCardContentId_;
			}
			set
			{
				this.weekCardContentId_ = value;
			}
		}

		// Token: 0x0601C75C RID: 116572 RVA: 0x0041C511 File Offset: 0x0041A711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardRewardRequest);
		}

		// Token: 0x0601C75D RID: 116573 RVA: 0x0041C51F File Offset: 0x0041A71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardRewardRequest other)
		{
			return other != null && (other == this || (this.WeekCardContentId == other.WeekCardContentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C75E RID: 116574 RVA: 0x0041C550 File Offset: 0x0041A750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeekCardContentId != 0)
			{
				num ^= this.WeekCardContentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C75F RID: 116575 RVA: 0x0041C58F File Offset: 0x0041A78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C760 RID: 116576 RVA: 0x0041C59C File Offset: 0x0041A79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C761 RID: 116577 RVA: 0x0041C5A5 File Offset: 0x0041A7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeekCardContentId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.WeekCardContentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C762 RID: 116578 RVA: 0x0041C5D8 File Offset: 0x0041A7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeekCardContentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeekCardContentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C763 RID: 116579 RVA: 0x0041C616 File Offset: 0x0041A816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeekCardRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeekCardContentId != 0)
			{
				this.WeekCardContentId = other.WeekCardContentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C764 RID: 116580 RVA: 0x0041C647 File Offset: 0x0041A847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C765 RID: 116581 RVA: 0x0041C650 File Offset: 0x0041A850
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeekCardContentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A2EA RID: 41706
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2EB RID: 41707
		public const int WeekCardContentIdFieldNumber = 14;

		// Token: 0x0400A2EC RID: 41708
		private int weekCardContentId_;
	}
}
