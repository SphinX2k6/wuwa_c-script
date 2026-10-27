using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF1 RID: 4081
	[NetMessage(EMessageId.RogueResInstStartResponse)]
	public sealed class RogueResInstStartResponse : IMessage<RogueResInstStartResponse>, IMessage, IEquatable<RogueResInstStartResponse>, IDeepCloneable<RogueResInstStartResponse>, IBufferMessage
	{
		// Token: 0x06015D12 RID: 89362 RVA: 0x0032B5A1 File Offset: 0x003297A1
		[NullableContext(1)]
		public static RogueResInstStartResponse Create()
		{
			return new RogueResInstStartResponse();
		}

		// Token: 0x170048D7 RID: 18647
		// (get) Token: 0x06015D13 RID: 89363 RVA: 0x0032B5A8 File Offset: 0x003297A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048D8 RID: 18648
		// (get) Token: 0x06015D14 RID: 89364 RVA: 0x0032B5AB File Offset: 0x003297AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstStartResponse.Descriptor;
			}
		}

		// Token: 0x06015D15 RID: 89365 RVA: 0x0032B5B2 File Offset: 0x003297B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartResponse()
		{
		}

		// Token: 0x06015D16 RID: 89366 RVA: 0x0032B5BA File Offset: 0x003297BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartResponse(RogueResInstStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D17 RID: 89367 RVA: 0x0032B5DF File Offset: 0x003297DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartResponse Clone()
		{
			return new RogueResInstStartResponse(this);
		}

		// Token: 0x170048D9 RID: 18649
		// (get) Token: 0x06015D18 RID: 89368 RVA: 0x0032B5E7 File Offset: 0x003297E7
		// (set) Token: 0x06015D19 RID: 89369 RVA: 0x0032B5EF File Offset: 0x003297EF
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

		// Token: 0x06015D1A RID: 89370 RVA: 0x0032B5F8 File Offset: 0x003297F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstStartResponse);
		}

		// Token: 0x06015D1B RID: 89371 RVA: 0x0032B606 File Offset: 0x00329806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D1C RID: 89372 RVA: 0x0032B634 File Offset: 0x00329834
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

		// Token: 0x06015D1D RID: 89373 RVA: 0x0032B679 File Offset: 0x00329879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D1E RID: 89374 RVA: 0x0032B686 File Offset: 0x00329886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D1F RID: 89375 RVA: 0x0032B68F File Offset: 0x0032988F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D20 RID: 89376 RVA: 0x0032B6C4 File Offset: 0x003298C4
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

		// Token: 0x06015D21 RID: 89377 RVA: 0x0032B702 File Offset: 0x00329902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstStartResponse other)
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

		// Token: 0x06015D22 RID: 89378 RVA: 0x0032B733 File Offset: 0x00329933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D23 RID: 89379 RVA: 0x0032B73C File Offset: 0x0032993C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040082F2 RID: 33522
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082F3 RID: 33523
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040082F4 RID: 33524
		private ErrorCode errorCode_;
	}
}
