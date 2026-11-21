using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F8 RID: 4856
	public sealed class SrvFighterInfo : IMessage<SrvFighterInfo>, IMessage, IEquatable<SrvFighterInfo>, IDeepCloneable<SrvFighterInfo>, IBufferMessage
	{
		// Token: 0x06019E77 RID: 106103 RVA: 0x003C7115 File Offset: 0x003C5315
		[NullableContext(1)]
		public static SrvFighterInfo Create()
		{
			return new SrvFighterInfo();
		}

		// Token: 0x170057B9 RID: 22457
		// (get) Token: 0x06019E78 RID: 106104 RVA: 0x003C711C File Offset: 0x003C531C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057BA RID: 22458
		// (get) Token: 0x06019E79 RID: 106105 RVA: 0x003C711F File Offset: 0x003C531F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SrvFighterInfo.Descriptor;
			}
		}

		// Token: 0x06019E7A RID: 106106 RVA: 0x003C7126 File Offset: 0x003C5326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterInfo()
		{
		}

		// Token: 0x06019E7B RID: 106107 RVA: 0x003C7144 File Offset: 0x003C5344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterInfo(SrvFighterInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.breakthrough_ = other.breakthrough_;
			this.propDataList_ = other.propDataList_.Clone();
			this.srvFighterSkillInfo_ = other.srvFighterSkillInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E7C RID: 106108 RVA: 0x003C71BA File Offset: 0x003C53BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterInfo Clone()
		{
			return new SrvFighterInfo(this);
		}

		// Token: 0x170057BB RID: 22459
		// (get) Token: 0x06019E7D RID: 106109 RVA: 0x003C71C2 File Offset: 0x003C53C2
		// (set) Token: 0x06019E7E RID: 106110 RVA: 0x003C71CA File Offset: 0x003C53CA
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

		// Token: 0x170057BC RID: 22460
		// (get) Token: 0x06019E7F RID: 106111 RVA: 0x003C71D3 File Offset: 0x003C53D3
		// (set) Token: 0x06019E80 RID: 106112 RVA: 0x003C71DB File Offset: 0x003C53DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170057BD RID: 22461
		// (get) Token: 0x06019E81 RID: 106113 RVA: 0x003C71E4 File Offset: 0x003C53E4
		// (set) Token: 0x06019E82 RID: 106114 RVA: 0x003C71EC File Offset: 0x003C53EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x170057BE RID: 22462
		// (get) Token: 0x06019E83 RID: 106115 RVA: 0x003C71F5 File Offset: 0x003C53F5
		// (set) Token: 0x06019E84 RID: 106116 RVA: 0x003C71FD File Offset: 0x003C53FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Breakthrough
		{
			get
			{
				return this.breakthrough_;
			}
			set
			{
				this.breakthrough_ = value;
			}
		}

		// Token: 0x170057BF RID: 22463
		// (get) Token: 0x06019E85 RID: 106117 RVA: 0x003C7206 File Offset: 0x003C5406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PropConfig> PropDataList
		{
			get
			{
				return this.propDataList_;
			}
		}

		// Token: 0x170057C0 RID: 22464
		// (get) Token: 0x06019E86 RID: 106118 RVA: 0x003C720E File Offset: 0x003C540E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SrvFighterSkillInfo> SrvFighterSkillInfo
		{
			get
			{
				return this.srvFighterSkillInfo_;
			}
		}

		// Token: 0x06019E87 RID: 106119 RVA: 0x003C7216 File Offset: 0x003C5416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SrvFighterInfo);
		}

		// Token: 0x06019E88 RID: 106120 RVA: 0x003C7224 File Offset: 0x003C5424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SrvFighterInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Level == other.Level && this.Exp == other.Exp && this.Breakthrough == other.Breakthrough && this.propDataList_.Equals(other.propDataList_) && this.srvFighterSkillInfo_.Equals(other.srvFighterSkillInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E89 RID: 106121 RVA: 0x003C72B8 File Offset: 0x003C54B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.Breakthrough != 0)
			{
				num ^= this.Breakthrough.GetHashCode();
			}
			num ^= this.propDataList_.GetHashCode();
			num ^= this.srvFighterSkillInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019E8A RID: 106122 RVA: 0x003C735E File Offset: 0x003C555E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E8B RID: 106123 RVA: 0x003C736B File Offset: 0x003C556B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E8C RID: 106124 RVA: 0x003C7374 File Offset: 0x003C5574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Exp);
			}
			if (this.Breakthrough != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Breakthrough);
			}
			this.propDataList_.WriteTo(ref output, SrvFighterInfo._repeated_propDataList_codec);
			this.srvFighterSkillInfo_.WriteTo(ref output, SrvFighterInfo._repeated_srvFighterSkillInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E8D RID: 106125 RVA: 0x003C7428 File Offset: 0x003C5628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.Breakthrough != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Breakthrough);
			}
			num += this.propDataList_.CalculateSize(SrvFighterInfo._repeated_propDataList_codec);
			num += this.srvFighterSkillInfo_.CalculateSize(SrvFighterInfo._repeated_srvFighterSkillInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019E8E RID: 106126 RVA: 0x003C74D4 File Offset: 0x003C56D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SrvFighterInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.Breakthrough != 0)
			{
				this.Breakthrough = other.Breakthrough;
			}
			this.propDataList_.Add(other.propDataList_);
			this.srvFighterSkillInfo_.Add(other.srvFighterSkillInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019E8F RID: 106127 RVA: 0x003C756E File Offset: 0x003C576E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E90 RID: 106128 RVA: 0x003C7578 File Offset: 0x003C5778
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
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Breakthrough = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.propDataList_.AddEntriesFrom(ref input, SrvFighterInfo._repeated_propDataList_codec);
						continue;
					}
					if (num == 50U)
					{
						this.srvFighterSkillInfo_.AddEntriesFrom(ref input, SrvFighterInfo._repeated_srvFighterSkillInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040098BB RID: 39099
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098BC RID: 39100
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040098BD RID: 39101
		private int roleId_;

		// Token: 0x040098BE RID: 39102
		public const int LevelFieldNumber = 2;

		// Token: 0x040098BF RID: 39103
		private int level_;

		// Token: 0x040098C0 RID: 39104
		public const int ExpFieldNumber = 3;

		// Token: 0x040098C1 RID: 39105
		private int exp_;

		// Token: 0x040098C2 RID: 39106
		public const int BreakthroughFieldNumber = 4;

		// Token: 0x040098C3 RID: 39107
		private int breakthrough_;

		// Token: 0x040098C4 RID: 39108
		public const int PropDataListFieldNumber = 5;

		// Token: 0x040098C5 RID: 39109
		private static readonly FieldCodec<PropConfig> _repeated_propDataList_codec = FieldCodec.ForMessage<PropConfig>(42U, PropConfig.Parser);

		// Token: 0x040098C6 RID: 39110
		private readonly RepeatedField<PropConfig> propDataList_ = new RepeatedField<PropConfig>();

		// Token: 0x040098C7 RID: 39111
		public const int SrvFighterSkillInfoFieldNumber = 6;

		// Token: 0x040098C8 RID: 39112
		private static readonly FieldCodec<SrvFighterSkillInfo> _repeated_srvFighterSkillInfo_codec = FieldCodec.ForMessage<SrvFighterSkillInfo>(50U, Aki.Protocol.SrvFighterSkillInfo.Parser);

		// Token: 0x040098C9 RID: 39113
		private readonly RepeatedField<SrvFighterSkillInfo> srvFighterSkillInfo_ = new RepeatedField<SrvFighterSkillInfo>();
	}
}
