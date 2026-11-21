using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DB RID: 5339
	[NetMessage(EMessageId.TrialRoleRewardResponse)]
	public sealed class TrialRoleRewardResponse : IMessage<TrialRoleRewardResponse>, IMessage, IEquatable<TrialRoleRewardResponse>, IDeepCloneable<TrialRoleRewardResponse>, IBufferMessage
	{
		// Token: 0x0601C51C RID: 115996 RVA: 0x0041C295 File Offset: 0x0041A495
		[NullableContext(1)]
		public static TrialRoleRewardResponse Create()
		{
			return new TrialRoleRewardResponse();
		}

		// Token: 0x17005FDF RID: 24543
		// (get) Token: 0x0601C51D RID: 115997 RVA: 0x0041C29C File Offset: 0x0041A49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FE0 RID: 24544
		// (get) Token: 0x0601C51E RID: 115998 RVA: 0x0041C29F File Offset: 0x0041A49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialRoleRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601C51F RID: 115999 RVA: 0x0041C2A6 File Offset: 0x0041A4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardResponse()
		{
		}

		// Token: 0x0601C520 RID: 116000 RVA: 0x0041C2AE File Offset: 0x0041A4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardResponse(TrialRoleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C521 RID: 116001 RVA: 0x0041C2D3 File Offset: 0x0041A4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardResponse Clone()
		{
			return new TrialRoleRewardResponse(this);
		}

		// Token: 0x17005FE1 RID: 24545
		// (get) Token: 0x0601C522 RID: 116002 RVA: 0x0041C2DB File Offset: 0x0041A4DB
		// (set) Token: 0x0601C523 RID: 116003 RVA: 0x0041C2E3 File Offset: 0x0041A4E3
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

		// Token: 0x0601C524 RID: 116004 RVA: 0x0041C2EC File Offset: 0x0041A4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialRoleRewardResponse);
		}

		// Token: 0x0601C525 RID: 116005 RVA: 0x0041C2FA File Offset: 0x0041A4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialRoleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C526 RID: 116006 RVA: 0x0041C328 File Offset: 0x0041A528
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

		// Token: 0x0601C527 RID: 116007 RVA: 0x0041C36D File Offset: 0x0041A56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C528 RID: 116008 RVA: 0x0041C37A File Offset: 0x0041A57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C529 RID: 116009 RVA: 0x0041C383 File Offset: 0x0041A583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C52A RID: 116010 RVA: 0x0041C3B4 File Offset: 0x0041A5B4
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

		// Token: 0x0601C52B RID: 116011 RVA: 0x0041C3F2 File Offset: 0x0041A5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialRoleRewardResponse other)
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

		// Token: 0x0601C52C RID: 116012 RVA: 0x0041C423 File Offset: 0x0041A623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C52D RID: 116013 RVA: 0x0041C42C File Offset: 0x0041A62C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A3B3 RID: 41907
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3B4 RID: 41908
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400A3B5 RID: 41909
		private ErrorCode errorCode_;
	}
}
