using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A9 RID: 1705
	[NetMessage(EMessageId.GameplayCueResponse)]
	public sealed class GameplayCueResponse : IMessage<GameplayCueResponse>, IMessage, IEquatable<GameplayCueResponse>, IDeepCloneable<GameplayCueResponse>, IBufferMessage
	{
		// Token: 0x06009C7C RID: 40060 RVA: 0x0017CF51 File Offset: 0x0017B151
		[NullableContext(1)]
		public static GameplayCueResponse Create()
		{
			return new GameplayCueResponse();
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06009C7D RID: 40061 RVA: 0x0017CF58 File Offset: 0x0017B158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06009C7E RID: 40062 RVA: 0x0017CF5B File Offset: 0x0017B15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCueResponse.Descriptor;
			}
		}

		// Token: 0x06009C7F RID: 40063 RVA: 0x0017CF62 File Offset: 0x0017B162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueResponse()
		{
		}

		// Token: 0x06009C80 RID: 40064 RVA: 0x0017CF6A File Offset: 0x0017B16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueResponse(GameplayCueResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C81 RID: 40065 RVA: 0x0017CF8F File Offset: 0x0017B18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueResponse Clone()
		{
			return new GameplayCueResponse(this);
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06009C82 RID: 40066 RVA: 0x0017CF97 File Offset: 0x0017B197
		// (set) Token: 0x06009C83 RID: 40067 RVA: 0x0017CF9F File Offset: 0x0017B19F
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

		// Token: 0x06009C84 RID: 40068 RVA: 0x0017CFA8 File Offset: 0x0017B1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCueResponse);
		}

		// Token: 0x06009C85 RID: 40069 RVA: 0x0017CFB6 File Offset: 0x0017B1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCueResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C86 RID: 40070 RVA: 0x0017CFE4 File Offset: 0x0017B1E4
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

		// Token: 0x06009C87 RID: 40071 RVA: 0x0017D029 File Offset: 0x0017B229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C88 RID: 40072 RVA: 0x0017D036 File Offset: 0x0017B236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C89 RID: 40073 RVA: 0x0017D03F File Offset: 0x0017B23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C8A RID: 40074 RVA: 0x0017D074 File Offset: 0x0017B274
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

		// Token: 0x06009C8B RID: 40075 RVA: 0x0017D0B2 File Offset: 0x0017B2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCueResponse other)
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

		// Token: 0x06009C8C RID: 40076 RVA: 0x0017D0E3 File Offset: 0x0017B2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C8D RID: 40077 RVA: 0x0017D0EC File Offset: 0x0017B2EC
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040049C6 RID: 18886
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049C7 RID: 18887
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040049C8 RID: 18888
		private ErrorCode errorCode_;
	}
}
