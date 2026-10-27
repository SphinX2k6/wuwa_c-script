using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B98 RID: 2968
	[NetMessage(EMessageId.OnlineMotorEndNotify)]
	public sealed class OnlineMotorEndNotify : IMessage<OnlineMotorEndNotify>, IMessage, IEquatable<OnlineMotorEndNotify>, IDeepCloneable<OnlineMotorEndNotify>, IBufferMessage
	{
		// Token: 0x0601017B RID: 65915 RVA: 0x002595E4 File Offset: 0x002577E4
		[NullableContext(1)]
		public static OnlineMotorEndNotify Create()
		{
			return new OnlineMotorEndNotify();
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0601017C RID: 65916 RVA: 0x002595EB File Offset: 0x002577EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0601017D RID: 65917 RVA: 0x002595EE File Offset: 0x002577EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorEndNotify.Descriptor;
			}
		}

		// Token: 0x0601017E RID: 65918 RVA: 0x002595F5 File Offset: 0x002577F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorEndNotify()
		{
		}

		// Token: 0x0601017F RID: 65919 RVA: 0x002595FD File Offset: 0x002577FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorEndNotify(OnlineMotorEndNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.endTime_ = other.endTime_;
			this.rank_ = other.rank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010180 RID: 65920 RVA: 0x0025963A File Offset: 0x0025783A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorEndNotify Clone()
		{
			return new OnlineMotorEndNotify(this);
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x06010181 RID: 65921 RVA: 0x00259642 File Offset: 0x00257842
		// (set) Token: 0x06010182 RID: 65922 RVA: 0x0025964A File Offset: 0x0025784A
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

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x06010183 RID: 65923 RVA: 0x00259653 File Offset: 0x00257853
		// (set) Token: 0x06010184 RID: 65924 RVA: 0x0025965B File Offset: 0x0025785B
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

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x06010185 RID: 65925 RVA: 0x00259664 File Offset: 0x00257864
		// (set) Token: 0x06010186 RID: 65926 RVA: 0x0025966C File Offset: 0x0025786C
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

		// Token: 0x06010187 RID: 65927 RVA: 0x00259675 File Offset: 0x00257875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorEndNotify);
		}

		// Token: 0x06010188 RID: 65928 RVA: 0x00259684 File Offset: 0x00257884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorEndNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EndTime == other.EndTime && this.Rank == other.Rank && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010189 RID: 65929 RVA: 0x002596E0 File Offset: 0x002578E0
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

		// Token: 0x0601018A RID: 65930 RVA: 0x00259751 File Offset: 0x00257951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601018B RID: 65931 RVA: 0x0025975E File Offset: 0x0025795E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601018C RID: 65932 RVA: 0x00259768 File Offset: 0x00257968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Rank != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Rank);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601018D RID: 65933 RVA: 0x002597E0 File Offset: 0x002579E0
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

		// Token: 0x0601018E RID: 65934 RVA: 0x00259850 File Offset: 0x00257A50
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

		// Token: 0x0601018F RID: 65935 RVA: 0x002598B4 File Offset: 0x00257AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010190 RID: 65936 RVA: 0x002598C0 File Offset: 0x00257AC0
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
				if (num != 88U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EndTime = input.ReadInt64();
						}
					}
					else
					{
						this.Rank = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006698 RID: 26264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006699 RID: 26265
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x0400669A RID: 26266
		private int playerId_;

		// Token: 0x0400669B RID: 26267
		public const int EndTimeFieldNumber = 14;

		// Token: 0x0400669C RID: 26268
		private long endTime_;

		// Token: 0x0400669D RID: 26269
		public const int RankFieldNumber = 12;

		// Token: 0x0400669E RID: 26270
		private int rank_;
	}
}
