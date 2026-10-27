using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C14 RID: 3092
	[NetMessage(EMessageId.PbUpLevelSkillRequest)]
	public sealed class PbUpLevelSkillRequest : IMessage<PbUpLevelSkillRequest>, IMessage, IEquatable<PbUpLevelSkillRequest>, IDeepCloneable<PbUpLevelSkillRequest>, IBufferMessage
	{
		// Token: 0x06010C8E RID: 68750 RVA: 0x002754E4 File Offset: 0x002736E4
		[NullableContext(1)]
		public static PbUpLevelSkillRequest Create()
		{
			return new PbUpLevelSkillRequest();
		}

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x06010C8F RID: 68751 RVA: 0x002754EB File Offset: 0x002736EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x06010C90 RID: 68752 RVA: 0x002754EE File Offset: 0x002736EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbUpLevelSkillRequest.Descriptor;
			}
		}

		// Token: 0x06010C91 RID: 68753 RVA: 0x002754F5 File Offset: 0x002736F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillRequest()
		{
		}

		// Token: 0x06010C92 RID: 68754 RVA: 0x002754FD File Offset: 0x002736FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillRequest(PbUpLevelSkillRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillId_ = other.skillId_;
			this.useBox_ = other.useBox_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C93 RID: 68755 RVA: 0x0027553A File Offset: 0x0027373A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillRequest Clone()
		{
			return new PbUpLevelSkillRequest(this);
		}

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x06010C94 RID: 68756 RVA: 0x00275542 File Offset: 0x00273742
		// (set) Token: 0x06010C95 RID: 68757 RVA: 0x0027554A File Offset: 0x0027374A
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

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x06010C96 RID: 68758 RVA: 0x00275553 File Offset: 0x00273753
		// (set) Token: 0x06010C97 RID: 68759 RVA: 0x0027555B File Offset: 0x0027375B
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

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x06010C98 RID: 68760 RVA: 0x00275564 File Offset: 0x00273764
		// (set) Token: 0x06010C99 RID: 68761 RVA: 0x0027556C File Offset: 0x0027376C
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

		// Token: 0x06010C9A RID: 68762 RVA: 0x00275575 File Offset: 0x00273775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbUpLevelSkillRequest);
		}

		// Token: 0x06010C9B RID: 68763 RVA: 0x00275584 File Offset: 0x00273784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbUpLevelSkillRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillId == other.SkillId && this.UseBox == other.UseBox && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C9C RID: 68764 RVA: 0x002755E0 File Offset: 0x002737E0
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

		// Token: 0x06010C9D RID: 68765 RVA: 0x00275651 File Offset: 0x00273851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C9E RID: 68766 RVA: 0x0027565E File Offset: 0x0027385E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C9F RID: 68767 RVA: 0x00275668 File Offset: 0x00273868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this.UseBox)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.UseBox);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010CA0 RID: 68768 RVA: 0x002756E0 File Offset: 0x002738E0
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

		// Token: 0x06010CA1 RID: 68769 RVA: 0x00275744 File Offset: 0x00273944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbUpLevelSkillRequest other)
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
			if (other.UseBox)
			{
				this.UseBox = other.UseBox;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010CA2 RID: 68770 RVA: 0x002757A8 File Offset: 0x002739A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010CA3 RID: 68771 RVA: 0x002757B4 File Offset: 0x002739B4
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
				if (num != 16U)
				{
					if (num != 72U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SkillId = input.ReadInt32();
						}
					}
					else
					{
						this.UseBox = input.ReadBool();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A9B RID: 27291
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A9C RID: 27292
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04006A9D RID: 27293
		private int roleId_;

		// Token: 0x04006A9E RID: 27294
		public const int SkillIdFieldNumber = 14;

		// Token: 0x04006A9F RID: 27295
		private int skillId_;

		// Token: 0x04006AA0 RID: 27296
		public const int UseBoxFieldNumber = 9;

		// Token: 0x04006AA1 RID: 27297
		private bool useBox_;
	}
}
