using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105F RID: 4191
	public sealed class RoleConfigInfo : IMessage<RoleConfigInfo>, IMessage, IEquatable<RoleConfigInfo>, IDeepCloneable<RoleConfigInfo>, IBufferMessage
	{
		// Token: 0x06016648 RID: 91720 RVA: 0x0034105C File Offset: 0x0033F25C
		[NullableContext(1)]
		public static RoleConfigInfo Create()
		{
			return new RoleConfigInfo();
		}

		// Token: 0x17004AEA RID: 19178
		// (get) Token: 0x06016649 RID: 91721 RVA: 0x00341063 File Offset: 0x0033F263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleConfigInfo> Parser
		{
			get
			{
				return RoleConfigInfo._parser;
			}
		}

		// Token: 0x17004AEB RID: 19179
		// (get) Token: 0x0601664A RID: 91722 RVA: 0x0034106A File Offset: 0x0033F26A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AEC RID: 19180
		// (get) Token: 0x0601664B RID: 91723 RVA: 0x0034106D File Offset: 0x0033F26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleConfigInfo.Descriptor;
			}
		}

		// Token: 0x0601664C RID: 91724 RVA: 0x00341074 File Offset: 0x0033F274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfo()
		{
		}

		// Token: 0x0601664D RID: 91725 RVA: 0x0034107C File Offset: 0x0033F27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfo(RoleConfigInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillBranch_ = other.skillBranch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601664E RID: 91726 RVA: 0x003410AD File Offset: 0x0033F2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfo Clone()
		{
			return new RoleConfigInfo(this);
		}

		// Token: 0x17004AED RID: 19181
		// (get) Token: 0x0601664F RID: 91727 RVA: 0x003410B5 File Offset: 0x0033F2B5
		// (set) Token: 0x06016650 RID: 91728 RVA: 0x003410BD File Offset: 0x0033F2BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004AEE RID: 19182
		// (get) Token: 0x06016651 RID: 91729 RVA: 0x003410C6 File Offset: 0x0033F2C6
		// (set) Token: 0x06016652 RID: 91730 RVA: 0x003410CE File Offset: 0x0033F2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillBranch
		{
			get
			{
				return this.skillBranch_;
			}
			set
			{
				this.skillBranch_ = value;
			}
		}

		// Token: 0x06016653 RID: 91731 RVA: 0x003410D7 File Offset: 0x0033F2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleConfigInfo);
		}

		// Token: 0x06016654 RID: 91732 RVA: 0x003410E5 File Offset: 0x0033F2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleConfigInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillBranch == other.SkillBranch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016655 RID: 91733 RVA: 0x00341124 File Offset: 0x0033F324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkillBranch != 0)
			{
				num ^= this.SkillBranch.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016656 RID: 91734 RVA: 0x0034117C File Offset: 0x0033F37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016657 RID: 91735 RVA: 0x00341189 File Offset: 0x0033F389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016658 RID: 91736 RVA: 0x00341194 File Offset: 0x0033F394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkillBranch != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillBranch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016659 RID: 91737 RVA: 0x003411EC File Offset: 0x0033F3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkillBranch != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillBranch);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601665A RID: 91738 RVA: 0x00341244 File Offset: 0x0033F444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleConfigInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkillBranch != 0)
			{
				this.SkillBranch = other.SkillBranch;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601665B RID: 91739 RVA: 0x00341294 File Offset: 0x0033F494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601665C RID: 91740 RVA: 0x003412A0 File Offset: 0x0033F4A0
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillBranch = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040085E7 RID: 34279
		private static readonly MessageParser<RoleConfigInfo> _parser = new MessageParser<RoleConfigInfo>(() => new RoleConfigInfo());

		// Token: 0x040085E8 RID: 34280
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085E9 RID: 34281
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040085EA RID: 34282
		private int roleId_;

		// Token: 0x040085EB RID: 34283
		public const int SkillBranchFieldNumber = 2;

		// Token: 0x040085EC RID: 34284
		private int skillBranch_;
	}
}
