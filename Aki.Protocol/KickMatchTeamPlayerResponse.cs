using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000880 RID: 2176
	[NetMessage(EMessageId.KickMatchTeamPlayerResponse)]
	public sealed class KickMatchTeamPlayerResponse : IMessage<KickMatchTeamPlayerResponse>, IMessage, IEquatable<KickMatchTeamPlayerResponse>, IDeepCloneable<KickMatchTeamPlayerResponse>, IBufferMessage
	{
		// Token: 0x0600C1B8 RID: 49592 RVA: 0x001CC2F1 File Offset: 0x001CA4F1
		[NullableContext(1)]
		public static KickMatchTeamPlayerResponse Create()
		{
			return new KickMatchTeamPlayerResponse();
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x0600C1B9 RID: 49593 RVA: 0x001CC2F8 File Offset: 0x001CA4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x0600C1BA RID: 49594 RVA: 0x001CC2FB File Offset: 0x001CA4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickMatchTeamPlayerResponse.Descriptor;
			}
		}

		// Token: 0x0600C1BB RID: 49595 RVA: 0x001CC302 File Offset: 0x001CA502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerResponse()
		{
		}

		// Token: 0x0600C1BC RID: 49596 RVA: 0x001CC30A File Offset: 0x001CA50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerResponse(KickMatchTeamPlayerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1BD RID: 49597 RVA: 0x001CC32F File Offset: 0x001CA52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickMatchTeamPlayerResponse Clone()
		{
			return new KickMatchTeamPlayerResponse(this);
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x0600C1BE RID: 49598 RVA: 0x001CC337 File Offset: 0x001CA537
		// (set) Token: 0x0600C1BF RID: 49599 RVA: 0x001CC33F File Offset: 0x001CA53F
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

		// Token: 0x0600C1C0 RID: 49600 RVA: 0x001CC348 File Offset: 0x001CA548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickMatchTeamPlayerResponse);
		}

		// Token: 0x0600C1C1 RID: 49601 RVA: 0x001CC356 File Offset: 0x001CA556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KickMatchTeamPlayerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C1C2 RID: 49602 RVA: 0x001CC384 File Offset: 0x001CA584
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

		// Token: 0x0600C1C3 RID: 49603 RVA: 0x001CC3C9 File Offset: 0x001CA5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C1C4 RID: 49604 RVA: 0x001CC3D6 File Offset: 0x001CA5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1C5 RID: 49605 RVA: 0x001CC3DF File Offset: 0x001CA5DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1C6 RID: 49606 RVA: 0x001CC414 File Offset: 0x001CA614
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

		// Token: 0x0600C1C7 RID: 49607 RVA: 0x001CC452 File Offset: 0x001CA652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KickMatchTeamPlayerResponse other)
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

		// Token: 0x0600C1C8 RID: 49608 RVA: 0x001CC483 File Offset: 0x001CA683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1C9 RID: 49609 RVA: 0x001CC48C File Offset: 0x001CA68C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040053FD RID: 21501
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053FE RID: 21502
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040053FF RID: 21503
		private ErrorCode errorCode_;
	}
}
