using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001396 RID: 5014
	[NetMessage(EMessageId.TeamMatchInviteRequest)]
	public sealed class TeamMatchInviteRequest : IMessage<TeamMatchInviteRequest>, IMessage, IEquatable<TeamMatchInviteRequest>, IDeepCloneable<TeamMatchInviteRequest>, IBufferMessage
	{
		// Token: 0x0601AB15 RID: 109333 RVA: 0x003E3790 File Offset: 0x003E1990
		[NullableContext(1)]
		public static TeamMatchInviteRequest Create()
		{
			return new TeamMatchInviteRequest();
		}

		// Token: 0x17005A62 RID: 23138
		// (get) Token: 0x0601AB16 RID: 109334 RVA: 0x003E3797 File Offset: 0x003E1997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A63 RID: 23139
		// (get) Token: 0x0601AB17 RID: 109335 RVA: 0x003E379A File Offset: 0x003E199A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchInviteRequest.Descriptor;
			}
		}

		// Token: 0x0601AB18 RID: 109336 RVA: 0x003E37A1 File Offset: 0x003E19A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRequest()
		{
		}

		// Token: 0x0601AB19 RID: 109337 RVA: 0x003E37A9 File Offset: 0x003E19A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRequest(TeamMatchInviteRequest other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB1A RID: 109338 RVA: 0x003E37CE File Offset: 0x003E19CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRequest Clone()
		{
			return new TeamMatchInviteRequest(this);
		}

		// Token: 0x17005A64 RID: 23140
		// (get) Token: 0x0601AB1B RID: 109339 RVA: 0x003E37D6 File Offset: 0x003E19D6
		// (set) Token: 0x0601AB1C RID: 109340 RVA: 0x003E37DE File Offset: 0x003E19DE
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

		// Token: 0x0601AB1D RID: 109341 RVA: 0x003E37E7 File Offset: 0x003E19E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchInviteRequest);
		}

		// Token: 0x0601AB1E RID: 109342 RVA: 0x003E37F5 File Offset: 0x003E19F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchInviteRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB1F RID: 109343 RVA: 0x003E3824 File Offset: 0x003E1A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601AB20 RID: 109344 RVA: 0x003E3863 File Offset: 0x003E1A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB21 RID: 109345 RVA: 0x003E3870 File Offset: 0x003E1A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB22 RID: 109346 RVA: 0x003E3879 File Offset: 0x003E1A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB23 RID: 109347 RVA: 0x003E38AC File Offset: 0x003E1AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601AB24 RID: 109348 RVA: 0x003E38EA File Offset: 0x003E1AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamMatchInviteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AB25 RID: 109349 RVA: 0x003E391B File Offset: 0x003E1B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB26 RID: 109350 RVA: 0x003E3924 File Offset: 0x003E1B24
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C57 RID: 40023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C58 RID: 40024
		public const int InstIdFieldNumber = 15;

		// Token: 0x04009C59 RID: 40025
		private int instId_;
	}
}
