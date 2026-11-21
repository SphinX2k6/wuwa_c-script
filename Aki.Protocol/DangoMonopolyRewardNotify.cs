using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000394 RID: 916
	[NetMessage(EMessageId.DangoMonopolyRewardNotify)]
	public sealed class DangoMonopolyRewardNotify : IMessage<DangoMonopolyRewardNotify>, IMessage, IEquatable<DangoMonopolyRewardNotify>, IDeepCloneable<DangoMonopolyRewardNotify>, IBufferMessage
	{
		// Token: 0x06005AAC RID: 23212 RVA: 0x000DCECB File Offset: 0x000DB0CB
		[NullableContext(1)]
		public static DangoMonopolyRewardNotify Create()
		{
			return new DangoMonopolyRewardNotify();
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06005AAD RID: 23213 RVA: 0x000DCED2 File Offset: 0x000DB0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06005AAE RID: 23214 RVA: 0x000DCED5 File Offset: 0x000DB0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyRewardNotify.Descriptor;
			}
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x000DCEDC File Offset: 0x000DB0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardNotify()
		{
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x000DCEEF File Offset: 0x000DB0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardNotify(DangoMonopolyRewardNotify other) : this()
		{
			this.reason_ = other.reason_;
			this.rewardDatas_ = other.rewardDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x000DCF25 File Offset: 0x000DB125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardNotify Clone()
		{
			return new DangoMonopolyRewardNotify(this);
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06005AB2 RID: 23218 RVA: 0x000DCF2D File Offset: 0x000DB12D
		// (set) Token: 0x06005AB3 RID: 23219 RVA: 0x000DCF35 File Offset: 0x000DB135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06005AB4 RID: 23220 RVA: 0x000DCF3E File Offset: 0x000DB13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoMonopolyRewardPb> RewardDatas
		{
			get
			{
				return this.rewardDatas_;
			}
		}

		// Token: 0x06005AB5 RID: 23221 RVA: 0x000DCF46 File Offset: 0x000DB146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyRewardNotify);
		}

		// Token: 0x06005AB6 RID: 23222 RVA: 0x000DCF54 File Offset: 0x000DB154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyRewardNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.rewardDatas_.Equals(other.rewardDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x000DCFA4 File Offset: 0x000DB1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			num ^= this.rewardDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x000DCFF1 File Offset: 0x000DB1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x000DCFFE File Offset: 0x000DB1FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x000DD008 File Offset: 0x000DB208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Reason);
			}
			this.rewardDatas_.WriteTo(ref output, DangoMonopolyRewardNotify._repeated_rewardDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x000DD058 File Offset: 0x000DB258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			num += this.rewardDatas_.CalculateSize(DangoMonopolyRewardNotify._repeated_rewardDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x000DD0AC File Offset: 0x000DB2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this.rewardDatas_.Add(other.rewardDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x000DD0F9 File Offset: 0x000DB2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x000DD104 File Offset: 0x000DB304
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
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewardDatas_.AddEntriesFrom(ref input, DangoMonopolyRewardNotify._repeated_rewardDatas_codec);
					}
				}
				else
				{
					this.Reason = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003618 RID: 13848
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003619 RID: 13849
		public const int ReasonFieldNumber = 1;

		// Token: 0x0400361A RID: 13850
		private int reason_;

		// Token: 0x0400361B RID: 13851
		public const int RewardDatasFieldNumber = 3;

		// Token: 0x0400361C RID: 13852
		private static readonly FieldCodec<DangoMonopolyRewardPb> _repeated_rewardDatas_codec = FieldCodec.ForMessage<DangoMonopolyRewardPb>(26U, DangoMonopolyRewardPb.Parser);

		// Token: 0x0400361D RID: 13853
		private readonly RepeatedField<DangoMonopolyRewardPb> rewardDatas_ = new RepeatedField<DangoMonopolyRewardPb>();
	}
}
