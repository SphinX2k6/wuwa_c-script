using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053B RID: 1339
	public sealed class FightFormationNotifyInfo : IMessage<FightFormationNotifyInfo>, IMessage, IEquatable<FightFormationNotifyInfo>, IDeepCloneable<FightFormationNotifyInfo>, IBufferMessage
	{
		// Token: 0x06007D70 RID: 32112 RVA: 0x0012FFB3 File Offset: 0x0012E1B3
		[NullableContext(1)]
		public static FightFormationNotifyInfo Create()
		{
			return new FightFormationNotifyInfo();
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x06007D71 RID: 32113 RVA: 0x0012FFBA File Offset: 0x0012E1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightFormationNotifyInfo> Parser
		{
			get
			{
				return FightFormationNotifyInfo._parser;
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06007D72 RID: 32114 RVA: 0x0012FFC1 File Offset: 0x0012E1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06007D73 RID: 32115 RVA: 0x0012FFC4 File Offset: 0x0012E1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightFormationNotifyInfo.Descriptor;
			}
		}

		// Token: 0x06007D74 RID: 32116 RVA: 0x0012FFCB File Offset: 0x0012E1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFormationNotifyInfo()
		{
		}

		// Token: 0x06007D75 RID: 32117 RVA: 0x0012FFEC File Offset: 0x0012E1EC
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

		// Token: 0x06007D76 RID: 32118 RVA: 0x00130051 File Offset: 0x0012E251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFormationNotifyInfo Clone()
		{
			return new FightFormationNotifyInfo(this);
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06007D77 RID: 32119 RVA: 0x00130059 File Offset: 0x0012E259
		// (set) Token: 0x06007D78 RID: 32120 RVA: 0x00130061 File Offset: 0x0012E261
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

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06007D79 RID: 32121 RVA: 0x0013006A File Offset: 0x0012E26A
		// (set) Token: 0x06007D7A RID: 32122 RVA: 0x00130072 File Offset: 0x0012E272
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

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06007D7B RID: 32123 RVA: 0x0013007B File Offset: 0x0012E27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationRoleInfo> RoleInfos
		{
			get
			{
				return this.roleInfos_;
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x06007D7C RID: 32124 RVA: 0x00130083 File Offset: 0x0012E283
		// (set) Token: 0x06007D7D RID: 32125 RVA: 0x0013008B File Offset: 0x0012E28B
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

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x06007D7E RID: 32126 RVA: 0x00130094 File Offset: 0x0012E294
		// (set) Token: 0x06007D7F RID: 32127 RVA: 0x0013009C File Offset: 0x0012E29C
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

		// Token: 0x06007D80 RID: 32128 RVA: 0x001300AF File Offset: 0x0012E2AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightFormationNotifyInfo);
		}

		// Token: 0x06007D81 RID: 32129 RVA: 0x001300C0 File Offset: 0x0012E2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightFormationNotifyInfo other)
		{
			return other != null && (other == this || (this.FormationId == other.FormationId && this.CurRole == other.CurRole && this.roleInfos_.Equals(other.roleInfos_) && this.IsCurrent == other.IsCurrent && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D82 RID: 32130 RVA: 0x00130144 File Offset: 0x0012E344
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

		// Token: 0x06007D83 RID: 32131 RVA: 0x001301DE File Offset: 0x0012E3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D84 RID: 32132 RVA: 0x001301EB File Offset: 0x0012E3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D85 RID: 32133 RVA: 0x001301F4 File Offset: 0x0012E3F4
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

		// Token: 0x06007D86 RID: 32134 RVA: 0x0013029C File Offset: 0x0012E49C
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

		// Token: 0x06007D87 RID: 32135 RVA: 0x00130330 File Offset: 0x0012E530
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

		// Token: 0x06007D88 RID: 32136 RVA: 0x001303BE File Offset: 0x0012E5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D89 RID: 32137 RVA: 0x001303C8 File Offset: 0x0012E5C8
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

		// Token: 0x04003FD2 RID: 16338
		private static readonly MessageParser<FightFormationNotifyInfo> _parser = new MessageParser<FightFormationNotifyInfo>(() => new FightFormationNotifyInfo());

		// Token: 0x04003FD3 RID: 16339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FD4 RID: 16340
		public const int FormationIdFieldNumber = 1;

		// Token: 0x04003FD5 RID: 16341
		private int formationId_;

		// Token: 0x04003FD6 RID: 16342
		public const int CurRoleFieldNumber = 2;

		// Token: 0x04003FD7 RID: 16343
		private int curRole_;

		// Token: 0x04003FD8 RID: 16344
		public const int RoleInfosFieldNumber = 3;

		// Token: 0x04003FD9 RID: 16345
		private static readonly FieldCodec<FormationRoleInfo> _repeated_roleInfos_codec = FieldCodec.ForMessage<FormationRoleInfo>(26U, FormationRoleInfo.Parser);

		// Token: 0x04003FDA RID: 16346
		private readonly RepeatedField<FormationRoleInfo> roleInfos_ = new RepeatedField<FormationRoleInfo>();

		// Token: 0x04003FDB RID: 16347
		public const int IsCurrentFieldNumber = 4;

		// Token: 0x04003FDC RID: 16348
		private bool isCurrent_;

		// Token: 0x04003FDD RID: 16349
		public const int NameFieldNumber = 5;

		// Token: 0x04003FDE RID: 16350
		private string name_ = "";
	}
}
