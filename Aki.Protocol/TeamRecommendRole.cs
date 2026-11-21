using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A2 RID: 5026
	public sealed class TeamRecommendRole : IMessage<TeamRecommendRole>, IMessage, IEquatable<TeamRecommendRole>, IDeepCloneable<TeamRecommendRole>, IBufferMessage
	{
		// Token: 0x0601AC00 RID: 109568 RVA: 0x003E54C5 File Offset: 0x003E36C5
		[NullableContext(1)]
		public static TeamRecommendRole Create()
		{
			return new TeamRecommendRole();
		}

		// Token: 0x17005A90 RID: 23184
		// (get) Token: 0x0601AC01 RID: 109569 RVA: 0x003E54CC File Offset: 0x003E36CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeamRecommendRole> Parser
		{
			get
			{
				return TeamRecommendRole._parser;
			}
		}

		// Token: 0x17005A91 RID: 23185
		// (get) Token: 0x0601AC02 RID: 109570 RVA: 0x003E54D3 File Offset: 0x003E36D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A92 RID: 23186
		// (get) Token: 0x0601AC03 RID: 109571 RVA: 0x003E54D6 File Offset: 0x003E36D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamRecommendRole.Descriptor;
			}
		}

		// Token: 0x0601AC04 RID: 109572 RVA: 0x003E54DD File Offset: 0x003E36DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendRole()
		{
		}

		// Token: 0x0601AC05 RID: 109573 RVA: 0x003E54F0 File Offset: 0x003E36F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendRole(TeamRecommendRole other) : this()
		{
			this.roleId_ = other.roleId_;
			this.teams_ = other.teams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC06 RID: 109574 RVA: 0x003E5526 File Offset: 0x003E3726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendRole Clone()
		{
			return new TeamRecommendRole(this);
		}

		// Token: 0x17005A93 RID: 23187
		// (get) Token: 0x0601AC07 RID: 109575 RVA: 0x003E552E File Offset: 0x003E372E
		// (set) Token: 0x0601AC08 RID: 109576 RVA: 0x003E5536 File Offset: 0x003E3736
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

		// Token: 0x17005A94 RID: 23188
		// (get) Token: 0x0601AC09 RID: 109577 RVA: 0x003E553F File Offset: 0x003E373F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TeamRecommendInfo> Teams
		{
			get
			{
				return this.teams_;
			}
		}

		// Token: 0x0601AC0A RID: 109578 RVA: 0x003E5547 File Offset: 0x003E3747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamRecommendRole);
		}

		// Token: 0x0601AC0B RID: 109579 RVA: 0x003E5558 File Offset: 0x003E3758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamRecommendRole other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.teams_.Equals(other.teams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC0C RID: 109580 RVA: 0x003E55A8 File Offset: 0x003E37A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.teams_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AC0D RID: 109581 RVA: 0x003E55F5 File Offset: 0x003E37F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC0E RID: 109582 RVA: 0x003E5602 File Offset: 0x003E3802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC0F RID: 109583 RVA: 0x003E560C File Offset: 0x003E380C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			this.teams_.WriteTo(ref output, TeamRecommendRole._repeated_teams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AC10 RID: 109584 RVA: 0x003E565C File Offset: 0x003E385C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.teams_.CalculateSize(TeamRecommendRole._repeated_teams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AC11 RID: 109585 RVA: 0x003E56B0 File Offset: 0x003E38B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamRecommendRole other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.teams_.Add(other.teams_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AC12 RID: 109586 RVA: 0x003E56FD File Offset: 0x003E38FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC13 RID: 109587 RVA: 0x003E5708 File Offset: 0x003E3908
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
						this.teams_.AddEntriesFrom(ref input, TeamRecommendRole._repeated_teams_codec);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C91 RID: 40081
		private static readonly MessageParser<TeamRecommendRole> _parser = new MessageParser<TeamRecommendRole>(() => new TeamRecommendRole());

		// Token: 0x04009C92 RID: 40082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C93 RID: 40083
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04009C94 RID: 40084
		private int roleId_;

		// Token: 0x04009C95 RID: 40085
		public const int TeamsFieldNumber = 2;

		// Token: 0x04009C96 RID: 40086
		private static readonly FieldCodec<TeamRecommendInfo> _repeated_teams_codec = FieldCodec.ForMessage<TeamRecommendInfo>(18U, TeamRecommendInfo.Parser);

		// Token: 0x04009C97 RID: 40087
		private readonly RepeatedField<TeamRecommendInfo> teams_ = new RepeatedField<TeamRecommendInfo>();
	}
}
