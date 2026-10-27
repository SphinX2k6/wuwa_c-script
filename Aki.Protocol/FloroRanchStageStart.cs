using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E6 RID: 1510
	public sealed class FloroRanchStageStart : IMessage<FloroRanchStageStart>, IMessage, IEquatable<FloroRanchStageStart>, IDeepCloneable<FloroRanchStageStart>, IBufferMessage
	{
		// Token: 0x06008BBC RID: 35772 RVA: 0x0015213A File Offset: 0x0015033A
		[NullableContext(1)]
		public static FloroRanchStageStart Create()
		{
			return new FloroRanchStageStart();
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06008BBD RID: 35773 RVA: 0x00152141 File Offset: 0x00150341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06008BBE RID: 35774 RVA: 0x00152144 File Offset: 0x00150344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchStageStart.Descriptor;
			}
		}

		// Token: 0x06008BBF RID: 35775 RVA: 0x0015214B File Offset: 0x0015034B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageStart()
		{
		}

		// Token: 0x06008BC0 RID: 35776 RVA: 0x00152153 File Offset: 0x00150353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageStart(FloroRanchStageStart other) : this()
		{
			this.target_ = other.target_;
			this.dayCount_ = other.dayCount_;
			this.reward_ = other.reward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BC1 RID: 35777 RVA: 0x00152190 File Offset: 0x00150390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageStart Clone()
		{
			return new FloroRanchStageStart(this);
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06008BC2 RID: 35778 RVA: 0x00152198 File Offset: 0x00150398
		// (set) Token: 0x06008BC3 RID: 35779 RVA: 0x001521A0 File Offset: 0x001503A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06008BC4 RID: 35780 RVA: 0x001521A9 File Offset: 0x001503A9
		// (set) Token: 0x06008BC5 RID: 35781 RVA: 0x001521B1 File Offset: 0x001503B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DayCount
		{
			get
			{
				return this.dayCount_;
			}
			set
			{
				this.dayCount_ = value;
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06008BC6 RID: 35782 RVA: 0x001521BA File Offset: 0x001503BA
		// (set) Token: 0x06008BC7 RID: 35783 RVA: 0x001521C2 File Offset: 0x001503C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x06008BC8 RID: 35784 RVA: 0x001521CB File Offset: 0x001503CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchStageStart);
		}

		// Token: 0x06008BC9 RID: 35785 RVA: 0x001521DC File Offset: 0x001503DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchStageStart other)
		{
			return other != null && (other == this || (this.Target == other.Target && this.DayCount == other.DayCount && this.Reward == other.Reward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008BCA RID: 35786 RVA: 0x00152238 File Offset: 0x00150438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Target != 0L)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.DayCount != 0)
			{
				num ^= this.DayCount.GetHashCode();
			}
			if (this.Reward != 0L)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x001522A9 File Offset: 0x001504A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008BCC RID: 35788 RVA: 0x001522B6 File Offset: 0x001504B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BCD RID: 35789 RVA: 0x001522C0 File Offset: 0x001504C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Target != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Target);
			}
			if (this.DayCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DayCount);
			}
			if (this.Reward != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BCE RID: 35790 RVA: 0x00152334 File Offset: 0x00150534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Target != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Target);
			}
			if (this.DayCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DayCount);
			}
			if (this.Reward != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Reward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008BCF RID: 35791 RVA: 0x001523A4 File Offset: 0x001505A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchStageStart other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Target != 0L)
			{
				this.Target = other.Target;
			}
			if (other.DayCount != 0)
			{
				this.DayCount = other.DayCount;
			}
			if (other.Reward != 0L)
			{
				this.Reward = other.Reward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008BD0 RID: 35792 RVA: 0x00152408 File Offset: 0x00150608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BD1 RID: 35793 RVA: 0x00152414 File Offset: 0x00150614
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reward = input.ReadInt64();
						}
					}
					else
					{
						this.DayCount = input.ReadInt32();
					}
				}
				else
				{
					this.Target = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004480 RID: 17536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004481 RID: 17537
		public const int TargetFieldNumber = 1;

		// Token: 0x04004482 RID: 17538
		private long target_;

		// Token: 0x04004483 RID: 17539
		public const int DayCountFieldNumber = 2;

		// Token: 0x04004484 RID: 17540
		private int dayCount_;

		// Token: 0x04004485 RID: 17541
		public const int RewardFieldNumber = 3;

		// Token: 0x04004486 RID: 17542
		private long reward_;
	}
}
