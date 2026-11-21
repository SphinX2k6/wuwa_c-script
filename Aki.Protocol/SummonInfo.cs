using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131E RID: 4894
	public sealed class SummonInfo : IMessage<SummonInfo>, IMessage, IEquatable<SummonInfo>, IDeepCloneable<SummonInfo>, IBufferMessage
	{
		// Token: 0x0601A174 RID: 106868 RVA: 0x003CD6B4 File Offset: 0x003CB8B4
		[NullableContext(1)]
		public static SummonInfo Create()
		{
			return new SummonInfo();
		}

		// Token: 0x17005855 RID: 22613
		// (get) Token: 0x0601A175 RID: 106869 RVA: 0x003CD6BB File Offset: 0x003CB8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005856 RID: 22614
		// (get) Token: 0x0601A176 RID: 106870 RVA: 0x003CD6BE File Offset: 0x003CB8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonInfo.Descriptor;
			}
		}

		// Token: 0x0601A177 RID: 106871 RVA: 0x003CD6C5 File Offset: 0x003CB8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonInfo()
		{
		}

		// Token: 0x0601A178 RID: 106872 RVA: 0x003CD6CD File Offset: 0x003CB8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonInfo(SummonInfo other) : this()
		{
			this.summonCfgId_ = other.summonCfgId_;
			this.summonerId_ = other.summonerId_;
			this.summonSkillId_ = other.summonSkillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A179 RID: 106873 RVA: 0x003CD70A File Offset: 0x003CB90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonInfo Clone()
		{
			return new SummonInfo(this);
		}

		// Token: 0x17005857 RID: 22615
		// (get) Token: 0x0601A17A RID: 106874 RVA: 0x003CD712 File Offset: 0x003CB912
		// (set) Token: 0x0601A17B RID: 106875 RVA: 0x003CD71A File Offset: 0x003CB91A
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

		// Token: 0x17005858 RID: 22616
		// (get) Token: 0x0601A17C RID: 106876 RVA: 0x003CD723 File Offset: 0x003CB923
		// (set) Token: 0x0601A17D RID: 106877 RVA: 0x003CD72B File Offset: 0x003CB92B
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

		// Token: 0x17005859 RID: 22617
		// (get) Token: 0x0601A17E RID: 106878 RVA: 0x003CD734 File Offset: 0x003CB934
		// (set) Token: 0x0601A17F RID: 106879 RVA: 0x003CD73C File Offset: 0x003CB93C
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

		// Token: 0x0601A180 RID: 106880 RVA: 0x003CD745 File Offset: 0x003CB945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonInfo);
		}

		// Token: 0x0601A181 RID: 106881 RVA: 0x003CD754 File Offset: 0x003CB954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonInfo other)
		{
			return other != null && (other == this || (this.SummonCfgId == other.SummonCfgId && this.SummonerId == other.SummonerId && this.SummonSkillId == other.SummonSkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A182 RID: 106882 RVA: 0x003CD7B0 File Offset: 0x003CB9B0
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

		// Token: 0x0601A183 RID: 106883 RVA: 0x003CD821 File Offset: 0x003CBA21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A184 RID: 106884 RVA: 0x003CD82E File Offset: 0x003CBA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A185 RID: 106885 RVA: 0x003CD838 File Offset: 0x003CBA38
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

		// Token: 0x0601A186 RID: 106886 RVA: 0x003CD8AC File Offset: 0x003CBAAC
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

		// Token: 0x0601A187 RID: 106887 RVA: 0x003CD91C File Offset: 0x003CBB1C
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

		// Token: 0x0601A188 RID: 106888 RVA: 0x003CD980 File Offset: 0x003CBB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A189 RID: 106889 RVA: 0x003CD98C File Offset: 0x003CBB8C
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

		// Token: 0x0400998B RID: 39307
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400998C RID: 39308
		public const int SummonCfgIdFieldNumber = 1;

		// Token: 0x0400998D RID: 39309
		private int summonCfgId_;

		// Token: 0x0400998E RID: 39310
		public const int SummonerIdFieldNumber = 2;

		// Token: 0x0400998F RID: 39311
		private long summonerId_;

		// Token: 0x04009990 RID: 39312
		public const int SummonSkillIdFieldNumber = 3;

		// Token: 0x04009991 RID: 39313
		private int summonSkillId_;
	}
}
