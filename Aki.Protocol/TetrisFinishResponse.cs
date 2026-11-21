using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C7 RID: 5063
	[NetMessage(EMessageId.TetrisFinishResponse)]
	public sealed class TetrisFinishResponse : IMessage<TetrisFinishResponse>, IMessage, IEquatable<TetrisFinishResponse>, IDeepCloneable<TetrisFinishResponse>, IBufferMessage
	{
		// Token: 0x0601AF23 RID: 110371 RVA: 0x003ECD53 File Offset: 0x003EAF53
		[NullableContext(1)]
		public static TetrisFinishResponse Create()
		{
			return new TetrisFinishResponse();
		}

		// Token: 0x17005B45 RID: 23365
		// (get) Token: 0x0601AF24 RID: 110372 RVA: 0x003ECD5A File Offset: 0x003EAF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B46 RID: 23366
		// (get) Token: 0x0601AF25 RID: 110373 RVA: 0x003ECD5D File Offset: 0x003EAF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisFinishResponse.Descriptor;
			}
		}

		// Token: 0x0601AF26 RID: 110374 RVA: 0x003ECD64 File Offset: 0x003EAF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishResponse()
		{
		}

		// Token: 0x0601AF27 RID: 110375 RVA: 0x003ECD6C File Offset: 0x003EAF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishResponse(TetrisFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF28 RID: 110376 RVA: 0x003ECD91 File Offset: 0x003EAF91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishResponse Clone()
		{
			return new TetrisFinishResponse(this);
		}

		// Token: 0x17005B47 RID: 23367
		// (get) Token: 0x0601AF29 RID: 110377 RVA: 0x003ECD99 File Offset: 0x003EAF99
		// (set) Token: 0x0601AF2A RID: 110378 RVA: 0x003ECDA1 File Offset: 0x003EAFA1
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

		// Token: 0x0601AF2B RID: 110379 RVA: 0x003ECDAA File Offset: 0x003EAFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisFinishResponse);
		}

		// Token: 0x0601AF2C RID: 110380 RVA: 0x003ECDB8 File Offset: 0x003EAFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF2D RID: 110381 RVA: 0x003ECDE8 File Offset: 0x003EAFE8
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

		// Token: 0x0601AF2E RID: 110382 RVA: 0x003ECE2D File Offset: 0x003EB02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF2F RID: 110383 RVA: 0x003ECE3A File Offset: 0x003EB03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF30 RID: 110384 RVA: 0x003ECE43 File Offset: 0x003EB043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF31 RID: 110385 RVA: 0x003ECE78 File Offset: 0x003EB078
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

		// Token: 0x0601AF32 RID: 110386 RVA: 0x003ECEB6 File Offset: 0x003EB0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TetrisFinishResponse other)
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

		// Token: 0x0601AF33 RID: 110387 RVA: 0x003ECEE7 File Offset: 0x003EB0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF34 RID: 110388 RVA: 0x003ECEF0 File Offset: 0x003EB0F0
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009D90 RID: 40336
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D91 RID: 40337
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009D92 RID: 40338
		private ErrorCode errorCode_;
	}
}
