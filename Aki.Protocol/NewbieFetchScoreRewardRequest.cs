using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0F RID: 2831
	[NetMessage(EMessageId.NewbieFetchScoreRewardRequest)]
	public sealed class NewbieFetchScoreRewardRequest : IMessage<NewbieFetchScoreRewardRequest>, IMessage, IEquatable<NewbieFetchScoreRewardRequest>, IDeepCloneable<NewbieFetchScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F5E6 RID: 62950 RVA: 0x0023DE1D File Offset: 0x0023C01D
		[NullableContext(1)]
		public static NewbieFetchScoreRewardRequest Create()
		{
			return new NewbieFetchScoreRewardRequest();
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600F5E7 RID: 62951 RVA: 0x0023DE24 File Offset: 0x0023C024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600F5E8 RID: 62952 RVA: 0x0023DE27 File Offset: 0x0023C027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieFetchScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F5E9 RID: 62953 RVA: 0x0023DE2E File Offset: 0x0023C02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardRequest()
		{
		}

		// Token: 0x0600F5EA RID: 62954 RVA: 0x0023DE41 File Offset: 0x0023C041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardRequest(NewbieFetchScoreRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.scoreRewardIds_ = other.scoreRewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F5EB RID: 62955 RVA: 0x0023DE77 File Offset: 0x0023C077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardRequest Clone()
		{
			return new NewbieFetchScoreRewardRequest(this);
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0600F5EC RID: 62956 RVA: 0x0023DE7F File Offset: 0x0023C07F
		// (set) Token: 0x0600F5ED RID: 62957 RVA: 0x0023DE87 File Offset: 0x0023C087
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

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600F5EE RID: 62958 RVA: 0x0023DE90 File Offset: 0x0023C090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewardIds
		{
			get
			{
				return this.scoreRewardIds_;
			}
		}

		// Token: 0x0600F5EF RID: 62959 RVA: 0x0023DE98 File Offset: 0x0023C098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieFetchScoreRewardRequest);
		}

		// Token: 0x0600F5F0 RID: 62960 RVA: 0x0023DEA8 File Offset: 0x0023C0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieFetchScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.scoreRewardIds_.Equals(other.scoreRewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F5F1 RID: 62961 RVA: 0x0023DEF8 File Offset: 0x0023C0F8
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

		// Token: 0x0600F5F2 RID: 62962 RVA: 0x0023DF45 File Offset: 0x0023C145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F5F3 RID: 62963 RVA: 0x0023DF52 File Offset: 0x0023C152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F5F4 RID: 62964 RVA: 0x0023DF5C File Offset: 0x0023C15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scoreRewardIds_.WriteTo(ref output, NewbieFetchScoreRewardRequest._repeated_scoreRewardIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F5F5 RID: 62965 RVA: 0x0023DFAC File Offset: 0x0023C1AC
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

		// Token: 0x0600F5F6 RID: 62966 RVA: 0x0023E000 File Offset: 0x0023C200
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

		// Token: 0x0600F5F7 RID: 62967 RVA: 0x0023E04D File Offset: 0x0023C24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F5F8 RID: 62968 RVA: 0x0023E058 File Offset: 0x0023C258
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
				if (num != 24U && num != 26U)
				{
					if (num != 72U)
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
					this.scoreRewardIds_.AddEntriesFrom(ref input, NewbieFetchScoreRewardRequest._repeated_scoreRewardIds_codec);
				}
			}
		}

		// Token: 0x040062CF RID: 25295
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062D0 RID: 25296
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x040062D1 RID: 25297
		private int activityId_;

		// Token: 0x040062D2 RID: 25298
		public const int ScoreRewardIdsFieldNumber = 3;

		// Token: 0x040062D3 RID: 25299
		private static readonly FieldCodec<int> _repeated_scoreRewardIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040062D4 RID: 25300
		private readonly RepeatedField<int> scoreRewardIds_ = new RepeatedField<int>();
	}
}
