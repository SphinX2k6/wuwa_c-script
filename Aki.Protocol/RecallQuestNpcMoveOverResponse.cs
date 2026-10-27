using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC4 RID: 3780
	[NetMessage(EMessageId.RecallQuestNpcMoveOverResponse)]
	public sealed class RecallQuestNpcMoveOverResponse : IMessage<RecallQuestNpcMoveOverResponse>, IMessage, IEquatable<RecallQuestNpcMoveOverResponse>, IDeepCloneable<RecallQuestNpcMoveOverResponse>, IBufferMessage
	{
		// Token: 0x06014455 RID: 83029 RVA: 0x002F26A9 File Offset: 0x002F08A9
		[NullableContext(1)]
		public static RecallQuestNpcMoveOverResponse Create()
		{
			return new RecallQuestNpcMoveOverResponse();
		}

		// Token: 0x17004365 RID: 17253
		// (get) Token: 0x06014456 RID: 83030 RVA: 0x002F26B0 File Offset: 0x002F08B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004366 RID: 17254
		// (get) Token: 0x06014457 RID: 83031 RVA: 0x002F26B3 File Offset: 0x002F08B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestNpcMoveOverResponse.Descriptor;
			}
		}

		// Token: 0x06014458 RID: 83032 RVA: 0x002F26BA File Offset: 0x002F08BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverResponse()
		{
		}

		// Token: 0x06014459 RID: 83033 RVA: 0x002F26C2 File Offset: 0x002F08C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverResponse(RecallQuestNpcMoveOverResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601445A RID: 83034 RVA: 0x002F26E7 File Offset: 0x002F08E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverResponse Clone()
		{
			return new RecallQuestNpcMoveOverResponse(this);
		}

		// Token: 0x17004367 RID: 17255
		// (get) Token: 0x0601445B RID: 83035 RVA: 0x002F26EF File Offset: 0x002F08EF
		// (set) Token: 0x0601445C RID: 83036 RVA: 0x002F26F7 File Offset: 0x002F08F7
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

		// Token: 0x0601445D RID: 83037 RVA: 0x002F2700 File Offset: 0x002F0900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestNpcMoveOverResponse);
		}

		// Token: 0x0601445E RID: 83038 RVA: 0x002F270E File Offset: 0x002F090E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestNpcMoveOverResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601445F RID: 83039 RVA: 0x002F273C File Offset: 0x002F093C
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

		// Token: 0x06014460 RID: 83040 RVA: 0x002F2781 File Offset: 0x002F0981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014461 RID: 83041 RVA: 0x002F278E File Offset: 0x002F098E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014462 RID: 83042 RVA: 0x002F2797 File Offset: 0x002F0997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014463 RID: 83043 RVA: 0x002F27CC File Offset: 0x002F09CC
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

		// Token: 0x06014464 RID: 83044 RVA: 0x002F280A File Offset: 0x002F0A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestNpcMoveOverResponse other)
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

		// Token: 0x06014465 RID: 83045 RVA: 0x002F283B File Offset: 0x002F0A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014466 RID: 83046 RVA: 0x002F2844 File Offset: 0x002F0A44
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B39 RID: 31545
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B3A RID: 31546
		public const int ErrorIdFieldNumber = 8;

		// Token: 0x04007B3B RID: 31547
		private ErrorCode errorId_;
	}
}
