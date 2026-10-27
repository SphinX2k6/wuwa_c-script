using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F4 RID: 1780
	[NetMessage(EMessageId.GivebackRewardRequest)]
	public sealed class GivebackRewardRequest : IMessage<GivebackRewardRequest>, IMessage, IEquatable<GivebackRewardRequest>, IDeepCloneable<GivebackRewardRequest>, IBufferMessage
	{
		// Token: 0x0600A23D RID: 41533 RVA: 0x001887D2 File Offset: 0x001869D2
		[NullableContext(1)]
		public static GivebackRewardRequest Create()
		{
			return new GivebackRewardRequest();
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x0600A23E RID: 41534 RVA: 0x001887D9 File Offset: 0x001869D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x0600A23F RID: 41535 RVA: 0x001887DC File Offset: 0x001869DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x001887E3 File Offset: 0x001869E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardRequest()
		{
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x001887F6 File Offset: 0x001869F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardRequest(GivebackRewardRequest other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this.rwdId_ = other.rwdId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x0018882C File Offset: 0x00186A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackRewardRequest Clone()
		{
			return new GivebackRewardRequest(this);
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x0600A243 RID: 41539 RVA: 0x00188834 File Offset: 0x00186A34
		// (set) Token: 0x0600A244 RID: 41540 RVA: 0x0018883C File Offset: 0x00186A3C
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

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x0600A245 RID: 41541 RVA: 0x00188845 File Offset: 0x00186A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RwdId
		{
			get
			{
				return this.rwdId_;
			}
		}

		// Token: 0x0600A246 RID: 41542 RVA: 0x0018884D File Offset: 0x00186A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackRewardRequest);
		}

		// Token: 0x0600A247 RID: 41543 RVA: 0x0018885C File Offset: 0x00186A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackRewardRequest other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && this.rwdId_.Equals(other.rwdId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A248 RID: 41544 RVA: 0x001888AC File Offset: 0x00186AAC
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

		// Token: 0x0600A249 RID: 41545 RVA: 0x001888F9 File Offset: 0x00186AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A24A RID: 41546 RVA: 0x00188906 File Offset: 0x00186B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A24B RID: 41547 RVA: 0x00188910 File Offset: 0x00186B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rwdId_.WriteTo(ref output, GivebackRewardRequest._repeated_rwdId_codec);
			if (this.RewardId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x00188960 File Offset: 0x00186B60
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

		// Token: 0x0600A24D RID: 41549 RVA: 0x001889B4 File Offset: 0x00186BB4
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

		// Token: 0x0600A24E RID: 41550 RVA: 0x00188A01 File Offset: 0x00186C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A24F RID: 41551 RVA: 0x00188A0C File Offset: 0x00186C0C
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
				if (num != 40U && num != 42U)
				{
					if (num != 64U)
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

		// Token: 0x04004B3D RID: 19261
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B3E RID: 19262
		public const int RewardIdFieldNumber = 8;

		// Token: 0x04004B3F RID: 19263
		private int rewardId_;

		// Token: 0x04004B40 RID: 19264
		public const int RwdIdFieldNumber = 5;

		// Token: 0x04004B41 RID: 19265
		private static readonly FieldCodec<int> _repeated_rwdId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04004B42 RID: 19266
		private readonly RepeatedField<int> rwdId_ = new RepeatedField<int>();
	}
}
