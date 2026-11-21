using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124B RID: 4683
	[NetMessage(EMessageId.ShortMessageUpdateResponse)]
	public sealed class ShortMessageUpdateResponse : IMessage<ShortMessageUpdateResponse>, IMessage, IEquatable<ShortMessageUpdateResponse>, IDeepCloneable<ShortMessageUpdateResponse>, IBufferMessage
	{
		// Token: 0x06019016 RID: 102422 RVA: 0x003A5333 File Offset: 0x003A3533
		[NullableContext(1)]
		public static ShortMessageUpdateResponse Create()
		{
			return new ShortMessageUpdateResponse();
		}

		// Token: 0x17005481 RID: 21633
		// (get) Token: 0x06019017 RID: 102423 RVA: 0x003A533A File Offset: 0x003A353A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005482 RID: 21634
		// (get) Token: 0x06019018 RID: 102424 RVA: 0x003A533D File Offset: 0x003A353D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06019019 RID: 102425 RVA: 0x003A5344 File Offset: 0x003A3544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateResponse()
		{
		}

		// Token: 0x0601901A RID: 102426 RVA: 0x003A534C File Offset: 0x003A354C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateResponse(ShortMessageUpdateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601901B RID: 102427 RVA: 0x003A5371 File Offset: 0x003A3571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateResponse Clone()
		{
			return new ShortMessageUpdateResponse(this);
		}

		// Token: 0x17005483 RID: 21635
		// (get) Token: 0x0601901C RID: 102428 RVA: 0x003A5379 File Offset: 0x003A3579
		// (set) Token: 0x0601901D RID: 102429 RVA: 0x003A5381 File Offset: 0x003A3581
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

		// Token: 0x0601901E RID: 102430 RVA: 0x003A538A File Offset: 0x003A358A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageUpdateResponse);
		}

		// Token: 0x0601901F RID: 102431 RVA: 0x003A5398 File Offset: 0x003A3598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019020 RID: 102432 RVA: 0x003A53C8 File Offset: 0x003A35C8
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

		// Token: 0x06019021 RID: 102433 RVA: 0x003A540D File Offset: 0x003A360D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019022 RID: 102434 RVA: 0x003A541A File Offset: 0x003A361A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019023 RID: 102435 RVA: 0x003A5423 File Offset: 0x003A3623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019024 RID: 102436 RVA: 0x003A5458 File Offset: 0x003A3658
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

		// Token: 0x06019025 RID: 102437 RVA: 0x003A5496 File Offset: 0x003A3696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageUpdateResponse other)
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

		// Token: 0x06019026 RID: 102438 RVA: 0x003A54C7 File Offset: 0x003A36C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019027 RID: 102439 RVA: 0x003A54D0 File Offset: 0x003A36D0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009444 RID: 37956
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009445 RID: 37957
		public const int ErrCodeFieldNumber = 9;

		// Token: 0x04009446 RID: 37958
		private ErrorCode errCode_;
	}
}
