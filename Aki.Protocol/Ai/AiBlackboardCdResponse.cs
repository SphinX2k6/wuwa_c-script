using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016A6 RID: 5798
	[NetMessage(EMessageId.AiBlackboardCdResponse)]
	public sealed class AiBlackboardCdResponse : IMessage<AiBlackboardCdResponse>, IMessage, IEquatable<AiBlackboardCdResponse>, IDeepCloneable<AiBlackboardCdResponse>, IBufferMessage
	{
		// Token: 0x0601D0DD RID: 119005 RVA: 0x00440AF6 File Offset: 0x0043ECF6
		[NullableContext(1)]
		public static AiBlackboardCdResponse Create()
		{
			return new AiBlackboardCdResponse();
		}

		// Token: 0x17006297 RID: 25239
		// (get) Token: 0x0601D0DE RID: 119006 RVA: 0x00440AFD File Offset: 0x0043ECFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006298 RID: 25240
		// (get) Token: 0x0601D0DF RID: 119007 RVA: 0x00440B00 File Offset: 0x0043ED00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardCdResponse.Descriptor;
			}
		}

		// Token: 0x0601D0E0 RID: 119008 RVA: 0x00440B07 File Offset: 0x0043ED07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdResponse()
		{
		}

		// Token: 0x0601D0E1 RID: 119009 RVA: 0x00440B0F File Offset: 0x0043ED0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdResponse(AiBlackboardCdResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D0E2 RID: 119010 RVA: 0x00440B34 File Offset: 0x0043ED34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdResponse Clone()
		{
			return new AiBlackboardCdResponse(this);
		}

		// Token: 0x17006299 RID: 25241
		// (get) Token: 0x0601D0E3 RID: 119011 RVA: 0x00440B3C File Offset: 0x0043ED3C
		// (set) Token: 0x0601D0E4 RID: 119012 RVA: 0x00440B44 File Offset: 0x0043ED44
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

		// Token: 0x0601D0E5 RID: 119013 RVA: 0x00440B4D File Offset: 0x0043ED4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardCdResponse);
		}

		// Token: 0x0601D0E6 RID: 119014 RVA: 0x00440B5B File Offset: 0x0043ED5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardCdResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D0E7 RID: 119015 RVA: 0x00440B8C File Offset: 0x0043ED8C
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

		// Token: 0x0601D0E8 RID: 119016 RVA: 0x00440BD1 File Offset: 0x0043EDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D0E9 RID: 119017 RVA: 0x00440BDE File Offset: 0x0043EDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D0EA RID: 119018 RVA: 0x00440BE7 File Offset: 0x0043EDE7
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

		// Token: 0x0601D0EB RID: 119019 RVA: 0x00440C1C File Offset: 0x0043EE1C
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

		// Token: 0x0601D0EC RID: 119020 RVA: 0x00440C5A File Offset: 0x0043EE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardCdResponse other)
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

		// Token: 0x0601D0ED RID: 119021 RVA: 0x00440C8B File Offset: 0x0043EE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D0EE RID: 119022 RVA: 0x00440C94 File Offset: 0x0043EE94
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

		// Token: 0x0400C41A RID: 50202
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C41B RID: 50203
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400C41C RID: 50204
		private ErrorCode errorCode_;
	}
}
