using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001139 RID: 4409
	[NetMessage(EMessageId.RTimeStopInstResponse)]
	public sealed class RTimeStopInstResponse : IMessage<RTimeStopInstResponse>, IMessage, IEquatable<RTimeStopInstResponse>, IDeepCloneable<RTimeStopInstResponse>, IBufferMessage
	{
		// Token: 0x06017838 RID: 96312 RVA: 0x0036A2F8 File Offset: 0x003684F8
		[NullableContext(1)]
		public static RTimeStopInstResponse Create()
		{
			return new RTimeStopInstResponse();
		}

		// Token: 0x17004EEB RID: 20203
		// (get) Token: 0x06017839 RID: 96313 RVA: 0x0036A2FF File Offset: 0x003684FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EEC RID: 20204
		// (get) Token: 0x0601783A RID: 96314 RVA: 0x0036A302 File Offset: 0x00368502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopInstResponse.Descriptor;
			}
		}

		// Token: 0x0601783B RID: 96315 RVA: 0x0036A309 File Offset: 0x00368509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstResponse()
		{
		}

		// Token: 0x0601783C RID: 96316 RVA: 0x0036A311 File Offset: 0x00368511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstResponse(RTimeStopInstResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601783D RID: 96317 RVA: 0x0036A336 File Offset: 0x00368536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstResponse Clone()
		{
			return new RTimeStopInstResponse(this);
		}

		// Token: 0x17004EED RID: 20205
		// (get) Token: 0x0601783E RID: 96318 RVA: 0x0036A33E File Offset: 0x0036853E
		// (set) Token: 0x0601783F RID: 96319 RVA: 0x0036A346 File Offset: 0x00368546
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

		// Token: 0x06017840 RID: 96320 RVA: 0x0036A34F File Offset: 0x0036854F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopInstResponse);
		}

		// Token: 0x06017841 RID: 96321 RVA: 0x0036A35D File Offset: 0x0036855D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopInstResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017842 RID: 96322 RVA: 0x0036A38C File Offset: 0x0036858C
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

		// Token: 0x06017843 RID: 96323 RVA: 0x0036A3D1 File Offset: 0x003685D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017844 RID: 96324 RVA: 0x0036A3DE File Offset: 0x003685DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017845 RID: 96325 RVA: 0x0036A3E7 File Offset: 0x003685E7
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

		// Token: 0x06017846 RID: 96326 RVA: 0x0036A41C File Offset: 0x0036861C
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

		// Token: 0x06017847 RID: 96327 RVA: 0x0036A45A File Offset: 0x0036865A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopInstResponse other)
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

		// Token: 0x06017848 RID: 96328 RVA: 0x0036A48B File Offset: 0x0036868B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017849 RID: 96329 RVA: 0x0036A494 File Offset: 0x00368694
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

		// Token: 0x04008BBB RID: 35771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BBC RID: 35772
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04008BBD RID: 35773
		private ErrorCode errorCode_;
	}
}
