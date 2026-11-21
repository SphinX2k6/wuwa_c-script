using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A4 RID: 5028
	public sealed class TeamRecommendTeammate : IMessage<TeamRecommendTeammate>, IMessage, IEquatable<TeamRecommendTeammate>, IDeepCloneable<TeamRecommendTeammate>, IBufferMessage
	{
		// Token: 0x0601AC2B RID: 109611 RVA: 0x003E5A47 File Offset: 0x003E3C47
		[NullableContext(1)]
		public static TeamRecommendTeammate Create()
		{
			return new TeamRecommendTeammate();
		}

		// Token: 0x17005A9A RID: 23194
		// (get) Token: 0x0601AC2C RID: 109612 RVA: 0x003E5A4E File Offset: 0x003E3C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeamRecommendTeammate> Parser
		{
			get
			{
				return TeamRecommendTeammate._parser;
			}
		}

		// Token: 0x17005A9B RID: 23195
		// (get) Token: 0x0601AC2D RID: 109613 RVA: 0x003E5A55 File Offset: 0x003E3C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A9C RID: 23196
		// (get) Token: 0x0601AC2E RID: 109614 RVA: 0x003E5A58 File Offset: 0x003E3C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamRecommendTeammate.Descriptor;
			}
		}

		// Token: 0x0601AC2F RID: 109615 RVA: 0x003E5A5F File Offset: 0x003E3C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendTeammate()
		{
		}

		// Token: 0x0601AC30 RID: 109616 RVA: 0x003E5A74 File Offset: 0x003E3C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendTeammate(TeamRecommendTeammate other) : this()
		{
			this.main_ = ((other.main_ != null) ? other.main_.Clone() : null);
			this.spares_ = other.spares_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC31 RID: 109617 RVA: 0x003E5AC5 File Offset: 0x003E3CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendTeammate Clone()
		{
			return new TeamRecommendTeammate(this);
		}

		// Token: 0x17005A9D RID: 23197
		// (get) Token: 0x0601AC32 RID: 109618 RVA: 0x003E5ACD File Offset: 0x003E3CCD
		// (set) Token: 0x0601AC33 RID: 109619 RVA: 0x003E5AD5 File Offset: 0x003E3CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendRoleInfo Main
		{
			get
			{
				return this.main_;
			}
			set
			{
				this.main_ = value;
			}
		}

		// Token: 0x17005A9E RID: 23198
		// (get) Token: 0x0601AC34 RID: 109620 RVA: 0x003E5ADE File Offset: 0x003E3CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TeamRecommendRoleInfo> Spares
		{
			get
			{
				return this.spares_;
			}
		}

		// Token: 0x0601AC35 RID: 109621 RVA: 0x003E5AE6 File Offset: 0x003E3CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamRecommendTeammate);
		}

		// Token: 0x0601AC36 RID: 109622 RVA: 0x003E5AF4 File Offset: 0x003E3CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamRecommendTeammate other)
		{
			return other != null && (other == this || (object.Equals(this.Main, other.Main) && this.spares_.Equals(other.spares_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC37 RID: 109623 RVA: 0x003E5B48 File Offset: 0x003E3D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.main_ != null)
			{
				num ^= this.Main.GetHashCode();
			}
			num ^= this.spares_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AC38 RID: 109624 RVA: 0x003E5B92 File Offset: 0x003E3D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC39 RID: 109625 RVA: 0x003E5B9F File Offset: 0x003E3D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC3A RID: 109626 RVA: 0x003E5BA8 File Offset: 0x003E3DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.main_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Main);
			}
			this.spares_.WriteTo(ref output, TeamRecommendTeammate._repeated_spares_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AC3B RID: 109627 RVA: 0x003E5BF8 File Offset: 0x003E3DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.main_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Main);
			}
			num += this.spares_.CalculateSize(TeamRecommendTeammate._repeated_spares_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AC3C RID: 109628 RVA: 0x003E5C4C File Offset: 0x003E3E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamRecommendTeammate other)
		{
			if (other == null)
			{
				return;
			}
			if (other.main_ != null)
			{
				if (this.main_ == null)
				{
					this.Main = new TeamRecommendRoleInfo();
				}
				this.Main.MergeFrom(other.Main);
			}
			this.spares_.Add(other.spares_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AC3D RID: 109629 RVA: 0x003E5CB1 File Offset: 0x003E3EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC3E RID: 109630 RVA: 0x003E5CBC File Offset: 0x003E3EBC
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.spares_.AddEntriesFrom(ref input, TeamRecommendTeammate._repeated_spares_codec);
					}
				}
				else
				{
					if (this.main_ == null)
					{
						this.Main = new TeamRecommendRoleInfo();
					}
					input.ReadMessage(this.Main);
				}
			}
		}

		// Token: 0x04009C9E RID: 40094
		private static readonly MessageParser<TeamRecommendTeammate> _parser = new MessageParser<TeamRecommendTeammate>(() => new TeamRecommendTeammate());

		// Token: 0x04009C9F RID: 40095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CA0 RID: 40096
		public const int MainFieldNumber = 1;

		// Token: 0x04009CA1 RID: 40097
		private TeamRecommendRoleInfo main_;

		// Token: 0x04009CA2 RID: 40098
		public const int SparesFieldNumber = 2;

		// Token: 0x04009CA3 RID: 40099
		private static readonly FieldCodec<TeamRecommendRoleInfo> _repeated_spares_codec = FieldCodec.ForMessage<TeamRecommendRoleInfo>(18U, TeamRecommendRoleInfo.Parser);

		// Token: 0x04009CA4 RID: 40100
		private readonly RepeatedField<TeamRecommendRoleInfo> spares_ = new RepeatedField<TeamRecommendRoleInfo>();
	}
}
