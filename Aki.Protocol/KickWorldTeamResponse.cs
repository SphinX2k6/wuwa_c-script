using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000882 RID: 2178
	[NetMessage(EMessageId.KickWorldTeamResponse)]
	public sealed class KickWorldTeamResponse : IMessage<KickWorldTeamResponse>, IMessage, IEquatable<KickWorldTeamResponse>, IDeepCloneable<KickWorldTeamResponse>, IBufferMessage
	{
		// Token: 0x0600C1DC RID: 49628 RVA: 0x001CC6A8 File Offset: 0x001CA8A8
		[NullableContext(1)]
		public static KickWorldTeamResponse Create()
		{
			return new KickWorldTeamResponse();
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x0600C1DD RID: 49629 RVA: 0x001CC6AF File Offset: 0x001CA8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x0600C1DE RID: 49630 RVA: 0x001CC6B2 File Offset: 0x001CA8B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KickWorldTeamResponse.Descriptor;
			}
		}

		// Token: 0x0600C1DF RID: 49631 RVA: 0x001CC6B9 File Offset: 0x001CA8B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamResponse()
		{
		}

		// Token: 0x0600C1E0 RID: 49632 RVA: 0x001CC6C1 File Offset: 0x001CA8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamResponse(KickWorldTeamResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1E1 RID: 49633 RVA: 0x001CC6E6 File Offset: 0x001CA8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KickWorldTeamResponse Clone()
		{
			return new KickWorldTeamResponse(this);
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x0600C1E2 RID: 49634 RVA: 0x001CC6EE File Offset: 0x001CA8EE
		// (set) Token: 0x0600C1E3 RID: 49635 RVA: 0x001CC6F6 File Offset: 0x001CA8F6
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

		// Token: 0x0600C1E4 RID: 49636 RVA: 0x001CC6FF File Offset: 0x001CA8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KickWorldTeamResponse);
		}

		// Token: 0x0600C1E5 RID: 49637 RVA: 0x001CC70D File Offset: 0x001CA90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KickWorldTeamResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C1E6 RID: 49638 RVA: 0x001CC73C File Offset: 0x001CA93C
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

		// Token: 0x0600C1E7 RID: 49639 RVA: 0x001CC781 File Offset: 0x001CA981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C1E8 RID: 49640 RVA: 0x001CC78E File Offset: 0x001CA98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1E9 RID: 49641 RVA: 0x001CC797 File Offset: 0x001CA997
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

		// Token: 0x0600C1EA RID: 49642 RVA: 0x001CC7CC File Offset: 0x001CA9CC
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

		// Token: 0x0600C1EB RID: 49643 RVA: 0x001CC80A File Offset: 0x001CAA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KickWorldTeamResponse other)
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

		// Token: 0x0600C1EC RID: 49644 RVA: 0x001CC83B File Offset: 0x001CAA3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1ED RID: 49645 RVA: 0x001CC844 File Offset: 0x001CAA44
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

		// Token: 0x04005403 RID: 21507
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005404 RID: 21508
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04005405 RID: 21509
		private ErrorCode errorCode_;
	}
}
