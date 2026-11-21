using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001281 RID: 4737
	[NetMessage(EMessageId.SkinRewardInfoUpdateNotify)]
	public sealed class SkinRewardInfoUpdateNotify : IMessage<SkinRewardInfoUpdateNotify>, IMessage, IEquatable<SkinRewardInfoUpdateNotify>, IDeepCloneable<SkinRewardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060194A3 RID: 103587 RVA: 0x003B05FB File Offset: 0x003AE7FB
		[NullableContext(1)]
		public static SkinRewardInfoUpdateNotify Create()
		{
			return new SkinRewardInfoUpdateNotify();
		}

		// Token: 0x1700558A RID: 21898
		// (get) Token: 0x060194A4 RID: 103588 RVA: 0x003B0602 File Offset: 0x003AE802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700558B RID: 21899
		// (get) Token: 0x060194A5 RID: 103589 RVA: 0x003B0605 File Offset: 0x003AE805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinRewardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060194A6 RID: 103590 RVA: 0x003B060C File Offset: 0x003AE80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardInfoUpdateNotify()
		{
		}

		// Token: 0x060194A7 RID: 103591 RVA: 0x003B0614 File Offset: 0x003AE814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardInfoUpdateNotify(SkinRewardInfoUpdateNotify other) : this()
		{
			this.rewardInfo_ = ((other.rewardInfo_ != null) ? other.rewardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060194A8 RID: 103592 RVA: 0x003B0649 File Offset: 0x003AE849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardInfoUpdateNotify Clone()
		{
			return new SkinRewardInfoUpdateNotify(this);
		}

		// Token: 0x1700558C RID: 21900
		// (get) Token: 0x060194A9 RID: 103593 RVA: 0x003B0651 File Offset: 0x003AE851
		// (set) Token: 0x060194AA RID: 103594 RVA: 0x003B0659 File Offset: 0x003AE859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityRewardInfo RewardInfo
		{
			get
			{
				return this.rewardInfo_;
			}
			set
			{
				this.rewardInfo_ = value;
			}
		}

		// Token: 0x060194AB RID: 103595 RVA: 0x003B0662 File Offset: 0x003AE862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinRewardInfoUpdateNotify);
		}

		// Token: 0x060194AC RID: 103596 RVA: 0x003B0670 File Offset: 0x003AE870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinRewardInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RewardInfo, other.RewardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060194AD RID: 103597 RVA: 0x003B06A4 File Offset: 0x003AE8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rewardInfo_ != null)
			{
				num ^= this.RewardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060194AE RID: 103598 RVA: 0x003B06E0 File Offset: 0x003AE8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060194AF RID: 103599 RVA: 0x003B06ED File Offset: 0x003AE8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060194B0 RID: 103600 RVA: 0x003B06F6 File Offset: 0x003AE8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RewardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060194B1 RID: 103601 RVA: 0x003B0728 File Offset: 0x003AE928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rewardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060194B2 RID: 103602 RVA: 0x003B0768 File Offset: 0x003AE968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkinRewardInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rewardInfo_ != null)
			{
				if (this.rewardInfo_ == null)
				{
					this.RewardInfo = new SkinRewardActivityRewardInfo();
				}
				this.RewardInfo.MergeFrom(other.RewardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060194B3 RID: 103603 RVA: 0x003B07BC File Offset: 0x003AE9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060194B4 RID: 103604 RVA: 0x003B07C8 File Offset: 0x003AE9C8
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rewardInfo_ == null)
					{
						this.RewardInfo = new SkinRewardActivityRewardInfo();
					}
					input.ReadMessage(this.RewardInfo);
				}
			}
		}

		// Token: 0x040095A8 RID: 38312
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095A9 RID: 38313
		public const int RewardInfoFieldNumber = 14;

		// Token: 0x040095AA RID: 38314
		private SkinRewardActivityRewardInfo rewardInfo_;
	}
}
