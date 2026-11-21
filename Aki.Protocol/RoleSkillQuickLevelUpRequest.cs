using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A4 RID: 4260
	[NetMessage(EMessageId.RoleSkillQuickLevelUpRequest)]
	public sealed class RoleSkillQuickLevelUpRequest : IMessage<RoleSkillQuickLevelUpRequest>, IMessage, IEquatable<RoleSkillQuickLevelUpRequest>, IDeepCloneable<RoleSkillQuickLevelUpRequest>, IBufferMessage
	{
		// Token: 0x06016C5B RID: 93275 RVA: 0x0034F850 File Offset: 0x0034DA50
		[NullableContext(1)]
		public static RoleSkillQuickLevelUpRequest Create()
		{
			return new RoleSkillQuickLevelUpRequest();
		}

		// Token: 0x17004C51 RID: 19537
		// (get) Token: 0x06016C5C RID: 93276 RVA: 0x0034F857 File Offset: 0x0034DA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C52 RID: 19538
		// (get) Token: 0x06016C5D RID: 93277 RVA: 0x0034F85A File Offset: 0x0034DA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillQuickLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x06016C5E RID: 93278 RVA: 0x0034F861 File Offset: 0x0034DA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillQuickLevelUpRequest()
		{
		}

		// Token: 0x06016C5F RID: 93279 RVA: 0x0034F86C File Offset: 0x0034DA6C
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

		// Token: 0x06016C60 RID: 93280 RVA: 0x0034F8C0 File Offset: 0x0034DAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillQuickLevelUpRequest Clone()
		{
			return new RoleSkillQuickLevelUpRequest(this);
		}

		// Token: 0x17004C53 RID: 19539
		// (get) Token: 0x06016C61 RID: 93281 RVA: 0x0034F8C8 File Offset: 0x0034DAC8
		// (set) Token: 0x06016C62 RID: 93282 RVA: 0x0034F8D0 File Offset: 0x0034DAD0
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

		// Token: 0x17004C54 RID: 19540
		// (get) Token: 0x06016C63 RID: 93283 RVA: 0x0034F8D9 File Offset: 0x0034DAD9
		// (set) Token: 0x06016C64 RID: 93284 RVA: 0x0034F8E1 File Offset: 0x0034DAE1
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

		// Token: 0x17004C55 RID: 19541
		// (get) Token: 0x06016C65 RID: 93285 RVA: 0x0034F8EA File Offset: 0x0034DAEA
		// (set) Token: 0x06016C66 RID: 93286 RVA: 0x0034F8F2 File Offset: 0x0034DAF2
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

		// Token: 0x17004C56 RID: 19542
		// (get) Token: 0x06016C67 RID: 93287 RVA: 0x0034F8FB File Offset: 0x0034DAFB
		// (set) Token: 0x06016C68 RID: 93288 RVA: 0x0034F903 File Offset: 0x0034DB03
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

		// Token: 0x06016C69 RID: 93289 RVA: 0x0034F90C File Offset: 0x0034DB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillQuickLevelUpRequest);
		}

		// Token: 0x06016C6A RID: 93290 RVA: 0x0034F91C File Offset: 0x0034DB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillQuickLevelUpRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillId == other.SkillId && this.TargetLevel == other.TargetLevel && this.UseBox == other.UseBox && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C6B RID: 93291 RVA: 0x0034F988 File Offset: 0x0034DB88
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

		// Token: 0x06016C6C RID: 93292 RVA: 0x0034FA12 File Offset: 0x0034DC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C6D RID: 93293 RVA: 0x0034FA1F File Offset: 0x0034DC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C6E RID: 93294 RVA: 0x0034FA28 File Offset: 0x0034DC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillId);
			}
			if (this.UseBox)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.UseBox);
			}
			if (this.TargetLevel != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TargetLevel);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C6F RID: 93295 RVA: 0x0034FAB8 File Offset: 0x0034DCB8
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

		// Token: 0x06016C70 RID: 93296 RVA: 0x0034FB34 File Offset: 0x0034DD34
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

		// Token: 0x06016C71 RID: 93297 RVA: 0x0034FBAC File Offset: 0x0034DDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C72 RID: 93298 RVA: 0x0034FBB8 File Offset: 0x0034DDB8
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.UseBox = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.TargetLevel = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400885F RID: 34911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008860 RID: 34912
		public const int RoleIdFieldNumber = 11;

		// Token: 0x04008861 RID: 34913
		private int roleId_;

		// Token: 0x04008862 RID: 34914
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04008863 RID: 34915
		private int skillId_;

		// Token: 0x04008864 RID: 34916
		public const int TargetLevelFieldNumber = 7;

		// Token: 0x04008865 RID: 34917
		private int targetLevel_;

		// Token: 0x04008866 RID: 34918
		public const int UseBoxFieldNumber = 5;

		// Token: 0x04008867 RID: 34919
		private bool useBox_;
	}
}
