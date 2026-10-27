using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001244 RID: 4676
	[NetMessage(EMessageId.SkinRewardInfoUpdateNotify)]
	public sealed class SkinRewardInfoUpdateNotify : IMessage<SkinRewardInfoUpdateNotify>, IMessage, IEquatable<SkinRewardInfoUpdateNotify>, IDeepCloneable<SkinRewardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018EB9 RID: 102073 RVA: 0x003A069B File Offset: 0x0039E89B
		[NullableContext(1)]
		public static SkinRewardInfoUpdateNotify Create()
		{
			return new SkinRewardInfoUpdateNotify();
		}

		// Token: 0x1700540B RID: 21515
		// (get) Token: 0x06018EBA RID: 102074 RVA: 0x003A06A2 File Offset: 0x0039E8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700540C RID: 21516
		// (get) Token: 0x06018EBB RID: 102075 RVA: 0x003A06A5 File Offset: 0x0039E8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinRewardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018EBC RID: 102076 RVA: 0x003A06AC File Offset: 0x0039E8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardInfoUpdateNotify()
		{
		}

		// Token: 0x06018EBD RID: 102077 RVA: 0x003A06B4 File Offset: 0x0039E8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardInfoUpdateNotify(SkinRewardInfoUpdateNotify other) : this()
		{
			this.rewardInfo_ = ((other.rewardInfo_ != null) ? other.rewardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018EBE RID: 102078 RVA: 0x003A06E9 File Offset: 0x0039E8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardInfoUpdateNotify Clone()
		{
			return new SkinRewardInfoUpdateNotify(this);
		}

		// Token: 0x1700540D RID: 21517
		// (get) Token: 0x06018EBF RID: 102079 RVA: 0x003A06F1 File Offset: 0x0039E8F1
		// (set) Token: 0x06018EC0 RID: 102080 RVA: 0x003A06F9 File Offset: 0x0039E8F9
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

		// Token: 0x06018EC1 RID: 102081 RVA: 0x003A0702 File Offset: 0x0039E902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinRewardInfoUpdateNotify);
		}

		// Token: 0x06018EC2 RID: 102082 RVA: 0x003A0710 File Offset: 0x0039E910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinRewardInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RewardInfo, other.RewardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018EC3 RID: 102083 RVA: 0x003A0744 File Offset: 0x0039E944
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

		// Token: 0x06018EC4 RID: 102084 RVA: 0x003A0780 File Offset: 0x0039E980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018EC5 RID: 102085 RVA: 0x003A078D File Offset: 0x0039E98D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018EC6 RID: 102086 RVA: 0x003A0796 File Offset: 0x0039E996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RewardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018EC7 RID: 102087 RVA: 0x003A07C8 File Offset: 0x0039E9C8
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

		// Token: 0x06018EC8 RID: 102088 RVA: 0x003A0808 File Offset: 0x0039EA08
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

		// Token: 0x06018EC9 RID: 102089 RVA: 0x003A085C File Offset: 0x0039EA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018ECA RID: 102090 RVA: 0x003A0868 File Offset: 0x0039EA68
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

		// Token: 0x040092F6 RID: 37622
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092F7 RID: 37623
		public const int RewardInfoFieldNumber = 4;

		// Token: 0x040092F8 RID: 37624
		private SkinRewardActivityRewardInfo rewardInfo_;
	}
}
