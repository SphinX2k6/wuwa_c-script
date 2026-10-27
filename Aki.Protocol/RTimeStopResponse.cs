using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200113C RID: 4412
	[NetMessage(EMessageId.RTimeStopResponse)]
	public sealed class RTimeStopResponse : IMessage<RTimeStopResponse>, IMessage, IEquatable<RTimeStopResponse>, IDeepCloneable<RTimeStopResponse>, IBufferMessage
	{
		// Token: 0x06017874 RID: 96372 RVA: 0x0036AAA0 File Offset: 0x00368CA0
		[NullableContext(1)]
		public static RTimeStopResponse Create()
		{
			return new RTimeStopResponse();
		}

		// Token: 0x17004EF7 RID: 20215
		// (get) Token: 0x06017875 RID: 96373 RVA: 0x0036AAA7 File Offset: 0x00368CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EF8 RID: 20216
		// (get) Token: 0x06017876 RID: 96374 RVA: 0x0036AAAA File Offset: 0x00368CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopResponse.Descriptor;
			}
		}

		// Token: 0x06017877 RID: 96375 RVA: 0x0036AAB1 File Offset: 0x00368CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopResponse()
		{
		}

		// Token: 0x06017878 RID: 96376 RVA: 0x0036AAB9 File Offset: 0x00368CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopResponse(RTimeStopResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017879 RID: 96377 RVA: 0x0036AADE File Offset: 0x00368CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopResponse Clone()
		{
			return new RTimeStopResponse(this);
		}

		// Token: 0x17004EF9 RID: 20217
		// (get) Token: 0x0601787A RID: 96378 RVA: 0x0036AAE6 File Offset: 0x00368CE6
		// (set) Token: 0x0601787B RID: 96379 RVA: 0x0036AAEE File Offset: 0x00368CEE
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

		// Token: 0x0601787C RID: 96380 RVA: 0x0036AAF7 File Offset: 0x00368CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopResponse);
		}

		// Token: 0x0601787D RID: 96381 RVA: 0x0036AB05 File Offset: 0x00368D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601787E RID: 96382 RVA: 0x0036AB34 File Offset: 0x00368D34
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

		// Token: 0x0601787F RID: 96383 RVA: 0x0036AB79 File Offset: 0x00368D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017880 RID: 96384 RVA: 0x0036AB86 File Offset: 0x00368D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017881 RID: 96385 RVA: 0x0036AB8F File Offset: 0x00368D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017882 RID: 96386 RVA: 0x0036ABC4 File Offset: 0x00368DC4
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

		// Token: 0x06017883 RID: 96387 RVA: 0x0036AC02 File Offset: 0x00368E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopResponse other)
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

		// Token: 0x06017884 RID: 96388 RVA: 0x0036AC33 File Offset: 0x00368E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017885 RID: 96389 RVA: 0x0036AC3C File Offset: 0x00368E3C
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008BCA RID: 35786
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BCB RID: 35787
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04008BCC RID: 35788
		private ErrorCode errorCode_;
	}
}
