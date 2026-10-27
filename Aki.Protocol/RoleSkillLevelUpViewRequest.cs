using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B1 RID: 4273
	[NetMessage(EMessageId.RoleSkillLevelUpViewRequest)]
	public sealed class RoleSkillLevelUpViewRequest : IMessage<RoleSkillLevelUpViewRequest>, IMessage, IEquatable<RoleSkillLevelUpViewRequest>, IDeepCloneable<RoleSkillLevelUpViewRequest>, IBufferMessage
	{
		// Token: 0x06016D03 RID: 93443 RVA: 0x0035068A File Offset: 0x0034E88A
		[NullableContext(1)]
		public static RoleSkillLevelUpViewRequest Create()
		{
			return new RoleSkillLevelUpViewRequest();
		}

		// Token: 0x17004C6E RID: 19566
		// (get) Token: 0x06016D04 RID: 93444 RVA: 0x00350691 File Offset: 0x0034E891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C6F RID: 19567
		// (get) Token: 0x06016D05 RID: 93445 RVA: 0x00350694 File Offset: 0x0034E894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillLevelUpViewRequest.Descriptor;
			}
		}

		// Token: 0x06016D06 RID: 93446 RVA: 0x0035069B File Offset: 0x0034E89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewRequest()
		{
		}

		// Token: 0x06016D07 RID: 93447 RVA: 0x003506A3 File Offset: 0x0034E8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewRequest(RoleSkillLevelUpViewRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D08 RID: 93448 RVA: 0x003506D4 File Offset: 0x0034E8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewRequest Clone()
		{
			return new RoleSkillLevelUpViewRequest(this);
		}

		// Token: 0x17004C70 RID: 19568
		// (get) Token: 0x06016D09 RID: 93449 RVA: 0x003506DC File Offset: 0x0034E8DC
		// (set) Token: 0x06016D0A RID: 93450 RVA: 0x003506E4 File Offset: 0x0034E8E4
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

		// Token: 0x17004C71 RID: 19569
		// (get) Token: 0x06016D0B RID: 93451 RVA: 0x003506ED File Offset: 0x0034E8ED
		// (set) Token: 0x06016D0C RID: 93452 RVA: 0x003506F5 File Offset: 0x0034E8F5
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

		// Token: 0x06016D0D RID: 93453 RVA: 0x003506FE File Offset: 0x0034E8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillLevelUpViewRequest);
		}

		// Token: 0x06016D0E RID: 93454 RVA: 0x0035070C File Offset: 0x0034E90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillLevelUpViewRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D0F RID: 93455 RVA: 0x0035074C File Offset: 0x0034E94C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016D10 RID: 93456 RVA: 0x003507A4 File Offset: 0x0034E9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D11 RID: 93457 RVA: 0x003507B1 File Offset: 0x0034E9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D12 RID: 93458 RVA: 0x003507BC File Offset: 0x0034E9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SkillId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016D13 RID: 93459 RVA: 0x00350818 File Offset: 0x0034EA18
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016D14 RID: 93460 RVA: 0x00350870 File Offset: 0x0034EA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillLevelUpViewRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016D15 RID: 93461 RVA: 0x003508C0 File Offset: 0x0034EAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D16 RID: 93462 RVA: 0x003508CC File Offset: 0x0034EACC
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
				if (num != 64U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008821 RID: 34849
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008822 RID: 34850
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04008823 RID: 34851
		private int roleId_;

		// Token: 0x04008824 RID: 34852
		public const int SkillIdFieldNumber = 8;

		// Token: 0x04008825 RID: 34853
		private int skillId_;
	}
}
