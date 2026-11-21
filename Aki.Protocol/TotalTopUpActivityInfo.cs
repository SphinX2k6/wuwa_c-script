using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FD RID: 5117
	public sealed class TotalTopUpActivityInfo : IMessage<TotalTopUpActivityInfo>, IMessage, IEquatable<TotalTopUpActivityInfo>, IDeepCloneable<TotalTopUpActivityInfo>, IBufferMessage
	{
		// Token: 0x0601B34C RID: 111436 RVA: 0x003F5448 File Offset: 0x003F3648
		[NullableContext(1)]
		public static TotalTopUpActivityInfo Create()
		{
			return new TotalTopUpActivityInfo();
		}

		// Token: 0x17005C18 RID: 23576
		// (get) Token: 0x0601B34D RID: 111437 RVA: 0x003F544F File Offset: 0x003F364F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C19 RID: 23577
		// (get) Token: 0x0601B34E RID: 111438 RVA: 0x003F5452 File Offset: 0x003F3652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpActivityInfo.Descriptor;
			}
		}

		// Token: 0x0601B34F RID: 111439 RVA: 0x003F5459 File Offset: 0x003F3659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfo()
		{
		}

		// Token: 0x0601B350 RID: 111440 RVA: 0x003F546C File Offset: 0x003F366C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfo(TotalTopUpActivityInfo other) : this()
		{
			this.score_ = other.score_;
			this.totalTopUpRewardInfos_ = other.totalTopUpRewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B351 RID: 111441 RVA: 0x003F54A2 File Offset: 0x003F36A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfo Clone()
		{
			return new TotalTopUpActivityInfo(this);
		}

		// Token: 0x17005C1A RID: 23578
		// (get) Token: 0x0601B352 RID: 111442 RVA: 0x003F54AA File Offset: 0x003F36AA
		// (set) Token: 0x0601B353 RID: 111443 RVA: 0x003F54B2 File Offset: 0x003F36B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x17005C1B RID: 23579
		// (get) Token: 0x0601B354 RID: 111444 RVA: 0x003F54BB File Offset: 0x003F36BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TotalTopUpRewardInfo> TotalTopUpRewardInfos
		{
			get
			{
				return this.totalTopUpRewardInfos_;
			}
		}

		// Token: 0x0601B355 RID: 111445 RVA: 0x003F54C3 File Offset: 0x003F36C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpActivityInfo);
		}

		// Token: 0x0601B356 RID: 111446 RVA: 0x003F54D4 File Offset: 0x003F36D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpActivityInfo other)
		{
			return other != null && (other == this || (this.Score == other.Score && this.totalTopUpRewardInfos_.Equals(other.totalTopUpRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B357 RID: 111447 RVA: 0x003F5524 File Offset: 0x003F3724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			num ^= this.totalTopUpRewardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B358 RID: 111448 RVA: 0x003F5571 File Offset: 0x003F3771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B359 RID: 111449 RVA: 0x003F557E File Offset: 0x003F377E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B35A RID: 111450 RVA: 0x003F5588 File Offset: 0x003F3788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Score != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Score);
			}
			this.totalTopUpRewardInfos_.WriteTo(ref output, TotalTopUpActivityInfo._repeated_totalTopUpRewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B35B RID: 111451 RVA: 0x003F55D8 File Offset: 0x003F37D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			num += this.totalTopUpRewardInfos_.CalculateSize(TotalTopUpActivityInfo._repeated_totalTopUpRewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B35C RID: 111452 RVA: 0x003F562C File Offset: 0x003F382C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this.totalTopUpRewardInfos_.Add(other.totalTopUpRewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B35D RID: 111453 RVA: 0x003F5679 File Offset: 0x003F3879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B35E RID: 111454 RVA: 0x003F5684 File Offset: 0x003F3884
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.totalTopUpRewardInfos_.AddEntriesFrom(ref input, TotalTopUpActivityInfo._repeated_totalTopUpRewardInfos_codec);
					}
				}
				else
				{
					this.Score = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009EA1 RID: 40609
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EA2 RID: 40610
		public const int ScoreFieldNumber = 1;

		// Token: 0x04009EA3 RID: 40611
		private int score_;

		// Token: 0x04009EA4 RID: 40612
		public const int TotalTopUpRewardInfosFieldNumber = 2;

		// Token: 0x04009EA5 RID: 40613
		private static readonly FieldCodec<TotalTopUpRewardInfo> _repeated_totalTopUpRewardInfos_codec = FieldCodec.ForMessage<TotalTopUpRewardInfo>(18U, TotalTopUpRewardInfo.Parser);

		// Token: 0x04009EA6 RID: 40614
		private readonly RepeatedField<TotalTopUpRewardInfo> totalTopUpRewardInfos_ = new RepeatedField<TotalTopUpRewardInfo>();
	}
}
