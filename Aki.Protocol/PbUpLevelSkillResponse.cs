using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C15 RID: 3093
	[NetMessage(EMessageId.PbUpLevelSkillResponse)]
	public sealed class PbUpLevelSkillResponse : IMessage<PbUpLevelSkillResponse>, IMessage, IEquatable<PbUpLevelSkillResponse>, IDeepCloneable<PbUpLevelSkillResponse>, IBufferMessage
	{
		// Token: 0x06010CA4 RID: 68772 RVA: 0x0027581F File Offset: 0x00273A1F
		[NullableContext(1)]
		public static PbUpLevelSkillResponse Create()
		{
			return new PbUpLevelSkillResponse();
		}

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x06010CA5 RID: 68773 RVA: 0x00275826 File Offset: 0x00273A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x06010CA6 RID: 68774 RVA: 0x00275829 File Offset: 0x00273A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbUpLevelSkillResponse.Descriptor;
			}
		}

		// Token: 0x06010CA7 RID: 68775 RVA: 0x00275830 File Offset: 0x00273A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillResponse()
		{
		}

		// Token: 0x06010CA8 RID: 68776 RVA: 0x00275838 File Offset: 0x00273A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillResponse(PbUpLevelSkillResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.skillInfo_ = ((other.skillInfo_ != null) ? other.skillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010CA9 RID: 68777 RVA: 0x00275890 File Offset: 0x00273A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillResponse Clone()
		{
			return new PbUpLevelSkillResponse(this);
		}

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x06010CAA RID: 68778 RVA: 0x00275898 File Offset: 0x00273A98
		// (set) Token: 0x06010CAB RID: 68779 RVA: 0x002758A0 File Offset: 0x00273AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x06010CAC RID: 68780 RVA: 0x002758A9 File Offset: 0x00273AA9
		// (set) Token: 0x06010CAD RID: 68781 RVA: 0x002758B1 File Offset: 0x00273AB1
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

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x06010CAE RID: 68782 RVA: 0x002758BA File Offset: 0x00273ABA
		// (set) Token: 0x06010CAF RID: 68783 RVA: 0x002758C2 File Offset: 0x00273AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntInt SkillInfo
		{
			get
			{
				return this.skillInfo_;
			}
			set
			{
				this.skillInfo_ = value;
			}
		}

		// Token: 0x06010CB0 RID: 68784 RVA: 0x002758CB File Offset: 0x00273ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbUpLevelSkillResponse);
		}

		// Token: 0x06010CB1 RID: 68785 RVA: 0x002758DC File Offset: 0x00273ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbUpLevelSkillResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && object.Equals(this.SkillInfo, other.SkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010CB2 RID: 68786 RVA: 0x0027593C File Offset: 0x00273B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.skillInfo_ != null)
			{
				num ^= this.SkillInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010CB3 RID: 68787 RVA: 0x002759B0 File Offset: 0x00273BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010CB4 RID: 68788 RVA: 0x002759BD File Offset: 0x00273BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010CB5 RID: 68789 RVA: 0x002759C8 File Offset: 0x00273BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			if (this.skillInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010CB6 RID: 68790 RVA: 0x00275A3C File Offset: 0x00273C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.skillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010CB7 RID: 68791 RVA: 0x00275AAC File Offset: 0x00273CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbUpLevelSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.skillInfo_ != null)
			{
				if (this.skillInfo_ == null)
				{
					this.SkillInfo = new ArrayIntInt();
				}
				this.SkillInfo.MergeFrom(other.SkillInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010CB8 RID: 68792 RVA: 0x00275B28 File Offset: 0x00273D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010CB9 RID: 68793 RVA: 0x00275B34 File Offset: 0x00273D34
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.skillInfo_ == null)
							{
								this.SkillInfo = new ArrayIntInt();
							}
							input.ReadMessage(this.SkillInfo);
						}
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006AA2 RID: 27298
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AA3 RID: 27299
		public const int CodeFieldNumber = 2;

		// Token: 0x04006AA4 RID: 27300
		private ErrorCode code_;

		// Token: 0x04006AA5 RID: 27301
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04006AA6 RID: 27302
		private int roleId_;

		// Token: 0x04006AA7 RID: 27303
		public const int SkillInfoFieldNumber = 3;

		// Token: 0x04006AA8 RID: 27304
		private ArrayIntInt skillInfo_;
	}
}
