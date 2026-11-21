using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000672 RID: 1650
	public sealed class GachaAccumulateGroupInfo : IMessage<GachaAccumulateGroupInfo>, IMessage, IEquatable<GachaAccumulateGroupInfo>, IDeepCloneable<GachaAccumulateGroupInfo>, IBufferMessage
	{
		// Token: 0x0600978F RID: 38799 RVA: 0x0016DAA4 File Offset: 0x0016BCA4
		[NullableContext(1)]
		public static GachaAccumulateGroupInfo Create()
		{
			return new GachaAccumulateGroupInfo();
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x06009790 RID: 38800 RVA: 0x0016DAAB File Offset: 0x0016BCAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x06009791 RID: 38801 RVA: 0x0016DAAE File Offset: 0x0016BCAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateGroupInfo.Descriptor;
			}
		}

		// Token: 0x06009792 RID: 38802 RVA: 0x0016DAB5 File Offset: 0x0016BCB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateGroupInfo()
		{
		}

		// Token: 0x06009793 RID: 38803 RVA: 0x0016DAC8 File Offset: 0x0016BCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateGroupInfo(GachaAccumulateGroupInfo other) : this()
		{
			this.groupId_ = other.groupId_;
			this.curGachaNum_ = other.curGachaNum_;
			this.gachaAccumulateRewardInfos_ = other.gachaAccumulateRewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009794 RID: 38804 RVA: 0x0016DB15 File Offset: 0x0016BD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateGroupInfo Clone()
		{
			return new GachaAccumulateGroupInfo(this);
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x06009795 RID: 38805 RVA: 0x0016DB1D File Offset: 0x0016BD1D
		// (set) Token: 0x06009796 RID: 38806 RVA: 0x0016DB25 File Offset: 0x0016BD25
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

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x06009797 RID: 38807 RVA: 0x0016DB2E File Offset: 0x0016BD2E
		// (set) Token: 0x06009798 RID: 38808 RVA: 0x0016DB36 File Offset: 0x0016BD36
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

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x06009799 RID: 38809 RVA: 0x0016DB3F File Offset: 0x0016BD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaAccumulateRewardInfo> GachaAccumulateRewardInfos
		{
			get
			{
				return this.gachaAccumulateRewardInfos_;
			}
		}

		// Token: 0x0600979A RID: 38810 RVA: 0x0016DB47 File Offset: 0x0016BD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateGroupInfo);
		}

		// Token: 0x0600979B RID: 38811 RVA: 0x0016DB58 File Offset: 0x0016BD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateGroupInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.CurGachaNum == other.CurGachaNum && this.gachaAccumulateRewardInfos_.Equals(other.gachaAccumulateRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600979C RID: 38812 RVA: 0x0016DBB8 File Offset: 0x0016BDB8
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

		// Token: 0x0600979D RID: 38813 RVA: 0x0016DC1E File Offset: 0x0016BE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600979E RID: 38814 RVA: 0x0016DC2B File Offset: 0x0016BE2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600979F RID: 38815 RVA: 0x0016DC34 File Offset: 0x0016BE34
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

		// Token: 0x060097A0 RID: 38816 RVA: 0x0016DCA0 File Offset: 0x0016BEA0
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

		// Token: 0x060097A1 RID: 38817 RVA: 0x0016DD0C File Offset: 0x0016BF0C
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

		// Token: 0x060097A2 RID: 38818 RVA: 0x0016DD6D File Offset: 0x0016BF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097A3 RID: 38819 RVA: 0x0016DD78 File Offset: 0x0016BF78
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

		// Token: 0x04004860 RID: 18528
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004861 RID: 18529
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04004862 RID: 18530
		private int groupId_;

		// Token: 0x04004863 RID: 18531
		public const int CurGachaNumFieldNumber = 2;

		// Token: 0x04004864 RID: 18532
		private int curGachaNum_;

		// Token: 0x04004865 RID: 18533
		public const int GachaAccumulateRewardInfosFieldNumber = 3;

		// Token: 0x04004866 RID: 18534
		private static readonly FieldCodec<GachaAccumulateRewardInfo> _repeated_gachaAccumulateRewardInfos_codec = FieldCodec.ForMessage<GachaAccumulateRewardInfo>(26U, GachaAccumulateRewardInfo.Parser);

		// Token: 0x04004867 RID: 18535
		private readonly RepeatedField<GachaAccumulateRewardInfo> gachaAccumulateRewardInfos_ = new RepeatedField<GachaAccumulateRewardInfo>();
	}
}
