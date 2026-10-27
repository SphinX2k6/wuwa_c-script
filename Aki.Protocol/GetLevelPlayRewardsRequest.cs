using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CD RID: 1741
	[NetMessage(EMessageId.GetLevelPlayRewardsRequest)]
	public sealed class GetLevelPlayRewardsRequest : IMessage<GetLevelPlayRewardsRequest>, IMessage, IEquatable<GetLevelPlayRewardsRequest>, IDeepCloneable<GetLevelPlayRewardsRequest>, IBufferMessage
	{
		// Token: 0x06009F29 RID: 40745 RVA: 0x00181E55 File Offset: 0x00180055
		[NullableContext(1)]
		public static GetLevelPlayRewardsRequest Create()
		{
			return new GetLevelPlayRewardsRequest();
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06009F2A RID: 40746 RVA: 0x00181E5C File Offset: 0x0018005C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x06009F2B RID: 40747 RVA: 0x00181E5F File Offset: 0x0018005F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLevelPlayRewardsRequest.Descriptor;
			}
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x00181E66 File Offset: 0x00180066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsRequest()
		{
		}

		// Token: 0x06009F2D RID: 40749 RVA: 0x00181E6E File Offset: 0x0018006E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsRequest(GetLevelPlayRewardsRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F2E RID: 40750 RVA: 0x00181E9F File Offset: 0x0018009F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelPlayRewardsRequest Clone()
		{
			return new GetLevelPlayRewardsRequest(this);
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06009F2F RID: 40751 RVA: 0x00181EA7 File Offset: 0x001800A7
		// (set) Token: 0x06009F30 RID: 40752 RVA: 0x00181EAF File Offset: 0x001800AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x06009F31 RID: 40753 RVA: 0x00181EB8 File Offset: 0x001800B8
		// (set) Token: 0x06009F32 RID: 40754 RVA: 0x00181EC0 File Offset: 0x001800C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x06009F33 RID: 40755 RVA: 0x00181EC9 File Offset: 0x001800C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLevelPlayRewardsRequest);
		}

		// Token: 0x06009F34 RID: 40756 RVA: 0x00181ED7 File Offset: 0x001800D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLevelPlayRewardsRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x00181F18 File Offset: 0x00180118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x00181F70 File Offset: 0x00180170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x00181F7D File Offset: 0x0018017D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F38 RID: 40760 RVA: 0x00181F88 File Offset: 0x00180188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F39 RID: 40761 RVA: 0x00181FE4 File Offset: 0x001801E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F3A RID: 40762 RVA: 0x0018203C File Offset: 0x0018023C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLevelPlayRewardsRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F3B RID: 40763 RVA: 0x0018208C File Offset: 0x0018028C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F3C RID: 40764 RVA: 0x00182098 File Offset: 0x00180298
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
				if (num != 112U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A5B RID: 19035
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A5C RID: 19036
		public const int InstIdFieldNumber = 15;

		// Token: 0x04004A5D RID: 19037
		private int instId_;

		// Token: 0x04004A5E RID: 19038
		public const int LevelPlayIdFieldNumber = 14;

		// Token: 0x04004A5F RID: 19039
		private int levelPlayId_;
	}
}
