using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008EB RID: 2283
	[NetMessage(EMessageId.LeaveInstResponse)]
	public sealed class LeaveInstResponse : IMessage<LeaveInstResponse>, IMessage, IEquatable<LeaveInstResponse>, IDeepCloneable<LeaveInstResponse>, IBufferMessage
	{
		// Token: 0x0600C9EC RID: 51692 RVA: 0x001DD1C8 File Offset: 0x001DB3C8
		[NullableContext(1)]
		public static LeaveInstResponse Create()
		{
			return new LeaveInstResponse();
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x0600C9ED RID: 51693 RVA: 0x001DD1CF File Offset: 0x001DB3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x0600C9EE RID: 51694 RVA: 0x001DD1D2 File Offset: 0x001DB3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveInstResponse.Descriptor;
			}
		}

		// Token: 0x0600C9EF RID: 51695 RVA: 0x001DD1D9 File Offset: 0x001DB3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstResponse()
		{
		}

		// Token: 0x0600C9F0 RID: 51696 RVA: 0x001DD1E1 File Offset: 0x001DB3E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstResponse(LeaveInstResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9F1 RID: 51697 RVA: 0x001DD206 File Offset: 0x001DB406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstResponse Clone()
		{
			return new LeaveInstResponse(this);
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x0600C9F2 RID: 51698 RVA: 0x001DD20E File Offset: 0x001DB40E
		// (set) Token: 0x0600C9F3 RID: 51699 RVA: 0x001DD216 File Offset: 0x001DB416
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

		// Token: 0x0600C9F4 RID: 51700 RVA: 0x001DD21F File Offset: 0x001DB41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveInstResponse);
		}

		// Token: 0x0600C9F5 RID: 51701 RVA: 0x001DD22D File Offset: 0x001DB42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveInstResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9F6 RID: 51702 RVA: 0x001DD25C File Offset: 0x001DB45C
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

		// Token: 0x0600C9F7 RID: 51703 RVA: 0x001DD2A1 File Offset: 0x001DB4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C9F8 RID: 51704 RVA: 0x001DD2AE File Offset: 0x001DB4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9F9 RID: 51705 RVA: 0x001DD2B7 File Offset: 0x001DB4B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C9FA RID: 51706 RVA: 0x001DD2EC File Offset: 0x001DB4EC
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

		// Token: 0x0600C9FB RID: 51707 RVA: 0x001DD32A File Offset: 0x001DB52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveInstResponse other)
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

		// Token: 0x0600C9FC RID: 51708 RVA: 0x001DD35B File Offset: 0x001DB55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9FD RID: 51709 RVA: 0x001DD364 File Offset: 0x001DB564
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400560C RID: 22028
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400560D RID: 22029
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400560E RID: 22030
		private ErrorCode errorCode_;
	}
}
