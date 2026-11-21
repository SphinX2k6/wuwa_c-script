using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000525 RID: 1317
	public sealed class FightFormation : IMessage<FightFormation>, IMessage, IEquatable<FightFormation>, IDeepCloneable<FightFormation>, IBufferMessage
	{
		// Token: 0x06007BED RID: 31725 RVA: 0x0012CECC File Offset: 0x0012B0CC
		[NullableContext(1)]
		public static FightFormation Create()
		{
			return new FightFormation();
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06007BEE RID: 31726 RVA: 0x0012CED3 File Offset: 0x0012B0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightFormation> Parser
		{
			get
			{
				return FightFormation._parser;
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06007BEF RID: 31727 RVA: 0x0012CEDA File Offset: 0x0012B0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06007BF0 RID: 31728 RVA: 0x0012CEDD File Offset: 0x0012B0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightFormation.Descriptor;
			}
		}

		// Token: 0x06007BF1 RID: 31729 RVA: 0x0012CEE4 File Offset: 0x0012B0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFormation()
		{
		}

		// Token: 0x06007BF2 RID: 31730 RVA: 0x0012CF04 File Offset: 0x0012B104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFormation(FightFormation other) : this()
		{
			this.formationId_ = other.formationId_;
			this.curRole_ = other.curRole_;
			this.roleIds_ = other.roleIds_.Clone();
			this.isCurrent_ = other.isCurrent_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BF3 RID: 31731 RVA: 0x0012CF69 File Offset: 0x0012B169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFormation Clone()
		{
			return new FightFormation(this);
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06007BF4 RID: 31732 RVA: 0x0012CF71 File Offset: 0x0012B171
		// (set) Token: 0x06007BF5 RID: 31733 RVA: 0x0012CF79 File Offset: 0x0012B179
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

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06007BF6 RID: 31734 RVA: 0x0012CF82 File Offset: 0x0012B182
		// (set) Token: 0x06007BF7 RID: 31735 RVA: 0x0012CF8A File Offset: 0x0012B18A
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

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06007BF8 RID: 31736 RVA: 0x0012CF93 File Offset: 0x0012B193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06007BF9 RID: 31737 RVA: 0x0012CF9B File Offset: 0x0012B19B
		// (set) Token: 0x06007BFA RID: 31738 RVA: 0x0012CFA3 File Offset: 0x0012B1A3
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

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06007BFB RID: 31739 RVA: 0x0012CFAC File Offset: 0x0012B1AC
		// (set) Token: 0x06007BFC RID: 31740 RVA: 0x0012CFB4 File Offset: 0x0012B1B4
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

		// Token: 0x06007BFD RID: 31741 RVA: 0x0012CFC7 File Offset: 0x0012B1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightFormation);
		}

		// Token: 0x06007BFE RID: 31742 RVA: 0x0012CFD8 File Offset: 0x0012B1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightFormation other)
		{
			return other != null && (other == this || (this.FormationId == other.FormationId && this.CurRole == other.CurRole && this.roleIds_.Equals(other.roleIds_) && this.IsCurrent == other.IsCurrent && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BFF RID: 31743 RVA: 0x0012D05C File Offset: 0x0012B25C
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
			num ^= this.roleIds_.GetHashCode();
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

		// Token: 0x06007C00 RID: 31744 RVA: 0x0012D0F6 File Offset: 0x0012B2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C01 RID: 31745 RVA: 0x0012D103 File Offset: 0x0012B303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C02 RID: 31746 RVA: 0x0012D10C File Offset: 0x0012B30C
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
			this.roleIds_.WriteTo(ref output, FightFormation._repeated_roleIds_codec);
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

		// Token: 0x06007C03 RID: 31747 RVA: 0x0012D1B4 File Offset: 0x0012B3B4
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
			num += this.roleIds_.CalculateSize(FightFormation._repeated_roleIds_codec);
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

		// Token: 0x06007C04 RID: 31748 RVA: 0x0012D248 File Offset: 0x0012B448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightFormation other)
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
			this.roleIds_.Add(other.roleIds_);
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

		// Token: 0x06007C05 RID: 31749 RVA: 0x0012D2D6 File Offset: 0x0012B4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C06 RID: 31750 RVA: 0x0012D2E0 File Offset: 0x0012B4E0
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
				if (num <= 24U)
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
					if (num == 24U)
					{
						goto IL_60;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_60;
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
				continue;
				IL_60:
				this.roleIds_.AddEntriesFrom(ref input, FightFormation._repeated_roleIds_codec);
			}
		}

		// Token: 0x04003FBB RID: 16315
		private static readonly MessageParser<FightFormation> _parser = new MessageParser<FightFormation>(() => new FightFormation());

		// Token: 0x04003FBC RID: 16316
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FBD RID: 16317
		public const int FormationIdFieldNumber = 1;

		// Token: 0x04003FBE RID: 16318
		private int formationId_;

		// Token: 0x04003FBF RID: 16319
		public const int CurRoleFieldNumber = 2;

		// Token: 0x04003FC0 RID: 16320
		private int curRole_;

		// Token: 0x04003FC1 RID: 16321
		public const int RoleIdsFieldNumber = 3;

		// Token: 0x04003FC2 RID: 16322
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04003FC3 RID: 16323
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04003FC4 RID: 16324
		public const int IsCurrentFieldNumber = 4;

		// Token: 0x04003FC5 RID: 16325
		private bool isCurrent_;

		// Token: 0x04003FC6 RID: 16326
		public const int NameFieldNumber = 5;

		// Token: 0x04003FC7 RID: 16327
		private string name_ = "";
	}
}
