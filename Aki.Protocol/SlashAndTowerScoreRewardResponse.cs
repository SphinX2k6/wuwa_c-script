using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001254 RID: 4692
	[NetMessage(EMessageId.SlashAndTowerScoreRewardResponse)]
	public sealed class SlashAndTowerScoreRewardResponse : IMessage<SlashAndTowerScoreRewardResponse>, IMessage, IEquatable<SlashAndTowerScoreRewardResponse>, IDeepCloneable<SlashAndTowerScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x06018FF5 RID: 102389 RVA: 0x003A3078 File Offset: 0x003A1278
		[NullableContext(1)]
		public static SlashAndTowerScoreRewardResponse Create()
		{
			return new SlashAndTowerScoreRewardResponse();
		}

		// Token: 0x1700544B RID: 21579
		// (get) Token: 0x06018FF6 RID: 102390 RVA: 0x003A307F File Offset: 0x003A127F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700544C RID: 21580
		// (get) Token: 0x06018FF7 RID: 102391 RVA: 0x003A3082 File Offset: 0x003A1282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x06018FF8 RID: 102392 RVA: 0x003A3089 File Offset: 0x003A1289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardResponse()
		{
		}

		// Token: 0x06018FF9 RID: 102393 RVA: 0x003A309C File Offset: 0x003A129C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardResponse(SlashAndTowerScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018FFA RID: 102394 RVA: 0x003A30D2 File Offset: 0x003A12D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerScoreRewardResponse Clone()
		{
			return new SlashAndTowerScoreRewardResponse(this);
		}

		// Token: 0x1700544D RID: 21581
		// (get) Token: 0x06018FFB RID: 102395 RVA: 0x003A30DA File Offset: 0x003A12DA
		// (set) Token: 0x06018FFC RID: 102396 RVA: 0x003A30E2 File Offset: 0x003A12E2
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

		// Token: 0x1700544E RID: 21582
		// (get) Token: 0x06018FFD RID: 102397 RVA: 0x003A30EB File Offset: 0x003A12EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x06018FFE RID: 102398 RVA: 0x003A30F3 File Offset: 0x003A12F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerScoreRewardResponse);
		}

		// Token: 0x06018FFF RID: 102399 RVA: 0x003A3104 File Offset: 0x003A1304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019000 RID: 102400 RVA: 0x003A3154 File Offset: 0x003A1354
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

		// Token: 0x06019001 RID: 102401 RVA: 0x003A31A7 File Offset: 0x003A13A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019002 RID: 102402 RVA: 0x003A31B4 File Offset: 0x003A13B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019003 RID: 102403 RVA: 0x003A31C0 File Offset: 0x003A13C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.rewardIds_.WriteTo(ref output, SlashAndTowerScoreRewardResponse._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019004 RID: 102404 RVA: 0x003A3210 File Offset: 0x003A1410
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

		// Token: 0x06019005 RID: 102405 RVA: 0x003A3264 File Offset: 0x003A1464
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

		// Token: 0x06019006 RID: 102406 RVA: 0x003A32B1 File Offset: 0x003A14B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019007 RID: 102407 RVA: 0x003A32BC File Offset: 0x003A14BC
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
				if (num != 24U)
				{
					if (num != 88U && num != 90U)
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

		// Token: 0x0400934F RID: 37711
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009350 RID: 37712
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009351 RID: 37713
		private ErrorCode errorCode_;

		// Token: 0x04009352 RID: 37714
		public const int RewardIdsFieldNumber = 11;

		// Token: 0x04009353 RID: 37715
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04009354 RID: 37716
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
