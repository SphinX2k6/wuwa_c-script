using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053A RID: 1338
	public sealed class FightFormation : IMessage<FightFormation>, IMessage, IEquatable<FightFormation>, IDeepCloneable<FightFormation>, IBufferMessage
	{
		// Token: 0x06007D55 RID: 32085 RVA: 0x0012FAD0 File Offset: 0x0012DCD0
		[NullableContext(1)]
		public static FightFormation Create()
		{
			return new FightFormation();
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x06007D56 RID: 32086 RVA: 0x0012FAD7 File Offset: 0x0012DCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightFormation> Parser
		{
			get
			{
				return FightFormation._parser;
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06007D57 RID: 32087 RVA: 0x0012FADE File Offset: 0x0012DCDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06007D58 RID: 32088 RVA: 0x0012FAE1 File Offset: 0x0012DCE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightFormation.Descriptor;
			}
		}

		// Token: 0x06007D59 RID: 32089 RVA: 0x0012FAE8 File Offset: 0x0012DCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFormation()
		{
		}

		// Token: 0x06007D5A RID: 32090 RVA: 0x0012FB08 File Offset: 0x0012DD08
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

		// Token: 0x06007D5B RID: 32091 RVA: 0x0012FB6D File Offset: 0x0012DD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFormation Clone()
		{
			return new FightFormation(this);
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06007D5C RID: 32092 RVA: 0x0012FB75 File Offset: 0x0012DD75
		// (set) Token: 0x06007D5D RID: 32093 RVA: 0x0012FB7D File Offset: 0x0012DD7D
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

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06007D5E RID: 32094 RVA: 0x0012FB86 File Offset: 0x0012DD86
		// (set) Token: 0x06007D5F RID: 32095 RVA: 0x0012FB8E File Offset: 0x0012DD8E
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

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06007D60 RID: 32096 RVA: 0x0012FB97 File Offset: 0x0012DD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x06007D61 RID: 32097 RVA: 0x0012FB9F File Offset: 0x0012DD9F
		// (set) Token: 0x06007D62 RID: 32098 RVA: 0x0012FBA7 File Offset: 0x0012DDA7
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

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x06007D63 RID: 32099 RVA: 0x0012FBB0 File Offset: 0x0012DDB0
		// (set) Token: 0x06007D64 RID: 32100 RVA: 0x0012FBB8 File Offset: 0x0012DDB8
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

		// Token: 0x06007D65 RID: 32101 RVA: 0x0012FBCB File Offset: 0x0012DDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightFormation);
		}

		// Token: 0x06007D66 RID: 32102 RVA: 0x0012FBDC File Offset: 0x0012DDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightFormation other)
		{
			return other != null && (other == this || (this.FormationId == other.FormationId && this.CurRole == other.CurRole && this.roleIds_.Equals(other.roleIds_) && this.IsCurrent == other.IsCurrent && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D67 RID: 32103 RVA: 0x0012FC60 File Offset: 0x0012DE60
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

		// Token: 0x06007D68 RID: 32104 RVA: 0x0012FCFA File Offset: 0x0012DEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D69 RID: 32105 RVA: 0x0012FD07 File Offset: 0x0012DF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D6A RID: 32106 RVA: 0x0012FD10 File Offset: 0x0012DF10
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

		// Token: 0x06007D6B RID: 32107 RVA: 0x0012FDB8 File Offset: 0x0012DFB8
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

		// Token: 0x06007D6C RID: 32108 RVA: 0x0012FE4C File Offset: 0x0012E04C
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

		// Token: 0x06007D6D RID: 32109 RVA: 0x0012FEDA File Offset: 0x0012E0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D6E RID: 32110 RVA: 0x0012FEE4 File Offset: 0x0012E0E4
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

		// Token: 0x04003FC5 RID: 16325
		private static readonly MessageParser<FightFormation> _parser = new MessageParser<FightFormation>(() => new FightFormation());

		// Token: 0x04003FC6 RID: 16326
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FC7 RID: 16327
		public const int FormationIdFieldNumber = 1;

		// Token: 0x04003FC8 RID: 16328
		private int formationId_;

		// Token: 0x04003FC9 RID: 16329
		public const int CurRoleFieldNumber = 2;

		// Token: 0x04003FCA RID: 16330
		private int curRole_;

		// Token: 0x04003FCB RID: 16331
		public const int RoleIdsFieldNumber = 3;

		// Token: 0x04003FCC RID: 16332
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04003FCD RID: 16333
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04003FCE RID: 16334
		public const int IsCurrentFieldNumber = 4;

		// Token: 0x04003FCF RID: 16335
		private bool isCurrent_;

		// Token: 0x04003FD0 RID: 16336
		public const int NameFieldNumber = 5;

		// Token: 0x04003FD1 RID: 16337
		private string name_ = "";
	}
}
