using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A8 RID: 936
	[NetMessage(EMessageId.DarkTideItemMarkResponse)]
	public sealed class DarkTideItemMarkResponse : IMessage<DarkTideItemMarkResponse>, IMessage, IEquatable<DarkTideItemMarkResponse>, IDeepCloneable<DarkTideItemMarkResponse>, IBufferMessage
	{
		// Token: 0x06005C09 RID: 23561 RVA: 0x000DFA4C File Offset: 0x000DDC4C
		[NullableContext(1)]
		public static DarkTideItemMarkResponse Create()
		{
			return new DarkTideItemMarkResponse();
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06005C0A RID: 23562 RVA: 0x000DFA53 File Offset: 0x000DDC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06005C0B RID: 23563 RVA: 0x000DFA56 File Offset: 0x000DDC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideItemMarkResponse.Descriptor;
			}
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x000DFA5D File Offset: 0x000DDC5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkResponse()
		{
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x000DFA65 File Offset: 0x000DDC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkResponse(DarkTideItemMarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C0E RID: 23566 RVA: 0x000DFA8A File Offset: 0x000DDC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkResponse Clone()
		{
			return new DarkTideItemMarkResponse(this);
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06005C0F RID: 23567 RVA: 0x000DFA92 File Offset: 0x000DDC92
		// (set) Token: 0x06005C10 RID: 23568 RVA: 0x000DFA9A File Offset: 0x000DDC9A
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

		// Token: 0x06005C11 RID: 23569 RVA: 0x000DFAA3 File Offset: 0x000DDCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideItemMarkResponse);
		}

		// Token: 0x06005C12 RID: 23570 RVA: 0x000DFAB1 File Offset: 0x000DDCB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideItemMarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C13 RID: 23571 RVA: 0x000DFAE0 File Offset: 0x000DDCE0
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

		// Token: 0x06005C14 RID: 23572 RVA: 0x000DFB25 File Offset: 0x000DDD25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C15 RID: 23573 RVA: 0x000DFB32 File Offset: 0x000DDD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C16 RID: 23574 RVA: 0x000DFB3B File Offset: 0x000DDD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C17 RID: 23575 RVA: 0x000DFB70 File Offset: 0x000DDD70
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

		// Token: 0x06005C18 RID: 23576 RVA: 0x000DFBAE File Offset: 0x000DDDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideItemMarkResponse other)
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

		// Token: 0x06005C19 RID: 23577 RVA: 0x000DFBDF File Offset: 0x000DDDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C1A RID: 23578 RVA: 0x000DFBE8 File Offset: 0x000DDDE8
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003629 RID: 13865
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400362A RID: 13866
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400362B RID: 13867
		private ErrorCode errorCode_;
	}
}
