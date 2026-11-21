using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000585 RID: 1413
	[NetMessage(EMessageId.FlagChallengeRewardRequest)]
	public sealed class FlagChallengeRewardRequest : IMessage<FlagChallengeRewardRequest>, IMessage, IEquatable<FlagChallengeRewardRequest>, IDeepCloneable<FlagChallengeRewardRequest>, IBufferMessage
	{
		// Token: 0x0600835D RID: 33629 RVA: 0x0013CB0F File Offset: 0x0013AD0F
		[NullableContext(1)]
		public static FlagChallengeRewardRequest Create()
		{
			return new FlagChallengeRewardRequest();
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x0600835E RID: 33630 RVA: 0x0013CB16 File Offset: 0x0013AD16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x0600835F RID: 33631 RVA: 0x0013CB19 File Offset: 0x0013AD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeRewardRequest.Descriptor;
			}
		}

		// Token: 0x06008360 RID: 33632 RVA: 0x0013CB20 File Offset: 0x0013AD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardRequest()
		{
		}

		// Token: 0x06008361 RID: 33633 RVA: 0x0013CB33 File Offset: 0x0013AD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardRequest(FlagChallengeRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.flagChallengeTaskIds_ = other.flagChallengeTaskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008362 RID: 33634 RVA: 0x0013CB69 File Offset: 0x0013AD69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardRequest Clone()
		{
			return new FlagChallengeRewardRequest(this);
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06008363 RID: 33635 RVA: 0x0013CB71 File Offset: 0x0013AD71
		// (set) Token: 0x06008364 RID: 33636 RVA: 0x0013CB79 File Offset: 0x0013AD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x06008365 RID: 33637 RVA: 0x0013CB82 File Offset: 0x0013AD82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FlagChallengeTaskIds
		{
			get
			{
				return this.flagChallengeTaskIds_;
			}
		}

		// Token: 0x06008366 RID: 33638 RVA: 0x0013CB8A File Offset: 0x0013AD8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeRewardRequest);
		}

		// Token: 0x06008367 RID: 33639 RVA: 0x0013CB98 File Offset: 0x0013AD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.flagChallengeTaskIds_.Equals(other.flagChallengeTaskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008368 RID: 33640 RVA: 0x0013CBE8 File Offset: 0x0013ADE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.flagChallengeTaskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008369 RID: 33641 RVA: 0x0013CC35 File Offset: 0x0013AE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600836A RID: 33642 RVA: 0x0013CC42 File Offset: 0x0013AE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600836B RID: 33643 RVA: 0x0013CC4C File Offset: 0x0013AE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.flagChallengeTaskIds_.WriteTo(ref output, FlagChallengeRewardRequest._repeated_flagChallengeTaskIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x0013CC9C File Offset: 0x0013AE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.flagChallengeTaskIds_.CalculateSize(FlagChallengeRewardRequest._repeated_flagChallengeTaskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600836D RID: 33645 RVA: 0x0013CCF0 File Offset: 0x0013AEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.flagChallengeTaskIds_.Add(other.flagChallengeTaskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600836E RID: 33646 RVA: 0x0013CD3D File Offset: 0x0013AF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x0013CD48 File Offset: 0x0013AF48
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
				if (num != 112U && num != 114U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.flagChallengeTaskIds_.AddEntriesFrom(ref input, FlagChallengeRewardRequest._repeated_flagChallengeTaskIds_codec);
				}
			}
		}

		// Token: 0x040041C8 RID: 16840
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041C9 RID: 16841
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x040041CA RID: 16842
		private int activityId_;

		// Token: 0x040041CB RID: 16843
		public const int FlagChallengeTaskIdsFieldNumber = 14;

		// Token: 0x040041CC RID: 16844
		private static readonly FieldCodec<int> _repeated_flagChallengeTaskIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040041CD RID: 16845
		private readonly RepeatedField<int> flagChallengeTaskIds_ = new RepeatedField<int>();
	}
}
