using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B4 RID: 4276
	[NetMessage(EMessageId.RoleSkillQuickLevelUpRequest)]
	public sealed class RoleSkillQuickLevelUpRequest : IMessage<RoleSkillQuickLevelUpRequest>, IMessage, IEquatable<RoleSkillQuickLevelUpRequest>, IDeepCloneable<RoleSkillQuickLevelUpRequest>, IBufferMessage
	{
		// Token: 0x06016D40 RID: 93504 RVA: 0x00350F2C File Offset: 0x0034F12C
		[NullableContext(1)]
		public static RoleSkillQuickLevelUpRequest Create()
		{
			return new RoleSkillQuickLevelUpRequest();
		}

		// Token: 0x17004C7B RID: 19579
		// (get) Token: 0x06016D41 RID: 93505 RVA: 0x00350F33 File Offset: 0x0034F133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C7C RID: 19580
		// (get) Token: 0x06016D42 RID: 93506 RVA: 0x00350F36 File Offset: 0x0034F136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillQuickLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x06016D43 RID: 93507 RVA: 0x00350F3D File Offset: 0x0034F13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillQuickLevelUpRequest()
		{
		}

		// Token: 0x06016D44 RID: 93508 RVA: 0x00350F48 File Offset: 0x0034F148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillQuickLevelUpRequest(RoleSkillQuickLevelUpRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillId_ = other.skillId_;
			this.targetLevel_ = other.targetLevel_;
			this.useBox_ = other.useBox_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D45 RID: 93509 RVA: 0x00350F9C File Offset: 0x0034F19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillQuickLevelUpRequest Clone()
		{
			return new RoleSkillQuickLevelUpRequest(this);
		}

		// Token: 0x17004C7D RID: 19581
		// (get) Token: 0x06016D46 RID: 93510 RVA: 0x00350FA4 File Offset: 0x0034F1A4
		// (set) Token: 0x06016D47 RID: 93511 RVA: 0x00350FAC File Offset: 0x0034F1AC
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

		// Token: 0x17004C7E RID: 19582
		// (get) Token: 0x06016D48 RID: 93512 RVA: 0x00350FB5 File Offset: 0x0034F1B5
		// (set) Token: 0x06016D49 RID: 93513 RVA: 0x00350FBD File Offset: 0x0034F1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17004C7F RID: 19583
		// (get) Token: 0x06016D4A RID: 93514 RVA: 0x00350FC6 File Offset: 0x0034F1C6
		// (set) Token: 0x06016D4B RID: 93515 RVA: 0x00350FCE File Offset: 0x0034F1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetLevel
		{
			get
			{
				return this.targetLevel_;
			}
			set
			{
				this.targetLevel_ = value;
			}
		}

		// Token: 0x17004C80 RID: 19584
		// (get) Token: 0x06016D4C RID: 93516 RVA: 0x00350FD7 File Offset: 0x0034F1D7
		// (set) Token: 0x06016D4D RID: 93517 RVA: 0x00350FDF File Offset: 0x0034F1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UseBox
		{
			get
			{
				return this.useBox_;
			}
			set
			{
				this.useBox_ = value;
			}
		}

		// Token: 0x06016D4E RID: 93518 RVA: 0x00350FE8 File Offset: 0x0034F1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillQuickLevelUpRequest);
		}

		// Token: 0x06016D4F RID: 93519 RVA: 0x00350FF8 File Offset: 0x0034F1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillQuickLevelUpRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillId == other.SkillId && this.TargetLevel == other.TargetLevel && this.UseBox == other.UseBox && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D50 RID: 93520 RVA: 0x00351064 File Offset: 0x0034F264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.TargetLevel != 0)
			{
				num ^= this.TargetLevel.GetHashCode();
			}
			if (this.UseBox)
			{
				num ^= this.UseBox.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016D51 RID: 93521 RVA: 0x003510EE File Offset: 0x0034F2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D52 RID: 93522 RVA: 0x003510FB File Offset: 0x0034F2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D53 RID: 93523 RVA: 0x00351104 File Offset: 0x0034F304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetLevel);
			}
			if (this.UseBox)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.UseBox);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SkillId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016D54 RID: 93524 RVA: 0x00351194 File Offset: 0x0034F394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.TargetLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetLevel);
			}
			if (this.UseBox)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016D55 RID: 93525 RVA: 0x00351210 File Offset: 0x0034F410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillQuickLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.TargetLevel != 0)
			{
				this.TargetLevel = other.TargetLevel;
			}
			if (other.UseBox)
			{
				this.UseBox = other.UseBox;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016D56 RID: 93526 RVA: 0x00351288 File Offset: 0x0034F488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D57 RID: 93527 RVA: 0x00351294 File Offset: 0x0034F494
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
						this.TargetLevel = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.UseBox = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008835 RID: 34869
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008836 RID: 34870
		public const int RoleIdFieldNumber = 15;

		// Token: 0x04008837 RID: 34871
		private int roleId_;

		// Token: 0x04008838 RID: 34872
		public const int SkillIdFieldNumber = 9;

		// Token: 0x04008839 RID: 34873
		private int skillId_;

		// Token: 0x0400883A RID: 34874
		public const int TargetLevelFieldNumber = 1;

		// Token: 0x0400883B RID: 34875
		private int targetLevel_;

		// Token: 0x0400883C RID: 34876
		public const int UseBoxFieldNumber = 2;

		// Token: 0x0400883D RID: 34877
		private bool useBox_;
	}
}
