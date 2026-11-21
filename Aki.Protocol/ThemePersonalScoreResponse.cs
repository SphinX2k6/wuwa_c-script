using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CE RID: 5070
	[NetMessage(EMessageId.ThemePersonalScoreResponse)]
	public sealed class ThemePersonalScoreResponse : IMessage<ThemePersonalScoreResponse>, IMessage, IEquatable<ThemePersonalScoreResponse>, IDeepCloneable<ThemePersonalScoreResponse>, IBufferMessage
	{
		// Token: 0x0601AFB6 RID: 110518 RVA: 0x003EE1F9 File Offset: 0x003EC3F9
		[NullableContext(1)]
		public static ThemePersonalScoreResponse Create()
		{
			return new ThemePersonalScoreResponse();
		}

		// Token: 0x17005B66 RID: 23398
		// (get) Token: 0x0601AFB7 RID: 110519 RVA: 0x003EE200 File Offset: 0x003EC400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B67 RID: 23399
		// (get) Token: 0x0601AFB8 RID: 110520 RVA: 0x003EE203 File Offset: 0x003EC403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemePersonalScoreResponse.Descriptor;
			}
		}

		// Token: 0x0601AFB9 RID: 110521 RVA: 0x003EE20A File Offset: 0x003EC40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreResponse()
		{
		}

		// Token: 0x0601AFBA RID: 110522 RVA: 0x003EE212 File Offset: 0x003EC412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreResponse(ThemePersonalScoreResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AFBB RID: 110523 RVA: 0x003EE237 File Offset: 0x003EC437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemePersonalScoreResponse Clone()
		{
			return new ThemePersonalScoreResponse(this);
		}

		// Token: 0x17005B68 RID: 23400
		// (get) Token: 0x0601AFBC RID: 110524 RVA: 0x003EE23F File Offset: 0x003EC43F
		// (set) Token: 0x0601AFBD RID: 110525 RVA: 0x003EE247 File Offset: 0x003EC447
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

		// Token: 0x0601AFBE RID: 110526 RVA: 0x003EE250 File Offset: 0x003EC450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemePersonalScoreResponse);
		}

		// Token: 0x0601AFBF RID: 110527 RVA: 0x003EE25E File Offset: 0x003EC45E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemePersonalScoreResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AFC0 RID: 110528 RVA: 0x003EE28C File Offset: 0x003EC48C
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

		// Token: 0x0601AFC1 RID: 110529 RVA: 0x003EE2D1 File Offset: 0x003EC4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AFC2 RID: 110530 RVA: 0x003EE2DE File Offset: 0x003EC4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AFC3 RID: 110531 RVA: 0x003EE2E7 File Offset: 0x003EC4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AFC4 RID: 110532 RVA: 0x003EE31C File Offset: 0x003EC51C
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

		// Token: 0x0601AFC5 RID: 110533 RVA: 0x003EE35A File Offset: 0x003EC55A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemePersonalScoreResponse other)
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

		// Token: 0x0601AFC6 RID: 110534 RVA: 0x003EE38B File Offset: 0x003EC58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFC7 RID: 110535 RVA: 0x003EE394 File Offset: 0x003EC594
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009DC0 RID: 40384
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DC1 RID: 40385
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04009DC2 RID: 40386
		private ErrorCode errorCode_;
	}
}
