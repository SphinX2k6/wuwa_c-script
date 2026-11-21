using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA2 RID: 4002
	[NetMessage(EMessageId.RoguelikeRoleInstStartResponse)]
	public sealed class RoguelikeRoleInstStartResponse : IMessage<RoguelikeRoleInstStartResponse>, IMessage, IEquatable<RoguelikeRoleInstStartResponse>, IDeepCloneable<RoguelikeRoleInstStartResponse>, IBufferMessage
	{
		// Token: 0x060156E2 RID: 87778 RVA: 0x0031D1BC File Offset: 0x0031B3BC
		[NullableContext(1)]
		public static RoguelikeRoleInstStartResponse Create()
		{
			return new RoguelikeRoleInstStartResponse();
		}

		// Token: 0x1700477A RID: 18298
		// (get) Token: 0x060156E3 RID: 87779 RVA: 0x0031D1C3 File Offset: 0x0031B3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700477B RID: 18299
		// (get) Token: 0x060156E4 RID: 87780 RVA: 0x0031D1C6 File Offset: 0x0031B3C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoleInstStartResponse.Descriptor;
			}
		}

		// Token: 0x060156E5 RID: 87781 RVA: 0x0031D1CD File Offset: 0x0031B3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartResponse()
		{
		}

		// Token: 0x060156E6 RID: 87782 RVA: 0x0031D1D5 File Offset: 0x0031B3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartResponse(RoguelikeRoleInstStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060156E7 RID: 87783 RVA: 0x0031D1FA File Offset: 0x0031B3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleInstStartResponse Clone()
		{
			return new RoguelikeRoleInstStartResponse(this);
		}

		// Token: 0x1700477C RID: 18300
		// (get) Token: 0x060156E8 RID: 87784 RVA: 0x0031D202 File Offset: 0x0031B402
		// (set) Token: 0x060156E9 RID: 87785 RVA: 0x0031D20A File Offset: 0x0031B40A
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

		// Token: 0x060156EA RID: 87786 RVA: 0x0031D213 File Offset: 0x0031B413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoleInstStartResponse);
		}

		// Token: 0x060156EB RID: 87787 RVA: 0x0031D221 File Offset: 0x0031B421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoleInstStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060156EC RID: 87788 RVA: 0x0031D250 File Offset: 0x0031B450
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

		// Token: 0x060156ED RID: 87789 RVA: 0x0031D295 File Offset: 0x0031B495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060156EE RID: 87790 RVA: 0x0031D2A2 File Offset: 0x0031B4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060156EF RID: 87791 RVA: 0x0031D2AB File Offset: 0x0031B4AB
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

		// Token: 0x060156F0 RID: 87792 RVA: 0x0031D2E0 File Offset: 0x0031B4E0
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

		// Token: 0x060156F1 RID: 87793 RVA: 0x0031D31E File Offset: 0x0031B51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeRoleInstStartResponse other)
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

		// Token: 0x060156F2 RID: 87794 RVA: 0x0031D34F File Offset: 0x0031B54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060156F3 RID: 87795 RVA: 0x0031D358 File Offset: 0x0031B558
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

		// Token: 0x0400815B RID: 33115
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400815C RID: 33116
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400815D RID: 33117
		private ErrorCode errorCode_;
	}
}
