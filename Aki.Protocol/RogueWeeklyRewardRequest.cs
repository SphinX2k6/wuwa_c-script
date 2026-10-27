using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001046 RID: 4166
	[NetMessage(EMessageId.RogueWeeklyRewardRequest)]
	public sealed class RogueWeeklyRewardRequest : IMessage<RogueWeeklyRewardRequest>, IMessage, IEquatable<RogueWeeklyRewardRequest>, IDeepCloneable<RogueWeeklyRewardRequest>, IBufferMessage
	{
		// Token: 0x06016425 RID: 91173 RVA: 0x0033BB01 File Offset: 0x00339D01
		[NullableContext(1)]
		public static RogueWeeklyRewardRequest Create()
		{
			return new RogueWeeklyRewardRequest();
		}

		// Token: 0x17004A69 RID: 19049
		// (get) Token: 0x06016426 RID: 91174 RVA: 0x0033BB08 File Offset: 0x00339D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A6A RID: 19050
		// (get) Token: 0x06016427 RID: 91175 RVA: 0x0033BB0B File Offset: 0x00339D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyRewardRequest.Descriptor;
			}
		}

		// Token: 0x06016428 RID: 91176 RVA: 0x0033BB12 File Offset: 0x00339D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardRequest()
		{
		}

		// Token: 0x06016429 RID: 91177 RVA: 0x0033BB1A File Offset: 0x00339D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardRequest(RogueWeeklyRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601642A RID: 91178 RVA: 0x0033BB4B File Offset: 0x00339D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardRequest Clone()
		{
			return new RogueWeeklyRewardRequest(this);
		}

		// Token: 0x17004A6B RID: 19051
		// (get) Token: 0x0601642B RID: 91179 RVA: 0x0033BB53 File Offset: 0x00339D53
		// (set) Token: 0x0601642C RID: 91180 RVA: 0x0033BB5B File Offset: 0x00339D5B
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

		// Token: 0x17004A6C RID: 19052
		// (get) Token: 0x0601642D RID: 91181 RVA: 0x0033BB64 File Offset: 0x00339D64
		// (set) Token: 0x0601642E RID: 91182 RVA: 0x0033BB6C File Offset: 0x00339D6C
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

		// Token: 0x0601642F RID: 91183 RVA: 0x0033BB75 File Offset: 0x00339D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyRewardRequest);
		}

		// Token: 0x06016430 RID: 91184 RVA: 0x0033BB83 File Offset: 0x00339D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016431 RID: 91185 RVA: 0x0033BBC4 File Offset: 0x00339DC4
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

		// Token: 0x06016432 RID: 91186 RVA: 0x0033BC1C File Offset: 0x00339E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016433 RID: 91187 RVA: 0x0033BC29 File Offset: 0x00339E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016434 RID: 91188 RVA: 0x0033BC34 File Offset: 0x00339E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016435 RID: 91189 RVA: 0x0033BC90 File Offset: 0x00339E90
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

		// Token: 0x06016436 RID: 91190 RVA: 0x0033BCE8 File Offset: 0x00339EE8
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

		// Token: 0x06016437 RID: 91191 RVA: 0x0033BD38 File Offset: 0x00339F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016438 RID: 91192 RVA: 0x0033BD44 File Offset: 0x00339F44
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
					if (num != 104U)
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

		// Token: 0x0400851F RID: 34079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008520 RID: 34080
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04008521 RID: 34081
		private int activityId_;

		// Token: 0x04008522 RID: 34082
		public const int ConfigIdFieldNumber = 13;

		// Token: 0x04008523 RID: 34083
		private int configId_;
	}
}
