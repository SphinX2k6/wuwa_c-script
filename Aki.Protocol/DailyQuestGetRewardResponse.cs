using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032F RID: 815
	[NetMessage(EMessageId.DailyQuestGetRewardResponse)]
	public sealed class DailyQuestGetRewardResponse : IMessage<DailyQuestGetRewardResponse>, IMessage, IEquatable<DailyQuestGetRewardResponse>, IDeepCloneable<DailyQuestGetRewardResponse>, IBufferMessage
	{
		// Token: 0x060051F5 RID: 20981 RVA: 0x000C79B4 File Offset: 0x000C5BB4
		[NullableContext(1)]
		public static DailyQuestGetRewardResponse Create()
		{
			return new DailyQuestGetRewardResponse();
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x060051F6 RID: 20982 RVA: 0x000C79BB File Offset: 0x000C5BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x060051F7 RID: 20983 RVA: 0x000C79BE File Offset: 0x000C5BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestGetRewardResponse.Descriptor;
			}
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x000C79C5 File Offset: 0x000C5BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardResponse()
		{
		}

		// Token: 0x060051F9 RID: 20985 RVA: 0x000C79D8 File Offset: 0x000C5BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardResponse(DailyQuestGetRewardResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this.rewards_ = other.rewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060051FA RID: 20986 RVA: 0x000C7A0E File Offset: 0x000C5C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestGetRewardResponse Clone()
		{
			return new DailyQuestGetRewardResponse(this);
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060051FB RID: 20987 RVA: 0x000C7A16 File Offset: 0x000C5C16
		// (set) Token: 0x060051FC RID: 20988 RVA: 0x000C7A1E File Offset: 0x000C5C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060051FD RID: 20989 RVA: 0x000C7A27 File Offset: 0x000C5C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DailyQuestReward> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x000C7A2F File Offset: 0x000C5C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestGetRewardResponse);
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x000C7A40 File Offset: 0x000C5C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestGetRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && this.rewards_.Equals(other.rewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x000C7A90 File Offset: 0x000C5C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			num ^= this.rewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x000C7AE3 File Offset: 0x000C5CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x000C7AF0 File Offset: 0x000C5CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x000C7AFC File Offset: 0x000C5CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewards_.WriteTo(ref output, DailyQuestGetRewardResponse._repeated_rewards_codec);
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x000C7B4C File Offset: 0x000C5D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			num += this.rewards_.CalculateSize(DailyQuestGetRewardResponse._repeated_rewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x000C7BA0 File Offset: 0x000C5DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestGetRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this.rewards_.Add(other.rewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x000C7BED File Offset: 0x000C5DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x000C7BF8 File Offset: 0x000C5DF8
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
				if (num != 34U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorId = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.rewards_.AddEntriesFrom(ref input, DailyQuestGetRewardResponse._repeated_rewards_codec);
				}
			}
		}

		// Token: 0x04003323 RID: 13091
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003324 RID: 13092
		public const int ErrorIdFieldNumber = 6;

		// Token: 0x04003325 RID: 13093
		private ErrorCode errorId_;

		// Token: 0x04003326 RID: 13094
		public const int RewardsFieldNumber = 4;

		// Token: 0x04003327 RID: 13095
		private static readonly FieldCodec<DailyQuestReward> _repeated_rewards_codec = FieldCodec.ForMessage<DailyQuestReward>(34U, DailyQuestReward.Parser);

		// Token: 0x04003328 RID: 13096
		private readonly RepeatedField<DailyQuestReward> rewards_ = new RepeatedField<DailyQuestReward>();
	}
}
