using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068C RID: 1676
	[NetMessage(EMessageId.GachaAccumulateRewardRequest)]
	public sealed class GachaAccumulateRewardRequest : IMessage<GachaAccumulateRewardRequest>, IMessage, IEquatable<GachaAccumulateRewardRequest>, IDeepCloneable<GachaAccumulateRewardRequest>, IBufferMessage
	{
		// Token: 0x0600996A RID: 39274 RVA: 0x00171963 File Offset: 0x0016FB63
		[NullableContext(1)]
		public static GachaAccumulateRewardRequest Create()
		{
			return new GachaAccumulateRewardRequest();
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x0600996B RID: 39275 RVA: 0x0017196A File Offset: 0x0016FB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x0600996C RID: 39276 RVA: 0x0017196D File Offset: 0x0016FB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600996D RID: 39277 RVA: 0x00171974 File Offset: 0x0016FB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardRequest()
		{
		}

		// Token: 0x0600996E RID: 39278 RVA: 0x00171994 File Offset: 0x0016FB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardRequest(GachaAccumulateRewardRequest other) : this()
		{
			this.gachaAccumulateId_ = other.gachaAccumulateId_;
			this.rewardId_ = other.rewardId_.Clone();
			this.selectedId_ = other.selectedId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600996F RID: 39279 RVA: 0x001719E6 File Offset: 0x0016FBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateRewardRequest Clone()
		{
			return new GachaAccumulateRewardRequest(this);
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x06009970 RID: 39280 RVA: 0x001719EE File Offset: 0x0016FBEE
		// (set) Token: 0x06009971 RID: 39281 RVA: 0x001719F6 File Offset: 0x0016FBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaAccumulateId
		{
			get
			{
				return this.gachaAccumulateId_;
			}
			set
			{
				this.gachaAccumulateId_ = value;
			}
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x06009972 RID: 39282 RVA: 0x001719FF File Offset: 0x0016FBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardId
		{
			get
			{
				return this.rewardId_;
			}
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x06009973 RID: 39283 RVA: 0x00171A07 File Offset: 0x0016FC07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedId
		{
			get
			{
				return this.selectedId_;
			}
		}

		// Token: 0x06009974 RID: 39284 RVA: 0x00171A0F File Offset: 0x0016FC0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateRewardRequest);
		}

		// Token: 0x06009975 RID: 39285 RVA: 0x00171A20 File Offset: 0x0016FC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateRewardRequest other)
		{
			return other != null && (other == this || (this.GachaAccumulateId == other.GachaAccumulateId && this.rewardId_.Equals(other.rewardId_) && this.selectedId_.Equals(other.selectedId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009976 RID: 39286 RVA: 0x00171A84 File Offset: 0x0016FC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaAccumulateId != 0)
			{
				num ^= this.GachaAccumulateId.GetHashCode();
			}
			num ^= this.rewardId_.GetHashCode();
			num ^= this.selectedId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009977 RID: 39287 RVA: 0x00171ADF File Offset: 0x0016FCDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009978 RID: 39288 RVA: 0x00171AEC File Offset: 0x0016FCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009979 RID: 39289 RVA: 0x00171AF8 File Offset: 0x0016FCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardId_.WriteTo(ref output, GachaAccumulateRewardRequest._repeated_rewardId_codec);
			if (this.GachaAccumulateId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.GachaAccumulateId);
			}
			this.selectedId_.WriteTo(ref output, GachaAccumulateRewardRequest._repeated_selectedId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600997A RID: 39290 RVA: 0x00171B58 File Offset: 0x0016FD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaAccumulateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaAccumulateId);
			}
			num += this.rewardId_.CalculateSize(GachaAccumulateRewardRequest._repeated_rewardId_codec);
			num += this.selectedId_.CalculateSize(GachaAccumulateRewardRequest._repeated_selectedId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600997B RID: 39291 RVA: 0x00171BBC File Offset: 0x0016FDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaAccumulateId != 0)
			{
				this.GachaAccumulateId = other.GachaAccumulateId;
			}
			this.rewardId_.Add(other.rewardId_);
			this.selectedId_.Add(other.selectedId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600997C RID: 39292 RVA: 0x00171C1A File Offset: 0x0016FE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600997D RID: 39293 RVA: 0x00171C24 File Offset: 0x0016FE24
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
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.rewardId_.AddEntriesFrom(ref input, GachaAccumulateRewardRequest._repeated_rewardId_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.GachaAccumulateId = input.ReadInt32();
						continue;
					}
					if (num == 104U || num == 106U)
					{
						this.selectedId_.AddEntriesFrom(ref input, GachaAccumulateRewardRequest._repeated_selectedId_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004894 RID: 18580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004895 RID: 18581
		public const int GachaAccumulateIdFieldNumber = 7;

		// Token: 0x04004896 RID: 18582
		private int gachaAccumulateId_;

		// Token: 0x04004897 RID: 18583
		public const int RewardIdFieldNumber = 4;

		// Token: 0x04004898 RID: 18584
		private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04004899 RID: 18585
		private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

		// Token: 0x0400489A RID: 18586
		public const int SelectedIdFieldNumber = 13;

		// Token: 0x0400489B RID: 18587
		private static readonly FieldCodec<int> _repeated_selectedId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x0400489C RID: 18588
		private readonly RepeatedField<int> selectedId_ = new RepeatedField<int>();
	}
}
