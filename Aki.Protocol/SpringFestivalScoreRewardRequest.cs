using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E7 RID: 4839
	[NetMessage(EMessageId.SpringFestivalScoreRewardRequest)]
	public sealed class SpringFestivalScoreRewardRequest : IMessage<SpringFestivalScoreRewardRequest>, IMessage, IEquatable<SpringFestivalScoreRewardRequest>, IDeepCloneable<SpringFestivalScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x06019D30 RID: 105776 RVA: 0x003C4990 File Offset: 0x003C2B90
		[NullableContext(1)]
		public static SpringFestivalScoreRewardRequest Create()
		{
			return new SpringFestivalScoreRewardRequest();
		}

		// Token: 0x1700577B RID: 22395
		// (get) Token: 0x06019D31 RID: 105777 RVA: 0x003C4997 File Offset: 0x003C2B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700577C RID: 22396
		// (get) Token: 0x06019D32 RID: 105778 RVA: 0x003C499A File Offset: 0x003C2B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x06019D33 RID: 105779 RVA: 0x003C49A1 File Offset: 0x003C2BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardRequest()
		{
		}

		// Token: 0x06019D34 RID: 105780 RVA: 0x003C49B4 File Offset: 0x003C2BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardRequest(SpringFestivalScoreRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.scoreIds_ = other.scoreIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D35 RID: 105781 RVA: 0x003C49EA File Offset: 0x003C2BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardRequest Clone()
		{
			return new SpringFestivalScoreRewardRequest(this);
		}

		// Token: 0x1700577D RID: 22397
		// (get) Token: 0x06019D36 RID: 105782 RVA: 0x003C49F2 File Offset: 0x003C2BF2
		// (set) Token: 0x06019D37 RID: 105783 RVA: 0x003C49FA File Offset: 0x003C2BFA
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

		// Token: 0x1700577E RID: 22398
		// (get) Token: 0x06019D38 RID: 105784 RVA: 0x003C4A03 File Offset: 0x003C2C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreIds
		{
			get
			{
				return this.scoreIds_;
			}
		}

		// Token: 0x06019D39 RID: 105785 RVA: 0x003C4A0B File Offset: 0x003C2C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalScoreRewardRequest);
		}

		// Token: 0x06019D3A RID: 105786 RVA: 0x003C4A1C File Offset: 0x003C2C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.scoreIds_.Equals(other.scoreIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D3B RID: 105787 RVA: 0x003C4A6C File Offset: 0x003C2C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.scoreIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019D3C RID: 105788 RVA: 0x003C4AB9 File Offset: 0x003C2CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D3D RID: 105789 RVA: 0x003C4AC6 File Offset: 0x003C2CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D3E RID: 105790 RVA: 0x003C4AD0 File Offset: 0x003C2CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			this.scoreIds_.WriteTo(ref output, SpringFestivalScoreRewardRequest._repeated_scoreIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D3F RID: 105791 RVA: 0x003C4B20 File Offset: 0x003C2D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.scoreIds_.CalculateSize(SpringFestivalScoreRewardRequest._repeated_scoreIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019D40 RID: 105792 RVA: 0x003C4B74 File Offset: 0x003C2D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.scoreIds_.Add(other.scoreIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019D41 RID: 105793 RVA: 0x003C4BC1 File Offset: 0x003C2DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D42 RID: 105794 RVA: 0x003C4BCC File Offset: 0x003C2DCC
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
				if (num != 56U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.scoreIds_.AddEntriesFrom(ref input, SpringFestivalScoreRewardRequest._repeated_scoreIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009873 RID: 39027
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009874 RID: 39028
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04009875 RID: 39029
		private int activityId_;

		// Token: 0x04009876 RID: 39030
		public const int ScoreIdsFieldNumber = 9;

		// Token: 0x04009877 RID: 39031
		private static readonly FieldCodec<int> _repeated_scoreIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04009878 RID: 39032
		private readonly RepeatedField<int> scoreIds_ = new RepeatedField<int>();
	}
}
