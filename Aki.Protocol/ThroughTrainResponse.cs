using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D9 RID: 5081
	[NetMessage(EMessageId.ThroughTrainResponse)]
	public sealed class ThroughTrainResponse : IMessage<ThroughTrainResponse>, IMessage, IEquatable<ThroughTrainResponse>, IDeepCloneable<ThroughTrainResponse>, IBufferMessage
	{
		// Token: 0x0601B07C RID: 110716 RVA: 0x003EF665 File Offset: 0x003ED865
		[NullableContext(1)]
		public static ThroughTrainResponse Create()
		{
			return new ThroughTrainResponse();
		}

		// Token: 0x17005B87 RID: 23431
		// (get) Token: 0x0601B07D RID: 110717 RVA: 0x003EF66C File Offset: 0x003ED86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B88 RID: 23432
		// (get) Token: 0x0601B07E RID: 110718 RVA: 0x003EF66F File Offset: 0x003ED86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainResponse.Descriptor;
			}
		}

		// Token: 0x0601B07F RID: 110719 RVA: 0x003EF676 File Offset: 0x003ED876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainResponse()
		{
		}

		// Token: 0x0601B080 RID: 110720 RVA: 0x003EF67E File Offset: 0x003ED87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainResponse(ThroughTrainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B081 RID: 110721 RVA: 0x003EF6A3 File Offset: 0x003ED8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainResponse Clone()
		{
			return new ThroughTrainResponse(this);
		}

		// Token: 0x17005B89 RID: 23433
		// (get) Token: 0x0601B082 RID: 110722 RVA: 0x003EF6AB File Offset: 0x003ED8AB
		// (set) Token: 0x0601B083 RID: 110723 RVA: 0x003EF6B3 File Offset: 0x003ED8B3
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

		// Token: 0x0601B084 RID: 110724 RVA: 0x003EF6BC File Offset: 0x003ED8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainResponse);
		}

		// Token: 0x0601B085 RID: 110725 RVA: 0x003EF6CA File Offset: 0x003ED8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B086 RID: 110726 RVA: 0x003EF6F8 File Offset: 0x003ED8F8
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

		// Token: 0x0601B087 RID: 110727 RVA: 0x003EF73D File Offset: 0x003ED93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B088 RID: 110728 RVA: 0x003EF74A File Offset: 0x003ED94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B089 RID: 110729 RVA: 0x003EF753 File Offset: 0x003ED953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B08A RID: 110730 RVA: 0x003EF788 File Offset: 0x003ED988
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

		// Token: 0x0601B08B RID: 110731 RVA: 0x003EF7C6 File Offset: 0x003ED9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainResponse other)
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

		// Token: 0x0601B08C RID: 110732 RVA: 0x003EF7F7 File Offset: 0x003ED9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B08D RID: 110733 RVA: 0x003EF800 File Offset: 0x003EDA00
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009DE3 RID: 40419
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DE4 RID: 40420
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04009DE5 RID: 40421
		private ErrorCode errorCode_;
	}
}
