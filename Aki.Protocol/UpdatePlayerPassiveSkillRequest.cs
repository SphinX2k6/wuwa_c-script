using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001517 RID: 5399
	[NetMessage(EMessageId.UpdatePlayerPassiveSkillRequest)]
	public sealed class UpdatePlayerPassiveSkillRequest : IMessage<UpdatePlayerPassiveSkillRequest>, IMessage, IEquatable<UpdatePlayerPassiveSkillRequest>, IDeepCloneable<UpdatePlayerPassiveSkillRequest>, IBufferMessage
	{
		// Token: 0x0601C9B0 RID: 117168 RVA: 0x0042544C File Offset: 0x0042364C
		[NullableContext(1)]
		public static UpdatePlayerPassiveSkillRequest Create()
		{
			return new UpdatePlayerPassiveSkillRequest();
		}

		// Token: 0x170060C3 RID: 24771
		// (get) Token: 0x0601C9B1 RID: 117169 RVA: 0x00425453 File Offset: 0x00423653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060C4 RID: 24772
		// (get) Token: 0x0601C9B2 RID: 117170 RVA: 0x00425456 File Offset: 0x00423656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayerPassiveSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601C9B3 RID: 117171 RVA: 0x0042545D File Offset: 0x0042365D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillRequest()
		{
		}

		// Token: 0x0601C9B4 RID: 117172 RVA: 0x00425465 File Offset: 0x00423665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillRequest(UpdatePlayerPassiveSkillRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.passiveSkillId_ = other.passiveSkillId_;
			this.cdEndTime_ = other.cdEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C9B5 RID: 117173 RVA: 0x004254A2 File Offset: 0x004236A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillRequest Clone()
		{
			return new UpdatePlayerPassiveSkillRequest(this);
		}

		// Token: 0x170060C5 RID: 24773
		// (get) Token: 0x0601C9B6 RID: 117174 RVA: 0x004254AA File Offset: 0x004236AA
		// (set) Token: 0x0601C9B7 RID: 117175 RVA: 0x004254B2 File Offset: 0x004236B2
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

		// Token: 0x170060C6 RID: 24774
		// (get) Token: 0x0601C9B8 RID: 117176 RVA: 0x004254BB File Offset: 0x004236BB
		// (set) Token: 0x0601C9B9 RID: 117177 RVA: 0x004254C3 File Offset: 0x004236C3
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

		// Token: 0x170060C7 RID: 24775
		// (get) Token: 0x0601C9BA RID: 117178 RVA: 0x004254CC File Offset: 0x004236CC
		// (set) Token: 0x0601C9BB RID: 117179 RVA: 0x004254D4 File Offset: 0x004236D4
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

		// Token: 0x0601C9BC RID: 117180 RVA: 0x004254DD File Offset: 0x004236DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayerPassiveSkillRequest);
		}

		// Token: 0x0601C9BD RID: 117181 RVA: 0x004254EC File Offset: 0x004236EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayerPassiveSkillRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.PassiveSkillId == other.PassiveSkillId && this.CdEndTime == other.CdEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C9BE RID: 117182 RVA: 0x00425548 File Offset: 0x00423748
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

		// Token: 0x0601C9BF RID: 117183 RVA: 0x004255B9 File Offset: 0x004237B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C9C0 RID: 117184 RVA: 0x004255C6 File Offset: 0x004237C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C9C1 RID: 117185 RVA: 0x004255D0 File Offset: 0x004237D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PassiveSkillId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.PassiveSkillId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this.CdEndTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.CdEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C9C2 RID: 117186 RVA: 0x00425644 File Offset: 0x00423844
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

		// Token: 0x0601C9C3 RID: 117187 RVA: 0x004256B4 File Offset: 0x004238B4
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

		// Token: 0x0601C9C4 RID: 117188 RVA: 0x00425718 File Offset: 0x00423918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C9C5 RID: 117189 RVA: 0x00425724 File Offset: 0x00423924
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
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.PassiveSkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A4DA RID: 42202
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4DB RID: 42203
		public const int RoleIdFieldNumber = 2;

		// Token: 0x0400A4DC RID: 42204
		private int roleId_;

		// Token: 0x0400A4DD RID: 42205
		public const int PassiveSkillIdFieldNumber = 1;

		// Token: 0x0400A4DE RID: 42206
		private long passiveSkillId_;

		// Token: 0x0400A4DF RID: 42207
		public const int CdEndTimeFieldNumber = 15;

		// Token: 0x0400A4E0 RID: 42208
		private long cdEndTime_;
	}
}
