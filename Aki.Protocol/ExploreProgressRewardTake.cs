using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E7 RID: 1255
	public sealed class ExploreProgressRewardTake : IMessage<ExploreProgressRewardTake>, IMessage, IEquatable<ExploreProgressRewardTake>, IDeepCloneable<ExploreProgressRewardTake>, IBufferMessage
	{
		// Token: 0x060076F4 RID: 30452 RVA: 0x001224E8 File Offset: 0x001206E8
		[NullableContext(1)]
		public static ExploreProgressRewardTake Create()
		{
			return new ExploreProgressRewardTake();
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x060076F5 RID: 30453 RVA: 0x001224EF File Offset: 0x001206EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExploreProgressRewardTake> Parser
		{
			get
			{
				return ExploreProgressRewardTake._parser;
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x060076F6 RID: 30454 RVA: 0x001224F6 File Offset: 0x001206F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x060076F7 RID: 30455 RVA: 0x001224F9 File Offset: 0x001206F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressRewardTake.Descriptor;
			}
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x00122500 File Offset: 0x00120700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardTake()
		{
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x00122513 File Offset: 0x00120713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardTake(ExploreProgressRewardTake other) : this()
		{
			this.areaId_ = other.areaId_;
			this.exploreProgress_ = other.exploreProgress_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x00122549 File Offset: 0x00120749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardTake Clone()
		{
			return new ExploreProgressRewardTake(this);
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x060076FB RID: 30459 RVA: 0x00122551 File Offset: 0x00120751
		// (set) Token: 0x060076FC RID: 30460 RVA: 0x00122559 File Offset: 0x00120759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x060076FD RID: 30461 RVA: 0x00122562 File Offset: 0x00120762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ExploreProgress
		{
			get
			{
				return this.exploreProgress_;
			}
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x0012256A File Offset: 0x0012076A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressRewardTake);
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x00122578 File Offset: 0x00120778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressRewardTake other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.exploreProgress_.Equals(other.exploreProgress_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x001225C8 File Offset: 0x001207C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			num ^= this.exploreProgress_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x00122615 File Offset: 0x00120815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x00122622 File Offset: 0x00120822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x0012262C File Offset: 0x0012082C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AreaId);
			}
			this.exploreProgress_.WriteTo(ref output, ExploreProgressRewardTake._repeated_exploreProgress_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x0012267C File Offset: 0x0012087C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			num += this.exploreProgress_.CalculateSize(ExploreProgressRewardTake._repeated_exploreProgress_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x001226D0 File Offset: 0x001208D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreProgressRewardTake other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			this.exploreProgress_.Add(other.exploreProgress_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x0012271D File Offset: 0x0012091D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x00122728 File Offset: 0x00120928
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.exploreProgress_.AddEntriesFrom(ref input, ExploreProgressRewardTake._repeated_exploreProgress_codec);
					}
				}
				else
				{
					this.AreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E59 RID: 15961
		private static readonly MessageParser<ExploreProgressRewardTake> _parser = new MessageParser<ExploreProgressRewardTake>(() => new ExploreProgressRewardTake());

		// Token: 0x04003E5A RID: 15962
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E5B RID: 15963
		public const int AreaIdFieldNumber = 1;

		// Token: 0x04003E5C RID: 15964
		private int areaId_;

		// Token: 0x04003E5D RID: 15965
		public const int ExploreProgressFieldNumber = 2;

		// Token: 0x04003E5E RID: 15966
		private static readonly FieldCodec<int> _repeated_exploreProgress_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003E5F RID: 15967
		private readonly RepeatedField<int> exploreProgress_ = new RepeatedField<int>();
	}
}
