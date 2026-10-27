using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001327 RID: 4903
	[NetMessage(EMessageId.TeamMatchFlagNotify)]
	public sealed class TeamMatchFlagNotify : IMessage<TeamMatchFlagNotify>, IMessage, IEquatable<TeamMatchFlagNotify>, IDeepCloneable<TeamMatchFlagNotify>, IBufferMessage
	{
		// Token: 0x0601A0DD RID: 106717 RVA: 0x003C8FAD File Offset: 0x003C71AD
		[NullableContext(1)]
		public static TeamMatchFlagNotify Create()
		{
			return new TeamMatchFlagNotify();
		}

		// Token: 0x170057E0 RID: 22496
		// (get) Token: 0x0601A0DE RID: 106718 RVA: 0x003C8FB4 File Offset: 0x003C71B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057E1 RID: 22497
		// (get) Token: 0x0601A0DF RID: 106719 RVA: 0x003C8FB7 File Offset: 0x003C71B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchFlagNotify.Descriptor;
			}
		}

		// Token: 0x0601A0E0 RID: 106720 RVA: 0x003C8FBE File Offset: 0x003C71BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchFlagNotify()
		{
		}

		// Token: 0x0601A0E1 RID: 106721 RVA: 0x003C8FC6 File Offset: 0x003C71C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchFlagNotify(TeamMatchFlagNotify other) : this()
		{
			this.matchFlag_ = other.matchFlag_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A0E2 RID: 106722 RVA: 0x003C8FF7 File Offset: 0x003C71F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchFlagNotify Clone()
		{
			return new TeamMatchFlagNotify(this);
		}

		// Token: 0x170057E2 RID: 22498
		// (get) Token: 0x0601A0E3 RID: 106723 RVA: 0x003C8FFF File Offset: 0x003C71FF
		// (set) Token: 0x0601A0E4 RID: 106724 RVA: 0x003C9007 File Offset: 0x003C7207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MatchFlag
		{
			get
			{
				return this.matchFlag_;
			}
			set
			{
				this.matchFlag_ = value;
			}
		}

		// Token: 0x170057E3 RID: 22499
		// (get) Token: 0x0601A0E5 RID: 106725 RVA: 0x003C9010 File Offset: 0x003C7210
		// (set) Token: 0x0601A0E6 RID: 106726 RVA: 0x003C9018 File Offset: 0x003C7218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x0601A0E7 RID: 106727 RVA: 0x003C9021 File Offset: 0x003C7221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchFlagNotify);
		}

		// Token: 0x0601A0E8 RID: 106728 RVA: 0x003C902F File Offset: 0x003C722F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchFlagNotify other)
		{
			return other != null && (other == this || (this.MatchFlag == other.MatchFlag && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A0E9 RID: 106729 RVA: 0x003C9070 File Offset: 0x003C7270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MatchFlag)
			{
				num ^= this.MatchFlag.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A0EA RID: 106730 RVA: 0x003C90C8 File Offset: 0x003C72C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A0EB RID: 106731 RVA: 0x003C90D5 File Offset: 0x003C72D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A0EC RID: 106732 RVA: 0x003C90E0 File Offset: 0x003C72E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchFlag)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.MatchFlag);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A0ED RID: 106733 RVA: 0x003C913C File Offset: 0x003C733C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MatchFlag)
			{
				num += 2;
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A0EE RID: 106734 RVA: 0x003C9188 File Offset: 0x003C7388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamMatchFlagNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MatchFlag)
			{
				this.MatchFlag = other.MatchFlag;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A0EF RID: 106735 RVA: 0x003C91D8 File Offset: 0x003C73D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A0F0 RID: 106736 RVA: 0x003C91E4 File Offset: 0x003C73E4
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
				if (num != 80U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.MatchFlag = input.ReadBool();
				}
			}
		}

		// Token: 0x0400982B RID: 38955
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400982C RID: 38956
		public const int MatchFlagFieldNumber = 10;

		// Token: 0x0400982D RID: 38957
		private bool matchFlag_;

		// Token: 0x0400982E RID: 38958
		public const int InstIdFieldNumber = 11;

		// Token: 0x0400982F RID: 38959
		private int instId_;
	}
}
