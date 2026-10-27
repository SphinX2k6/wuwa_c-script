using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DC RID: 4316
	[NetMessage(EMessageId.RollBlockGamePlayReadyResponse)]
	public sealed class RollBlockGamePlayReadyResponse : IMessage<RollBlockGamePlayReadyResponse>, IMessage, IEquatable<RollBlockGamePlayReadyResponse>, IDeepCloneable<RollBlockGamePlayReadyResponse>, IBufferMessage
	{
		// Token: 0x0601706F RID: 94319 RVA: 0x00357B91 File Offset: 0x00355D91
		[NullableContext(1)]
		public static RollBlockGamePlayReadyResponse Create()
		{
			return new RollBlockGamePlayReadyResponse();
		}

		// Token: 0x17004D26 RID: 19750
		// (get) Token: 0x06017070 RID: 94320 RVA: 0x00357B98 File Offset: 0x00355D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D27 RID: 19751
		// (get) Token: 0x06017071 RID: 94321 RVA: 0x00357B9B File Offset: 0x00355D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockGamePlayReadyResponse.Descriptor;
			}
		}

		// Token: 0x06017072 RID: 94322 RVA: 0x00357BA2 File Offset: 0x00355DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyResponse()
		{
		}

		// Token: 0x06017073 RID: 94323 RVA: 0x00357BAA File Offset: 0x00355DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyResponse(RollBlockGamePlayReadyResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017074 RID: 94324 RVA: 0x00357BCF File Offset: 0x00355DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyResponse Clone()
		{
			return new RollBlockGamePlayReadyResponse(this);
		}

		// Token: 0x17004D28 RID: 19752
		// (get) Token: 0x06017075 RID: 94325 RVA: 0x00357BD7 File Offset: 0x00355DD7
		// (set) Token: 0x06017076 RID: 94326 RVA: 0x00357BDF File Offset: 0x00355DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06017077 RID: 94327 RVA: 0x00357BE8 File Offset: 0x00355DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockGamePlayReadyResponse);
		}

		// Token: 0x06017078 RID: 94328 RVA: 0x00357BF6 File Offset: 0x00355DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockGamePlayReadyResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017079 RID: 94329 RVA: 0x00357C24 File Offset: 0x00355E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601707A RID: 94330 RVA: 0x00357C69 File Offset: 0x00355E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601707B RID: 94331 RVA: 0x00357C76 File Offset: 0x00355E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601707C RID: 94332 RVA: 0x00357C7F File Offset: 0x00355E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601707D RID: 94333 RVA: 0x00357CB4 File Offset: 0x00355EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601707E RID: 94334 RVA: 0x00357CF2 File Offset: 0x00355EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockGamePlayReadyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601707F RID: 94335 RVA: 0x00357D23 File Offset: 0x00355F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017080 RID: 94336 RVA: 0x00357D2C File Offset: 0x00355F2C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400891C RID: 35100
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400891D RID: 35101
		public const int CodeFieldNumber = 13;

		// Token: 0x0400891E RID: 35102
		private ErrorCode code_;
	}
}
