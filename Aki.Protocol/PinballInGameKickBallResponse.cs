using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3A RID: 3386
	[NetMessage(EMessageId.PinballInGameKickBallResponse)]
	public sealed class PinballInGameKickBallResponse : IMessage<PinballInGameKickBallResponse>, IMessage, IEquatable<PinballInGameKickBallResponse>, IDeepCloneable<PinballInGameKickBallResponse>, IBufferMessage
	{
		// Token: 0x060124A7 RID: 74919 RVA: 0x002ABBC6 File Offset: 0x002A9DC6
		[NullableContext(1)]
		public static PinballInGameKickBallResponse Create()
		{
			return new PinballInGameKickBallResponse();
		}

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x060124A8 RID: 74920 RVA: 0x002ABBCD File Offset: 0x002A9DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x060124A9 RID: 74921 RVA: 0x002ABBD0 File Offset: 0x002A9DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameKickBallResponse.Descriptor;
			}
		}

		// Token: 0x060124AA RID: 74922 RVA: 0x002ABBD7 File Offset: 0x002A9DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallResponse()
		{
		}

		// Token: 0x060124AB RID: 74923 RVA: 0x002ABBDF File Offset: 0x002A9DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallResponse(PinballInGameKickBallResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060124AC RID: 74924 RVA: 0x002ABC04 File Offset: 0x002A9E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallResponse Clone()
		{
			return new PinballInGameKickBallResponse(this);
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x060124AD RID: 74925 RVA: 0x002ABC0C File Offset: 0x002A9E0C
		// (set) Token: 0x060124AE RID: 74926 RVA: 0x002ABC14 File Offset: 0x002A9E14
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

		// Token: 0x060124AF RID: 74927 RVA: 0x002ABC1D File Offset: 0x002A9E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameKickBallResponse);
		}

		// Token: 0x060124B0 RID: 74928 RVA: 0x002ABC2B File Offset: 0x002A9E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameKickBallResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060124B1 RID: 74929 RVA: 0x002ABC5C File Offset: 0x002A9E5C
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

		// Token: 0x060124B2 RID: 74930 RVA: 0x002ABCA1 File Offset: 0x002A9EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060124B3 RID: 74931 RVA: 0x002ABCAE File Offset: 0x002A9EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060124B4 RID: 74932 RVA: 0x002ABCB7 File Offset: 0x002A9EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060124B5 RID: 74933 RVA: 0x002ABCEC File Offset: 0x002A9EEC
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

		// Token: 0x060124B6 RID: 74934 RVA: 0x002ABD2A File Offset: 0x002A9F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballInGameKickBallResponse other)
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

		// Token: 0x060124B7 RID: 74935 RVA: 0x002ABD5B File Offset: 0x002A9F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060124B8 RID: 74936 RVA: 0x002ABD64 File Offset: 0x002A9F64
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400726A RID: 29290
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400726B RID: 29291
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400726C RID: 29292
		private ErrorCode errorCode_;
	}
}
