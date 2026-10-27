using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A0 RID: 1952
	[NetMessage(EMessageId.HonamiStoryScoreRewardRequest)]
	public sealed class HonamiStoryScoreRewardRequest : IMessage<HonamiStoryScoreRewardRequest>, IMessage, IEquatable<HonamiStoryScoreRewardRequest>, IDeepCloneable<HonamiStoryScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600AFFB RID: 45051 RVA: 0x001A6259 File Offset: 0x001A4459
		[NullableContext(1)]
		public static HonamiStoryScoreRewardRequest Create()
		{
			return new HonamiStoryScoreRewardRequest();
		}

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x0600AFFC RID: 45052 RVA: 0x001A6260 File Offset: 0x001A4460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x0600AFFD RID: 45053 RVA: 0x001A6263 File Offset: 0x001A4463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600AFFE RID: 45054 RVA: 0x001A626A File Offset: 0x001A446A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardRequest()
		{
		}

		// Token: 0x0600AFFF RID: 45055 RVA: 0x001A627D File Offset: 0x001A447D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardRequest(HonamiStoryScoreRewardRequest other) : this()
		{
			this.scoreRewardId_ = other.scoreRewardId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B000 RID: 45056 RVA: 0x001A62B3 File Offset: 0x001A44B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardRequest Clone()
		{
			return new HonamiStoryScoreRewardRequest(this);
		}

		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x0600B001 RID: 45057 RVA: 0x001A62BB File Offset: 0x001A44BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewardId
		{
			get
			{
				return this.scoreRewardId_;
			}
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x0600B002 RID: 45058 RVA: 0x001A62C3 File Offset: 0x001A44C3
		// (set) Token: 0x0600B003 RID: 45059 RVA: 0x001A62CB File Offset: 0x001A44CB
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

		// Token: 0x0600B004 RID: 45060 RVA: 0x001A62D4 File Offset: 0x001A44D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryScoreRewardRequest);
		}

		// Token: 0x0600B005 RID: 45061 RVA: 0x001A62E4 File Offset: 0x001A44E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryScoreRewardRequest other)
		{
			return other != null && (other == this || (this.scoreRewardId_.Equals(other.scoreRewardId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B006 RID: 45062 RVA: 0x001A6334 File Offset: 0x001A4534
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

		// Token: 0x0600B007 RID: 45063 RVA: 0x001A6381 File Offset: 0x001A4581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B008 RID: 45064 RVA: 0x001A638E File Offset: 0x001A458E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B009 RID: 45065 RVA: 0x001A6398 File Offset: 0x001A4598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scoreRewardId_.WriteTo(ref output, HonamiStoryScoreRewardRequest._repeated_scoreRewardId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B00A RID: 45066 RVA: 0x001A63E8 File Offset: 0x001A45E8
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

		// Token: 0x0600B00B RID: 45067 RVA: 0x001A643C File Offset: 0x001A463C
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

		// Token: 0x0600B00C RID: 45068 RVA: 0x001A6489 File Offset: 0x001A4689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B00D RID: 45069 RVA: 0x001A6494 File Offset: 0x001A4694
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
				if (num != 16U && num != 18U)
				{
					if (num != 80U)
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

		// Token: 0x04004F1D RID: 20253
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F1E RID: 20254
		public const int ScoreRewardIdFieldNumber = 2;

		// Token: 0x04004F1F RID: 20255
		private static readonly FieldCodec<int> _repeated_scoreRewardId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004F20 RID: 20256
		private readonly RepeatedField<int> scoreRewardId_ = new RepeatedField<int>();

		// Token: 0x04004F21 RID: 20257
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04004F22 RID: 20258
		private int activityId_;
	}
}
