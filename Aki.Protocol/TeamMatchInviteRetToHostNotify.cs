using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001398 RID: 5016
	[NetMessage(EMessageId.TeamMatchInviteRetToHostNotify)]
	public sealed class TeamMatchInviteRetToHostNotify : IMessage<TeamMatchInviteRetToHostNotify>, IMessage, IEquatable<TeamMatchInviteRetToHostNotify>, IDeepCloneable<TeamMatchInviteRetToHostNotify>, IBufferMessage
	{
		// Token: 0x0601AB39 RID: 109369 RVA: 0x003E3B49 File Offset: 0x003E1D49
		[NullableContext(1)]
		public static TeamMatchInviteRetToHostNotify Create()
		{
			return new TeamMatchInviteRetToHostNotify();
		}

		// Token: 0x17005A68 RID: 23144
		// (get) Token: 0x0601AB3A RID: 109370 RVA: 0x003E3B50 File Offset: 0x003E1D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A69 RID: 23145
		// (get) Token: 0x0601AB3B RID: 109371 RVA: 0x003E3B53 File Offset: 0x003E1D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchInviteRetToHostNotify.Descriptor;
			}
		}

		// Token: 0x0601AB3C RID: 109372 RVA: 0x003E3B5A File Offset: 0x003E1D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRetToHostNotify()
		{
		}

		// Token: 0x0601AB3D RID: 109373 RVA: 0x003E3B62 File Offset: 0x003E1D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRetToHostNotify(TeamMatchInviteRetToHostNotify other) : this()
		{
			this.instId_ = other.instId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB3E RID: 109374 RVA: 0x003E3B93 File Offset: 0x003E1D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRetToHostNotify Clone()
		{
			return new TeamMatchInviteRetToHostNotify(this);
		}

		// Token: 0x17005A6A RID: 23146
		// (get) Token: 0x0601AB3F RID: 109375 RVA: 0x003E3B9B File Offset: 0x003E1D9B
		// (set) Token: 0x0601AB40 RID: 109376 RVA: 0x003E3BA3 File Offset: 0x003E1DA3
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

		// Token: 0x17005A6B RID: 23147
		// (get) Token: 0x0601AB41 RID: 109377 RVA: 0x003E3BAC File Offset: 0x003E1DAC
		// (set) Token: 0x0601AB42 RID: 109378 RVA: 0x003E3BB4 File Offset: 0x003E1DB4
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

		// Token: 0x0601AB43 RID: 109379 RVA: 0x003E3BBD File Offset: 0x003E1DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchInviteRetToHostNotify);
		}

		// Token: 0x0601AB44 RID: 109380 RVA: 0x003E3BCB File Offset: 0x003E1DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchInviteRetToHostNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB45 RID: 109381 RVA: 0x003E3C0C File Offset: 0x003E1E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
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

		// Token: 0x0601AB46 RID: 109382 RVA: 0x003E3C6A File Offset: 0x003E1E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB47 RID: 109383 RVA: 0x003E3C77 File Offset: 0x003E1E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB48 RID: 109384 RVA: 0x003E3C80 File Offset: 0x003E1E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB49 RID: 109385 RVA: 0x003E3CDC File Offset: 0x003E1EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
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

		// Token: 0x0601AB4A RID: 109386 RVA: 0x003E3D34 File Offset: 0x003E1F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamMatchInviteRetToHostNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AB4B RID: 109387 RVA: 0x003E3D84 File Offset: 0x003E1F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB4C RID: 109388 RVA: 0x003E3D90 File Offset: 0x003E1F90
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
				if (num != 32U)
				{
					if (num != 96U)
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009C5D RID: 40029
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C5E RID: 40030
		public const int InstIdFieldNumber = 12;

		// Token: 0x04009C5F RID: 40031
		private int instId_;

		// Token: 0x04009C60 RID: 40032
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009C61 RID: 40033
		private ErrorCode errorCode_;
	}
}
