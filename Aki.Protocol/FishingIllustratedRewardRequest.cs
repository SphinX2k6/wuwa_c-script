using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000564 RID: 1380
	[NetMessage(EMessageId.FishingIllustratedRewardRequest)]
	public sealed class FishingIllustratedRewardRequest : IMessage<FishingIllustratedRewardRequest>, IMessage, IEquatable<FishingIllustratedRewardRequest>, IDeepCloneable<FishingIllustratedRewardRequest>, IBufferMessage
	{
		// Token: 0x060080A2 RID: 32930 RVA: 0x00136B54 File Offset: 0x00134D54
		[NullableContext(1)]
		public static FishingIllustratedRewardRequest Create()
		{
			return new FishingIllustratedRewardRequest();
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x060080A3 RID: 32931 RVA: 0x00136B5B File Offset: 0x00134D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x060080A4 RID: 32932 RVA: 0x00136B5E File Offset: 0x00134D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedRewardRequest.Descriptor;
			}
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x00136B65 File Offset: 0x00134D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardRequest()
		{
		}

		// Token: 0x060080A6 RID: 32934 RVA: 0x00136B6D File Offset: 0x00134D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardRequest(FishingIllustratedRewardRequest other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080A7 RID: 32935 RVA: 0x00136B92 File Offset: 0x00134D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardRequest Clone()
		{
			return new FishingIllustratedRewardRequest(this);
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x060080A8 RID: 32936 RVA: 0x00136B9A File Offset: 0x00134D9A
		// (set) Token: 0x060080A9 RID: 32937 RVA: 0x00136BA2 File Offset: 0x00134DA2
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

		// Token: 0x060080AA RID: 32938 RVA: 0x00136BAB File Offset: 0x00134DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedRewardRequest);
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x00136BB9 File Offset: 0x00134DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedRewardRequest other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x00136BE8 File Offset: 0x00134DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x00136C27 File Offset: 0x00134E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x00136C34 File Offset: 0x00134E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x00136C3D File Offset: 0x00134E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x00136C70 File Offset: 0x00134E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x00136CAE File Offset: 0x00134EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingIllustratedRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x00136CDF File Offset: 0x00134EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x00136CE8 File Offset: 0x00134EE8
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040040B5 RID: 16565
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040B6 RID: 16566
		public const int RewardIdFieldNumber = 10;

		// Token: 0x040040B7 RID: 16567
		private int rewardId_;
	}
}
