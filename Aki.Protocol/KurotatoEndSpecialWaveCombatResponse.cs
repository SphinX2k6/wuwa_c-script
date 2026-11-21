using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000884 RID: 2180
	[NetMessage(EMessageId.KurotatoEndSpecialWaveCombatResponse)]
	public sealed class KurotatoEndSpecialWaveCombatResponse : IMessage<KurotatoEndSpecialWaveCombatResponse>, IMessage, IEquatable<KurotatoEndSpecialWaveCombatResponse>, IDeepCloneable<KurotatoEndSpecialWaveCombatResponse>, IBufferMessage
	{
		// Token: 0x0600C22D RID: 49709 RVA: 0x001CD1DA File Offset: 0x001CB3DA
		[NullableContext(1)]
		public static KurotatoEndSpecialWaveCombatResponse Create()
		{
			return new KurotatoEndSpecialWaveCombatResponse();
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x0600C22E RID: 49710 RVA: 0x001CD1E1 File Offset: 0x001CB3E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x0600C22F RID: 49711 RVA: 0x001CD1E4 File Offset: 0x001CB3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndSpecialWaveCombatResponse.Descriptor;
			}
		}

		// Token: 0x0600C230 RID: 49712 RVA: 0x001CD1EB File Offset: 0x001CB3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatResponse()
		{
		}

		// Token: 0x0600C231 RID: 49713 RVA: 0x001CD1F3 File Offset: 0x001CB3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatResponse(KurotatoEndSpecialWaveCombatResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C232 RID: 49714 RVA: 0x001CD218 File Offset: 0x001CB418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatResponse Clone()
		{
			return new KurotatoEndSpecialWaveCombatResponse(this);
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x0600C233 RID: 49715 RVA: 0x001CD220 File Offset: 0x001CB420
		// (set) Token: 0x0600C234 RID: 49716 RVA: 0x001CD228 File Offset: 0x001CB428
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

		// Token: 0x0600C235 RID: 49717 RVA: 0x001CD231 File Offset: 0x001CB431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndSpecialWaveCombatResponse);
		}

		// Token: 0x0600C236 RID: 49718 RVA: 0x001CD23F File Offset: 0x001CB43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndSpecialWaveCombatResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C237 RID: 49719 RVA: 0x001CD270 File Offset: 0x001CB470
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

		// Token: 0x0600C238 RID: 49720 RVA: 0x001CD2B5 File Offset: 0x001CB4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C239 RID: 49721 RVA: 0x001CD2C2 File Offset: 0x001CB4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C23A RID: 49722 RVA: 0x001CD2CB File Offset: 0x001CB4CB
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

		// Token: 0x0600C23B RID: 49723 RVA: 0x001CD300 File Offset: 0x001CB500
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

		// Token: 0x0600C23C RID: 49724 RVA: 0x001CD33E File Offset: 0x001CB53E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoEndSpecialWaveCombatResponse other)
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

		// Token: 0x0600C23D RID: 49725 RVA: 0x001CD36F File Offset: 0x001CB56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C23E RID: 49726 RVA: 0x001CD378 File Offset: 0x001CB578
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

		// Token: 0x0400546A RID: 21610
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400546B RID: 21611
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400546C RID: 21612
		private ErrorCode errorCode_;
	}
}
