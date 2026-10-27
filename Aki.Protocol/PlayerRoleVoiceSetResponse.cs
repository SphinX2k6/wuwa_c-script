using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAA RID: 3498
	[NetMessage(EMessageId.PlayerRoleVoiceSetResponse)]
	public sealed class PlayerRoleVoiceSetResponse : IMessage<PlayerRoleVoiceSetResponse>, IMessage, IEquatable<PlayerRoleVoiceSetResponse>, IDeepCloneable<PlayerRoleVoiceSetResponse>, IBufferMessage
	{
		// Token: 0x06012D8C RID: 77196 RVA: 0x002BFB89 File Offset: 0x002BDD89
		[NullableContext(1)]
		public static PlayerRoleVoiceSetResponse Create()
		{
			return new PlayerRoleVoiceSetResponse();
		}

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x06012D8D RID: 77197 RVA: 0x002BFB90 File Offset: 0x002BDD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x06012D8E RID: 77198 RVA: 0x002BFB93 File Offset: 0x002BDD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerRoleVoiceSetResponse.Descriptor;
			}
		}

		// Token: 0x06012D8F RID: 77199 RVA: 0x002BFB9A File Offset: 0x002BDD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetResponse()
		{
		}

		// Token: 0x06012D90 RID: 77200 RVA: 0x002BFBA2 File Offset: 0x002BDDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetResponse(PlayerRoleVoiceSetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D91 RID: 77201 RVA: 0x002BFBC7 File Offset: 0x002BDDC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRoleVoiceSetResponse Clone()
		{
			return new PlayerRoleVoiceSetResponse(this);
		}

		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x06012D92 RID: 77202 RVA: 0x002BFBCF File Offset: 0x002BDDCF
		// (set) Token: 0x06012D93 RID: 77203 RVA: 0x002BFBD7 File Offset: 0x002BDDD7
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

		// Token: 0x06012D94 RID: 77204 RVA: 0x002BFBE0 File Offset: 0x002BDDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerRoleVoiceSetResponse);
		}

		// Token: 0x06012D95 RID: 77205 RVA: 0x002BFBEE File Offset: 0x002BDDEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerRoleVoiceSetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D96 RID: 77206 RVA: 0x002BFC1C File Offset: 0x002BDE1C
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

		// Token: 0x06012D97 RID: 77207 RVA: 0x002BFC61 File Offset: 0x002BDE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D98 RID: 77208 RVA: 0x002BFC6E File Offset: 0x002BDE6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D99 RID: 77209 RVA: 0x002BFC77 File Offset: 0x002BDE77
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

		// Token: 0x06012D9A RID: 77210 RVA: 0x002BFCAC File Offset: 0x002BDEAC
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

		// Token: 0x06012D9B RID: 77211 RVA: 0x002BFCEA File Offset: 0x002BDEEA
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

		// Token: 0x06012D9C RID: 77212 RVA: 0x002BFD1B File Offset: 0x002BDF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D9D RID: 77213 RVA: 0x002BFD24 File Offset: 0x002BDF24
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

		// Token: 0x040074A7 RID: 29863
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074A8 RID: 29864
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040074A9 RID: 29865
		private ErrorCode errorCode_;
	}
}
