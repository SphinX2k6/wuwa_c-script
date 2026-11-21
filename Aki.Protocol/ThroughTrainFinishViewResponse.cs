using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D6 RID: 5078
	[NetMessage(EMessageId.ThroughTrainFinishViewResponse)]
	public sealed class ThroughTrainFinishViewResponse : IMessage<ThroughTrainFinishViewResponse>, IMessage, IEquatable<ThroughTrainFinishViewResponse>, IDeepCloneable<ThroughTrainFinishViewResponse>, IBufferMessage
	{
		// Token: 0x0601B046 RID: 110662 RVA: 0x003EF0D5 File Offset: 0x003ED2D5
		[NullableContext(1)]
		public static ThroughTrainFinishViewResponse Create()
		{
			return new ThroughTrainFinishViewResponse();
		}

		// Token: 0x17005B7E RID: 23422
		// (get) Token: 0x0601B047 RID: 110663 RVA: 0x003EF0DC File Offset: 0x003ED2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B7F RID: 23423
		// (get) Token: 0x0601B048 RID: 110664 RVA: 0x003EF0DF File Offset: 0x003ED2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainFinishViewResponse.Descriptor;
			}
		}

		// Token: 0x0601B049 RID: 110665 RVA: 0x003EF0E6 File Offset: 0x003ED2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewResponse()
		{
		}

		// Token: 0x0601B04A RID: 110666 RVA: 0x003EF0EE File Offset: 0x003ED2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewResponse(ThroughTrainFinishViewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B04B RID: 110667 RVA: 0x003EF113 File Offset: 0x003ED313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewResponse Clone()
		{
			return new ThroughTrainFinishViewResponse(this);
		}

		// Token: 0x17005B80 RID: 23424
		// (get) Token: 0x0601B04C RID: 110668 RVA: 0x003EF11B File Offset: 0x003ED31B
		// (set) Token: 0x0601B04D RID: 110669 RVA: 0x003EF123 File Offset: 0x003ED323
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

		// Token: 0x0601B04E RID: 110670 RVA: 0x003EF12C File Offset: 0x003ED32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainFinishViewResponse);
		}

		// Token: 0x0601B04F RID: 110671 RVA: 0x003EF13A File Offset: 0x003ED33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainFinishViewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B050 RID: 110672 RVA: 0x003EF168 File Offset: 0x003ED368
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

		// Token: 0x0601B051 RID: 110673 RVA: 0x003EF1AD File Offset: 0x003ED3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B052 RID: 110674 RVA: 0x003EF1BA File Offset: 0x003ED3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B053 RID: 110675 RVA: 0x003EF1C3 File Offset: 0x003ED3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B054 RID: 110676 RVA: 0x003EF1F8 File Offset: 0x003ED3F8
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

		// Token: 0x0601B055 RID: 110677 RVA: 0x003EF236 File Offset: 0x003ED436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainFinishViewResponse other)
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

		// Token: 0x0601B056 RID: 110678 RVA: 0x003EF267 File Offset: 0x003ED467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B057 RID: 110679 RVA: 0x003EF270 File Offset: 0x003ED470
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009DDA RID: 40410
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DDB RID: 40411
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009DDC RID: 40412
		private ErrorCode errorCode_;
	}
}
