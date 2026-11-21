using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144D RID: 5197
	[NetMessage(EMessageId.TraceRecallQuestResponse)]
	public sealed class TraceRecallQuestResponse : IMessage<TraceRecallQuestResponse>, IMessage, IEquatable<TraceRecallQuestResponse>, IDeepCloneable<TraceRecallQuestResponse>, IBufferMessage
	{
		// Token: 0x0601B9B0 RID: 113072 RVA: 0x00402D13 File Offset: 0x00400F13
		[NullableContext(1)]
		public static TraceRecallQuestResponse Create()
		{
			return new TraceRecallQuestResponse();
		}

		// Token: 0x17005D70 RID: 23920
		// (get) Token: 0x0601B9B1 RID: 113073 RVA: 0x00402D1A File Offset: 0x00400F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D71 RID: 23921
		// (get) Token: 0x0601B9B2 RID: 113074 RVA: 0x00402D1D File Offset: 0x00400F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceRecallQuestResponse.Descriptor;
			}
		}

		// Token: 0x0601B9B3 RID: 113075 RVA: 0x00402D24 File Offset: 0x00400F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestResponse()
		{
		}

		// Token: 0x0601B9B4 RID: 113076 RVA: 0x00402D2C File Offset: 0x00400F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestResponse(TraceRecallQuestResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B9B5 RID: 113077 RVA: 0x00402D51 File Offset: 0x00400F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestResponse Clone()
		{
			return new TraceRecallQuestResponse(this);
		}

		// Token: 0x17005D72 RID: 23922
		// (get) Token: 0x0601B9B6 RID: 113078 RVA: 0x00402D59 File Offset: 0x00400F59
		// (set) Token: 0x0601B9B7 RID: 113079 RVA: 0x00402D61 File Offset: 0x00400F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0601B9B8 RID: 113080 RVA: 0x00402D6A File Offset: 0x00400F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceRecallQuestResponse);
		}

		// Token: 0x0601B9B9 RID: 113081 RVA: 0x00402D78 File Offset: 0x00400F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceRecallQuestResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B9BA RID: 113082 RVA: 0x00402DA8 File Offset: 0x00400FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B9BB RID: 113083 RVA: 0x00402DED File Offset: 0x00400FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B9BC RID: 113084 RVA: 0x00402DFA File Offset: 0x00400FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B9BD RID: 113085 RVA: 0x00402E03 File Offset: 0x00401003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B9BE RID: 113086 RVA: 0x00402E38 File Offset: 0x00401038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B9BF RID: 113087 RVA: 0x00402E76 File Offset: 0x00401076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceRecallQuestResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B9C0 RID: 113088 RVA: 0x00402EA7 File Offset: 0x004010A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B9C1 RID: 113089 RVA: 0x00402EB0 File Offset: 0x004010B0
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A074 RID: 41076
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A075 RID: 41077
		public const int ErrorIdFieldNumber = 10;

		// Token: 0x0400A076 RID: 41078
		private ErrorCode errorId_;
	}
}
