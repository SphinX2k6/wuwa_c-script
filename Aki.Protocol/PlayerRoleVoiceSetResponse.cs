using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9A RID: 3482
	[NetMessage(EMessageId.PlayerRoleVoiceSetResponse)]
	public sealed class PlayerRoleVoiceSetResponse : IMessage<PlayerRoleVoiceSetResponse>, IMessage, IEquatable<PlayerRoleVoiceSetResponse>, IDeepCloneable<PlayerRoleVoiceSetResponse>, IBufferMessage
	{
		// Token: 0x06012C90 RID: 76944 RVA: 0x002BDF65 File Offset: 0x002BC165
		[NullableContext(1)]
		public static PlayerRoleVoiceSetResponse Create()
		{
			return new PlayerRoleVoiceSetResponse();
		}

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x06012C91 RID: 76945 RVA: 0x002BDF6C File Offset: 0x002BC16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x06012C92 RID: 76946 RVA: 0x002BDF6F File Offset: 0x002BC16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerRoleVoiceSetResponse.Descriptor;
			}
		}

		// Token: 0x06012C93 RID: 76947 RVA: 0x002BDF76 File Offset: 0x002BC176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetResponse()
		{
		}

		// Token: 0x06012C94 RID: 76948 RVA: 0x002BDF7E File Offset: 0x002BC17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetResponse(PlayerRoleVoiceSetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C95 RID: 76949 RVA: 0x002BDFA3 File Offset: 0x002BC1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetResponse Clone()
		{
			return new PlayerRoleVoiceSetResponse(this);
		}

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x06012C96 RID: 76950 RVA: 0x002BDFAB File Offset: 0x002BC1AB
		// (set) Token: 0x06012C97 RID: 76951 RVA: 0x002BDFB3 File Offset: 0x002BC1B3
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

		// Token: 0x06012C98 RID: 76952 RVA: 0x002BDFBC File Offset: 0x002BC1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerRoleVoiceSetResponse);
		}

		// Token: 0x06012C99 RID: 76953 RVA: 0x002BDFCA File Offset: 0x002BC1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerRoleVoiceSetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C9A RID: 76954 RVA: 0x002BDFF8 File Offset: 0x002BC1F8
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

		// Token: 0x06012C9B RID: 76955 RVA: 0x002BE03D File Offset: 0x002BC23D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C9C RID: 76956 RVA: 0x002BE04A File Offset: 0x002BC24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C9D RID: 76957 RVA: 0x002BE053 File Offset: 0x002BC253
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

		// Token: 0x06012C9E RID: 76958 RVA: 0x002BE088 File Offset: 0x002BC288
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

		// Token: 0x06012C9F RID: 76959 RVA: 0x002BE0C6 File Offset: 0x002BC2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerRoleVoiceSetResponse other)
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

		// Token: 0x06012CA0 RID: 76960 RVA: 0x002BE0F7 File Offset: 0x002BC2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012CA1 RID: 76961 RVA: 0x002BE100 File Offset: 0x002BC300
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

		// Token: 0x040074BF RID: 29887
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074C0 RID: 29888
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040074C1 RID: 29889
		private ErrorCode errorCode_;
	}
}
