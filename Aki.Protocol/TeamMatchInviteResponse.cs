using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001397 RID: 5015
	[NetMessage(EMessageId.TeamMatchInviteResponse)]
	public sealed class TeamMatchInviteResponse : IMessage<TeamMatchInviteResponse>, IMessage, IEquatable<TeamMatchInviteResponse>, IDeepCloneable<TeamMatchInviteResponse>, IBufferMessage
	{
		// Token: 0x0601AB27 RID: 109351 RVA: 0x003E3969 File Offset: 0x003E1B69
		[NullableContext(1)]
		public static TeamMatchInviteResponse Create()
		{
			return new TeamMatchInviteResponse();
		}

		// Token: 0x17005A65 RID: 23141
		// (get) Token: 0x0601AB28 RID: 109352 RVA: 0x003E3970 File Offset: 0x003E1B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A66 RID: 23142
		// (get) Token: 0x0601AB29 RID: 109353 RVA: 0x003E3973 File Offset: 0x003E1B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamMatchInviteResponse.Descriptor;
			}
		}

		// Token: 0x0601AB2A RID: 109354 RVA: 0x003E397A File Offset: 0x003E1B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteResponse()
		{
		}

		// Token: 0x0601AB2B RID: 109355 RVA: 0x003E3982 File Offset: 0x003E1B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteResponse(TeamMatchInviteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB2C RID: 109356 RVA: 0x003E39A7 File Offset: 0x003E1BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamMatchInviteResponse Clone()
		{
			return new TeamMatchInviteResponse(this);
		}

		// Token: 0x17005A67 RID: 23143
		// (get) Token: 0x0601AB2D RID: 109357 RVA: 0x003E39AF File Offset: 0x003E1BAF
		// (set) Token: 0x0601AB2E RID: 109358 RVA: 0x003E39B7 File Offset: 0x003E1BB7
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

		// Token: 0x0601AB2F RID: 109359 RVA: 0x003E39C0 File Offset: 0x003E1BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamMatchInviteResponse);
		}

		// Token: 0x0601AB30 RID: 109360 RVA: 0x003E39CE File Offset: 0x003E1BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamMatchInviteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB31 RID: 109361 RVA: 0x003E39FC File Offset: 0x003E1BFC
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

		// Token: 0x0601AB32 RID: 109362 RVA: 0x003E3A41 File Offset: 0x003E1C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB33 RID: 109363 RVA: 0x003E3A4E File Offset: 0x003E1C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB34 RID: 109364 RVA: 0x003E3A57 File Offset: 0x003E1C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB35 RID: 109365 RVA: 0x003E3A8C File Offset: 0x003E1C8C
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

		// Token: 0x0601AB36 RID: 109366 RVA: 0x003E3ACA File Offset: 0x003E1CCA
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

		// Token: 0x0601AB37 RID: 109367 RVA: 0x003E3AFB File Offset: 0x003E1CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB38 RID: 109368 RVA: 0x003E3B04 File Offset: 0x003E1D04
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009C5A RID: 40026
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C5B RID: 40027
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04009C5C RID: 40028
		private ErrorCode errorCode_;
	}
}
