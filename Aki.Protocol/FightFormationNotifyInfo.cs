using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000526 RID: 1318
	public sealed class FightFormationNotifyInfo : IMessage<FightFormationNotifyInfo>, IMessage, IEquatable<FightFormationNotifyInfo>, IDeepCloneable<FightFormationNotifyInfo>, IBufferMessage
	{
		// Token: 0x06007C08 RID: 31752 RVA: 0x0012D3AF File Offset: 0x0012B5AF
		[NullableContext(1)]
		public static FightFormationNotifyInfo Create()
		{
			return new FightFormationNotifyInfo();
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06007C09 RID: 31753 RVA: 0x0012D3B6 File Offset: 0x0012B5B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightFormationNotifyInfo> Parser
		{
			get
			{
				return FightFormationNotifyInfo._parser;
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06007C0A RID: 31754 RVA: 0x0012D3BD File Offset: 0x0012B5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06007C0B RID: 31755 RVA: 0x0012D3C0 File Offset: 0x0012B5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightFormationNotifyInfo.Descriptor;
			}
		}

		// Token: 0x06007C0C RID: 31756 RVA: 0x0012D3C7 File Offset: 0x0012B5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFormationNotifyInfo()
		{
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x0012D3E8 File Offset: 0x0012B5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFormationNotifyInfo(FightFormationNotifyInfo other) : this()
		{
			this.formationId_ = other.formationId_;
			this.curRole_ = other.curRole_;
			this.roleInfos_ = other.roleInfos_.Clone();
			this.isCurrent_ = other.isCurrent_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C0E RID: 31758 RVA: 0x0012D44D File Offset: 0x0012B64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFormationNotifyInfo Clone()
		{
			return new FightFormationNotifyInfo(this);
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06007C0F RID: 31759 RVA: 0x0012D455 File Offset: 0x0012B655
		// (set) Token: 0x06007C10 RID: 31760 RVA: 0x0012D45D File Offset: 0x0012B65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FormationId
		{
			get
			{
				return this.formationId_;
			}
			set
			{
				this.formationId_ = value;
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06007C11 RID: 31761 RVA: 0x0012D466 File Offset: 0x0012B666
		// (set) Token: 0x06007C12 RID: 31762 RVA: 0x0012D46E File Offset: 0x0012B66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRole
		{
			get
			{
				return this.curRole_;
			}
			set
			{
				this.curRole_ = value;
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06007C13 RID: 31763 RVA: 0x0012D477 File Offset: 0x0012B677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationRoleInfo> RoleInfos
		{
			get
			{
				return this.roleInfos_;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06007C14 RID: 31764 RVA: 0x0012D47F File Offset: 0x0012B67F
		// (set) Token: 0x06007C15 RID: 31765 RVA: 0x0012D487 File Offset: 0x0012B687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCurrent
		{
			get
			{
				return this.isCurrent_;
			}
			set
			{
				this.isCurrent_ = value;
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06007C16 RID: 31766 RVA: 0x0012D490 File Offset: 0x0012B690
		// (set) Token: 0x06007C17 RID: 31767 RVA: 0x0012D498 File Offset: 0x0012B698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06007C18 RID: 31768 RVA: 0x0012D4AB File Offset: 0x0012B6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightFormationNotifyInfo);
		}

		// Token: 0x06007C19 RID: 31769 RVA: 0x0012D4BC File Offset: 0x0012B6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightFormationNotifyInfo other)
		{
			return other != null && (other == this || (this.FormationId == other.FormationId && this.CurRole == other.CurRole && this.roleInfos_.Equals(other.roleInfos_) && this.IsCurrent == other.IsCurrent && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C1A RID: 31770 RVA: 0x0012D540 File Offset: 0x0012B740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FormationId != 0)
			{
				num ^= this.FormationId.GetHashCode();
			}
			if (this.CurRole != 0)
			{
				num ^= this.CurRole.GetHashCode();
			}
			num ^= this.roleInfos_.GetHashCode();
			if (this.IsCurrent)
			{
				num ^= this.IsCurrent.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C1B RID: 31771 RVA: 0x0012D5DA File Offset: 0x0012B7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x0012D5E7 File Offset: 0x0012B7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x0012D5F0 File Offset: 0x0012B7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FormationId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FormationId);
			}
			if (this.CurRole != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurRole);
			}
			this.roleInfos_.WriteTo(ref output, FightFormationNotifyInfo._repeated_roleInfos_codec);
			if (this.IsCurrent)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsCurrent);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C1E RID: 31774 RVA: 0x0012D698 File Offset: 0x0012B898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FormationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FormationId);
			}
			if (this.CurRole != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRole);
			}
			num += this.roleInfos_.CalculateSize(FightFormationNotifyInfo._repeated_roleInfos_codec);
			if (this.IsCurrent)
			{
				num += 2;
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C1F RID: 31775 RVA: 0x0012D72C File Offset: 0x0012B92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightFormationNotifyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FormationId != 0)
			{
				this.FormationId = other.FormationId;
			}
			if (other.CurRole != 0)
			{
				this.CurRole = other.CurRole;
			}
			this.roleInfos_.Add(other.roleInfos_);
			if (other.IsCurrent)
			{
				this.IsCurrent = other.IsCurrent;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C20 RID: 31776 RVA: 0x0012D7BA File Offset: 0x0012B9BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C21 RID: 31777 RVA: 0x0012D7C4 File Offset: 0x0012B9C4
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
						this.FormationId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurRole = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.roleInfos_.AddEntriesFrom(ref input, FightFormationNotifyInfo._repeated_roleInfos_codec);
						continue;
					}
					if (num == 32U)
					{
						this.IsCurrent = input.ReadBool();
						continue;
					}
					if (num == 42U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003FC8 RID: 16328
		private static readonly MessageParser<FightFormationNotifyInfo> _parser = new MessageParser<FightFormationNotifyInfo>(() => new FightFormationNotifyInfo());

		// Token: 0x04003FC9 RID: 16329
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FCA RID: 16330
		public const int FormationIdFieldNumber = 1;

		// Token: 0x04003FCB RID: 16331
		private int formationId_;

		// Token: 0x04003FCC RID: 16332
		public const int CurRoleFieldNumber = 2;

		// Token: 0x04003FCD RID: 16333
		private int curRole_;

		// Token: 0x04003FCE RID: 16334
		public const int RoleInfosFieldNumber = 3;

		// Token: 0x04003FCF RID: 16335
		private static readonly FieldCodec<FormationRoleInfo> _repeated_roleInfos_codec = FieldCodec.ForMessage<FormationRoleInfo>(26U, FormationRoleInfo.Parser);

		// Token: 0x04003FD0 RID: 16336
		private readonly RepeatedField<FormationRoleInfo> roleInfos_ = new RepeatedField<FormationRoleInfo>();

		// Token: 0x04003FD1 RID: 16337
		public const int IsCurrentFieldNumber = 4;

		// Token: 0x04003FD2 RID: 16338
		private bool isCurrent_;

		// Token: 0x04003FD3 RID: 16339
		public const int NameFieldNumber = 5;

		// Token: 0x04003FD4 RID: 16340
		private string name_ = "";
	}
}
