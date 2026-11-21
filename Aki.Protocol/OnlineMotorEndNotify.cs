using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B88 RID: 2952
	[NetMessage(EMessageId.OnlineMotorEndNotify)]
	public sealed class OnlineMotorEndNotify : IMessage<OnlineMotorEndNotify>, IMessage, IEquatable<OnlineMotorEndNotify>, IDeepCloneable<OnlineMotorEndNotify>, IBufferMessage
	{
		// Token: 0x06010077 RID: 65655 RVA: 0x00257719 File Offset: 0x00255919
		[NullableContext(1)]
		public static OnlineMotorEndNotify Create()
		{
			return new OnlineMotorEndNotify();
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x06010078 RID: 65656 RVA: 0x00257720 File Offset: 0x00255920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x06010079 RID: 65657 RVA: 0x00257723 File Offset: 0x00255923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorEndNotify.Descriptor;
			}
		}

		// Token: 0x0601007A RID: 65658 RVA: 0x0025772A File Offset: 0x0025592A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorEndNotify()
		{
		}

		// Token: 0x0601007B RID: 65659 RVA: 0x00257732 File Offset: 0x00255932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorEndNotify(OnlineMotorEndNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.endTime_ = other.endTime_;
			this.rank_ = other.rank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601007C RID: 65660 RVA: 0x0025776F File Offset: 0x0025596F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorEndNotify Clone()
		{
			return new OnlineMotorEndNotify(this);
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0601007D RID: 65661 RVA: 0x00257777 File Offset: 0x00255977
		// (set) Token: 0x0601007E RID: 65662 RVA: 0x0025777F File Offset: 0x0025597F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0601007F RID: 65663 RVA: 0x00257788 File Offset: 0x00255988
		// (set) Token: 0x06010080 RID: 65664 RVA: 0x00257790 File Offset: 0x00255990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x06010081 RID: 65665 RVA: 0x00257799 File Offset: 0x00255999
		// (set) Token: 0x06010082 RID: 65666 RVA: 0x002577A1 File Offset: 0x002559A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x06010083 RID: 65667 RVA: 0x002577AA File Offset: 0x002559AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorEndNotify);
		}

		// Token: 0x06010084 RID: 65668 RVA: 0x002577B8 File Offset: 0x002559B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorEndNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EndTime == other.EndTime && this.Rank == other.Rank && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010085 RID: 65669 RVA: 0x00257814 File Offset: 0x00255A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.Rank != 0)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010086 RID: 65670 RVA: 0x00257885 File Offset: 0x00255A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010087 RID: 65671 RVA: 0x00257892 File Offset: 0x00255A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010088 RID: 65672 RVA: 0x0025789C File Offset: 0x00255A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EndTime);
			}
			if (this.Rank != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Rank);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010089 RID: 65673 RVA: 0x00257914 File Offset: 0x00255B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.Rank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rank);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601008A RID: 65674 RVA: 0x00257984 File Offset: 0x00255B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.Rank != 0)
			{
				this.Rank = other.Rank;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601008B RID: 65675 RVA: 0x002579E8 File Offset: 0x00255BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601008C RID: 65676 RVA: 0x002579F4 File Offset: 0x00255BF4
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlayerId = input.ReadInt32();
						}
					}
					else
					{
						this.Rank = input.ReadInt32();
					}
				}
				else
				{
					this.EndTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x040066A8 RID: 26280
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066A9 RID: 26281
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x040066AA RID: 26282
		private int playerId_;

		// Token: 0x040066AB RID: 26283
		public const int EndTimeFieldNumber = 2;

		// Token: 0x040066AC RID: 26284
		private long endTime_;

		// Token: 0x040066AD RID: 26285
		public const int RankFieldNumber = 3;

		// Token: 0x040066AE RID: 26286
		private int rank_;
	}
}
