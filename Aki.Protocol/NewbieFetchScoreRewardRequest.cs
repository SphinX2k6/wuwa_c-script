using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFE RID: 2814
	[NetMessage(EMessageId.NewbieFetchScoreRewardRequest)]
	public sealed class NewbieFetchScoreRewardRequest : IMessage<NewbieFetchScoreRewardRequest>, IMessage, IEquatable<NewbieFetchScoreRewardRequest>, IDeepCloneable<NewbieFetchScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F4CC RID: 62668 RVA: 0x0023BC11 File Offset: 0x00239E11
		[NullableContext(1)]
		public static NewbieFetchScoreRewardRequest Create()
		{
			return new NewbieFetchScoreRewardRequest();
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600F4CD RID: 62669 RVA: 0x0023BC18 File Offset: 0x00239E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600F4CE RID: 62670 RVA: 0x0023BC1B File Offset: 0x00239E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieFetchScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F4CF RID: 62671 RVA: 0x0023BC22 File Offset: 0x00239E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardRequest()
		{
		}

		// Token: 0x0600F4D0 RID: 62672 RVA: 0x0023BC35 File Offset: 0x00239E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardRequest(NewbieFetchScoreRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.scoreRewardIds_ = other.scoreRewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F4D1 RID: 62673 RVA: 0x0023BC6B File Offset: 0x00239E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardRequest Clone()
		{
			return new NewbieFetchScoreRewardRequest(this);
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600F4D2 RID: 62674 RVA: 0x0023BC73 File Offset: 0x00239E73
		// (set) Token: 0x0600F4D3 RID: 62675 RVA: 0x0023BC7B File Offset: 0x00239E7B
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

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600F4D4 RID: 62676 RVA: 0x0023BC84 File Offset: 0x00239E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewardIds
		{
			get
			{
				return this.scoreRewardIds_;
			}
		}

		// Token: 0x0600F4D5 RID: 62677 RVA: 0x0023BC8C File Offset: 0x00239E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieFetchScoreRewardRequest);
		}

		// Token: 0x0600F4D6 RID: 62678 RVA: 0x0023BC9C File Offset: 0x00239E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieFetchScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.scoreRewardIds_.Equals(other.scoreRewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F4D7 RID: 62679 RVA: 0x0023BCEC File Offset: 0x00239EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.scoreRewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F4D8 RID: 62680 RVA: 0x0023BD39 File Offset: 0x00239F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F4D9 RID: 62681 RVA: 0x0023BD46 File Offset: 0x00239F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F4DA RID: 62682 RVA: 0x0023BD50 File Offset: 0x00239F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			this.scoreRewardIds_.WriteTo(ref output, NewbieFetchScoreRewardRequest._repeated_scoreRewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F4DB RID: 62683 RVA: 0x0023BDA0 File Offset: 0x00239FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.scoreRewardIds_.CalculateSize(NewbieFetchScoreRewardRequest._repeated_scoreRewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F4DC RID: 62684 RVA: 0x0023BDF4 File Offset: 0x00239FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieFetchScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.scoreRewardIds_.Add(other.scoreRewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F4DD RID: 62685 RVA: 0x0023BE41 File Offset: 0x0023A041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F4DE RID: 62686 RVA: 0x0023BE4C File Offset: 0x0023A04C
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
				if (num != 104U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.scoreRewardIds_.AddEntriesFrom(ref input, NewbieFetchScoreRewardRequest._repeated_scoreRewardIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040062D8 RID: 25304
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062D9 RID: 25305
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x040062DA RID: 25306
		private int activityId_;

		// Token: 0x040062DB RID: 25307
		public const int ScoreRewardIdsFieldNumber = 15;

		// Token: 0x040062DC RID: 25308
		private static readonly FieldCodec<int> _repeated_scoreRewardIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040062DD RID: 25309
		private readonly RepeatedField<int> scoreRewardIds_ = new RepeatedField<int>();
	}
}
