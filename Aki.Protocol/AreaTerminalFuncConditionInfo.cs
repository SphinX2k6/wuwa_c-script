using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010F RID: 271
	public sealed class AreaTerminalFuncConditionInfo : IMessage<AreaTerminalFuncConditionInfo>, IMessage, IEquatable<AreaTerminalFuncConditionInfo>, IDeepCloneable<AreaTerminalFuncConditionInfo>, IBufferMessage
	{
		// Token: 0x060025AF RID: 9647 RVA: 0x00064A84 File Offset: 0x00062C84
		[NullableContext(1)]
		public static AreaTerminalFuncConditionInfo Create()
		{
			return new AreaTerminalFuncConditionInfo();
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x00064A8B File Offset: 0x00062C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AreaTerminalFuncConditionInfo> Parser
		{
			get
			{
				return AreaTerminalFuncConditionInfo._parser;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x00064A92 File Offset: 0x00062C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x00064A95 File Offset: 0x00062C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaTerminalFuncConditionInfo.Descriptor;
			}
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00064A9C File Offset: 0x00062C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalFuncConditionInfo()
		{
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00064AAF File Offset: 0x00062CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalFuncConditionInfo(AreaTerminalFuncConditionInfo other) : this()
		{
			this.funcId_ = other.funcId_;
			this.finishConditionIds_ = other.finishConditionIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00064AE5 File Offset: 0x00062CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalFuncConditionInfo Clone()
		{
			return new AreaTerminalFuncConditionInfo(this);
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060025B6 RID: 9654 RVA: 0x00064AED File Offset: 0x00062CED
		// (set) Token: 0x060025B7 RID: 9655 RVA: 0x00064AF5 File Offset: 0x00062CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncId
		{
			get
			{
				return this.funcId_;
			}
			set
			{
				this.funcId_ = value;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x00064AFE File Offset: 0x00062CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishConditionIds
		{
			get
			{
				return this.finishConditionIds_;
			}
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x00064B06 File Offset: 0x00062D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaTerminalFuncConditionInfo);
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x00064B14 File Offset: 0x00062D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaTerminalFuncConditionInfo other)
		{
			return other != null && (other == this || (this.FuncId == other.FuncId && this.finishConditionIds_.Equals(other.finishConditionIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00064B64 File Offset: 0x00062D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FuncId != 0)
			{
				num ^= this.FuncId.GetHashCode();
			}
			num ^= this.finishConditionIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00064BB1 File Offset: 0x00062DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x00064BBE File Offset: 0x00062DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x00064BC8 File Offset: 0x00062DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FuncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FuncId);
			}
			this.finishConditionIds_.WriteTo(ref output, AreaTerminalFuncConditionInfo._repeated_finishConditionIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00064C18 File Offset: 0x00062E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FuncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncId);
			}
			num += this.finishConditionIds_.CalculateSize(AreaTerminalFuncConditionInfo._repeated_finishConditionIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x00064C6C File Offset: 0x00062E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AreaTerminalFuncConditionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FuncId != 0)
			{
				this.FuncId = other.FuncId;
			}
			this.finishConditionIds_.Add(other.finishConditionIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x00064CB9 File Offset: 0x00062EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00064CC4 File Offset: 0x00062EC4
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.finishConditionIds_.AddEntriesFrom(ref input, AreaTerminalFuncConditionInfo._repeated_finishConditionIds_codec);
					}
				}
				else
				{
					this.FuncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400262A RID: 9770
		private static readonly MessageParser<AreaTerminalFuncConditionInfo> _parser = new MessageParser<AreaTerminalFuncConditionInfo>(() => new AreaTerminalFuncConditionInfo());

		// Token: 0x0400262B RID: 9771
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400262C RID: 9772
		public const int FuncIdFieldNumber = 1;

		// Token: 0x0400262D RID: 9773
		private int funcId_;

		// Token: 0x0400262E RID: 9774
		public const int FinishConditionIdsFieldNumber = 2;

		// Token: 0x0400262F RID: 9775
		private static readonly FieldCodec<int> _repeated_finishConditionIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002630 RID: 9776
		private readonly RepeatedField<int> finishConditionIds_ = new RepeatedField<int>();
	}
}
