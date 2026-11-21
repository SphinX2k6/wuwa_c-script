using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001394 RID: 5012
	[NetMessage(EMessageId.TeamMatchFlagNotify)]
	public sealed class TeamMatchFlagNotify : IMessage<TeamMatchFlagNotify>, IMessage, IEquatable<TeamMatchFlagNotify>, IDeepCloneable<TeamMatchFlagNotify>, IBufferMessage
	{
		// Token: 0x0601AAED RID: 109293 RVA: 0x003E3269 File Offset: 0x003E1469
		[NullableContext(1)]
		public static TeamMatchFlagNotify Create()
		{
			return new TeamMatchFlagNotify();
		}

		// Token: 0x17005A5A RID: 23130
		// (get) Token: 0x0601AAEE RID: 109294 RVA: 0x003E3270 File Offset: 0x003E1470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A5B RID: 23131
		// (get) Token: 0x0601AAEF RID: 109295 RVA: 0x003E3273 File Offset: 0x003E1473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchFlagNotify.Descriptor;
			}
		}

		// Token: 0x0601AAF0 RID: 109296 RVA: 0x003E327A File Offset: 0x003E147A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchFlagNotify()
		{
		}

		// Token: 0x0601AAF1 RID: 109297 RVA: 0x003E3282 File Offset: 0x003E1482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchFlagNotify(TeamMatchFlagNotify other) : this()
		{
			this.matchFlag_ = other.matchFlag_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AAF2 RID: 109298 RVA: 0x003E32B3 File Offset: 0x003E14B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchFlagNotify Clone()
		{
			return new TeamMatchFlagNotify(this);
		}

		// Token: 0x17005A5C RID: 23132
		// (get) Token: 0x0601AAF3 RID: 109299 RVA: 0x003E32BB File Offset: 0x003E14BB
		// (set) Token: 0x0601AAF4 RID: 109300 RVA: 0x003E32C3 File Offset: 0x003E14C3
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

		// Token: 0x17005A5D RID: 23133
		// (get) Token: 0x0601AAF5 RID: 109301 RVA: 0x003E32CC File Offset: 0x003E14CC
		// (set) Token: 0x0601AAF6 RID: 109302 RVA: 0x003E32D4 File Offset: 0x003E14D4
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

		// Token: 0x0601AAF7 RID: 109303 RVA: 0x003E32DD File Offset: 0x003E14DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchFlagNotify);
		}

		// Token: 0x0601AAF8 RID: 109304 RVA: 0x003E32EB File Offset: 0x003E14EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchFlagNotify other)
		{
			return other != null && (other == this || (this.MatchFlag == other.MatchFlag && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AAF9 RID: 109305 RVA: 0x003E332C File Offset: 0x003E152C
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

		// Token: 0x0601AAFA RID: 109306 RVA: 0x003E3384 File Offset: 0x003E1584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AAFB RID: 109307 RVA: 0x003E3391 File Offset: 0x003E1591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AAFC RID: 109308 RVA: 0x003E339C File Offset: 0x003E159C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchFlag)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.MatchFlag);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AAFD RID: 109309 RVA: 0x003E33F8 File Offset: 0x003E15F8
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

		// Token: 0x0601AAFE RID: 109310 RVA: 0x003E3444 File Offset: 0x003E1644
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

		// Token: 0x0601AAFF RID: 109311 RVA: 0x003E3494 File Offset: 0x003E1694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB00 RID: 109312 RVA: 0x003E34A0 File Offset: 0x003E16A0
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
				if (num != 104U)
				{
					if (num != 112U)
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

		// Token: 0x04009C4D RID: 40013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C4E RID: 40014
		public const int MatchFlagFieldNumber = 13;

		// Token: 0x04009C4F RID: 40015
		private bool matchFlag_;

		// Token: 0x04009C50 RID: 40016
		public const int InstIdFieldNumber = 14;

		// Token: 0x04009C51 RID: 40017
		private int instId_;
	}
}
