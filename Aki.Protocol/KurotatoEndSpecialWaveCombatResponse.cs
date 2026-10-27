using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000895 RID: 2197
	[NetMessage(EMessageId.KurotatoEndSpecialWaveCombatResponse)]
	public sealed class KurotatoEndSpecialWaveCombatResponse : IMessage<KurotatoEndSpecialWaveCombatResponse>, IMessage, IEquatable<KurotatoEndSpecialWaveCombatResponse>, IDeepCloneable<KurotatoEndSpecialWaveCombatResponse>, IBufferMessage
	{
		// Token: 0x0600C349 RID: 49993 RVA: 0x001CF4C2 File Offset: 0x001CD6C2
		[NullableContext(1)]
		public static KurotatoEndSpecialWaveCombatResponse Create()
		{
			return new KurotatoEndSpecialWaveCombatResponse();
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x0600C34A RID: 49994 RVA: 0x001CF4C9 File Offset: 0x001CD6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x0600C34B RID: 49995 RVA: 0x001CF4CC File Offset: 0x001CD6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndSpecialWaveCombatResponse.Descriptor;
			}
		}

		// Token: 0x0600C34C RID: 49996 RVA: 0x001CF4D3 File Offset: 0x001CD6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatResponse()
		{
		}

		// Token: 0x0600C34D RID: 49997 RVA: 0x001CF4DB File Offset: 0x001CD6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatResponse(KurotatoEndSpecialWaveCombatResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C34E RID: 49998 RVA: 0x001CF500 File Offset: 0x001CD700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatResponse Clone()
		{
			return new KurotatoEndSpecialWaveCombatResponse(this);
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x0600C34F RID: 49999 RVA: 0x001CF508 File Offset: 0x001CD708
		// (set) Token: 0x0600C350 RID: 50000 RVA: 0x001CF510 File Offset: 0x001CD710
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

		// Token: 0x0600C351 RID: 50001 RVA: 0x001CF519 File Offset: 0x001CD719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndSpecialWaveCombatResponse);
		}

		// Token: 0x0600C352 RID: 50002 RVA: 0x001CF527 File Offset: 0x001CD727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndSpecialWaveCombatResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C353 RID: 50003 RVA: 0x001CF558 File Offset: 0x001CD758
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

		// Token: 0x0600C354 RID: 50004 RVA: 0x001CF59D File Offset: 0x001CD79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C355 RID: 50005 RVA: 0x001CF5AA File Offset: 0x001CD7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C356 RID: 50006 RVA: 0x001CF5B3 File Offset: 0x001CD7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C357 RID: 50007 RVA: 0x001CF5E8 File Offset: 0x001CD7E8
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

		// Token: 0x0600C358 RID: 50008 RVA: 0x001CF626 File Offset: 0x001CD826
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

		// Token: 0x0600C359 RID: 50009 RVA: 0x001CF657 File Offset: 0x001CD857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C35A RID: 50010 RVA: 0x001CF660 File Offset: 0x001CD860
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005463 RID: 21603
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005464 RID: 21604
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005465 RID: 21605
		private ErrorCode errorCode_;
	}
}
