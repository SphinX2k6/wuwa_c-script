using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146F RID: 5231
	public sealed class TurntableActivityData : IMessage<TurntableActivityData>, IMessage, IEquatable<TurntableActivityData>, IDeepCloneable<TurntableActivityData>, IBufferMessage
	{
		// Token: 0x0601BB17 RID: 113431 RVA: 0x00401FB1 File Offset: 0x004001B1
		[NullableContext(1)]
		public static TurntableActivityData Create()
		{
			return new TurntableActivityData();
		}

		// Token: 0x17005D63 RID: 23907
		// (get) Token: 0x0601BB18 RID: 113432 RVA: 0x00401FB8 File Offset: 0x004001B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D64 RID: 23908
		// (get) Token: 0x0601BB19 RID: 113433 RVA: 0x00401FBB File Offset: 0x004001BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TurntableActivityData.Descriptor;
			}
		}

		// Token: 0x0601BB1A RID: 113434 RVA: 0x00401FC2 File Offset: 0x004001C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableActivityData()
		{
		}

		// Token: 0x0601BB1B RID: 113435 RVA: 0x00401FE0 File Offset: 0x004001E0
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

		// Token: 0x0601BB1C RID: 113436 RVA: 0x0040203E File Offset: 0x0040023E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableActivityData Clone()
		{
			return new TurntableActivityData(this);
		}

		// Token: 0x17005D65 RID: 23909
		// (get) Token: 0x0601BB1D RID: 113437 RVA: 0x00402046 File Offset: 0x00400246
		// (set) Token: 0x0601BB1E RID: 113438 RVA: 0x0040204E File Offset: 0x0040024E
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

		// Token: 0x17005D66 RID: 23910
		// (get) Token: 0x0601BB1F RID: 113439 RVA: 0x00402057 File Offset: 0x00400257
		// (set) Token: 0x0601BB20 RID: 113440 RVA: 0x0040205F File Offset: 0x0040025F
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

		// Token: 0x17005D67 RID: 23911
		// (get) Token: 0x0601BB21 RID: 113441 RVA: 0x00402068 File Offset: 0x00400268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedItem
		{
			get
			{
				return this.rewardedItem_;
			}
		}

		// Token: 0x17005D68 RID: 23912
		// (get) Token: 0x0601BB22 RID: 113442 RVA: 0x00402070 File Offset: 0x00400270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> TurntableTasks
		{
			get
			{
				return this.turntableTasks_;
			}
		}

		// Token: 0x0601BB23 RID: 113443 RVA: 0x00402078 File Offset: 0x00400278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TurntableActivityData);
		}

		// Token: 0x0601BB24 RID: 113444 RVA: 0x00402088 File Offset: 0x00400288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TurntableActivityData other)
		{
			return other != null && (other == this || (this.IsAllFinish == other.IsAllFinish && this.CurRound == other.CurRound && this.rewardedItem_.Equals(other.rewardedItem_) && this.turntableTasks_.Equals(other.turntableTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB25 RID: 113445 RVA: 0x004020FC File Offset: 0x004002FC
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

		// Token: 0x0601BB26 RID: 113446 RVA: 0x00402170 File Offset: 0x00400370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB27 RID: 113447 RVA: 0x0040217D File Offset: 0x0040037D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB28 RID: 113448 RVA: 0x00402188 File Offset: 0x00400388
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

		// Token: 0x0601BB29 RID: 113449 RVA: 0x00402204 File Offset: 0x00400404
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

		// Token: 0x0601BB2A RID: 113450 RVA: 0x00402274 File Offset: 0x00400474
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

		// Token: 0x0601BB2B RID: 113451 RVA: 0x004022E6 File Offset: 0x004004E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB2C RID: 113452 RVA: 0x004022F0 File Offset: 0x004004F0
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

		// Token: 0x04009F89 RID: 40841
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F8A RID: 40842
		public const int IsAllFinishFieldNumber = 1;

		// Token: 0x04009F8B RID: 40843
		private bool isAllFinish_;

		// Token: 0x04009F8C RID: 40844
		public const int CurRoundFieldNumber = 2;

		// Token: 0x04009F8D RID: 40845
		private int curRound_;

		// Token: 0x04009F8E RID: 40846
		public const int RewardedItemFieldNumber = 3;

		// Token: 0x04009F8F RID: 40847
		private static readonly FieldCodec<int> _repeated_rewardedItem_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009F90 RID: 40848
		private readonly RepeatedField<int> rewardedItem_ = new RepeatedField<int>();

		// Token: 0x04009F91 RID: 40849
		public const int TurntableTasksFieldNumber = 4;

		// Token: 0x04009F92 RID: 40850
		private static readonly FieldCodec<ActivityTask> _repeated_turntableTasks_codec = FieldCodec.ForMessage<ActivityTask>(34U, ActivityTask.Parser);

		// Token: 0x04009F93 RID: 40851
		private readonly RepeatedField<ActivityTask> turntableTasks_ = new RepeatedField<ActivityTask>();
	}
}
