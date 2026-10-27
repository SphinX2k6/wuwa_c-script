using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB5 RID: 4021
	[NetMessage(EMessageId.RoguelikeRoleRoomSelectResponse)]
	public sealed class RoguelikeRoleRoomSelectResponse : IMessage<RoguelikeRoleRoomSelectResponse>, IMessage, IEquatable<RoguelikeRoleRoomSelectResponse>, IDeepCloneable<RoguelikeRoleRoomSelectResponse>, IBufferMessage
	{
		// Token: 0x06015801 RID: 88065 RVA: 0x0031EF8C File Offset: 0x0031D18C
		[NullableContext(1)]
		public static RoguelikeRoleRoomSelectResponse Create()
		{
			return new RoguelikeRoleRoomSelectResponse();
		}

		// Token: 0x170047AF RID: 18351
		// (get) Token: 0x06015802 RID: 88066 RVA: 0x0031EF93 File Offset: 0x0031D193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047B0 RID: 18352
		// (get) Token: 0x06015803 RID: 88067 RVA: 0x0031EF96 File Offset: 0x0031D196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoleRoomSelectResponse.Descriptor;
			}
		}

		// Token: 0x06015804 RID: 88068 RVA: 0x0031EF9D File Offset: 0x0031D19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectResponse()
		{
		}

		// Token: 0x06015805 RID: 88069 RVA: 0x0031EFA5 File Offset: 0x0031D1A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectResponse(RoguelikeRoleRoomSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015806 RID: 88070 RVA: 0x0031EFCA File Offset: 0x0031D1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomSelectResponse Clone()
		{
			return new RoguelikeRoleRoomSelectResponse(this);
		}

		// Token: 0x170047B1 RID: 18353
		// (get) Token: 0x06015807 RID: 88071 RVA: 0x0031EFD2 File Offset: 0x0031D1D2
		// (set) Token: 0x06015808 RID: 88072 RVA: 0x0031EFDA File Offset: 0x0031D1DA
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

		// Token: 0x06015809 RID: 88073 RVA: 0x0031EFE3 File Offset: 0x0031D1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoleRoomSelectResponse);
		}

		// Token: 0x0601580A RID: 88074 RVA: 0x0031EFF1 File Offset: 0x0031D1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoleRoomSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601580B RID: 88075 RVA: 0x0031F020 File Offset: 0x0031D220
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

		// Token: 0x0601580C RID: 88076 RVA: 0x0031F065 File Offset: 0x0031D265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601580D RID: 88077 RVA: 0x0031F072 File Offset: 0x0031D272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601580E RID: 88078 RVA: 0x0031F07B File Offset: 0x0031D27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601580F RID: 88079 RVA: 0x0031F0B0 File Offset: 0x0031D2B0
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

		// Token: 0x06015810 RID: 88080 RVA: 0x0031F0EE File Offset: 0x0031D2EE
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

		// Token: 0x06015811 RID: 88081 RVA: 0x0031F11F File Offset: 0x0031D31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015812 RID: 88082 RVA: 0x0031F128 File Offset: 0x0031D328
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400813F RID: 33087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008140 RID: 33088
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04008141 RID: 33089
		private ErrorCode errorCode_;
	}
}
