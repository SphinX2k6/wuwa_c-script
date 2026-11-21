using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120A RID: 4618
	[NetMessage(EMessageId.SetFanNumberOfTurnsResponse)]
	public sealed class SetFanNumberOfTurnsResponse : IMessage<SetFanNumberOfTurnsResponse>, IMessage, IEquatable<SetFanNumberOfTurnsResponse>, IDeepCloneable<SetFanNumberOfTurnsResponse>, IBufferMessage
	{
		// Token: 0x06018AC5 RID: 101061 RVA: 0x003992DC File Offset: 0x003974DC
		[NullableContext(1)]
		public static SetFanNumberOfTurnsResponse Create()
		{
			return new SetFanNumberOfTurnsResponse();
		}

		// Token: 0x17005355 RID: 21333
		// (get) Token: 0x06018AC6 RID: 101062 RVA: 0x003992E3 File Offset: 0x003974E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005356 RID: 21334
		// (get) Token: 0x06018AC7 RID: 101063 RVA: 0x003992E6 File Offset: 0x003974E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFanNumberOfTurnsResponse.Descriptor;
			}
		}

		// Token: 0x06018AC8 RID: 101064 RVA: 0x003992ED File Offset: 0x003974ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsResponse()
		{
		}

		// Token: 0x06018AC9 RID: 101065 RVA: 0x003992F5 File Offset: 0x003974F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsResponse(SetFanNumberOfTurnsResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018ACA RID: 101066 RVA: 0x0039931A File Offset: 0x0039751A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsResponse Clone()
		{
			return new SetFanNumberOfTurnsResponse(this);
		}

		// Token: 0x17005357 RID: 21335
		// (get) Token: 0x06018ACB RID: 101067 RVA: 0x00399322 File Offset: 0x00397522
		// (set) Token: 0x06018ACC RID: 101068 RVA: 0x0039932A File Offset: 0x0039752A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06018ACD RID: 101069 RVA: 0x00399333 File Offset: 0x00397533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFanNumberOfTurnsResponse);
		}

		// Token: 0x06018ACE RID: 101070 RVA: 0x00399341 File Offset: 0x00397541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFanNumberOfTurnsResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018ACF RID: 101071 RVA: 0x00399370 File Offset: 0x00397570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018AD0 RID: 101072 RVA: 0x003993B5 File Offset: 0x003975B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018AD1 RID: 101073 RVA: 0x003993C2 File Offset: 0x003975C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018AD2 RID: 101074 RVA: 0x003993CB File Offset: 0x003975CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018AD3 RID: 101075 RVA: 0x003993FC File Offset: 0x003975FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018AD4 RID: 101076 RVA: 0x0039943A File Offset: 0x0039763A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFanNumberOfTurnsResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018AD5 RID: 101077 RVA: 0x0039946B File Offset: 0x0039766B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018AD6 RID: 101078 RVA: 0x00399474 File Offset: 0x00397674
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009297 RID: 37527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009298 RID: 37528
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04009299 RID: 37529
		private ErrorCode errCode_;
	}
}
