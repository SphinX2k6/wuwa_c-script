using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DA RID: 5082
	[NetMessage(EMessageId.TraceRecallQuestResponse)]
	public sealed class TraceRecallQuestResponse : IMessage<TraceRecallQuestResponse>, IMessage, IEquatable<TraceRecallQuestResponse>, IDeepCloneable<TraceRecallQuestResponse>, IBufferMessage
	{
		// Token: 0x0601AF25 RID: 110373 RVA: 0x003E7A47 File Offset: 0x003E5C47
		[NullableContext(1)]
		public static TraceRecallQuestResponse Create()
		{
			return new TraceRecallQuestResponse();
		}

		// Token: 0x17005ADB RID: 23259
		// (get) Token: 0x0601AF26 RID: 110374 RVA: 0x003E7A4E File Offset: 0x003E5C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ADC RID: 23260
		// (get) Token: 0x0601AF27 RID: 110375 RVA: 0x003E7A51 File Offset: 0x003E5C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceRecallQuestResponse.Descriptor;
			}
		}

		// Token: 0x0601AF28 RID: 110376 RVA: 0x003E7A58 File Offset: 0x003E5C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestResponse()
		{
		}

		// Token: 0x0601AF29 RID: 110377 RVA: 0x003E7A60 File Offset: 0x003E5C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestResponse(TraceRecallQuestResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF2A RID: 110378 RVA: 0x003E7A85 File Offset: 0x003E5C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestResponse Clone()
		{
			return new TraceRecallQuestResponse(this);
		}

		// Token: 0x17005ADD RID: 23261
		// (get) Token: 0x0601AF2B RID: 110379 RVA: 0x003E7A8D File Offset: 0x003E5C8D
		// (set) Token: 0x0601AF2C RID: 110380 RVA: 0x003E7A95 File Offset: 0x003E5C95
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

		// Token: 0x0601AF2D RID: 110381 RVA: 0x003E7A9E File Offset: 0x003E5C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceRecallQuestResponse);
		}

		// Token: 0x0601AF2E RID: 110382 RVA: 0x003E7AAC File Offset: 0x003E5CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceRecallQuestResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF2F RID: 110383 RVA: 0x003E7ADC File Offset: 0x003E5CDC
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

		// Token: 0x0601AF30 RID: 110384 RVA: 0x003E7B21 File Offset: 0x003E5D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF31 RID: 110385 RVA: 0x003E7B2E File Offset: 0x003E5D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF32 RID: 110386 RVA: 0x003E7B37 File Offset: 0x003E5D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF33 RID: 110387 RVA: 0x003E7B6C File Offset: 0x003E5D6C
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

		// Token: 0x0601AF34 RID: 110388 RVA: 0x003E7BAA File Offset: 0x003E5DAA
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

		// Token: 0x0601AF35 RID: 110389 RVA: 0x003E7BDB File Offset: 0x003E5DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF36 RID: 110390 RVA: 0x003E7BE4 File Offset: 0x003E5DE4
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009C2D RID: 39981
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C2E RID: 39982
		public const int ErrorIdFieldNumber = 5;

		// Token: 0x04009C2F RID: 39983
		private ErrorCode errorId_;
	}
}
