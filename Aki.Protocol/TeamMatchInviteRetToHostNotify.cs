using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132B RID: 4907
	[NetMessage(EMessageId.TeamMatchInviteRetToHostNotify)]
	public sealed class TeamMatchInviteRetToHostNotify : IMessage<TeamMatchInviteRetToHostNotify>, IMessage, IEquatable<TeamMatchInviteRetToHostNotify>, IDeepCloneable<TeamMatchInviteRetToHostNotify>, IBufferMessage
	{
		// Token: 0x0601A129 RID: 106793 RVA: 0x003C988D File Offset: 0x003C7A8D
		[NullableContext(1)]
		public static TeamMatchInviteRetToHostNotify Create()
		{
			return new TeamMatchInviteRetToHostNotify();
		}

		// Token: 0x170057EE RID: 22510
		// (get) Token: 0x0601A12A RID: 106794 RVA: 0x003C9894 File Offset: 0x003C7A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057EF RID: 22511
		// (get) Token: 0x0601A12B RID: 106795 RVA: 0x003C9897 File Offset: 0x003C7A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchInviteRetToHostNotify.Descriptor;
			}
		}

		// Token: 0x0601A12C RID: 106796 RVA: 0x003C989E File Offset: 0x003C7A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRetToHostNotify()
		{
		}

		// Token: 0x0601A12D RID: 106797 RVA: 0x003C98A6 File Offset: 0x003C7AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRetToHostNotify(TeamMatchInviteRetToHostNotify other) : this()
		{
			this.instId_ = other.instId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A12E RID: 106798 RVA: 0x003C98D7 File Offset: 0x003C7AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteRetToHostNotify Clone()
		{
			return new TeamMatchInviteRetToHostNotify(this);
		}

		// Token: 0x170057F0 RID: 22512
		// (get) Token: 0x0601A12F RID: 106799 RVA: 0x003C98DF File Offset: 0x003C7ADF
		// (set) Token: 0x0601A130 RID: 106800 RVA: 0x003C98E7 File Offset: 0x003C7AE7
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

		// Token: 0x170057F1 RID: 22513
		// (get) Token: 0x0601A131 RID: 106801 RVA: 0x003C98F0 File Offset: 0x003C7AF0
		// (set) Token: 0x0601A132 RID: 106802 RVA: 0x003C98F8 File Offset: 0x003C7AF8
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

		// Token: 0x0601A133 RID: 106803 RVA: 0x003C9901 File Offset: 0x003C7B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchInviteRetToHostNotify);
		}

		// Token: 0x0601A134 RID: 106804 RVA: 0x003C990F File Offset: 0x003C7B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchInviteRetToHostNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A135 RID: 106805 RVA: 0x003C9950 File Offset: 0x003C7B50
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

		// Token: 0x0601A136 RID: 106806 RVA: 0x003C99AE File Offset: 0x003C7BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A137 RID: 106807 RVA: 0x003C99BB File Offset: 0x003C7BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A138 RID: 106808 RVA: 0x003C99C4 File Offset: 0x003C7BC4
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
				output.WriteRawTag(112);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A139 RID: 106809 RVA: 0x003C9A20 File Offset: 0x003C7C20
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

		// Token: 0x0601A13A RID: 106810 RVA: 0x003C9A78 File Offset: 0x003C7C78
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

		// Token: 0x0601A13B RID: 106811 RVA: 0x003C9AC8 File Offset: 0x003C7CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A13C RID: 106812 RVA: 0x003C9AD4 File Offset: 0x003C7CD4
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400983B RID: 38971
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400983C RID: 38972
		public const int InstIdFieldNumber = 14;

		// Token: 0x0400983D RID: 38973
		private int instId_;

		// Token: 0x0400983E RID: 38974
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400983F RID: 38975
		private ErrorCode errorCode_;
	}
}
