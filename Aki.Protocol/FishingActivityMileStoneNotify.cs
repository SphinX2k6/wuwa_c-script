using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000531 RID: 1329
	[NetMessage(EMessageId.FishingActivityMileStoneNotify)]
	public sealed class FishingActivityMileStoneNotify : IMessage<FishingActivityMileStoneNotify>, IMessage, IEquatable<FishingActivityMileStoneNotify>, IDeepCloneable<FishingActivityMileStoneNotify>, IBufferMessage
	{
		// Token: 0x06007CE6 RID: 31974 RVA: 0x0012F06D File Offset: 0x0012D26D
		[NullableContext(1)]
		public static FishingActivityMileStoneNotify Create()
		{
			return new FishingActivityMileStoneNotify();
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06007CE7 RID: 31975 RVA: 0x0012F074 File Offset: 0x0012D274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06007CE8 RID: 31976 RVA: 0x0012F077 File Offset: 0x0012D277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityMileStoneNotify.Descriptor;
			}
		}

		// Token: 0x06007CE9 RID: 31977 RVA: 0x0012F07E File Offset: 0x0012D27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMileStoneNotify()
		{
		}

		// Token: 0x06007CEA RID: 31978 RVA: 0x0012F091 File Offset: 0x0012D291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMileStoneNotify(FishingActivityMileStoneNotify other) : this()
		{
			this.milestoneRewarded_ = other.milestoneRewarded_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CEB RID: 31979 RVA: 0x0012F0BB File Offset: 0x0012D2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMileStoneNotify Clone()
		{
			return new FishingActivityMileStoneNotify(this);
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06007CEC RID: 31980 RVA: 0x0012F0C3 File Offset: 0x0012D2C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SignState> MilestoneRewarded
		{
			get
			{
				return this.milestoneRewarded_;
			}
		}

		// Token: 0x06007CED RID: 31981 RVA: 0x0012F0CB File Offset: 0x0012D2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityMileStoneNotify);
		}

		// Token: 0x06007CEE RID: 31982 RVA: 0x0012F0D9 File Offset: 0x0012D2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityMileStoneNotify other)
		{
			return other != null && (other == this || (this.MilestoneRewarded.Equals(other.MilestoneRewarded) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CEF RID: 31983 RVA: 0x0012F10C File Offset: 0x0012D30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.MilestoneRewarded.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007CF0 RID: 31984 RVA: 0x0012F140 File Offset: 0x0012D340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007CF1 RID: 31985 RVA: 0x0012F14D File Offset: 0x0012D34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CF2 RID: 31986 RVA: 0x0012F156 File Offset: 0x0012D356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.milestoneRewarded_.WriteTo(ref output, FishingActivityMileStoneNotify._map_milestoneRewarded_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CF3 RID: 31987 RVA: 0x0012F180 File Offset: 0x0012D380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.milestoneRewarded_.CalculateSize(FishingActivityMileStoneNotify._map_milestoneRewarded_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007CF4 RID: 31988 RVA: 0x0012F1B9 File Offset: 0x0012D3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingActivityMileStoneNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.milestoneRewarded_.MergeFrom(other.milestoneRewarded_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007CF5 RID: 31989 RVA: 0x0012F1E7 File Offset: 0x0012D3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x0012F1F0 File Offset: 0x0012D3F0
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.milestoneRewarded_.AddEntriesFrom(ref input, FishingActivityMileStoneNotify._map_milestoneRewarded_codec);
				}
			}
		}

		// Token: 0x04004006 RID: 16390
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004007 RID: 16391
		public const int MilestoneRewardedFieldNumber = 15;

		// Token: 0x04004008 RID: 16392
		private static readonly MapField<int, SignState>.Codec _map_milestoneRewarded_codec = new MapField<int, SignState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<SignState>(16U, (SignState x) => (int)x, (int x) => (SignState)x, SignState.Lock), 122U);

		// Token: 0x04004009 RID: 16393
		private readonly MapField<int, SignState> milestoneRewarded_ = new MapField<int, SignState>();
	}
}
