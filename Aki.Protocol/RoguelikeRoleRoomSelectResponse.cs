using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA5 RID: 4005
	[NetMessage(EMessageId.RoguelikeRoleRoomSelectResponse)]
	public sealed class RoguelikeRoleRoomSelectResponse : IMessage<RoguelikeRoleRoomSelectResponse>, IMessage, IEquatable<RoguelikeRoleRoomSelectResponse>, IDeepCloneable<RoguelikeRoleRoomSelectResponse>, IBufferMessage
	{
		// Token: 0x0601571C RID: 87836 RVA: 0x0031D8DB File Offset: 0x0031BADB
		[NullableContext(1)]
		public static RoguelikeRoleRoomSelectResponse Create()
		{
			return new RoguelikeRoleRoomSelectResponse();
		}

		// Token: 0x17004785 RID: 18309
		// (get) Token: 0x0601571D RID: 87837 RVA: 0x0031D8E2 File Offset: 0x0031BAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004786 RID: 18310
		// (get) Token: 0x0601571E RID: 87838 RVA: 0x0031D8E5 File Offset: 0x0031BAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoleRoomSelectResponse.Descriptor;
			}
		}

		// Token: 0x0601571F RID: 87839 RVA: 0x0031D8EC File Offset: 0x0031BAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectResponse()
		{
		}

		// Token: 0x06015720 RID: 87840 RVA: 0x0031D8F4 File Offset: 0x0031BAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectResponse(RoguelikeRoleRoomSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015721 RID: 87841 RVA: 0x0031D919 File Offset: 0x0031BB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectResponse Clone()
		{
			return new RoguelikeRoleRoomSelectResponse(this);
		}

		// Token: 0x17004787 RID: 18311
		// (get) Token: 0x06015722 RID: 87842 RVA: 0x0031D921 File Offset: 0x0031BB21
		// (set) Token: 0x06015723 RID: 87843 RVA: 0x0031D929 File Offset: 0x0031BB29
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

		// Token: 0x06015724 RID: 87844 RVA: 0x0031D932 File Offset: 0x0031BB32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoleRoomSelectResponse);
		}

		// Token: 0x06015725 RID: 87845 RVA: 0x0031D940 File Offset: 0x0031BB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoleRoomSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015726 RID: 87846 RVA: 0x0031D970 File Offset: 0x0031BB70
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

		// Token: 0x06015727 RID: 87847 RVA: 0x0031D9B5 File Offset: 0x0031BBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015728 RID: 87848 RVA: 0x0031D9C2 File Offset: 0x0031BBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015729 RID: 87849 RVA: 0x0031D9CB File Offset: 0x0031BBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601572A RID: 87850 RVA: 0x0031DA00 File Offset: 0x0031BC00
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

		// Token: 0x0601572B RID: 87851 RVA: 0x0031DA3E File Offset: 0x0031BC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeRoleRoomSelectResponse other)
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

		// Token: 0x0601572C RID: 87852 RVA: 0x0031DA6F File Offset: 0x0031BC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601572D RID: 87853 RVA: 0x0031DA78 File Offset: 0x0031BC78
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008169 RID: 33129
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400816A RID: 33130
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400816B RID: 33131
		private ErrorCode errorCode_;
	}
}
