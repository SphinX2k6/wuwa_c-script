using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E0 RID: 1760
	[NetMessage(EMessageId.GivebackRewardRequest)]
	public sealed class GivebackRewardRequest : IMessage<GivebackRewardRequest>, IMessage, IEquatable<GivebackRewardRequest>, IDeepCloneable<GivebackRewardRequest>, IBufferMessage
	{
		// Token: 0x0600A0E7 RID: 41191 RVA: 0x00185D9E File Offset: 0x00183F9E
		[NullableContext(1)]
		public static GivebackRewardRequest Create()
		{
			return new GivebackRewardRequest();
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x0600A0E8 RID: 41192 RVA: 0x00185DA5 File Offset: 0x00183FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x0600A0E9 RID: 41193 RVA: 0x00185DA8 File Offset: 0x00183FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x00185DAF File Offset: 0x00183FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardRequest()
		{
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x00185DC2 File Offset: 0x00183FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardRequest(GivebackRewardRequest other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this.rwdId_ = other.rwdId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0EC RID: 41196 RVA: 0x00185DF8 File Offset: 0x00183FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardRequest Clone()
		{
			return new GivebackRewardRequest(this);
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x0600A0ED RID: 41197 RVA: 0x00185E00 File Offset: 0x00184000
		// (set) Token: 0x0600A0EE RID: 41198 RVA: 0x00185E08 File Offset: 0x00184008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x0600A0EF RID: 41199 RVA: 0x00185E11 File Offset: 0x00184011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RwdId
		{
			get
			{
				return this.rwdId_;
			}
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x00185E19 File Offset: 0x00184019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackRewardRequest);
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x00185E28 File Offset: 0x00184028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackRewardRequest other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && this.rwdId_.Equals(other.rwdId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x00185E78 File Offset: 0x00184078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			num ^= this.rwdId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x00185EC5 File Offset: 0x001840C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x00185ED2 File Offset: 0x001840D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x00185EDC File Offset: 0x001840DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rwdId_.WriteTo(ref output, GivebackRewardRequest._repeated_rwdId_codec);
			if (this.RewardId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x00185F2C File Offset: 0x0018412C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			num += this.rwdId_.CalculateSize(GivebackRewardRequest._repeated_rwdId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x00185F80 File Offset: 0x00184180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			this.rwdId_.Add(other.rwdId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x00185FCD File Offset: 0x001841CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x00185FD8 File Offset: 0x001841D8
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RewardId = input.ReadInt32();
					}
				}
				else
				{
					this.rwdId_.AddEntriesFrom(ref input, GivebackRewardRequest._repeated_rwdId_codec);
				}
			}
		}

		// Token: 0x04004B36 RID: 19254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B37 RID: 19255
		public const int RewardIdFieldNumber = 12;

		// Token: 0x04004B38 RID: 19256
		private int rewardId_;

		// Token: 0x04004B39 RID: 19257
		public const int RwdIdFieldNumber = 2;

		// Token: 0x04004B3A RID: 19258
		private static readonly FieldCodec<int> _repeated_rwdId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004B3B RID: 19259
		private readonly RepeatedField<int> rwdId_ = new RepeatedField<int>();
	}
}
