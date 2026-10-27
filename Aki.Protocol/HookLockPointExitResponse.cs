using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B5 RID: 1973
	[NetMessage(EMessageId.HookLockPointExitResponse)]
	public sealed class HookLockPointExitResponse : IMessage<HookLockPointExitResponse>, IMessage, IEquatable<HookLockPointExitResponse>, IDeepCloneable<HookLockPointExitResponse>, IBufferMessage
	{
		// Token: 0x0600B1AF RID: 45487 RVA: 0x001A9E04 File Offset: 0x001A8004
		[NullableContext(1)]
		public static HookLockPointExitResponse Create()
		{
			return new HookLockPointExitResponse();
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x0600B1B0 RID: 45488 RVA: 0x001A9E0B File Offset: 0x001A800B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x0600B1B1 RID: 45489 RVA: 0x001A9E0E File Offset: 0x001A800E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointExitResponse.Descriptor;
			}
		}

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x001A9E15 File Offset: 0x001A8015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitResponse()
		{
		}

		// Token: 0x0600B1B3 RID: 45491 RVA: 0x001A9E1D File Offset: 0x001A801D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitResponse(HookLockPointExitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1B4 RID: 45492 RVA: 0x001A9E42 File Offset: 0x001A8042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitResponse Clone()
		{
			return new HookLockPointExitResponse(this);
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x0600B1B5 RID: 45493 RVA: 0x001A9E4A File Offset: 0x001A804A
		// (set) Token: 0x0600B1B6 RID: 45494 RVA: 0x001A9E52 File Offset: 0x001A8052
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

		// Token: 0x0600B1B7 RID: 45495 RVA: 0x001A9E5B File Offset: 0x001A805B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointExitResponse);
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x001A9E69 File Offset: 0x001A8069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointExitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x001A9E98 File Offset: 0x001A8098
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

		// Token: 0x0600B1BA RID: 45498 RVA: 0x001A9EDD File Offset: 0x001A80DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B1BB RID: 45499 RVA: 0x001A9EEA File Offset: 0x001A80EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1BC RID: 45500 RVA: 0x001A9EF3 File Offset: 0x001A80F3
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

		// Token: 0x0600B1BD RID: 45501 RVA: 0x001A9F28 File Offset: 0x001A8128
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

		// Token: 0x0600B1BE RID: 45502 RVA: 0x001A9F66 File Offset: 0x001A8166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointExitResponse other)
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

		// Token: 0x0600B1BF RID: 45503 RVA: 0x001A9F97 File Offset: 0x001A8197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1C0 RID: 45504 RVA: 0x001A9FA0 File Offset: 0x001A81A0
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

		// Token: 0x04004F9D RID: 20381
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F9E RID: 20382
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004F9F RID: 20383
		private ErrorCode errorCode_;
	}
}
