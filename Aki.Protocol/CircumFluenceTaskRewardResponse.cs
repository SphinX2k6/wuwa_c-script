using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029B RID: 667
	[NetMessage(EMessageId.CircumFluenceTaskRewardResponse)]
	public sealed class CircumFluenceTaskRewardResponse : IMessage<CircumFluenceTaskRewardResponse>, IMessage, IEquatable<CircumFluenceTaskRewardResponse>, IDeepCloneable<CircumFluenceTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060045A3 RID: 17827 RVA: 0x000AB12E File Offset: 0x000A932E
		[NullableContext(1)]
		public static CircumFluenceTaskRewardResponse Create()
		{
			return new CircumFluenceTaskRewardResponse();
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x000AB135 File Offset: 0x000A9335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060045A5 RID: 17829 RVA: 0x000AB138 File Offset: 0x000A9338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CircumFluenceTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x000AB13F File Offset: 0x000A933F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardResponse()
		{
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x000AB147 File Offset: 0x000A9347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardResponse(CircumFluenceTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x000AB16C File Offset: 0x000A936C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardResponse Clone()
		{
			return new CircumFluenceTaskRewardResponse(this);
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x000AB174 File Offset: 0x000A9374
		// (set) Token: 0x060045AA RID: 17834 RVA: 0x000AB17C File Offset: 0x000A937C
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

		// Token: 0x060045AB RID: 17835 RVA: 0x000AB185 File Offset: 0x000A9385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CircumFluenceTaskRewardResponse);
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x000AB193 File Offset: 0x000A9393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CircumFluenceTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x000AB1C4 File Offset: 0x000A93C4
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

		// Token: 0x060045AE RID: 17838 RVA: 0x000AB209 File Offset: 0x000A9409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x000AB216 File Offset: 0x000A9416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x000AB21F File Offset: 0x000A941F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x000AB254 File Offset: 0x000A9454
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

		// Token: 0x060045B2 RID: 17842 RVA: 0x000AB292 File Offset: 0x000A9492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CircumFluenceTaskRewardResponse other)
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

		// Token: 0x060045B3 RID: 17843 RVA: 0x000AB2C3 File Offset: 0x000A94C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x000AB2CC File Offset: 0x000A94CC
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002F5C RID: 12124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F5D RID: 12125
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002F5E RID: 12126
		private ErrorCode errorCode_;
	}
}
