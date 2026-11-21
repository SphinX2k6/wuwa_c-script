using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F9 RID: 4857
	public sealed class SrvFighterSkillInfo : IMessage<SrvFighterSkillInfo>, IMessage, IEquatable<SrvFighterSkillInfo>, IDeepCloneable<SrvFighterSkillInfo>, IBufferMessage
	{
		// Token: 0x06019E92 RID: 106130 RVA: 0x003C7656 File Offset: 0x003C5856
		[NullableContext(1)]
		public static SrvFighterSkillInfo Create()
		{
			return new SrvFighterSkillInfo();
		}

		// Token: 0x170057C1 RID: 22465
		// (get) Token: 0x06019E93 RID: 106131 RVA: 0x003C765D File Offset: 0x003C585D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SrvFighterSkillInfo> Parser
		{
			get
			{
				return SrvFighterSkillInfo._parser;
			}
		}

		// Token: 0x170057C2 RID: 22466
		// (get) Token: 0x06019E94 RID: 106132 RVA: 0x003C7664 File Offset: 0x003C5864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057C3 RID: 22467
		// (get) Token: 0x06019E95 RID: 106133 RVA: 0x003C7667 File Offset: 0x003C5867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SrvFighterSkillInfo.Descriptor;
			}
		}

		// Token: 0x06019E96 RID: 106134 RVA: 0x003C766E File Offset: 0x003C586E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterSkillInfo()
		{
		}

		// Token: 0x06019E97 RID: 106135 RVA: 0x003C7676 File Offset: 0x003C5876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterSkillInfo(SrvFighterSkillInfo other) : this()
		{
			this.skillId_ = other.skillId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E98 RID: 106136 RVA: 0x003C76A7 File Offset: 0x003C58A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterSkillInfo Clone()
		{
			return new SrvFighterSkillInfo(this);
		}

		// Token: 0x170057C4 RID: 22468
		// (get) Token: 0x06019E99 RID: 106137 RVA: 0x003C76AF File Offset: 0x003C58AF
		// (set) Token: 0x06019E9A RID: 106138 RVA: 0x003C76B7 File Offset: 0x003C58B7
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

		// Token: 0x170057C5 RID: 22469
		// (get) Token: 0x06019E9B RID: 106139 RVA: 0x003C76C0 File Offset: 0x003C58C0
		// (set) Token: 0x06019E9C RID: 106140 RVA: 0x003C76C8 File Offset: 0x003C58C8
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

		// Token: 0x06019E9D RID: 106141 RVA: 0x003C76D1 File Offset: 0x003C58D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SrvFighterSkillInfo);
		}

		// Token: 0x06019E9E RID: 106142 RVA: 0x003C76DF File Offset: 0x003C58DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SrvFighterSkillInfo other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E9F RID: 106143 RVA: 0x003C7720 File Offset: 0x003C5920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019EA0 RID: 106144 RVA: 0x003C7778 File Offset: 0x003C5978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019EA1 RID: 106145 RVA: 0x003C7785 File Offset: 0x003C5985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019EA2 RID: 106146 RVA: 0x003C7790 File Offset: 0x003C5990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019EA3 RID: 106147 RVA: 0x003C77E8 File Offset: 0x003C59E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019EA4 RID: 106148 RVA: 0x003C7840 File Offset: 0x003C5A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SrvFighterSkillInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019EA5 RID: 106149 RVA: 0x003C7890 File Offset: 0x003C5A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019EA6 RID: 106150 RVA: 0x003C789C File Offset: 0x003C5A9C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040098CA RID: 39114
		private static readonly MessageParser<SrvFighterSkillInfo> _parser = new MessageParser<SrvFighterSkillInfo>(() => new SrvFighterSkillInfo());

		// Token: 0x040098CB RID: 39115
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098CC RID: 39116
		public const int SkillIdFieldNumber = 1;

		// Token: 0x040098CD RID: 39117
		private int skillId_;

		// Token: 0x040098CE RID: 39118
		public const int LevelFieldNumber = 2;

		// Token: 0x040098CF RID: 39119
		private int level_;
	}
}
