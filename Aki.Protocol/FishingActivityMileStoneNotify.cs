using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000546 RID: 1350
	[NetMessage(EMessageId.FishingActivityMileStoneNotify)]
	public sealed class FishingActivityMileStoneNotify : IMessage<FishingActivityMileStoneNotify>, IMessage, IEquatable<FishingActivityMileStoneNotify>, IDeepCloneable<FishingActivityMileStoneNotify>, IBufferMessage
	{
		// Token: 0x06007E4E RID: 32334 RVA: 0x00131C71 File Offset: 0x0012FE71
		[NullableContext(1)]
		public static FishingActivityMileStoneNotify Create()
		{
			return new FishingActivityMileStoneNotify();
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x06007E4F RID: 32335 RVA: 0x00131C78 File Offset: 0x0012FE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x06007E50 RID: 32336 RVA: 0x00131C7B File Offset: 0x0012FE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityMileStoneNotify.Descriptor;
			}
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x00131C82 File Offset: 0x0012FE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMileStoneNotify()
		{
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x00131C95 File Offset: 0x0012FE95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMileStoneNotify(FishingActivityMileStoneNotify other) : this()
		{
			this.milestoneRewarded_ = other.milestoneRewarded_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x00131CBF File Offset: 0x0012FEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMileStoneNotify Clone()
		{
			return new FishingActivityMileStoneNotify(this);
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06007E54 RID: 32340 RVA: 0x00131CC7 File Offset: 0x0012FEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SignState> MilestoneRewarded
		{
			get
			{
				return this.milestoneRewarded_;
			}
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x00131CCF File Offset: 0x0012FECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityMileStoneNotify);
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x00131CDD File Offset: 0x0012FEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityMileStoneNotify other)
		{
			return other != null && (other == this || (this.MilestoneRewarded.Equals(other.MilestoneRewarded) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E57 RID: 32343 RVA: 0x00131D10 File Offset: 0x0012FF10
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

		// Token: 0x06007E58 RID: 32344 RVA: 0x00131D44 File Offset: 0x0012FF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x00131D51 File Offset: 0x0012FF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E5A RID: 32346 RVA: 0x00131D5A File Offset: 0x0012FF5A
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

		// Token: 0x06007E5B RID: 32347 RVA: 0x00131D84 File Offset: 0x0012FF84
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

		// Token: 0x06007E5C RID: 32348 RVA: 0x00131DBD File Offset: 0x0012FFBD
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

		// Token: 0x06007E5D RID: 32349 RVA: 0x00131DEB File Offset: 0x0012FFEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x00131DF4 File Offset: 0x0012FFF4
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.milestoneRewarded_.AddEntriesFrom(ref input, FishingActivityMileStoneNotify._map_milestoneRewarded_codec);
				}
			}
		}

		// Token: 0x04004010 RID: 16400
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004011 RID: 16401
		public const int MilestoneRewardedFieldNumber = 10;

		// Token: 0x04004012 RID: 16402
		private static readonly MapField<int, SignState>.Codec _map_milestoneRewarded_codec = new MapField<int, SignState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<SignState>(16U, (SignState x) => (int)x, (int x) => (SignState)x, SignState.Lock), 82U);

		// Token: 0x04004013 RID: 16403
		private readonly MapField<int, SignState> milestoneRewarded_ = new MapField<int, SignState>();
	}
}
