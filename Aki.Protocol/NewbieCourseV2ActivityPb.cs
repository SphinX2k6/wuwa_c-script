using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0B RID: 2827
	public sealed class NewbieCourseV2ActivityPb : IMessage<NewbieCourseV2ActivityPb>, IMessage, IEquatable<NewbieCourseV2ActivityPb>, IDeepCloneable<NewbieCourseV2ActivityPb>, IBufferMessage
	{
		// Token: 0x0600F598 RID: 62872 RVA: 0x0023D43D File Offset: 0x0023B63D
		[NullableContext(1)]
		public static NewbieCourseV2ActivityPb Create()
		{
			return new NewbieCourseV2ActivityPb();
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600F599 RID: 62873 RVA: 0x0023D444 File Offset: 0x0023B644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600F59A RID: 62874 RVA: 0x0023D447 File Offset: 0x0023B647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCourseV2ActivityPb.Descriptor;
			}
		}

		// Token: 0x0600F59B RID: 62875 RVA: 0x0023D44E File Offset: 0x0023B64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2ActivityPb()
		{
		}

		// Token: 0x0600F59C RID: 62876 RVA: 0x0023D461 File Offset: 0x0023B661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2ActivityPb(NewbieCourseV2ActivityPb other) : this()
		{
			this.hadTakeReward_ = other.hadTakeReward_.Clone();
			this.beginOpenTime_ = other.beginOpenTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F59D RID: 62877 RVA: 0x0023D497 File Offset: 0x0023B697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2ActivityPb Clone()
		{
			return new NewbieCourseV2ActivityPb(this);
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600F59E RID: 62878 RVA: 0x0023D49F File Offset: 0x0023B69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HadTakeReward
		{
			get
			{
				return this.hadTakeReward_;
			}
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600F59F RID: 62879 RVA: 0x0023D4A7 File Offset: 0x0023B6A7
		// (set) Token: 0x0600F5A0 RID: 62880 RVA: 0x0023D4AF File Offset: 0x0023B6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginOpenTime
		{
			get
			{
				return this.beginOpenTime_;
			}
			set
			{
				this.beginOpenTime_ = value;
			}
		}

		// Token: 0x0600F5A1 RID: 62881 RVA: 0x0023D4B8 File Offset: 0x0023B6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCourseV2ActivityPb);
		}

		// Token: 0x0600F5A2 RID: 62882 RVA: 0x0023D4C8 File Offset: 0x0023B6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCourseV2ActivityPb other)
		{
			return other != null && (other == this || (this.hadTakeReward_.Equals(other.hadTakeReward_) && this.BeginOpenTime == other.BeginOpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F5A3 RID: 62883 RVA: 0x0023D518 File Offset: 0x0023B718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hadTakeReward_.GetHashCode();
			if (this.BeginOpenTime != 0L)
			{
				num ^= this.BeginOpenTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F5A4 RID: 62884 RVA: 0x0023D565 File Offset: 0x0023B765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F5A5 RID: 62885 RVA: 0x0023D572 File Offset: 0x0023B772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F5A6 RID: 62886 RVA: 0x0023D57C File Offset: 0x0023B77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hadTakeReward_.WriteTo(ref output, NewbieCourseV2ActivityPb._repeated_hadTakeReward_codec);
			if (this.BeginOpenTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BeginOpenTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F5A7 RID: 62887 RVA: 0x0023D5CC File Offset: 0x0023B7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hadTakeReward_.CalculateSize(NewbieCourseV2ActivityPb._repeated_hadTakeReward_codec);
			if (this.BeginOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginOpenTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F5A8 RID: 62888 RVA: 0x0023D620 File Offset: 0x0023B820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCourseV2ActivityPb other)
		{
			if (other == null)
			{
				return;
			}
			this.hadTakeReward_.Add(other.hadTakeReward_);
			if (other.BeginOpenTime != 0L)
			{
				this.BeginOpenTime = other.BeginOpenTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F5A9 RID: 62889 RVA: 0x0023D66D File Offset: 0x0023B86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F5AA RID: 62890 RVA: 0x0023D678 File Offset: 0x0023B878
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
				if (num != 8U && num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BeginOpenTime = input.ReadInt64();
					}
				}
				else
				{
					this.hadTakeReward_.AddEntriesFrom(ref input, NewbieCourseV2ActivityPb._repeated_hadTakeReward_codec);
				}
			}
		}

		// Token: 0x040062BA RID: 25274
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062BB RID: 25275
		public const int HadTakeRewardFieldNumber = 1;

		// Token: 0x040062BC RID: 25276
		private static readonly FieldCodec<int> _repeated_hadTakeReward_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040062BD RID: 25277
		private readonly RepeatedField<int> hadTakeReward_ = new RepeatedField<int>();

		// Token: 0x040062BE RID: 25278
		public const int BeginOpenTimeFieldNumber = 2;

		// Token: 0x040062BF RID: 25279
		private long beginOpenTime_;
	}
}
