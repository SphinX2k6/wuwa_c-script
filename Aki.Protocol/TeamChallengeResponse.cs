using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001390 RID: 5008
	[NetMessage(EMessageId.TeamChallengeResponse)]
	public sealed class TeamChallengeResponse : IMessage<TeamChallengeResponse>, IMessage, IEquatable<TeamChallengeResponse>, IDeepCloneable<TeamChallengeResponse>, IBufferMessage
	{
		// Token: 0x0601AA9F RID: 109215 RVA: 0x003E28B7 File Offset: 0x003E0AB7
		[NullableContext(1)]
		public static TeamChallengeResponse Create()
		{
			return new TeamChallengeResponse();
		}

		// Token: 0x17005A4B RID: 23115
		// (get) Token: 0x0601AAA0 RID: 109216 RVA: 0x003E28BE File Offset: 0x003E0ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A4C RID: 23116
		// (get) Token: 0x0601AAA1 RID: 109217 RVA: 0x003E28C1 File Offset: 0x003E0AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamChallengeResponse.Descriptor;
			}
		}

		// Token: 0x0601AAA2 RID: 109218 RVA: 0x003E28C8 File Offset: 0x003E0AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeResponse()
		{
		}

		// Token: 0x0601AAA3 RID: 109219 RVA: 0x003E28D0 File Offset: 0x003E0AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeResponse(TeamChallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AAA4 RID: 109220 RVA: 0x003E28F5 File Offset: 0x003E0AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeResponse Clone()
		{
			return new TeamChallengeResponse(this);
		}

		// Token: 0x17005A4D RID: 23117
		// (get) Token: 0x0601AAA5 RID: 109221 RVA: 0x003E28FD File Offset: 0x003E0AFD
		// (set) Token: 0x0601AAA6 RID: 109222 RVA: 0x003E2905 File Offset: 0x003E0B05
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

		// Token: 0x0601AAA7 RID: 109223 RVA: 0x003E290E File Offset: 0x003E0B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamChallengeResponse);
		}

		// Token: 0x0601AAA8 RID: 109224 RVA: 0x003E291C File Offset: 0x003E0B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamChallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AAA9 RID: 109225 RVA: 0x003E294C File Offset: 0x003E0B4C
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

		// Token: 0x0601AAAA RID: 109226 RVA: 0x003E2991 File Offset: 0x003E0B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AAAB RID: 109227 RVA: 0x003E299E File Offset: 0x003E0B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AAAC RID: 109228 RVA: 0x003E29A7 File Offset: 0x003E0BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AAAD RID: 109229 RVA: 0x003E29DC File Offset: 0x003E0BDC
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

		// Token: 0x0601AAAE RID: 109230 RVA: 0x003E2A1A File Offset: 0x003E0C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamChallengeResponse other)
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

		// Token: 0x0601AAAF RID: 109231 RVA: 0x003E2A4B File Offset: 0x003E0C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AAB0 RID: 109232 RVA: 0x003E2A54 File Offset: 0x003E0C54
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009C3B RID: 39995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C3C RID: 39996
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009C3D RID: 39997
		private ErrorCode errorCode_;
	}
}
