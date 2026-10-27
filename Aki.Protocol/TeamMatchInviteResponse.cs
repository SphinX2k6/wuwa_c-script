using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132A RID: 4906
	[NetMessage(EMessageId.TeamMatchInviteResponse)]
	public sealed class TeamMatchInviteResponse : IMessage<TeamMatchInviteResponse>, IMessage, IEquatable<TeamMatchInviteResponse>, IDeepCloneable<TeamMatchInviteResponse>, IBufferMessage
	{
		// Token: 0x0601A117 RID: 106775 RVA: 0x003C96AD File Offset: 0x003C78AD
		[NullableContext(1)]
		public static TeamMatchInviteResponse Create()
		{
			return new TeamMatchInviteResponse();
		}

		// Token: 0x170057EB RID: 22507
		// (get) Token: 0x0601A118 RID: 106776 RVA: 0x003C96B4 File Offset: 0x003C78B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057EC RID: 22508
		// (get) Token: 0x0601A119 RID: 106777 RVA: 0x003C96B7 File Offset: 0x003C78B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchInviteResponse.Descriptor;
			}
		}

		// Token: 0x0601A11A RID: 106778 RVA: 0x003C96BE File Offset: 0x003C78BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteResponse()
		{
		}

		// Token: 0x0601A11B RID: 106779 RVA: 0x003C96C6 File Offset: 0x003C78C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteResponse(TeamMatchInviteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A11C RID: 106780 RVA: 0x003C96EB File Offset: 0x003C78EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteResponse Clone()
		{
			return new TeamMatchInviteResponse(this);
		}

		// Token: 0x170057ED RID: 22509
		// (get) Token: 0x0601A11D RID: 106781 RVA: 0x003C96F3 File Offset: 0x003C78F3
		// (set) Token: 0x0601A11E RID: 106782 RVA: 0x003C96FB File Offset: 0x003C78FB
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

		// Token: 0x0601A11F RID: 106783 RVA: 0x003C9704 File Offset: 0x003C7904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchInviteResponse);
		}

		// Token: 0x0601A120 RID: 106784 RVA: 0x003C9712 File Offset: 0x003C7912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchInviteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A121 RID: 106785 RVA: 0x003C9740 File Offset: 0x003C7940
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

		// Token: 0x0601A122 RID: 106786 RVA: 0x003C9785 File Offset: 0x003C7985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A123 RID: 106787 RVA: 0x003C9792 File Offset: 0x003C7992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A124 RID: 106788 RVA: 0x003C979B File Offset: 0x003C799B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A125 RID: 106789 RVA: 0x003C97D0 File Offset: 0x003C79D0
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

		// Token: 0x0601A126 RID: 106790 RVA: 0x003C980E File Offset: 0x003C7A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamMatchInviteResponse other)
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

		// Token: 0x0601A127 RID: 106791 RVA: 0x003C983F File Offset: 0x003C7A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A128 RID: 106792 RVA: 0x003C9848 File Offset: 0x003C7A48
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009838 RID: 38968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009839 RID: 38969
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400983A RID: 38970
		private ErrorCode errorCode_;
	}
}
