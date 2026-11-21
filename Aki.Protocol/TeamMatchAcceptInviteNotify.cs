using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001391 RID: 5009
	[NetMessage(EMessageId.TeamMatchAcceptInviteNotify)]
	public sealed class TeamMatchAcceptInviteNotify : IMessage<TeamMatchAcceptInviteNotify>, IMessage, IEquatable<TeamMatchAcceptInviteNotify>, IDeepCloneable<TeamMatchAcceptInviteNotify>, IBufferMessage
	{
		// Token: 0x0601AAB1 RID: 109233 RVA: 0x003E2A99 File Offset: 0x003E0C99
		[NullableContext(1)]
		public static TeamMatchAcceptInviteNotify Create()
		{
			return new TeamMatchAcceptInviteNotify();
		}

		// Token: 0x17005A4E RID: 23118
		// (get) Token: 0x0601AAB2 RID: 109234 RVA: 0x003E2AA0 File Offset: 0x003E0CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A4F RID: 23119
		// (get) Token: 0x0601AAB3 RID: 109235 RVA: 0x003E2AA3 File Offset: 0x003E0CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchAcceptInviteNotify.Descriptor;
			}
		}

		// Token: 0x0601AAB4 RID: 109236 RVA: 0x003E2AAA File Offset: 0x003E0CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteNotify()
		{
		}

		// Token: 0x0601AAB5 RID: 109237 RVA: 0x003E2AB2 File Offset: 0x003E0CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteNotify(TeamMatchAcceptInviteNotify other) : this()
		{
			this.acceptResult_ = other.acceptResult_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AAB6 RID: 109238 RVA: 0x003E2AE3 File Offset: 0x003E0CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteNotify Clone()
		{
			return new TeamMatchAcceptInviteNotify(this);
		}

		// Token: 0x17005A50 RID: 23120
		// (get) Token: 0x0601AAB7 RID: 109239 RVA: 0x003E2AEB File Offset: 0x003E0CEB
		// (set) Token: 0x0601AAB8 RID: 109240 RVA: 0x003E2AF3 File Offset: 0x003E0CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMatchAcceptInviteResult AcceptResult
		{
			get
			{
				return this.acceptResult_;
			}
			set
			{
				this.acceptResult_ = value;
			}
		}

		// Token: 0x17005A51 RID: 23121
		// (get) Token: 0x0601AAB9 RID: 109241 RVA: 0x003E2AFC File Offset: 0x003E0CFC
		// (set) Token: 0x0601AABA RID: 109242 RVA: 0x003E2B04 File Offset: 0x003E0D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x0601AABB RID: 109243 RVA: 0x003E2B0D File Offset: 0x003E0D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchAcceptInviteNotify);
		}

		// Token: 0x0601AABC RID: 109244 RVA: 0x003E2B1B File Offset: 0x003E0D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchAcceptInviteNotify other)
		{
			return other != null && (other == this || (this.AcceptResult == other.AcceptResult && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AABD RID: 109245 RVA: 0x003E2B5C File Offset: 0x003E0D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				num ^= this.AcceptResult.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AABE RID: 109246 RVA: 0x003E2BBA File Offset: 0x003E0DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AABF RID: 109247 RVA: 0x003E2BC7 File Offset: 0x003E0DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AAC0 RID: 109248 RVA: 0x003E2BD0 File Offset: 0x003E0DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PlayerId);
			}
			if (this.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.AcceptResult);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AAC1 RID: 109249 RVA: 0x003E2C2C File Offset: 0x003E0E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AcceptResult);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AAC2 RID: 109250 RVA: 0x003E2C84 File Offset: 0x003E0E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamMatchAcceptInviteNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AcceptResult != EMatchAcceptInviteResult.Accept)
			{
				this.AcceptResult = other.AcceptResult;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AAC3 RID: 109251 RVA: 0x003E2CD4 File Offset: 0x003E0ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AAC4 RID: 109252 RVA: 0x003E2CE0 File Offset: 0x003E0EE0
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
				if (num != 64U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AcceptResult = (EMatchAcceptInviteResult)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C3E RID: 39998
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C3F RID: 39999
		public const int AcceptResultFieldNumber = 11;

		// Token: 0x04009C40 RID: 40000
		private EMatchAcceptInviteResult acceptResult_;

		// Token: 0x04009C41 RID: 40001
		public const int PlayerIdFieldNumber = 8;

		// Token: 0x04009C42 RID: 40002
		private int playerId_;
	}
}
