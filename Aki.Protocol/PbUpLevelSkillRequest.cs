using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C04 RID: 3076
	[NetMessage(EMessageId.PbUpLevelSkillRequest)]
	public sealed class PbUpLevelSkillRequest : IMessage<PbUpLevelSkillRequest>, IMessage, IEquatable<PbUpLevelSkillRequest>, IDeepCloneable<PbUpLevelSkillRequest>, IBufferMessage
	{
		// Token: 0x06010B8E RID: 68494 RVA: 0x00273778 File Offset: 0x00271978
		[NullableContext(1)]
		public static PbUpLevelSkillRequest Create()
		{
			return new PbUpLevelSkillRequest();
		}

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x06010B8F RID: 68495 RVA: 0x0027377F File Offset: 0x0027197F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x06010B90 RID: 68496 RVA: 0x00273782 File Offset: 0x00271982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbUpLevelSkillRequest.Descriptor;
			}
		}

		// Token: 0x06010B91 RID: 68497 RVA: 0x00273789 File Offset: 0x00271989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillRequest()
		{
		}

		// Token: 0x06010B92 RID: 68498 RVA: 0x00273791 File Offset: 0x00271991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillRequest(PbUpLevelSkillRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillId_ = other.skillId_;
			this.useBox_ = other.useBox_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B93 RID: 68499 RVA: 0x002737CE File Offset: 0x002719CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillRequest Clone()
		{
			return new PbUpLevelSkillRequest(this);
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x06010B94 RID: 68500 RVA: 0x002737D6 File Offset: 0x002719D6
		// (set) Token: 0x06010B95 RID: 68501 RVA: 0x002737DE File Offset: 0x002719DE
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

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x06010B96 RID: 68502 RVA: 0x002737E7 File Offset: 0x002719E7
		// (set) Token: 0x06010B97 RID: 68503 RVA: 0x002737EF File Offset: 0x002719EF
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

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x06010B98 RID: 68504 RVA: 0x002737F8 File Offset: 0x002719F8
		// (set) Token: 0x06010B99 RID: 68505 RVA: 0x00273800 File Offset: 0x00271A00
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

		// Token: 0x06010B9A RID: 68506 RVA: 0x00273809 File Offset: 0x00271A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbUpLevelSkillRequest);
		}

		// Token: 0x06010B9B RID: 68507 RVA: 0x00273818 File Offset: 0x00271A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbUpLevelSkillRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillId == other.SkillId && this.UseBox == other.UseBox && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B9C RID: 68508 RVA: 0x00273874 File Offset: 0x00271A74
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

		// Token: 0x06010B9D RID: 68509 RVA: 0x002738E5 File Offset: 0x00271AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B9E RID: 68510 RVA: 0x002738F2 File Offset: 0x00271AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B9F RID: 68511 RVA: 0x002738FC File Offset: 0x00271AFC
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
				output.WriteRawTag(96);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010BA0 RID: 68512 RVA: 0x00273974 File Offset: 0x00271B74
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

		// Token: 0x06010BA1 RID: 68513 RVA: 0x002739D8 File Offset: 0x00271BD8
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

		// Token: 0x06010BA2 RID: 68514 RVA: 0x00273A3C File Offset: 0x00271C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010BA3 RID: 68515 RVA: 0x00273A48 File Offset: 0x00271C48
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
						if (num != 96U)
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

		// Token: 0x04006AAF RID: 27311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AB0 RID: 27312
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04006AB1 RID: 27313
		private int roleId_;

		// Token: 0x04006AB2 RID: 27314
		public const int SkillIdFieldNumber = 12;

		// Token: 0x04006AB3 RID: 27315
		private int skillId_;

		// Token: 0x04006AB4 RID: 27316
		public const int UseBoxFieldNumber = 9;

		// Token: 0x04006AB5 RID: 27317
		private bool useBox_;
	}
}
