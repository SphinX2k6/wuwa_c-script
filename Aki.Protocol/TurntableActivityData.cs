using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E2 RID: 5346
	public sealed class TurntableActivityData : IMessage<TurntableActivityData>, IMessage, IEquatable<TurntableActivityData>, IDeepCloneable<TurntableActivityData>, IBufferMessage
	{
		// Token: 0x0601C5A2 RID: 116130 RVA: 0x0041D279 File Offset: 0x0041B479
		[NullableContext(1)]
		public static TurntableActivityData Create()
		{
			return new TurntableActivityData();
		}

		// Token: 0x17005FF8 RID: 24568
		// (get) Token: 0x0601C5A3 RID: 116131 RVA: 0x0041D280 File Offset: 0x0041B480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FF9 RID: 24569
		// (get) Token: 0x0601C5A4 RID: 116132 RVA: 0x0041D283 File Offset: 0x0041B483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TurntableActivityData.Descriptor;
			}
		}

		// Token: 0x0601C5A5 RID: 116133 RVA: 0x0041D28A File Offset: 0x0041B48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableActivityData()
		{
		}

		// Token: 0x0601C5A6 RID: 116134 RVA: 0x0041D2A8 File Offset: 0x0041B4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableActivityData(TurntableActivityData other) : this()
		{
			this.isAllFinish_ = other.isAllFinish_;
			this.curRound_ = other.curRound_;
			this.rewardedItem_ = other.rewardedItem_.Clone();
			this.turntableTasks_ = other.turntableTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C5A7 RID: 116135 RVA: 0x0041D306 File Offset: 0x0041B506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableActivityData Clone()
		{
			return new TurntableActivityData(this);
		}

		// Token: 0x17005FFA RID: 24570
		// (get) Token: 0x0601C5A8 RID: 116136 RVA: 0x0041D30E File Offset: 0x0041B50E
		// (set) Token: 0x0601C5A9 RID: 116137 RVA: 0x0041D316 File Offset: 0x0041B516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAllFinish
		{
			get
			{
				return this.isAllFinish_;
			}
			set
			{
				this.isAllFinish_ = value;
			}
		}

		// Token: 0x17005FFB RID: 24571
		// (get) Token: 0x0601C5AA RID: 116138 RVA: 0x0041D31F File Offset: 0x0041B51F
		// (set) Token: 0x0601C5AB RID: 116139 RVA: 0x0041D327 File Offset: 0x0041B527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRound
		{
			get
			{
				return this.curRound_;
			}
			set
			{
				this.curRound_ = value;
			}
		}

		// Token: 0x17005FFC RID: 24572
		// (get) Token: 0x0601C5AC RID: 116140 RVA: 0x0041D330 File Offset: 0x0041B530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedItem
		{
			get
			{
				return this.rewardedItem_;
			}
		}

		// Token: 0x17005FFD RID: 24573
		// (get) Token: 0x0601C5AD RID: 116141 RVA: 0x0041D338 File Offset: 0x0041B538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> TurntableTasks
		{
			get
			{
				return this.turntableTasks_;
			}
		}

		// Token: 0x0601C5AE RID: 116142 RVA: 0x0041D340 File Offset: 0x0041B540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TurntableActivityData);
		}

		// Token: 0x0601C5AF RID: 116143 RVA: 0x0041D350 File Offset: 0x0041B550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TurntableActivityData other)
		{
			return other != null && (other == this || (this.IsAllFinish == other.IsAllFinish && this.CurRound == other.CurRound && this.rewardedItem_.Equals(other.rewardedItem_) && this.turntableTasks_.Equals(other.turntableTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C5B0 RID: 116144 RVA: 0x0041D3C4 File Offset: 0x0041B5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsAllFinish)
			{
				num ^= this.IsAllFinish.GetHashCode();
			}
			if (this.CurRound != 0)
			{
				num ^= this.CurRound.GetHashCode();
			}
			num ^= this.rewardedItem_.GetHashCode();
			num ^= this.turntableTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C5B1 RID: 116145 RVA: 0x0041D438 File Offset: 0x0041B638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C5B2 RID: 116146 RVA: 0x0041D445 File Offset: 0x0041B645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C5B3 RID: 116147 RVA: 0x0041D450 File Offset: 0x0041B650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAllFinish)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsAllFinish);
			}
			if (this.CurRound != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurRound);
			}
			this.rewardedItem_.WriteTo(ref output, TurntableActivityData._repeated_rewardedItem_codec);
			this.turntableTasks_.WriteTo(ref output, TurntableActivityData._repeated_turntableTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C5B4 RID: 116148 RVA: 0x0041D4CC File Offset: 0x0041B6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsAllFinish)
			{
				num += 2;
			}
			if (this.CurRound != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRound);
			}
			num += this.rewardedItem_.CalculateSize(TurntableActivityData._repeated_rewardedItem_codec);
			num += this.turntableTasks_.CalculateSize(TurntableActivityData._repeated_turntableTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C5B5 RID: 116149 RVA: 0x0041D53C File Offset: 0x0041B73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TurntableActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsAllFinish)
			{
				this.IsAllFinish = other.IsAllFinish;
			}
			if (other.CurRound != 0)
			{
				this.CurRound = other.CurRound;
			}
			this.rewardedItem_.Add(other.rewardedItem_);
			this.turntableTasks_.Add(other.turntableTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C5B6 RID: 116150 RVA: 0x0041D5AE File Offset: 0x0041B7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C5B7 RID: 116151 RVA: 0x0041D5B8 File Offset: 0x0041B7B8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.IsAllFinish = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.CurRound = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.rewardedItem_.AddEntriesFrom(ref input, TurntableActivityData._repeated_rewardedItem_codec);
						continue;
					}
					if (num == 34U)
					{
						this.turntableTasks_.AddEntriesFrom(ref input, TurntableActivityData._repeated_turntableTasks_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A3D0 RID: 41936
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3D1 RID: 41937
		public const int IsAllFinishFieldNumber = 1;

		// Token: 0x0400A3D2 RID: 41938
		private bool isAllFinish_;

		// Token: 0x0400A3D3 RID: 41939
		public const int CurRoundFieldNumber = 2;

		// Token: 0x0400A3D4 RID: 41940
		private int curRound_;

		// Token: 0x0400A3D5 RID: 41941
		public const int RewardedItemFieldNumber = 3;

		// Token: 0x0400A3D6 RID: 41942
		private static readonly FieldCodec<int> _repeated_rewardedItem_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400A3D7 RID: 41943
		private readonly RepeatedField<int> rewardedItem_ = new RepeatedField<int>();

		// Token: 0x0400A3D8 RID: 41944
		public const int TurntableTasksFieldNumber = 4;

		// Token: 0x0400A3D9 RID: 41945
		private static readonly FieldCodec<ActivityTask> _repeated_turntableTasks_codec = FieldCodec.ForMessage<ActivityTask>(34U, ActivityTask.Parser);

		// Token: 0x0400A3DA RID: 41946
		private readonly RepeatedField<ActivityTask> turntableTasks_ = new RepeatedField<ActivityTask>();
	}
}
