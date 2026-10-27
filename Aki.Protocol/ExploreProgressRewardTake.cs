using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FD RID: 1277
	public sealed class ExploreProgressRewardTake : IMessage<ExploreProgressRewardTake>, IMessage, IEquatable<ExploreProgressRewardTake>, IDeepCloneable<ExploreProgressRewardTake>, IBufferMessage
	{
		// Token: 0x06007870 RID: 30832 RVA: 0x0012537D File Offset: 0x0012357D
		[NullableContext(1)]
		public static ExploreProgressRewardTake Create()
		{
			return new ExploreProgressRewardTake();
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06007871 RID: 30833 RVA: 0x00125384 File Offset: 0x00123584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExploreProgressRewardTake> Parser
		{
			get
			{
				return ExploreProgressRewardTake._parser;
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06007872 RID: 30834 RVA: 0x0012538B File Offset: 0x0012358B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06007873 RID: 30835 RVA: 0x0012538E File Offset: 0x0012358E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressRewardTake.Descriptor;
			}
		}

		// Token: 0x06007874 RID: 30836 RVA: 0x00125395 File Offset: 0x00123595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardTake()
		{
		}

		// Token: 0x06007875 RID: 30837 RVA: 0x001253A8 File Offset: 0x001235A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardTake(ExploreProgressRewardTake other) : this()
		{
			this.areaId_ = other.areaId_;
			this.exploreProgress_ = other.exploreProgress_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007876 RID: 30838 RVA: 0x001253DE File Offset: 0x001235DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardTake Clone()
		{
			return new ExploreProgressRewardTake(this);
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06007877 RID: 30839 RVA: 0x001253E6 File Offset: 0x001235E6
		// (set) Token: 0x06007878 RID: 30840 RVA: 0x001253EE File Offset: 0x001235EE
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

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06007879 RID: 30841 RVA: 0x001253F7 File Offset: 0x001235F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ExploreProgress
		{
			get
			{
				return this.exploreProgress_;
			}
		}

		// Token: 0x0600787A RID: 30842 RVA: 0x001253FF File Offset: 0x001235FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressRewardTake);
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x00125410 File Offset: 0x00123610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressRewardTake other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.exploreProgress_.Equals(other.exploreProgress_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x00125460 File Offset: 0x00123660
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

		// Token: 0x0600787D RID: 30845 RVA: 0x001254AD File Offset: 0x001236AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600787E RID: 30846 RVA: 0x001254BA File Offset: 0x001236BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600787F RID: 30847 RVA: 0x001254C4 File Offset: 0x001236C4
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

		// Token: 0x06007880 RID: 30848 RVA: 0x00125514 File Offset: 0x00123714
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

		// Token: 0x06007881 RID: 30849 RVA: 0x00125568 File Offset: 0x00123768
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

		// Token: 0x06007882 RID: 30850 RVA: 0x001255B5 File Offset: 0x001237B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x001255C0 File Offset: 0x001237C0
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

		// Token: 0x04003E68 RID: 15976
		private static readonly MessageParser<ExploreProgressRewardTake> _parser = new MessageParser<ExploreProgressRewardTake>(() => new ExploreProgressRewardTake());

		// Token: 0x04003E69 RID: 15977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E6A RID: 15978
		public const int AreaIdFieldNumber = 1;

		// Token: 0x04003E6B RID: 15979
		private int areaId_;

		// Token: 0x04003E6C RID: 15980
		public const int ExploreProgressFieldNumber = 2;

		// Token: 0x04003E6D RID: 15981
		private static readonly FieldCodec<int> _repeated_exploreProgress_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003E6E RID: 15982
		private readonly RepeatedField<int> exploreProgress_ = new RepeatedField<int>();
	}
}
