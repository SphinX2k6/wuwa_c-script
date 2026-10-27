using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001326 RID: 4902
	[NetMessage(EMessageId.TeamMatchAcceptInviteResponse)]
	public sealed class TeamMatchAcceptInviteResponse : IMessage<TeamMatchAcceptInviteResponse>, IMessage, IEquatable<TeamMatchAcceptInviteResponse>, IDeepCloneable<TeamMatchAcceptInviteResponse>, IBufferMessage
	{
		// Token: 0x0601A0CB RID: 106699 RVA: 0x003C8DCB File Offset: 0x003C6FCB
		[NullableContext(1)]
		public static TeamMatchAcceptInviteResponse Create()
		{
			return new TeamMatchAcceptInviteResponse();
		}

		// Token: 0x170057DD RID: 22493
		// (get) Token: 0x0601A0CC RID: 106700 RVA: 0x003C8DD2 File Offset: 0x003C6FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057DE RID: 22494
		// (get) Token: 0x0601A0CD RID: 106701 RVA: 0x003C8DD5 File Offset: 0x003C6FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchAcceptInviteResponse.Descriptor;
			}
		}

		// Token: 0x0601A0CE RID: 106702 RVA: 0x003C8DDC File Offset: 0x003C6FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteResponse()
		{
		}

		// Token: 0x0601A0CF RID: 106703 RVA: 0x003C8DE4 File Offset: 0x003C6FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteResponse(TeamMatchAcceptInviteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A0D0 RID: 106704 RVA: 0x003C8E09 File Offset: 0x003C7009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchAcceptInviteResponse Clone()
		{
			return new TeamMatchAcceptInviteResponse(this);
		}

		// Token: 0x170057DF RID: 22495
		// (get) Token: 0x0601A0D1 RID: 106705 RVA: 0x003C8E11 File Offset: 0x003C7011
		// (set) Token: 0x0601A0D2 RID: 106706 RVA: 0x003C8E19 File Offset: 0x003C7019
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

		// Token: 0x0601A0D3 RID: 106707 RVA: 0x003C8E22 File Offset: 0x003C7022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchAcceptInviteResponse);
		}

		// Token: 0x0601A0D4 RID: 106708 RVA: 0x003C8E30 File Offset: 0x003C7030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchAcceptInviteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A0D5 RID: 106709 RVA: 0x003C8E60 File Offset: 0x003C7060
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

		// Token: 0x0601A0D6 RID: 106710 RVA: 0x003C8EA5 File Offset: 0x003C70A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A0D7 RID: 106711 RVA: 0x003C8EB2 File Offset: 0x003C70B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A0D8 RID: 106712 RVA: 0x003C8EBB File Offset: 0x003C70BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A0D9 RID: 106713 RVA: 0x003C8EF0 File Offset: 0x003C70F0
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

		// Token: 0x0601A0DA RID: 106714 RVA: 0x003C8F2E File Offset: 0x003C712E
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

		// Token: 0x0601A0DB RID: 106715 RVA: 0x003C8F5F File Offset: 0x003C715F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A0DC RID: 106716 RVA: 0x003C8F68 File Offset: 0x003C7168
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009828 RID: 38952
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009829 RID: 38953
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400982A RID: 38954
		private ErrorCode errorCode_;
	}
}
