using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001036 RID: 4150
	[NetMessage(EMessageId.RogueWeeklyRewardRequest)]
	public sealed class RogueWeeklyRewardRequest : IMessage<RogueWeeklyRewardRequest>, IMessage, IEquatable<RogueWeeklyRewardRequest>, IDeepCloneable<RogueWeeklyRewardRequest>, IBufferMessage
	{
		// Token: 0x06016340 RID: 90944 RVA: 0x0033A431 File Offset: 0x00338631
		[NullableContext(1)]
		public static RogueWeeklyRewardRequest Create()
		{
			return new RogueWeeklyRewardRequest();
		}

		// Token: 0x17004A3F RID: 19007
		// (get) Token: 0x06016341 RID: 90945 RVA: 0x0033A438 File Offset: 0x00338638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A40 RID: 19008
		// (get) Token: 0x06016342 RID: 90946 RVA: 0x0033A43B File Offset: 0x0033863B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyRewardRequest.Descriptor;
			}
		}

		// Token: 0x06016343 RID: 90947 RVA: 0x0033A442 File Offset: 0x00338642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardRequest()
		{
		}

		// Token: 0x06016344 RID: 90948 RVA: 0x0033A44A File Offset: 0x0033864A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardRequest(RogueWeeklyRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016345 RID: 90949 RVA: 0x0033A47B File Offset: 0x0033867B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardRequest Clone()
		{
			return new RogueWeeklyRewardRequest(this);
		}

		// Token: 0x17004A41 RID: 19009
		// (get) Token: 0x06016346 RID: 90950 RVA: 0x0033A483 File Offset: 0x00338683
		// (set) Token: 0x06016347 RID: 90951 RVA: 0x0033A48B File Offset: 0x0033868B
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

		// Token: 0x17004A42 RID: 19010
		// (get) Token: 0x06016348 RID: 90952 RVA: 0x0033A494 File Offset: 0x00338694
		// (set) Token: 0x06016349 RID: 90953 RVA: 0x0033A49C File Offset: 0x0033869C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x0601634A RID: 90954 RVA: 0x0033A4A5 File Offset: 0x003386A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyRewardRequest);
		}

		// Token: 0x0601634B RID: 90955 RVA: 0x0033A4B3 File Offset: 0x003386B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601634C RID: 90956 RVA: 0x0033A4F4 File Offset: 0x003386F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601634D RID: 90957 RVA: 0x0033A54C File Offset: 0x0033874C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601634E RID: 90958 RVA: 0x0033A559 File Offset: 0x00338759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601634F RID: 90959 RVA: 0x0033A564 File Offset: 0x00338764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016350 RID: 90960 RVA: 0x0033A5C0 File Offset: 0x003387C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016351 RID: 90961 RVA: 0x0033A618 File Offset: 0x00338818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016352 RID: 90962 RVA: 0x0033A668 File Offset: 0x00338868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016353 RID: 90963 RVA: 0x0033A674 File Offset: 0x00338874
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
						this.ConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008549 RID: 34121
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400854A RID: 34122
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x0400854B RID: 34123
		private int activityId_;

		// Token: 0x0400854C RID: 34124
		public const int ConfigIdFieldNumber = 14;

		// Token: 0x0400854D RID: 34125
		private int configId_;
	}
}
