using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C4 RID: 5060
	public sealed class TowerRecommendRole : IMessage<TowerRecommendRole>, IMessage, IEquatable<TowerRecommendRole>, IDeepCloneable<TowerRecommendRole>, IBufferMessage
	{
		// Token: 0x0601AD71 RID: 109937 RVA: 0x003E430A File Offset: 0x003E250A
		[NullableContext(1)]
		public static TowerRecommendRole Create()
		{
			return new TowerRecommendRole();
		}

		// Token: 0x17005A85 RID: 23173
		// (get) Token: 0x0601AD72 RID: 109938 RVA: 0x003E4311 File Offset: 0x003E2511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerRecommendRole> Parser
		{
			get
			{
				return TowerRecommendRole._parser;
			}
		}

		// Token: 0x17005A86 RID: 23174
		// (get) Token: 0x0601AD73 RID: 109939 RVA: 0x003E4318 File Offset: 0x003E2518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A87 RID: 23175
		// (get) Token: 0x0601AD74 RID: 109940 RVA: 0x003E431B File Offset: 0x003E251B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRecommendRole.Descriptor;
			}
		}

		// Token: 0x0601AD75 RID: 109941 RVA: 0x003E4322 File Offset: 0x003E2522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendRole()
		{
		}

		// Token: 0x0601AD76 RID: 109942 RVA: 0x003E432C File Offset: 0x003E252C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendRole(TowerRecommendRole other) : this()
		{
			this.roleId_ = other.roleId_;
			this.leaveSkillId_ = other.leaveSkillId_;
			this.level_ = other.level_;
			this.skillBranchId_ = other.skillBranchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD77 RID: 109943 RVA: 0x003E4380 File Offset: 0x003E2580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendRole Clone()
		{
			return new TowerRecommendRole(this);
		}

		// Token: 0x17005A88 RID: 23176
		// (get) Token: 0x0601AD78 RID: 109944 RVA: 0x003E4388 File Offset: 0x003E2588
		// (set) Token: 0x0601AD79 RID: 109945 RVA: 0x003E4390 File Offset: 0x003E2590
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

		// Token: 0x17005A89 RID: 23177
		// (get) Token: 0x0601AD7A RID: 109946 RVA: 0x003E4399 File Offset: 0x003E2599
		// (set) Token: 0x0601AD7B RID: 109947 RVA: 0x003E43A1 File Offset: 0x003E25A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LeaveSkillId
		{
			get
			{
				return this.leaveSkillId_;
			}
			set
			{
				this.leaveSkillId_ = value;
			}
		}

		// Token: 0x17005A8A RID: 23178
		// (get) Token: 0x0601AD7C RID: 109948 RVA: 0x003E43AA File Offset: 0x003E25AA
		// (set) Token: 0x0601AD7D RID: 109949 RVA: 0x003E43B2 File Offset: 0x003E25B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17005A8B RID: 23179
		// (get) Token: 0x0601AD7E RID: 109950 RVA: 0x003E43BB File Offset: 0x003E25BB
		// (set) Token: 0x0601AD7F RID: 109951 RVA: 0x003E43C3 File Offset: 0x003E25C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
			set
			{
				this.skillBranchId_ = value;
			}
		}

		// Token: 0x0601AD80 RID: 109952 RVA: 0x003E43CC File Offset: 0x003E25CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRecommendRole);
		}

		// Token: 0x0601AD81 RID: 109953 RVA: 0x003E43DC File Offset: 0x003E25DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRecommendRole other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.LeaveSkillId == other.LeaveSkillId && this.Level == other.Level && this.SkillBranchId == other.SkillBranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD82 RID: 109954 RVA: 0x003E4448 File Offset: 0x003E2648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.LeaveSkillId != 0)
			{
				num ^= this.LeaveSkillId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.SkillBranchId != 0)
			{
				num ^= this.SkillBranchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AD83 RID: 109955 RVA: 0x003E44D2 File Offset: 0x003E26D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD84 RID: 109956 RVA: 0x003E44DF File Offset: 0x003E26DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD85 RID: 109957 RVA: 0x003E44E8 File Offset: 0x003E26E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.LeaveSkillId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LeaveSkillId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.SkillBranchId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkillBranchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD86 RID: 109958 RVA: 0x003E4578 File Offset: 0x003E2778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.LeaveSkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LeaveSkillId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.SkillBranchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillBranchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AD87 RID: 109959 RVA: 0x003E4600 File Offset: 0x003E2800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerRecommendRole other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.LeaveSkillId != 0)
			{
				this.LeaveSkillId = other.LeaveSkillId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.SkillBranchId != 0)
			{
				this.SkillBranchId = other.SkillBranchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AD88 RID: 109960 RVA: 0x003E4678 File Offset: 0x003E2878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD89 RID: 109961 RVA: 0x003E4684 File Offset: 0x003E2884
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LeaveSkillId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.SkillBranchId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009BC2 RID: 39874
		private static readonly MessageParser<TowerRecommendRole> _parser = new MessageParser<TowerRecommendRole>(() => new TowerRecommendRole());

		// Token: 0x04009BC3 RID: 39875
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BC4 RID: 39876
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04009BC5 RID: 39877
		private int roleId_;

		// Token: 0x04009BC6 RID: 39878
		public const int LeaveSkillIdFieldNumber = 2;

		// Token: 0x04009BC7 RID: 39879
		private int leaveSkillId_;

		// Token: 0x04009BC8 RID: 39880
		public const int LevelFieldNumber = 3;

		// Token: 0x04009BC9 RID: 39881
		private int level_;

		// Token: 0x04009BCA RID: 39882
		public const int SkillBranchIdFieldNumber = 4;

		// Token: 0x04009BCB RID: 39883
		private int skillBranchId_;
	}
}
