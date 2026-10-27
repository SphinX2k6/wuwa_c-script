using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001278 RID: 4728
	[NetMessage(EMessageId.SpringFestivalScoreRewardRequest)]
	public sealed class SpringFestivalScoreRewardRequest : IMessage<SpringFestivalScoreRewardRequest>, IMessage, IEquatable<SpringFestivalScoreRewardRequest>, IDeepCloneable<SpringFestivalScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x060192FA RID: 103162 RVA: 0x003AA23C File Offset: 0x003A843C
		[NullableContext(1)]
		public static SpringFestivalScoreRewardRequest Create()
		{
			return new SpringFestivalScoreRewardRequest();
		}

		// Token: 0x170054FA RID: 21754
		// (get) Token: 0x060192FB RID: 103163 RVA: 0x003AA243 File Offset: 0x003A8443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054FB RID: 21755
		// (get) Token: 0x060192FC RID: 103164 RVA: 0x003AA246 File Offset: 0x003A8446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x060192FD RID: 103165 RVA: 0x003AA24D File Offset: 0x003A844D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardRequest()
		{
		}

		// Token: 0x060192FE RID: 103166 RVA: 0x003AA260 File Offset: 0x003A8460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardRequest(SpringFestivalScoreRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.scoreIds_ = other.scoreIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060192FF RID: 103167 RVA: 0x003AA296 File Offset: 0x003A8496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalScoreRewardRequest Clone()
		{
			return new SpringFestivalScoreRewardRequest(this);
		}

		// Token: 0x170054FC RID: 21756
		// (get) Token: 0x06019300 RID: 103168 RVA: 0x003AA29E File Offset: 0x003A849E
		// (set) Token: 0x06019301 RID: 103169 RVA: 0x003AA2A6 File Offset: 0x003A84A6
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

		// Token: 0x170054FD RID: 21757
		// (get) Token: 0x06019302 RID: 103170 RVA: 0x003AA2AF File Offset: 0x003A84AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreIds
		{
			get
			{
				return this.scoreIds_;
			}
		}

		// Token: 0x06019303 RID: 103171 RVA: 0x003AA2B7 File Offset: 0x003A84B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalScoreRewardRequest);
		}

		// Token: 0x06019304 RID: 103172 RVA: 0x003AA2C8 File Offset: 0x003A84C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.scoreIds_.Equals(other.scoreIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019305 RID: 103173 RVA: 0x003AA318 File Offset: 0x003A8518
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

		// Token: 0x06019306 RID: 103174 RVA: 0x003AA365 File Offset: 0x003A8565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019307 RID: 103175 RVA: 0x003AA372 File Offset: 0x003A8572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019308 RID: 103176 RVA: 0x003AA37C File Offset: 0x003A857C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			this.scoreIds_.WriteTo(ref output, SpringFestivalScoreRewardRequest._repeated_scoreIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019309 RID: 103177 RVA: 0x003AA3CC File Offset: 0x003A85CC
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

		// Token: 0x0601930A RID: 103178 RVA: 0x003AA420 File Offset: 0x003A8620
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

		// Token: 0x0601930B RID: 103179 RVA: 0x003AA46D File Offset: 0x003A866D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601930C RID: 103180 RVA: 0x003AA478 File Offset: 0x003A8678
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
				if (num != 64U)
				{
					if (num != 88U && num != 90U)
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

		// Token: 0x04009449 RID: 37961
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400944A RID: 37962
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x0400944B RID: 37963
		private int activityId_;

		// Token: 0x0400944C RID: 37964
		public const int ScoreIdsFieldNumber = 11;

		// Token: 0x0400944D RID: 37965
		private static readonly FieldCodec<int> _repeated_scoreIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400944E RID: 37966
		private readonly RepeatedField<int> scoreIds_ = new RepeatedField<int>();
	}
}
