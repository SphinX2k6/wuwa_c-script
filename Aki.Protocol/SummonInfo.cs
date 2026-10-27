using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AF RID: 4783
	public sealed class SummonInfo : IMessage<SummonInfo>, IMessage, IEquatable<SummonInfo>, IDeepCloneable<SummonInfo>, IBufferMessage
	{
		// Token: 0x0601973E RID: 104254 RVA: 0x003B2F78 File Offset: 0x003B1178
		[NullableContext(1)]
		public static SummonInfo Create()
		{
			return new SummonInfo();
		}

		// Token: 0x170055D4 RID: 21972
		// (get) Token: 0x0601973F RID: 104255 RVA: 0x003B2F7F File Offset: 0x003B117F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055D5 RID: 21973
		// (get) Token: 0x06019740 RID: 104256 RVA: 0x003B2F82 File Offset: 0x003B1182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonInfo.Descriptor;
			}
		}

		// Token: 0x06019741 RID: 104257 RVA: 0x003B2F89 File Offset: 0x003B1189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonInfo()
		{
		}

		// Token: 0x06019742 RID: 104258 RVA: 0x003B2F91 File Offset: 0x003B1191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonInfo(SummonInfo other) : this()
		{
			this.summonCfgId_ = other.summonCfgId_;
			this.summonerId_ = other.summonerId_;
			this.summonSkillId_ = other.summonSkillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019743 RID: 104259 RVA: 0x003B2FCE File Offset: 0x003B11CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonInfo Clone()
		{
			return new SummonInfo(this);
		}

		// Token: 0x170055D6 RID: 21974
		// (get) Token: 0x06019744 RID: 104260 RVA: 0x003B2FD6 File Offset: 0x003B11D6
		// (set) Token: 0x06019745 RID: 104261 RVA: 0x003B2FDE File Offset: 0x003B11DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SummonCfgId
		{
			get
			{
				return this.summonCfgId_;
			}
			set
			{
				this.summonCfgId_ = value;
			}
		}

		// Token: 0x170055D7 RID: 21975
		// (get) Token: 0x06019746 RID: 104262 RVA: 0x003B2FE7 File Offset: 0x003B11E7
		// (set) Token: 0x06019747 RID: 104263 RVA: 0x003B2FEF File Offset: 0x003B11EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonerId
		{
			get
			{
				return this.summonerId_;
			}
			set
			{
				this.summonerId_ = value;
			}
		}

		// Token: 0x170055D8 RID: 21976
		// (get) Token: 0x06019748 RID: 104264 RVA: 0x003B2FF8 File Offset: 0x003B11F8
		// (set) Token: 0x06019749 RID: 104265 RVA: 0x003B3000 File Offset: 0x003B1200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SummonSkillId
		{
			get
			{
				return this.summonSkillId_;
			}
			set
			{
				this.summonSkillId_ = value;
			}
		}

		// Token: 0x0601974A RID: 104266 RVA: 0x003B3009 File Offset: 0x003B1209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonInfo);
		}

		// Token: 0x0601974B RID: 104267 RVA: 0x003B3018 File Offset: 0x003B1218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonInfo other)
		{
			return other != null && (other == this || (this.SummonCfgId == other.SummonCfgId && this.SummonerId == other.SummonerId && this.SummonSkillId == other.SummonSkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601974C RID: 104268 RVA: 0x003B3074 File Offset: 0x003B1274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonCfgId != 0)
			{
				num ^= this.SummonCfgId.GetHashCode();
			}
			if (this.SummonerId != 0L)
			{
				num ^= this.SummonerId.GetHashCode();
			}
			if (this.SummonSkillId != 0)
			{
				num ^= this.SummonSkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601974D RID: 104269 RVA: 0x003B30E5 File Offset: 0x003B12E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601974E RID: 104270 RVA: 0x003B30F2 File Offset: 0x003B12F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601974F RID: 104271 RVA: 0x003B30FC File Offset: 0x003B12FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonCfgId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SummonCfgId);
			}
			if (this.SummonerId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.SummonerId);
			}
			if (this.SummonSkillId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SummonSkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019750 RID: 104272 RVA: 0x003B3170 File Offset: 0x003B1370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonCfgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SummonCfgId);
			}
			if (this.SummonerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonerId);
			}
			if (this.SummonSkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SummonSkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019751 RID: 104273 RVA: 0x003B31E0 File Offset: 0x003B13E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonCfgId != 0)
			{
				this.SummonCfgId = other.SummonCfgId;
			}
			if (other.SummonerId != 0L)
			{
				this.SummonerId = other.SummonerId;
			}
			if (other.SummonSkillId != 0)
			{
				this.SummonSkillId = other.SummonSkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019752 RID: 104274 RVA: 0x003B3244 File Offset: 0x003B1444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019753 RID: 104275 RVA: 0x003B3250 File Offset: 0x003B1450
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SummonSkillId = input.ReadInt32();
						}
					}
					else
					{
						this.SummonerId = input.ReadInt64();
					}
				}
				else
				{
					this.SummonCfgId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009561 RID: 38241
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009562 RID: 38242
		public const int SummonCfgIdFieldNumber = 1;

		// Token: 0x04009563 RID: 38243
		private int summonCfgId_;

		// Token: 0x04009564 RID: 38244
		public const int SummonerIdFieldNumber = 2;

		// Token: 0x04009565 RID: 38245
		private long summonerId_;

		// Token: 0x04009566 RID: 38246
		public const int SummonSkillIdFieldNumber = 3;

		// Token: 0x04009567 RID: 38247
		private int summonSkillId_;
	}
}
