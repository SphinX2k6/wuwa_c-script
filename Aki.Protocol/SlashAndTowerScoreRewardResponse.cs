using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001291 RID: 4753
	[NetMessage(EMessageId.SlashAndTowerScoreRewardResponse)]
	public sealed class SlashAndTowerScoreRewardResponse : IMessage<SlashAndTowerScoreRewardResponse>, IMessage, IEquatable<SlashAndTowerScoreRewardResponse>, IDeepCloneable<SlashAndTowerScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x060195DF RID: 103903 RVA: 0x003B2FC8 File Offset: 0x003B11C8
		[NullableContext(1)]
		public static SlashAndTowerScoreRewardResponse Create()
		{
			return new SlashAndTowerScoreRewardResponse();
		}

		// Token: 0x170055CA RID: 21962
		// (get) Token: 0x060195E0 RID: 103904 RVA: 0x003B2FCF File Offset: 0x003B11CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055CB RID: 21963
		// (get) Token: 0x060195E1 RID: 103905 RVA: 0x003B2FD2 File Offset: 0x003B11D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x060195E2 RID: 103906 RVA: 0x003B2FD9 File Offset: 0x003B11D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardResponse()
		{
		}

		// Token: 0x060195E3 RID: 103907 RVA: 0x003B2FEC File Offset: 0x003B11EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardResponse(SlashAndTowerScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060195E4 RID: 103908 RVA: 0x003B3022 File Offset: 0x003B1222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardResponse Clone()
		{
			return new SlashAndTowerScoreRewardResponse(this);
		}

		// Token: 0x170055CC RID: 21964
		// (get) Token: 0x060195E5 RID: 103909 RVA: 0x003B302A File Offset: 0x003B122A
		// (set) Token: 0x060195E6 RID: 103910 RVA: 0x003B3032 File Offset: 0x003B1232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170055CD RID: 21965
		// (get) Token: 0x060195E7 RID: 103911 RVA: 0x003B303B File Offset: 0x003B123B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x060195E8 RID: 103912 RVA: 0x003B3043 File Offset: 0x003B1243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerScoreRewardResponse);
		}

		// Token: 0x060195E9 RID: 103913 RVA: 0x003B3054 File Offset: 0x003B1254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060195EA RID: 103914 RVA: 0x003B30A4 File Offset: 0x003B12A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.rewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060195EB RID: 103915 RVA: 0x003B30F7 File Offset: 0x003B12F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060195EC RID: 103916 RVA: 0x003B3104 File Offset: 0x003B1304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060195ED RID: 103917 RVA: 0x003B3110 File Offset: 0x003B1310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.rewardIds_.WriteTo(ref output, SlashAndTowerScoreRewardResponse._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060195EE RID: 103918 RVA: 0x003B3160 File Offset: 0x003B1360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rewardIds_.CalculateSize(SlashAndTowerScoreRewardResponse._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060195EF RID: 103919 RVA: 0x003B31B4 File Offset: 0x003B13B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060195F0 RID: 103920 RVA: 0x003B3201 File Offset: 0x003B1401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060195F1 RID: 103921 RVA: 0x003B320C File Offset: 0x003B140C
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
				if (num != 88U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewardIds_.AddEntriesFrom(ref input, SlashAndTowerScoreRewardResponse._repeated_rewardIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009601 RID: 38401
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009602 RID: 38402
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009603 RID: 38403
		private ErrorCode errorCode_;

		// Token: 0x04009604 RID: 38404
		public const int RewardIdsFieldNumber = 13;

		// Token: 0x04009605 RID: 38405
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04009606 RID: 38406
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
