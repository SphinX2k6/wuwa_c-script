using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A1 RID: 5281
	[NetMessage(EMessageId.UpdatePlayerPassiveSkillRequest)]
	public sealed class UpdatePlayerPassiveSkillRequest : IMessage<UpdatePlayerPassiveSkillRequest>, IMessage, IEquatable<UpdatePlayerPassiveSkillRequest>, IDeepCloneable<UpdatePlayerPassiveSkillRequest>, IBufferMessage
	{
		// Token: 0x0601BEE9 RID: 114409 RVA: 0x00409994 File Offset: 0x00407B94
		[NullableContext(1)]
		public static UpdatePlayerPassiveSkillRequest Create()
		{
			return new UpdatePlayerPassiveSkillRequest();
		}

		// Token: 0x17005E22 RID: 24098
		// (get) Token: 0x0601BEEA RID: 114410 RVA: 0x0040999B File Offset: 0x00407B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E23 RID: 24099
		// (get) Token: 0x0601BEEB RID: 114411 RVA: 0x0040999E File Offset: 0x00407B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayerPassiveSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601BEEC RID: 114412 RVA: 0x004099A5 File Offset: 0x00407BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillRequest()
		{
		}

		// Token: 0x0601BEED RID: 114413 RVA: 0x004099AD File Offset: 0x00407BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillRequest(UpdatePlayerPassiveSkillRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.passiveSkillId_ = other.passiveSkillId_;
			this.cdEndTime_ = other.cdEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BEEE RID: 114414 RVA: 0x004099EA File Offset: 0x00407BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillRequest Clone()
		{
			return new UpdatePlayerPassiveSkillRequest(this);
		}

		// Token: 0x17005E24 RID: 24100
		// (get) Token: 0x0601BEEF RID: 114415 RVA: 0x004099F2 File Offset: 0x00407BF2
		// (set) Token: 0x0601BEF0 RID: 114416 RVA: 0x004099FA File Offset: 0x00407BFA
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

		// Token: 0x17005E25 RID: 24101
		// (get) Token: 0x0601BEF1 RID: 114417 RVA: 0x00409A03 File Offset: 0x00407C03
		// (set) Token: 0x0601BEF2 RID: 114418 RVA: 0x00409A0B File Offset: 0x00407C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PassiveSkillId
		{
			get
			{
				return this.passiveSkillId_;
			}
			set
			{
				this.passiveSkillId_ = value;
			}
		}

		// Token: 0x17005E26 RID: 24102
		// (get) Token: 0x0601BEF3 RID: 114419 RVA: 0x00409A14 File Offset: 0x00407C14
		// (set) Token: 0x0601BEF4 RID: 114420 RVA: 0x00409A1C File Offset: 0x00407C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CdEndTime
		{
			get
			{
				return this.cdEndTime_;
			}
			set
			{
				this.cdEndTime_ = value;
			}
		}

		// Token: 0x0601BEF5 RID: 114421 RVA: 0x00409A25 File Offset: 0x00407C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayerPassiveSkillRequest);
		}

		// Token: 0x0601BEF6 RID: 114422 RVA: 0x00409A34 File Offset: 0x00407C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayerPassiveSkillRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.PassiveSkillId == other.PassiveSkillId && this.CdEndTime == other.CdEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BEF7 RID: 114423 RVA: 0x00409A90 File Offset: 0x00407C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.PassiveSkillId != 0L)
			{
				num ^= this.PassiveSkillId.GetHashCode();
			}
			if (this.CdEndTime != 0L)
			{
				num ^= this.CdEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BEF8 RID: 114424 RVA: 0x00409B01 File Offset: 0x00407D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BEF9 RID: 114425 RVA: 0x00409B0E File Offset: 0x00407D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BEFA RID: 114426 RVA: 0x00409B18 File Offset: 0x00407D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.CdEndTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.CdEndTime);
			}
			if (this.PassiveSkillId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.PassiveSkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BEFB RID: 114427 RVA: 0x00409B8C File Offset: 0x00407D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.PassiveSkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PassiveSkillId);
			}
			if (this.CdEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CdEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BEFC RID: 114428 RVA: 0x00409BFC File Offset: 0x00407DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePlayerPassiveSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.PassiveSkillId != 0L)
			{
				this.PassiveSkillId = other.PassiveSkillId;
			}
			if (other.CdEndTime != 0L)
			{
				this.CdEndTime = other.CdEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BEFD RID: 114429 RVA: 0x00409C60 File Offset: 0x00407E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BEFE RID: 114430 RVA: 0x00409C6C File Offset: 0x00407E6C
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
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PassiveSkillId = input.ReadInt64();
						}
					}
					else
					{
						this.CdEndTime = input.ReadInt64();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A081 RID: 41089
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A082 RID: 41090
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400A083 RID: 41091
		private int roleId_;

		// Token: 0x0400A084 RID: 41092
		public const int PassiveSkillIdFieldNumber = 15;

		// Token: 0x0400A085 RID: 41093
		private long passiveSkillId_;

		// Token: 0x0400A086 RID: 41094
		public const int CdEndTimeFieldNumber = 11;

		// Token: 0x0400A087 RID: 41095
		private long cdEndTime_;
	}
}
