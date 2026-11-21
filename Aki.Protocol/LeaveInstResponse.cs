using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DA RID: 2266
	[NetMessage(EMessageId.LeaveInstResponse)]
	public sealed class LeaveInstResponse : IMessage<LeaveInstResponse>, IMessage, IEquatable<LeaveInstResponse>, IDeepCloneable<LeaveInstResponse>, IBufferMessage
	{
		// Token: 0x0600C8D0 RID: 51408 RVA: 0x001DAEEC File Offset: 0x001D90EC
		[NullableContext(1)]
		public static LeaveInstResponse Create()
		{
			return new LeaveInstResponse();
		}

		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x0600C8D1 RID: 51409 RVA: 0x001DAEF3 File Offset: 0x001D90F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x0600C8D2 RID: 51410 RVA: 0x001DAEF6 File Offset: 0x001D90F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveInstResponse.Descriptor;
			}
		}

		// Token: 0x0600C8D3 RID: 51411 RVA: 0x001DAEFD File Offset: 0x001D90FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstResponse()
		{
		}

		// Token: 0x0600C8D4 RID: 51412 RVA: 0x001DAF05 File Offset: 0x001D9105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstResponse(LeaveInstResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8D5 RID: 51413 RVA: 0x001DAF2A File Offset: 0x001D912A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstResponse Clone()
		{
			return new LeaveInstResponse(this);
		}

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x0600C8D6 RID: 51414 RVA: 0x001DAF32 File Offset: 0x001D9132
		// (set) Token: 0x0600C8D7 RID: 51415 RVA: 0x001DAF3A File Offset: 0x001D913A
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

		// Token: 0x0600C8D8 RID: 51416 RVA: 0x001DAF43 File Offset: 0x001D9143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveInstResponse);
		}

		// Token: 0x0600C8D9 RID: 51417 RVA: 0x001DAF51 File Offset: 0x001D9151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveInstResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8DA RID: 51418 RVA: 0x001DAF80 File Offset: 0x001D9180
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

		// Token: 0x0600C8DB RID: 51419 RVA: 0x001DAFC5 File Offset: 0x001D91C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C8DC RID: 51420 RVA: 0x001DAFD2 File Offset: 0x001D91D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8DD RID: 51421 RVA: 0x001DAFDB File Offset: 0x001D91DB
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

		// Token: 0x0600C8DE RID: 51422 RVA: 0x001DB010 File Offset: 0x001D9210
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

		// Token: 0x0600C8DF RID: 51423 RVA: 0x001DB04E File Offset: 0x001D924E
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

		// Token: 0x0600C8E0 RID: 51424 RVA: 0x001DB07F File Offset: 0x001D927F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8E1 RID: 51425 RVA: 0x001DB088 File Offset: 0x001D9288
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

		// Token: 0x04005613 RID: 22035
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005614 RID: 22036
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04005615 RID: 22037
		private ErrorCode errorCode_;
	}
}
