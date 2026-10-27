using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001045 RID: 4165
	[NetMessage(EMessageId.RogueWeeklyResultResponse)]
	public sealed class RogueWeeklyResultResponse : IMessage<RogueWeeklyResultResponse>, IMessage, IEquatable<RogueWeeklyResultResponse>, IDeepCloneable<RogueWeeklyResultResponse>, IBufferMessage
	{
		// Token: 0x06016413 RID: 91155 RVA: 0x0033B91E File Offset: 0x00339B1E
		[NullableContext(1)]
		public static RogueWeeklyResultResponse Create()
		{
			return new RogueWeeklyResultResponse();
		}

		// Token: 0x17004A66 RID: 19046
		// (get) Token: 0x06016414 RID: 91156 RVA: 0x0033B925 File Offset: 0x00339B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A67 RID: 19047
		// (get) Token: 0x06016415 RID: 91157 RVA: 0x0033B928 File Offset: 0x00339B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyResultResponse.Descriptor;
			}
		}

		// Token: 0x06016416 RID: 91158 RVA: 0x0033B92F File Offset: 0x00339B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultResponse()
		{
		}

		// Token: 0x06016417 RID: 91159 RVA: 0x0033B937 File Offset: 0x00339B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultResponse(RogueWeeklyResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016418 RID: 91160 RVA: 0x0033B95C File Offset: 0x00339B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultResponse Clone()
		{
			return new RogueWeeklyResultResponse(this);
		}

		// Token: 0x17004A68 RID: 19048
		// (get) Token: 0x06016419 RID: 91161 RVA: 0x0033B964 File Offset: 0x00339B64
		// (set) Token: 0x0601641A RID: 91162 RVA: 0x0033B96C File Offset: 0x00339B6C
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

		// Token: 0x0601641B RID: 91163 RVA: 0x0033B975 File Offset: 0x00339B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyResultResponse);
		}

		// Token: 0x0601641C RID: 91164 RVA: 0x0033B983 File Offset: 0x00339B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601641D RID: 91165 RVA: 0x0033B9B4 File Offset: 0x00339BB4
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

		// Token: 0x0601641E RID: 91166 RVA: 0x0033B9F9 File Offset: 0x00339BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601641F RID: 91167 RVA: 0x0033BA06 File Offset: 0x00339C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016420 RID: 91168 RVA: 0x0033BA0F File Offset: 0x00339C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016421 RID: 91169 RVA: 0x0033BA44 File Offset: 0x00339C44
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

		// Token: 0x06016422 RID: 91170 RVA: 0x0033BA82 File Offset: 0x00339C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyResultResponse other)
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

		// Token: 0x06016423 RID: 91171 RVA: 0x0033BAB3 File Offset: 0x00339CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016424 RID: 91172 RVA: 0x0033BABC File Offset: 0x00339CBC
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400851C RID: 34076
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400851D RID: 34077
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400851E RID: 34078
		private ErrorCode errorCode_;
	}
}
