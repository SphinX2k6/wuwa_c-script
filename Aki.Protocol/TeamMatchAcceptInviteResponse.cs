using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001393 RID: 5011
	[NetMessage(EMessageId.TeamMatchAcceptInviteResponse)]
	public sealed class TeamMatchAcceptInviteResponse : IMessage<TeamMatchAcceptInviteResponse>, IMessage, IEquatable<TeamMatchAcceptInviteResponse>, IDeepCloneable<TeamMatchAcceptInviteResponse>, IBufferMessage
	{
		// Token: 0x0601AADB RID: 109275 RVA: 0x003E3087 File Offset: 0x003E1287
		[NullableContext(1)]
		public static TeamMatchAcceptInviteResponse Create()
		{
			return new TeamMatchAcceptInviteResponse();
		}

		// Token: 0x17005A57 RID: 23127
		// (get) Token: 0x0601AADC RID: 109276 RVA: 0x003E308E File Offset: 0x003E128E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A58 RID: 23128
		// (get) Token: 0x0601AADD RID: 109277 RVA: 0x003E3091 File Offset: 0x003E1291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchAcceptInviteResponse.Descriptor;
			}
		}

		// Token: 0x0601AADE RID: 109278 RVA: 0x003E3098 File Offset: 0x003E1298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteResponse()
		{
		}

		// Token: 0x0601AADF RID: 109279 RVA: 0x003E30A0 File Offset: 0x003E12A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteResponse(TeamMatchAcceptInviteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AAE0 RID: 109280 RVA: 0x003E30C5 File Offset: 0x003E12C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteResponse Clone()
		{
			return new TeamMatchAcceptInviteResponse(this);
		}

		// Token: 0x17005A59 RID: 23129
		// (get) Token: 0x0601AAE1 RID: 109281 RVA: 0x003E30CD File Offset: 0x003E12CD
		// (set) Token: 0x0601AAE2 RID: 109282 RVA: 0x003E30D5 File Offset: 0x003E12D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0601AAE3 RID: 109283 RVA: 0x003E30DE File Offset: 0x003E12DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchAcceptInviteResponse);
		}

		// Token: 0x0601AAE4 RID: 109284 RVA: 0x003E30EC File Offset: 0x003E12EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchAcceptInviteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AAE5 RID: 109285 RVA: 0x003E311C File Offset: 0x003E131C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AAE6 RID: 109286 RVA: 0x003E3161 File Offset: 0x003E1361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AAE7 RID: 109287 RVA: 0x003E316E File Offset: 0x003E136E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AAE8 RID: 109288 RVA: 0x003E3177 File Offset: 0x003E1377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AAE9 RID: 109289 RVA: 0x003E31AC File Offset: 0x003E13AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AAEA RID: 109290 RVA: 0x003E31EA File Offset: 0x003E13EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamMatchAcceptInviteResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AAEB RID: 109291 RVA: 0x003E321B File Offset: 0x003E141B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AAEC RID: 109292 RVA: 0x003E3224 File Offset: 0x003E1424
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009C4A RID: 40010
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C4B RID: 40011
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04009C4C RID: 40012
		private ErrorCode errorCode_;
	}
}
