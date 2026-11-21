using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139F RID: 5023
	public sealed class TeamRecommendInfo : IMessage<TeamRecommendInfo>, IMessage, IEquatable<TeamRecommendInfo>, IDeepCloneable<TeamRecommendInfo>, IBufferMessage
	{
		// Token: 0x0601ABC9 RID: 109513 RVA: 0x003E4EE0 File Offset: 0x003E30E0
		[NullableContext(1)]
		public static TeamRecommendInfo Create()
		{
			return new TeamRecommendInfo();
		}

		// Token: 0x17005A86 RID: 23174
		// (get) Token: 0x0601ABCA RID: 109514 RVA: 0x003E4EE7 File Offset: 0x003E30E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeamRecommendInfo> Parser
		{
			get
			{
				return TeamRecommendInfo._parser;
			}
		}

		// Token: 0x17005A87 RID: 23175
		// (get) Token: 0x0601ABCB RID: 109515 RVA: 0x003E4EEE File Offset: 0x003E30EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A88 RID: 23176
		// (get) Token: 0x0601ABCC RID: 109516 RVA: 0x003E4EF1 File Offset: 0x003E30F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamRecommendInfo.Descriptor;
			}
		}

		// Token: 0x0601ABCD RID: 109517 RVA: 0x003E4EF8 File Offset: 0x003E30F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendInfo()
		{
		}

		// Token: 0x0601ABCE RID: 109518 RVA: 0x003E4F0B File Offset: 0x003E310B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendInfo(TeamRecommendInfo other) : this()
		{
			this.skillBranchId_ = other.skillBranchId_;
			this.teammates_ = other.teammates_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ABCF RID: 109519 RVA: 0x003E4F41 File Offset: 0x003E3141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendInfo Clone()
		{
			return new TeamRecommendInfo(this);
		}

		// Token: 0x17005A89 RID: 23177
		// (get) Token: 0x0601ABD0 RID: 109520 RVA: 0x003E4F49 File Offset: 0x003E3149
		// (set) Token: 0x0601ABD1 RID: 109521 RVA: 0x003E4F51 File Offset: 0x003E3151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
			set
			{
				this.skillBranchId_ = value;
			}
		}

		// Token: 0x17005A8A RID: 23178
		// (get) Token: 0x0601ABD2 RID: 109522 RVA: 0x003E4F5A File Offset: 0x003E315A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TeamRecommendTeammate> Teammates
		{
			get
			{
				return this.teammates_;
			}
		}

		// Token: 0x0601ABD3 RID: 109523 RVA: 0x003E4F62 File Offset: 0x003E3162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamRecommendInfo);
		}

		// Token: 0x0601ABD4 RID: 109524 RVA: 0x003E4F70 File Offset: 0x003E3170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamRecommendInfo other)
		{
			return other != null && (other == this || (this.SkillBranchId == other.SkillBranchId && this.teammates_.Equals(other.teammates_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ABD5 RID: 109525 RVA: 0x003E4FC0 File Offset: 0x003E31C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillBranchId != 0)
			{
				num ^= this.SkillBranchId.GetHashCode();
			}
			num ^= this.teammates_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ABD6 RID: 109526 RVA: 0x003E500D File Offset: 0x003E320D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ABD7 RID: 109527 RVA: 0x003E501A File Offset: 0x003E321A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ABD8 RID: 109528 RVA: 0x003E5024 File Offset: 0x003E3224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillBranchId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillBranchId);
			}
			this.teammates_.WriteTo(ref output, TeamRecommendInfo._repeated_teammates_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ABD9 RID: 109529 RVA: 0x003E5074 File Offset: 0x003E3274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillBranchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillBranchId);
			}
			num += this.teammates_.CalculateSize(TeamRecommendInfo._repeated_teammates_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ABDA RID: 109530 RVA: 0x003E50C8 File Offset: 0x003E32C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamRecommendInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillBranchId != 0)
			{
				this.SkillBranchId = other.SkillBranchId;
			}
			this.teammates_.Add(other.teammates_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ABDB RID: 109531 RVA: 0x003E5115 File Offset: 0x003E3315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ABDC RID: 109532 RVA: 0x003E5120 File Offset: 0x003E3320
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.teammates_.AddEntriesFrom(ref input, TeamRecommendInfo._repeated_teammates_codec);
					}
				}
				else
				{
					this.SkillBranchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C85 RID: 40069
		private static readonly MessageParser<TeamRecommendInfo> _parser = new MessageParser<TeamRecommendInfo>(() => new TeamRecommendInfo());

		// Token: 0x04009C86 RID: 40070
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C87 RID: 40071
		public const int SkillBranchIdFieldNumber = 1;

		// Token: 0x04009C88 RID: 40072
		private int skillBranchId_;

		// Token: 0x04009C89 RID: 40073
		public const int TeammatesFieldNumber = 2;

		// Token: 0x04009C8A RID: 40074
		private static readonly FieldCodec<TeamRecommendTeammate> _repeated_teammates_codec = FieldCodec.ForMessage<TeamRecommendTeammate>(18U, TeamRecommendTeammate.Parser);

		// Token: 0x04009C8B RID: 40075
		private readonly RepeatedField<TeamRecommendTeammate> teammates_ = new RepeatedField<TeamRecommendTeammate>();
	}
}
