using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001208 RID: 4616
	[NetMessage(EMessageId.ShortMessageReceivedResponse)]
	public sealed class ShortMessageReceivedResponse : IMessage<ShortMessageReceivedResponse>, IMessage, IEquatable<ShortMessageReceivedResponse>, IDeepCloneable<ShortMessageReceivedResponse>, IBufferMessage
	{
		// Token: 0x060189B0 RID: 100784 RVA: 0x003941C1 File Offset: 0x003923C1
		[NullableContext(1)]
		public static ShortMessageReceivedResponse Create()
		{
			return new ShortMessageReceivedResponse();
		}

		// Token: 0x170052E7 RID: 21223
		// (get) Token: 0x060189B1 RID: 100785 RVA: 0x003941C8 File Offset: 0x003923C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052E8 RID: 21224
		// (get) Token: 0x060189B2 RID: 100786 RVA: 0x003941CB File Offset: 0x003923CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReceivedResponse.Descriptor;
			}
		}

		// Token: 0x060189B3 RID: 100787 RVA: 0x003941D2 File Offset: 0x003923D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedResponse()
		{
		}

		// Token: 0x060189B4 RID: 100788 RVA: 0x003941DA File Offset: 0x003923DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedResponse(ShortMessageReceivedResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060189B5 RID: 100789 RVA: 0x003941FF File Offset: 0x003923FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedResponse Clone()
		{
			return new ShortMessageReceivedResponse(this);
		}

		// Token: 0x170052E9 RID: 21225
		// (get) Token: 0x060189B6 RID: 100790 RVA: 0x00394207 File Offset: 0x00392407
		// (set) Token: 0x060189B7 RID: 100791 RVA: 0x0039420F File Offset: 0x0039240F
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

		// Token: 0x060189B8 RID: 100792 RVA: 0x00394218 File Offset: 0x00392418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReceivedResponse);
		}

		// Token: 0x060189B9 RID: 100793 RVA: 0x00394226 File Offset: 0x00392426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReceivedResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060189BA RID: 100794 RVA: 0x00394254 File Offset: 0x00392454
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

		// Token: 0x060189BB RID: 100795 RVA: 0x00394299 File Offset: 0x00392499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060189BC RID: 100796 RVA: 0x003942A6 File Offset: 0x003924A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060189BD RID: 100797 RVA: 0x003942AF File Offset: 0x003924AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060189BE RID: 100798 RVA: 0x003942E4 File Offset: 0x003924E4
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

		// Token: 0x060189BF RID: 100799 RVA: 0x00394322 File Offset: 0x00392522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReceivedResponse other)
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

		// Token: 0x060189C0 RID: 100800 RVA: 0x00394353 File Offset: 0x00392553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060189C1 RID: 100801 RVA: 0x0039435C File Offset: 0x0039255C
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400916B RID: 37227
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400916C RID: 37228
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x0400916D RID: 37229
		private ErrorCode errCode_;
	}
}
