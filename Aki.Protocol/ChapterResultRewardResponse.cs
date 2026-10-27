using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026E RID: 622
	[NetMessage(EMessageId.ChapterResultRewardResponse)]
	public sealed class ChapterResultRewardResponse : IMessage<ChapterResultRewardResponse>, IMessage, IEquatable<ChapterResultRewardResponse>, IDeepCloneable<ChapterResultRewardResponse>, IBufferMessage
	{
		// Token: 0x0600419B RID: 16795 RVA: 0x000A139A File Offset: 0x0009F59A
		[NullableContext(1)]
		public static ChapterResultRewardResponse Create()
		{
			return new ChapterResultRewardResponse();
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x0600419C RID: 16796 RVA: 0x000A13A1 File Offset: 0x0009F5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x0600419D RID: 16797 RVA: 0x000A13A4 File Offset: 0x0009F5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChapterResultRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x000A13AB File Offset: 0x0009F5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardResponse()
		{
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x000A13B3 File Offset: 0x0009F5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardResponse(ChapterResultRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x000A13D8 File Offset: 0x0009F5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardResponse Clone()
		{
			return new ChapterResultRewardResponse(this);
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060041A1 RID: 16801 RVA: 0x000A13E0 File Offset: 0x0009F5E0
		// (set) Token: 0x060041A2 RID: 16802 RVA: 0x000A13E8 File Offset: 0x0009F5E8
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

		// Token: 0x060041A3 RID: 16803 RVA: 0x000A13F1 File Offset: 0x0009F5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChapterResultRewardResponse);
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x000A13FF File Offset: 0x0009F5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChapterResultRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x000A1430 File Offset: 0x0009F630
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

		// Token: 0x060041A6 RID: 16806 RVA: 0x000A1475 File Offset: 0x0009F675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x000A1482 File Offset: 0x0009F682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x000A148B File Offset: 0x0009F68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x000A14C0 File Offset: 0x0009F6C0
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

		// Token: 0x060041AA RID: 16810 RVA: 0x000A14FE File Offset: 0x0009F6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChapterResultRewardResponse other)
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

		// Token: 0x060041AB RID: 16811 RVA: 0x000A152F File Offset: 0x0009F72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x000A1538 File Offset: 0x0009F738
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002DCA RID: 11722
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DCB RID: 11723
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04002DCC RID: 11724
		private ErrorCode errorCode_;
	}
}
