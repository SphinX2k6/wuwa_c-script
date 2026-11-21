using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000903 RID: 2307
	[NetMessage(EMessageId.LevelSequenceFrameEventActionResponse)]
	public sealed class LevelSequenceFrameEventActionResponse : IMessage<LevelSequenceFrameEventActionResponse>, IMessage, IEquatable<LevelSequenceFrameEventActionResponse>, IDeepCloneable<LevelSequenceFrameEventActionResponse>, IBufferMessage
	{
		// Token: 0x0600CC04 RID: 52228 RVA: 0x001E182F File Offset: 0x001DFA2F
		[NullableContext(1)]
		public static LevelSequenceFrameEventActionResponse Create()
		{
			return new LevelSequenceFrameEventActionResponse();
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x0600CC05 RID: 52229 RVA: 0x001E1836 File Offset: 0x001DFA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x0600CC06 RID: 52230 RVA: 0x001E1839 File Offset: 0x001DFA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelSequenceFrameEventActionResponse.Descriptor;
			}
		}

		// Token: 0x0600CC07 RID: 52231 RVA: 0x001E1840 File Offset: 0x001DFA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionResponse()
		{
		}

		// Token: 0x0600CC08 RID: 52232 RVA: 0x001E1848 File Offset: 0x001DFA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionResponse(LevelSequenceFrameEventActionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC09 RID: 52233 RVA: 0x001E186D File Offset: 0x001DFA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelSequenceFrameEventActionResponse Clone()
		{
			return new LevelSequenceFrameEventActionResponse(this);
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x0600CC0A RID: 52234 RVA: 0x001E1875 File Offset: 0x001DFA75
		// (set) Token: 0x0600CC0B RID: 52235 RVA: 0x001E187D File Offset: 0x001DFA7D
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

		// Token: 0x0600CC0C RID: 52236 RVA: 0x001E1886 File Offset: 0x001DFA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelSequenceFrameEventActionResponse);
		}

		// Token: 0x0600CC0D RID: 52237 RVA: 0x001E1894 File Offset: 0x001DFA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelSequenceFrameEventActionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC0E RID: 52238 RVA: 0x001E18C4 File Offset: 0x001DFAC4
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

		// Token: 0x0600CC0F RID: 52239 RVA: 0x001E1909 File Offset: 0x001DFB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC10 RID: 52240 RVA: 0x001E1916 File Offset: 0x001DFB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC11 RID: 52241 RVA: 0x001E191F File Offset: 0x001DFB1F
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

		// Token: 0x0600CC12 RID: 52242 RVA: 0x001E1954 File Offset: 0x001DFB54
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

		// Token: 0x0600CC13 RID: 52243 RVA: 0x001E1992 File Offset: 0x001DFB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelSequenceFrameEventActionResponse other)
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

		// Token: 0x0600CC14 RID: 52244 RVA: 0x001E19C3 File Offset: 0x001DFBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC15 RID: 52245 RVA: 0x001E19CC File Offset: 0x001DFBCC
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

		// Token: 0x040056E7 RID: 22247
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056E8 RID: 22248
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040056E9 RID: 22249
		private ErrorCode errorCode_;
	}
}
