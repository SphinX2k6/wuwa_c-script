using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137D RID: 4989
	[NetMessage(EMessageId.TimePointRewardActivityConditionNotify)]
	public sealed class TimePointRewardActivityConditionNotify : IMessage<TimePointRewardActivityConditionNotify>, IMessage, IEquatable<TimePointRewardActivityConditionNotify>, IDeepCloneable<TimePointRewardActivityConditionNotify>, IBufferMessage
	{
		// Token: 0x0601A7C5 RID: 108485 RVA: 0x003D81E9 File Offset: 0x003D63E9
		[NullableContext(1)]
		public static TimePointRewardActivityConditionNotify Create()
		{
			return new TimePointRewardActivityConditionNotify();
		}

		// Token: 0x17005953 RID: 22867
		// (get) Token: 0x0601A7C6 RID: 108486 RVA: 0x003D81F0 File Offset: 0x003D63F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005954 RID: 22868
		// (get) Token: 0x0601A7C7 RID: 108487 RVA: 0x003D81F3 File Offset: 0x003D63F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointRewardActivityConditionNotify.Descriptor;
			}
		}

		// Token: 0x0601A7C8 RID: 108488 RVA: 0x003D81FA File Offset: 0x003D63FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityConditionNotify()
		{
		}

		// Token: 0x0601A7C9 RID: 108489 RVA: 0x003D8204 File Offset: 0x003D6404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityConditionNotify(TimePointRewardActivityConditionNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A7CA RID: 108490 RVA: 0x003D8250 File Offset: 0x003D6450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityConditionNotify Clone()
		{
			return new TimePointRewardActivityConditionNotify(this);
		}

		// Token: 0x17005955 RID: 22869
		// (get) Token: 0x0601A7CB RID: 108491 RVA: 0x003D8258 File Offset: 0x003D6458
		// (set) Token: 0x0601A7CC RID: 108492 RVA: 0x003D8260 File Offset: 0x003D6460
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

		// Token: 0x17005956 RID: 22870
		// (get) Token: 0x0601A7CD RID: 108493 RVA: 0x003D8269 File Offset: 0x003D6469
		// (set) Token: 0x0601A7CE RID: 108494 RVA: 0x003D8271 File Offset: 0x003D6471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityData Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x0601A7CF RID: 108495 RVA: 0x003D827A File Offset: 0x003D647A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointRewardActivityConditionNotify);
		}

		// Token: 0x0601A7D0 RID: 108496 RVA: 0x003D8288 File Offset: 0x003D6488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointRewardActivityConditionNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A7D1 RID: 108497 RVA: 0x003D82D8 File Offset: 0x003D64D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A7D2 RID: 108498 RVA: 0x003D832D File Offset: 0x003D652D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A7D3 RID: 108499 RVA: 0x003D833A File Offset: 0x003D653A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A7D4 RID: 108500 RVA: 0x003D8344 File Offset: 0x003D6544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.data_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A7D5 RID: 108501 RVA: 0x003D83A0 File Offset: 0x003D65A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A7D6 RID: 108502 RVA: 0x003D83F8 File Offset: 0x003D65F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimePointRewardActivityConditionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new TimePointRewardActivityData();
				}
				this.Data.MergeFrom(other.Data);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A7D7 RID: 108503 RVA: 0x003D8460 File Offset: 0x003D6660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A7D8 RID: 108504 RVA: 0x003D846C File Offset: 0x003D666C
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
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.data_ == null)
						{
							this.Data = new TimePointRewardActivityData();
						}
						input.ReadMessage(this.Data);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A1E RID: 39454
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A1F RID: 39455
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04009A20 RID: 39456
		private int activityId_;

		// Token: 0x04009A21 RID: 39457
		public const int DataFieldNumber = 8;

		// Token: 0x04009A22 RID: 39458
		private TimePointRewardActivityData data_;
	}
}
