using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005EE RID: 1518
	[NetMessage(EMessageId.FlowSeqSetPlayerPosResponse)]
	public sealed class FlowSeqSetPlayerPosResponse : IMessage<FlowSeqSetPlayerPosResponse>, IMessage, IEquatable<FlowSeqSetPlayerPosResponse>, IDeepCloneable<FlowSeqSetPlayerPosResponse>, IBufferMessage
	{
		// Token: 0x06008CEF RID: 36079 RVA: 0x00156406 File Offset: 0x00154606
		[NullableContext(1)]
		public static FlowSeqSetPlayerPosResponse Create()
		{
			return new FlowSeqSetPlayerPosResponse();
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06008CF0 RID: 36080 RVA: 0x0015640D File Offset: 0x0015460D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06008CF1 RID: 36081 RVA: 0x00156410 File Offset: 0x00154610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowSeqSetPlayerPosResponse.Descriptor;
			}
		}

		// Token: 0x06008CF2 RID: 36082 RVA: 0x00156417 File Offset: 0x00154617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowSeqSetPlayerPosResponse()
		{
		}

		// Token: 0x06008CF3 RID: 36083 RVA: 0x0015641F File Offset: 0x0015461F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowSeqSetPlayerPosResponse(FlowSeqSetPlayerPosResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CF4 RID: 36084 RVA: 0x00156444 File Offset: 0x00154644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowSeqSetPlayerPosResponse Clone()
		{
			return new FlowSeqSetPlayerPosResponse(this);
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06008CF5 RID: 36085 RVA: 0x0015644C File Offset: 0x0015464C
		// (set) Token: 0x06008CF6 RID: 36086 RVA: 0x00156454 File Offset: 0x00154654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06008CF7 RID: 36087 RVA: 0x0015645D File Offset: 0x0015465D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowSeqSetPlayerPosResponse);
		}

		// Token: 0x06008CF8 RID: 36088 RVA: 0x0015646B File Offset: 0x0015466B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowSeqSetPlayerPosResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CF9 RID: 36089 RVA: 0x0015649C File Offset: 0x0015469C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CFA RID: 36090 RVA: 0x001564E1 File Offset: 0x001546E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008CFB RID: 36091 RVA: 0x001564EE File Offset: 0x001546EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CFC RID: 36092 RVA: 0x001564F7 File Offset: 0x001546F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CFD RID: 36093 RVA: 0x0015652C File Offset: 0x0015472C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x0015656A File Offset: 0x0015476A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowSeqSetPlayerPosResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CFF RID: 36095 RVA: 0x0015659B File Offset: 0x0015479B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D00 RID: 36096 RVA: 0x001565A4 File Offset: 0x001547A4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004547 RID: 17735
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004548 RID: 17736
		public const int CodeFieldNumber = 13;

		// Token: 0x04004549 RID: 17737
		private ErrorCode code_;
	}
}
