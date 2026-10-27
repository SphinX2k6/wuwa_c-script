using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000686 RID: 1670
	public sealed class GachaAccumulateGroupInfo : IMessage<GachaAccumulateGroupInfo>, IMessage, IEquatable<GachaAccumulateGroupInfo>, IDeepCloneable<GachaAccumulateGroupInfo>, IBufferMessage
	{
		// Token: 0x060098E5 RID: 39141 RVA: 0x001704D7 File Offset: 0x0016E6D7
		[NullableContext(1)]
		public static GachaAccumulateGroupInfo Create()
		{
			return new GachaAccumulateGroupInfo();
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x060098E6 RID: 39142 RVA: 0x001704DE File Offset: 0x0016E6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x060098E7 RID: 39143 RVA: 0x001704E1 File Offset: 0x0016E6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateGroupInfo.Descriptor;
			}
		}

		// Token: 0x060098E8 RID: 39144 RVA: 0x001704E8 File Offset: 0x0016E6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateGroupInfo()
		{
		}

		// Token: 0x060098E9 RID: 39145 RVA: 0x001704FC File Offset: 0x0016E6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateGroupInfo(GachaAccumulateGroupInfo other) : this()
		{
			this.groupId_ = other.groupId_;
			this.curGachaNum_ = other.curGachaNum_;
			this.gachaAccumulateRewardInfos_ = other.gachaAccumulateRewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x00170549 File Offset: 0x0016E749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateGroupInfo Clone()
		{
			return new GachaAccumulateGroupInfo(this);
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x060098EB RID: 39147 RVA: 0x00170551 File Offset: 0x0016E751
		// (set) Token: 0x060098EC RID: 39148 RVA: 0x00170559 File Offset: 0x0016E759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x060098ED RID: 39149 RVA: 0x00170562 File Offset: 0x0016E762
		// (set) Token: 0x060098EE RID: 39150 RVA: 0x0017056A File Offset: 0x0016E76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurGachaNum
		{
			get
			{
				return this.curGachaNum_;
			}
			set
			{
				this.curGachaNum_ = value;
			}
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x060098EF RID: 39151 RVA: 0x00170573 File Offset: 0x0016E773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaAccumulateRewardInfo> GachaAccumulateRewardInfos
		{
			get
			{
				return this.gachaAccumulateRewardInfos_;
			}
		}

		// Token: 0x060098F0 RID: 39152 RVA: 0x0017057B File Offset: 0x0016E77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateGroupInfo);
		}

		// Token: 0x060098F1 RID: 39153 RVA: 0x0017058C File Offset: 0x0016E78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateGroupInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.CurGachaNum == other.CurGachaNum && this.gachaAccumulateRewardInfos_.Equals(other.gachaAccumulateRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060098F2 RID: 39154 RVA: 0x001705EC File Offset: 0x0016E7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.CurGachaNum != 0)
			{
				num ^= this.CurGachaNum.GetHashCode();
			}
			num ^= this.gachaAccumulateRewardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098F3 RID: 39155 RVA: 0x00170652 File Offset: 0x0016E852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060098F4 RID: 39156 RVA: 0x0017065F File Offset: 0x0016E85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098F5 RID: 39157 RVA: 0x00170668 File Offset: 0x0016E868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.CurGachaNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurGachaNum);
			}
			this.gachaAccumulateRewardInfos_.WriteTo(ref output, GachaAccumulateGroupInfo._repeated_gachaAccumulateRewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098F6 RID: 39158 RVA: 0x001706D4 File Offset: 0x0016E8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.CurGachaNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurGachaNum);
			}
			num += this.gachaAccumulateRewardInfos_.CalculateSize(GachaAccumulateGroupInfo._repeated_gachaAccumulateRewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098F7 RID: 39159 RVA: 0x00170740 File Offset: 0x0016E940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.CurGachaNum != 0)
			{
				this.CurGachaNum = other.CurGachaNum;
			}
			this.gachaAccumulateRewardInfos_.Add(other.gachaAccumulateRewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060098F8 RID: 39160 RVA: 0x001707A1 File Offset: 0x0016E9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098F9 RID: 39161 RVA: 0x001707AC File Offset: 0x0016E9AC
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
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.gachaAccumulateRewardInfos_.AddEntriesFrom(ref input, GachaAccumulateGroupInfo._repeated_gachaAccumulateRewardInfos_codec);
						}
					}
					else
					{
						this.CurGachaNum = input.ReadInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004867 RID: 18535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004868 RID: 18536
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04004869 RID: 18537
		private int groupId_;

		// Token: 0x0400486A RID: 18538
		public const int CurGachaNumFieldNumber = 2;

		// Token: 0x0400486B RID: 18539
		private int curGachaNum_;

		// Token: 0x0400486C RID: 18540
		public const int GachaAccumulateRewardInfosFieldNumber = 3;

		// Token: 0x0400486D RID: 18541
		private static readonly FieldCodec<GachaAccumulateRewardInfo> _repeated_gachaAccumulateRewardInfos_codec = FieldCodec.ForMessage<GachaAccumulateRewardInfo>(26U, GachaAccumulateRewardInfo.Parser);

		// Token: 0x0400486E RID: 18542
		private readonly RepeatedField<GachaAccumulateRewardInfo> gachaAccumulateRewardInfos_ = new RepeatedField<GachaAccumulateRewardInfo>();
	}
}
