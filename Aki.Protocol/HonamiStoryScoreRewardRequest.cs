using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078C RID: 1932
	[NetMessage(EMessageId.HonamiStoryScoreRewardRequest)]
	public sealed class HonamiStoryScoreRewardRequest : IMessage<HonamiStoryScoreRewardRequest>, IMessage, IEquatable<HonamiStoryScoreRewardRequest>, IDeepCloneable<HonamiStoryScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600AEA5 RID: 44709 RVA: 0x001A382D File Offset: 0x001A1A2D
		[NullableContext(1)]
		public static HonamiStoryScoreRewardRequest Create()
		{
			return new HonamiStoryScoreRewardRequest();
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x0600AEA6 RID: 44710 RVA: 0x001A3834 File Offset: 0x001A1A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x0600AEA7 RID: 44711 RVA: 0x001A3837 File Offset: 0x001A1A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600AEA8 RID: 44712 RVA: 0x001A383E File Offset: 0x001A1A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardRequest()
		{
		}

		// Token: 0x0600AEA9 RID: 44713 RVA: 0x001A3851 File Offset: 0x001A1A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardRequest(HonamiStoryScoreRewardRequest other) : this()
		{
			this.scoreRewardId_ = other.scoreRewardId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEAA RID: 44714 RVA: 0x001A3887 File Offset: 0x001A1A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardRequest Clone()
		{
			return new HonamiStoryScoreRewardRequest(this);
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x0600AEAB RID: 44715 RVA: 0x001A388F File Offset: 0x001A1A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewardId
		{
			get
			{
				return this.scoreRewardId_;
			}
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x0600AEAC RID: 44716 RVA: 0x001A3897 File Offset: 0x001A1A97
		// (set) Token: 0x0600AEAD RID: 44717 RVA: 0x001A389F File Offset: 0x001A1A9F
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

		// Token: 0x0600AEAE RID: 44718 RVA: 0x001A38A8 File Offset: 0x001A1AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryScoreRewardRequest);
		}

		// Token: 0x0600AEAF RID: 44719 RVA: 0x001A38B8 File Offset: 0x001A1AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryScoreRewardRequest other)
		{
			return other != null && (other == this || (this.scoreRewardId_.Equals(other.scoreRewardId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AEB0 RID: 44720 RVA: 0x001A3908 File Offset: 0x001A1B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.scoreRewardId_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AEB1 RID: 44721 RVA: 0x001A3955 File Offset: 0x001A1B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AEB2 RID: 44722 RVA: 0x001A3962 File Offset: 0x001A1B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEB3 RID: 44723 RVA: 0x001A396C File Offset: 0x001A1B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scoreRewardId_.WriteTo(ref output, HonamiStoryScoreRewardRequest._repeated_scoreRewardId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEB4 RID: 44724 RVA: 0x001A39BC File Offset: 0x001A1BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.scoreRewardId_.CalculateSize(HonamiStoryScoreRewardRequest._repeated_scoreRewardId_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEB5 RID: 44725 RVA: 0x001A3A10 File Offset: 0x001A1C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.scoreRewardId_.Add(other.scoreRewardId_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEB6 RID: 44726 RVA: 0x001A3A5D File Offset: 0x001A1C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEB7 RID: 44727 RVA: 0x001A3A68 File Offset: 0x001A1C68
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
				if (num != 56U && num != 58U)
				{
					if (num != 88U)
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
					this.scoreRewardId_.AddEntriesFrom(ref input, HonamiStoryScoreRewardRequest._repeated_scoreRewardId_codec);
				}
			}
		}

		// Token: 0x04004F16 RID: 20246
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F17 RID: 20247
		public const int ScoreRewardIdFieldNumber = 7;

		// Token: 0x04004F18 RID: 20248
		private static readonly FieldCodec<int> _repeated_scoreRewardId_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04004F19 RID: 20249
		private readonly RepeatedField<int> scoreRewardId_ = new RepeatedField<int>();

		// Token: 0x04004F1A RID: 20250
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04004F1B RID: 20251
		private int activityId_;
	}
}
