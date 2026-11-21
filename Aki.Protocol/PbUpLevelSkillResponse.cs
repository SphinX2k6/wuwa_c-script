using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C05 RID: 3077
	[NetMessage(EMessageId.PbUpLevelSkillResponse)]
	public sealed class PbUpLevelSkillResponse : IMessage<PbUpLevelSkillResponse>, IMessage, IEquatable<PbUpLevelSkillResponse>, IDeepCloneable<PbUpLevelSkillResponse>, IBufferMessage
	{
		// Token: 0x06010BA4 RID: 68516 RVA: 0x00273AB3 File Offset: 0x00271CB3
		[NullableContext(1)]
		public static PbUpLevelSkillResponse Create()
		{
			return new PbUpLevelSkillResponse();
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x06010BA5 RID: 68517 RVA: 0x00273ABA File Offset: 0x00271CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x06010BA6 RID: 68518 RVA: 0x00273ABD File Offset: 0x00271CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbUpLevelSkillResponse.Descriptor;
			}
		}

		// Token: 0x06010BA7 RID: 68519 RVA: 0x00273AC4 File Offset: 0x00271CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillResponse()
		{
		}

		// Token: 0x06010BA8 RID: 68520 RVA: 0x00273ACC File Offset: 0x00271CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillResponse(PbUpLevelSkillResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.skillInfo_ = ((other.skillInfo_ != null) ? other.skillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010BA9 RID: 68521 RVA: 0x00273B24 File Offset: 0x00271D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelSkillResponse Clone()
		{
			return new PbUpLevelSkillResponse(this);
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x06010BAA RID: 68522 RVA: 0x00273B2C File Offset: 0x00271D2C
		// (set) Token: 0x06010BAB RID: 68523 RVA: 0x00273B34 File Offset: 0x00271D34
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

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x06010BAC RID: 68524 RVA: 0x00273B3D File Offset: 0x00271D3D
		// (set) Token: 0x06010BAD RID: 68525 RVA: 0x00273B45 File Offset: 0x00271D45
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

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x06010BAE RID: 68526 RVA: 0x00273B4E File Offset: 0x00271D4E
		// (set) Token: 0x06010BAF RID: 68527 RVA: 0x00273B56 File Offset: 0x00271D56
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

		// Token: 0x06010BB0 RID: 68528 RVA: 0x00273B5F File Offset: 0x00271D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbUpLevelSkillResponse);
		}

		// Token: 0x06010BB1 RID: 68529 RVA: 0x00273B70 File Offset: 0x00271D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbUpLevelSkillResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && object.Equals(this.SkillInfo, other.SkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010BB2 RID: 68530 RVA: 0x00273BD0 File Offset: 0x00271DD0
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

		// Token: 0x06010BB3 RID: 68531 RVA: 0x00273C44 File Offset: 0x00271E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010BB4 RID: 68532 RVA: 0x00273C51 File Offset: 0x00271E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010BB5 RID: 68533 RVA: 0x00273C5C File Offset: 0x00271E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.skillInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SkillInfo);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010BB6 RID: 68534 RVA: 0x00273CD4 File Offset: 0x00271ED4
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

		// Token: 0x06010BB7 RID: 68535 RVA: 0x00273D44 File Offset: 0x00271F44
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

		// Token: 0x06010BB8 RID: 68536 RVA: 0x00273DC0 File Offset: 0x00271FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010BB9 RID: 68537 RVA: 0x00273DCC File Offset: 0x00271FCC
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
				if (num != 10U)
				{
					if (num != 56U)
					{
						if (num != 80U)
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
						this.Code = (ErrorCode)input.ReadEnum();
					}
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
		}

		// Token: 0x04006AB6 RID: 27318
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AB7 RID: 27319
		public const int CodeFieldNumber = 7;

		// Token: 0x04006AB8 RID: 27320
		private ErrorCode code_;

		// Token: 0x04006AB9 RID: 27321
		public const int RoleIdFieldNumber = 10;

		// Token: 0x04006ABA RID: 27322
		private int roleId_;

		// Token: 0x04006ABB RID: 27323
		public const int SkillInfoFieldNumber = 1;

		// Token: 0x04006ABC RID: 27324
		private ArrayIntInt skillInfo_;
	}
}
